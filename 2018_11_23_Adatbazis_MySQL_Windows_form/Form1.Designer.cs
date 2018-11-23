namespace _2018_11_23_Adatbazis_MySQL_Windows_form
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
            this.Button_regisztralas.Location = new System.Drawing.Point(98, 139);
            this.Button_regisztralas.Name = "Button_regisztralas";
            this.Button_regisztralas.Size = new System.Drawing.Size(75, 23);
            this.Button_regisztralas.TabIndex = 3;
            this.Button_regisztralas.Text = "Regisztrálás";
            this.Button_regisztralas.UseVisualStyleBackColor = true;
            // 
            // Form_adatbazis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Button_regisztralas);
            this.Controls.Add(this.DateTimePicker_szul_ido);
            this.Controls.Add(this.TextBox_jelszo);
            this.Controls.Add(this.TextBox_nev);
            this.Name = "Form_adatbazis";
            this.Text = "Adatbázis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_nev;
        private System.Windows.Forms.TextBox TextBox_jelszo;
        private System.Windows.Forms.DateTimePicker DateTimePicker_szul_ido;
        private System.Windows.Forms.Button Button_regisztralas;
    }
}

