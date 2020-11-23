namespace ProjetIA_01
{
    partial class FormAffichageCarte
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
            this.lblChoix = new System.Windows.Forms.Label();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.btnAfficherTrajectoire = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblNoeud = new System.Windows.Forms.Label();
            this.richTextBoxNoeud = new System.Windows.Forms.RichTextBox();
            this.lblTemps = new System.Windows.Forms.Label();
            this.Resultat = new System.Windows.Forms.GroupBox();
            this.fond = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOuverts = new System.Windows.Forms.Label();
            this.lblFermes = new System.Windows.Forms.Label();
            this.Resultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fond)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(35, 55);
            this.lblChoix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(96, 17);
            this.lblChoix.TabIndex = 10;
            this.lblChoix.Text = "Choix du cas :";
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(46, 131);
            this.radioC.Margin = new System.Windows.Forms.Padding(4);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(62, 21);
            this.radioC.TabIndex = 9;
            this.radioC.TabStop = true;
            this.radioC.Text = "cas c";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(46, 103);
            this.radioB.Margin = new System.Windows.Forms.Padding(4);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(63, 21);
            this.radioB.TabIndex = 8;
            this.radioB.TabStop = true;
            this.radioB.Text = "cas b";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(46, 74);
            this.radioA.Margin = new System.Windows.Forms.Padding(4);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(63, 21);
            this.radioA.TabIndex = 7;
            this.radioA.TabStop = true;
            this.radioA.Text = "cas a";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // btnAfficherTrajectoire
            // 
            this.btnAfficherTrajectoire.Location = new System.Drawing.Point(13, 173);
            this.btnAfficherTrajectoire.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherTrajectoire.Name = "btnAfficherTrajectoire";
            this.btnAfficherTrajectoire.Size = new System.Drawing.Size(140, 68);
            this.btnAfficherTrajectoire.TabIndex = 11;
            this.btnAfficherTrajectoire.Text = "Afficher Trajectoire";
            this.btnAfficherTrajectoire.UseVisualStyleBackColor = true;
            this.btnAfficherTrajectoire.Click += new System.EventHandler(this.btnAfficherTrajectoire_Click);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(13, 249);
            this.btnRecommencer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(140, 67);
            this.btnRecommencer.TabIndex = 12;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(13, 72);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(119, 17);
            this.lblDistance.TabIndex = 15;
            this.lblDistance.Text = "Distance Totale : ";
            // 
            // lblNoeud
            // 
            this.lblNoeud.AutoSize = true;
            this.lblNoeud.Location = new System.Drawing.Point(16, 114);
            this.lblNoeud.Name = "lblNoeud";
            this.lblNoeud.Size = new System.Drawing.Size(134, 17);
            this.lblNoeud.TabIndex = 16;
            this.lblNoeud.Text = "Noeuds successifs :";
            // 
            // richTextBoxNoeud
            // 
            this.richTextBoxNoeud.Location = new System.Drawing.Point(13, 146);
            this.richTextBoxNoeud.Name = "richTextBoxNoeud";
            this.richTextBoxNoeud.Size = new System.Drawing.Size(350, 147);
            this.richTextBoxNoeud.TabIndex = 17;
            this.richTextBoxNoeud.Text = "";
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Location = new System.Drawing.Point(10, 35);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(167, 17);
            this.lblTemps.TabIndex = 14;
            this.lblTemps.Text = "Temps de parcourt total :";
            // 
            // Resultat
            // 
            this.Resultat.Controls.Add(this.richTextBoxNoeud);
            this.Resultat.Controls.Add(this.lblNoeud);
            this.Resultat.Controls.Add(this.lblDistance);
            this.Resultat.Controls.Add(this.lblTemps);
            this.Resultat.Location = new System.Drawing.Point(575, 23);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(379, 309);
            this.Resultat.TabIndex = 18;
            this.Resultat.TabStop = false;
            this.Resultat.Text = "Résultat";
            // 
            // fond
            // 
            this.fond.Image = global::ProjetIA_01.Properties.Resources.fond_bleu1;
            this.fond.Location = new System.Drawing.Point(173, 55);
            this.fond.Margin = new System.Windows.Forms.Padding(4);
            this.fond.Name = "fond";
            this.fond.Size = new System.Drawing.Size(300, 300);
            this.fond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fond.TabIndex = 1;
            this.fond.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFermes);
            this.groupBox1.Controls.Add(this.lblOuverts);
            this.groupBox1.Location = new System.Drawing.Point(575, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ouverts / Fermés";
            // 
            // lblOuverts
            // 
            this.lblOuverts.AutoSize = true;
            this.lblOuverts.Location = new System.Drawing.Point(7, 22);
            this.lblOuverts.Name = "lblOuverts";
            this.lblOuverts.Size = new System.Drawing.Size(132, 17);
            this.lblOuverts.TabIndex = 0;
            this.lblOuverts.Text = "Nombre d\'ouverts : ";
            // 
            // lblFermes
            // 
            this.lblFermes.AutoSize = true;
            this.lblFermes.Location = new System.Drawing.Point(7, 49);
            this.lblFermes.Name = "lblFermes";
            this.lblFermes.Size = new System.Drawing.Size(137, 17);
            this.lblFermes.TabIndex = 1;
            this.lblFermes.Text = "Nombre de fermés : ";
            // 
            // FormAffichageCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.btnAfficherTrajectoire);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioA);
            this.Controls.Add(this.fond);
            this.Name = "FormAffichageCarte";
            this.Text = "FormAffichageCarte";
            this.Resultat.ResumeLayout(false);
            this.Resultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fond)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fond;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.Button btnAfficherTrajectoire;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblNoeud;
        private System.Windows.Forms.RichTextBox richTextBoxNoeud;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.GroupBox Resultat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFermes;
        private System.Windows.Forms.Label lblOuverts;
    }
}