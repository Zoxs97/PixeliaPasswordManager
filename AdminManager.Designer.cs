namespace PixeliaPasswordManager
{
    partial class AdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManager));
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCopyEmail = new System.Windows.Forms.Button();
            this.buttonCopyUsername = new System.Windows.Forms.Button();
            this.buttonCopyPassword = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNewEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGeneratePassword = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxRandomPassword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonCopyPassword = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.groupBox1);
            this.groupBoxPanel.Controls.Add(this.panel1);
            this.groupBoxPanel.Controls.Add(this.toolStrip1);
            this.groupBoxPanel.Controls.Add(this.dataGridView);
            this.groupBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPanel.Size = new System.Drawing.Size(1385, 789);
            this.groupBoxPanel.TabIndex = 2;
            this.groupBoxPanel.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCopyEmail);
            this.groupBox1.Controls.Add(this.buttonCopyUsername);
            this.groupBox1.Controls.Add(this.buttonCopyPassword);
            this.groupBox1.Controls.Add(this.checkBoxShowPassword);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.textBoxType);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.labelType);
            this.groupBox1.Location = new System.Drawing.Point(244, 577);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1136, 208);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Settings";
            // 
            // buttonCopyEmail
            // 
            this.buttonCopyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCopyEmail.Location = new System.Drawing.Point(458, 111);
            this.buttonCopyEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCopyEmail.Name = "buttonCopyEmail";
            this.buttonCopyEmail.Size = new System.Drawing.Size(96, 30);
            this.buttonCopyEmail.TabIndex = 12;
            this.buttonCopyEmail.Text = "Copy";
            this.buttonCopyEmail.UseVisualStyleBackColor = true;
            // 
            // buttonCopyUsername
            // 
            this.buttonCopyUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCopyUsername.Location = new System.Drawing.Point(458, 77);
            this.buttonCopyUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCopyUsername.Name = "buttonCopyUsername";
            this.buttonCopyUsername.Size = new System.Drawing.Size(96, 30);
            this.buttonCopyUsername.TabIndex = 11;
            this.buttonCopyUsername.Text = "Copy";
            this.buttonCopyUsername.UseVisualStyleBackColor = true;
            // 
            // buttonCopyPassword
            // 
            this.buttonCopyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCopyPassword.Location = new System.Drawing.Point(458, 144);
            this.buttonCopyPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCopyPassword.Name = "buttonCopyPassword";
            this.buttonCopyPassword.Size = new System.Drawing.Size(96, 30);
            this.buttonCopyPassword.TabIndex = 10;
            this.buttonCopyPassword.Text = "Copy";
            this.buttonCopyPassword.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(278, 178);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(175, 29);
            this.checkBoxShowPassword.TabIndex = 9;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(146, 111);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(307, 30);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(22, 114);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 25);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(146, 144);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(307, 30);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(146, 77);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(307, 30);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(146, 46);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(307, 30);
            this.textBoxType.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(22, 146);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(22, 79);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(102, 25);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(22, 46);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 25);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 723);
            this.panel1.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripSeparator1,
            this.toolStripButtonNewEntry,
            this.toolStripButtonDeleteEntry,
            this.toolStripButtonEditEntry,
            this.toolStripSeparator2,
            this.toolStripButtonReload,
            this.toolStripButtonGeneratePassword,
            this.toolStripTextBoxRandomPassword,
            this.toolStripButtonCopyPassword});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1379, 31);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::PixeliaPasswordManager.Properties.Resources.iconsNew_3;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonOpen.Text = "Open Tree";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonNewEntry
            // 
            this.toolStripButtonNewEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewEntry.Image = global::PixeliaPasswordManager.Properties.Resources.icon_0;
            this.toolStripButtonNewEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewEntry.Name = "toolStripButtonNewEntry";
            this.toolStripButtonNewEntry.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonNewEntry.Text = "New Entry";
            // 
            // toolStripButtonDeleteEntry
            // 
            this.toolStripButtonDeleteEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteEntry.Image = global::PixeliaPasswordManager.Properties.Resources.icon_1;
            this.toolStripButtonDeleteEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteEntry.Name = "toolStripButtonDeleteEntry";
            this.toolStripButtonDeleteEntry.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonDeleteEntry.Text = "DeleteEntry";
            // 
            // toolStripButtonEditEntry
            // 
            this.toolStripButtonEditEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditEntry.Image = global::PixeliaPasswordManager.Properties.Resources.icon_2;
            this.toolStripButtonEditEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditEntry.Name = "toolStripButtonEditEntry";
            this.toolStripButtonEditEntry.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonEditEntry.Text = "Edit Entry";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReload.Image = global::PixeliaPasswordManager.Properties.Resources.icon_4;
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonReload.Text = "Reload";
            // 
            // toolStripButtonGeneratePassword
            // 
            this.toolStripButtonGeneratePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGeneratePassword.Image = global::PixeliaPasswordManager.Properties.Resources.icon_3;
            this.toolStripButtonGeneratePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGeneratePassword.Name = "toolStripButtonGeneratePassword";
            this.toolStripButtonGeneratePassword.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonGeneratePassword.Text = "Generate Password";
            // 
            // toolStripTextBoxRandomPassword
            // 
            this.toolStripTextBoxRandomPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxRandomPassword.Name = "toolStripTextBoxRandomPassword";
            this.toolStripTextBoxRandomPassword.Size = new System.Drawing.Size(178, 31);
            // 
            // toolStripButtonCopyPassword
            // 
            this.toolStripButtonCopyPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCopyPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripButtonCopyPassword.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyPassword.Image")));
            this.toolStripButtonCopyPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyPassword.Name = "toolStripButtonCopyPassword";
            this.toolStripButtonCopyPassword.Size = new System.Drawing.Size(53, 28);
            this.toolStripButtonCopyPassword.Text = "Copy";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(244, 62);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1136, 510);
            this.dataGridView.TabIndex = 13;
            // 
            // AdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1385, 789);
            this.Controls.Add(this.groupBoxPanel);
            this.Name = "AdminManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManager";
            this.groupBoxPanel.ResumeLayout(false);
            this.groupBoxPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCopyEmail;
        private System.Windows.Forms.Button buttonCopyUsername;
        private System.Windows.Forms.Button buttonCopyPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewEntry;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteEntry;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripButton toolStripButtonGeneratePassword;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxRandomPassword;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyPassword;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}