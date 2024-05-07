namespace ParkingManagementSystem
{
    partial class Cars
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
            label5 = new Label();
            pntabl = new TextBox();
            ctbl = new TextBox();
            cttbl = new TextBox();
            dtbl = new TextBox();
            gcb = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ubtn = new Button();
            dbtn = new Button();
            sbtn = new Button();
            CarDGV = new DataGridView();
            label1 = new Label();
            searchtbl = new TextBox();
            label2 = new Label();
            resetbtn = new Button();
            Restore = new Button();
            ((System.ComponentModel.ISupportInitialize)CarDGV).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(96, 50);
            label5.Name = "label5";
            label5.Size = new Size(175, 31);
            label5.TabIndex = 1;
            label5.Text = "Parking Lot 1.0";
            // 
            // pntabl
            // 
            pntabl.Location = new Point(230, 201);
            pntabl.Name = "pntabl";
            pntabl.Size = new Size(207, 31);
            pntabl.TabIndex = 1;
            // 
            // ctbl
            // 
            ctbl.Location = new Point(557, 198);
            ctbl.Name = "ctbl";
            ctbl.Size = new Size(270, 31);
            ctbl.TabIndex = 6;
            // 
            // cttbl
            // 
            cttbl.Location = new Point(230, 140);
            cttbl.Name = "cttbl";
            cttbl.Size = new Size(207, 31);
            cttbl.TabIndex = 0;
            // 
            // dtbl
            // 
            dtbl.Location = new Point(557, 137);
            dtbl.Name = "dtbl";
            dtbl.Size = new Size(270, 31);
            dtbl.TabIndex = 8;
            // 
            // gcb
            // 
            gcb.FormattingEnabled = true;
            gcb.Items.AddRange(new object[] { "Male", "Female" });
            gcb.Location = new Point(880, 134);
            gcb.Name = "gcb";
            gcb.Size = new Size(158, 33);
            gcb.TabIndex = 9;
            gcb.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(96, 203);
            label7.Name = "label7";
            label7.Size = new Size(132, 28);
            label7.TabIndex = 17;
            label7.Text = "Plate Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(490, 139);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 18;
            label8.Text = "Driver";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(140, 142);
            label9.Name = "label9";
            label9.Size = new Size(87, 28);
            label9.TabIndex = 19;
            label9.Text = "Car Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(494, 200);
            label10.Name = "label10";
            label10.Size = new Size(60, 28);
            label10.TabIndex = 20;
            label10.Text = "Color";
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
            ubtn.Location = new Point(397, 277);
            ubtn.Name = "ubtn";
            ubtn.Size = new Size(158, 41);
            ubtn.TabIndex = 22;
            ubtn.Text = "Update Car";
            ubtn.UseVisualStyleBackColor = false;
            ubtn.Click += ubtn_Click;
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
            dbtn.Location = new Point(613, 277);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(158, 41);
            dbtn.TabIndex = 23;
            dbtn.Text = "Delete Car";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
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
            sbtn.Location = new Point(202, 277);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(158, 41);
            sbtn.TabIndex = 24;
            sbtn.Text = "Save Car";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click;
            // 
            // CarDGV
            // 
            CarDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CarDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDGV.Location = new Point(12, 400);
            CarDGV.Name = "CarDGV";
            CarDGV.RowHeadersWidth = 51;
            CarDGV.Size = new Size(1114, 244);
            CarDGV.TabIndex = 25;
            CarDGV.CellContentClick += CarDGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(263, 364);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 27;
            label1.Text = "Search by All Types";
            // 
            // searchtbl
            // 
            searchtbl.Location = new Point(445, 363);
            searchtbl.Name = "searchtbl";
            searchtbl.Size = new Size(365, 31);
            searchtbl.TabIndex = 26;
            searchtbl.TextChanged += searchtbl_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 362);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 28;
            label2.Text = "Cars List";
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
            resetbtn.Location = new Point(821, 277);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(158, 41);
            resetbtn.TabIndex = 29;
            resetbtn.Text = "Reset Car";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // Restore
            // 
            Restore.BackColor = Color.White;
            Restore.FlatAppearance.BorderSize = 0;
            Restore.FlatAppearance.MouseDownBackColor = Color.Cyan;
            Restore.FlatAppearance.MouseOverBackColor = Color.Cyan;
            Restore.FlatStyle = FlatStyle.Flat;
            Restore.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Restore.Location = new Point(821, 360);
            Restore.Name = "Restore";
            Restore.Size = new Size(158, 34);
            Restore.TabIndex = 30;
            Restore.Text = "Restore Filter";
            Restore.UseVisualStyleBackColor = false;
            Restore.Click += Restore_Click;
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1138, 656);
            ControlBox = false;
            Controls.Add(Restore);
            Controls.Add(resetbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchtbl);
            Controls.Add(CarDGV);
            Controls.Add(sbtn);
            Controls.Add(dbtn);
            Controls.Add(ubtn);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(gcb);
            Controls.Add(dtbl);
            Controls.Add(cttbl);
            Controls.Add(ctbl);
            Controls.Add(pntabl);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Cars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)CarDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox pntabl;
        private TextBox ctbl;
        private TextBox cttbl;
        private TextBox dtbl;
        private ComboBox gcb;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button ubtn;
        private Button dbtn;
        private Button sbtn;
        private DataGridView CarDGV;
        private Label label1;
        private TextBox searchtbl;
        private Label label2;
        private Button resetbtn;
        private Button Restore;
    }
}