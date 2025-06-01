namespace conclave
{
    partial class Form1
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
            this.btGerenciar = new System.Windows.Forms.Button();
            this.btVotar = new System.Windows.Forms.Button();
            this.btResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGerenciar
            // 
            this.btGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btGerenciar.Location = new System.Drawing.Point(52, 37);
            this.btGerenciar.Name = "btGerenciar";
            this.btGerenciar.Size = new System.Drawing.Size(373, 105);
            this.btGerenciar.TabIndex = 0;
            this.btGerenciar.Text = "&Gerenciar Papáveis";
            this.btGerenciar.UseVisualStyleBackColor = true;
            this.btGerenciar.Click += new System.EventHandler(this.btGerenciar_Click);
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btVotar.Location = new System.Drawing.Point(52, 170);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(373, 105);
            this.btVotar.TabIndex = 1;
            this.btVotar.Text = "&Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // btResultados
            // 
            this.btResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btResultados.Location = new System.Drawing.Point(52, 304);
            this.btResultados.Name = "btResultados";
            this.btResultados.Size = new System.Drawing.Size(373, 105);
            this.btResultados.TabIndex = 2;
            this.btResultados.Text = "&Resultados";
            this.btResultados.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btResultados);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.btGerenciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGerenciar;
        private System.Windows.Forms.Button btVotar;
        private System.Windows.Forms.Button btResultados;
    }
}

