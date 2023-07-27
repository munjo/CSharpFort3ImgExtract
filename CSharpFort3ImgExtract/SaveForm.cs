using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class SaveForm : Form
    {
        /// <summary>
        /// 사용자가 설정한 경로를 가져오거나 설정 합니다.
        /// </summary>
        public string SelectedPath
        {
            get => TB_savePath.Text;
            set
            {
                TB_savePath.Text = value;
            } 
        }

        /// <summary>
        /// 파일을 덮어 쓸지 결정하는 옵션을 가져오거나 설정 합니다.
        /// </summary>
        public bool Overwrite
        {
            get => CB_overwrite.Checked;
            set
            {
                CB_overwrite.Checked = value;
            }
        }

        public SaveForm()
        {
            InitializeComponent();
        }

        private void B_savePath_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                SelectedPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void B_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void B_save_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
