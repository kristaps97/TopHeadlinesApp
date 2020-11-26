using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TopHeadlinesApp.UI
{
   /// <summary>
   /// Interaction logic for LoginWindow.xaml
   /// </summary>
   public partial class LoginWindow : Window
   {
      public LoginWindow()
      {
         InitializeComponent();
      }

      private void loginButton_Click(object sender, RoutedEventArgs e)
      {
         // TODO : Implement proper login logic

         string username = usernameTextBox.Text;
         string password = passwordTextBox.Password.ToString();

         if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
         {
            MainWindow mainWindow = new MainWindow(username);
            mainWindow.Show();
            Close();
         }         
      }
   }
}
