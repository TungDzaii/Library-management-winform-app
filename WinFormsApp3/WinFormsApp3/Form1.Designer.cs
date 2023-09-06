namespace WinFormsApp3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtBookName = new TextBox();
            txtAuthorName = new TextBox();
            txtDate = new TextBox();
            txtCategory = new TextBox();
            btnExit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtPrice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            txtQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 22;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 14);
            label2.TabIndex = 21;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 14);
            label3.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(789, 151);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(852, 38);
            txtBookName.Margin = new Padding(2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(106, 23);
            txtBookName.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(852, 70);
            txtAuthorName.Margin = new Padding(2);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(106, 23);
            txtAuthorName.TabIndex = 6;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(852, 110);
            txtDate.Margin = new Padding(2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(106, 23);
            txtDate.TabIndex = 7;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(852, 148);
            txtCategory.Margin = new Padding(2);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(106, 23);
            txtCategory.TabIndex = 8;
            txtCategory.TextChanged += txtCategory_TextChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveBorder;
            btnExit.Location = new Point(939, 279);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(68, 37);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(571, 279);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 37);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(908, 11);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(662, 279);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(67, 37);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(757, 279);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 37);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(852, 182);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(106, 23);
            txtPrice.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(775, 41);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 24;
            label5.Text = "Book Name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(766, 73);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 25;
            label6.Text = "Author Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(741, 113);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 26;
            label7.Text = "Date of Publishing";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(811, 185);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 27;
            label8.Text = "Price";
            label8.Click += label8_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(725, 11);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 23);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 11);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(696, 182);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(792, 221);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 31;
            label9.Text = "Quantity";
            label9.Click += label9_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(852, 218);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(106, 23);
            txtQuantity.TabIndex = 30;
            txtQuantity.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 327);
            Controls.Add(label9);
            Controls.Add(txtQuantity);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(txtCategory);
            Controls.Add(txtDate);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Thanh Tri Library";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBookName;
        private TextBox txtAuthorName;
        private TextBox txtDate;
        private TextBox txtCategory;
        private Button btnExit;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtPrice;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox txtQuantity;
    }
}