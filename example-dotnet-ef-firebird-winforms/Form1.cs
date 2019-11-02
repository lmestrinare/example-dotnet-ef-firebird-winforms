using example_dotnet_ef_firebird_winforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_dotnet_ef_firebird_winforms
{
    public partial class Form1 : Form
    {
        private AppDbContext db = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private static DataTable ConvertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.DisplayName, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.DisplayName, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SMS> SMSItem = db.SMS.ToList();

            DataTable table = ConvertToDatatable(SMSItem);
            dataGridView1.DataSource = table;

        }
    }
}
