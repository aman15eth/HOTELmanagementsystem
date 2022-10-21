namespace hospital_mangement_system.add_user_control
{
    partial class UserControl2
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.roomNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tex_mobile = new System.Windows.Forms.TextBox();
            this.text_naition = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.date_dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.allote_room = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txt_bed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_roomtyoe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.price = new System.Windows.Forms.Label();
            this.bed = new System.Windows.Forms.Label();
            this.roomtype = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaroomnum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "customer registration ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roomNo
            // 
            this.roomNo.AutoSize = true;
            this.roomNo.Location = new System.Drawing.Point(104, 81);
            this.roomNo.Name = "roomNo";
            this.roomNo.Size = new System.Drawing.Size(35, 13);
            this.roomNo.TabIndex = 3;
            this.roomNo.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "mobile number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "nationality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "date of birth";
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(79, 111);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(200, 20);
            this.tex_name.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tex_mobile
            // 
            this.tex_mobile.Location = new System.Drawing.Point(79, 177);
            this.tex_mobile.Name = "tex_mobile";
            this.tex_mobile.Size = new System.Drawing.Size(200, 20);
            this.tex_mobile.TabIndex = 10;
            // 
            // text_naition
            // 
            this.text_naition.Location = new System.Drawing.Point(79, 233);
            this.text_naition.Name = "text_naition";
            this.text_naition.Size = new System.Drawing.Size(200, 20);
            this.text_naition.TabIndex = 11;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gender.Location = new System.Drawing.Point(79, 291);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(200, 21);
            this.gender.TabIndex = 12;
            // 
            // date_dob
            // 
            this.date_dob.CheckedState.Parent = this.date_dob;
            this.date_dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_dob.HoverState.Parent = this.date_dob;
            this.date_dob.Location = new System.Drawing.Point(79, 345);
            this.date_dob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_dob.Name = "date_dob";
            this.date_dob.ShadowDecoration.Parent = this.date_dob;
            this.date_dob.Size = new System.Drawing.Size(200, 36);
            this.date_dob.TabIndex = 13;
            this.date_dob.Value = new System.DateTime(2022, 10, 20, 12, 18, 57, 191);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "id proof";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(418, 111);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(200, 20);
            this.txt_id.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adress";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(418, 197);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(200, 20);
            this.txt_adress.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Check in";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(418, 266);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker2.TabIndex = 19;
            this.guna2DateTimePicker2.Value = new System.DateTime(2022, 10, 20, 12, 18, 57, 191);
            // 
            // allote_room
            // 
            this.allote_room.BorderRadius = 32;
            this.allote_room.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.allote_room.BorderThickness = 1;
            this.allote_room.CheckedState.Parent = this.allote_room;
            this.allote_room.CustomImages.Parent = this.allote_room;
            this.allote_room.FillColor = System.Drawing.Color.IndianRed;
            this.allote_room.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.allote_room.ForeColor = System.Drawing.Color.White;
            this.allote_room.HoverState.Parent = this.allote_room;
            this.allote_room.Location = new System.Drawing.Point(596, 370);
            this.allote_room.Name = "allote_room";
            this.allote_room.ShadowDecoration.Parent = this.allote_room;
            this.allote_room.Size = new System.Drawing.Size(180, 45);
            this.allote_room.TabIndex = 20;
            this.allote_room.Text = "Allote Room";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(717, 323);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(49, 8);
            this.guna2Button2.TabIndex = 21;
            this.guna2Button2.Text = "guna2Button2";
            // 
            // txt_bed
            // 
            this.txt_bed.BackColor = System.Drawing.Color.Transparent;
            this.txt_bed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bed.FocusedState.Parent = this.txt_bed;
            this.txt_bed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_bed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_bed.HoverState.Parent = this.txt_bed;
            this.txt_bed.ItemHeight = 30;
            this.txt_bed.Items.AddRange(new object[] {
            "Four-poster bed",
            "Platform bed",
            "Box bed",
            "Bunk bed",
            "Canopy bed",
            "Floor bed"});
            this.txt_bed.ItemsAppearance.Parent = this.txt_bed;
            this.txt_bed.Location = new System.Drawing.Point(624, 167);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.ShadowDecoration.Parent = this.txt_bed;
            this.txt_bed.Size = new System.Drawing.Size(302, 36);
            this.txt_bed.TabIndex = 29;
            this.txt_bed.SelectedIndexChanged += new System.EventHandler(this.txt_bed_SelectedIndexChanged);
            // 
            // txt_roomtyoe
            // 
            this.txt_roomtyoe.BackColor = System.Drawing.Color.Transparent;
            this.txt_roomtyoe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_roomtyoe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_roomtyoe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomtyoe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomtyoe.FocusedState.Parent = this.txt_roomtyoe;
            this.txt_roomtyoe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_roomtyoe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_roomtyoe.HoverState.Parent = this.txt_roomtyoe;
            this.txt_roomtyoe.ItemHeight = 30;
            this.txt_roomtyoe.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txt_roomtyoe.ItemsAppearance.Parent = this.txt_roomtyoe;
            this.txt_roomtyoe.Location = new System.Drawing.Point(624, 86);
            this.txt_roomtyoe.Name = "txt_roomtyoe";
            this.txt_roomtyoe.ShadowDecoration.Parent = this.txt_roomtyoe;
            this.txt_roomtyoe.Size = new System.Drawing.Size(302, 36);
            this.txt_roomtyoe.TabIndex = 28;
            this.txt_roomtyoe.SelectedIndexChanged += new System.EventHandler(this.txt_roomtyoe_SelectedIndexChanged);
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.Parent = this.txt_price;
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.FocusedState.Parent = this.txt_price;
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.HoverState.Parent = this.txt_price;
            this.txt_price.Location = new System.Drawing.Point(624, 281);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "Price";
            this.txt_price.SelectedText = "";
            this.txt_price.ShadowDecoration.Parent = this.txt_price;
            this.txt_price.Size = new System.Drawing.Size(302, 36);
            this.txt_price.TabIndex = 27;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(702, 265);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 25;
            this.price.Text = "Price";
            // 
            // bed
            // 
            this.bed.AutoSize = true;
            this.bed.Location = new System.Drawing.Point(714, 135);
            this.bed.Name = "bed";
            this.bed.Size = new System.Drawing.Size(25, 13);
            this.bed.TabIndex = 24;
            this.bed.Text = "bed";
            // 
            // roomtype
            // 
            this.roomtype.AutoSize = true;
            this.roomtype.Location = new System.Drawing.Point(702, 68);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(62, 13);
            this.roomtype.TabIndex = 23;
            this.roomtype.Text = "Room Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(724, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Room Number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // gunaroomnum
            // 
            this.gunaroomnum.BackColor = System.Drawing.Color.Transparent;
            this.gunaroomnum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaroomnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaroomnum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaroomnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaroomnum.FocusedState.Parent = this.gunaroomnum;
            this.gunaroomnum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaroomnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gunaroomnum.HoverState.Parent = this.gunaroomnum;
            this.gunaroomnum.ItemHeight = 30;
            this.gunaroomnum.ItemsAppearance.Parent = this.gunaroomnum;
            this.gunaroomnum.Location = new System.Drawing.Point(624, 226);
            this.gunaroomnum.Name = "gunaroomnum";
            this.gunaroomnum.ShadowDecoration.Parent = this.gunaroomnum;
            this.gunaroomnum.Size = new System.Drawing.Size(302, 36);
            this.gunaroomnum.TabIndex = 30;
            this.gunaroomnum.SelectedIndexChanged += new System.EventHandler(this.gunaroomnum_SelectedIndexChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.gunaroomnum);
            this.Controls.Add(this.txt_bed);
            this.Controls.Add(this.txt_roomtyoe);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.price);
            this.Controls.Add(this.bed);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.allote_room);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_dob);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.text_naition);
            this.Controls.Add(this.tex_mobile);
            this.Controls.Add(this.tex_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomNo);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(945, 418);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roomNo;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button allote_room;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_dob;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox text_naition;
        private System.Windows.Forms.TextBox tex_mobile;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ComboBox txt_bed;
        private Guna.UI2.WinForms.Guna2ComboBox txt_roomtyoe;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label bed;
        private System.Windows.Forms.Label roomtype;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox gunaroomnum;
    }
}
