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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            // populate materials combobox
            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                             .Cast<Desk.DesktopMaterial>()
                             .ToList();

            comSurfaceMaterial.DataSource = materials;

            // set default to empty
            comSurfaceMaterial.SelectedIndex = -1;


            // populate shipping combobox
            var shipping = new List<DeskQuote.Delivery>();

            shipping = Enum.GetValues(typeof(DeskQuote.Delivery))
                            .Cast<DeskQuote.Delivery>()
                            .ToList();

            comDelivery.DataSource = shipping;

            // set deafult to empty
            comDelivery.SelectedIndex = -1;

            // set numericupdown controls to empty
            numDeskWidth.Text = String.Empty;
            numDeskDepth.Text = String.Empty;
            numNumberOfDrawers.Text = String.Empty;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk
            {
                Depth = numDeskDepth.Value,
                Width = numDeskWidth.Value,
                NumberOfDrawers = (int)numNumberOfDrawers.Value,
                Material = (Desk.DesktopMaterial)comSurfaceMaterial.SelectedValue
            };
            
            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = txtCustomerName.Text,
                QuoteDate = DateTime.Now,
                DeliveryType = (DeskQuote.Delivery)comDelivery.SelectedValue
            };

            try
            {
                // get quote amount
                var quote = deskQuote.GetQuote();

                // add amount to quote
                deskQuote.QuoteAmount = quote;

                // add quote to file
                AddQuoteToFile(deskQuote);

                // show 'DisplayQuote' form
                DisplayQuote frmDisplayQuote = new DisplayQuote(deskQuote);
                frmDisplayQuote.Show();
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.InnerException.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotes = null;

            // read existing quotes
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    // load existing quotes
                    string quotes = reader.ReadToEnd();

                    // deserialize quotes
                    deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                    // add a new quote
                    deskQuotes.Add(deskQuote);
                }

                // save to file
                SaveQuotes(deskQuotes);
            }
            else
            {
                // create quote list
                deskQuotes = new List<DeskQuote> { deskQuote };

                // save to file
                SaveQuotes(deskQuotes);
            }         
        }

        private void SaveQuotes(List<DeskQuote> quotes)
        {
            var quotesFile = @"quotes.json";

            // serilize quotes
            var serializedQuotes = JsonConvert.SerializeObject(quotes);

            // write quotes to file
            File.WriteAllText(quotesFile, serializedQuotes);
        }
    }
}

