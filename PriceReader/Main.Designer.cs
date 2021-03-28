
namespace PriceReader
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUnitsPrices = new System.Windows.Forms.DataGridView();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtbxBarcode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUnitsPrices);
            this.panel1.Controls.Add(this.lblItemName);
            this.panel1.Controls.Add(this.txtbxBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 603);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvUnitsPrices
            // 
            this.dgvUnitsPrices.AllowUserToAddRows = false;
            this.dgvUnitsPrices.AllowUserToDeleteRows = false;
            this.dgvUnitsPrices.AllowUserToResizeColumns = false;
            this.dgvUnitsPrices.AllowUserToResizeRows = false;
            this.dgvUnitsPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitsPrices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUnitsPrices.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvUnitsPrices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnitsPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitsPrices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUnitsPrices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUnitsPrices.Enabled = false;
            this.dgvUnitsPrices.Location = new System.Drawing.Point(0, 333);
            this.dgvUnitsPrices.Name = "dgvUnitsPrices";
            this.dgvUnitsPrices.ReadOnly = true;
            this.dgvUnitsPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnitsPrices.ShowCellErrors = false;
            this.dgvUnitsPrices.ShowCellToolTips = false;
            this.dgvUnitsPrices.ShowEditingIcon = false;
            this.dgvUnitsPrices.ShowRowErrors = false;
            this.dgvUnitsPrices.Size = new System.Drawing.Size(1180, 270);
            this.dgvUnitsPrices.TabIndex = 5;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arabic Typesetting", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblItemName.Location = new System.Drawing.Point(724, 139);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(239, 79);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item name";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxBarcode
            // 
            this.txtbxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxBarcode.Location = new System.Drawing.Point(857, 12);
            this.txtbxBarcode.Name = "txtbxBarcode";
            this.txtbxBarcode.Size = new System.Drawing.Size(272, 24);
            this.txtbxBarcode.TabIndex = 3;
            this.txtbxBarcode.TextChanged += new System.EventHandler(this.txtbxBarcode_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1180, 603);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsPrices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbxBarcode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.DataGridView dgvUnitsPrices;
    }
}

