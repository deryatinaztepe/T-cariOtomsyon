using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TİcariOtomsyon
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-OSOK6P2;Initial Catalog=Dbo_TicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
