﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TopHeadlinesApp.UI.Models;
using TopHeadlinesApp.UI.ViewModels;

namespace TopHeadlinesApp.UI
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      MainWindowViewModel _mainWindowViewModel;
      public MainWindow(string username)
      {
         InitializeComponent();
         _mainWindowViewModel = new MainWindowViewModel(username);
         DataContext = _mainWindowViewModel;
      }

      private void RefreshNewsButton_Click(object sender, RoutedEventArgs e)
      {
         _mainWindowViewModel.RefreshArticles();
      }

      private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
      {
         var item = sender as ListViewItem;
         if (item != null && item.IsSelected)
         {
            var article = item.DataContext as Article;
            ArticleWindow articleWindow = new ArticleWindow(article, _mainWindowViewModel.User);
            articleWindow.Show();
         }
      }
   }
}
