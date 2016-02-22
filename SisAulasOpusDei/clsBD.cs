using System.Data.SqlClient;

namespace SisAulasOpusDei
{
    class clsBD
    {
        static SqlConnection _sqlCon;
        
        public static SqlConnection SqlSisConnnection
        {
            get 
            { 
                if (_sqlCon == null)
                {
                    _sqlCon = new SqlConnection("Data Source=PAULOMRAMOS-PC\\PAULO;Initial Catalog=SisAulasPite;Integrated Security=True");
                }
                return _sqlCon; 
            }
        }
        
    }
}
