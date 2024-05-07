namespace ParkingManagementSystem
{
    partial class Places
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
            sbtn = new Button();
            dbtn = new Button();
            ubtn = new Button();
            label9 = new Label();
            scb = new ComboBox();
            ptbl = new TextBox();
            label5 = new Label();
            Restore = new Button();
            resetbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            searchtbl = new TextBox();
            PlaceDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PlaceDGV).BeginInit();
            SuspendLayout();
            // 
            // sbtn
            // 
            sbtn.BackColor = Color.White;
            sbtn.Cursor = Cursors.Hand;
            sbtn.FlatAppearance.BorderSize = 0;
            sbtn.FlatAppearance.MouseDownBackColor = Color.Lime;
            sbtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            sbtn.FlatStyle = FlatStyle.Flat;
            sbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            sbtn.Location = new Point(167, 219);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(158, 41);
            sbtn.TabIndex = 37;
            sbtn.Text = "Save Car";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click_1;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.White;
            dbtn.Cursor = Cursors.Hand;
            dbtn.FlatAppearance.BorderSize = 0;
            dbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            dbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            dbtn.FlatStyle = FlatStyle.Flat;
            dbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dbtn.Location = new Point(603, 219);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(158, 41);
            dbtn.TabIndex = 36;
            dbtn.Text = "Delete Car";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
            // 
            // ubtn
            // 
            ubtn.BackColor = Color.White;
            ubtn.Cursor = Cursors.Hand;
            ubtn.FlatAppearance.BorderSize = 0;
            ubtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            ubtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            ubtn.FlatStyle = FlatStyle.Flat;
            ubtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            ubtn.Location = new Point(378, 219);
            ubtn.Name = "ubtn";
            ubtn.Size = new Size(158, 41);
            ubtn.TabIndex = 35;
            ubtn.Text = "Update Car";
            ubtn.UseVisualStyleBackColor = false;
            ubtn.Click += ubtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(227, 135);
            label9.Name = "label9";
            label9.Size = new Size(82, 28);
            label9.TabIndex = 33;
            label9.Text = "Position";
            // 
            // scb
            // 
            scb.FormattingEnabled = true;
            scb.Items.AddRange(new object[] { "Booked", "Free", "Maintenance" });
            scb.Location = new Point(672, 130);
            scb.Name = "scb";
            scb.Size = new Size(184, 33);
            scb.TabIndex = 30;
            scb.Text = "Status";
            // 
            // ptbl
            // 
            ptbl.Location = new Point(312, 133);
            ptbl.Name = "ptbl";
            ptbl.Size = new Size(243, 31);
            ptbl.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(92, 33);
            label5.Name = "label5";
            label5.Size = new Size(175, 31);
            label5.TabIndex = 25;
            label5.Text = "Parking Lot 1.0";
            // 
            // Restore
            // 
            Restore.BackColor = Color.White;
            Restore.FlatAppearance.BorderSize = 0;
            Restore.FlatAppearance.MouseDownBackColor = Color.Cyan;
            Restore.FlatAppearance.MouseOverBackColor = Color.Cyan;
            Restore.FlatStyle = FlatStyle.Flat;
            Restore.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Restore.Location = new Point(821, 334);
            Restore.Name = "Restore";
            Restore.Size = new Size(158, 34);
            Restore.TabIndex = 43;
            Restore.Text = "Restore Filter";
            Restore.UseVisualStyleBackColor = false;
            Restore.Click += Restore_Click_1;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.White;
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatAppearance.MouseDownBackColor = Color.Cyan;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            resetbtn.Location = new Point(823, 219);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(158, 41);
            resetbtn.TabIndex = 42;
            resetbtn.Text = "Reset Car";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 336);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 41;
            label2.Text = "Places List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(263, 338);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 40;
            label1.Text = "Search by All Types";
            // 
            // searchtbl
            // 
            searchtbl.Location = new Point(445, 337);
            searchtbl.Name = "searchtbl";
            searchtbl.Size = new Size(365, 31);
            searchtbl.TabIndex = 39;
            searchtbl.TextChanged += searchtbl_TextChanged_1;
            // 
            // PlaceDGV
            // 
            PlaceDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PlaceDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PlaceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlaceDGV.Location = new Point(12, 374);
            PlaceDGV.Name = "PlaceDGV";
            PlaceDGV.RowHeadersWidth = 51;
            PlaceDGV.Size = new Size(1114, 270);
            PlaceDGV.TabIndex = 38;
            PlaceDGV.CellContentClick += PlaceDGV_CellContentClick;
            // 
            // Places
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 656);
            ControlBox = false;
            Controls.Add(Restore);
            Controls.Add(resetbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchtbl);
            Controls.Add(PlaceDGV);
            Controls.Add(sbtn);
            Controls.Add(dbtn);
            Controls.Add(ubtn);
            Controls.Add(label9);
            Controls.Add(scb);
            Controls.Add(ptbl);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Places";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Places";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)PlaceDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sbtn;
        private Button dbtn;
        private Button ubtn;
        private Label label9;
        private ComboBox scb;
        private TextBox ptbl;
        private Label label5;
        private Button Restore;
        private Button resetbtn;
        private Label label2;
        private Label label1;
        private TextBox searchtbl;
        private DataGridView PlaceDGV;
    }
}