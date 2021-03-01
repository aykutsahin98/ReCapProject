
namespace CarRentalHomeScreen
{
    partial class ColorOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorOperations));
            this.UpdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.txtfColorName = new System.Windows.Forms.TextBox();
            this.txtfColorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrandListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridColor = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColor)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateButton.Appearance.Options.UseFont = true;
            this.UpdateButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.ImageOptions.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(291, 82);
            this.UpdateButton.LookAndFeel.SkinName = "DevExpress Style";
            this.UpdateButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(179, 38);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageOptions.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(386, 28);
            this.DeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.DeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 38);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.ImageOptions.Image")));
            this.AddButton.Location = new System.Drawing.Point(291, 28);
            this.AddButton.LookAndFeel.SkinName = "DevExpress Style";
            this.AddButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 38);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "ADD";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // txtfColorName
            // 
            this.txtfColorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfColorName.Location = new System.Drawing.Point(134, 90);
            this.txtfColorName.Multiline = true;
            this.txtfColorName.Name = "txtfColorName";
            this.txtfColorName.Size = new System.Drawing.Size(140, 30);
            this.txtfColorName.TabIndex = 13;
            // 
            // txtfColorID
            // 
            this.txtfColorID.Enabled = false;
            this.txtfColorID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfColorID.Location = new System.Drawing.Point(134, 28);
            this.txtfColorID.Multiline = true;
            this.txtfColorID.Name = "txtfColorID";
            this.txtfColorID.Size = new System.Drawing.Size(140, 30);
            this.txtfColorID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Color Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Color ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "COLOR OPERATIONS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.BrandListMenuItem,
            this.timeMenu,
            this.dateMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 25;
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
            // BrandListMenuItem
            // 
            this.BrandListMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandListMenuItem.Image = global::CarRentalHomeScreen.Properties.Resources.loop;
            this.BrandListMenuItem.Name = "BrandListMenuItem";
            this.BrandListMenuItem.Size = new System.Drawing.Size(165, 20);
            this.BrandListMenuItem.Text = "UPDATED COLOR LIST";
            this.BrandListMenuItem.Click += new System.EventHandler(this.BrandListMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.txtfColorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.txtfColorID);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 148);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridColor);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 258);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COLOR LIST";
            // 
            // dataGridColor
            // 
            this.dataGridColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridColor.Location = new System.Drawing.Point(11, 31);
            this.dataGridColor.Name = "dataGridColor";
            this.dataGridColor.Size = new System.Drawing.Size(473, 221);
            this.dataGridColor.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColorOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ColorOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorOperations";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton UpdateButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private System.Windows.Forms.TextBox txtfColorName;
        private System.Windows.Forms.TextBox txtfColorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrandListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeMenu;
        private System.Windows.Forms.ToolStripMenuItem dateMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridColor;
        private System.Windows.Forms.Timer timer1;
    }
}