using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ekz_Apteka.Models
{
    public class Medicine
    {
        [Key]
        public long MedicineId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MedicineName { get; set; }

        public decimal MedicinePrice { get; set; }

        public DateTime SellTime { get; set; }

        public int MedicineTypeId { get; set; }
        public MedicineType MedicineType { get; set; }
    }
}
