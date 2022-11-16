namespace SortingAlgorithms
{
    partial class FormSortingAlgorithms
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
            this.listBoxPreSort = new System.Windows.Forms.ListBox();
            this.listBoxPostSort = new System.Windows.Forms.ListBox();
            this.groupBoxBubbleSort = new System.Windows.Forms.GroupBox();
            this.buttonBubbleInLine = new System.Windows.Forms.Button();
            this.groupBoxBubbleSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pre-Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post-Sort";
            // 
            // listBoxPreSort
            // 
            this.listBoxPreSort.FormattingEnabled = true;
            this.listBoxPreSort.ItemHeight = 25;
            this.listBoxPreSort.Location = new System.Drawing.Point(29, 54);
            this.listBoxPreSort.Name = "listBoxPreSort";
            this.listBoxPreSort.Size = new System.Drawing.Size(373, 629);
            this.listBoxPreSort.TabIndex = 2;
            // 
            // listBoxPostSort
            // 
            this.listBoxPostSort.FormattingEnabled = true;
            this.listBoxPostSort.ItemHeight = 25;
            this.listBoxPostSort.Location = new System.Drawing.Point(436, 53);
            this.listBoxPostSort.Name = "listBoxPostSort";
            this.listBoxPostSort.Size = new System.Drawing.Size(380, 629);
            this.listBoxPostSort.TabIndex = 3;
            // 
            // groupBoxBubbleSort
            // 
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleInLine);
            this.groupBoxBubbleSort.Location = new System.Drawing.Point(841, 53);
            this.groupBoxBubbleSort.Name = "groupBoxBubbleSort";
            this.groupBoxBubbleSort.Size = new System.Drawing.Size(341, 100);
            this.groupBoxBubbleSort.TabIndex = 4;
            this.groupBoxBubbleSort.TabStop = false;
            this.groupBoxBubbleSort.Text = "Bubble Sort";
            // 
            // buttonBubbleInLine
            // 
            this.buttonBubbleInLine.Location = new System.Drawing.Point(77, 30);
            this.buttonBubbleInLine.Name = "buttonBubbleInLine";
            this.buttonBubbleInLine.Size = new System.Drawing.Size(175, 44);
            this.buttonBubbleInLine.TabIndex = 0;
            this.buttonBubbleInLine.Text = "In-Line";
            this.buttonBubbleInLine.UseVisualStyleBackColor = true;
            this.buttonBubbleInLine.Click += new System.EventHandler(this.buttonBubbleInLine_Click);
            // 
            // FormSortingAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 713);
            this.Controls.Add(this.groupBoxBubbleSort);
            this.Controls.Add(this.listBoxPostSort);
            this.Controls.Add(this.listBoxPreSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSortingAlgorithms";
            this.Text = "Sorting Algorithm";
            this.groupBoxBubbleSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPreSort;
        private System.Windows.Forms.ListBox listBoxPostSort;
        private System.Windows.Forms.GroupBox groupBoxBubbleSort;
        private System.Windows.Forms.Button buttonBubbleInLine;
    }
}

