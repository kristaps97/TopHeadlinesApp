using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopHeadlinesApp.UI.Models;

namespace TopHeadlinesApp.UI
{
   public class NewsRetriever
   {

      public ObservableCollection<Article> GetFakeArticles()
      {
         return new ObservableCollection<Article>()
         {
            new Article
            {
               Title = "Breaking News Report",
               Author = "The News Person",
               PublishedAt = DateTime.Now,
               Comments = new ObservableCollection<Comment>
               {
                  new Comment
                  {
                     UserId = "user1",
                     Content = "Very nice"
                  }
               }
            },
            new Article
            {
               Title = "Breaking News Report 2",
               Author = "The News Person 2",
               PublishedAt = DateTime.Now.AddMinutes(-10),
               Comments = new ObservableCollection<Comment>()
            },
            new Article
            {
               Title = "Breaking News Report 3",
               Author = "The News Person 3",
               PublishedAt = DateTime.Now.AddMinutes(-30),
               Comments = new ObservableCollection<Comment>()
            },
         };
      }
   }
}
