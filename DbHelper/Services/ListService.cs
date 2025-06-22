using System.Collections.Generic;
using System.Linq;
using DbHelper.DTOS;
using DbHelper.Services;

namespace DbHelper
{
    public class ListService
    {
        public List<UserDTO> GetUserList()
        {
            using (var db = new sah_obs_basicEntities())
            {
                return db.Kullanicilars.Select(u => new UserDTO
                {
                    Id = u.id,
                    Name = u.name,
                    Surname = u.surname,
                    Username = u.username,
                    Role = u.yetki,
                }).ToList();
            }
        }

        public List<DiscDTO> GetDiscList()
        {
            using (var db = new sah_obs_basicEntities())
            {
                var rawList = db.Devamsizliks.ToList(); // SQL burada biter

                return rawList.Select(d => new DiscDTO
                {
                    Id = d.id,
                    Date = d.tarih.Day + ":" + d.tarih.Month + ":" + d.tarih.Year ?? "Tarih Yok",
                    Status = d.durum ? "Raporlu" : "Raporsuz",
                    StudentName = db.Kullanicilars.FirstOrDefault(u => u.id == d.ogrenci_id)?.name ?? "Bilinmiyor"
                }).ToList();
            }
        }

        public List<AnnoDTO> GetAnnoList()
        {
            using (var db = new sah_obs_basicEntities())
            {
                var rawList = db.Duyurulars.ToList(); // SQL burada biter

                return rawList.Select(a => new AnnoDTO
                {
                    Id = a.id,
                    Title = a.title,
                    Content = a.content,
                    AnnoType = a.AnnoType,
                    AnnoEdu = a.AnnoEdu,
                    CreatedAt = a.created_at.Value.Day + ":" + a.created_at.Value.Month + ":" + a.created_at.Value.Year ?? "Tarih Yok",
                }).ToList();
            }
        }

        public List<DiscDTO> GetUserDiscList()
        {
            int userİd = UserSession.UserId;

            using (var db = new sah_obs_basicEntities())
            {
                var rawList = db.Devamsizliks.ToList(); // SQL burada biter

                return rawList
               .Where(d => d.ogrenci_id == userİd)
               .Select(d => new DiscDTO
               {
                   Id = d.id,
                   Date = d.tarih.Day + ":" + d.tarih.Month + ":" + d.tarih.Year ?? "Tarih Yok",
                   Status = d.durum ? "Raporlu" : "Raporsuz",
               }).ToList();
            }
        }

        public List<NoteDTO> GetAllNotes()
        {
            using (var db = new sah_obs_basicEntities())
            {
                return db.Notlars.Select(n => new NoteDTO
                {
                    Id = n.id,
                    StudentId = n.ogrenci_id,
                    DersKodu = n.ders_kodu,
                    NotDegeri = n.not_degeri,
                    Tarih = n.tarih
                }).ToList();
            }
        }

        public List<NoteDTO> GetUserNotes(int userId)
        {
            using (var db = new sah_obs_basicEntities())
            {
                return db.Notlars
                .Where(n => n.ogrenci_id == userId)
                .Select(n => new NoteDTO
                {
                    Id = n.id,
                    StudentId = n.ogrenci_id,
                    DersKodu = n.ders_kodu,
                    NotDegeri = n.not_degeri,
                    Tarih = n.tarih
                }).ToList();
            }
        }
    }
}