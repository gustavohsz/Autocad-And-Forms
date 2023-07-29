namespace DrawRectangle
{
    partial class RectangleForm
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
            this.gbRectangleForm = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCoordinates = new System.Windows.Forms.RadioButton();
            this.rbPickOnScreen = new System.Windows.Forms.RadioButton();
            this.gbCoordinates = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXcoord = new System.Windows.Forms.TextBox();
            this.txtYCoord = new System.Windows.Forms.TextBox();
            this.btnDrawRectangle = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbRectangleForm.SuspendLayout();
            this.gbCoordinates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRectangleForm
            // 
            this.gbRectangleForm.Controls.Add(this.lblInfo);
            this.gbRectangleForm.Controls.Add(this.btnDrawRectangle);
            this.gbRectangleForm.Controls.Add(this.gbCoordinates);
            this.gbRectangleForm.Controls.Add(this.rbPickOnScreen);
            this.gbRectangleForm.Controls.Add(this.rbCoordinates);
            this.gbRectangleForm.Controls.Add(this.label3);
            this.gbRectangleForm.Controls.Add(this.label2);
            this.gbRectangleForm.Controls.Add(this.txtHeight);
            this.gbRectangleForm.Controls.Add(this.txtWidth);
            this.gbRectangleForm.Controls.Add(this.label1);
            this.gbRectangleForm.Location = new System.Drawing.Point(12, 12);
            this.gbRectangleForm.Name = "gbRectangleForm";
            this.gbRectangleForm.Size = new System.Drawing.Size(353, 311);
            this.gbRectangleForm.TabIndex = 0;
            this.gbRectangleForm.TabStop = false;
            this.gbRectangleForm.Text = "Entre com os parâmetros do retângulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o comprimento:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(119, 36);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(119, 62);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira a altura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escolha o ponto de inserção:";
            // 
            // rbCoordinates
            // 
            this.rbCoordinates.AutoSize = true;
            this.rbCoordinates.Location = new System.Drawing.Point(28, 130);
            this.rbCoordinates.Name = "rbCoordinates";
            this.rbCoordinates.Size = new System.Drawing.Size(131, 17);
            this.rbCoordinates.TabIndex = 5;
            this.rbCoordinates.TabStop = true;
            this.rbCoordinates.Text = "Digite as coordenadas";
            this.rbCoordinates.UseVisualStyleBackColor = true;
            this.rbCoordinates.CheckedChanged += new System.EventHandler(this.rbCoordinates_CheckedChanged);
            // 
            // rbPickOnScreen
            // 
            this.rbPickOnScreen.AutoSize = true;
            this.rbPickOnScreen.Location = new System.Drawing.Point(197, 130);
            this.rbPickOnScreen.Name = "rbPickOnScreen";
            this.rbPickOnScreen.Size = new System.Drawing.Size(123, 17);
            this.rbPickOnScreen.TabIndex = 6;
            this.rbPickOnScreen.TabStop = true;
            this.rbPickOnScreen.Text = "Insirir o ponto na tela";
            this.rbPickOnScreen.UseVisualStyleBackColor = true;
            this.rbPickOnScreen.CheckedChanged += new System.EventHandler(this.rbPickOnScreen_CheckedChanged);
            // 
            // gbCoordinates
            // 
            this.gbCoordinates.Controls.Add(this.txtYCoord);
            this.gbCoordinates.Controls.Add(this.txtXcoord);
            this.gbCoordinates.Controls.Add(this.label5);
            this.gbCoordinates.Controls.Add(this.label4);
            this.gbCoordinates.Location = new System.Drawing.Point(9, 167);
            this.gbCoordinates.Name = "gbCoordinates";
            this.gbCoordinates.Size = new System.Drawing.Size(335, 90);
            this.gbCoordinates.TabIndex = 7;
            this.gbCoordinates.TabStop = false;
            this.gbCoordinates.Text = "Entre com as coordenadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Coordenada X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Coordenada Y:";
            // 
            // txtXcoord
            // 
            this.txtXcoord.Location = new System.Drawing.Point(110, 23);
            this.txtXcoord.Name = "txtXcoord";
            this.txtXcoord.Size = new System.Drawing.Size(100, 20);
            this.txtXcoord.TabIndex = 2;
            // 
            // txtYCoord
            // 
            this.txtYCoord.Location = new System.Drawing.Point(110, 49);
            this.txtYCoord.Name = "txtYCoord";
            this.txtYCoord.Size = new System.Drawing.Size(100, 20);
            this.txtYCoord.TabIndex = 3;
            // 
            // btnDrawRectangle
            // 
            this.btnDrawRectangle.Location = new System.Drawing.Point(90, 263);
            this.btnDrawRectangle.Name = "btnDrawRectangle";
            this.btnDrawRectangle.Size = new System.Drawing.Size(172, 23);
            this.btnDrawRectangle.TabIndex = 8;
            this.btnDrawRectangle.Text = "Desenhar o retângulo";
            this.btnDrawRectangle.UseVisualStyleBackColor = true;
            this.btnDrawRectangle.Click += new System.EventHandler(this.btnDrawRectangle_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 286);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(16, 13);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "...";
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 335);
            this.Controls.Add(this.gbRectangleForm);
            this.MaximizeBox = false;
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            this.gbRectangleForm.ResumeLayout(false);
            this.gbRectangleForm.PerformLayout();
            this.gbCoordinates.ResumeLayout(false);
            this.gbCoordinates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRectangleForm;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDrawRectangle;
        private System.Windows.Forms.GroupBox gbCoordinates;
        private System.Windows.Forms.TextBox txtYCoord;
        private System.Windows.Forms.TextBox txtXcoord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPickOnScreen;
        private System.Windows.Forms.RadioButton rbCoordinates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
    }
}