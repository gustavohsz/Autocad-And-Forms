using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace AutomateUpdateLayer
{
    public partial class LayerUpdateForm : Form
    {
        public LayerUpdateForm()
        {
            InitializeComponent();
        }

        private void LayerUpdateForm_Load(object sender, EventArgs e)
        {
            PopulateListbox(txtPath.Text.Trim());
        }

        private void PopulateListbox(string dwgPath)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = dwgPath;

                string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dwg");
                //load all the drawing files into the listbox
                lstDwgs.DataSource = files;

                //foreach(string dwg in files)
                //{
                //    lstDwgs.Items.Add(dwg);
                //}

                lblInfo.Text = "Total number of drawings = " + lstDwgs.Items.Count;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PopulateListbox(fbd.SelectedPath);
                }
            }
        }

        private void btnUpdateLayer_Click(object sender, EventArgs e)
        {
            string oldLayer = txtLayerOlder.Text.Trim();
            string newLayer = txtLayerNew.Text.Trim();
            int i = 1;

            UpdateLayerUtil util = new UpdateLayerUtil();

            int totalCount = lstDwgs.Items.Count;

            //loop through the list and process the drawing one at a time
            foreach(string dwgFile in lstDwgs.Items)
            {
                lblInfo.Text = "Processado ( " + i.ToString() + " de " + totalCount.ToString() + " ) : " + dwgFile;
                lblInfo.ForeColor = Color.Green;
                util.ProcessLayerUpdate(dwgFile, oldLayer, newLayer);

                i++;
            }
            lblInfo.Text = "Atualização de Layers completa!";
            lblInfo.ForeColor = Color.Green;
        }
    }
}
