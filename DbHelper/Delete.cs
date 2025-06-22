using System.Linq;
using DbHelper.DTOS;

namespace DbHelper
{
    public class Delete
    {
        private sah_obs_basicEntities db = new sah_obs_basicEntities();

        public OperationResult User_Delete(UserDTO userDto)
        {
            var user = db.Kullanicilars
                .FirstOrDefault(x => x.name == userDto.Name && x.surname == userDto.Surname);

            if (user == null)
            {
                return OperationResult.Failure("Böyle bir kullanıcı bulunamadı.");
            }

            db.Kullanicilars.Remove(user);
            int result = db.SaveChanges();

            if (result > 0)
            {
                return OperationResult.Success($"{userDto.Name} {userDto.Surname} adlı kullanıcı başarıyla silindi.");
            }
            else
            {
                return OperationResult.Failure("Kullanıcı silinirken bir hata oluştu.");
            }
        }

        public OperationResult Anno_Delete(int id)
        {
            var announcement = db.Duyurulars.Find(id);
            if (announcement == null)
                return OperationResult.Failure("Duyuru bulunamadı.");

            db.Duyurulars.Remove(announcement);
            db.SaveChanges();

            return OperationResult.Success("Duyuru silindi.");
        }

        public OperationResult Disc_Delete(int id)
        {
            var disc = db.Devamsizliks.Find(id);
            if (disc == null)
                return OperationResult.Failure("Devamsızlık kaydı bulunamadı.");
            db.Devamsizliks.Remove(disc);
            db.SaveChanges();
            return OperationResult.Success("Devamsızlık kaydı silindi.");
        }

        public OperationResult Note_Delete(int id)
        {
            var note = db.Notlars.Find(id);
            if (note == null)
                return OperationResult.Failure("Not bulunamadı.");

            db.Notlars.Remove(note);
            db.SaveChanges();
            return OperationResult.Success("Not silindi.");
        }
    }
}