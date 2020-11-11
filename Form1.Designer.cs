namespace RistiNolla
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPisteetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sammutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitenToimiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.Tasa = new System.Windows.Forms.Label();
            this.X_voitto = new System.Windows.Forms.Label();
            this.O_voitto = new System.Windows.Forms.Label();
            this.Tasapaeli = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.setPlayerDeafultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedotToolStripMenuItem,
            this.apuaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedotToolStripMenuItem
            // 
            this.tiedotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiPeliToolStripMenuItem,
            this.setPlayerDeafultsToolStripMenuItem,
            this.resetPisteetToolStripMenuItem,
            this.sammutaToolStripMenuItem});
            this.tiedotToolStripMenuItem.Name = "tiedotToolStripMenuItem";
            this.tiedotToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tiedotToolStripMenuItem.Text = "Tiedot";
            // 
            // uusiPeliToolStripMenuItem
            // 
            this.uusiPeliToolStripMenuItem.Name = "uusiPeliToolStripMenuItem";
            this.uusiPeliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uusiPeliToolStripMenuItem.Text = "Uusi Peli";
            this.uusiPeliToolStripMenuItem.Click += new System.EventHandler(this.uusiPeliToolStripMenuItem_Click);
            // 
            // resetPisteetToolStripMenuItem
            // 
            this.resetPisteetToolStripMenuItem.Name = "resetPisteetToolStripMenuItem";
            this.resetPisteetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetPisteetToolStripMenuItem.Text = "Nollaa Pisteet";
            this.resetPisteetToolStripMenuItem.Click += new System.EventHandler(this.resetPisteetToolStripMenuItem_Click);
            // 
            // sammutaToolStripMenuItem
            // 
            this.sammutaToolStripMenuItem.Name = "sammutaToolStripMenuItem";
            this.sammutaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sammutaToolStripMenuItem.Text = "Sammuta";
            this.sammutaToolStripMenuItem.Click += new System.EventHandler(this.sammutaToolStripMenuItem_Click);
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitenToimiiToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.apuaToolStripMenuItem.Text = "Apua";
            // 
            // mitenToimiiToolStripMenuItem
            // 
            this.mitenToimiiToolStripMenuItem.Name = "mitenToimiiToolStripMenuItem";
            this.mitenToimiiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mitenToimiiToolStripMenuItem.Text = "Miten toimii";
            this.mitenToimiiToolStripMenuItem.Click += new System.EventHandler(this.mitenToimiiToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.A1.Location = new System.Drawing.Point(23, 41);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(106, 92);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.nappi_click);
            this.A1.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.A1.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.A2.Location = new System.Drawing.Point(150, 41);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(106, 92);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.nappi_click);
            this.A2.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.A2.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.A3.Location = new System.Drawing.Point(278, 41);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(106, 92);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.nappi_click);
            this.A3.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.A3.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.B1.Location = new System.Drawing.Point(23, 154);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(106, 92);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.nappi_click);
            this.B1.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.B1.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.B2.Location = new System.Drawing.Point(150, 154);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(106, 92);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.nappi_click);
            this.B2.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.B2.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.B3.Location = new System.Drawing.Point(278, 154);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(106, 92);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.nappi_click);
            this.B3.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.B3.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.C1.Location = new System.Drawing.Point(23, 266);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(106, 92);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.nappi_click);
            this.C1.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.C1.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.C2.Location = new System.Drawing.Point(150, 266);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(106, 92);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.nappi_click);
            this.C2.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.C2.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.C3.Location = new System.Drawing.Point(278, 266);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(106, 92);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.nappi_click);
            this.C3.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.C3.MouseLeave += new System.EventHandler(this.nappi_menee);
            // 
            // Tasa
            // 
            this.Tasa.AutoSize = true;
            this.Tasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasa.Location = new System.Drawing.Point(160, 372);
            this.Tasa.Name = "Tasa";
            this.Tasa.Size = new System.Drawing.Size(82, 20);
            this.Tasa.TabIndex = 12;
            this.Tasa.Text = "Tasapelit";
            // 
            // X_voitto
            // 
            this.X_voitto.AutoSize = true;
            this.X_voitto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_voitto.Location = new System.Drawing.Point(61, 407);
            this.X_voitto.Name = "X_voitto";
            this.X_voitto.Size = new System.Drawing.Size(16, 18);
            this.X_voitto.TabIndex = 13;
            this.X_voitto.Text = "0";
            // 
            // O_voitto
            // 
            this.O_voitto.AutoSize = true;
            this.O_voitto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_voitto.Location = new System.Drawing.Point(321, 407);
            this.O_voitto.Name = "O_voitto";
            this.O_voitto.Size = new System.Drawing.Size(16, 18);
            this.O_voitto.TabIndex = 14;
            this.O_voitto.Text = "0";
            // 
            // Tasapaeli
            // 
            this.Tasapaeli.AutoSize = true;
            this.Tasapaeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasapaeli.Location = new System.Drawing.Point(187, 407);
            this.Tasapaeli.Name = "Tasapaeli";
            this.Tasapaeli.Size = new System.Drawing.Size(16, 18);
            this.Tasapaeli.TabIndex = 15;
            this.Tasapaeli.Text = "0";
            // 
            // P1
            // 
            this.P1.Location = new System.Drawing.Point(29, 374);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(100, 20);
            this.P1.TabIndex = 16;
            this.P1.Text = "Pelaaja 1";
            this.P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(278, 374);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(100, 20);
            this.P2.TabIndex = 17;
            this.P2.Text = "Pelaaja 2";
            this.P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P2.TextChanged += new System.EventHandler(this.P2_TextChanged);
            // 
            // setPlayerDeafultsToolStripMenuItem
            // 
            this.setPlayerDeafultsToolStripMenuItem.Name = "setPlayerDeafultsToolStripMenuItem";
            this.setPlayerDeafultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPlayerDeafultsToolStripMenuItem.Text = "Set Player Deafults";
            this.setPlayerDeafultsToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDeafultsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 442);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Tasapaeli);
            this.Controls.Add(this.O_voitto);
            this.Controls.Add(this.X_voitto);
            this.Controls.Add(this.Tasa);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Risti nolla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.nappi_click);
            this.MouseEnter += new System.EventHandler(this.nappi_tulee);
            this.MouseLeave += new System.EventHandler(this.nappi_menee);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sammutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitenToimiiToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label Tasa;
        private System.Windows.Forms.Label X_voitto;
        private System.Windows.Forms.Label O_voitto;
        private System.Windows.Forms.Label Tasapaeli;
        private System.Windows.Forms.ToolStripMenuItem resetPisteetToolStripMenuItem;
        private System.Windows.Forms.TextBox P1;
        private System.Windows.Forms.TextBox P2;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDeafultsToolStripMenuItem;
    }
}

