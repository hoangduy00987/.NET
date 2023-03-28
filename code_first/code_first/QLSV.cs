using System;
using System.Data.Entity;
using System.Linq;

namespace code_first
{
    public class QLSV : DbContext//có thể thay đổi cấu trúc csdl
    {
      
        public QLSV()
            : base("name=Model1")
        {
            Database.SetInitializer<QLSV>(new CreateDb());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<SV> SVs { get; set; }
       public virtual DbSet<LSH> LSHes { get; set; }
       
    }
    //
 
}