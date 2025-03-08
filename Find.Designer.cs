namespace BinaryEditor
{
    partial class Find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            tableLayoutPanel1 = new TableLayoutPanel();
            FindTextBox = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            FindedLBox = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            FullBox = new CheckBox();
            FindButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(FindTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2068968F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.7931061F));
            tableLayoutPanel1.Size = new Size(402, 580);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FindTextBox
            // 
            FindTextBox.Dock = DockStyle.Fill;
            FindTextBox.Location = new Point(3, 3);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(396, 59);
            FindTextBox.TabIndex = 0;
            FindTextBox.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(FindedLBox, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 68);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.40171F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90.59829F));
            tableLayoutPanel2.Size = new Size(396, 509);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // FindedLBox
            // 
            FindedLBox.Dock = DockStyle.Fill;
            FindedLBox.FormattingEnabled = true;
            FindedLBox.Location = new Point(3, 50);
            FindedLBox.Name = "FindedLBox";
            FindedLBox.Size = new Size(390, 456);
            FindedLBox.TabIndex = 0;
            FindedLBox.SelectedIndexChanged += FindedLBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.94872F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.05128F));
            tableLayoutPanel3.Controls.Add(FullBox, 0, 0);
            tableLayoutPanel3.Controls.Add(FindButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(390, 41);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // FullBox
            // 
            FullBox.AutoSize = true;
            FullBox.Dock = DockStyle.Fill;
            FullBox.Location = new Point(3, 3);
            FullBox.Name = "FullBox";
            FullBox.Size = new Size(220, 35);
            FullBox.TabIndex = 2;
            FullBox.Text = "Convert to full-width";
            FullBox.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            FindButton.Dock = DockStyle.Fill;
            FindButton.Location = new Point(229, 3);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(158, 35);
            FindButton.TabIndex = 3;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // Find
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 580);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Find";
            Text = "Find";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox FindTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox FindedLBox;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox FullBox;
        private Button FindButton;
    }
}