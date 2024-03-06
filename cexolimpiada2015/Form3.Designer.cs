namespace cexolimpiada2015
{
    partial class Form3
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
            this.InitializareBtn = new System.Windows.Forms.Button();
            this.SalvareCoordonateBtn = new System.Windows.Forms.Button();
            this.GenerareCroaziereBtn = new System.Windows.Forms.Button();
            this.ActualizareDistanteBtn = new System.Windows.Forms.Button();
            this.ListaCroaziereBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InitializareBtn
            // 
            this.InitializareBtn.Location = new System.Drawing.Point(849, 256);
            this.InitializareBtn.Name = "InitializareBtn";
            this.InitializareBtn.Size = new System.Drawing.Size(118, 23);
            this.InitializareBtn.TabIndex = 0;
            this.InitializareBtn.Text = "Initializare";
            this.InitializareBtn.UseVisualStyleBackColor = true;
            this.InitializareBtn.Click += new System.EventHandler(this.InitializareBtn_Click);
            // 
            // SalvareCoordonateBtn
            // 
            this.SalvareCoordonateBtn.Location = new System.Drawing.Point(849, 285);
            this.SalvareCoordonateBtn.Name = "SalvareCoordonateBtn";
            this.SalvareCoordonateBtn.Size = new System.Drawing.Size(118, 23);
            this.SalvareCoordonateBtn.TabIndex = 1;
            this.SalvareCoordonateBtn.Text = "Salvare Coordonate";
            this.SalvareCoordonateBtn.UseVisualStyleBackColor = true;
            this.SalvareCoordonateBtn.Click += new System.EventHandler(this.SalvareCoordonateBtn_Click);
            // 
            // GenerareCroaziereBtn
            // 
            this.GenerareCroaziereBtn.Location = new System.Drawing.Point(849, 343);
            this.GenerareCroaziereBtn.Name = "GenerareCroaziereBtn";
            this.GenerareCroaziereBtn.Size = new System.Drawing.Size(118, 23);
            this.GenerareCroaziereBtn.TabIndex = 3;
            this.GenerareCroaziereBtn.Text = "Generare Croaziere";
            this.GenerareCroaziereBtn.UseVisualStyleBackColor = true;
            this.GenerareCroaziereBtn.Click += new System.EventHandler(this.GenerareCroaziereBtn_Click);
            // 
            // ActualizareDistanteBtn
            // 
            this.ActualizareDistanteBtn.Location = new System.Drawing.Point(849, 314);
            this.ActualizareDistanteBtn.Name = "ActualizareDistanteBtn";
            this.ActualizareDistanteBtn.Size = new System.Drawing.Size(118, 23);
            this.ActualizareDistanteBtn.TabIndex = 2;
            this.ActualizareDistanteBtn.Text = "ActualizareDistante";
            this.ActualizareDistanteBtn.UseVisualStyleBackColor = true;
            this.ActualizareDistanteBtn.Click += new System.EventHandler(this.ActualizareDistanteBtn_Click);
            // 
            // ListaCroaziereBtn
            // 
            this.ListaCroaziereBtn.Location = new System.Drawing.Point(849, 372);
            this.ListaCroaziereBtn.Name = "ListaCroaziereBtn";
            this.ListaCroaziereBtn.Size = new System.Drawing.Size(118, 23);
            this.ListaCroaziereBtn.TabIndex = 4;
            this.ListaCroaziereBtn.Text = "Lista Croaziere";
            this.ListaCroaziereBtn.UseVisualStyleBackColor = true;
            this.ListaCroaziereBtn.Click += new System.EventHandler(this.ListaCroaziereBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cexolimpiada2015.Properties.Resources.MareaNeagra;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListaCroaziereBtn);
            this.Controls.Add(this.GenerareCroaziereBtn);
            this.Controls.Add(this.ActualizareDistanteBtn);
            this.Controls.Add(this.SalvareCoordonateBtn);
            this.Controls.Add(this.InitializareBtn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InitializareBtn;
        private System.Windows.Forms.Button SalvareCoordonateBtn;
        private System.Windows.Forms.Button GenerareCroaziereBtn;
        private System.Windows.Forms.Button ActualizareDistanteBtn;
        private System.Windows.Forms.Button ListaCroaziereBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}