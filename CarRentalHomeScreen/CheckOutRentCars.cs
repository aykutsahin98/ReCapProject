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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalHomeScreen
{
    public partial class CheckOutRentCars : Form
    {
        public CheckOutRentCars()
        {
            InitializeComponent();
            LoadRentalCar();
            CarIdList();
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
                          join co in context.Colors
                          on c.ColorId equals co.ColorId
                          select new
                          {
                              RentalId = r.RentalId,
                              CarName = b.BrandName,
                              CustomerId = cu.CustomerId,
                              CompanyName = cu.CompanyName,
                              UserName = u.UserName,
                              RentDate = r.RentDate,
                              ReturnDate = r.ReturnDate
                          }).ToList();
            dataGridView1.DataSource = result;
        }
        public void CarIdList()
        {
            var result = carManager.GetAll();
            comboBox1.DataSource = result.Data;
            comboBox1.DisplayMember = "CarId";
            comboBox1.ValueMember = "CarId";
        }
     
        private void checkButton_Click(object sender, EventArgs e)
        {
           

        }
    }
}
