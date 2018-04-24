namespace WindowsFormsApp1
{
    partial class RestituieCarte
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
            this.email = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.imprumuturi = new System.Windows.Forms.ListView();
            this.nuImprumuturi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.restituieGrup = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idImprumut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.review = new System.Windows.Forms.TextBox();
            this.restituieGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restituie o carte";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(13, 47);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(31, 13);
            this.email.TabIndex = 1;
            this.email.Text = "email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(59, 44);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(200, 20);
            this.emailBox.TabIndex = 2;
            // 
            // imprumuturi
            // 
            this.imprumuturi.Location = new System.Drawing.Point(16, 91);
            this.imprumuturi.Name = "imprumuturi";
            this.imprumuturi.Size = new System.Drawing.Size(495, 97);
            this.imprumuturi.TabIndex = 3;
            this.imprumuturi.UseCompatibleStateImageBehavior = false;
            this.imprumuturi.Visible = false;
            this.imprumuturi.SelectedIndexChanged += new System.EventHandler(this.imprumuturi_SelectedIndexChanged);
            // 
            // nuImprumuturi
            // 
            this.nuImprumuturi.Location = new System.Drawing.Point(16, 91);
            this.nuImprumuturi.Name = "nuImprumuturi";
            this.nuImprumuturi.Size = new System.Drawing.Size(256, 20);
            this.nuImprumuturi.TabIndex = 4;
            this.nuImprumuturi.Visible = false;
            this.nuImprumuturi.TextChanged += new System.EventHandler(this.nuImprumuturi_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vezi imprumuturi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // restituieGrup
            // 
            this.restituieGrup.Controls.Add(this.review);
            this.restituieGrup.Controls.Add(this.label3);
            this.restituieGrup.Controls.Add(this.idImprumut);
            this.restituieGrup.Controls.Add(this.label2);
            this.restituieGrup.Controls.Add(this.rezultat);
            this.restituieGrup.Controls.Add(this.button2);
            this.restituieGrup.Location = new System.Drawing.Point(16, 206);
            this.restituieGrup.Name = "restituieGrup";
            this.restituieGrup.Size = new System.Drawing.Size(495, 137);
            this.restituieGrup.TabIndex = 6;
            this.restituieGrup.TabStop = false;
            this.restituieGrup.Text = "Restituie";
            this.restituieGrup.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Restituie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(12, 98);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(384, 20);
            this.rezultat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id-ul :";
            // 
            // idImprumut
            // 
            this.idImprumut.Location = new System.Drawing.Point(71, 31);
            this.idImprumut.Name = "idImprumut";
            this.idImprumut.Size = new System.Drawing.Size(100, 20);
            this.idImprumut.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Review:";
            // 
            // review
            // 
            this.review.Location = new System.Drawing.Point(71, 66);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(325, 20);
            this.review.TabIndex = 11;
            // 
            // RestituieCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 355);
            this.Controls.Add(this.restituieGrup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nuImprumuturi);
            this.Controls.Add(this.imprumuturi);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "RestituieCarte";
            this.Text = "RestituieCarte";
            this.restituieGrup.ResumeLayout(false);
            this.restituieGrup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.ListView imprumuturi;
        private System.Windows.Forms.TextBox nuImprumuturi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox restituieGrup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.TextBox idImprumut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox review;
        private System.Windows.Forms.Label label3;
    }
}