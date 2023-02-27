using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            lstToDo.DataSource=TaskRepository.FindAllToDo();
            lstDoing.DataSource=TaskRepository.FindAllDoing();
            lstDone.DataSource=TaskRepository.FindAllDone();
        }

        #region Buttons new taks
        private void btnDeleteText_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text.Length == 0)
                {
                    MessageBox.Show("Description was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescription.Focus();
                }
                else
                {
                    Task task = new Task(txtDescription.Text);
                    TaskRepository.Save(task);

                    lstToDo.DataSource = TaskRepository.FindAllToDo();

                    txtDescription.Text = "";
                    txtDescription.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
#endregion

        #region Buttons that change state
        private void btnMoveToDoing_Click(object sender, EventArgs e)
        {
            if (lstToDo.SelectedIndex > -1)
            {
                Task task = (Task)lstToDo.SelectedItem;
                task.State = 1;
                TaskRepository.Save(task);
                lstToDo.DataSource = TaskRepository.FindAllToDo();
                lstDoing.DataSource = TaskRepository.FindAllDoing();
            }
        }

        private void btnMoveToDone_Click(object sender, EventArgs e)
        {
            if (lstDoing.SelectedIndex > -1)
            {
                Task task = (Task)lstDoing.SelectedItem;
                task.State = 2;
                TaskRepository.Save(task);
                lstDoing.DataSource = TaskRepository.FindAllDoing();
                lstDone.DataSource = TaskRepository.FindAllDone();
            }
        }
        private void btnBackToToDo_Click(object sender, EventArgs e)
        {
            if (lstDoing.SelectedIndex > -1)
            {
                Task task = (Task)lstDoing.SelectedItem;
                task.State = 0;
                TaskRepository.Save(task);
                lstDoing.DataSource = TaskRepository.FindAllDoing();
                lstToDo.DataSource = TaskRepository.FindAllToDo();
            }
        }
        private void btnBackToDoing_Click(object sender, EventArgs e)
        {
            if (lstDone.SelectedIndex > -1)
            {
                Task task = (Task)lstDone.SelectedItem;
                task.State = 1;
                TaskRepository.Save(task);
                lstDoing.DataSource = TaskRepository.FindAllDoing();
                lstDone.DataSource = TaskRepository.FindAllDone();
            }
        }
        private void btnAllDeleteTask_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ListBox list;
            if (btn == btnDeleteTaskFromToDo)
                list = lstToDo;
            else
                list = lstDone;
            if (list.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Are you sure you want to delete task \"{((Task)list.SelectedItem).Description}\"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    TaskRepository.Remove((Task)list.SelectedItem);
                    lstToDo.DataSource = TaskRepository.FindAllToDo();
                    lstDone.DataSource = TaskRepository.FindAllDone();
                }
            }
        }
        #endregion

        #region ToolTip to ListBox items
        private void lstAll_MouseMove(object sender, MouseEventArgs e)
        {
            var listBox = (ListBox)sender;
            int index = listBox.IndexFromPoint(e.Location);
            if (index >= 0 && index < listBox.Items.Count)
            {
                string itemText = listBox.Items[index].ToString();
                ttMain.SetToolTip(listBox, itemText);
            }
            else
            {
                ttMain.SetToolTip(listBox, string.Empty);
            }
        }
        #endregion

        #region Drag and Drop in all lists
        private void UpdateLists()
        {
            // saving the selected index of each list
            int indexToDo = lstToDo.SelectedIndex;
            int indexDoing = lstDoing.SelectedIndex;
            int indexDone = lstDone.SelectedIndex;

            // updating the lists
            lstToDo.DataSource = TaskRepository.FindAllToDo();
            lstDoing.DataSource= TaskRepository.FindAllDoing();
            lstDone.DataSource= TaskRepository.FindAllDone();

            // returning the index to their old values
            if (lstToDo.SelectedIndex > -1)
                if (lstToDo.Items.Count > indexToDo)
                {
                    lstToDo.SelectedIndex = indexToDo;
                    if(lstToDo.SelectedIndex==-1)
                        lstToDo.SelectedIndex = 0;
                }
                else
                    lstToDo.SelectedIndex = lstToDo.Items.Count - 1;

            if (lstDoing.SelectedIndex > -1)
                if (lstDoing.Items.Count > indexDoing)
                {
                    lstDoing.SelectedIndex = indexDoing;
                    if (lstDoing.SelectedIndex == -1)
                        lstDoing.SelectedIndex = 0;
                }
                else
                    lstDoing.SelectedIndex = lstDoing.Items.Count - 1;

            if(lstDone.SelectedIndex > -1)
                if (lstDone.Items.Count > indexDone)
                {
                    lstDone.SelectedIndex = indexDone;
                    if (lstDone.SelectedIndex == -1)
                        lstDone.SelectedIndex = 0;
                }
                else
                    lstDone.SelectedIndex = lstDone.Items.Count - 1;
            // whithout this, every click reset the selected index to 0.
        }
        private void lstAll_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var listBox = (ListBox)sender;
                if (listBox.SelectedItem != null)
                {
                    listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Move);
                }
            }
        }
        private void lstAll_DragDrop(object sender, DragEventArgs e)
        {
            var listBox = (ListBox)sender;
            Task task = (Task)e.Data.GetData(typeof(Task));

            if (listBox == lstToDo)
                task.State = 0;
            else if (listBox == lstDoing)
                task.State = 1;
            else
                task.State = 2;

            TaskRepository.Save(task);
            UpdateLists();
        }
        private void lstAll_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        #endregion
    }
}
