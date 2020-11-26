using NewsAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TopHeadlinesApp.UI.Models;

namespace TopHeadlinesApp.UI
{
   public class NewsRetriever
   {
      private const string ApiKey = "e3d577984b954a588c3ddf3d90af9f74";
      public async Task<ObservableCollection<Models.Article>> GetArticlesFromApi(string country, string category)
      {
         HttpClient client = new HttpClient();

         HttpResponseMessage response = await client.GetAsync(
            $@"https://newsapi.org/v2/top-headlines?country={country}&apiKey={ApiKey}&category={category}");

         string responseBody = await response.Content.ReadAsStringAsync();

         ArticlesResult articleResult = JsonConvert.DeserializeObject<ArticlesResult>(responseBody);

         ObservableCollection<Models.Article> articles = new ObservableCollection<Models.Article>();

         foreach (var article in articleResult.Articles)
         {
            articles.Add(new Models.Article
            {
               Title = article.Title,
               Author = article.Author,
               PublishedAt = article.PublishedAt.Value,
               Comments = new ObservableCollection<Comment>()
            });
         }

         return articles;
      }

      public ObservableCollection<Models.Article> GetFakeArticles()
      {
         return new ObservableCollection<Models.Article>()
         {
            new Models.Article
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
            new Models.Article
            {
               Title = "Breaking News Report 2",
               Author = "The News Person 2",
               PublishedAt = DateTime.Now.AddMinutes(-10),
               Comments = new ObservableCollection<Comment>()
            },
            new Models.Article
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
