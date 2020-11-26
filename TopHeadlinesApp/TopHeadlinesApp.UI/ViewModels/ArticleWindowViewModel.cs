using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopHeadlinesApp.UI.Models;

namespace TopHeadlinesApp.UI.ViewModels
{
   public class ArticleWindowViewModel
   {
      public Article Article { get; set; }
      public User User { get; set; }
      public string CurrentComment { get; set; }

      public ArticleWindowViewModel(Article article, User user)
      {
         Article = article;
         User = user;
      }

      public void AddComment()
      {
         Article.Comments.Add(new Comment
         {
            UserId = User.Username,
            Content = CurrentComment
         });
      }
   }
}
