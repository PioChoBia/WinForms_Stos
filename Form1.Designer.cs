namespace WinForms_Stos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPokaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWpisz = new System.Windows.Forms.TextBox();
            this.buttonWloz = new System.Windows.Forms.Button();
            this.buttonZdejmij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPokaz
            // 
            this.textBoxPokaz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPokaz.Location = new System.Drawing.Point(122, 167);
            this.textBoxPokaz.Multiline = true;
            this.textBoxPokaz.Name = "textBoxPokaz";
            this.textBoxPokaz.ReadOnly = true;
            this.textBoxPokaz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPokaz.Size = new System.Drawing.Size(223, 475);
            this.textBoxPokaz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "wkładanie i usuwanie z stosu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxWpisz
            // 
            this.textBoxWpisz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxWpisz.Location = new System.Drawing.Point(122, 61);
            this.textBoxWpisz.Name = "textBoxWpisz";
            this.textBoxWpisz.Size = new System.Drawing.Size(223, 29);
            this.textBoxWpisz.TabIndex = 2;
            // 
            // buttonWloz
            // 
            this.buttonWloz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWloz.Location = new System.Drawing.Point(122, 109);
            this.buttonWloz.Name = "buttonWloz";
            this.buttonWloz.Size = new System.Drawing.Size(91, 35);
            this.buttonWloz.TabIndex = 3;
            this.buttonWloz.Text = "wloz";
            this.buttonWloz.UseVisualStyleBackColor = true;
            this.buttonWloz.Click += new System.EventHandler(this.buttonWloz_Click);
            // 
            // buttonZdejmij
            // 
            this.buttonZdejmij.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZdejmij.Location = new System.Drawing.Point(254, 109);
            this.buttonZdejmij.Name = "buttonZdejmij";
            this.buttonZdejmij.Size = new System.Drawing.Size(91, 35);
            this.buttonZdejmij.TabIndex = 4;
            this.buttonZdejmij.Text = "zdejmij";
            this.buttonZdejmij.UseVisualStyleBackColor = true;
            this.buttonZdejmij.Click += new System.EventHandler(this.buttonZdejmij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 670);
            this.Controls.Add(this.buttonZdejmij);
            this.Controls.Add(this.buttonWloz);
            this.Controls.Add(this.textBoxWpisz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPokaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPokaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWpisz;
        private System.Windows.Forms.Button buttonWloz;
        private System.Windows.Forms.Button buttonZdejmij;
    }
}
