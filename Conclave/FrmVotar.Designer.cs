namespace conclave
{
    partial class FrmVotar
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
            this.lbxCardeais = new System.Windows.Forms.ListBox();
            this.btVotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(126, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cardeais:";
            // 
            // lbxCardeais
            // 
            this.lbxCardeais.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbxCardeais.FormattingEnabled = true;
            this.lbxCardeais.ItemHeight = 38;
            this.lbxCardeais.Location = new System.Drawing.Point(12, 60);
            this.lbxCardeais.Name = "lbxCardeais";
            this.lbxCardeais.Size = new System.Drawing.Size(394, 232);
            this.lbxCardeais.TabIndex = 1;
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btVotar.Location = new System.Drawing.Point(12, 309);
            this.btVotar.Name = "btVotar";
            this.btVotar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btVotar.Size = new System.Drawing.Size(394, 64);
            this.btVotar.TabIndex = 2;
            this.btVotar.Text = "Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // FrmVotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 392);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.lbxCardeais);
            this.Controls.Add(this.label1);
            this.Name = "FrmVotar";
            this.Text = "FrmVotar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxCardeais;
        private System.Windows.Forms.Button btVotar;
    }
}