using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private Form _mainMenu;

        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            loadGrid();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // load existing quotes
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.Material,
                    DeliveryType = d.DeliveryType,
                    QuoteAmount = d.QuoteAmount
                }).ToList();

                //string deskQuotes = File.ReadAllLines(@"quotes.json");

                //foreach (string deskQuote in deskQuotes)
                //{
                //    string[] arrRow = deskQuote.Split(new char[] { ',' });
                //    dataGridView1.Rows.Add(arrRow);
                //}
            }
        }
    }
}
