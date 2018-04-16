using System;
namespace Messenger
{
    public class Menu
    {
        MenuButton login = new MenuButton("Login");
        MenuButton newUser = new MenuButton("New user");
        MenuButton exit = new MenuButton("Exit");

        public void BasicMenu()
        {
           // Console.WriteLine(login.Name, newUser.Name, exit.Name);

        }
    }
}
