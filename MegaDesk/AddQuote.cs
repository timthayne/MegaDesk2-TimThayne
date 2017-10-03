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
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();

            desk.Depth = numDeskDepth.Value;
            desk.Width = numDeskWidth.Value;
            desk.NumberOfDrawers = (int)numNumberOfDrawers.Value;

            switch (comSurfaceMaterial.Text.ToLower())
            {
                case "laminate":
                    desk.SurfaceMaterial = Desk.Surface.Laminate;
                    break;

                case "oak":
                    desk.SurfaceMaterial = Desk.Surface.Oak;
                    break;

                case "pine":
                    desk.SurfaceMaterial = Desk.Surface.Pine;
                    break;

                case "rosewood":
                    desk.SurfaceMaterial = Desk.Surface.Rosewood;
                    break;

                case "veneer":
                    desk.SurfaceMaterial = Desk.Surface.Veneer;
                    break;
            }

            var deskQuote = new DeskQuote();

            deskQuote.Desk = desk;
            deskQuote.CustomerName = txtCustomerName.Text;
            deskQuote.QuoteDate = DateTime.Now;
            
            switch(comDelivery.Text.ToLower())
            {
                case "rush - 3 days":
                    deskQuote.DeliveryType = DeskQuote.Delivery.Rush3Days;
                    break;

                case "rush - 5 days":
                    deskQuote.DeliveryType = DeskQuote.Delivery.Rush5Days;
                    break;

                case "rush - 7 days":
                    deskQuote.DeliveryType = DeskQuote.Delivery.Rush7Days;
                    break;

                case "normal - 14 days":
                    deskQuote.DeliveryType = DeskQuote.Delivery.Normal14Days;
                    break;
            }

            try
            {
                var quote = deskQuote.GetQuote();

                //TODO: ensure valid quote amount
                deskQuote.QuoteAmount = quote;

                AddQuoteToFile(deskQuote);

                //TODO: show quote in DisplayQuote (via construtor)

            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            string ordersFile = @"quotes.txt";
            if (!File.Exists(ordersFile))
            {
                using (StreamWriter streamWriter = File.CreateText("quotes.txt"))
                {
                    streamWriter.WriteLine(
                        $"{deskQuote.QuoteDate}," +
                        $"{deskQuote.CustomerName}," +
                        $"{deskQuote.Desk.Depth}," +
                        $"{deskQuote.Desk.Width}," +
                        $"{deskQuote.Desk.NumberOfDrawers}," +
                        $"{deskQuote.Desk.SurfaceMaterial}," +
                        $"{deskQuote.QuoteAmount}," +
                        $"{deskQuote.DeliveryType}, " +
                        $"{deskQuote.QuoteAmount}");
                }

            }
            using (StreamWriter streamWriter = File.AppendText(@"quotes.txt"))
            {
                streamWriter.WriteLine(
                    $"{deskQuote.QuoteDate}," +
                    $"{deskQuote.CustomerName}," +
                    $"{deskQuote.Desk.Depth}," +
                    $"{deskQuote.Desk.Width}," +
                    $"{deskQuote.Desk.NumberOfDrawers}," +
                    $"{deskQuote.Desk.SurfaceMaterial}," +
                    $"{deskQuote.QuoteAmount}," +
                    $"{deskQuote.DeliveryType}, " +
                    $"{deskQuote.QuoteAmount}");
            }
        }
    }
}

