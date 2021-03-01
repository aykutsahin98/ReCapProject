using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class UserOperations : Form
    {
        public UserOperations()
        {
            InitializeComponent();
            UserLoad();
            tarih();
            timer1.Start();
        }

        UserManager userManager = new UserManager(new EfUserDal());

        public void UserLoad()
        {
            var result = userManager.GetAll();
            dataGridUsers.DataSource = result.Data;
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
                var result = userManager.Add(new User
                {
                    UserName = txtfName.Text,
                    Email = txtfMail.Text,
                    Password = txtfPassword.Text 
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                UserLoad();
            } catch (Exception exception){MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");}
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridUsers.SelectedRows)
            {
                try
                {
                    var result = userManager.Delete(new User
                    { UserId = Convert.ToInt32(row.Cells[0].Value) });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    UserLoad();
                } catch (Exception exception){MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");}
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = userManager.Update(new User
                {
                    UserId = Convert.ToInt32(dataGridUsers.CurrentRow.Cells[0].Value),
                    UserName = txtfName.Text,
                    Email = txtfMail.Text,
                    Password = txtfPassword.Text
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                UserLoad();
            } catch (Exception exception) {MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");}
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            txtfName.Text = "";
            txtfMail.Text = "";
            txtfPassword.Text = "";
        }

        int i = 0;
        private void dataGridUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txtfName.Text = dataGridUsers.Rows[i].Cells[1].Value.ToString();
            txtfMail.Text = dataGridUsers.Rows[i].Cells[2].Value.ToString();
            txtfPassword.Text = dataGridUsers.Rows[i].Cells[3].Value.ToString();
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

        private void UserListMenuItem_Click(object sender, EventArgs e)
        {
            UserLoad();
            MessageBox.Show("Kullanıcı Listesi Güncellenmiştir.");
        }
    }
}
