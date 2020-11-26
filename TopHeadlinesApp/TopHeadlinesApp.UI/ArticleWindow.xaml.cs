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
using TopHeadlinesApp.UI.Models;
using TopHeadlinesApp.UI.ViewModels;

namespace TopHeadlinesApp.UI
{
   /// <summary>
   /// Interaction logic for ArticleWindow.xaml
   /// </summary>
   public partial class ArticleWindow : Window
   {
      ArticleWindowViewModel _articleWindowViewModel;
      public ArticleWindow(Article article, User user)
      {
         InitializeComponent();
         _articleWindowViewModel = new ArticleWindowViewModel(article, user);
         DataContext = _articleWindowViewModel;
      }

      private void addCommentButton_Click(object sender, RoutedEventArgs e)
      {
         _articleWindowViewModel.AddComment();
      }
   }
}
