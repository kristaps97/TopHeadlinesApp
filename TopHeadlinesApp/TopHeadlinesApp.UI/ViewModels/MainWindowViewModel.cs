using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopHeadlinesApp.UI.ViewModels
{
   public class MainWindowViewModel
   {
      public string Username { get; set; }

      public MainWindowViewModel(string username)
      {
         Username = username;
      }
   }
}
