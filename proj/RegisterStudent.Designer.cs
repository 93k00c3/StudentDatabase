namespace StudentRegDatabase
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStuid = new System.Windows.Forms.TextBox();
            this.txtStuname = new System.Windows.Forms.TextBox();
            this.txtStuAge = new System.Windows.Forms.TextBox();
            this.txtStugpa = new System.Windows.Forms.TextBox();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Studenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię i Nazwisko";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wiek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Średnia";
            // 
            // txtStuid
            // 
            this.txtStuid.Location = new System.Drawing.Point(233, 65);
            this.txtStuid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStuid.Name = "txtStuid";
            this.txtStuid.Size = new System.Drawing.Size(136, 20);
            this.txtStuid.TabIndex = 4;
            this.txtStuid.TextChanged += new System.EventHandler(this.txtStuid_TextChanged);
            // 
            // txtStuname
            // 
            this.txtStuname.Location = new System.Drawing.Point(233, 119);
            this.txtStuname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStuname.Name = "txtStuname";
            this.txtStuname.Size = new System.Drawing.Size(136, 20);
            this.txtStuname.TabIndex = 5;
            // 
            // txtStuAge
            // 
            this.txtStuAge.Location = new System.Drawing.Point(233, 178);
            this.txtStuAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStuAge.Name = "txtStuAge";
            this.txtStuAge.Size = new System.Drawing.Size(136, 20);
            this.txtStuAge.TabIndex = 6;
            this.txtStuAge.TextChanged += new System.EventHandler(this.txtStuAge_TextChanged);
            // 
            // txtStugpa
            // 
            this.txtStugpa.Location = new System.Drawing.Point(233, 230);
            this.txtStugpa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStugpa.Name = "txtStugpa";
            this.txtStugpa.Size = new System.Drawing.Size(136, 20);
            this.txtStugpa.TabIndex = 7;
            this.txtStugpa.TextChanged += new System.EventHandler(this.txtStugpa_TextChanged);
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.Color.Transparent;
            this.btnRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.Location = new System.Drawing.Point(71, 294);
            this.btnRegis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(107, 31);
            this.btnRegis.TabIndex = 8;
            this.btnRegis.Text = "DODAJ";
            this.btnRegis.UseVisualStyleBackColor = false;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.Color.Transparent;
            this.btnrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.Location = new System.Drawing.Point(271, 294);
            this.btnrest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(98, 31);
            this.btnrest.TabIndex = 9;
            this.btnrest.Text = "RESET";
            this.btnrest.UseVisualStyleBackColor = false;
            this.btnrest.Click += new System.EventHandler(this.btnrest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(446, 372);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.txtStugpa);
            this.Controls.Add(this.txtStuAge);
            this.Controls.Add(this.txtStuname);
            this.Controls.Add(this.txtStuid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStuid;
        private System.Windows.Forms.TextBox txtStuname;
        private System.Windows.Forms.TextBox txtStuAge;
        private System.Windows.Forms.TextBox txtStugpa;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnrest;
    }
}

