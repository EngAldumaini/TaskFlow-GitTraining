using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Validates the task name before adding it to the list.
        private void btnAdd_Click(object sender, EventArgs e)
        {

            string task = txtTask.Text.Trim();

            if (string.IsNullOrWhiteSpace(task))
            {
                MessageBox.Show("Task name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstTasks.Items.Add(task);

            txtTask.Clear();
            txtTask.Focus();

        }

        // Deletes the selected task from the list.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
        }
    }
}
