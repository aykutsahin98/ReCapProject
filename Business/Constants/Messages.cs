using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded = "Marka kayıt işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";
        public static string BrandAddError = "Eklemek istediğiniz marka zaten mevcut.Farklı bir marka giriniz.";

        //ColorMessages
        public static string ColorAdded = "Renk kayıt işlemi başarılı";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı";
        public static string ColorDeleted = "Renk silme işlemi başarılı";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz.";

        //CarMessages
        public static string CarAdded = "Araç kayıt işlemi başarılı";
        public static string CarDeleted = "Araç silme işlemi başarılı";
        public static string CarUpdated = "Araç güncelleme işlemi başarılı";

        //UserMessages
        public static string UserAdded = "Kullanıcı kayıt işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı";

        //CustomerMessages
        public static string CustomerAdded = "Müşteri kayıt işlemi başarılı";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarılı";
        public static string CustomerDeleted = "Müşteri silme işlemi başarılı";

        //CustomerMessages
        public static string RentalAdded = "Kiralama  işlemi başarılı";
        public static string RentalUpdated = "Kiralama güncelleme işlemi başarılı";
        public static string RentalDeleted = "Kiralama silme işlemi başarılı";

        public static string AddedRental = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";

        public static string Listed = "Listelendi";
        public static string NameInValid = "İsim geçersiz";
        public static string PriceInValid = "Geçersiz fiyat";

    }
}