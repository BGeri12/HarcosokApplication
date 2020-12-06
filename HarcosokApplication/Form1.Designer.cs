namespace HarcosokApplication
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
            this.textBox_hnev = new System.Windows.Forms.TextBox();
            this.textBox_knev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_letrehoz = new System.Windows.Forms.Button();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.comboBox_hasznalo = new System.Windows.Forms.ComboBox();
            this.richTextBox_leiras = new System.Windows.Forms.RichTextBox();
            this.richTextBox_kepessegLeiras = new System.Windows.Forms.RichTextBox();
            this.listBox_harcosok = new System.Windows.Forms.ListBox();
            this.listBox_kepessegek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_hnev
            // 
            this.textBox_hnev.Location = new System.Drawing.Point(75, 46);
            this.textBox_hnev.Name = "textBox_hnev";
            this.textBox_hnev.Size = new System.Drawing.Size(189, 20);
            this.textBox_hnev.TabIndex = 0;
            // 
            // textBox_knev
            // 
            this.textBox_knev.Location = new System.Drawing.Point(92, 188);
            this.textBox_knev.Name = "textBox_knev";
            this.textBox_knev.Size = new System.Drawing.Size(121, 20);
            this.textBox_knev.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Név:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Harcos létrehozása";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Képesség hozzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Használó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Leírás:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Képességei:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Harcosok:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Képesség leírása:";
            // 
            // button_letrehoz
            // 
            this.button_letrehoz.Location = new System.Drawing.Point(289, 44);
            this.button_letrehoz.Name = "button_letrehoz";
            this.button_letrehoz.Size = new System.Drawing.Size(75, 23);
            this.button_letrehoz.TabIndex = 15;
            this.button_letrehoz.Text = "Létrehoz";
            this.button_letrehoz.UseVisualStyleBackColor = true;
            this.button_letrehoz.Click += new System.EventHandler(this.button_letrehoz_Click);
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Location = new System.Drawing.Point(24, 223);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaad.TabIndex = 16;
            this.button_hozzaad.Text = "Hozzáad";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(505, 372);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(75, 23);
            this.button_modosit.TabIndex = 17;
            this.button_modosit.Text = "Modosít";
            this.button_modosit.UseVisualStyleBackColor = true;
            this.button_modosit.Click += new System.EventHandler(this.button_modosit_Click);
            // 
            // button_torles
            // 
            this.button_torles.Location = new System.Drawing.Point(189, 498);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(75, 23);
            this.button_torles.TabIndex = 18;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // comboBox_hasznalo
            // 
            this.comboBox_hasznalo.FormattingEnabled = true;
            this.comboBox_hasznalo.Location = new System.Drawing.Point(92, 143);
            this.comboBox_hasznalo.Name = "comboBox_hasznalo";
            this.comboBox_hasznalo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_hasznalo.TabIndex = 19;
            // 
            // richTextBox_leiras
            // 
            this.richTextBox_leiras.Location = new System.Drawing.Point(373, 159);
            this.richTextBox_leiras.Name = "richTextBox_leiras";
            this.richTextBox_leiras.Size = new System.Drawing.Size(207, 49);
            this.richTextBox_leiras.TabIndex = 20;
            this.richTextBox_leiras.Text = "";
            // 
            // richTextBox_kepessegLeiras
            // 
            this.richTextBox_kepessegLeiras.Location = new System.Drawing.Point(373, 304);
            this.richTextBox_kepessegLeiras.Name = "richTextBox_kepessegLeiras";
            this.richTextBox_kepessegLeiras.Size = new System.Drawing.Size(207, 49);
            this.richTextBox_kepessegLeiras.TabIndex = 21;
            this.richTextBox_kepessegLeiras.Text = "";
            // 
            // listBox_harcosok
            // 
            this.listBox_harcosok.FormattingEnabled = true;
            this.listBox_harcosok.Location = new System.Drawing.Point(24, 304);
            this.listBox_harcosok.Name = "listBox_harcosok";
            this.listBox_harcosok.Size = new System.Drawing.Size(120, 186);
            this.listBox_harcosok.TabIndex = 22;
            this.listBox_harcosok.SelectedIndexChanged += new System.EventHandler(this.listBox_harcosok_SelectedIndexChanged);
            // 
            // listBox_kepessegek
            // 
            this.listBox_kepessegek.FormattingEnabled = true;
            this.listBox_kepessegek.Location = new System.Drawing.Point(189, 304);
            this.listBox_kepessegek.Name = "listBox_kepessegek";
            this.listBox_kepessegek.Size = new System.Drawing.Size(120, 186);
            this.listBox_kepessegek.TabIndex = 23;
            this.listBox_kepessegek.SelectedIndexChanged += new System.EventHandler(this.listBox_kepessegek_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 555);
            this.Controls.Add(this.listBox_kepessegek);
            this.Controls.Add(this.listBox_harcosok);
            this.Controls.Add(this.richTextBox_kepessegLeiras);
            this.Controls.Add(this.richTextBox_leiras);
            this.Controls.Add(this.comboBox_hasznalo);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.button_letrehoz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_knev);
            this.Controls.Add(this.textBox_hnev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_hnev;
        private System.Windows.Forms.TextBox textBox_knev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_letrehoz;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.ComboBox comboBox_hasznalo;
        private System.Windows.Forms.RichTextBox richTextBox_leiras;
        private System.Windows.Forms.RichTextBox richTextBox_kepessegLeiras;
        private System.Windows.Forms.ListBox listBox_harcosok;
        private System.Windows.Forms.ListBox listBox_kepessegek;
    }
}

