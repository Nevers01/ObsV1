using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper.DTOS
{
    public class AnnoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AnnoType { get; set; }
        public string AnnoEdu { get; set; }
        public string CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}