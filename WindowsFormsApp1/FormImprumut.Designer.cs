namespace WindowsFormsApp1
{
    partial class FormImprumut
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
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.pas3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(92, 57);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(169, 20);
            this.email.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imprumuta o Carte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nume";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prenume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adresa";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(92, 90);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(169, 20);
            this.nume.TabIndex = 6;
            // 
            // prenume
            // 
            this.prenume.Location = new System.Drawing.Point(92, 124);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(169, 20);
            this.prenume.TabIndex = 7;
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(92, 158);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(169, 20);
            this.adresa.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Continua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(12, 233);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(122, 20);
            this.rezultat.TabIndex = 10;
            this.rezultat.Visible = false;
            // 
            // pas3
            // 
            this.pas3.Location = new System.Drawing.Point(164, 231);
            this.pas3.Name = "pas3";
            this.pas3.Size = new System.Drawing.Size(108, 23);
            this.pas3.TabIndex = 11;
            this.pas3.Text = "Pasul urmator >";
            this.pas3.UseVisualStyleBackColor = true;
            this.pas3.Visible = false;
            this.pas3.Click += new System.EventHandler(this.pas3_Click);
            // 
            // FormImprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.pas3);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "FormImprumut";
            this.Text = "FormImprumut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Button pas3;
    }
}