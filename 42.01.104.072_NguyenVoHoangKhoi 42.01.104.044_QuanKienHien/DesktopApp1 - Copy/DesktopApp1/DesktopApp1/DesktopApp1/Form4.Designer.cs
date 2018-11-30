namespace DesktopApp1
{
    partial class Form4
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
            this.linear = new System.Windows.Forms.Button();
            this.binary = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.shell = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.heap = new System.Windows.Forms.Button();
            this.interchange = new System.Windows.Forms.Button();
            this.quick = new System.Windows.Forms.Button();
            this.bubble = new System.Windows.Forms.Button();
            this.merge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linear
            // 
            this.linear.Location = new System.Drawing.Point(25, 22);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(260, 92);
            this.linear.TabIndex = 0;
            this.linear.Text = "Linear Search ( Tìm kiếm tuần tự )";
            this.linear.UseVisualStyleBackColor = true;
            this.linear.Click += new System.EventHandler(this.linear_Click);
            // 
            // binary
            // 
            this.binary.Location = new System.Drawing.Point(324, 22);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(260, 92);
            this.binary.TabIndex = 0;
            this.binary.Text = "Binary Search ( Tìm kiếm nhị phân )";
            this.binary.UseVisualStyleBackColor = true;
            this.binary.Click += new System.EventHandler(this.binary_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(25, 157);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(260, 92);
            this.select.TabIndex = 0;
            this.select.Text = "Selection Sort";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // shell
            // 
            this.shell.Location = new System.Drawing.Point(324, 157);
            this.shell.Name = "shell";
            this.shell.Size = new System.Drawing.Size(260, 92);
            this.shell.TabIndex = 0;
            this.shell.Text = "Shell Sort";
            this.shell.UseVisualStyleBackColor = true;
            this.shell.Click += new System.EventHandler(this.shell_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(25, 290);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(260, 92);
            this.insert.TabIndex = 0;
            this.insert.Text = "Insert Sort";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // heap
            // 
            this.heap.Location = new System.Drawing.Point(324, 290);
            this.heap.Name = "heap";
            this.heap.Size = new System.Drawing.Size(260, 92);
            this.heap.TabIndex = 0;
            this.heap.Text = "Heap Sort";
            this.heap.UseVisualStyleBackColor = true;
            this.heap.Click += new System.EventHandler(this.heap_Click);
            // 
            // interchange
            // 
            this.interchange.Location = new System.Drawing.Point(25, 425);
            this.interchange.Name = "interchange";
            this.interchange.Size = new System.Drawing.Size(260, 92);
            this.interchange.TabIndex = 0;
            this.interchange.Text = "Interchange Sort";
            this.interchange.UseVisualStyleBackColor = true;
            this.interchange.Click += new System.EventHandler(this.interchange_Click);
            // 
            // quick
            // 
            this.quick.Location = new System.Drawing.Point(324, 425);
            this.quick.Name = "quick";
            this.quick.Size = new System.Drawing.Size(260, 92);
            this.quick.TabIndex = 0;
            this.quick.Text = "Quick Sort";
            this.quick.UseVisualStyleBackColor = true;
            this.quick.Click += new System.EventHandler(this.quick_Click);
            // 
            // bubble
            // 
            this.bubble.Location = new System.Drawing.Point(25, 565);
            this.bubble.Name = "bubble";
            this.bubble.Size = new System.Drawing.Size(260, 92);
            this.bubble.TabIndex = 0;
            this.bubble.Text = "Bubble Sort";
            this.bubble.UseVisualStyleBackColor = true;
            this.bubble.Click += new System.EventHandler(this.bubble_Click);
            // 
            // merge
            // 
            this.merge.Location = new System.Drawing.Point(324, 565);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(260, 92);
            this.merge.TabIndex = 0;
            this.merge.Text = "Merge Sort";
            this.merge.UseVisualStyleBackColor = true;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 701);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.bubble);
            this.Controls.Add(this.quick);
            this.Controls.Add(this.interchange);
            this.Controls.Add(this.shell);
            this.Controls.Add(this.heap);
            this.Controls.Add(this.select);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.linear);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button linear;
        private System.Windows.Forms.Button binary;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button shell;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button heap;
        private System.Windows.Forms.Button interchange;
        private System.Windows.Forms.Button quick;
        private System.Windows.Forms.Button bubble;
        private System.Windows.Forms.Button merge;
    }
}