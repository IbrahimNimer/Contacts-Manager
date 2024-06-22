using System;
using System.Collections.Generic;

namespace Contacts_Manager
{
    public class CManager
    {


        // // // 
        public static List<string> ContactsManager(List<string> Contact, string action, string name = "")
        {
            if (action == "add" && !string.IsNullOrEmpty(name))
            {
                AddContact(Contact, name);
            }
            if (action == "remove" && !string.IsNullOrEmpty(name))
            {
                RemoveContact(Contact, name);
            }
            if (action == "view")
            {
                ViewAllContacts(Contact);
            }

            return Contact;
        }

        public static List<string> AddContact(List<string> Contact, string name)
        {
            if (!Contact.Contains(name) && !string.IsNullOrEmpty(name))
            {
                Contact.Add(name);
            }
            return Contact;
        }

        public static List<string> RemoveContact(List<string> Contact, string name)
        {
            if (Contact.Contains(name))
            {
                Contact.Remove(name);
            }
            return Contact;
        }

        public static List<string> ViewAllContacts(List<string> Contact)
        {
            return Contact;
        }
    }
}
