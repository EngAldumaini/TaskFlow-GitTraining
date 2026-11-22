namespace TaskFlow
{
    partial class Form1
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
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(240, 32);
            this.txtTask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(416, 30);
            this.txtTask.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 23;
            this.lstTasks.Location = new System.Drawing.Point(20, 86);
            this.lstTasks.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(636, 418);
            this.lstTasks.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 520);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTask);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskFlow - Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstTasks;
    }
}

