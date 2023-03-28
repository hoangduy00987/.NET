using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace code_first
{
    //Datannotation: thiết lập các cụm từ khóa thông qua các mối quan hệ
    [Table("SinhVien")] 
   public class SV
    {
        [Column("soTheSV")][Key]
        //key để biết được cái nào là thuộc tính khóa chính
        //Required không cho phép null
        //column để tên tbale trùng tên thuộc tính
        public string MSSV { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime NgaySinh { get; set; }
        public int ID_LOP { get; set; }
        [ForeignKey("ID_LOP")]
        //khởi tạo thuộc tính khóa ngoại qua ID_LOP
        public virtual LSH LSH { get; set; }
    }
}
