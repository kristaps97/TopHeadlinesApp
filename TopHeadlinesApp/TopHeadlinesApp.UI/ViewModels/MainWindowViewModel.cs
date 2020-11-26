using NewsAPI.Constants;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopHeadlinesApp.UI.Models;

namespace TopHeadlinesApp.UI.ViewModels
{
   public class MainWindowViewModel : INotifyPropertyChanged
   {
      public NewsRetriever _newsRetriever = new NewsRetriever();
      public ObservableCollection<Article> Articles { get; set; }

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

         Articles = new ObservableCollection<Article>();
      }

      public async void RefreshArticles()
      {

         if (!string.IsNullOrEmpty(SelectedCountry) && !string.IsNullOrEmpty(SelectedCategory))
         {
            Articles.Clear();           
            Articles = _newsRetriever.GetFakeArticles();
            OnPropertyChanged("Articles");
         }
      }

      public event PropertyChangedEventHandler PropertyChanged;

      private void OnPropertyChanged(string property)
      {
         if (PropertyChanged != null)
         {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
         }
      }
   }
}
