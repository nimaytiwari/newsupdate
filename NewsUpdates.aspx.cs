using System;
using System.Collections.Generic;
using System.Web;

namespace newsupdate
{
    public partial class NewsUpdates : System.Web.UI.Page
    {
        public List<NewsItem> NewsItems { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve news updates
                NewsItems = GetNewsItems();
            }
        }

        private List<NewsItem> GetNewsItems()
        {
            List<NewsItem> newsItems = new List<NewsItem>();

            // Sample news updates
            newsItems.Add(new NewsItem
            {
                Title = "Update I",
                Date = "24 Jun 05:17 PM",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam pellentesque dui rhoncus luctus posuere. Morbi dictum vitae turpis et hendrerit. Morbi egestas sollicitudin magna, sit amet euismod nisl iaculis convallis. Nunc sed congue purus, eu posuere sapien. Donec auctor neque non porttitor tristique. Donec tristique quam magna, ac semper nunc laoreet eu. Curabitur quis eleifend lacus, eu finibus lectus. Donec a varius nulla. Vivamus orci ligula, vehicula a volutpat quis, tincidunt ut diam. In sollicitudin, dui ut eleifend sollicitudin, elit neque lacinia massa, lacinia sollicitudin tortor arcu id sapien. Aenean sit amet leo ut eros vehicula lobortis. Integer lacinia feugiat suscipit. Phasellus non imperdiet magna. Maecenas ut viverra justo, vitae tincidunt velit. Ut vel augue sit amet lectus tincidunt lacinia ut vitae nibh. "
            });

            //newsItems.Add(new NewsItem
            //{
            //    Title = "News Update 2",
            //    Date = "DateTime.Now",
            //    Content = "This is the content of news update 2."
            //});

            //newsItems.Add(new NewsItem
            //{
            //    Title = "News Update 3",
            //    Date = "DateTime.Now",
            //    Content = "This is the content of news update 3."
            //});

            return newsItems;
        }
    }

    public class NewsItem
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
    }
}
