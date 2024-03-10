namespace ExamWinForms
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
            productView = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            txtCount = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)productView).BeginInit();
            SuspendLayout();
            // 
            // productView
            // 
            productView.AllowUserToAddRows = false;
            productView.AllowUserToDeleteRows = false;
            productView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productView.Location = new Point(12, 41);
            productView.Margin = new Padding(3, 3, 3, 100);
            productView.Name = "productView";
            productView.ReadOnly = true;
            productView.Size = new Size(365, 397);
            productView.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(510, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(238, 36);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(627, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(510, 162);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 36);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(534, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(214, 23);
            txtID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(600, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 23);
            txtName.TabIndex = 7;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(556, 104);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(192, 23);
            txtCount.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(549, 133);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(199, 23);
            txtPrice.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 49);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 78);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 11;
            label2.Text = "Name product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 107);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 136);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 13;
            label4.Text = "Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtCount);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(productView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)productView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productView;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtCount;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
