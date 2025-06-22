using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper.DTOS
{
    public class NoteDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string DersKodu { get; set; }
        public decimal NotDegeri { get; set; }
        public DateTime Tarih { get; set; }
    }
}