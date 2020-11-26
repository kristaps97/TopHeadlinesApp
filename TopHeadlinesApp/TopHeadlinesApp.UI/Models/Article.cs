using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopHeadlinesApp.UI.Models
{
   public class Article
   {
      public int Id { get; set; }
      public string Title { get; set; }
      public string Author { get; set; }
      public DateTime PublishedAt { get; set; }
      public ObservableCollection<Comment> Comments { get; set; }
   }
}
