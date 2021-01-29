
namespace Question01_Generic_Method
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.displayGroupBox = new System.Windows.Forms.GroupBox();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputGroupBox.SuspendLayout();
            this.displayGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.button1);
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Controls.Add(this.selectComboBox);
            this.inputGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGroupBox.ForeColor = System.Drawing.Color.Gray;
            this.inputGroupBox.Location = new System.Drawing.Point(6, 6);
            this.inputGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.inputGroupBox.Size = new System.Drawing.Size(298, 60);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(221, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.ForeColor = System.Drawing.Color.Black;
            this.inputTextBox.Location = new System.Drawing.Point(104, 25);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(108, 21);
            this.inputTextBox.TabIndex = 0;
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(9, 25);
            this.selectComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(84, 23);
            this.selectComboBox.TabIndex = 1;
            this.selectComboBox.SelectedIndexChanged += new System.EventHandler(this.selectComboBox_SelectedIndexChanged);
            // 
            // displayGroupBox
            // 
            this.displayGroupBox.Controls.Add(this.displayTextBox);
            this.displayGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayGroupBox.ForeColor = System.Drawing.Color.Gray;
            this.displayGroupBox.Location = new System.Drawing.Point(6, 280);
            this.displayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.displayGroupBox.Name = "displayGroupBox";
            this.displayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.displayGroupBox.Size = new System.Drawing.Size(298, 56);
            this.displayGroupBox.TabIndex = 1;
            this.displayGroupBox.TabStop = false;
            this.displayGroupBox.Text = "Result";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(15, 22);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(274, 21);
            this.displayTextBox.TabIndex = 0;
            // 
            // dataListBox
            // 
            this.dataListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListBox.ForeColor = System.Drawing.Color.Gray;
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 15;
            this.dataListBox.Location = new System.Drawing.Point(12, 19);
            this.dataListBox.Margin = new System.Windows.Forms.Padding(2);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(274, 154);
            this.dataListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataListBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(295, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 348);
            this.Controls.Add(this.displayGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.displayGroupBox.ResumeLayout(false);
            this.displayGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.GroupBox displayGroupBox;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

