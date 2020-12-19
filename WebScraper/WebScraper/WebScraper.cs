using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        //Built to scrape off docs.microsoft websites in this format: (ex)
        //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types
        //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/program-building-blocks
        //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/features
        //https://docs.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2003/
        //https://docs.microsoft.com/en-us/powershell/scripting/overview?view=powershell-7.1
        //https://docs.microsoft.com/en-us/dotnet/api/microsoft.activities.build.expressions.expressionsbuildextension?view=netframework-4.8
        //https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/add-history?view=powershell-7.1


        private async void btn_enter_Click(object sender, EventArgs e)
        {
            List<string> itemList = new List<string>();

            //url textbox to var
            var url = tb_url;

            var httpClient = new HttpClient();

            //HttpClient connects to the URL
            var html = await httpClient.GetStringAsync(url.Text);

            //Create a new AgilityPack HTMLDocument
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();

            htmlDocument.LoadHtml(html);

            //Seach and create list of results
            var docOdd = htmlDocument.DocumentNode.Descendants("tr")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("odd")).ToList();

            var docEven = htmlDocument.DocumentNode.Descendants("tr")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("odd")).ToList();


            //I would rather have it get rows in a table if there is one, if not then I get everything. 
            if (docOdd.Count == 0 && docEven.Count == 0)
            {
                htmlDocument.LoadHtml(html);

                var doc = htmlDocument.DocumentNode.Descendants("main")
                    .Where(node => node.GetAttributeValue("p", "")
                    .Equals("")).ToList();

                //Clean List
                foreach (var item in doc)
                {
                    itemList.Add(item.InnerText);
                }

                foreach (var item in itemList)
                {
                    tb_main.Text += item;
                }
                //PAR
            }

            if (docOdd.Count != 0 && docEven.Count != 0)
            {
                //Clean List
                foreach (var item in docOdd)
                {
                    itemList.Add(item.InnerText);
                }

                foreach (var item in docEven)
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

        private void Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(tb_filepath.Text, tb_main.Text);
        }

        private void btn_fileExplorer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            tb_filepath.Text = openFileDialog.FileName.ToString();
        }
    }
}
        
    

