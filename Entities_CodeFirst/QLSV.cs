namespace Entities_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QLSV : DbContext
    {
        // Your context has been configured to use a 'QLSV' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Entities_CodeFirst.QLSV' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLSV' 
        // connection string in the application configuration file.
        public QLSV()
            : base("name=QLSV")
        {
            Database.SetInitializer<QLSV>(new CreatDB());
        }

        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<LopSV> LopSVs { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}