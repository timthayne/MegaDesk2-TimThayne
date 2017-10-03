using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            _deskQuote = deskQuote;

            // set form properties
            txtCustomerName.Text = _deskQuote.CustomerName;
            numDeskWidth.Value = _deskQuote.Desk.Width;
            numDeskDepth.Value = _deskQuote.Desk.Depth;
            numNumberOfDrawers.Value = _deskQuote.Desk.NumberOfDrawers;

            switch (_deskQuote.Desk.SurfaceMaterial)
            {
                case Desk.Surface.Laminate:
                    comSurfaceMaterial.SelectedIndex = 0;
                    break;

                case Desk.Surface.Oak:
                    comSurfaceMaterial.SelectedIndex = 1;
                    break;

                case Desk.Surface.Pine:
                    comSurfaceMaterial.SelectedIndex = 2;
                    break;

                case Desk.Surface.Rosewood:
                    comSurfaceMaterial.SelectedIndex = 3;
                    break;

                case Desk.Surface.Veneer:
                    comSurfaceMaterial.SelectedIndex = 4;
                    break;
            }

            switch (_deskQuote.DeliveryType)
            {
                case DeskQuote.Delivery.Rush3Days:
                    comDelivery.SelectedIndex = 0;
                    break;

                case DeskQuote.Delivery.Rush5Days:
                    comDelivery.SelectedIndex = 1;
                    break;

                case DeskQuote.Delivery.Rush7Days:
                    comDelivery.SelectedIndex = 2;
                    break;

                case DeskQuote.Delivery.Normal14Days:
                    comDelivery.SelectedIndex = 3;
                    break;
            }

            txtPriceQuote.Text = _deskQuote.QuoteAmount.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var frmMainMenu = new MainMenu();
            frmMainMenu.Show();
            Close();
        }
    }
}
