using _3_layers.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_layers.DAL;
namespace _3_layers.BLL
{
    public class QLSV_BLL
    {
        public List<CBBItem> GetCBBItems()
        {
            List<CBBItem> data = new List<CBBItem>();
            data.Add(new CBBItem { Value = "0", Text = "All" });
            QLSVDAL dal = new QLSVDAL();
            foreach (LopSH i in dal.GetAllLSH())
            {
                data.Add(new CBBItem { Value = i.IDlOP.ToString(), Text = i.NameSH });

            }
            return data;
        }





        public List<SV> GetSVByIDLop(int ID_lop)
        {
            List<SV> data = new List<SV>();
            QLSVDAL dal = new QLSVDAL();
            if (ID_lop == 0)
            {
                data = dal.GetAllSv();
            }
            else
            {
                foreach (SV i in dal.GetAllSv())
                {
                    if (i.IDlOP == ID_lop)
                    {
                        data.Add(i);
                    }
                }
            }
            return data;
        }
    }

}