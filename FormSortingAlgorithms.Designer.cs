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
            this.buttonBubbleSortClass = new System.Windows.Forms.Button();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.buttonBubbleInLine = new System.Windows.Forms.Button();
            this.buttonBubbleSortGeneric = new System.Windows.Forms.Button();
            this.groupBoxBubbleSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pre-Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post-Sort";
            // 
            // listBoxPreSort
            // 
            this.listBoxPreSort.FormattingEnabled = true;
            this.listBoxPreSort.Location = new System.Drawing.Point(14, 28);
            this.listBoxPreSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPreSort.Name = "listBoxPreSort";
            this.listBoxPreSort.Size = new System.Drawing.Size(188, 329);
            this.listBoxPreSort.TabIndex = 2;
            // 
            // listBoxPostSort
            // 
            this.listBoxPostSort.FormattingEnabled = true;
            this.listBoxPostSort.Location = new System.Drawing.Point(218, 28);
            this.listBoxPostSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPostSort.Name = "listBoxPostSort";
            this.listBoxPostSort.Size = new System.Drawing.Size(192, 329);
            this.listBoxPostSort.TabIndex = 3;
            // 
            // groupBoxBubbleSort
            // 
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleSortGeneric);
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleSortClass);
            this.groupBoxBubbleSort.Controls.Add(this.buttonFunction);
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleInLine);
            this.groupBoxBubbleSort.Location = new System.Drawing.Point(420, 28);
            this.groupBoxBubbleSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBubbleSort.Name = "groupBoxBubbleSort";
            this.groupBoxBubbleSort.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBubbleSort.Size = new System.Drawing.Size(168, 193);
            this.groupBoxBubbleSort.TabIndex = 4;
            this.groupBoxBubbleSort.TabStop = false;
            this.groupBoxBubbleSort.Text = "Bubble Sort";
            // 
            // buttonBubbleSortClass
            // 
            this.buttonBubbleSortClass.Location = new System.Drawing.Point(38, 88);
            this.buttonBubbleSortClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBubbleSortClass.Name = "buttonBubbleSortClass";
            this.buttonBubbleSortClass.Size = new System.Drawing.Size(88, 23);
            this.buttonBubbleSortClass.TabIndex = 2;
            this.buttonBubbleSortClass.Text = "Class";
            this.buttonBubbleSortClass.UseVisualStyleBackColor = true;
            this.buttonBubbleSortClass.Click += new System.EventHandler(this.buttonBubbleSortClass_Click);
            // 
            // buttonFunction
            // 
            this.buttonFunction.Location = new System.Drawing.Point(38, 53);
            this.buttonFunction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(88, 23);
            this.buttonFunction.TabIndex = 1;
            this.buttonFunction.Text = "Function";
            this.buttonFunction.UseVisualStyleBackColor = true;
            this.buttonFunction.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonBubbleInLine
            // 
            this.buttonBubbleInLine.Location = new System.Drawing.Point(38, 16);
            this.buttonBubbleInLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBubbleInLine.Name = "buttonBubbleInLine";
            this.buttonBubbleInLine.Size = new System.Drawing.Size(88, 23);
            this.buttonBubbleInLine.TabIndex = 0;
            this.buttonBubbleInLine.Text = "In-Line";
            this.buttonBubbleInLine.UseVisualStyleBackColor = true;
            this.buttonBubbleInLine.Click += new System.EventHandler(this.buttonBubbleInLine_Click);
            // 
            // buttonBubbleSortGeneric
            // 
            this.buttonBubbleSortGeneric.Location = new System.Drawing.Point(38, 124);
            this.buttonBubbleSortGeneric.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBubbleSortGeneric.Name = "buttonBubbleSortGeneric";
            this.buttonBubbleSortGeneric.Size = new System.Drawing.Size(88, 23);
            this.buttonBubbleSortGeneric.TabIndex = 5;
            this.buttonBubbleSortGeneric.Text = "Generic";
            this.buttonBubbleSortGeneric.UseVisualStyleBackColor = true;
            this.buttonBubbleSortGeneric.Click += new System.EventHandler(this.buttonBubbleSortGeneric_Click);
            // 
            // FormSortingAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 371);
            this.Controls.Add(this.groupBoxBubbleSort);
            this.Controls.Add(this.listBoxPostSort);
            this.Controls.Add(this.listBoxPreSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSortingAlgorithms";
            this.Text = "Sorting Algorithms";
            this.Load += new System.EventHandler(this.FormSortingAlgorithms_Load);
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
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.Button buttonBubbleSortClass;
        private System.Windows.Forms.Button buttonBubbleSortGeneric;
    }
}

