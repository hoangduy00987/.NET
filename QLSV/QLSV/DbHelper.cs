using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
   public class DbHelper
    {
        private static DbHelper _Instance;
        private SqlConnection _cnn;
        private DbHelper(string s)
        {
            _cnn = new SqlConnection(s);
        }
        public static DbHelper Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DbHelper(@"Data Source=duy;Initial Catalog=SINHVIENDH;Integrated Security=True");

                return
                        _Instance;
            }
            private set { }
        }
        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();

        }
        public DataTable gettable(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }
    }
}
