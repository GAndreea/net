﻿namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titluCarte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prenumeAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nrExemplare = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.restitue = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Achizitie Carte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titlu Carte";
            // 
            // titluCarte
            // 
            this.titluCarte.Location = new System.Drawing.Point(120, 64);
            this.titluCarte.Name = "titluCarte";
            this.titluCarte.Size = new System.Drawing.Size(201, 20);
            this.titluCarte.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nume Autor";
            // 
            // numeAutor
            // 
            this.numeAutor.Location = new System.Drawing.Point(120, 99);
            this.numeAutor.Name = "numeAutor";
            this.numeAutor.Size = new System.Drawing.Size(201, 20);
            this.numeAutor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenume Autor";
            // 
            // prenumeAutor
            // 
            this.prenumeAutor.Location = new System.Drawing.Point(120, 135);
            this.prenumeAutor.Name = "prenumeAutor";
            this.prenumeAutor.Size = new System.Drawing.Size(201, 20);
            this.prenumeAutor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gen";
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(120, 172);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(201, 20);
            this.gen.TabIndex = 8;
            this.gen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nr Exemplare";
            // 
            // nrExemplare
            // 
            this.nrExemplare.Location = new System.Drawing.Point(120, 208);
            this.nrExemplare.Name = "nrExemplare";
            this.nrExemplare.Size = new System.Drawing.Size(201, 20);
            this.nrExemplare.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Imprumuta Carte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // restitue
            // 
            this.restitue.Location = new System.Drawing.Point(18, 19);
            this.restitue.Name = "restitue";
            this.restitue.Size = new System.Drawing.Size(108, 23);
            this.restitue.TabIndex = 12;
            this.restitue.Text = "Restituie Carte";
            this.restitue.UseVisualStyleBackColor = true;
            this.restitue.Click += new System.EventHandler(this.restitue_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Statitici";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Biblioteca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.restitue);
            this.groupBox1.Location = new System.Drawing.Point(25, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 91);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alte Meniuri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nrExemplare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenumeAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titluCarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titluCarte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenumeAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nrExemplare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button restitue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
