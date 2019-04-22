namespace Karaoke
{
    partial class F_BackUpAndRestore
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
            this.metroTile_restore = new MetroFramework.Controls.MetroTile();
            this.metroTile_BackUp = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTile_restore
            // 
            this.metroTile_restore.ActiveControl = null;
            this.metroTile_restore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile_restore.Location = new System.Drawing.Point(194, 177);
            this.metroTile_restore.Name = "metroTile_restore";
            this.metroTile_restore.Size = new System.Drawing.Size(255, 240);
            this.metroTile_restore.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile_restore.TabIndex = 12;
            this.metroTile_restore.Text = "RESTORE";
            this.metroTile_restore.TileImage = global::Karaoke.Properties.Resources.backup2;
            this.metroTile_restore.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_restore.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_restore.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_restore.UseSelectable = true;
            this.metroTile_restore.UseTileImage = true;
            this.metroTile_restore.Click += new System.EventHandler(this.metroTile_restore_Click);
            // 
            // metroTile_BackUp
            // 
            this.metroTile_BackUp.ActiveControl = null;
            this.metroTile_BackUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile_BackUp.Location = new System.Drawing.Point(474, 177);
            this.metroTile_BackUp.Name = "metroTile_BackUp";
            this.metroTile_BackUp.Size = new System.Drawing.Size(255, 240);
            this.metroTile_BackUp.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile_BackUp.TabIndex = 11;
            this.metroTile_BackUp.Text = "BACK UP";
            this.metroTile_BackUp.TileImage = global::Karaoke.Properties.Resources.restore;
            this.metroTile_BackUp.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_BackUp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_BackUp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_BackUp.UseSelectable = true;
            this.metroTile_BackUp.UseTileImage = true;
            this.metroTile_BackUp.Click += new System.EventHandler(this.metroTile_BackUp_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(376, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "SELECT FUNCTION";
            // 
            // F_BackUpAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 496);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile_restore);
            this.Controls.Add(this.metroTile_BackUp);
            this.Name = "F_BackUpAndRestore";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "BACK UP AND RESTORE";
            this.Load += new System.EventHandler(this.F_BackUpAndRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile_BackUp;
        private MetroFramework.Controls.MetroTile metroTile_restore;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}