using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Bu işlemi yapmak için muttemel zaman dilimi dışındasınız.";

        public static string CarAdded = "Araç eklendi.";
        public static string CarListed = "Araçlar listelendi.";
        public static string CarInvalid = "Araç ismi geçersiz.";
        public static string CarDeleted = "Araç silndi.";
        public static string CarUpdated = "Araç güncellendi.";

        public static string NoVehicle = "Araç zaten kiralanmış.";
        public static string ThereIsaVehicle = "Araç kiralandı.";
        public static string RentalListed = "Kiralanmış araçlar listelendi.";
        public static string RentalDeleted = "Araç kiralama işlemi silindi.";
        public static string RentalUpdated = "Araç kiralama işlemi güncellendi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandListed = "Markalar listelendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorListed = "Renkler listelendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncelendi";

        public static string CarImageAdded = "Bu araç için resim yükleme işlemi başarılı.";
        public static string CarImageListed = "Araş resimleri listelendi.";
        public static string CheckIfCarImageLimitExceded = "Bir araca en fazla 5 fotoğraf eklenebilir.";
        public static string CarImageUpdated = "Araç resim güncellemesi başarılı.";
        public static string CarImageDeleted = " Araç resmi silindi.";
        public static string CarImageNull = "Araç resmi boş.";
        public static string FailAddedImageLimit;

        public static string AuthorizationDenied ="Yetkiniz yoktur.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError ="Şifre hatalı.";
        public static string SuccessfulLogin = " Kullanıcı giriş işlemi başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserRegistered = "Kullanıcı kayıt işlemi başarılı.";
    }
}
