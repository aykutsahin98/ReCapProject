using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalHomeScreen
{
    public partial class CarOperations : Form
    {   
        public CarOperations()
        {
            InitializeComponent();
            cmBoxYearList();
            LoadColors();
            LoadBrands();
            DetailListCar();
            tarih();
            timer1.Start();
        }
       
        //GLOBAL DEĞERLER

        CarManager carManager = new CarManager(new EfCarDal());
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        ColorManager colorManager = new ColorManager(new EfColorDal());
        RentACarContext context = new RentACarContext();

        public void LoadColors()
        {
            //var result = (from co in context.Colors select co.ColorName).ToList();
            var result = colorManager.GetAll();
            comboBoxColor.DataSource = result.Data;
            comboBoxColor.DisplayMember = "ColorName";
        }
        public void LoadBrands()
        {
            /*var result = (from b in context.Brands select b.BrandName).ToList();
            comboBoxBrand.Items.Add(result);*/
            var result = brandManager.GetAll();
            comboBoxBrand.DataSource = result.Data;
            comboBoxBrand.DisplayMember = "BrandName";
        }
        public void cmBoxYearList()
        {
            for (int i = 2000; i <= 2021; i++)
            {
                cmBoxYear.Items.Add(i);
            }
        }
        public void DetailListCar()
        {
            var result = (from c in context.Cars
                          join co in context.Colors
                          on c.ColorId equals co.ColorId
                          join b in context.Brands
                          on c.BrandId equals b.BrandId
                          select new CarDetailDto
                          {
                              CarId = c.CarId,
                              BrandName = b.BrandName,
                              ColorName = co.ColorName,
                              DailyPrice = c.DailyPrice,
                              Descriptions = c.Descriptions,
                              ModelYear = c.ModelYear
                          }).ToList();
            dataGridCars.DataSource = result;
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
        private void dataGridCars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            comboBoxBrand.Text = dataGridCars.Rows[i].Cells[1].Value.ToString();
            comboBoxColor.Text = dataGridCars.Rows[i].Cells[2].Value.ToString();
            txtfDailyPrice.Text = dataGridCars.Rows[i].Cells[3].Value.ToString();
            cmBoxYear.Text = dataGridCars.Rows[i].Cells[4].Value.ToString();
            txtfDescription.Text = dataGridCars.Rows[i].Cells[5].Value.ToString();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            comboBoxBrand.Text = "";
            comboBoxColor.Text = "";
            cmBoxYear.Text = "";
            txtfDailyPrice.Text = "";
            txtfDescription.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = carManager.Add(new Car
                {
                    BrandId = Convert.ToInt32(id),
                    ColorId = Convert.ToInt32(Id),
                    ModelYear = Convert.ToString(cmBoxYear.Text),
                    DailyPrice = Convert.ToDecimal(txtfDailyPrice.Text),
                    Descriptions = txtfDescription.Text
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                DetailListCar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }
        
        private void ListButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listeler Güncellenmiştir");
            DetailListCar();
            LoadBrands();
            LoadColors();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCars.SelectedRows)
            {
                try
                {
                    var result = carManager.Delete(new Car
                    {
                        CarId = Convert.ToInt32(row.Cells[0].Value)
                    });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    DetailListCar();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
                try
            { 
                var result = carManager.Update(new Car
                {
                    CarId = Convert.ToInt32(dataGridCars.CurrentRow.Cells[0].Value),
                    BrandId = Convert.ToInt32(labelBrand.Text),
                    ColorId = Convert.ToInt32(labelColor.Text),
                    ModelYear = Convert.ToString(cmBoxYear.Text),
                    DailyPrice = Convert.ToDecimal(txtfDailyPrice.Text),
                    Descriptions = Convert.ToString(txtfDescription.Text)
                }); 
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                DetailListCar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }
        
        int id = 0;
        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
             id = (comboBoxBrand.SelectedItem as Brand).BrandId;
             labelBrand.Text = Convert.ToString(id);
        }
       
        int Id = 0;
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = (comboBoxColor.SelectedItem as Entities.Concrete.Color).ColorId;
            labelColor.Text = Convert.ToString(Id);
        }

        private void brandMenuItem_Click(object sender, EventArgs e)
        {
            BrandOperations brand = new BrandOperations();
            brand.Show();
        }

        private void colorMenuItem_Click(object sender, EventArgs e)
        {
            ColorOperations color = new ColorOperations();
            color.Show();
        }

        private void homeScreenMenuItem_Click(object sender, EventArgs e)
        {
            CarRentalHome home = new CarRentalHome();
            home.Show();
            this.Hide();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            InfoPage about = new InfoPage();
            about.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman();
        }
    }
}