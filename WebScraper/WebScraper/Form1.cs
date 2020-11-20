using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WebScraper
{

    public partial class Form1_WebScraper : Form
    {
        public Form1_WebScraper()
        {


            InitializeComponent();


        }




        private async void btn_enter_Click(object sender, EventArgs e)
        {
            List<string> itemList = new List<string>();
            var url = tb_url;

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url.Text);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var doc = htmlDocument.DocumentNode.Descendants("tr")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("odd")).ToList();

            foreach (var item in doc)
            {
                itemList.Add(item.InnerText);
            }

            foreach (var item in itemList)
            {
                tb_main.Text += item;
            }
            //PARSE OUT DESCRIPTIONS
            //GO THROUGH HREF'S 
        }
    }
    }
        
    

