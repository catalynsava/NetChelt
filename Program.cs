using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace NetChelt
{
    public class Program
    {
        public static SQLiteConnection Conexiune;
        public static SQLiteTransaction Tranzactie;
        public static SQLiteCommand Comanda;
        public static SQLiteDataReader CititorDate;

        public static void Main(string[] args)
        {
            
            Console.WriteLine("deschidere conexiune " + deschideConexiune());
            CreateHostBuilder(args).Build().Run();
        }
        private static bool deschideConexiune(){
            try
            {
                var strBuilder=new SQLiteConnectionStringBuilder();
                strBuilder.DataSource=AppDomain.CurrentDomain.BaseDirectory + "cheltuieli.db";
                strBuilder.Version=3;
                strBuilder.WaitTimeout=30;
                strBuilder.UseUTF16Encoding=true;
                strBuilder.Pooling=true;
                strBuilder.PageSize=1024;

                Conexiune=new SQLiteConnection(strBuilder.ConnectionString);
				Conexiune.Open();
                return true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool inchideConexiune(){
            try
            {
                Conexiune.Close();
                Conexiune.Dispose();
                return true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
			
		}

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
