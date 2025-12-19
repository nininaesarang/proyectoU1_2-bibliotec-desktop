
namespace proyectoU1_2
{
    partial class Authors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authors));
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnMODIFY = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAuthor = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mkd_id = new System.Windows.Forms.MaskedTextBox();
            this.mkdPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.chkContract = new System.Windows.Forms.CheckBox();
            this.btnREFRESH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(799, 602);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(141, 35);
            this.btnCANCEL.TabIndex = 62;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnMODIFY
            // 
            this.btnMODIFY.Location = new System.Drawing.Point(635, 602);
            this.btnMODIFY.Name = "btnMODIFY";
            this.btnMODIFY.Size = new System.Drawing.Size(141, 35);
            this.btnMODIFY.TabIndex = 61;
            this.btnMODIFY.Text = "Modify";
            this.btnMODIFY.UseVisualStyleBackColor = true;
            this.btnMODIFY.Click += new System.EventHandler(this.btnMODIFY_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(643, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "State:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "City:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Address:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Phone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Last Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(721, 331);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 26);
            this.txtAddress.TabIndex = 51;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(739, 244);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(177, 26);
            this.txtLName.TabIndex = 49;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(704, 205);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 26);
            this.txtName.TabIndex = 48;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(169, 100);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 25);
            this.Search.TabIndex = 46;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(262, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 26);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(799, 561);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(141, 35);
            this.btnDELETE.TabIndex = 44;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(635, 561);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(141, 35);
            this.btnADD.TabIndex = 43;
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
            this.label1.Location = new System.Drawing.Point(330, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage Author List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridAuthor
            // 
            this.dataGridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthor.Location = new System.Drawing.Point(17, 145);
            this.dataGridAuthor.Name = "dataGridAuthor";
            this.dataGridAuthor.RowHeadersWidth = 62;
            this.dataGridAuthor.RowTemplate.Height = 28;
            this.dataGridAuthor.Size = new System.Drawing.Size(595, 476);
            this.dataGridAuthor.TabIndex = 41;
            this.dataGridAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSALES_CellContentClick);
            this.dataGridAuthor.SelectionChanged += new System.EventHandler(this.dataGridAuthor_SelectionChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(969, 82);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // mkd_id
            // 
            this.mkd_id.Location = new System.Drawing.Point(704, 154);
            this.mkd_id.Mask = "000-00-0000";
            this.mkd_id.Name = "mkd_id";
            this.mkd_id.Size = new System.Drawing.Size(212, 26);
            this.mkd_id.TabIndex = 63;
            this.mkd_id.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkd_id_MaskInputRejected);
            // 
            // mkdPhone
            // 
            this.mkdPhone.Location = new System.Drawing.Point(708, 286);
            this.mkdPhone.Mask = "000 00-0000";
            this.mkdPhone.Name = "mkdPhone";
            this.mkdPhone.Size = new System.Drawing.Size(212, 26);
            this.mkdPhone.TabIndex = 64;
            this.mkdPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkdPhone_MaskInputRejected);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(704, 370);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(212, 26);
            this.txtCity.TabIndex = 65;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(701, 413);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(212, 26);
            this.txtState.TabIndex = 66;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "CP:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(701, 466);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(212, 26);
            this.txtCP.TabIndex = 69;
            this.txtCP.TextChanged += new System.EventHandler(this.txtCP_TextChanged);
            // 
            // chkContract
            // 
            this.chkContract.AutoSize = true;
            this.chkContract.Location = new System.Drawing.Point(647, 513);
            this.chkContract.Name = "chkContract";
            this.chkContract.Size = new System.Drawing.Size(96, 24);
            this.chkContract.TabIndex = 70;
            this.chkContract.Text = "Contract";
            this.chkContract.UseVisualStyleBackColor = true;
            this.chkContract.CheckedChanged += new System.EventHandler(this.chkContract_CheckedChanged);
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(799, 507);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(141, 35);
            this.btnREFRESH.TabIndex = 71;
            this.btnREFRESH.Text = "Refresh table";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 649);
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.chkContract);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.mkdPhone);
            this.Controls.Add(this.mkd_id);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnMODIFY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridAuthor);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Authors";
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.Authors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnMODIFY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAuthor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox mkd_id;
        private System.Windows.Forms.MaskedTextBox mkdPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.CheckBox chkContract;
        private System.Windows.Forms.Button btnREFRESH;
    }
}