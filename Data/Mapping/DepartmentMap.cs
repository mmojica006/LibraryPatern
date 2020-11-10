using Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            HasKey(t => t.ID);
            Property(t => t.Name).IsRequired();
            Property(t => t.IP);
            //table
            ToTable("Departments");
        }
    }
}
