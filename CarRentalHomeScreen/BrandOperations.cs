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
using Business.Abstract;

namespace CarRentalHomeScreen
{
    public partial class BrandOperations : Form
    {
        public BrandOperations()
        {
            InitializeComponent();
            LoadBrand();
            tarih();
            timer1.Start();
        }
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        public void LoadBrand()
        {
            var result = brandManager.GetAll();
            dataGridBrand.DataSource = result.Data;
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
        int i = 0;
        private void dataGridBrand_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txtftBrandID.Text = dataGridBrand.Rows[i].Cells[0].Value.ToString();
            txtfBrandName.Text = dataGridBrand.Rows[i].Cells[1].Value.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = brandManager.Add(new Brand
                { BrandName = txtfBrandName.Text });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadBrand();
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message, "Bilgilendirme Penceresi"); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridBrand.SelectedRows)
            {
                try
                {
                    var result = brandManager.Delete(new Brand
                    { BrandId = Convert.ToInt32(row.Cells[0].Value) });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadBrand();
                }
                catch (Exception exception)
                { MessageBox.Show(exception.Message, "Bilgilendirme Penceresi"); }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int brandId = Convert.ToInt16(txtftBrandID.Text);
            string brandName = txtfBrandName.Text;

            var result = brandManager.Update(new Brand { BrandId = brandId, BrandName = brandName });
            MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
            LoadBrand();
        }

        private void BrandListMenuItem_Click(object sender, EventArgs e)
        {
            LoadBrand();
            MessageBox.Show("Marka Listesi Güncellenmiştir");
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