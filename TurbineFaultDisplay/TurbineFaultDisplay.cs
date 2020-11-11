using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurbineFaultDisplay
{
    public partial class TurbineFaultDisplay : Form
    {
        private object[] rows;
        public TurbineFaultDisplay()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridView1.Columns[0].Name = "Turbine";
            dataGridView1.Columns[1].Name = "Fault Code";
            dataGridView1.Columns[2].Name = "Description";
            dataGridView1.Columns[3].Name = "Priority";

            // Populate the rows.
            string[] row1 = new string[] { "A01", "0", "", "0" };
            string[] row2 = new string[] { "A02", "562", "Voltage Drop Detected Warning", "10" };
            string[] row3 = new string[] { "A03", "574", "Converter Cooling Power Supply Error", "300" };
            string[] row4 = new string[] { "A04", "0", "", "0" };
            string[] row5 = new string[] { "A05", "0", "", "0" };
            string[] row6 = new string[] { "A06", "0", "", "0" };
            string[] row7 = new string[] { "A07", "577", "High Inverter Radiator Temperature Warning", "40" };
            string[] row8 = new string[] { "A08", "0", "", "0" };
            rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8 };

            // Resize the height of the column headers. 
            dataGridView1.AutoResizeColumnHeadersHeight();

            // Resize all the row heights to fit the contents of all non-header cells.
            dataGridView1.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            for (int turbine = 0; turbine < cbTurbines.Items.Count; turbine++)
                cbTurbines.SetItemChecked(turbine, true);
            updateTableView();
        }

        private void updateTableView()
        {
            dataGridView1.Rows.Clear();
            foreach (string[] rowArray in rows)
            {
                if (rowArray[1] != "0" || cbShowZeros.Checked == true)
                {
                    if (tbSearch.Text == "" || rowArray[0].ToLower().Contains(tbSearch.Text.ToLower()) || rowArray[1].ToLower().Contains(tbSearch.Text.ToLower()) || rowArray[2].ToLower().Contains(tbSearch.Text.ToLower()) || rowArray[3].ToLower().Contains(tbSearch.Text.ToLower()))
                    {
                        foreach (var cbTurbine in cbTurbines.CheckedItems)
                        {
                            if (rowArray[0].ToLower() == cbTurbine.ToString().ToLower())
                                dataGridView1.Rows.Add(rowArray);
                        }
                    }
                }

            }
        }

        private void cbShowZeros_CheckedChanged(object sender, EventArgs e)
        {
            updateTableView();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            updateTableView();
        }

        private void cbTurbines_MouseUp(object sender, MouseEventArgs e)
        {

            updateTableView();
        }

        private void cbTurbines_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            updateTableView();
        }
    }
}
