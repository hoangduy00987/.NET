using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first
{
class CreateDb: CreateDatabaseIfNotExists<QLSV>
    {
        //để thêm dữ liệu thì override lại hàm seed
        //nếu csdl chưa tồn tại thì tạo csdl mới

        // để khởi tạo thì phải kế thừa từ 1 chiến lước;

        protected override void Seed(QLSV context)
        {
            context.LSHes.AddRange(new LSH[]
            {
                new LSH {ID_LOP = 1,NameLop = "21T"},
             new LSH {ID_LOP = 2,NameLop = "22T"}
            });
            context.SVs.AddRange(new SV[]
            {
                 new SV { MSSV= "101",Name = "DUY",Gender=true,NgaySinh = DateTime.Now,ID_LOP = 1},
                  new SV { MSSV= "102",Name = "DUYA",Gender=true,NgaySinh = DateTime.Now,ID_LOP = 2},
                   new SV { MSSV= "103",Name = "DUYB",Gender=true,NgaySinh = DateTime.Now,ID_LOP = 1}


            });
        }
    }
}
