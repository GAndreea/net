namespace WindowsFormsApp1
{
    partial class AfisareCarti
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
            this.gen = new System.Windows.Forms.TextBox();
            this.afis = new System.Windows.Forms.Button();
            this.carti = new System.Windows.Forms.ListView();
            this.nuCarti = new System.Windows.Forms.TextBox();
            this.alegere = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numeAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prenumeAutor = new System.Windows.Forms.TextBox();
            this.imprumuta = new System.Windows.Forms.Button();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.cititorId = new System.Windows.Forms.TextBox();
            this.alegere.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gen Carte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(93, 20);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(100, 20);
            this.gen.TabIndex = 1;
            // 
            // afis
            // 
            this.afis.Location = new System.Drawing.Point(231, 17);
            this.afis.Name = "afis";
            this.afis.Size = new System.Drawing.Size(75, 23);
            this.afis.TabIndex = 2;
            this.afis.Text = "Afisare carti";
            this.afis.UseVisualStyleBackColor = true;
            this.afis.Click += new System.EventHandler(this.afis_Click);
            // 
            // carti
            // 
            this.carti.Location = new System.Drawing.Point(16, 66);
            this.carti.Name = "carti";
            this.carti.Size = new System.Drawing.Size(596, 120);
            this.carti.TabIndex = 3;
            this.carti.UseCompatibleStateImageBehavior = false;
            this.carti.Visible = false;
            // 
            // nuCarti
            // 
            this.nuCarti.Location = new System.Drawing.Point(16, 66);
            this.nuCarti.Name = "nuCarti";
            this.nuCarti.Size = new System.Drawing.Size(152, 20);
            this.nuCarti.TabIndex = 4;
            this.nuCarti.Visible = false;
            // 
            // alegere
            // 
            this.alegere.Controls.Add(this.imprumuta);
            this.alegere.Controls.Add(this.prenumeAutor);
            this.alegere.Controls.Add(this.label4);
            this.alegere.Controls.Add(this.numeAutor);
            this.alegere.Controls.Add(this.label3);
            this.alegere.Controls.Add(this.titlu);
            this.alegere.Controls.Add(this.label2);
            this.alegere.Location = new System.Drawing.Point(16, 193);
            this.alegere.Name = "alegere";
            this.alegere.Size = new System.Drawing.Size(596, 82);
            this.alegere.TabIndex = 5;
            this.alegere.TabStop = false;
            this.alegere.Text = "alegerea dv";
            this.alegere.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titlu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titlu
            // 
            this.titlu.Location = new System.Drawing.Point(44, 19);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(100, 20);
            this.titlu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume Autor:";
            // 
            // numeAutor
            // 
            this.numeAutor.Location = new System.Drawing.Point(233, 19);
            this.numeAutor.Name = "numeAutor";
            this.numeAutor.Size = new System.Drawing.Size(100, 20);
            this.numeAutor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prenume Autor:";
            // 
            // prenumeAutor
            // 
            this.prenumeAutor.Location = new System.Drawing.Point(446, 19);
            this.prenumeAutor.Name = "prenumeAutor";
            this.prenumeAutor.Size = new System.Drawing.Size(100, 20);
            this.prenumeAutor.TabIndex = 5;
            // 
            // imprumuta
            // 
            this.imprumuta.Location = new System.Drawing.Point(461, 53);
            this.imprumuta.Name = "imprumuta";
            this.imprumuta.Size = new System.Drawing.Size(116, 23);
            this.imprumuta.TabIndex = 6;
            this.imprumuta.Text = "Imprumuta Carte";
            this.imprumuta.UseVisualStyleBackColor = true;
            this.imprumuta.Click += new System.EventHandler(this.imprumuta_Click);
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(16, 293);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(333, 20);
            this.rezultat.TabIndex = 6;
            this.rezultat.Visible = false;
            // 
            // cititorId
            // 
            this.cititorId.Location = new System.Drawing.Point(511, 20);
            this.cititorId.Name = "cititorId";
            this.cititorId.Size = new System.Drawing.Size(100, 20);
            this.cititorId.TabIndex = 7;
            this.cititorId.Visible = false;
            // 
            // AfisareCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 331);
            this.Controls.Add(this.cititorId);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.alegere);
            this.Controls.Add(this.nuCarti);
            this.Controls.Add(this.carti);
            this.Controls.Add(this.afis);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.label1);
            this.Name = "AfisareCarti";
            this.Text = "AfisareCarti";
            this.alegere.ResumeLayout(false);
            this.alegere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gen;
        private System.Windows.Forms.Button afis;
        private System.Windows.Forms.ListView carti;
        private System.Windows.Forms.TextBox nuCarti;
        private System.Windows.Forms.GroupBox alegere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenumeAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titlu;
        private System.Windows.Forms.Button imprumuta;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.TextBox cititorId;
    }
}