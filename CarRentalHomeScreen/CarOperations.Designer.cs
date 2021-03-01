
namespace CarRentalHomeScreen
{
    partial class CarOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarOperations));
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfDescription = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfDailyPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmBoxYear = new System.Windows.Forms.ComboBox();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.ListButton = new DevExpress.XtraEditors.SimpleButton();
            this.CleanButton = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(123, 39);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(154, 26);
            this.comboBoxBrand.TabIndex = 0;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(320, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description: ";
            // 
            // txtfDescription
            // 
            this.txtfDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfDescription.Location = new System.Drawing.Point(447, 36);
            this.txtfDescription.Multiline = true;
            this.txtfDescription.Name = "txtfDescription";
            this.txtfDescription.Size = new System.Drawing.Size(151, 110);
            this.txtfDescription.TabIndex = 3;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(123, 98);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(154, 26);
            this.comboBoxColor.TabIndex = 5;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color List: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(320, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Daily Price:\r\n";
            // 
            // txtfDailyPrice
            // 
            this.txtfDailyPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfDailyPrice.Location = new System.Drawing.Point(447, 155);
            this.txtfDailyPrice.Name = "txtfDailyPrice";
            this.txtfDailyPrice.Size = new System.Drawing.Size(151, 26);
            this.txtfDailyPrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Model Year: ";
            // 
            // cmBoxYear
            // 
            this.cmBoxYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBoxYear.FormattingEnabled = true;
            this.cmBoxYear.Location = new System.Drawing.Point(140, 158);
            this.cmBoxYear.Name = "cmBoxYear";
            this.cmBoxYear.Size = new System.Drawing.Size(137, 26);
            this.cmBoxYear.TabIndex = 11;
            // 
            // dataGridCars
            // 
            this.dataGridCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(6, 25);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridCars.Size = new System.Drawing.Size(838, 162);
            this.dataGridCars.TabIndex = 12;
            this.dataGridCars.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCars_CellMouseClick);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(283, 45);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(13, 13);
            this.labelBrand.TabIndex = 18;
            this.labelBrand.Text = "0";
            this.labelBrand.Visible = false;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(283, 104);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(13, 13);
            this.labelColor.TabIndex = 19;
            this.labelColor.Text = "0";
            this.labelColor.Visible = false;
            // 
            // ListButton
            // 
            this.ListButton.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListButton.Appearance.Options.UseFont = true;
            this.ListButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListButton.ImageOptions.Image")));
            this.ListButton.Location = new System.Drawing.Point(625, 155);
            this.ListButton.LookAndFeel.SkinName = "DevExpress Style";
            this.ListButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(208, 49);
            this.ListButton.TabIndex = 17;
            this.ListButton.Text = "Update Lists";
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CleanButton.Appearance.Options.UseFont = true;
            this.CleanButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CleanButton.ImageOptions.Image")));
            this.CleanButton.Location = new System.Drawing.Point(732, 93);
            this.CleanButton.LookAndFeel.SkinName = "DevExpress Style";
            this.CleanButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(101, 56);
            this.CleanButton.TabIndex = 16;
            this.CleanButton.Text = "Clean";
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateButton.Appearance.Options.UseFont = true;
            this.UpdateButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.ImageOptions.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(625, 93);
            this.UpdateButton.LookAndFeel.SkinName = "DevExpress Style";
            this.UpdateButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(101, 56);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageOptions.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(732, 28);
            this.DeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.DeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 56);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.ImageOptions.Image")));
            this.AddButton.Location = new System.Drawing.Point(625, 28);
            this.AddButton.LookAndFeel.SkinName = "DevExpress Style";
            this.AddButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 56);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxBrand);
            this.groupBox1.Controls.Add(this.labelColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.comboBoxColor);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.txtfDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfDailyPrice);
            this.groupBox1.Controls.Add(this.cmBoxYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ListButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.CleanButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 220);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridCars);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(7, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 200);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CAR LIST";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.brandMenuItem,
            this.colorMenuItem,
            this.timeMenu,
            this.dateMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeScreenMenuItem,
            this.aboutMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mENUToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mENUToolStripMenuItem.Image")));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // homeScreenMenuItem
            // 
            this.homeScreenMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources.home;
            this.homeScreenMenuItem.Name = "homeScreenMenuItem";
            this.homeScreenMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeScreenMenuItem.Text = "Home Screen";
            this.homeScreenMenuItem.Click += new System.EventHandler(this.homeScreenMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources._001_written_conversation_speech_bubble_with_letter_i_inside_of_information_for_interface;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // brandMenuItem
            // 
            this.brandMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources._006_brand;
            this.brandMenuItem.Name = "brandMenuItem";
            this.brandMenuItem.Size = new System.Drawing.Size(132, 20);
            this.brandMenuItem.Text = "ADDING BRAND";
            this.brandMenuItem.Click += new System.EventHandler(this.brandMenuItem_Click);
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources._005_tags;
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.Size = new System.Drawing.Size(128, 20);
            this.colorMenuItem.Text = "ADDING COLOR";
            this.colorMenuItem.Click += new System.EventHandler(this.colorMenuItem_Click);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CarOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 495);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CarOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Operations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfDescription;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfDailyPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmBoxYear;
        private System.Windows.Forms.DataGridView dataGridCars;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton UpdateButton;
        private DevExpress.XtraEditors.SimpleButton CleanButton;
        private DevExpress.XtraEditors.SimpleButton ListButton;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeScreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeMenu;
        private System.Windows.Forms.ToolStripMenuItem dateMenu;
        private System.Windows.Forms.Timer timer1;
    }
}