using DbHelper.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper.Services
{
    public class NoteService
    {
        private readonly sah_obs_basicEntities db = new sah_obs_basicEntities();

        public List<NoteDTO> GetAllNotes()
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

        public OperationResult AddNote(NoteDTO dto)
        {
            var yeniNot = new Notlar
            {
                ogrenci_id = dto.StudentId,
                ders_kodu = dto.DersKodu,
                not_degeri = dto.NotDegeri,
                tarih = dto.Tarih
            };

            db.Notlars.Add(yeniNot);
            db.SaveChanges();

            return OperationResult.Success("Not başarıyla eklendi.");
        }

        public OperationResult UpdateNote(NoteDTO dto)
        {
            var not = db.Notlars.Find(dto.Id);
            if (not == null)
                return OperationResult.Failure("Not bulunamadı.");

            not.ogrenci_id = dto.StudentId;
            not.ders_kodu = dto.DersKodu;
            not.not_degeri = dto.NotDegeri;
            not.tarih = dto.Tarih;

            db.SaveChanges();
            return OperationResult.Success("Not güncellendi.");
        }

        public OperationResult DeleteNote(int id)
        {
            var not = db.Notlars.Find(id);
            if (not == null)
                return OperationResult.Failure("Not bulunamadı.");

            db.Notlars.Remove(not);
            db.SaveChanges();
            return OperationResult.Success("Not silindi.");
        }
    }
}