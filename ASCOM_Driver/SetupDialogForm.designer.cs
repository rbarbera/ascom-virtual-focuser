namespace ASCOM.DarkSkyGeek
{
    partial class SetupDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDialogForm));
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.DSGLogo = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.focuserSelectorLabel = new System.Windows.Forms.Label();
            this.focuserSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.positionToleranceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DSGLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Image = global::ASCOM.DarkSkyGeek.Properties.Resources.icon_ok_24;
            this.cmdOK.Location = new System.Drawing.Point(419, 230);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(79, 44);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::ASCOM.DarkSkyGeek.Properties.Resources.icon_cancel_24;
            this.cmdCancel.Location = new System.Drawing.Point(505, 230);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(79, 44);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // chkTrace
            // 
            this.chkTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(16, 255);
            this.chkTrace.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(83, 20);
            this.chkTrace.TabIndex = 6;
            this.chkTrace.Text = "Trace on";
            this.chkTrace.UseVisualStyleBackColor = true;
            // 
            // DSGLogo
            // 
            this.DSGLogo.Image = global::ASCOM.DarkSkyGeek.Properties.Resources.darkskygeek;
            this.DSGLogo.Location = new System.Drawing.Point(16, 15);
            this.DSGLogo.Margin = new System.Windows.Forms.Padding(4);
            this.DSGLogo.Name = "DSGLogo";
            this.DSGLogo.Size = new System.Drawing.Size(88, 88);
            this.DSGLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DSGLogo.TabIndex = 7;
            this.DSGLogo.TabStop = false;
            this.DSGLogo.Click += new System.EventHandler(this.BrowseToHomepage);
            this.DSGLogo.DoubleClick += new System.EventHandler(this.BrowseToHomepage);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Location = new System.Drawing.Point(143, 16);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(441, 95);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // focuserSelectorLabel
            // 
            this.focuserSelectorLabel.AutoSize = true;
            this.focuserSelectorLabel.Location = new System.Drawing.Point(17, 151);
            this.focuserSelectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focuserSelectorLabel.Name = "focuserSelectorLabel";
            this.focuserSelectorLabel.Size = new System.Drawing.Size(59, 16);
            this.focuserSelectorLabel.TabIndex = 9;
            this.focuserSelectorLabel.Text = "Focuser:";
            // 
            // focuserSelectorComboBox
            // 
            this.focuserSelectorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.focuserSelectorComboBox.FormattingEnabled = true;
            this.focuserSelectorComboBox.Location = new System.Drawing.Point(146, 151);
            this.focuserSelectorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.focuserSelectorComboBox.Name = "focuserSelectorComboBox";
            this.focuserSelectorComboBox.Size = new System.Drawing.Size(438, 24);
            this.focuserSelectorComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Position Tolerance:";
            // 
            // positionToleranceTextBox
            // 
            this.positionToleranceTextBox.Location = new System.Drawing.Point(146, 189);
            this.positionToleranceTextBox.Name = "positionToleranceTextBox";
            this.positionToleranceTextBox.Size = new System.Drawing.Size(74, 22);
            this.positionToleranceTextBox.TabIndex = 12;
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 285);
            this.Controls.Add(this.positionToleranceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.focuserSelectorComboBox);
            this.Controls.Add(this.focuserSelectorLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.DSGLogo);
            this.Controls.Add(this.chkTrace);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DarkSkyGeek’s Virtual Focuser ASCOM Driver";
            this.Load += new System.EventHandler(this.SetupDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSGLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.PictureBox DSGLogo;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label focuserSelectorLabel;
        private System.Windows.Forms.ComboBox focuserSelectorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox positionToleranceTextBox;
    }
}