using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuAutoFill
{
    public partial class MenuOptionsForm : Form
    {
        public MenuOptionsForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Selecione o arquivo";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Arquivos do Excel (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != "")
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
            else
            {
                txtFilePath.Text = "";
            }
        }
    }
}
