using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbHelper.DTOS;

namespace DbHelper
{
    public class Update
    {
        private sah_obs_basicEntities db = new sah_obs_basicEntities();

        public OperationResult User_Update(UserDTO userDto)
        {
            var user = db.Kullanicilars.Find(userDto.Id);

            if (user == null)
            {
                return new OperationResult
                {
                    IsSuccess = false,
                    Message = "Kullanıcı bulunamadı."
                };
            }

            // DTO'dan gelen verilerle kullanıcı bilgilerini güncelle
            user.name = userDto.Name;
            user.surname = userDto.Surname;
            user.Kimlik_Numarası = userDto.TCKN;
            user.yetki = userDto.Role;

            int result = db.SaveChanges();

            if (result > 0)
            {
                return new OperationResult
                {
                    IsSuccess = true,
                    Message = "Kullanıcı başarıyla güncellendi."
                };
            }
            else
            {
                return new OperationResult
                {
                    IsSuccess = false,
                    Message = "Kullanıcı güncelleme başarısız oldu."
                };
            }
        }

        public OperationResult<UserDTO> User_Search(string name, string surname)
        {
            var user = db.Kullanicilars.FirstOrDefault(x => x.name == name && x.surname == surname);

            if (user == null)
            {
                return new OperationResult<UserDTO>
                {
                    IsSuccess = false,
                    Message = "Kullanıcı bulunamadı.",
                    Data = null
                };
            }

            var userDto = new UserDTO
            {
                Id = user.id,
                Name = user.name,
                Surname = user.surname,
                Username = user.username,
                Role = user.yetki,
                IsAdmin = db.Yetkilers.FirstOrDefault(y => y.yetki_adi == user.yetki)?.is_admin ?? false
            };

            return new OperationResult<UserDTO>
            {
                IsSuccess = true,
                Message = "Kullanıcı bulundu.",
                Data = userDto
            };
        }

        public OperationResult Anno_Update(AnnoDTO dto)
        {
            var announcement = db.Duyurulars.Find(dto.Id);
            if (announcement == null)
                return OperationResult.Failure("Duyuru bulunamadı.");

            announcement.title = dto.Title;
            announcement.content = dto.Content;
            announcement.updated_at = DateTime.Now;

            db.SaveChanges();
            return OperationResult.Success("Duyuru güncellendi.");
        }

        public OperationResult Disc_Update(DiscDTO dto)
        {
            var disc = db.Devamsizliks.Find(dto.Id);
            if (disc == null)
                return OperationResult.Failure("Devamsızlık kaydı bulunamadı.");

            // "Raporlu" mu, değil mi kontrolü
            disc.durum = dto.Status == "Raporlu";

            // String tarihi DateTime’a çevir
            if (DateTime.TryParseExact(dto.Date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                disc.tarih = parsedDate;
            }
            else
            {
                return OperationResult.Failure("Tarih formatı geçersiz.");
            }

            db.SaveChanges();
            return OperationResult.Success("Devamsızlık kaydı güncellendi.");
        }

        public OperationResult Note_Update(NoteDTO dto)
        {
            var note = db.Notlars.Find(dto.Id);
            if (note == null)
                return OperationResult.Failure("Not bulunamadı.");

            note.ders_kodu = dto.DersKodu;
            note.not_degeri = dto.NotDegeri;
            note.tarih = dto.Tarih;
            db.SaveChanges();
            return OperationResult.Success("Not güncellendi.");
        }
    }
}