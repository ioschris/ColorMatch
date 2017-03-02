namespace ColorMatch
{
    partial class ColorMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorMatch));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRGBValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHexValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.btnCopyHex = new System.Windows.Forms.Button();
            this.btnCopyRGB = new System.Windows.Forms.Button();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.gbDefault = new System.Windows.Forms.GroupBox();
            this.listColors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRGBValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHexValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRGBValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHexValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.gbPreview.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbDefault.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRGBValueToolStripMenuItem,
            this.copyHexValueToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // copyRGBValueToolStripMenuItem
            // 
            this.copyRGBValueToolStripMenuItem.Name = "copyRGBValueToolStripMenuItem";
            this.copyRGBValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyRGBValueToolStripMenuItem.Text = "Copy &RGB Value";
            // 
            // copyHexValueToolStripMenuItem
            // 
            this.copyHexValueToolStripMenuItem.Name = "copyHexValueToolStripMenuItem";
            this.copyHexValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyHexValueToolStripMenuItem.Text = "Copy &Hex Value";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.pnlPreview);
            this.gbPreview.Location = new System.Drawing.Point(12, 36);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(144, 153);
            this.gbPreview.TabIndex = 4;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Color Preview";
            // 
            // pnlPreview
            // 
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreview.Location = new System.Drawing.Point(22, 30);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(100, 100);
            this.pnlPreview.TabIndex = 4;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnCustom);
            this.gbInfo.Controls.Add(this.btnColorPicker);
            this.gbInfo.Controls.Add(this.btnCopyHex);
            this.gbInfo.Controls.Add(this.btnCopyRGB);
            this.gbInfo.Controls.Add(this.txtHex);
            this.gbInfo.Controls.Add(this.lblHex);
            this.gbInfo.Controls.Add(this.lblGreen);
            this.gbInfo.Controls.Add(this.txtGreen);
            this.gbInfo.Controls.Add(this.txtBlue);
            this.gbInfo.Controls.Add(this.txtRed);
            this.gbInfo.Controls.Add(this.lblBlue);
            this.gbInfo.Controls.Add(this.lblRed);
            this.gbInfo.Location = new System.Drawing.Point(174, 36);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(307, 153);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Color Information";
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(136, 115);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(114, 23);
            this.btnCustom.TabIndex = 11;
            this.btnCustom.Text = "Custom Color";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Image = global::ColorMatch.Properties.Resources.ColorPicker_16x16;
            this.btnColorPicker.Location = new System.Drawing.Point(256, 115);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(42, 23);
            this.btnColorPicker.TabIndex = 10;
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // btnCopyHex
            // 
            this.btnCopyHex.Location = new System.Drawing.Point(136, 86);
            this.btnCopyHex.Name = "btnCopyHex";
            this.btnCopyHex.Size = new System.Drawing.Size(162, 23);
            this.btnCopyHex.TabIndex = 9;
            this.btnCopyHex.Text = "Copy &Hex Value";
            this.btnCopyHex.UseVisualStyleBackColor = true;
            this.btnCopyHex.Click += new System.EventHandler(this.btnCopyHex_Click);
            // 
            // btnCopyRGB
            // 
            this.btnCopyRGB.Location = new System.Drawing.Point(136, 57);
            this.btnCopyRGB.Name = "btnCopyRGB";
            this.btnCopyRGB.Size = new System.Drawing.Size(162, 23);
            this.btnCopyRGB.TabIndex = 8;
            this.btnCopyRGB.Text = "Copy &RGB Value";
            this.btnCopyRGB.UseVisualStyleBackColor = true;
            this.btnCopyRGB.Click += new System.EventHandler(this.btnCopyRGB_Click);
            // 
            // txtHex
            // 
            this.txtHex.Enabled = false;
            this.txtHex.Location = new System.Drawing.Point(195, 25);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(103, 20);
            this.txtHex.TabIndex = 7;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(133, 28);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(56, 13);
            this.lblHex.TabIndex = 6;
            this.lblHex.Text = "Hex Value";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(8, 59);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Green";
            // 
            // txtGreen
            // 
            this.txtGreen.Enabled = false;
            this.txtGreen.Location = new System.Drawing.Point(50, 56);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(50, 20);
            this.txtGreen.TabIndex = 5;
            // 
            // txtBlue
            // 
            this.txtBlue.Enabled = false;
            this.txtBlue.Location = new System.Drawing.Point(50, 88);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(50, 20);
            this.txtBlue.TabIndex = 4;
            // 
            // txtRed
            // 
            this.txtRed.Enabled = false;
            this.txtRed.Location = new System.Drawing.Point(50, 25);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(50, 20);
            this.txtRed.TabIndex = 3;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(8, 91);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "Blue";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(8, 28);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red";
            // 
            // gbDefault
            // 
            this.gbDefault.Controls.Add(this.listColors);
            this.gbDefault.Location = new System.Drawing.Point(12, 205);
            this.gbDefault.Name = "gbDefault";
            this.gbDefault.Size = new System.Drawing.Size(469, 197);
            this.gbDefault.TabIndex = 6;
            this.gbDefault.TabStop = false;
            this.gbDefault.Text = "Default Colors";
            // 
            // listColors
            // 
            this.listColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listColors.GridLines = true;
            this.listColors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listColors.Location = new System.Drawing.Point(14, 22);
            this.listColors.MultiSelect = false;
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(440, 160);
            this.listColors.TabIndex = 0;
            this.listColors.UseCompatibleStateImageBehavior = false;
            this.listColors.View = System.Windows.Forms.View.Details;
            this.listColors.SelectedIndexChanged += new System.EventHandler(this.listColors_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Color Name";
            this.columnHeader1.Width = 218;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color Value";
            this.columnHeader2.Width = 218;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // copyRGBValueToolStripMenuItem1
            // 
            this.copyRGBValueToolStripMenuItem1.Name = "copyRGBValueToolStripMenuItem1";
            this.copyRGBValueToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // copyHexValueToolStripMenuItem1
            // 
            this.copyHexValueToolStripMenuItem1.Name = "copyHexValueToolStripMenuItem1";
            this.copyHexValueToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem3,
            this.optionsToolStripMenuItem2,
            this.aboutToolStripMenuItem3});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(493, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem3
            // 
            this.fileToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRGBValueToolStripMenuItem2,
            this.copyHexValueToolStripMenuItem2,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem2});
            this.fileToolStripMenuItem3.Name = "fileToolStripMenuItem3";
            this.fileToolStripMenuItem3.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem3.Text = "File";
            // 
            // copyRGBValueToolStripMenuItem2
            // 
            this.copyRGBValueToolStripMenuItem2.Name = "copyRGBValueToolStripMenuItem2";
            this.copyRGBValueToolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.copyRGBValueToolStripMenuItem2.Text = "Copy &RGB Value";
            this.copyRGBValueToolStripMenuItem2.Click += new System.EventHandler(this.copyRGBValueToolStripMenuItem2_Click);
            // 
            // copyHexValueToolStripMenuItem2
            // 
            this.copyHexValueToolStripMenuItem2.Name = "copyHexValueToolStripMenuItem2";
            this.copyHexValueToolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.copyHexValueToolStripMenuItem2.Text = "Copy &Hex Value";
            this.copyHexValueToolStripMenuItem2.Click += new System.EventHandler(this.copyHexValueToolStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // closeToolStripMenuItem2
            // 
            this.closeToolStripMenuItem2.Name = "closeToolStripMenuItem2";
            this.closeToolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.closeToolStripMenuItem2.Text = "Close";
            this.closeToolStripMenuItem2.Click += new System.EventHandler(this.closeToolStripMenuItem2_Click);
            // 
            // optionsToolStripMenuItem2
            // 
            this.optionsToolStripMenuItem2.Name = "optionsToolStripMenuItem2";
            this.optionsToolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.optionsToolStripMenuItem2.Text = "Edit";
            // 
            // aboutToolStripMenuItem3
            // 
            this.aboutToolStripMenuItem3.Name = "aboutToolStripMenuItem3";
            this.aboutToolStripMenuItem3.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem3.Text = "About";
            this.aboutToolStripMenuItem3.Click += new System.EventHandler(this.aboutToolStripMenuItem3_Click);
            // 
            // ColorMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 432);
            this.Controls.Add(this.gbDefault);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "ColorMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorMatch by Chris Harris - Build: ";
            this.Load += new System.EventHandler(this.ColorMatch_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorMatch_MouseUp);
            this.gbPreview.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbDefault.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnCopyHex;
        private System.Windows.Forms.Button btnCopyRGB;
        private System.Windows.Forms.GroupBox gbDefault;
        private System.Windows.Forms.ListView listColors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem copyRGBValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyHexValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyRGBValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyHexValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copyRGBValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyHexValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem3;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

