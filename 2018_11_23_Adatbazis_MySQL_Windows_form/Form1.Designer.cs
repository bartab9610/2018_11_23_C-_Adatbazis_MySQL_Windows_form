﻿namespace _2018_11_23_Adatbazis_MySQL_Windows_form
{
    partial class Form_adatbazis
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
            this.TextBox_nev = new System.Windows.Forms.TextBox();
            this.TextBox_jelszo = new System.Windows.Forms.TextBox();
            this.DateTimePicker_szul_ido = new System.Windows.Forms.DateTimePicker();
            this.Button_regisztralas = new System.Windows.Forms.Button();
            this.Button_torles = new System.Windows.Forms.Button();
            this.Button_update = new System.Windows.Forms.Button();
            this.Label_Reg_userek = new System.Windows.Forms.Label();
            this.ListBox_felhasznalok = new System.Windows.Forms.ListBox();
            this.ListBox_statisztika = new System.Windows.Forms.ListBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_nev
            // 
            this.TextBox_nev.Location = new System.Drawing.Point(22, 22);
            this.TextBox_nev.Name = "TextBox_nev";
            this.TextBox_nev.Size = new System.Drawing.Size(100, 20);
            this.TextBox_nev.TabIndex = 0;
            // 
            // TextBox_jelszo
            // 
            this.TextBox_jelszo.Location = new System.Drawing.Point(22, 58);
            this.TextBox_jelszo.Name = "TextBox_jelszo";
            this.TextBox_jelszo.PasswordChar = '*';
            this.TextBox_jelszo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_jelszo.TabIndex = 1;
            // 
            // DateTimePicker_szul_ido
            // 
            this.DateTimePicker_szul_ido.Location = new System.Drawing.Point(22, 95);
            this.DateTimePicker_szul_ido.Name = "DateTimePicker_szul_ido";
            this.DateTimePicker_szul_ido.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker_szul_ido.TabIndex = 2;
            // 
            // Button_regisztralas
            // 
            this.Button_regisztralas.Location = new System.Drawing.Point(12, 128);
            this.Button_regisztralas.Name = "Button_regisztralas";
            this.Button_regisztralas.Size = new System.Drawing.Size(75, 23);
            this.Button_regisztralas.TabIndex = 3;
            this.Button_regisztralas.Text = "Regisztrálás";
            this.Button_regisztralas.UseVisualStyleBackColor = true;
            this.Button_regisztralas.Click += new System.EventHandler(this.Button_regisztralas_Click);
            // 
            // Button_torles
            // 
            this.Button_torles.Location = new System.Drawing.Point(197, 128);
            this.Button_torles.Name = "Button_torles";
            this.Button_torles.Size = new System.Drawing.Size(75, 23);
            this.Button_torles.TabIndex = 4;
            this.Button_torles.Text = "Törlés";
            this.Button_torles.UseVisualStyleBackColor = true;
            this.Button_torles.Click += new System.EventHandler(this.Button_torles_Click);
            // 
            // Button_update
            // 
            this.Button_update.Location = new System.Drawing.Point(104, 128);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(75, 23);
            this.Button_update.TabIndex = 5;
            this.Button_update.Text = "Update";
            this.Button_update.UseVisualStyleBackColor = true;
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // Label_Reg_userek
            // 
            this.Label_Reg_userek.BackColor = System.Drawing.Color.White;
            this.Label_Reg_userek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Reg_userek.Location = new System.Drawing.Point(12, 165);
            this.Label_Reg_userek.Name = "Label_Reg_userek";
            this.Label_Reg_userek.Size = new System.Drawing.Size(260, 23);
            this.Label_Reg_userek.TabIndex = 6;
            this.Label_Reg_userek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox_felhasznalok
            // 
            this.ListBox_felhasznalok.FormattingEnabled = true;
            this.ListBox_felhasznalok.Location = new System.Drawing.Point(12, 199);
            this.ListBox_felhasznalok.Name = "ListBox_felhasznalok";
            this.ListBox_felhasznalok.Size = new System.Drawing.Size(260, 56);
            this.ListBox_felhasznalok.TabIndex = 7;
            // 
            // ListBox_statisztika
            // 
            this.ListBox_statisztika.FormattingEnabled = true;
            this.ListBox_statisztika.Location = new System.Drawing.Point(12, 266);
            this.ListBox_statisztika.Name = "ListBox_statisztika";
            this.ListBox_statisztika.Size = new System.Drawing.Size(260, 56);
            this.ListBox_statisztika.TabIndex = 8;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 335);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(260, 138);
            this.DataGridView.TabIndex = 9;
            // 
            // Form_adatbazis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 488);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ListBox_statisztika);
            this.Controls.Add(this.ListBox_felhasznalok);
            this.Controls.Add(this.Label_Reg_userek);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_torles);
            this.Controls.Add(this.Button_regisztralas);
            this.Controls.Add(this.DateTimePicker_szul_ido);
            this.Controls.Add(this.TextBox_jelszo);
            this.Controls.Add(this.TextBox_nev);
            this.MinimumSize = new System.Drawing.Size(300, 527);
            this.Name = "Form_adatbazis";
            this.Text = "Adatbázis";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_nev;
        private System.Windows.Forms.TextBox TextBox_jelszo;
        private System.Windows.Forms.DateTimePicker DateTimePicker_szul_ido;
        private System.Windows.Forms.Button Button_regisztralas;
        private System.Windows.Forms.Button Button_torles;
        private System.Windows.Forms.Button Button_update;
        private System.Windows.Forms.Label Label_Reg_userek;
        private System.Windows.Forms.ListBox ListBox_felhasznalok;
        private System.Windows.Forms.ListBox ListBox_statisztika;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}

