namespace DynamicDataBinding
{
    partial class BasicComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            name = new TextBox();
            label2 = new Label();
            age = new TextBox();
            label3 = new Label();
            gender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // name
            // 
            name.Location = new Point(126, 13);
            name.Name = "name";
            name.Size = new Size(246, 27);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // age
            // 
            age.Location = new Point(127, 66);
            age.Name = "age";
            age.Size = new Size(245, 27);
            age.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 111);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Location = new Point(131, 113);
            gender.Name = "gender";
            gender.Size = new Size(241, 28);
            gender.TabIndex = 5;
            // 
            // BasicComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gender);
            Controls.Add(label3);
            Controls.Add(age);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "BasicComponent";
            Size = new Size(411, 147);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox ageTextBox;
        private Label label3;
        private ComboBox gender;
        private TextBox name;
        private TextBox age;
    }
}
