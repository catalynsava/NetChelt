using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite;


namespace NetChelt.Models
{
    public class UserModel
    {
        [Required(ErrorMessage="da un id!")]
        public static string Id { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        
        public static bool verificausernameparola(string username, string password){
				try{
					string strsql="SELECT ID, USERNAME, PASS FROM administrare WHERE ";
					strsql+="USERNAME='" + username + "'";
					strsql+=" AND PASS='" + password + "';";
					using(Program.Comanda=new SQLiteCommand(strsql, Program.Conexiune)){
						using(Program.CititorDate=Program.Comanda.ExecuteReader()){
							if(Program.CititorDate.Read()==true){

                                //UserModel ut=new UserModel();
                                Id=Program.CititorDate["id"].ToString();
                                UserName=Program.CititorDate["USERNAME"].ToString();
                                Password=Program.CititorDate["PASS"].ToString();

                                if(Program.CititorDate.IsClosed==false){
                                    Program.CititorDate.Close();
                                }

                                Program.Comanda.Dispose();

                                return true;
							}else{
                                return false;
                            }
						}
					}
				}catch(Exception ex){
					Console.WriteLine(ex.Message);
                    return false;
				}
		}
    }
}