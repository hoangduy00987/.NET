using mo_HINH_3layers.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo_HINH_3layers.BLL
{
    public class QLSV_BLL
    {
        public List<CBBItems> GetCBBItems(int ID_LOP)
        {
            List<CBBItems> data = new List<CBBItems>();
            data.Add(new CBBItems { Value = "0", Text = "ALL" });
           QLSV_BLL ql = new QLSV_BLL();
            foreach(CBBItems i in ql.get)
        }

    }
}
