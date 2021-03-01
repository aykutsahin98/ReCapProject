
namespace CarRentalHomeScreen
{
    partial class UserOperations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOperations));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CleanButton = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.txtfMail = new System.Windows.Forms.TextBox();
            this.txtfPassword = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "E-Mail: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(130, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "USER OPERATIONS";
            // 
            // txtfName
            // 
            this.txtfName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfName.Location = new System.Drawing.Point(190, 42);
            this.txtfName.Multiline = true;
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(150, 27);
            this.txtfName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name - Surname: ";
            // 
            // CleanButton
            // 
            this.CleanButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CleanButton.Appearance.Options.UseFont = true;
            this.CleanButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CleanButton.ImageOptions.Image")));
            this.CleanButton.Location = new System.Drawing.Point(346, 142);
            this.CleanButton.LookAndFeel.SkinName = "DevExpress Style";
            this.CleanButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(164, 47);
            this.CleanButton.TabIndex = 35;
            this.CleanButton.Text = "Clean";
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateButton.Appearance.Options.UseFont = true;
            this.UpdateButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.ImageOptions.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(346, 93);
            this.UpdateButton.LookAndFeel.SkinName = "DevExpress Style";
            this.UpdateButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 43);
            this.UpdateButton.TabIndex = 34;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageOptions.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(425, 40);
            this.DeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.DeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 45);
            this.DeleteButton.TabIndex = 33;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.ImageOptions.Image")));
            this.AddButton.Location = new System.Drawing.Point(346, 40);
            this.AddButton.LookAndFeel.SkinName = "DevExpress Style";
            this.AddButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(73, 45);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // txtfMail
            // 
            this.txtfMail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfMail.Location = new System.Drawing.Point(122, 100);
            this.txtfMail.Name = "txtfMail";
            this.txtfMail.Size = new System.Drawing.Size(218, 26);
            this.txtfMail.TabIndex = 37;
            // 
            // txtfPassword
            // 
            this.txtfPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfPassword.Location = new System.Drawing.Point(122, 162);
            this.txtfPassword.Name = "txtfPassword";
            this.txtfPassword.PasswordChar = '•';
            this.txtfPassword.Size = new System.Drawing.Size(218, 27);
            this.txtfPassword.TabIndex = 38;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.UserListMenuItem,
            this.timeMenu,
            this.dateMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mENUToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mENUToolStripMenuItem.Image")));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources._001_written_conversation_speech_bubble_with_letter_i_inside_of_information_for_interface;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // UserListMenuItem
            // 
            this.UserListMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserListMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources.loop;
            this.UserListMenuItem.Name = "UserListMenuItem";
            this.UserListMenuItem.Size = new System.Drawing.Size(156, 20);
            this.UserListMenuItem.Text = "UPDATED USER LIST";
            this.UserListMenuItem.Click += new System.EventHandler(this.UserListMenuItem_Click);
            // 
            // timeMenu
            // 
            this.timeMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.timeMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.timeMenu.Name = "timeMenu";
            this.timeMenu.Size = new System.Drawing.Size(56, 20);
            this.timeMenu.Text = "Zaman";
            // 
            // dateMenu
            // 
            this.dateMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dateMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateMenu.ForeColor = System.Drawing.Color.Navy;
            this.dateMenu.Name = "dateMenu";
            this.dateMenu.Size = new System.Drawing.Size(45, 20);
            this.dateMenu.Text = "Tarih";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CleanButton);
            this.groupBox1.Controls.Add(this.txtfMail);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.txtfPassword);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 215);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridUsers);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 234);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BRAND LIST";
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(11, 31);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.Size = new System.Drawing.Size(513, 197);
            this.dataGridUsers.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "UserOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOperations";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton CleanButton;
        private DevExpress.XtraEditors.SimpleButton UpdateButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfMail;
        private System.Windows.Forms.TextBox txtfPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeMenu;
        private System.Windows.Forms.ToolStripMenuItem dateMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Timer timer1;
    }
}