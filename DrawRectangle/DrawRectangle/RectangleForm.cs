using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;

namespace DrawRectangle
{
    public partial class RectangleForm : Form
    {
        Point3d insPt;
        double xCoord, yCoord;
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            //Validate the width
            bool isValid = ValidateEntry(txtWidth);
            if(isValid == false)
            {
                MessageBox.Show("Invalid Width. Please enter a valid value.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWidth.Focus();
                return;
            }

            //validate the height
            isValid = ValidateEntry(txtHeight);
            if (isValid == false)
            {
                MessageBox.Show("Invalid Width. Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Focus();
                return;
            }

            if (rbPickOnScreen.Checked)
            {
                //ask for the insertionPoint of the rectangle
                this.Hide(); //esconde o form
                Editor edt = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
                PromptPointOptions ppo = new PromptPointOptions("Escolha o ponto de inserção do retângulo: ");
                PromptPointResult ppr = edt.GetPoint(ppo);
                insPt = ppr.Value;
                this.Show();
            }

            if (rbCoordinates.Checked)
            {
                //validate X coordinate
                isValid = ValidateEntry(txtXcoord);
                if (isValid == false)
                {
                    MessageBox.Show("Invalid X-Coordinate. Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtXcoord.Focus();
                    return;
                }
                isValid = ValidateEntry(txtYCoord);
                if (isValid == false)
                {
                    MessageBox.Show("Invalid Y-Coordinate. Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYCoord.Focus();
                    return;
                }

                xCoord = double.Parse(txtXcoord.Text.Trim());
                yCoord = double.Parse(txtYCoord.Text.Trim());
                insPt = new Point3d(xCoord, yCoord, 0);

            }

            double width = double.Parse(txtWidth.Text.Trim());
            double height = double.Parse(txtHeight.Text.Trim());

            RactangleUtil rect = new RactangleUtil();
            rect.DrawRectangle(width, height, insPt);
            lblInfo.Text = "Retângulo foi Criado!";
            lblInfo.ForeColor = Color.Green;
        }

        private void rbPickOnScreen_CheckedChanged(object sender, EventArgs e)
        {
            gbCoordinates.Enabled = false;
        }

        private void rbCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            gbCoordinates.Enabled = true;
        }

        private bool ValidateEntry(TextBox tb)
        {
            bool isValid = false;
            double value;

            try
            {
                //validate the Textbox value
                if (tb.Text.Trim() == ""){
                    lblInfo.Text = "Please enter a value.";
                    lblInfo.ForeColor = Color.Red;
                }
                else
                {
                    value = double.Parse(tb.Text.Trim());
                    isValid = true;
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Invalid input. " + ex.Message;
                lblInfo.ForeColor = Color.Red;
            }

            return isValid;
        }

    }
}
