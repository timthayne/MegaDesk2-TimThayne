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
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            // assign private variables
            _mainMenu = mainMenu;

            // set default state
            comboSurfaceMaterial.SelectedIndex = 0;
            loadGrid();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void comboSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex == 0)
            {
                // reset grid
                loadGrid();
            }
            else
            {
                // search grid
                loadGrid(combo.SelectedItem.ToString());
            }
        }

        private void loadGrid()
        {
            dataGridView1.Rows.Clear();

            string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

            foreach (string deskQuote in deskQuotes)
            {
                string[] arrRow = deskQuote.Split(new char[] { ',' });
                dataGridView1.Rows.Add(arrRow);
            }
        }

        private void loadGrid(string searchTerm)
        {
            dataGridView1.Rows.Clear();

            string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

            foreach (string deskQuote in deskQuotes)
            {
                if (deskQuote.Contains(searchTerm))
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    dataGridView1.Rows.Add(arrRow);
                }
            }
        }
    }
}
