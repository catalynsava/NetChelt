using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace NetChelt.Models
{
    public class ListaContext
    {
        public static List<ListaModel> ListaToDo=new List<ListaModel>();  
        public static List<ListaModel> incarcLista()
        {
            try{
                string strdenumiri = "SELECT " + 
                                "lista.ID, " +
                                "lista.PRIORITATE, " +
                                "lista.DENUMIRE, " +
                                "lista.MAGAZIN, " +
                                "lista.SCURT, " +
                                "lista.DESCRIERE, " +
                                "lista.VALOARE, " +
                                "lista.NEVOIE, " +
                                "lista.PERIOADA, " +
                                "lista.DATA, " +
                                "lista.ACTIV, " +
                                "lista.O " +
                        "FROM lista WHERE " +
                                "lista.NEVOIE=1 AND " +
                                "lista.ACTIV=1 " +
                        "ORDER BY lista.PRIORITATE, lista.PERIOADA;";

                Console.WriteLine(strdenumiri);
                
                
                using(Program.Tranzactie=Program.Conexiune.BeginTransaction(IsolationLevel.Serializable)){
				using(Program.Comanda=new SQLiteCommand()){
					Program.Comanda.Connection=Program.Conexiune;
					Program.Comanda.CommandText=strdenumiri;
					using(Program.CititorDate=Program.Comanda.ExecuteReader()){
						while (Program.CititorDate.Read()){
                            ListaToDo.Add(
                                new ListaModel{
                                        Id =Program.CititorDate[0].ToString(),
                                        Prioritate =Convert.ToInt32(Program.CititorDate[1]),
                                        Denumire=Program.CititorDate[2].ToString(),
                                        Magazin =Program.CititorDate[3].ToString(),
                                        Scurt =Program.CititorDate[4].ToString(),
                                        Descriere=Program.CititorDate[5].ToString(),
                                        Valoare=(decimal)Program.CititorDate[6],
                                        Nevoie=Convert.ToInt32(Program.CititorDate[7]),
                                        Perioada=Program.CititorDate[8].ToString(),
                                        Date=Program.CititorDate[9].ToString(),
                                        Activ=Convert.ToInt32(Program.CititorDate[10]),
                                        O=Program.CititorDate[11].ToString()
                                }
                            );
							
						}
						Program.CititorDate.Close();
					}
					Program.Comanda.Dispose();
				}
                Program.Tranzactie.Dispose();
                }
                return ListaToDo;
					
			}catch(Exception ex){
				Console.WriteLine(ex.Message);
                return ListaToDo;
			}
        }
    }
}