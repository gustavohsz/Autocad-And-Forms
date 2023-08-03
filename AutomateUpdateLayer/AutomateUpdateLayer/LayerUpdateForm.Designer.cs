namespace AutomateUpdateLayer
{
    partial class LayerUpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstDwgs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLayerOlder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLayerNew = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnUpdateLayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(74, 24);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(296, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(376, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Buscar";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstDwgs
            // 
            this.lstDwgs.FormattingEnabled = true;
            this.lstDwgs.Location = new System.Drawing.Point(15, 66);
            this.lstDwgs.Name = "lstDwgs";
            this.lstDwgs.Size = new System.Drawing.Size(443, 160);
            this.lstDwgs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira a Layer antiga:";
            // 
            // txtLayerOlder
            // 
            this.txtLayerOlder.Location = new System.Drawing.Point(124, 245);
            this.txtLayerOlder.Name = "txtLayerOlder";
            this.txtLayerOlder.Size = new System.Drawing.Size(334, 20);
            this.txtLayerOlder.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insira a Latey nova:";
            // 
            // txtLayerNew
            // 
            this.txtLayerNew.Location = new System.Drawing.Point(124, 281);
            this.txtLayerNew.Name = "txtLayerNew";
            this.txtLayerNew.Size = new System.Drawing.Size(334, 20);
            this.txtLayerNew.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 321);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(16, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "...";
            // 
            // btnUpdateLayer
            // 
            this.btnUpdateLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLayer.Location = new System.Drawing.Point(172, 356);
            this.btnUpdateLayer.Name = "btnUpdateLayer";
            this.btnUpdateLayer.Size = new System.Drawing.Size(121, 35);
            this.btnUpdateLayer.TabIndex = 9;
            this.btnUpdateLayer.Text = "Atualizar Layer";
            this.btnUpdateLayer.UseVisualStyleBackColor = true;
            this.btnUpdateLayer.Click += new System.EventHandler(this.btnUpdateLayer_Click);
            // 
            // LayerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 403);
            this.Controls.Add(this.btnUpdateLayer);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtLayerNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLayerOlder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDwgs);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LayerUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LayerUpdateForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LayerUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstDwgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLayerOlder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLayerNew;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnUpdateLayer;
    }
}