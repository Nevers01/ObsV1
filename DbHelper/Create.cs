using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using DbHelper.DTOS;

namespace DbHelper
{
    public class Create
    {
        private sah_obs_basicEntities db = new sah_obs_basicEntities();

        public OperationResult User_Add(string name, string surname, string password, string tckn, string role)
        {
            var existingUser = db.Kullanicilars
                                 .FirstOrDefault(x => x.name == name && x.surname == surname);

            if (existingUser != null)
            {
                return OperationResult.Failure("Böyle bir kullanıcı zaten sistemde var.");
            }

            Kullanicilar user = new Kullanicilar
            {
                name = name,
                surname = surname,
                password = password,
                Kimlik_Numarası = tckn,
                yetki = role
            };

            db.Kullanicilars.Add(user);

            if (db.SaveChanges() > 0)
            {
                return OperationResult.Success("Kayıt başarılı.");
            }
            else
            {
                return OperationResult.Failure("Kayıt başarısız oldu.");
            }
        }

        public OperationResult Disc_Add(DateTime tarih, bool durum, string username, string usersurname)
        {
            try
            {
                var userId = db.Kullanicilars.FirstOrDefault(u => u.name == username && u.surname == usersurname);

                var existingDisc = db.Devamsizliks
                                     .FirstOrDefault(x => x.ogrenci_id == userId.id && x.tarih == tarih);

                if (existingDisc != null)
                {
                    return OperationResult.Failure("Bu tarihe ait devamsızlık zaten mevcut.");
                }

                Devamsizlik Disc = new Devamsizlik
                {
                    tarih = tarih,
                    durum = durum,
                    ogrenci_id = userId.id
                };

                db.Devamsizliks.Add(Disc);

                if (db.SaveChanges() > 0)
                {
                    return OperationResult.Success("Devamsızlık kaydı başarılı.");
                }
                else
                {
                    return OperationResult.Failure("Devamsızlık kaydı başarısız.");
                }
            }
            catch (Exception ex)
            {
                return OperationResult.Failure("Hata: " + ex.Message);
            }
        }

        public OperationResult Anno_Add(AnnoDTO dto)
        {
            var entity = new Duyurular
            {
                title = dto.Title,
                content = dto.Content,
                AnnoType = dto.AnnoType,
                AnnoEdu = dto.AnnoEdu,
                created_at = DateTime.Now,
                is_active = true
            };

            db.Duyurulars.Add(entity);
            db.SaveChanges();

            return OperationResult.Success("Duyuru başarıyla eklendi.");
        }

        public OperationResult Node_Add(NoteDTO dto)
        {
            var note = new Notlar
            {
                ogrenci_id = dto.StudentId,
                ders_kodu = dto.DersKodu,
                not_degeri = dto.NotDegeri,
                tarih = dto.Tarih
            };

            db.Notlars.Add(note);
            db.SaveChanges();
            return OperationResult.Success("Not eklendi.");
        }
    }
}