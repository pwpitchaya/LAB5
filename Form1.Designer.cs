namespace LAB5
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
            label1 = new Label();
            label2 = new Label();
            save = new Button();
            textBoxName = new TextBox();
            textBoxgpa = new TextBox();
            Boxname = new TextBox();
            Boxgpa = new TextBox();
            BoxLow = new TextBox();
            BoxtHigh = new TextBox();
            Boxav = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 71);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 117);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "เกรด";
            // 
            // save
            // 
            save.Location = new Point(231, 172);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 2;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += button1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(222, 71);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxgpa
            // 
            textBoxgpa.Location = new Point(222, 114);
            textBoxgpa.Name = "textBoxgpa";
            textBoxgpa.Size = new Size(125, 27);
            textBoxgpa.TabIndex = 4;
            // 
            // Boxname
            // 
            Boxname.Location = new Point(435, 38);
            Boxname.Name = "Boxname";
            Boxname.Size = new Size(125, 27);
            Boxname.TabIndex = 5;
            // 
            // Boxgpa
            // 
            Boxgpa.Location = new Point(435, 71);
            Boxgpa.Name = "Boxgpa";
            Boxgpa.Size = new Size(125, 27);
            Boxgpa.TabIndex = 6;
            // 
            // BoxLow
            // 
            BoxLow.Location = new Point(587, 71);
            BoxLow.Name = "BoxLow";
            BoxLow.Size = new Size(125, 27);
            BoxLow.TabIndex = 7;
            // 
            // BoxtHigh
            // 
            BoxtHigh.Location = new Point(587, 38);
            BoxtHigh.Name = "BoxtHigh";
            BoxtHigh.Size = new Size(125, 27);
            BoxtHigh.TabIndex = 8;
            // 
            // Boxav
            // 
            Boxav.Location = new Point(515, 114);
            Boxav.Name = "Boxav";
            Boxav.Size = new Size(125, 27);
            Boxav.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Boxav);
            Controls.Add(BoxtHigh);
            Controls.Add(BoxLow);
            Controls.Add(Boxgpa);
            Controls.Add(Boxname);
            Controls.Add(textBoxgpa);
            Controls.Add(textBoxName);
            Controls.Add(save);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button save;
        private TextBox textBoxName;
        private TextBox textBoxgpa;
        private TextBox Boxname;
        private TextBox Boxgpa;
        private TextBox BoxLow;
        private TextBox BoxtHigh;
        private TextBox Boxav;
    }
}
