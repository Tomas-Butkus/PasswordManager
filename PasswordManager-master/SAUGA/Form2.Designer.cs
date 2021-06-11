
namespace SAUGA
{
    partial class form
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
            this.exitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newname = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.newurl = new System.Windows.Forms.TextBox();
            this.newcomm = new System.Windows.Forms.TextBox();
            this.createbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logged = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urlclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updatebtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.copybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(12, 415);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "URL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Comment:";
            // 
            // newname
            // 
            this.newname.Location = new System.Drawing.Point(231, 53);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(100, 20);
            this.newname.TabIndex = 7;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(231, 92);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(100, 20);
            this.newpass.TabIndex = 8;
            // 
            // newurl
            // 
            this.newurl.Location = new System.Drawing.Point(231, 135);
            this.newurl.Name = "newurl";
            this.newurl.Size = new System.Drawing.Size(100, 20);
            this.newurl.TabIndex = 9;
            // 
            // newcomm
            // 
            this.newcomm.Location = new System.Drawing.Point(231, 176);
            this.newcomm.Name = "newcomm";
            this.newcomm.Size = new System.Drawing.Size(100, 20);
            this.newcomm.TabIndex = 10;
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(221, 202);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(113, 23);
            this.createbtn.TabIndex = 11;
            this.createbtn.Text = "Create Password";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generate Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logged
            // 
            this.logged.AutoSize = true;
            this.logged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logged.Location = new System.Drawing.Point(12, 9);
            this.logged.Name = "logged";
            this.logged.Size = new System.Drawing.Size(46, 17);
            this.logged.TabIndex = 13;
            this.logged.Text = "label7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(502, 48);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(138, 20);
            this.searchtxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name:";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(646, 48);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(94, 21);
            this.searchbtn.TabIndex = 19;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameclm,
            this.passclm,
            this.urlclm,
            this.commclm});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(436, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 174);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameclm
            // 
            this.nameclm.Text = "Name";
            this.nameclm.Width = 50;
            // 
            // passclm
            // 
            this.passclm.Text = "Password";
            // 
            // urlclm
            // 
            this.urlclm.Text = "URL";
            this.urlclm.Width = 100;
            // 
            // commclm
            // 
            this.commclm.Text = "Comment";
            this.commclm.Width = 120;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(436, 257);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(176, 23);
            this.updatebtn.TabIndex = 21;
            this.updatebtn.Text = "Update Password";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(436, 286);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(176, 23);
            this.showbtn.TabIndex = 22;
            this.showbtn.Text = "Show Password";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(618, 257);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(170, 23);
            this.deletebtn.TabIndex = 23;
            this.deletebtn.Text = "Delete Password";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // copybtn
            // 
            this.copybtn.Location = new System.Drawing.Point(618, 286);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(170, 23);
            this.copybtn.TabIndex = 24;
            this.copybtn.Text = "Copy to Clipboard";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logged);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.newcomm);
            this.Controls.Add(this.newurl);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitbtn);
            this.Name = "form";
            this.Text = "form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newname;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox newurl;
        private System.Windows.Forms.TextBox newcomm;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label logged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameclm;
        private System.Windows.Forms.ColumnHeader passclm;
        private System.Windows.Forms.ColumnHeader urlclm;
        private System.Windows.Forms.ColumnHeader commclm;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button copybtn;
    }
}