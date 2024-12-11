namespace WinFormsStringMethod
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
            txtFullname = new TextBox();
            txtTitle = new TextBox();
            btnSplitname = new Button();
            txtFristName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(198, 163);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(294, 27);
            txtFullname.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(198, 219);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(294, 27);
            txtTitle.TabIndex = 1;
            // 
            // btnSplitname
            // 
            btnSplitname.Location = new Point(573, 163);
            btnSplitname.Name = "btnSplitname";
            btnSplitname.Size = new Size(94, 29);
            btnSplitname.TabIndex = 2;
            btnSplitname.Text = "แยกชื่อสกุล";
            btnSplitname.UseVisualStyleBackColor = true;
            btnSplitname.Click += btnSplitname_Click;
            // 
            // txtFristName
            // 
            txtFristName.Location = new Point(198, 286);
            txtFristName.Name = "txtFristName";
            txtFristName.Size = new Size(294, 27);
            txtFristName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(198, 344);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(294, 27);
            txtLastName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 166);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 5;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 222);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 6;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 289);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 7;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 347);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 8;
            label4.Text = "สกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 219);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 738);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFristName);
            Controls.Add(btnSplitname);
            Controls.Add(txtTitle);
            Controls.Add(txtFullname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private TextBox txtTitle;
        private Button btnSplitname;
        private TextBox txtFristName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
