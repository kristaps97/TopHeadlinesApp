using NewsAPI.Constants;
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

      public List<string> Countries { get; set; }
      public List<string> Categories { get; set; }

      public string SelectedCountry { get; set; }
      public string SelectedCategory { get; set; }

      public MainWindowViewModel(string username)
      {
         Username = username;

         // Using Enums from NewsApi nuget package to fill the list of
         // countries and categories
         Countries = Enum.GetNames(typeof(Countries)).ToList();
         Categories = Enum.GetNames(typeof(Categories)).ToList();
      }
   }
}
