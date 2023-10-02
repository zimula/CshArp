

using MySql.Data.MySqlClient;
using MySql.Data.EntityFramework;
using System.Data;
using MySqlX.XDevAPI.Relational;
using System.Security.Cryptography.X509Certificates;
using DataAdapter.Access;

namespace DataAdapter
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            AccessAfdeling afdeling = new AccessAfdeling();
            afdeling.accessEmps();

            
            
        }
    }

}