
namespace proyectoU1_2
{
    partial class client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataStock = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtAuthorLN = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(791, 422);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(141, 35);
            this.btnCANCEL.TabIndex = 45;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(164, 92);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 25);
            this.Search.TabIndex = 44;
            this.Search.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(257, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 26);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "Stock in stores";
            // 
            // dataStock
            // 
            this.dataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStock.Location = new System.Drawing.Point(27, 133);
            this.dataStock.Name = "dataStock";
            this.dataStock.RowHeadersWidth = 62;
            this.dataStock.RowTemplate.Height = 28;
            this.dataStock.Size = new System.Drawing.Size(595, 324);
            this.dataStock.TabIndex = 41;
            this.dataStock.SelectionChanged += new System.EventHandler(this.dataStock_SelectionChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(969, 82);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Author last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Author name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Store:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Title:";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(791, 328);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(138, 26);
            this.txtQTY.TabIndex = 50;
            // 
            // txtAuthorLN
            // 
            this.txtAuthorLN.Location = new System.Drawing.Point(791, 277);
            this.txtAuthorLN.Name = "txtAuthorLN";
            this.txtAuthorLN.Size = new System.Drawing.Size(138, 26);
            this.txtAuthorLN.TabIndex = 49;
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(791, 229);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(138, 26);
            this.txtAName.TabIndex = 48;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(717, 133);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(212, 26);
            this.txtStore.TabIndex = 47;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(717, 177);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(212, 26);
            this.txtTitle.TabIndex = 46;
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(644, 422);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(141, 35);
            this.btnTitle.TabIndex = 56;
            this.btnTitle.Text = "XML Title";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(644, 381);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(141, 35);
            this.btnAuthor.TabIndex = 57;
            this.btnAuthor.Text = "XML Author";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(791, 381);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(141, 35);
            this.btnStore.TabIndex = 58;
            this.btnStore.Text = "XML Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 469);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.txtAuthorLN);
            this.Controls.Add(this.txtAName);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataStock);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "client";
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataStock;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtAuthorLN;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnStore;
    }
}