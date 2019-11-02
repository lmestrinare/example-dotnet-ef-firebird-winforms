using example_dotnet_ef_firebird_winforms.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace example_dotnet_ef_firebird_winforms.Mapping
{
    class SMSMap : EntityTypeConfiguration<SMS>
    {
        public SMSMap()
        {
            ToTable("SMS");
        }
    }
}
