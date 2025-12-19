
namespace proyectoU1_2
{
    partial class modify_discount
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(169, 277);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(141, 35);
            this.btnCANCEL.TabIndex = 127;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 277);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 35);
            this.btnEdit.TabIndex = 126;
            this.btnEdit.Text = "Modify";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 125;
            this.label6.Text = "Discount:";
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(124, 165);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(177, 26);
            this.txtHigh.TabIndex = 124;
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(94, 221);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(207, 26);
            this.txtDisc.TabIndex = 123;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(128, 12);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(173, 26);
            this.txtType.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 121;
            this.label5.Text = "High quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 120;
            this.label4.Text = "Low quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 119;
            this.label3.Text = "Store ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Discount type:";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(117, 113);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(184, 26);
            this.txtLow.TabIndex = 117;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(91, 63);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(210, 26);
            this.txtStore.TabIndex = 116;
            // 
            // modify_discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 326);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtStore);
            this.Name = "modify_discount";
            this.Text = "modify_discount";
            this.Load += new System.EventHandler(this.modify_discount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtStore;
    }
}