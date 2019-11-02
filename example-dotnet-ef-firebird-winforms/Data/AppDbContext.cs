using example_dotnet_ef_firebird_winforms.Mapping;
using example_dotnet_ef_firebird_winforms.Models;
using FirebirdSql.Data.FirebirdClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Text;

namespace example_dotnet_ef_firebird_winforms
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("Conexao") {  }

        public DbSet<SMS> SMS { get; set; }
    }
}
