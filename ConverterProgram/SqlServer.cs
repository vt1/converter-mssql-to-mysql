using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterProgram
{
    class SqlServer
    {
        private SqlConnection cnn;
        private string connectionString = null;
        public SqlServer()
        {
            createConnection();
        }

        public void createConnection()
        {
            connectionString = "Initial Catalog=odbo;Data Source=(local);Integrated Security=SSPI;";
            cnn = new SqlConnection(connectionString);
            try
            {                
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection !");
            }
        }

        public SqlConnection getSqlConnection()
        {
            return cnn;
        }

    }
}
