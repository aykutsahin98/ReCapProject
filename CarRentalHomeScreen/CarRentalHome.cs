using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalHomeScreen
{
    public partial class CarRentalHome : Form
    {
        public CarRentalHome()
        {
            InitializeComponent();
        }
      
        void tarih() //Tarihi Görüntülemek İçin Bir Fonksiyon
        {
            int ay = DateTime.Now.Month;
            int yil = DateTime.Now.Year;
            int gun = DateTime.Now.Day;
            label1.Text = "Date: " + gun + "/" + (ay) + "/" + yil;
        }

        void zaman() //Zamanı Görüntülemek İçin Bir Fonksiyon
        {
            String Sure = DateTime.Now.ToShortTimeString();
            label2.Text = "Time: " + Sure;
        }

        private void CarRentalHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            tarih();
            zaman();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoPage form2 = new InfoPage();//açılacak form
            form2.MdiParent = this;//bu formu parent olarak veriyoruz.
            form2.Show(); //form 2 açılıyor.
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            CarOperations car = new CarOperations();
            car.Show();
            this.Hide();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            CustomerOperations customer = new CustomerOperations();
            customer.Show();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            RentACarOperations rent = new RentACarOperations();
            rent.Show();
            this.Hide();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            //UserOperations user = new UserOperations();
            //user.Show();
        }
    }
}
