
namespace CarRentalHomeScreen
{
    partial class CustomerOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOperations));
            this.UpdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.txtfCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateButton.Appearance.Options.UseFont = true;
            this.UpdateButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.ImageOptions.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(352, 85);
            this.UpdateButton.LookAndFeel.SkinName = "DevExpress Style";
            this.UpdateButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(165, 38);
            this.UpdateButton.TabIndex = 26;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageOptions.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(433, 31);
            this.DeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.DeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 38);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.ImageOptions.Image")));
            this.AddButton.Location = new System.Drawing.Point(352, 31);
            this.AddButton.LookAndFeel.SkinName = "DevExpress Style";
            this.AddButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 38);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "ADD";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(6, 30);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.Size = new System.Drawing.Size(518, 205);
            this.dataGridCustomer.TabIndex = 23;
            // 
            // txtfCompanyName
            // 
            this.txtfCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfCompanyName.Location = new System.Drawing.Point(177, 31);
            this.txtfCompanyName.Multiline = true;
            this.txtfCompanyName.Name = "txtfCompanyName";
            this.txtfCompanyName.Size = new System.Drawing.Size(146, 30);
            this.txtfCompanyName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Company Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "CUSTOMER OPERATIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "User Name: ";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(136, 96);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(187, 27);
            this.comboBoxUsers.TabIndex = 29;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.CustomerListMenuItem,
            this.timeMenu,
            this.dateMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 40;
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
            this.aboutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // CustomerListMenuItem
            // 
            this.CustomerListMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerListMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources.loop;
            this.CustomerListMenuItem.Name = "CustomerListMenuItem";
            this.CustomerListMenuItem.Size = new System.Drawing.Size(193, 20);
            this.CustomerListMenuItem.Text = "UPDATED CUSTOMER LIST";
            this.CustomerListMenuItem.Click += new System.EventHandler(this.CustomerListMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.txtfCompanyName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.comboBoxUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 146);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridCustomer);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 242);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CUSTOMER LIST";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomerOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CustomerOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOperations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton UpdateButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.TextBox txtfCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeMenu;
        private System.Windows.Forms.ToolStripMenuItem dateMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
    }
}