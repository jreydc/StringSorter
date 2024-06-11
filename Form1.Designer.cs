namespace StringSorter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            txtStringInput = new TextBox();
            lblOutputString = new Label();
            btnSort = new Button();
            cmbSortType = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtStringInput
            // 
            txtStringInput.Enabled = false;
            txtStringInput.Location = new Point(151, 52);
            txtStringInput.Name = "txtStringInput";
            txtStringInput.Size = new Size(160, 23);
            txtStringInput.TabIndex = 0;
            // 
            // lblOutputString
            // 
            lblOutputString.AutoSize = true;
            lblOutputString.Location = new Point(151, 102);
            lblOutputString.Name = "lblOutputString";
            lblOutputString.Size = new Size(82, 15);
            lblOutputString.TabIndex = 1;
            lblOutputString.Text = "Sorted Output";
            // 
            // btnSort
            // 
            btnSort.Enabled = false;
            btnSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSort.Image = Properties.Resources.up_and_down_arrow_button;
            btnSort.ImageAlign = ContentAlignment.MiddleLeft;
            btnSort.Location = new Point(330, 38);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(106, 45);
            btnSort.TabIndex = 2;
            btnSort.Text = "SORT";
            btnSort.TextAlign = ContentAlignment.MiddleRight;
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cmbSortType
            // 
            cmbSortType.FormattingEnabled = true;
            cmbSortType.Items.AddRange(new object[] { "Bubble Sort", "Quick Sort", "Merge Sort" });
            cmbSortType.Location = new Point(13, 52);
            cmbSortType.Name = "cmbSortType";
            cmbSortType.Size = new Size(121, 23);
            cmbSortType.TabIndex = 3;
            cmbSortType.SelectedIndexChanged += cmbSortType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 4;
            label1.Text = "Please Select a Sort type:";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 180);
            Controls.Add(label1);
            Controls.Add(cmbSortType);
            Controls.Add(btnSort);
            Controls.Add(lblOutputString);
            Controls.Add(txtStringInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "String Sorter Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStringInput;
        private Label lblOutputString;
        private Button btnSort;
        private ComboBox cmbSortType;
        private Label label1;
    }
}
