using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first
{
    public class LSH
    {
        public LSH() {
            SVs = new HashSet<SV>();
             
         }
        //khởi tạo đối tượng của lớp sinh hoạt trước
        [Key]
        public int ID_LOP { get; set; }
        public string NameLop { get; set; }
        public virtual ICollection<SV> SVs { get; set; }
            //khai báo thuộc tính quan hệ sinh viên bằng Icolection quan hện q lớp nhiều sinh viên 
    }
}
