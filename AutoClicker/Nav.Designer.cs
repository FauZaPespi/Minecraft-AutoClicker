namespace AutoClicker
{
    partial class Nav
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NavElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.sPanel3 = new Sipaa.Framework.SPanel();
            this.sPanel4 = new Sipaa.Framework.SPanel();
            this.AnimeAllNavIndex = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NavElipse
            // 
            this.NavElipse.BorderRadius = 18;
            this.NavElipse.TargetControl = this;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel2.BorderRadius = 6;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(2, 3);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(77, 65);
            this.sPanel2.TabIndex = 1;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel1.BorderRadius = 6;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(2, 74);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(77, 65);
            this.sPanel1.TabIndex = 2;
            // 
            // sPanel3
            // 
            this.sPanel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel3.BorderRadius = 6;
            this.sPanel3.BorderSize = 0;
            this.sPanel3.ForeColor = System.Drawing.Color.White;
            this.sPanel3.Location = new System.Drawing.Point(2, 145);
            this.sPanel3.Name = "sPanel3";
            this.sPanel3.Size = new System.Drawing.Size(77, 65);
            this.sPanel3.TabIndex = 3;
            // 
            // sPanel4
            // 
            this.sPanel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel4.BorderRadius = 6;
            this.sPanel4.BorderSize = 0;
            this.sPanel4.ForeColor = System.Drawing.Color.White;
            this.sPanel4.Location = new System.Drawing.Point(2, 216);
            this.sPanel4.Name = "sPanel4";
            this.sPanel4.Size = new System.Drawing.Size(77, 65);
            this.sPanel4.TabIndex = 4;
            // 
            // AnimeAllNavIndex
            // 
            this.AnimeAllNavIndex.Enabled = true;
            this.AnimeAllNavIndex.Interval = 30;
            this.AnimeAllNavIndex.Tick += new System.EventHandler(this.AnimeAllNavIndex_Tick);
            // 
            // Nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sPanel4);
            this.Controls.Add(this.sPanel3);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.sPanel2);
            this.Name = "Nav";
            this.Size = new System.Drawing.Size(83, 286);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse NavElipse;
        private Sipaa.Framework.SPanel sPanel2;
        private Sipaa.Framework.SPanel sPanel1;
        private Sipaa.Framework.SPanel sPanel3;
        private Sipaa.Framework.SPanel sPanel4;
        public System.Windows.Forms.Timer AnimeAllNavIndex;
    }
}
