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
    public partial class ColorOperations : Form
    {
        public ColorOperations()
        {
            InitializeComponent();
            LoadColor();
            tarih();
            timer1.Start();
        }
        ColorManager colorManager = new ColorManager(new EfColorDal());

        public void LoadColor()
        {
            var result = colorManager.GetAll();
            dataGridColor.DataSource = result.Data;
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
                var result = colorManager.Add(new Entities.Concrete.Color
                { ColorName = txtfColorName.Text });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadColor();
            }
            catch (Exception exception)
            { MessageBox.Show(exception.Message, "Bilgilendirme Penceresi"); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridColor.SelectedRows)
            {
                try
                {
                    var result = colorManager.Delete(new Entities.Concrete.Color
                    { ColorId = Convert.ToInt32(row.Cells[0].Value) });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadColor();
                }
                catch (Exception exception)
                { MessageBox.Show(exception.Message, "Bilgilendirme Penceresi"); }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int colorId = Convert.ToInt16(txtfColorID.Text);
            string colorName = txtfColorName.Text;

            var result = colorManager.Update(new Entities.Concrete.Color { ColorId = colorId, ColorName = colorName });
            MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
            LoadColor();
        }
        int i = 0;
        private void dataGridColor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txtfColorID.Text = dataGridColor.Rows[i].Cells[0].Value.ToString();
            txtfColorName.Text = dataGridColor.Rows[i].Cells[1].Value.ToString();
        }

        private void BrandListMenuItem_Click(object sender, EventArgs e)
        {
            LoadColor();
            MessageBox.Show("Renk Listesi Güncellenmiştir");
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
