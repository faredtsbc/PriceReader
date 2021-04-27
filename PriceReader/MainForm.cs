using PriceReader.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Threading;

namespace PriceReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    db.BARCODE.Any();
                }
                lblItemName.Text = "يرجى اجراء مسح الباركود لمنتج لعرض السعر";
            }
           catch (Exception ex)
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات");
            }
            txtbxBarcode.Width = 0;
            txtbxBarcode.Height = 0;
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void GetItemDetails()
        {
            string displayId = ConfigurationManager.AppSettings.Get("displayId");
            try
            {
                using (Context db = new Context())
                {
                    var item =  await db.BARCODE.FirstOrDefaultAsync(x => x.BARCODE == txtbxBarcode.Text.Trim());
                    if (item != null)
                    {
                        lblItemName.Text = db.ITEMS.Find(item.ITEM_ID).ITEM_NAME;
                        var itemDetails = await (from b in db.BARCODE
                                           join u in db.UNITS
                                           on b.UNIT_ID equals u.UNIT_ID
                                           where b.ITEM_ID == item.ITEM_ID
                                           select new
                                           {
                                               UnitDescription = u.UNIT_DISC,
                                               UnitQty = b.UNIT_QTY,
                                               UnitPrice = b.PRICE1

                                           }).OrderBy(x => x.UnitPrice).ToListAsync();

                        
                        dgvUnitsPrices.ColumnHeadersVisible = true;
                        if (displayId == "1")
                            dgvUnitsPrices.DataSource = itemDetails.Take(1).ToList();
                        if (displayId == "2")
                            dgvUnitsPrices.DataSource = itemDetails.OrderByDescending(x=>x.UnitPrice).Take(1).ToList();
                        if (displayId == "0")
                            dgvUnitsPrices.DataSource = itemDetails.Distinct().ToList();

                        foreach (DataGridViewColumn c in dgvUnitsPrices.Columns)
                        {
                            c.DefaultCellStyle.Font = new Font("Hacen Vanilla Ultra Light", 40F, GraphicsUnit.Pixel);
                        }
                        dgvUnitsPrices.Columns[0].HeaderText = "العبوة";
                        dgvUnitsPrices.Columns[0].Width = (int)(dgvUnitsPrices.Width * 0.2);
                        dgvUnitsPrices.Columns[0].HeaderCell.Style.Font = new Font("Hacen Vanilla Ultra Light", 20F, FontStyle.Italic);
                        dgvUnitsPrices.Columns[1].HeaderText = " الكمية بالعبوة";
                        dgvUnitsPrices.Columns[1].Width = (int)(dgvUnitsPrices.Width * 0.15);
                        dgvUnitsPrices.Columns[1].HeaderCell.Style.Font = new Font("Hacen Vanilla Ultra Light", 20F, FontStyle.Italic);
                        dgvUnitsPrices.Columns[2].HeaderText = "السعر";
                        dgvUnitsPrices.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvUnitsPrices.Columns[2].HeaderCell.Style.Font = new Font("Hacen Vanilla Ultra Light", 20F, FontStyle.Italic);
                        dgvUnitsPrices.CurrentCell.Selected = false;
                    }
                    else
                    {
                        lblItemName.Text = "لم يتم العثور على المنتج";
                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            
        }
        private void ClearScreen()
        {
            lblItemName.Text = "يرجى اجراء مسح الباركود لمنتج لعرض السعر";
            dgvUnitsPrices.ColumnHeadersVisible = false;
            dgvUnitsPrices.DataSource = null;
        }
        private async void txtbxBarcode_TextChanged(object sender, EventArgs e)
        {
            ClearScreen();
            
            
            if (txtbxBarcode.Text.Trim().Length == 13)
            {
                
                var tokenSource = new CancellationTokenSource();
                GetItemDetails();
                txtbxBarcode.Clear();
                await DelayView(tokenSource);
                ClearScreen();
                
                
            }          

        }

        private async Task DelayView(CancellationTokenSource tokenSource)
        {
            try
            {
                await Task.Delay(TimeSpan.FromSeconds(10), tokenSource.Token);
            }
            finally
            {
                tokenSource.Cancel();
                tokenSource.Dispose();
            }
            
        }
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void اعداداتالخادمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string password = Interaction.InputBox("كلمة المرور؟", " ", "", 300, 300).Trim();
            if (password == "Start052016")
            {
                SettingsForm settingFrm = new SettingsForm();
                settingFrm.ShowDialog();
            }
        }

        private void dgvUnitsPrices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
