using System.Collections.Generic;
using System.Linq;
using DbHelper.DTOS;
using DbHelper;

namespace DbHelper
{
    public class List
    {
        private sah_obs_basicEntities db = new sah_obs_basicEntities();

        public List<UserDTO> GetUserList()
        {
            var userList = db.Kullanicilars
                .Select(k => new UserDTO
                {
                    Id = k.id,
                    Name = k.name,
                    Surname = k.surname,
                    Username = k.username,
                    Role = k.yetki,
                    IsAdmin = db.Yetkilers.FirstOrDefault(y => y.yetki_adi == k.yetki).is_admin ?? false
                })
                .ToList();

            return userList;
        }

        public List<DiscDTO> GetDiscList()
        {
            var students = db.Kullanicilars.ToList(); // Tüm öğrencileri çek
            var discList = db.Devamsizliks
                .ToList()
                .Select(d => new DiscDTO
                {
                    Id = d.id,
                    Date = d.tarih.ToString("dd/MM/yyyy"),
                    Status = d.durum ? "Raporlu" : "Raporsuz",
                    StudentName = students
                                    .FirstOrDefault(s => s.id == d.ogrenci_id) != null
                        ? students.FirstOrDefault(s => s.id == d.ogrenci_id).name + " " + students.FirstOrDefault(s => s.id == d.ogrenci_id).surname
                        : "Bilinmeyen Öğrenci"
                })
                .ToList();

            return discList;
        }

        public List<AnnoDTO> GetAnnoList()
        {
            return db.Duyurulars
                .Where(x => x.is_active == true)
                .Select(x => new AnnoDTO
                {
                    Id = x.id,
                    Title = x.title,
                    Content = x.content,
                    CreatedAt = x.created_at.HasValue ? x.created_at.Value.ToString("dd/MM/yyyy") : "Tarih Yok",
                    IsActive = x.is_active ?? false
                })
                .ToList();
        }
    }
}