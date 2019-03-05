//MARTIN CARRION!!!!!!!

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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

namespace GameOfThrones02252019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //https://got-quotes.herokuapp.com/quotes
           using(HttpClient client=new HttpClient())
            {
                var response = client.GetAsync(@"https://got-quotes.herokuapp.com/quotes").Result;
                if(response.IsSuccessStatusCode)
                {
                    var Content = response.Content.ReadAsStringAsync().Result;
                    Quote q = JsonConvert.DeserializeObject<Quote>(Content);
                    txtQuote.Inlines.Add(new Italic(new Run(Content)));

                    if (Content.Contains("Tyrion"))
                    {
                        




                    }
                   
                    

                }
            }




        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
