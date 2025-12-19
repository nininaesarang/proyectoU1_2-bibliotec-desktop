
namespace proyectoU1_2
{
    partial class sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridSALES = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSELL = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDiscounts = new System.Windows.Forms.ComboBox();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSELL = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnREFRESH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSALES)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(969, 82);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridSALES
            // 
            this.dataGridSALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSALES.Location = new System.Drawing.Point(14, 140);
            this.dataGridSALES.Name = "dataGridSALES";
            this.dataGridSALES.RowHeadersWidth = 62;
            this.dataGridSALES.RowTemplate.Height = 28;
            this.dataGridSALES.Size = new System.Drawing.Size(595, 570);
            this.dataGridSALES.TabIndex = 12;
            this.dataGridSALES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSALES_CellContentClick);
            this.dataGridSALES.SelectionChanged += new System.EventHandler(this.dataGridSALES_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(462, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSELL
            // 
            this.btnSELL.Location = new System.Drawing.Point(638, 609);
            this.btnSELL.Name = "btnSELL";
            this.btnSELL.Size = new System.Drawing.Size(141, 35);
            this.btnSELL.TabIndex = 14;
            this.btnSELL.Text = "Sell";
            this.btnSELL.UseVisualStyleBackColor = true;
            this.btnSELL.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(259, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 26);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(166, 100);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 25);
            this.Search.TabIndex = 17;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(701, 158);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(212, 26);
            this.txtTitle.TabIndex = 18;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(701, 245);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(212, 26);
            this.txtType.TabIndex = 20;
            this.txtType.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(704, 292);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(212, 26);
            this.txtNotes.TabIndex = 21;
            this.txtNotes.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(701, 202);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(212, 26);
            this.txtAuthor.TabIndex = 22;
            this.txtAuthor.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPDate
            // 
            this.txtPDate.Location = new System.Drawing.Point(775, 331);
            this.txtPDate.Name = "txtPDate";
            this.txtPDate.Size = new System.Drawing.Size(138, 26);
            this.txtPDate.TabIndex = 23;
            this.txtPDate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Title:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Notes:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Author:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Publication Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Price:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Available discounts:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbDiscounts
            // 
            this.cmbDiscounts.FormattingEnabled = true;
            this.cmbDiscounts.Location = new System.Drawing.Point(792, 419);
            this.cmbDiscounts.Name = "cmbDiscounts";
            this.cmbDiscounts.Size = new System.Drawing.Size(121, 28);
            this.cmbDiscounts.TabIndex = 36;
            this.cmbDiscounts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(792, 609);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(141, 35);
            this.btnCANCEL.TabIndex = 38;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Quantity:";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(718, 464);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(195, 26);
            this.txtQTY.TabIndex = 40;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(701, 370);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(212, 26);
            this.txtPrice.TabIndex = 41;
            // 
            // txtSELL
            // 
            this.txtSELL.Location = new System.Drawing.Point(763, 548);
            this.txtSELL.Name = "txtSELL";
            this.txtSELL.Size = new System.Drawing.Size(150, 26);
            this.txtSELL.TabIndex = 42;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(718, 508);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(195, 26);
            this.txtStore.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Quantity to sell:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 508);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Store:";
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(748, 95);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(141, 35);
            this.btnREFRESH.TabIndex = 72;
            this.btnREFRESH.Text = "Refresh table";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 734);
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.txtSELL);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.cmbDiscounts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPDate);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSELL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSALES);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSALES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridSALES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSELL;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDiscounts;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSELL;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnREFRESH;
    }
}