
namespace CarRentalHomeScreen
{
    partial class CarRentalHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRentalHome));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCar = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.buttonUser = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRent = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // buttonCar
            // 
            this.buttonCar.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonCar.Appearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCar.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCar.Appearance.Options.UseBackColor = true;
            this.buttonCar.Appearance.Options.UseBorderColor = true;
            this.buttonCar.Appearance.Options.UseFont = true;
            this.buttonCar.AppearancePressed.BackColor = System.Drawing.Color.Yellow;
            this.buttonCar.AppearancePressed.Options.UseBackColor = true;
            this.buttonCar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCar.ImageOptions.Image")));
            this.buttonCar.Location = new System.Drawing.Point(113, 76);
            this.buttonCar.LookAndFeel.SkinName = "DevExpress Style";
            this.buttonCar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.buttonCar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonCar.Size = new System.Drawing.Size(259, 50);
            this.buttonCar.TabIndex = 3;
            this.buttonCar.Text = "CAR OPERATIONS";
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonCustomer.Appearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCustomer.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCustomer.Appearance.Options.UseBackColor = true;
            this.buttonCustomer.Appearance.Options.UseBorderColor = true;
            this.buttonCustomer.Appearance.Options.UseFont = true;
            this.buttonCustomer.AppearancePressed.BackColor = System.Drawing.Color.Yellow;
            this.buttonCustomer.AppearancePressed.Options.UseBackColor = true;
            this.buttonCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.buttonCustomer.Location = new System.Drawing.Point(378, 76);
            this.buttonCustomer.LookAndFeel.SkinName = "DevExpress Style";
            this.buttonCustomer.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.buttonCustomer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(259, 50);
            this.buttonCustomer.TabIndex = 4;
            this.buttonCustomer.Text = "CUSTOMER OPERATIONS";
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonUser.Appearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUser.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUser.Appearance.Options.UseBackColor = true;
            this.buttonUser.Appearance.Options.UseBorderColor = true;
            this.buttonUser.Appearance.Options.UseFont = true;
            this.buttonUser.AppearancePressed.BackColor = System.Drawing.Color.Yellow;
            this.buttonUser.AppearancePressed.Options.UseBackColor = true;
            this.buttonUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.buttonUser.Location = new System.Drawing.Point(378, 145);
            this.buttonUser.LookAndFeel.SkinName = "DevExpress Style";
            this.buttonUser.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.buttonUser.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(259, 50);
            this.buttonUser.TabIndex = 5;
            this.buttonUser.Text = "USER OPERATIONS";
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonRent
            // 
            this.buttonRent.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonRent.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonRent.Appearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRent.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRent.Appearance.Options.UseBackColor = true;
            this.buttonRent.Appearance.Options.UseBorderColor = true;
            this.buttonRent.Appearance.Options.UseFont = true;
            this.buttonRent.AppearancePressed.BackColor = System.Drawing.Color.Yellow;
            this.buttonRent.AppearancePressed.Options.UseBackColor = true;
            this.buttonRent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.buttonRent.Location = new System.Drawing.Point(113, 145);
            this.buttonRent.LookAndFeel.SkinName = "DevExpress Style";
            this.buttonRent.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.buttonRent.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(259, 50);
            this.buttonRent.TabIndex = 7;
            this.buttonRent.Text = "RENT A CAR ";
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(621, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time:";
            // 
            // CarRentalHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CarRentalHomeScreen.Properties.Resources.rent_a_car_kasko_özserneo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(756, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.label2);
            this.Name = "CarRentalHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAR RENT HOME SCREEN";
            this.Load += new System.EventHandler(this.CarRentalHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton buttonCar;
        private DevExpress.XtraEditors.SimpleButton buttonCustomer;
        private DevExpress.XtraEditors.SimpleButton buttonUser;
        private DevExpress.XtraEditors.SimpleButton buttonRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}