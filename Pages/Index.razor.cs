using MyFirstBalzorServerApp.Models;

namespace MyFirstBalzorServerApp.Pages
{
    public partial class Index
    {
        private List<Contact> contacts;
        private Dictionary<string, object> MyTextBoxAttributes = new Dictionary<string, object>
    {
      {"placeholder","FirstName"},
      {"disabled","disabled"}
    };

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            //contacts = new List<Contact>();
            contacts = new List<Contact>
        {
            new Contact
            {
                FirstName = "John",
                LastName = "Th",
                Email = "Johnth@gmail.com",
            }, new Contact
            {
                FirstName = "Don",
                LastName = "Th",
                Email = "Donth@gmail.com",
            }, new Contact
            {
                FirstName = "Bon",
                LastName = "Th",
                Email = "Bonth@gmail.com",
            }
        };
            base.OnInitializedAsync();
        }
    }
}
