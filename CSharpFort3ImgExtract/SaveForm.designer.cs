
namespace CSharpFort3ImgExtract
{
    partial class SaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveForm));
            this.B_save = new System.Windows.Forms.Button();
            this.B_close = new System.Windows.Forms.Button();
            this.B_savePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_savePath = new System.Windows.Forms.TextBox();
            this.CB_overwrite = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // B_save
            // 
            this.B_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_save.Location = new System.Drawing.Point(418, 66);
            this.B_save.Name = "B_save";
            this.B_save.Size = new System.Drawing.Size(75, 23);
            this.B_save.TabIndex = 1;
            this.B_save.Text = "내보내기";
            this.B_save.UseVisualStyleBackColor = true;
            this.B_save.Click += new System.EventHandler(this.B_save_Click);
            // 
            // B_close
            // 
            this.B_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_close.Location = new System.Drawing.Point(497, 66);
            this.B_close.Name = "B_close";
            this.B_close.Size = new System.Drawing.Size(75, 23);
            this.B_close.TabIndex = 2;
            this.B_close.Text = "취소";
            this.B_close.UseVisualStyleBackColor = true;
            this.B_close.Click += new System.EventHandler(this.B_close_Click);
            // 
            // B_savePath
            // 
            this.B_savePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_savePath.Location = new System.Drawing.Point(497, 12);
            this.B_savePath.Name = "B_savePath";
            this.B_savePath.Size = new System.Drawing.Size(75, 23);
            this.B_savePath.TabIndex = 5;
            this.B_savePath.Text = "찾아보기";
            this.B_savePath.UseVisualStyleBackColor = true;
            this.B_savePath.Click += new System.EventHandler(this.B_savePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "저장위치";
            // 
            // TB_savePath
            // 
            this.TB_savePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_savePath.Location = new System.Drawing.Point(71, 12);
            this.TB_savePath.Name = "TB_savePath";
            this.TB_savePath.ReadOnly = true;
            this.TB_savePath.Size = new System.Drawing.Size(422, 21);
            this.TB_savePath.TabIndex = 11;
            // 
            // CB_overwrite
            // 
            this.CB_overwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_overwrite.AutoSize = true;
            this.CB_overwrite.Location = new System.Drawing.Point(220, 70);
            this.CB_overwrite.Name = "CB_overwrite";
            this.CB_overwrite.Size = new System.Drawing.Size(192, 16);
            this.CB_overwrite.TabIndex = 12;
            this.CB_overwrite.Text = "중복된 이미지 파일명 덮어쓰기";
            this.CB_overwrite.UseVisualStyleBackColor = true;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 101);
            this.Controls.Add(this.CB_overwrite);
            this.Controls.Add(this.TB_savePath);
            this.Controls.Add(this.B_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_savePath);
            this.Controls.Add(this.B_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 120);
            this.Name = "SaveForm";
            this.ShowInTaskbar = false;
            this.Text = "저장";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_save;
        private System.Windows.Forms.Button B_close;
        private System.Windows.Forms.Button B_savePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_savePath;
        private System.Windows.Forms.CheckBox CB_overwrite;
    }
}