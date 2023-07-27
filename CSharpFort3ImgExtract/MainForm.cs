using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFort3ImgExtract
{
    public partial class MainForm : Form
    {
        List<Fort3Img> fort3Imgs;
        DirectBitmap directBitmap;
        string imgName;

        public string ImgName
        {
            get => imgName;
            private set
            {
                imgName = value;

                if (value == null || value == string.Empty)
                {
                    L_openImg.Text = "불러온 이미지 없음";
                }
                else
                {
                    L_openImg.Text = value;
                }
            }
        }


        public MainForm()
        {
            InitializeComponent();
            ImgName = string.Empty;
            fort3Imgs = new List<Fort3Img>();

            CB_imgBG.DataSource = typeof(Color).GetProperties()
    .Where(x => x.PropertyType == typeof(Color))
    .Select(x => x.GetValue(null)).ToList();

            CB_imgBG.MaxDropDownItems = 10;
            CB_imgBG.IntegralHeight = false;
            CB_imgBG.DrawMode = DrawMode.OwnerDrawFixed;
            CB_imgBG.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void B_openImg_Click(object sender, EventArgs e)
        {
            OFD_openImg.FileName = imgName;

            DialogResult result = OFD_openImg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine(OFD_openImg.FileName);

                PB_img.Image = null;
                directBitmap?.Dispose();
                RTB_hex.Clear();

                CLB_imgList.Items.Clear();
                fort3Imgs.Clear();

                string ext = Path.GetExtension(OFD_openImg.FileName);
                ext = ext.ToLower();
                bool check = false;
                P_rgbType.Visible = false;

                switch (ext)
                {
                    case ".i16":
                        check = DataExtract.I16Decompress(OFD_openImg.FileName, fort3Imgs);
                        break;
                    case ".img":
                    case ".spr":
                        check = DataExtract.ImgSprDecompress(OFD_openImg.FileName, fort3Imgs);
                        P_rgbType.Visible = true;
                        break;
                    case ".tga":
                        break;
                }

                if (check)
                {
                    for (int i = 0; i < fort3Imgs.Count; i++)
                    {
                        CLB_imgList.Items.Add(i + 1, true);
                    }

                    CLB_imgList.SelectedIndex = 0;
                    ImgName = Path.GetFileName(OFD_openImg.FileName);
                }
                else
                {
                    ImgName = string.Empty;
                }
            }
        }

        private void B_save_Click(object sender, EventArgs e)
        {

        }

        private void CLB_imgList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CLB_imgList.SelectedIndex;
            Fort3Img img = null;
            int layer = 0;

            if (index != -1)
            {
                PB_img.Image = null;
                directBitmap?.Dispose();
                RTB_hex.Clear();

                img = fort3Imgs[index];

                TLP_imgLayer.Visible = img.ImgData[1].Data != null;

                if (RB_layer1.Checked && TLP_imgLayer.Visible)
                {
                    layer = 1;
                }

                if (tabControl1.SelectedIndex == 0)
                {
                    directBitmap = ImageConversion.Fort3ImgDraw(img, layer);
                    PB_img.Image = directBitmap?.Bitmap;
                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    string hexText = DataExtract.HexData(img.ImgData[layer].Data);
                    RTB_hex.Text = hexText;
                }
            }

            L_imgSize.Text = string.Format("{0}×{1} px",
                PB_img.Image?.Width ?? 0,
                PB_img.Image?.Height ?? 0);

            TB_offsetX.Text = img?.ImgData[layer].OffsetX.ToString() ?? "";
            TB_offsetY.Text = img?.ImgData[layer].OffsetY.ToString() ?? "";
            TB_rgbType.Text = img?.TypeValue.ToString() ?? "";
        }

        private void CLB_imgList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (CLB_imgList.CheckedItems.Count == 1
                && e.NewValue == CheckState.Unchecked)
            {
                B_save.Enabled = false;
            }
            else
            {
                B_save.Enabled = true;
            }

            if (!CB_allCheck.Focused)
            {
                if (CLB_imgList.CheckedItems.Count == CLB_imgList.Items.Count - 1
                && e.NewValue == CheckState.Checked)
                {
                    CB_allCheck.Checked = true;
                }
                else
                {
                    CB_allCheck.Checked = false;
                }
            }
        }

        private void CB_allCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_allCheck.Focused)
            {
                if (CB_allCheck.Checked)
                {
                    for (int i = 0; i < CLB_imgList.Items.Count; i++)
                    {
                        CLB_imgList.SetItemChecked(i, true);
                    }
                }
                else
                {
                    for (int i = 0; i < CLB_imgList.Items.Count; i++)
                    {
                        CLB_imgList.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void CB_imgBG_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = CB_imgBG.GetItemText(CB_imgBG.Items[e.Index]);
                var color = (Color)CB_imgBG.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, CB_imgBG.Font, r2,
                    CB_imgBG.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void CB_imgBG_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CB_imgBG.SelectedIndex;

            if(index != -1)
            {
                var color = (Color)CB_imgBG.Items[index];

                PB_img.BackColor = color;
                if(color == Color.Transparent)
                {
                    PB_img.BackgroundImage = Properties.Resources.imgBackground;
                }
                else
                {
                    PB_img.BackgroundImage = null;
                }
            }
        }
    }
}
