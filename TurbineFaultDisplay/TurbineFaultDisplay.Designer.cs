namespace TurbineFaultDisplay
{
    partial class TurbineFaultDisplay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbShowZeros = new System.Windows.Forms.CheckBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTurbines = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOptions
            // 
            this.menuOptions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuOptions.Size = new System.Drawing.Size(800, 24);
            this.menuOptions.TabIndex = 0;
            this.menuOptions.Text = "Options";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(706, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // cbShowZeros
            // 
            this.cbShowZeros.AutoSize = true;
            this.cbShowZeros.Location = new System.Drawing.Point(82, 32);
            this.cbShowZeros.Name = "cbShowZeros";
            this.cbShowZeros.Size = new System.Drawing.Size(116, 19);
            this.cbShowZeros.TabIndex = 2;
            this.cbShowZeros.Text = "Show Zero Faults";
            this.cbShowZeros.UseVisualStyleBackColor = true;
            this.cbShowZeros.CheckedChanged += new System.EventHandler(this.cbShowZeros_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(343, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(445, 23);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // cbTurbines
            // 
            this.cbTurbines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTurbines.CheckOnClick = true;
            this.cbTurbines.FormattingEnabled = true;
            this.cbTurbines.Items.AddRange(new object[] {
            "A01",
            "A02",
            "A03",
            "A04",
            "A05",
            "A06",
            "A07"});
            this.cbTurbines.Location = new System.Drawing.Point(13, 55);
            this.cbTurbines.Name = "cbTurbines";
            this.cbTurbines.Size = new System.Drawing.Size(63, 364);
            this.cbTurbines.Sorted = true;
            this.cbTurbines.TabIndex = 5;
            this.cbTurbines.ThreeDCheckBoxes = true;
            this.cbTurbines.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbTurbines_ItemCheck);
            this.cbTurbines.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbTurbines_MouseUp);
            // 
            // TurbineFaultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTurbines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbShowZeros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuOptions);
            this.MainMenuStrip = this.menuOptions;
            this.Name = "TurbineFaultDisplay";
            this.Text = "Turbine Faults";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbShowZeros;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cbTurbines;
    }
}

