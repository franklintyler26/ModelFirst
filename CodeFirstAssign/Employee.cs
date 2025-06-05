using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssign
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "Varchar")]
        [MaxLength(10)]
        [Required]
        [RegularExpression("^E+[0-9]{3}$", ErrorMessage = "ID should start with 'E' followed by 3 digits")]
        public string EmpID { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        public string EmpName { get; set; }

        //navigation property
        [ForeignKey("DeptID")]
        public Department Department { get; set; }
        public int DeptID { get; set; }
       
        [Range(50000, 150000, ErrorMessage = "Invalid Salary")]
        public int Salary { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateofBirth {  get; set; }

    }
}
