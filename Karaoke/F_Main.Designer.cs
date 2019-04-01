namespace Karaoke
{
    partial class F_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lb_loginas = new MetroFramework.Controls.MetroLabel();
            this.metroTile_EXIT = new MetroFramework.Controls.MetroTile();
            this.metroTile_REPORTS = new MetroFramework.Controls.MetroTile();
            this.metroTile_SERVICES_MANAGEMENT = new MetroFramework.Controls.MetroTile();
            this.metroTile_karaokeManager = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(484, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(383, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "SELECT THE ITEM YOU WANT TO USE BELOW";
            // 
            // lb_loginas
            // 
            this.lb_loginas.AutoSize = true;
            this.lb_loginas.Location = new System.Drawing.Point(1136, 6);
            this.lb_loginas.Name = "lb_loginas";
            this.lb_loginas.Size = new System.Drawing.Size(94, 20);
            this.lb_loginas.TabIndex = 7;
            this.lb_loginas.Text = "Login as: ###";
            // 
            // metroTile_EXIT
            // 
            this.metroTile_EXIT.ActiveControl = null;
            this.metroTile_EXIT.Location = new System.Drawing.Point(1222, 39);
            this.metroTile_EXIT.Name = "metroTile_EXIT";
            this.metroTile_EXIT.Size = new System.Drawing.Size(113, 36);
            this.metroTile_EXIT.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile_EXIT.TabIndex = 8;
            this.metroTile_EXIT.Text = "EXIT";
            this.metroTile_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_EXIT.UseSelectable = true;
            this.metroTile_EXIT.Click += new System.EventHandler(this.metroTile_EXIT_Click);
            // 
            // metroTile_REPORTS
            // 
            this.metroTile_REPORTS.ActiveControl = null;
            this.metroTile_REPORTS.Location = new System.Drawing.Point(940, 191);
            this.metroTile_REPORTS.Name = "metroTile_REPORTS";
            this.metroTile_REPORTS.Size = new System.Drawing.Size(395, 334);
            this.metroTile_REPORTS.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile_REPORTS.TabIndex = 3;
            this.metroTile_REPORTS.Text = "REPORTS";
            this.metroTile_REPORTS.TileImage = global::Karaoke.Properties.Resources.report;
            this.metroTile_REPORTS.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_REPORTS.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_REPORTS.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_REPORTS.UseSelectable = true;
            this.metroTile_REPORTS.UseTileImage = true;
            // 
            // metroTile_SERVICES_MANAGEMENT
            // 
            this.metroTile_SERVICES_MANAGEMENT.ActiveControl = null;
            this.metroTile_SERVICES_MANAGEMENT.Location = new System.Drawing.Point(494, 191);
            this.metroTile_SERVICES_MANAGEMENT.Name = "metroTile_SERVICES_MANAGEMENT";
            this.metroTile_SERVICES_MANAGEMENT.Size = new System.Drawing.Size(395, 334);
            this.metroTile_SERVICES_MANAGEMENT.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile_SERVICES_MANAGEMENT.TabIndex = 2;
            this.metroTile_SERVICES_MANAGEMENT.Text = "SERVICES MANAGEMENT";
            this.metroTile_SERVICES_MANAGEMENT.TileImage = global::Karaoke.Properties.Resources.manager;
            this.metroTile_SERVICES_MANAGEMENT.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_SERVICES_MANAGEMENT.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_SERVICES_MANAGEMENT.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_SERVICES_MANAGEMENT.UseSelectable = true;
            this.metroTile_SERVICES_MANAGEMENT.UseTileImage = true;
            this.metroTile_SERVICES_MANAGEMENT.Click += new System.EventHandler(this.metroTile_SERVICES_MANAGEMENT_Click);
            // 
            // metroTile_karaokeManager
            // 
            this.metroTile_karaokeManager.ActiveControl = null;
            this.metroTile_karaokeManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile_karaokeManager.Location = new System.Drawing.Point(46, 191);
            this.metroTile_karaokeManager.Name = "metroTile_karaokeManager";
            this.metroTile_karaokeManager.Size = new System.Drawing.Size(395, 334);
            this.metroTile_karaokeManager.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile_karaokeManager.TabIndex = 1;
            this.metroTile_karaokeManager.Text = "KARAOKE MANAGER";
            this.metroTile_karaokeManager.TileImage = global::Karaoke.Properties.Resources.karaoke_2;
            this.metroTile_karaokeManager.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_karaokeManager.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_karaokeManager.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_karaokeManager.UseSelectable = true;
            this.metroTile_karaokeManager.UseTileImage = true;
            this.metroTile_karaokeManager.Click += new System.EventHandler(this.metroTile_karaokeManager_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 572);
            this.Controls.Add(this.metroTile_EXIT);
            this.Controls.Add(this.lb_loginas);
            this.Controls.Add(this.metroTile_REPORTS);
            this.Controls.Add(this.metroTile_SERVICES_MANAGEMENT);
            this.Controls.Add(this.metroTile_karaokeManager);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Main";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "KARAOKE PROGRAM";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile_karaokeManager;
        private MetroFramework.Controls.MetroTile metroTile_SERVICES_MANAGEMENT;
        private MetroFramework.Controls.MetroTile metroTile_REPORTS;
        private MetroFramework.Controls.MetroLabel lb_loginas;
        private MetroFramework.Controls.MetroTile metroTile_EXIT;
    }
}