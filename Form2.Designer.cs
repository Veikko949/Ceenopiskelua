namespace RistiNolla
{
    partial class Form2
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
            this.Pelaaja1 = new System.Windows.Forms.Label();
            this.Pelaaja2 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pelaaja1
            // 
            this.Pelaaja1.AutoSize = true;
            this.Pelaaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pelaaja1.Location = new System.Drawing.Point(16, 22);
            this.Pelaaja1.Name = "Pelaaja1";
            this.Pelaaja1.Size = new System.Drawing.Size(153, 24);
            this.Pelaaja1.TabIndex = 0;
            this.Pelaaja1.Text = "Pelaaja Yksi Nimi";
            this.Pelaaja1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pelaaja2
            // 
            this.Pelaaja2.AutoSize = true;
            this.Pelaaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pelaaja2.Location = new System.Drawing.Point(16, 57);
            this.Pelaaja2.Name = "Pelaaja2";
            this.Pelaaja2.Size = new System.Drawing.Size(172, 24);
            this.Pelaaja2.TabIndex = 1;
            this.Pelaaja2.Text = "Pelaaja Kasksi Nimi";
            this.Pelaaja2.Click += new System.EventHandler(this.label2_Click);
            // 
            // P1
            // 
            this.P1.Location = new System.Drawing.Point(218, 27);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(211, 20);
            this.P1.TabIndex = 2;
            this.P1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(218, 62);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(211, 20);
            this.P2.TabIndex = 3;
            this.P2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.P2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P2_KeyPress);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(343, 88);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(86, 32);
            this.Play.TabIndex = 4;
            this.Play.Text = "Pelaa";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 135);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Pelaaja2);
            this.Controls.Add(this.Pelaaja1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Pelaajien Nimet";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pelaaja1;
        private System.Windows.Forms.Label Pelaaja2;
        private System.Windows.Forms.TextBox P1;
        private System.Windows.Forms.TextBox P2;
        private System.Windows.Forms.Button Play;
    }
}