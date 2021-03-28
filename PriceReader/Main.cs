using PriceReader.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceReader
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblItemName.Text = "";
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbxBarcode_TextChanged(object sender, EventArgs e)
        {
            lblItemName.Text = "";
            dgvUnitsPrices.ColumnHeadersVisible = false;
            dgvUnitsPrices.DataSource = null;
            if (txtbxBarcode.Text != string.Empty)
            {
                using (Context db = new Context())
                {
                    var item = db.Barcodes.FirstOrDefault(x=>x.BARCODE==txtbxBarcode.Text.Trim());
                    if (item != null)
                    {
                        lblItemName.Text = db.Items.Find(item.ITEM_ID).ITEM_NAME;
                        var itemDetails = (from b in db.Barcodes
                                           join u in db.Units
                                           on b.UNIT_ID equals u.UNIT_ID
                                           where b.ITEM_ID == item.ITEM_ID
                                           select new
                                           {
                                               UnitDescription = u.UNIT_DISC,
                                               UnitQty = b.UNIT_QTY,
                                               UnitPrice = b.PRICE1

                                           });

                        dgvUnitsPrices.ColumnHeadersVisible = true;
                        dgvUnitsPrices.DataSource = itemDetails.ToList();
                        foreach (DataGridViewColumn c in dgvUnitsPrices.Columns)
                        {
                            c.DefaultCellStyle.Font = new Font("Arial", 30F, GraphicsUnit.Pixel);
                        }
                        dgvUnitsPrices.Columns[0].HeaderText = "العبوة";
                        dgvUnitsPrices.Columns[1].HeaderText = "الكمية";
                        dgvUnitsPrices.Columns[2].HeaderText = "السعر";
                        dgvUnitsPrices.CurrentCell.Selected = false;
                    }
                    else
                    {
                        lblItemName.Text = "لم يتم العثور على المنتج";
                    }
                }
            }
            
        }
    }
}
