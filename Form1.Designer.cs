namespace gestiondvd
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lstDvd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutDvd = new System.Windows.Forms.Button();
            this.btnSupprDvd = new System.Windows.Forms.Button();
            this.btnModifDvd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDurée = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnSupprGenre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstActeur = new System.Windows.Forms.ListBox();
            this.txtAjoutGenre = new System.Windows.Forms.TextBox();
            this.btnAjoutGenre = new System.Windows.Forms.Button();
            this.btnAjoutActeurDvd = new System.Windows.Forms.Button();
            this.btnSupprActeurDvd = new System.Windows.Forms.Button();
            this.cboActeur = new System.Windows.Forms.ComboBox();
            this.btnSupprActeur = new System.Windows.Forms.Button();
            this.txtAjoutActeur = new System.Windows.Forms.TextBox();
            this.btnAjoutActeur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "TESTING MYSQL CONNECTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDvd
            // 
            this.lstDvd.FormattingEnabled = true;
            this.lstDvd.ItemHeight = 16;
            this.lstDvd.Location = new System.Drawing.Point(10, 194);
            this.lstDvd.Name = "lstDvd";
            this.lstDvd.Size = new System.Drawing.Size(301, 372);
            this.lstDvd.TabIndex = 1;
            this.lstDvd.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "lst des Dvd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAjoutDvd
            // 
            this.btnAjoutDvd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAjoutDvd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjoutDvd.FlatAppearance.BorderSize = 0;
            this.btnAjoutDvd.Location = new System.Drawing.Point(317, 165);
            this.btnAjoutDvd.Name = "btnAjoutDvd";
            this.btnAjoutDvd.Size = new System.Drawing.Size(202, 23);
            this.btnAjoutDvd.TabIndex = 3;
            this.btnAjoutDvd.Text = "Ajout Dvd (sans les acteurs)";
            this.btnAjoutDvd.UseVisualStyleBackColor = false;
            // 
            // btnSupprDvd
            // 
            this.btnSupprDvd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSupprDvd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprDvd.FlatAppearance.BorderSize = 0;
            this.btnSupprDvd.Location = new System.Drawing.Point(317, 197);
            this.btnSupprDvd.Name = "btnSupprDvd";
            this.btnSupprDvd.Size = new System.Drawing.Size(202, 23);
            this.btnSupprDvd.TabIndex = 4;
            this.btnSupprDvd.Text = "Suppr Dvd";
            this.btnSupprDvd.UseVisualStyleBackColor = false;
            // 
            // btnModifDvd
            // 
            this.btnModifDvd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModifDvd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModifDvd.FlatAppearance.BorderSize = 0;
            this.btnModifDvd.Location = new System.Drawing.Point(317, 226);
            this.btnModifDvd.Name = "btnModifDvd";
            this.btnModifDvd.Size = new System.Drawing.Size(202, 23);
            this.btnModifDvd.TabIndex = 5;
            this.btnModifDvd.Text = "Modif (titre durée genre)";
            this.btnModifDvd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // txtDurée
            // 
            this.txtDurée.Location = new System.Drawing.Point(585, 194);
            this.txtDurée.Name = "txtDurée";
            this.txtDurée.Size = new System.Drawing.Size(183, 22);
            this.txtDurée.TabIndex = 9;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(585, 162);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(401, 22);
            this.txtTitre.TabIndex = 10;
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(585, 225);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(291, 24);
            this.cboGenre.TabIndex = 11;
            // 
            // btnSupprGenre
            // 
            this.btnSupprGenre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSupprGenre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprGenre.FlatAppearance.BorderSize = 0;
            this.btnSupprGenre.Location = new System.Drawing.Point(882, 222);
            this.btnSupprGenre.Name = "btnSupprGenre";
            this.btnSupprGenre.Size = new System.Drawing.Size(104, 23);
            this.btnSupprGenre.TabIndex = 12;
            this.btnSupprGenre.Text = "Suppr Genre";
            this.btnSupprGenre.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Acteurs";
            // 
            // lstActeur
            // 
            this.lstActeur.FormattingEnabled = true;
            this.lstActeur.ItemHeight = 16;
            this.lstActeur.Location = new System.Drawing.Point(592, 311);
            this.lstActeur.Name = "lstActeur";
            this.lstActeur.Size = new System.Drawing.Size(284, 180);
            this.lstActeur.TabIndex = 14;
            // 
            // txtAjoutGenre
            // 
            this.txtAjoutGenre.Location = new System.Drawing.Point(588, 260);
            this.txtAjoutGenre.Name = "txtAjoutGenre";
            this.txtAjoutGenre.Size = new System.Drawing.Size(288, 22);
            this.txtAjoutGenre.TabIndex = 15;
            // 
            // btnAjoutGenre
            // 
            this.btnAjoutGenre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAjoutGenre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjoutGenre.FlatAppearance.BorderSize = 0;
            this.btnAjoutGenre.Location = new System.Drawing.Point(882, 257);
            this.btnAjoutGenre.Name = "btnAjoutGenre";
            this.btnAjoutGenre.Size = new System.Drawing.Size(104, 23);
            this.btnAjoutGenre.TabIndex = 16;
            this.btnAjoutGenre.Text = "Ajout Genre";
            this.btnAjoutGenre.UseVisualStyleBackColor = false;
            // 
            // btnAjoutActeurDvd
            // 
            this.btnAjoutActeurDvd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAjoutActeurDvd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjoutActeurDvd.FlatAppearance.BorderSize = 0;
            this.btnAjoutActeurDvd.Location = new System.Drawing.Point(882, 311);
            this.btnAjoutActeurDvd.Name = "btnAjoutActeurDvd";
            this.btnAjoutActeurDvd.Size = new System.Drawing.Size(32, 23);
            this.btnAjoutActeurDvd.TabIndex = 17;
            this.btnAjoutActeurDvd.Text = "+";
            this.btnAjoutActeurDvd.UseVisualStyleBackColor = false;
            // 
            // btnSupprActeurDvd
            // 
            this.btnSupprActeurDvd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSupprActeurDvd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprActeurDvd.FlatAppearance.BorderSize = 0;
            this.btnSupprActeurDvd.Location = new System.Drawing.Point(882, 340);
            this.btnSupprActeurDvd.Name = "btnSupprActeurDvd";
            this.btnSupprActeurDvd.Size = new System.Drawing.Size(32, 23);
            this.btnSupprActeurDvd.TabIndex = 18;
            this.btnSupprActeurDvd.Text = "-";
            this.btnSupprActeurDvd.UseVisualStyleBackColor = false;
            // 
            // cboActeur
            // 
            this.cboActeur.FormattingEnabled = true;
            this.cboActeur.Location = new System.Drawing.Point(594, 507);
            this.cboActeur.Name = "cboActeur";
            this.cboActeur.Size = new System.Drawing.Size(282, 24);
            this.cboActeur.TabIndex = 19;
            // 
            // btnSupprActeur
            // 
            this.btnSupprActeur.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSupprActeur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprActeur.FlatAppearance.BorderSize = 0;
            this.btnSupprActeur.Location = new System.Drawing.Point(882, 506);
            this.btnSupprActeur.Name = "btnSupprActeur";
            this.btnSupprActeur.Size = new System.Drawing.Size(104, 23);
            this.btnSupprActeur.TabIndex = 20;
            this.btnSupprActeur.Text = "Suppr acteur";
            this.btnSupprActeur.UseVisualStyleBackColor = false;
            // 
            // txtAjoutActeur
            // 
            this.txtAjoutActeur.Location = new System.Drawing.Point(595, 543);
            this.txtAjoutActeur.Name = "txtAjoutActeur";
            this.txtAjoutActeur.Size = new System.Drawing.Size(281, 22);
            this.txtAjoutActeur.TabIndex = 21;
            // 
            // btnAjoutActeur
            // 
            this.btnAjoutActeur.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAjoutActeur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjoutActeur.FlatAppearance.BorderSize = 0;
            this.btnAjoutActeur.Location = new System.Drawing.Point(882, 543);
            this.btnAjoutActeur.Name = "btnAjoutActeur";
            this.btnAjoutActeur.Size = new System.Drawing.Size(104, 23);
            this.btnAjoutActeur.TabIndex = 22;
            this.btnAjoutActeur.Text = "Ajout acteur";
            this.btnAjoutActeur.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 600);
            this.Controls.Add(this.btnAjoutActeur);
            this.Controls.Add(this.txtAjoutActeur);
            this.Controls.Add(this.btnSupprActeur);
            this.Controls.Add(this.cboActeur);
            this.Controls.Add(this.btnSupprActeurDvd);
            this.Controls.Add(this.btnAjoutActeurDvd);
            this.Controls.Add(this.btnAjoutGenre);
            this.Controls.Add(this.txtAjoutGenre);
            this.Controls.Add(this.lstActeur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSupprGenre);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.txtDurée);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifDvd);
            this.Controls.Add(this.btnSupprDvd);
            this.Controls.Add(this.btnAjoutDvd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDvd);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Gestion des DVD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstDvd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutDvd;
        private System.Windows.Forms.Button btnSupprDvd;
        private System.Windows.Forms.Button btnModifDvd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDurée;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnSupprGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstActeur;
        private System.Windows.Forms.TextBox txtAjoutGenre;
        private System.Windows.Forms.Button btnAjoutGenre;
        private System.Windows.Forms.Button btnAjoutActeurDvd;
        private System.Windows.Forms.Button btnSupprActeurDvd;
        private System.Windows.Forms.ComboBox cboActeur;
        private System.Windows.Forms.Button btnSupprActeur;
        private System.Windows.Forms.TextBox txtAjoutActeur;
        private System.Windows.Forms.Button btnAjoutActeur;
    }
}

