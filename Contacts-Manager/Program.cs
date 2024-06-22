namespace Contacts_Manager
{
    public class Program
    {
        static void Main(string[] args)
        {
            string action = "add";
            List<string> Contact = new List<string>
            {
                "Ibrahim" , "Jafar" , "Moayad"
            };
            string name = "Abed";

            //Act    
            List<string> Result = Contacts_Manager.CManager.ContactsManager(Contact, action, name);

            for (int i = 0; Result.Count > i; i++)
            {
                Console.WriteLine(Result[i]);
            }
        }
    }
 }
