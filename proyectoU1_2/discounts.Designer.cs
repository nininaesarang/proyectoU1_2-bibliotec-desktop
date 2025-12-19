
namespace proyectoU1_2
{
    partial class discounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(discounts));
            this.btnREFRESH = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnMODIFY = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDiscounts = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(796, 428);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(141, 35);
            this.btnREFRESH.TabIndex = 99;
            this.btnREFRESH.Text = "Refresh table";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(796, 510);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(141, 35);
            this.btnCANCEL.TabIndex = 91;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnMODIFY
            // 
            this.btnMODIFY.Location = new System.Drawing.Point(630, 510);
            this.btnMODIFY.Name = "btnMODIFY";
            this.btnMODIFY.Size = new System.Drawing.Size(141, 35);
            this.btnMODIFY.TabIndex = 90;
            this.btnMODIFY.Text = "Modify";
            this.btnMODIFY.UseVisualStyleBackColor = true;
            this.btnMODIFY.Click += new System.EventHandler(this.btnMODIFY_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "High quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Low quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Store ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Discount type:";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(743, 252);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(184, 26);
            this.txtLow.TabIndex = 81;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(717, 202);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(210, 26);
            this.txtStore.TabIndex = 80;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(164, 97);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 25);
            this.Search.TabIndex = 79;
            this.Search.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(257, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 26);
            this.txtSearch.TabIndex = 78;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(796, 469);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(141, 35);
            this.btnDELETE.TabIndex = 77;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(630, 469);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(141, 35);
            this.btnADD.TabIndex = 76;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(325, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 75;
            this.label1.Text = "Manage Discounts";
            // 
            // dataGridDiscounts
            // 
            this.dataGridDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiscounts.Location = new System.Drawing.Point(17, 151);
            this.dataGridDiscounts.Name = "dataGridDiscounts";
            this.dataGridDiscounts.RowHeadersWidth = 62;
            this.dataGridDiscounts.RowTemplate.Height = 28;
            this.dataGridDiscounts.Size = new System.Drawing.Size(595, 415);
            this.dataGridDiscounts.TabIndex = 74;
            this.dataGridDiscounts.SelectionChanged += new System.EventHandler(this.dataGridDiscounts_SelectionChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(969, 82);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(754, 151);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(173, 26);
            this.txtType.TabIndex = 100;
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(720, 360);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(207, 26);
            this.txtDisc.TabIndex = 101;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(750, 304);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(177, 26);
            this.txtHigh.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "Discount:";
            // 
            // discounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 578);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnMODIFY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDiscounts);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "discounts";
            this.Text = "discounts";
            this.Load += new System.EventHandler(this.discounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnREFRESH;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnMODIFY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDiscounts;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label label6;
    }
}