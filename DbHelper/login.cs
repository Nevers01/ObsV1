using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbHelper
{
    public class Login
    {
        private sah_obs_basicEntities db = new sah_obs_basicEntities();

        public class LoginResult
        {
            public bool IsSuccess { get; set; }
            public bool IsAdmin { get; set; }
            public int UserId { get; set; }
            public string Message { get; set; }
        }

        public LoginResult LoginControl(string username, string password)
        {
            var user = db.Kullanicilars
                         .FirstOrDefault(x => x.username == username && x.password == password);

            if (user != null)
            {
                string kullaniciYetkisi = user.yetki;

                var yetki = db.Yetkilers.FirstOrDefault(y => y.yetki_adi == kullaniciYetkisi);

                bool isAdmin = (yetki != null && yetki.is_admin.HasValue && yetki.is_admin.Value);

                return new LoginResult
                {
                    IsSuccess = true,
                    IsAdmin = isAdmin,
                    UserId = user.id,
                    Message = "Giriş başarılı."
                };
            }
            else
            {
                return new LoginResult
                {
                    IsSuccess = false,
                    IsAdmin = false,
                    Message = "Kullanıcı adı veya şifre hatalı."
                };
            }
        }
    }
}