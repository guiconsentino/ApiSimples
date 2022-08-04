using MySql.Data.MySqlClient;

namespace ApiGuilherme.DataBase
{
    public class Conect
    {

        public Conect()
        {
            
        }

        public MySqlConnection conectar()
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost; database=teste; user id =root; password =****** port =3306;";
                con.Open();
                Console.WriteLine("deu certo");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return conectar();
        }
        
    
    }
        
    
}
