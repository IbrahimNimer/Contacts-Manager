using System.Collections.Generic;
using Xunit;

namespace Contacts_Manager_Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            string action = "add";
            List<string> Contact = new List<string>
            {
                "Ibrahim", "Jafar", "Moayad"
            };
            string name = "Abed";

            // Act
            List<string> Result = Contacts_Manager.CManager.ContactsManager(Contact, action, name);

            // Assert
            Assert.Equal(4, Result.Count);
            Assert.Contains("Abed", Result);
        }

        [Fact]
        public void RejectedAddTest()
        {
            // Arrange
            string action = "add";
            List<string> Contact = new List<string>
            {
                "Ibrahim", "Jafar", "Moayad"
            };
            string name = "Ibrahim";

            // Act
            List<string> Result = Contacts_Manager.CManager.ContactsManager(Contact, action, name);

            // Assert
            Assert.Equal(3, Result.Count);
        }

        [Fact]
        public void RemoveTest()
        {
            // Arrange
            string action = "remove";
            List<string> Contact = new List<string>
            {
                "Ibrahim", "Jafar", "Moayad"
            };
            string name = "Ibrahim";

            // Act
            List<string> Result = Contacts_Manager.CManager.ContactsManager(Contact, action, name);

            // Assert
            Assert.Equal(2, Result.Count);
            Assert.DoesNotContain("Ibrahim", Result);
        }

        [Fact]
        public void ViewTest()
        {
            // Arrange
            string action = "view";
            List<string> Contact = new List<string>
            {
                "Ibrahim", "Jafar", "Moayad"
            };

            // Act
            List<string> Result = Contacts_Manager.CManager.ContactsManager(Contact, action);

            // Assert
            Assert.Equal(3, Result.Count);
        }

        [Fact]
        public void AddEmptyContactTest()
        {
            // Arrange
            string action = "add";
            List<string> Contact = new List<string>
            {
                "Ibrahim", "Jafar", "Moayad"
            };
            string name = "";

            // Act
            List<string> Result = Contacts_Manager.CManager.ContactsManager(Contact, action, name);

            // Assert
            Assert.Equal(3, Result.Count);
        }

        [Fact]
        public void RemoveNonExistentContactTest()
        {
            // Arrange
            string action = "remove";
            List<string> Contact = new List<string>
            {
                "Ibrahim", "Jafar", "Moayad"
            };
            string name = "Ali";

            // Act
            List<string> Result = Contacts_Manager.CManager.ContactsManager(Contact, action, name);

            // Assert
            Assert.Equal(3, Result.Count);
        }
    }
}
