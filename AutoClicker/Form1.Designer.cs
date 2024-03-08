namespace AutoClicker
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
            this.components = new System.ComponentModel.Container();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.sToggleButton1 = new Sipaa.Framework.SToggleButton();
            this.sPanel3 = new Sipaa.Framework.SPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.sToggleButton2 = new Sipaa.Framework.SToggleButton();
            this.sDropdownMenu1 = new Sipaa.Framework.SDropdownMenu(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.leftClickerTimer = new System.Windows.Forms.Timer(this.components);
            this.rightClickerTimer = new System.Windows.Forms.Timer(this.components);
            this.nav1 = new AutoClicker.Nav();
            this.sPanel1.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.sPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 12;
            this.sEllipse1.TargetControl = this;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel1.BorderRadius = 6;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.guna2CircleButton2);
            this.sPanel1.Controls.Add(this.guna2CircleButton1);
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(12, 12);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(776, 76);
            this.sPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Akira Expanded", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(611, 67);
            this.label2.TabIndex = 6;
            this.label2.Text = "LSD Clicker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(660, 16);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(42, 42);
            this.guna2CircleButton2.TabIndex = 5;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(708, 16);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(42, 42);
            this.guna2CircleButton1.TabIndex = 4;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel2.BorderRadius = 6;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.Controls.Add(this.label3);
            this.sPanel2.Controls.Add(this.label1);
            this.sPanel2.Controls.Add(this.guna2TrackBar1);
            this.sPanel2.Controls.Add(this.sToggleButton1);
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(105, 94);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(337, 281);
            this.sPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Left Click";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "10CPS";
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(15, 46);
            this.guna2TrackBar1.Maximum = 25;
            this.guna2TrackBar1.Minimum = 1;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(300, 43);
            this.guna2TrackBar1.TabIndex = 2;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBar1.Value = 10;
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // sToggleButton1
            // 
            this.sToggleButton1.AutoSize = true;
            this.sToggleButton1.Location = new System.Drawing.Point(15, 18);
            this.sToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.sToggleButton1.Name = "sToggleButton1";
            this.sToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.sToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.sToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.sToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.sToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.sToggleButton1.TabIndex = 0;
            this.sToggleButton1.UseVisualStyleBackColor = true;
            this.sToggleButton1.CheckedChanged += new System.EventHandler(this.sToggleButton1_CheckedChanged);
            // 
            // sPanel3
            // 
            this.sPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel3.BorderRadius = 6;
            this.sPanel3.BorderSize = 0;
            this.sPanel3.Controls.Add(this.label4);
            this.sPanel3.Controls.Add(this.guna2TrackBar2);
            this.sPanel3.Controls.Add(this.sToggleButton2);
            this.sPanel3.ForeColor = System.Drawing.Color.White;
            this.sPanel3.Location = new System.Drawing.Point(451, 94);
            this.sPanel3.Name = "sPanel3";
            this.sPanel3.Size = new System.Drawing.Size(337, 281);
            this.sPanel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Right Click";
            // 
            // guna2TrackBar2
            // 
            this.guna2TrackBar2.Location = new System.Drawing.Point(24, 50);
            this.guna2TrackBar2.Maximum = 25;
            this.guna2TrackBar2.Minimum = 1;
            this.guna2TrackBar2.Name = "guna2TrackBar2";
            this.guna2TrackBar2.Size = new System.Drawing.Size(300, 43);
            this.guna2TrackBar2.TabIndex = 6;
            this.guna2TrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBar2.Value = 10;
            // 
            // sToggleButton2
            // 
            this.sToggleButton2.AutoSize = true;
            this.sToggleButton2.Location = new System.Drawing.Point(24, 22);
            this.sToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.sToggleButton2.Name = "sToggleButton2";
            this.sToggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.sToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.sToggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.sToggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.sToggleButton2.Size = new System.Drawing.Size(45, 22);
            this.sToggleButton2.TabIndex = 5;
            this.sToggleButton2.UseVisualStyleBackColor = true;
            this.sToggleButton2.CheckedChanged += new System.EventHandler(this.sToggleButton2_CheckedChanged);
            // 
            // sDropdownMenu1
            // 
            this.sDropdownMenu1.IsMainMenu = false;
            this.sDropdownMenu1.MenuItemHeight = 25;
            this.sDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.sDropdownMenu1.Name = "sDropdownMenu1";
            this.sDropdownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.sDropdownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.sPanel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.sPanel2;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl4.TargetControl = this.sPanel3;
            this.guna2DragControl4.UseTransparentDrag = true;
            // 
            // leftClickerTimer
            // 
            this.leftClickerTimer.Tick += new System.EventHandler(this.leftClickerTimer_Tick);
            // 
            // rightClickerTimer
            // 
            this.rightClickerTimer.Tick += new System.EventHandler(this.rightClickerTimer_Tick);
            // 
            // nav1
            // 
            this.nav1.Location = new System.Drawing.Point(12, 94);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(83, 286);
            this.nav1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.nav1);
            this.Controls.Add(this.sPanel3);
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.sPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            this.sPanel3.ResumeLayout(false);
            this.sPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sipaa.Framework.SEllipse sEllipse1;
        private Sipaa.Framework.SPanel sPanel3;
        private Sipaa.Framework.SPanel sPanel2;
        private Sipaa.Framework.SPanel sPanel1;
        private Sipaa.Framework.SDropdownMenu sDropdownMenu1;
        private Sipaa.Framework.SToggleButton sToggleButton1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer leftClickerTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar2;
        private Sipaa.Framework.SToggleButton sToggleButton2;
        private System.Windows.Forms.Timer rightClickerTimer;
        private Nav nav1;
    }
}

