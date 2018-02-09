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
        private Form _mainMenu;
        //private DeskQuote _deskQuote;
        
        public DisplayQuote(Form mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            //_deskQuote = deskQuote;

            // set form properties
            txtCustomerName.Text = deskQuote.CustomerName;
            numDeskWidth.Value = deskQuote.Desk.Width;
            numDeskDepth.Value = deskQuote.Desk.Depth;
            numNumberOfDrawers.Value = deskQuote.Desk.NumberOfDrawers;
            comSurfaceMaterial.SelectedValue = deskQuote.Desk.Material;
            comDelivery.SelectedValue = deskQuote.DeliveryType;
            /*
            switch (deskQuote.Desk.Material)
            {
                case Desk.DesktopMaterial.Laminate:
                    comSurfaceMaterial.SelectedIndex = 0;
                    break;

                case Desk.DesktopMaterial.Oak:
                    comSurfaceMaterial.SelectedIndex = 1;
                    break;

                case Desk.DesktopMaterial.Pine:
                    comSurfaceMaterial.SelectedIndex = 2;
                    break;

                case Desk.DesktopMaterial.Rosewood:
                    comSurfaceMaterial.SelectedIndex = 3;
                    break;

                case Desk.DesktopMaterial.Veneer:
                    comSurfaceMaterial.SelectedIndex = 4;
                    break;
            }
            */
            /*
            switch (deskQuote.DeliveryType)
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
            */

            txtPriceQuote.Text = deskQuote.QuotePrice.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
