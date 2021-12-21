using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ekz_Apteka.Models
{
    public class MedicineType
    {
        [Key]
        public int MedicineTypeId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MedicineTypeName { get; set; }
    }
}
