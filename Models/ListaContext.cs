using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace NetChelt.Models
{
    public class ListaContext
    {
        public static List<ListaModel> ListaToDo { get; set; }  
        public ListaContext()
        {
            try{
                string strdenumiri = "SELECT lista.ID" + 
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
                                "lista.O" +
                        "FROM lista WHERE " +
                                "lista.NEVOIE=1 AND " +
                                "lista.ACTIV=1 " +
                        "ORDER BY lista.PRIORITATE, lista.PERIOADA;";
                
                
                using(Program.Tranzactie=Program.Conexiune.BeginTransaction(IsolationLevel.Serializable)){
				using(Program.Comanda=new SQLiteCommand()){
					Program.Comanda.Connection=Program.Conexiune;
					Program.Comanda.CommandText=strdenumiri;
					using(Program.CititorDate=Program.Comanda.ExecuteReader()){
						while (Program.CititorDate.Read()){
                            ListaToDo.Add(
                                new ListaModel{
                                        Id =Program.CititorDate[0].ToString(),
                                        Prioritate =(int)Program.CititorDate[1],
                                        Magazin =Program.CititorDate[2].ToString(),
                                        Scurt =Program.CititorDate[3].ToString(),
                                        Descriere=Program.CititorDate[4].ToString(),
                                        Valoare=(decimal)Program.CititorDate[5],
                                        Nevoie=(int)Program.CititorDate[6],
                                        Perioada=Program.CititorDate[7].ToString(),
                                        Date=Program.CititorDate[8].ToString(),
                                        Activ=(int)Program.CititorDate[9],
                                        O=Program.CititorDate[10].ToString()
                                }
                            );
							
						}
						Program.CititorDate.Close();
					}
					Program.Comanda.Dispose();
				}
                Program.Tranzactie.Dispose();
                }
					
			}catch(Exception ex){
				Console.WriteLine(ex.Message);
			}
        }
    }
}