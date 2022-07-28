using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EntityOrnek
{
    class SqlBaglantisi
    {
        public SqlConnection SqlBaglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=OGUZHAN;Initial Catalog=DbSınav;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
        

    }
}
