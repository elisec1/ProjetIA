namespace ProjetIA_01
{
    partial class MainForm
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
            this.fond = new System.Windows.Forms.PictureBox();
            this.btnAfficherTrajectoire = new System.Windows.Forms.Button();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.lblChoix = new System.Windows.Forms.Label();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.lblSolution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fond)).BeginInit();
            this.SuspendLayout();
            // 
            // fond
            // 
            this.fond.Image = global::ProjetIA_01.Properties.Resources.fond_bleu1;
            this.fond.Location = new System.Drawing.Point(236, 38);
            this.fond.Margin = new System.Windows.Forms.Padding(4);
            this.fond.Name = "fond";
            this.fond.Size = new System.Drawing.Size(300, 300);
            this.fond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fond.TabIndex = 0;
            this.fond.TabStop = false;
            // 
            // btnAfficherTrajectoire
            // 
            this.btnAfficherTrajectoire.Location = new System.Drawing.Point(51, 258);
            this.btnAfficherTrajectoire.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherTrajectoire.Name = "btnAfficherTrajectoire";
            this.btnAfficherTrajectoire.Size = new System.Drawing.Size(100, 52);
            this.btnAfficherTrajectoire.TabIndex = 1;
            this.btnAfficherTrajectoire.Text = "Afficher Trajectoire";
            this.btnAfficherTrajectoire.UseVisualStyleBackColor = true;
            this.btnAfficherTrajectoire.Click += new System.EventHandler(this.btnAfficherTrajectoire_Click);
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(63, 87);
            this.radioA.Margin = new System.Windows.Forms.Padding(4);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(63, 21);
            this.radioA.TabIndex = 2;
            this.radioA.TabStop = true;
            this.radioA.Text = "cas a";
            this.radioA.UseVisualStyleBackColor = true;
            this.radioA.CheckedChanged += new System.EventHandler(this.radioA_CheckedChanged);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(63, 116);
            this.radioB.Margin = new System.Windows.Forms.Padding(4);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(63, 21);
            this.radioB.TabIndex = 3;
            this.radioB.TabStop = true;
            this.radioB.Text = "cas b";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(63, 144);
            this.radioC.Margin = new System.Windows.Forms.Padding(4);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(62, 21);
            this.radioC.TabIndex = 4;
            this.radioC.TabStop = true;
            this.radioC.Text = "cas c";
            this.radioC.UseVisualStyleBackColor = true;
            this.radioC.CheckedChanged += new System.EventHandler(this.radioC_CheckedChanged);
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.Location = new System.Drawing.Point(356, 165);
            this.btnDemarrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(135, 119);
            this.btnDemarrer.TabIndex = 5;
            this.btnDemarrer.Text = "Démarrer";
            this.btnDemarrer.UseVisualStyleBackColor = true;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(52, 68);
            this.lblChoix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(96, 17);
            this.lblChoix.TabIndex = 6;
            this.lblChoix.Text = "Choix du cas :";
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(384, 414);
            this.btnRecommencer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(121, 28);
            this.btnRecommencer.TabIndex = 7;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // lblSolution
            // 
            this.lblSolution.Location = new System.Drawing.Point(571, 43);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(217, 122);
            this.lblSolution.TabIndex = 8;
            this.lblSolution.Text = "\"Une solution a été trouvée en \" + stopwatch.Elapsed.TotalSeconds + \" secondes.\"";
            this.lblSolution.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSolution.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.btnDemarrer);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioA);
            this.Controls.Add(this.btnAfficherTrajectoire);
            this.Controls.Add(this.fond);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fond;
        private System.Windows.Forms.Button btnAfficherTrajectoire;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.Button btnDemarrer;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Label lblSolution;
    }
}

