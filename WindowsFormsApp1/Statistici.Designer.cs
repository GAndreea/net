namespace WindowsFormsApp1
{
    partial class Statistici
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listCititori = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panala = new System.Windows.Forms.DateTimePicker();
            this.dela = new System.Windows.Forms.DateTimePicker();
            this.cititori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listCarti = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listAutori = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listGenuri = new System.Windows.Forms.ListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.carteId = new System.Windows.Forms.TextBox();
            this.listReviewuri = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numeCarte = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listCititori);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panala);
            this.tabPage1.Controls.Add(this.dela);
            this.tabPage1.Controls.Add(this.cititori);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Useri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listCititori
            // 
            this.listCititori.Location = new System.Drawing.Point(13, 196);
            this.listCititori.Name = "listCititori";
            this.listCititori.Size = new System.Drawing.Size(220, 126);
            this.listCititori.TabIndex = 7;
            this.listCititori.UseCompatibleStateImageBehavior = false;
            this.listCititori.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cititori intr-o anumita perioada";
            // 
            // panala
            // 
            this.panala.Location = new System.Drawing.Point(10, 128);
            this.panala.Name = "panala";
            this.panala.Size = new System.Drawing.Size(223, 20);
            this.panala.TabIndex = 3;
            // 
            // dela
            // 
            this.dela.Location = new System.Drawing.Point(10, 90);
            this.dela.Name = "dela";
            this.dela.Size = new System.Drawing.Size(223, 20);
            this.dela.TabIndex = 2;
            // 
            // cititori
            // 
            this.cititori.Location = new System.Drawing.Point(99, 14);
            this.cititori.Name = "cititori";
            this.cititori.Size = new System.Drawing.Size(100, 20);
            this.cititori.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr Cititori in total:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listCarti);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listCarti
            // 
            this.listCarti.Location = new System.Drawing.Point(6, 43);
            this.listCarti.Name = "listCarti";
            this.listCarti.Size = new System.Drawing.Size(236, 222);
            this.listCarti.TabIndex = 1;
            this.listCarti.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cele mai solicitate carti";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listAutori);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(251, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Autori";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cei mai cautati autori:";
            // 
            // listAutori
            // 
            this.listAutori.Location = new System.Drawing.Point(18, 51);
            this.listAutori.Name = "listAutori";
            this.listAutori.Size = new System.Drawing.Size(217, 231);
            this.listAutori.TabIndex = 1;
            this.listAutori.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listGenuri);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(251, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Genuri";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cele mai solicitate genuri";
            // 
            // listGenuri
            // 
            this.listGenuri.Location = new System.Drawing.Point(19, 55);
            this.listGenuri.Name = "listGenuri";
            this.listGenuri.Size = new System.Drawing.Size(216, 192);
            this.listGenuri.TabIndex = 1;
            this.listGenuri.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.numeCarte);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.listReviewuri);
            this.tabPage5.Controls.Add(this.carteId);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(251, 328);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Reviewuri";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // carteId
            // 
            this.carteId.Location = new System.Drawing.Point(40, 27);
            this.carteId.Name = "carteId";
            this.carteId.Size = new System.Drawing.Size(81, 20);
            this.carteId.TabIndex = 0;
            // 
            // listReviewuri
            // 
            this.listReviewuri.Location = new System.Drawing.Point(21, 105);
            this.listReviewuri.Name = "listReviewuri";
            this.listReviewuri.Size = new System.Drawing.Size(215, 183);
            this.listReviewuri.TabIndex = 1;
            this.listReviewuri.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "vezi reviewuri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "id:";
            // 
            // numeCarte
            // 
            this.numeCarte.Location = new System.Drawing.Point(21, 72);
            this.numeCarte.Name = "numeCarte";
            this.numeCarte.Size = new System.Drawing.Size(100, 20);
            this.numeCarte.TabIndex = 4;
            // 
            // Statistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 379);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistici";
            this.Text = "Statistici";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker panala;
        private System.Windows.Forms.DateTimePicker dela;
        private System.Windows.Forms.TextBox cititori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listCititori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listCarti;
        private System.Windows.Forms.ListView listAutori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listGenuri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listReviewuri;
        private System.Windows.Forms.TextBox carteId;
        private System.Windows.Forms.TextBox numeCarte;
        private System.Windows.Forms.Label label6;
    }
}