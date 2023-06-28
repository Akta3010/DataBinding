namespace DynamicDataBinding
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
            Save = new Button();
            LoadFile = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            clear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Location = new Point(189, 249);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 0;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // LoadFile
            // 
            LoadFile.Location = new Point(471, 249);
            LoadFile.Name = "LoadFile";
            LoadFile.Size = new Size(94, 29);
            LoadFile.TabIndex = 1;
            LoadFile.Text = "Load";
            LoadFile.UseVisualStyleBackColor = true;
            LoadFile.Click += LoadFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(clear);
            panel1.Controls.Add(LoadFile);
            panel1.Controls.Add(Save);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 306);
            panel1.TabIndex = 2;
            // 
            // clear
            // 
            clear.Location = new Point(332, 249);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 2;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 306);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Save;
        private Button LoadFile;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button clear;
    }
}