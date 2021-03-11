using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class CustomerOperations : Form
    {
        public CustomerOperations()
        {
            InitializeComponent();
            LoadCustomer();
            //UserLoad();
            tarih();
            timer1.Start();
        }
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        UserManager userManager = new UserManager(new EfUserDal());
        RentACarContext context = new RentACarContext();
       /* public void UserLoad()
        {
            var result = userManager.GetAll();(from cu in context.Customers
                          join us in context.Users
                          on cu.UserId equals us.UserId
                          select new
                          {
                              UserName = us.UserName
                          }).ToList();
            comboBoxUsers.DataSource = result.Data;
            comboBoxUsers.DisplayMember = "UserName";
            comboBoxUsers.ValueMember = "UserId";
        }*/
        public void LoadCustomer()
        {
            var result = (from cu in context.Customers
                          join us in context.Users
                          on cu.UserId equals us.UserId
                          select new 
                          {
                              CustomerId = cu.CustomerId,
                              CompanyName = cu.CompanyName,
                              UserName = us.UserName,
                          }).ToList();
            dataGridCustomer.DataSource = result;
        }

        void tarih() //Tarihi Görüntülemek İçin Bir Fonksiyon
        {
            int ay = DateTime.Now.Month;
            int yil = DateTime.Now.Year;
            int gun = DateTime.Now.Day;
            dateMenu.Text = "Date: " + gun + "/" + (ay) + "/" + yil;
        }
        void zaman() //Zamanı Görüntülemek İçin Bir Fonksiyon
        {
            String Sure = DateTime.Now.ToShortTimeString();
            timeMenu.Text = "Time: " + Sure;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = customerManager.Add(new Customer
                {
                    UserId = Convert.ToInt32(label4.Text),
                    CompanyName = txtfCompanyName.Text
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadCustomer();
            }
            catch (Exception exception){MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");}
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCustomer.SelectedRows)
            {
                try
                {
                    var result = customerManager.Delete(new Customer
                    { CustomerId = Convert.ToInt32(row.Cells[0].Value) });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadCustomer();
                } catch (Exception exception){MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");}
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = customerManager.Update(new Customer
                {
                    CustomerId = Convert.ToInt32(dataGridCustomer.CurrentRow.Cells[0].Value),
                    UserId = Convert.ToInt32(label4.Text),
                    CompanyName = Convert.ToString(txtfCompanyName.Text)
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadCustomer();
            }catch (Exception exception){MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");}
        }

        int Id = 0;
        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = (comboBoxUsers.SelectedItem as User).UserId;
            label4.Text = Convert.ToString(Id);
        }

        private void CustomerListMenuItem_Click(object sender, EventArgs e)
        {
            LoadCustomer();
            MessageBox.Show("Müşteri Listesi Güncellenmiştir");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            InfoPage page = new InfoPage();
            page.Show();
        }
    }
}
