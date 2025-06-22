using System;
using System.Collections.Generic;
using System.Linq;

namespace DbHelper.Services
{
    public static class LookupService
    {
        public static List<string> GetAuthorities()
        {
            using (var db = new sah_obs_basicEntities())
            {
                return db.Yetkilers.Select(x => x.yetki_adi).ToList();
            }
        }

        public static List<string> GetStatuses()
        {
            using (var db = new sah_obs_basicEntities())
            {
                return db.Status.Select(x => x.StatusName).ToList();
            }
        }

        public static List<string> GetEducations()
        {
            using (var db = new sah_obs_basicEntities())
            {
                return db.Derslers.Select(x => x.DersAdi).ToList();
            }
        }

        public static List<string> GetUsers()
        {
            using (var db = new sah_obs_basicEntities())
            {
                return db.Kullanicilars.Select(x => x.name).ToList();
            }
        }
    }
}