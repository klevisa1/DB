using System;
namespace ConectionMySQL.Properties
{
    public class test
    {
        static void Main(string[]args)
        {
            DBConnection conn = DBConnection.Instance();
            conn.DatabaseName = "student";
            try
            {
                if (conn.IsConnect())
                {
                    Console.WriteLine("Conectet to Database");

                }
                else
                {

                    Console.WriteLine("Connection failed");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //conn.Close();
                Console.WriteLine("Fundi i app");
            }
                
            


        }
        
    }
}