
namespace CSharpFort3ImgExtract
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.L_openImg = new System.Windows.Forms.Label();
            this.B_openImg = new System.Windows.Forms.Button();
            this.CB_allCheck = new System.Windows.Forms.CheckBox();
            this.B_save = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.P_imgInfo = new System.Windows.Forms.Panel();
            this.L_imgSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_offsetY = new System.Windows.Forms.TextBox();
            this.TB_offsetX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_imgBG = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TLP_imgLayer = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.RB_layer1 = new System.Windows.Forms.RadioButton();
            this.RB_layer0 = new System.Windows.Forms.RadioButton();
            this.P_img = new System.Windows.Forms.Panel();
            this.PB_img = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RTB_hex = new System.Windows.Forms.RichTextBox();
            this.CLB_imgList = new System.Windows.Forms.CheckedListBox();
            this.OFD_openImg = new System.Windows.Forms.OpenFileDialog();
            this.TB_rgbType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.P_imgInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TLP_imgLayer.SuspendLayout();
            this.P_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_openImg
            // 
            this.L_openImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_openImg.Location = new System.Drawing.Point(123, 12);
            this.L_openImg.Name = "L_openImg";
            this.L_openImg.Size = new System.Drawing.Size(665, 23);
            this.L_openImg.TabIndex = 8;
            this.L_openImg.Text = "불러온 이미지 없음";
            this.L_openImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // B_openImg
            // 
            this.B_openImg.Location = new System.Drawing.Point(12, 12);
            this.B_openImg.Name = "B_openImg";
            this.B_openImg.Size = new System.Drawing.Size(105, 23);
            this.B_openImg.TabIndex = 7;
            this.B_openImg.Text = "이미지 불러오기";
            this.B_openImg.UseVisualStyleBackColor = true;
            this.B_openImg.Click += new System.EventHandler(this.B_openImg_Click);
            // 
            // CB_allCheck
            // 
            this.CB_allCheck.AutoSize = true;
            this.CB_allCheck.Location = new System.Drawing.Point(12, 41);
            this.CB_allCheck.Name = "CB_allCheck";
            this.CB_allCheck.Size = new System.Drawing.Size(76, 16);
            this.CB_allCheck.TabIndex = 22;
            this.CB_allCheck.Text = "전체 선택";
            this.CB_allCheck.UseVisualStyleBackColor = true;
            this.CB_allCheck.CheckedChanged += new System.EventHandler(this.CB_allCheck_CheckedChanged);
            // 
            // B_save
            // 
            this.B_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_save.Enabled = false;
            this.B_save.Location = new System.Drawing.Point(12, 462);
            this.B_save.Name = "B_save";
            this.B_save.Size = new System.Drawing.Size(93, 49);
            this.B_save.TabIndex = 20;
            this.B_save.Text = "선택된 이미지 내보내기";
            this.B_save.UseVisualStyleBackColor = true;
            this.B_save.Click += new System.EventHandler(this.B_save_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(111, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 470);
            this.tabControl1.TabIndex = 23;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.CLB_imgList_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(669, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.P_imgInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.P_img, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 444);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // P_imgInfo
            // 
            this.P_imgInfo.BackColor = System.Drawing.SystemColors.Control;
            this.P_imgInfo.Controls.Add(this.TB_rgbType);
            this.P_imgInfo.Controls.Add(this.label3);
            this.P_imgInfo.Controls.Add(this.L_imgSize);
            this.P_imgInfo.Controls.Add(this.label2);
            this.P_imgInfo.Controls.Add(this.label1);
            this.P_imgInfo.Controls.Add(this.TB_offsetY);
            this.P_imgInfo.Controls.Add(this.TB_offsetX);
            this.P_imgInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_imgInfo.Location = new System.Drawing.Point(0, 419);
            this.P_imgInfo.Margin = new System.Windows.Forms.Padding(0);
            this.P_imgInfo.Name = "P_imgInfo";
            this.P_imgInfo.Size = new System.Drawing.Size(669, 25);
            this.P_imgInfo.TabIndex = 2;
            // 
            // L_imgSize
            // 
            this.L_imgSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.L_imgSize.Location = new System.Drawing.Point(445, 1);
            this.L_imgSize.Name = "L_imgSize";
            this.L_imgSize.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.L_imgSize.Size = new System.Drawing.Size(224, 22);
            this.L_imgSize.TabIndex = 10;
            this.L_imgSize.Text = "0×0 px";
            this.L_imgSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "offsetY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "offsetX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_offsetY
            // 
            this.TB_offsetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_offsetY.Location = new System.Drawing.Point(187, 2);
            this.TB_offsetY.Name = "TB_offsetY";
            this.TB_offsetY.ReadOnly = true;
            this.TB_offsetY.Size = new System.Drawing.Size(80, 21);
            this.TB_offsetY.TabIndex = 20;
            this.TB_offsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_offsetX
            // 
            this.TB_offsetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_offsetX.Location = new System.Drawing.Point(52, 2);
            this.TB_offsetX.Name = "TB_offsetX";
            this.TB_offsetX.ReadOnly = true;
            this.TB_offsetX.Size = new System.Drawing.Size(80, 21);
            this.TB_offsetX.TabIndex = 19;
            this.TB_offsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.CB_imgBG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TLP_imgLayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 25);
            this.panel1.TabIndex = 3;
            // 
            // CB_imgBG
            // 
            this.CB_imgBG.FormattingEnabled = true;
            this.CB_imgBG.Location = new System.Drawing.Point(50, 2);
            this.CB_imgBG.Name = "CB_imgBG";
            this.CB_imgBG.Size = new System.Drawing.Size(164, 20);
            this.CB_imgBG.TabIndex = 16;
            this.CB_imgBG.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CB_imgBG_DrawItem);
            this.CB_imgBG.SelectedIndexChanged += new System.EventHandler(this.CB_imgBG_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "배경색";
            // 
            // TLP_imgLayer
            // 
            this.TLP_imgLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TLP_imgLayer.ColumnCount = 3;
            this.TLP_imgLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_imgLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TLP_imgLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TLP_imgLayer.Controls.Add(this.label4, 0, 0);
            this.TLP_imgLayer.Controls.Add(this.RB_layer1, 2, 0);
            this.TLP_imgLayer.Controls.Add(this.RB_layer0, 1, 0);
            this.TLP_imgLayer.Location = new System.Drawing.Point(220, 1);
            this.TLP_imgLayer.Name = "TLP_imgLayer";
            this.TLP_imgLayer.RowCount = 1;
            this.TLP_imgLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_imgLayer.Size = new System.Drawing.Size(112, 23);
            this.TLP_imgLayer.TabIndex = 14;
            this.TLP_imgLayer.Visible = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "레이어";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RB_layer1
            // 
            this.RB_layer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_layer1.Location = new System.Drawing.Point(85, 3);
            this.RB_layer1.Name = "RB_layer1";
            this.RB_layer1.Size = new System.Drawing.Size(26, 17);
            this.RB_layer1.TabIndex = 11;
            this.RB_layer1.Text = "1";
            this.RB_layer1.UseVisualStyleBackColor = true;
            this.RB_layer1.CheckedChanged += new System.EventHandler(this.CLB_imgList_SelectedIndexChanged);
            // 
            // RB_layer0
            // 
            this.RB_layer0.Checked = true;
            this.RB_layer0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_layer0.Location = new System.Drawing.Point(53, 3);
            this.RB_layer0.Name = "RB_layer0";
            this.RB_layer0.Size = new System.Drawing.Size(26, 17);
            this.RB_layer0.TabIndex = 10;
            this.RB_layer0.TabStop = true;
            this.RB_layer0.Text = "0";
            this.RB_layer0.UseVisualStyleBackColor = true;
            this.RB_layer0.CheckedChanged += new System.EventHandler(this.CLB_imgList_SelectedIndexChanged);
            // 
            // P_img
            // 
            this.P_img.AutoScroll = true;
            this.P_img.Controls.Add(this.PB_img);
            this.P_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_img.Location = new System.Drawing.Point(0, 25);
            this.P_img.Margin = new System.Windows.Forms.Padding(0);
            this.P_img.Name = "P_img";
            this.P_img.Size = new System.Drawing.Size(669, 394);
            this.P_img.TabIndex = 0;
            // 
            // PB_img
            // 
            this.PB_img.BackColor = System.Drawing.Color.Transparent;
            this.PB_img.BackgroundImage = global::CSharpFort3ImgExtract.Properties.Resources.imgBackground;
            this.PB_img.Location = new System.Drawing.Point(0, 0);
            this.PB_img.Margin = new System.Windows.Forms.Padding(0);
            this.PB_img.Name = "PB_img";
            this.PB_img.Size = new System.Drawing.Size(0, 0);
            this.PB_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_img.TabIndex = 0;
            this.PB_img.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RTB_hex);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(669, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hex";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RTB_hex
            // 
            this.RTB_hex.BackColor = System.Drawing.SystemColors.Window;
            this.RTB_hex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_hex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_hex.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RTB_hex.Location = new System.Drawing.Point(0, 0);
            this.RTB_hex.Name = "RTB_hex";
            this.RTB_hex.ReadOnly = true;
            this.RTB_hex.Size = new System.Drawing.Size(669, 444);
            this.RTB_hex.TabIndex = 1;
            this.RTB_hex.Text = "";
            this.RTB_hex.WordWrap = false;
            // 
            // CLB_imgList
            // 
            this.CLB_imgList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLB_imgList.FormattingEnabled = true;
            this.CLB_imgList.Location = new System.Drawing.Point(12, 66);
            this.CLB_imgList.Name = "CLB_imgList";
            this.CLB_imgList.Size = new System.Drawing.Size(93, 388);
            this.CLB_imgList.TabIndex = 24;
            this.CLB_imgList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_imgList_ItemCheck);
            this.CLB_imgList.SelectedIndexChanged += new System.EventHandler(this.CLB_imgList_SelectedIndexChanged);
            // 
            // OFD_openImg
            // 
            this.OFD_openImg.Filter = "포트리스3 이미지|*.i16;*.img;*.spr;";
            // 
            // TB_rgbType
            // 
            this.TB_rgbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_rgbType.Location = new System.Drawing.Point(346, 2);
            this.TB_rgbType.Name = "TB_rgbType";
            this.TB_rgbType.ReadOnly = true;
            this.TB_rgbType.Size = new System.Drawing.Size(80, 21);
            this.TB_rgbType.TabIndex = 25;
            this.TB_rgbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "RGB값 타입";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.CLB_imgList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CB_allCheck);
            this.Controls.Add(this.B_save);
            this.Controls.Add(this.L_openImg);
            this.Controls.Add(this.B_openImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "포트리스3 이미지 뷰어";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.P_imgInfo.ResumeLayout(false);
            this.P_imgInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TLP_imgLayer.ResumeLayout(false);
            this.P_img.ResumeLayout(false);
            this.P_img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_openImg;
        private System.Windows.Forms.Button B_openImg;
        private System.Windows.Forms.CheckBox CB_allCheck;
        private System.Windows.Forms.Button B_save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox RTB_hex;
        private System.Windows.Forms.CheckedListBox CLB_imgList;
        private System.Windows.Forms.Panel P_imgInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_offsetY;
        private System.Windows.Forms.TextBox TB_offsetX;
        private System.Windows.Forms.TableLayoutPanel TLP_imgLayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_layer1;
        private System.Windows.Forms.RadioButton RB_layer0;
        private System.Windows.Forms.Label L_imgSize;
        private System.Windows.Forms.Panel P_img;
        private System.Windows.Forms.PictureBox PB_img;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_imgBG;
        private System.Windows.Forms.OpenFileDialog OFD_openImg;
        private System.Windows.Forms.TextBox TB_rgbType;
        private System.Windows.Forms.Label label3;
    }
}

