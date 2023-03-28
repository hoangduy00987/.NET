using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _3_layers.DAL;
using _3_layers.DTO;

namespace _3_layers.DAL
{

    public class QLSVDAL
    {
        public List<SV> GetAllSv()
        {
            List<SV> data = new List<SV>();
            string query = "Select * from SV";
            foreach (DataRow i in DbHelper.Instance.gettable(query).Rows)
            {
                data.Add(getSVByDataRow(i));
            }
            return data;

        }
        public SV getSVByDataRow(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                TENSV = i["TENSV"].ToString(),
                DTB = Convert.ToDouble(i["DTB"].ToString()),
               // IDlOP = Convert.ToInt32(i["IDLOP"].ToString())
            };
        }
        public List<LopSH> GetAllLSH()
        {
            List<LopSH> data = new List<LopSH>();
            string query = "Select * from LOP";
            foreach (DataRow i in DbHelper.Instance.gettable(query).Rows)
            {
                data.Add(getLSHByDataRow(i));
            }
            return data;

        }
        public LopSH getLSHByDataRow(DataRow i)
        {
            return new LopSH
            {
                IDlOP = Convert.ToInt32(i["IDlOP"].ToString()),
                NameSH = i["TENLOP"].ToString()
            };



        }
       
    }
}