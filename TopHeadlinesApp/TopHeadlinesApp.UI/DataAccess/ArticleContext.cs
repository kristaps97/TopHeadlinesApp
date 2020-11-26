using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopHeadlinesApp.UI.Models;

namespace TopHeadlinesApp.UI.DataAccess
{
   public class ArticleContext : DbContext
   {
      public ArticleContext() : base("ArticlesDbContext")
      {

      }

      public DbSet<User> Users { get; set; }
      public DbSet<Article> Articles { get; set; }
      public DbSet<Comment> Comments { get; set; }

   }
}
