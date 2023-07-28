using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        SaveForm saveForm;

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

            // 배경색 설정 콤보박스 컬러값 데이터로 바인딩
            CB_imgBG.DataSource = typeof(Color).GetProperties()
    .Where(x => x.PropertyType == typeof(Color))
    .Select(x => x.GetValue(null)).ToList();

            CB_imgBG.MaxDropDownItems = 10;
            CB_imgBG.IntegralHeight = false;
            CB_imgBG.DrawMode = DrawMode.OwnerDrawFixed;
            CB_imgBG.DropDownStyle = ComboBoxStyle.DropDownList;

            // 세이브 폼 세팅
            saveForm = new SaveForm();
            saveForm.SelectedPath = Directory.GetCurrentDirectory();
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

                switch (ext)
                {
                    case ".i16":
                        check = DataExtract.I16Decompress(OFD_openImg.FileName, fort3Imgs);
                        break;
                    case ".img":
                    case ".spr":
                        check = DataExtract.ImgSprDecompress(OFD_openImg.FileName, fort3Imgs);
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
                    L_imgSize.Text = "0×0 px";

                    TB_offsetX.Text = "";
                    TB_offsetY.Text = "";
                    TB_rgbType.Text = "";
                }
            }
        }

        private void B_save_Click(object sender, EventArgs e)
        {
            var result =  saveForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                string folderName = Path.GetFileNameWithoutExtension(imgName);

                string path = Path.Combine(saveForm.SelectedPath, folderName);

                DirectoryInfo di = new DirectoryInfo(path);

                try
                {
                    // 폴더가 없다면 폴더 생성
                    if (di.Exists == false)
                    {
                        di.Create();
                    }

                    for (int a = 0; a < CLB_imgList.CheckedIndices.Count; a++)
                    {
                        int index = CLB_imgList.CheckedIndices[a];

                        for (int b = 0; b < fort3Imgs[index].ImgData.Length; b++)
                        {
                            if((fort3Imgs[index].ImgData[b].Data?.Length ?? 0) == 0)
                            {
                                continue;
                            }

                            DirectBitmap directBitmap = ImageConversion.Fort3ImgDraw(fort3Imgs[index], b);

                            // 저장될 이미지 제목
                            string fileName = Path.GetFileNameWithoutExtension(imgName) + string.Format("-{0:D4}", CLB_imgList.Items[index]);
                            // 이미지 레이어가 2개라면 뒤에 숫자를 붙여준다.
                            if (fort3Imgs[index].ImgData[1].Data != null)
                            {
                                fileName += string.Format("-{0}", b);
                            }
                            fileName += ".png";

                            //중복된 파일이 있다면
                            if (File.Exists(Path.Combine(path, fileName)))
                            {
                                // 덮어쓰기가 활성화 됐을 때만
                                if (saveForm.Overwrite == true)
                                {
                                    // 이미지 저장
                                    directBitmap?.Save(Path.Combine(path, fileName), ImageFormat.Png);
                                }
                            }
                            else
                            {
                                // 이미지 저장
                                directBitmap?.Save(Path.Combine(path, fileName), ImageFormat.Png);
                            }

                            directBitmap?.Dispose();
                        }
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
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
            // 배경색 설정 콤보박스내 데이터에 색상이 표시되게 다시 그리기
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = CB_imgBG.GetItemText(CB_imgBG.Items[e.Index]);
                var color = (Color)CB_imgBG.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 4);
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

                P_img.BackColor = color;
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
