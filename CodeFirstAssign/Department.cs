using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssign
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptID { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [RegularExpression("^(Finance|HR)$", ErrorMessage = "Invalid Department. It should be finance or HR")]
        public string DepartmentName { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength (20)]
        public string Manager {  get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public Byte[] DepartmentEdit { get; set; }  

    }
}
