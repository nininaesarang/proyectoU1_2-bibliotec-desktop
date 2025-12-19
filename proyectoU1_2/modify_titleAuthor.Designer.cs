
namespace proyectoU1_2
{
    partial class modify_titleAuthor
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
            this.txtAuthorORDER = new System.Windows.Forms.TextBox();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtRoyal = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMODIFY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAuthorORDER
            // 
            this.txtAuthorORDER.Location = new System.Drawing.Point(112, 99);
            this.txtAuthorORDER.Name = "txtAuthorORDER";
            this.txtAuthorORDER.Size = new System.Drawing.Size(195, 26);
            this.txtAuthorORDER.TabIndex = 164;
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(99, 54);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(208, 26);
            this.txtTitleID.TabIndex = 163;
            // 
            // txtRoyal
            // 
            this.txtRoyal.Location = new System.Drawing.Point(112, 138);
            this.txtRoyal.Name = "txtRoyal";
            this.txtRoyal.Size = new System.Drawing.Size(193, 26);
            this.txtRoyal.TabIndex = 162;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(97, 12);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(210, 26);
            this.txtAuthorID.TabIndex = 161;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(166, 185);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(141, 35);
            this.btnCANCEL.TabIndex = 160;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 159;
            this.label7.Text = "Royaltyper:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 158;
            this.label6.Text = "Athor Order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 157;
            this.label5.Text = "Title ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 156;
            this.label4.Text = "Author ID:";
            // 
            // btnMODIFY
            // 
            this.btnMODIFY.Location = new System.Drawing.Point(9, 185);
            this.btnMODIFY.Name = "btnMODIFY";
            this.btnMODIFY.Size = new System.Drawing.Size(141, 35);
            this.btnMODIFY.TabIndex = 155;
            this.btnMODIFY.Text = "Modify";
            this.btnMODIFY.UseVisualStyleBackColor = true;
            this.btnMODIFY.Click += new System.EventHandler(this.btnMODIFY_Click);
            // 
            // modify_titleAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 241);
            this.Controls.Add(this.txtAuthorORDER);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.txtRoyal);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMODIFY);
            this.Name = "modify_titleAuthor";
            this.Text = "modify_titleAuthor";
            this.Load += new System.EventHandler(this.modify_titleAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorORDER;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtRoyal;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMODIFY;
    }
}