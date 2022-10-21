namespace hospital_mangement_system.add_user_control
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.roomNo = new System.Windows.Forms.Label();
            this.roomtype = new System.Windows.Forms.Label();
            this.bed = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.guna2TextBox1_roonnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1_roomtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2_bed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1_addroom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.roomTableAdapter1 = new hospital_mangement_system.HotelDataSetTableAdapters.roomTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(34, 91);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(404, 263);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "add new room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roomNo
            // 
            this.roomNo.AutoSize = true;
            this.roomNo.Location = new System.Drawing.Point(495, 91);
            this.roomNo.Name = "roomNo";
            this.roomNo.Size = new System.Drawing.Size(75, 13);
            this.roomNo.TabIndex = 2;
            this.roomNo.Text = "Room Number";
            // 
            // roomtype
            // 
            this.roomtype.AutoSize = true;
            this.roomtype.Location = new System.Drawing.Point(508, 169);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(62, 13);
            this.roomtype.TabIndex = 3;
            this.roomtype.Text = "Room Type";
            // 
            // bed
            // 
            this.bed.AutoSize = true;
            this.bed.Location = new System.Drawing.Point(528, 245);
            this.bed.Name = "bed";
            this.bed.Size = new System.Drawing.Size(25, 13);
            this.bed.TabIndex = 4;
            this.bed.Text = "bed";
            this.bed.Click += new System.EventHandler(this.bed_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(522, 309);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 5;
            this.price.Text = "Price";
            // 
            // guna2TextBox1_roonnumber
            // 
            this.guna2TextBox1_roonnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1_roonnumber.DefaultText = "";
            this.guna2TextBox1_roonnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1_roonnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1_roonnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1_roonnumber.DisabledState.Parent = this.guna2TextBox1_roonnumber;
            this.guna2TextBox1_roonnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1_roonnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1_roonnumber.FocusedState.Parent = this.guna2TextBox1_roonnumber;
            this.guna2TextBox1_roonnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1_roonnumber.HoverState.Parent = this.guna2TextBox1_roonnumber;
            this.guna2TextBox1_roonnumber.Location = new System.Drawing.Point(444, 118);
            this.guna2TextBox1_roonnumber.Name = "guna2TextBox1_roonnumber";
            this.guna2TextBox1_roonnumber.PasswordChar = '\0';
            this.guna2TextBox1_roonnumber.PlaceholderText = "Room Nmber";
            this.guna2TextBox1_roonnumber.SelectedText = "";
            this.guna2TextBox1_roonnumber.ShadowDecoration.Parent = this.guna2TextBox1_roonnumber;
            this.guna2TextBox1_roonnumber.Size = new System.Drawing.Size(302, 36);
            this.guna2TextBox1_roonnumber.TabIndex = 6;
            this.guna2TextBox1_roonnumber.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2TextBox4_price
            // 
            this.guna2TextBox4_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4_price.DefaultText = "";
            this.guna2TextBox4_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4_price.DisabledState.Parent = this.guna2TextBox4_price;
            this.guna2TextBox4_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4_price.FocusedState.Parent = this.guna2TextBox4_price;
            this.guna2TextBox4_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4_price.HoverState.Parent = this.guna2TextBox4_price;
            this.guna2TextBox4_price.Location = new System.Drawing.Point(444, 325);
            this.guna2TextBox4_price.Name = "guna2TextBox4_price";
            this.guna2TextBox4_price.PasswordChar = '\0';
            this.guna2TextBox4_price.PlaceholderText = "Price";
            this.guna2TextBox4_price.SelectedText = "";
            this.guna2TextBox4_price.ShadowDecoration.Parent = this.guna2TextBox4_price;
            this.guna2TextBox4_price.Size = new System.Drawing.Size(302, 36);
            this.guna2TextBox4_price.TabIndex = 9;
            // 
            // guna2ComboBox1_roomtype
            // 
            this.guna2ComboBox1_roomtype.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1_roomtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1_roomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1_roomtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1_roomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1_roomtype.FocusedState.Parent = this.guna2ComboBox1_roomtype;
            this.guna2ComboBox1_roomtype.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2ComboBox1_roomtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1_roomtype.HoverState.Parent = this.guna2ComboBox1_roomtype;
            this.guna2ComboBox1_roomtype.ItemHeight = 30;
            this.guna2ComboBox1_roomtype.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.guna2ComboBox1_roomtype.ItemsAppearance.Parent = this.guna2ComboBox1_roomtype;
            this.guna2ComboBox1_roomtype.Location = new System.Drawing.Point(444, 195);
            this.guna2ComboBox1_roomtype.Name = "guna2ComboBox1_roomtype";
            this.guna2ComboBox1_roomtype.ShadowDecoration.Parent = this.guna2ComboBox1_roomtype;
            this.guna2ComboBox1_roomtype.Size = new System.Drawing.Size(302, 36);
            this.guna2ComboBox1_roomtype.TabIndex = 10;
            this.guna2ComboBox1_roomtype.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_roomtype_SelectedIndexChanged);
            // 
            // guna2ComboBox2_bed
            // 
            this.guna2ComboBox2_bed.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2_bed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2_bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2_bed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2_bed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2_bed.FocusedState.Parent = this.guna2ComboBox2_bed;
            this.guna2ComboBox2_bed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2_bed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2_bed.HoverState.Parent = this.guna2ComboBox2_bed;
            this.guna2ComboBox2_bed.ItemHeight = 30;
            this.guna2ComboBox2_bed.Items.AddRange(new object[] {
            "Four-poster bed",
            "Platform bed",
            "Box bed",
            "Bunk bed",
            "Canopy bed",
            "Floor bed"});
            this.guna2ComboBox2_bed.ItemsAppearance.Parent = this.guna2ComboBox2_bed;
            this.guna2ComboBox2_bed.Location = new System.Drawing.Point(444, 261);
            this.guna2ComboBox2_bed.Name = "guna2ComboBox2_bed";
            this.guna2ComboBox2_bed.ShadowDecoration.Parent = this.guna2ComboBox2_bed;
            this.guna2ComboBox2_bed.Size = new System.Drawing.Size(302, 36);
            this.guna2ComboBox2_bed.TabIndex = 11;
            this.guna2ComboBox2_bed.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_bed_SelectedIndexChanged);
            // 
            // guna2Button1_addroom
            // 
            this.guna2Button1_addroom.BorderRadius = 20;
            this.guna2Button1_addroom.CheckedState.Parent = this.guna2Button1_addroom;
            this.guna2Button1_addroom.CustomImages.Parent = this.guna2Button1_addroom;
            this.guna2Button1_addroom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1_addroom.ForeColor = System.Drawing.Color.White;
            this.guna2Button1_addroom.HoverState.Parent = this.guna2Button1_addroom;
            this.guna2Button1_addroom.Location = new System.Drawing.Point(752, 118);
            this.guna2Button1_addroom.Name = "guna2Button1_addroom";
            this.guna2Button1_addroom.ShadowDecoration.Parent = this.guna2Button1_addroom;
            this.guna2Button1_addroom.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1_addroom.TabIndex = 12;
            this.guna2Button1_addroom.Text = "Add Room";
            this.guna2Button1_addroom.Click += new System.EventHandler(this.guna2Button1_addroom_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "search room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2Button1_addroom);
            this.Controls.Add(this.guna2ComboBox2_bed);
            this.Controls.Add(this.guna2ComboBox1_roomtype);
            this.Controls.Add(this.guna2TextBox4_price);
            this.Controls.Add(this.guna2TextBox1_roonnumber);
            this.Controls.Add(this.price);
            this.Controls.Add(this.bed);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.roomNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(945, 418);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Enter += new System.EventHandler(this.UserControl1_Enter);
            this.Leave += new System.EventHandler(this.UserControl1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roomNo;
        private System.Windows.Forms.Label roomtype;
        private System.Windows.Forms.Label bed;
        private System.Windows.Forms.Label price;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1_roonnumber;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4_price;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1_roomtype;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2_bed;
        private Guna.UI2.WinForms.Guna2Button guna2Button1_addroom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private HotelDataSetTableAdapters.roomTableAdapter roomTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}
