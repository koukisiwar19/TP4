
namespace TP4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomprenom = new System.Windows.Forms.TextBox();
            this.txtds = new System.Windows.Forms.TextBox();
            this.txtexaman = new System.Windows.Forms.TextBox();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.txtmoyenne = new System.Windows.Forms.TextBox();
            this.Moyenne = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.ListBox();
            this.btcal = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSupp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom & prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note DS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note Examen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note NP";
            // 
            // txtnomprenom
            // 
            this.txtnomprenom.Location = new System.Drawing.Point(161, 58);
            this.txtnomprenom.Name = "txtnomprenom";
            this.txtnomprenom.Size = new System.Drawing.Size(117, 23);
            this.txtnomprenom.TabIndex = 4;
            this.txtnomprenom.TextChanged += new System.EventHandler(this.txtnomprenom_TextChanged);
            // 
            // txtds
            // 
            this.txtds.Location = new System.Drawing.Point(161, 105);
            this.txtds.Name = "txtds";
            this.txtds.Size = new System.Drawing.Size(117, 23);
            this.txtds.TabIndex = 5;
            this.txtds.TextChanged += new System.EventHandler(this.txtds_TextChanged);
            // 
            // txtexaman
            // 
            this.txtexaman.Location = new System.Drawing.Point(161, 149);
            this.txtexaman.Name = "txtexaman";
            this.txtexaman.Size = new System.Drawing.Size(117, 23);
            this.txtexaman.TabIndex = 6;
            this.txtexaman.TextChanged += new System.EventHandler(this.txtexaman_TextChanged);
            // 
            // txtNP
            // 
            this.txtNP.Location = new System.Drawing.Point(161, 196);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(117, 23);
            this.txtNP.TabIndex = 7;
            this.txtNP.TextChanged += new System.EventHandler(this.txtNP_TextChanged);
            // 
            // txtmoyenne
            // 
            this.txtmoyenne.Enabled = false;
            this.txtmoyenne.Location = new System.Drawing.Point(161, 241);
            this.txtmoyenne.Name = "txtmoyenne";
            this.txtmoyenne.Size = new System.Drawing.Size(117, 23);
            this.txtmoyenne.TabIndex = 8;
            this.txtmoyenne.TextChanged += new System.EventHandler(this.txtmoyenne_TextChanged);
            // 
            // Moyenne
            // 
            this.Moyenne.AutoSize = true;
            this.Moyenne.Location = new System.Drawing.Point(39, 248);
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.Size = new System.Drawing.Size(57, 15);
            this.Moyenne.TabIndex = 9;
            this.Moyenne.Text = "Moyenne";
            // 
            // Liste
            // 
            this.Liste.FormattingEnabled = true;
            this.Liste.ItemHeight = 15;
            this.Liste.Location = new System.Drawing.Point(296, 58);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(256, 214);
            this.Liste.TabIndex = 10;
            this.Liste.SelectedIndexChanged += new System.EventHandler(this.Liste_SelectedIndexChanged);
            // 
            // btcal
            // 
            this.btcal.Enabled = false;
            this.btcal.Location = new System.Drawing.Point(69, 305);
            this.btcal.Name = "btcal";
            this.btcal.Size = new System.Drawing.Size(94, 29);
            this.btcal.TabIndex = 11;
            this.btcal.Text = "Calculer";
            this.btcal.UseVisualStyleBackColor = true;
            this.btcal.Click += new System.EventHandler(this.btcal_Click);
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(195, 305);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(98, 29);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Ajouter";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSupp
            // 
            this.btSupp.Enabled = false;
            this.btSupp.Location = new System.Drawing.Point(320, 305);
            this.btSupp.Name = "btSupp";
            this.btSupp.Size = new System.Drawing.Size(105, 28);
            this.btSupp.TabIndex = 13;
            this.btSupp.Text = "Supprimer";
            this.btSupp.UseVisualStyleBackColor = true;
            this.btSupp.Click += new System.EventHandler(this.btSupp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSupp);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btcal);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.Moyenne);
            this.Controls.Add(this.txtmoyenne);
            this.Controls.Add(this.txtNP);
            this.Controls.Add(this.txtexaman);
            this.Controls.Add(this.txtds);
            this.Controls.Add(this.txtnomprenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcul de Moyenne";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomprenom;
        private System.Windows.Forms.TextBox txtds;
        private System.Windows.Forms.TextBox txtexaman;
        private System.Windows.Forms.TextBox txtNP;
        private System.Windows.Forms.TextBox txtmoyenne;
        private System.Windows.Forms.Label Moyenne;
        private System.Windows.Forms.ListBox Liste;
        private System.Windows.Forms.Button btcal;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSupp;
    }
}

