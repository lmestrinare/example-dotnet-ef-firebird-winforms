using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace example_dotnet_ef_firebird_winforms.Models
{
    public class SMS
    {
        [Key]
        [Column("ID_SMS")]
        [DisplayName("Código")]
        public int id { get; set; }
        
        [Column("ORIGEM_SMS")]
        [DisplayName("Origem")]
        public String Origem { get; set; }

        [Column("FONE_SMS")]
        [DisplayName("Telefone")]
        public String Fone { get; set; }
    }
}
