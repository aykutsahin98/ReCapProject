using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class RentACarOperations : Form
    {
        public RentACarOperations()
        {
            InitializeComponent();
            LoadRentalCar();
            LoadCar();
            CarIdList();
            UserList();
            CustomerIdList();
        }
        CarManager carManager = new CarManager(new EfCarDal());
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        ColorManager colorManager = new ColorManager(new EfColorDal());
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        UserManager userManager = new UserManager(new EfUserDal());
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        RentACarContext context = new RentACarContext();

       public void LoadRentalCar()
        {
            var result = (from r in context.Rentals
                          join c in context.Cars
                          on r.CarId equals c.CarId
                          join cu in context.Customers
                          on r.CustomerId equals cu.CustomerId
                          join b in context.Brands
                          on c.BrandId equals b.BrandId
                          join u in context.Users
                          on cu.UserId equals u.UserId
                          select new
                          {
                              RentalId = r.RentalId,
                              CarId = c.CarId,
                              UserName = u.UserName,
                              CompanyName = cu.CompanyName,
                              RentDate = r.RentDate,
                              ReturnDate = r.ReturnDate
                          }).ToList();
            dataGridView1.DataSource = result;
            dataGridView1.Columns[0].HeaderCell.Value = "Rental ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Car ID";
            dataGridView1.Columns[2].HeaderCell.Value = "Users";
            dataGridView1.Columns[3].HeaderCell.Value = "Company";
            dataGridView1.Columns[4].HeaderCell.Value = "Rent Date";
            dataGridView1.Columns[5].HeaderCell.Value = "Return Date";
            
        }
        
        public void LoadCar()
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
            dataGridCars.Columns[0].HeaderCell.Value = "Car ID";
            dataGridCars.Columns[1].HeaderCell.Value = "Brand";
            dataGridCars.Columns[2].HeaderCell.Value = "Color";
            dataGridCars.Columns[2].HeaderCell.Value = "Model Year";
            dataGridCars.Columns[3].HeaderCell.Value = "Daily Price";
            dataGridCars.Columns[4].HeaderCell.Value = "Description";
        }
      
        public void CarIdList()
        {
            var result = carManager.GetAll();
            comboBoxCarList.DataSource = result.Data;
            comboBoxCarList.DisplayMember = "CarId";
            comboBoxCarList.ValueMember = "CarId";
        }
        public void UserList()
        {
            var result = (from cu in context.Customers
                          join us in context.Users
                          on cu.UserId equals us.UserId
                          select new
                          {
                              CustomerId = cu.CustomerId,
                              UserName = us.UserName,
                              CompanyName = cu.CompanyName
                          }).ToList();
            dataGridCustomer.DataSource = result;
            dataGridCustomer.Columns[0].HeaderCell.Value = "User ID";
            dataGridCustomer.Columns[1].HeaderCell.Value = "User Name";
            dataGridCustomer.Columns[2].HeaderCell.Value = "Company";
        }
        public void CustomerIdList()
        {
            var result = customerManager.GetAll();
            comboBoxUser.DataSource = result.Data;
            comboBoxUser.DisplayMember = "CustomerId";
            comboBoxUser.ValueMember = "CustomerId";
        }
        
        private void RentButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var result = rentalManager.Add(new Rental
                {
                    CarId = Convert.ToInt32(comboBoxCarList.SelectedValue),
                    CustomerId = Convert.ToInt32(comboBoxUser.SelectedValue),
                    RentDate = DateTime.Now,
                    ReturnDate = null,
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
               LoadRentalCar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadCar();
            LoadRentalCar();
            CustomerIdList();
            UserList();
            CarIdList();
            MessageBox.Show("Bütün Listeler Güncellenmiştir");
        }

        //int customerId = 0;
        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*customerId = (comboBoxUser.SelectedItem as Customer).CustomerId;
            LabelUser.Text = Convert.ToString(customerId);*/
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            /*CheckOutRentCars form1 = new CheckOutRentCars();
            form1.Show();*/
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                try
            {
                var st = (from r in context.Rentals where r.CarId == int.Parse(comboBoxCarList.Text) select r).First();
                st.RentalId = Convert.ToInt32(row.Cells[0].Value);
                st.CustomerId = Convert.ToInt32(comboBoxUser.Text);
                st.ReturnDate = DateTime.Now;
                MessageBox.Show(rentalManager.Update(st).Message,"Bilgilendirme Mesajı");
                LoadRentalCar();

                
                /*var result = rentalManager.Update(new Rental
                {
                    

                RentalId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    CarId = Convert.ToInt32(comboBoxCarList.SelectedValue),
                    CustomerId = Convert.ToInt32(comboBoxUser.SelectedValue),
                    ReturnDate = DateTime.Now,
                    
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadRentalCar();*/
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    var result = rentalManager.Delete(new Rental
                    {
                        RentalId = Convert.ToInt32(row.Cells[0].Value)

                    });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadRentalCar();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
                }
            }
        }
        int i = 0;
        private void dataGridCars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            comboBoxCarList.Text = dataGridCars.Rows[i].Cells[0].Value.ToString();
            
        }
        private void dataGridCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            comboBoxUser.Text = dataGridCustomer.Rows[i].Cells[0].Value.ToString();
        }

        private void CarMenuItem_Click(object sender, EventArgs e)
        {
            CarOperations car = new CarOperations();
            car.Show();
        }

        private void CustomerMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOperations customer = new CustomerOperations();
            customer.Show();
        }

        private void homeScreenMenuItem_Click(object sender, EventArgs e)
        {
            CarRentalHome home = new CarRentalHome();
            home.Show();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            InfoPage page = new InfoPage();
            page.Show();
        }
    }
}
