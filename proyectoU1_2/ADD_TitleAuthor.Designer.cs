
namespace proyectoU1_2
{
    partial class ADD_TitleAuthor
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
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtAuthorORDER = new System.Windows.Forms.TextBox();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtRoyal = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(169, 188);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(141, 35);
            this.btnCANCEL.TabIndex = 150;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 149;
            this.label7.Text = "Royaltyper:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 148;
            this.label6.Text = "Athor Order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 147;
            this.label5.Text = "Title ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 146;
            this.label4.Text = "Author ID:";
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(12, 188);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(141, 35);
            this.btnADD.TabIndex = 144;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtAuthorORDER
            // 
            this.txtAuthorORDER.Location = new System.Drawing.Point(115, 102);
            this.txtAuthorORDER.Name = "txtAuthorORDER";
            this.txtAuthorORDER.Size = new System.Drawing.Size(195, 26);
            this.txtAuthorORDER.TabIndex = 154;
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(102, 57);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(208, 26);
            this.txtTitleID.TabIndex = 153;
            // 
            // txtRoyal
            // 
            this.txtRoyal.Location = new System.Drawing.Point(115, 141);
            this.txtRoyal.Name = "txtRoyal";
            this.txtRoyal.Size = new System.Drawing.Size(193, 26);
            this.txtRoyal.TabIndex = 152;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(100, 15);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(210, 26);
            this.txtAuthorID.TabIndex = 151;
            // 
            // ADD_TitleAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 247);
            this.Controls.Add(this.txtAuthorORDER);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.txtRoyal);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnADD);
            this.Name = "ADD_TitleAuthor";
            this.Text = "ADD_TitleAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtAuthorORDER;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtRoyal;
        private System.Windows.Forms.TextBox txtAuthorID;
    }
}