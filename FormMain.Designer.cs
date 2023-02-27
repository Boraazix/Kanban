namespace Kanban
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.btnDeleteTaskFromDone = new System.Windows.Forms.Button();
            this.btnMoveToDone = new System.Windows.Forms.Button();
            this.btnMoveToDoing = new System.Windows.Forms.Button();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblDoing = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.lstDoing = new System.Windows.Forms.ListBox();
            this.lstToDo = new System.Windows.Forms.ListBox();
            this.grpNewTask = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteText = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnBackToToDo = new System.Windows.Forms.Button();
            this.btnBackToDoing = new System.Windows.Forms.Button();
            this.btnDeleteTaskFromToDo = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.grpTasks.SuspendLayout();
            this.grpNewTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pcbMain);
            this.pnlMain.Controls.Add(this.grpTasks);
            this.pnlMain.Controls.Add(this.grpNewTask);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(554, 310);
            this.pnlMain.TabIndex = 0;
            // 
            // pcbMain
            // 
            this.pcbMain.Image = global::Kanban.Properties.Resources.img_503713;
            this.pcbMain.Location = new System.Drawing.Point(403, 12);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(134, 113);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMain.TabIndex = 2;
            this.pcbMain.TabStop = false;
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.btnDeleteTaskFromToDo);
            this.grpTasks.Controls.Add(this.btnBackToDoing);
            this.grpTasks.Controls.Add(this.btnBackToToDo);
            this.grpTasks.Controls.Add(this.btnDeleteTaskFromDone);
            this.grpTasks.Controls.Add(this.btnMoveToDone);
            this.grpTasks.Controls.Add(this.btnMoveToDoing);
            this.grpTasks.Controls.Add(this.lblDone);
            this.grpTasks.Controls.Add(this.lblDoing);
            this.grpTasks.Controls.Add(this.lblToDo);
            this.grpTasks.Controls.Add(this.lstDone);
            this.grpTasks.Controls.Add(this.lstDoing);
            this.grpTasks.Controls.Add(this.lstToDo);
            this.grpTasks.Location = new System.Drawing.Point(12, 131);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(528, 166);
            this.grpTasks.TabIndex = 1;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Tasks";
            // 
            // btnDeleteTaskFromDone
            // 
            this.btnDeleteTaskFromDone.Location = new System.Drawing.Point(442, 133);
            this.btnDeleteTaskFromDone.Name = "btnDeleteTaskFromDone";
            this.btnDeleteTaskFromDone.Size = new System.Drawing.Size(77, 23);
            this.btnDeleteTaskFromDone.TabIndex = 5;
            this.btnDeleteTaskFromDone.Text = "Delete task";
            this.btnDeleteTaskFromDone.UseVisualStyleBackColor = true;
            this.btnDeleteTaskFromDone.Click += new System.EventHandler(this.btnAllDeleteTask_Click);
            // 
            // btnMoveToDone
            // 
            this.btnMoveToDone.Location = new System.Drawing.Point(267, 133);
            this.btnMoveToDone.Name = "btnMoveToDone";
            this.btnMoveToDone.Size = new System.Drawing.Size(77, 23);
            this.btnMoveToDone.TabIndex = 3;
            this.btnMoveToDone.Text = "Next";
            this.btnMoveToDone.UseVisualStyleBackColor = true;
            this.btnMoveToDone.Click += new System.EventHandler(this.btnMoveToDone_Click);
            // 
            // btnMoveToDoing
            // 
            this.btnMoveToDoing.Location = new System.Drawing.Point(92, 133);
            this.btnMoveToDoing.Name = "btnMoveToDoing";
            this.btnMoveToDoing.Size = new System.Drawing.Size(77, 23);
            this.btnMoveToDoing.TabIndex = 1;
            this.btnMoveToDoing.Text = "Next";
            this.btnMoveToDoing.UseVisualStyleBackColor = true;
            this.btnMoveToDoing.Click += new System.EventHandler(this.btnMoveToDoing_Click);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(356, 16);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(36, 13);
            this.lblDone.TabIndex = 5;
            this.lblDone.Text = "Done:";
            // 
            // lblDoing
            // 
            this.lblDoing.AutoSize = true;
            this.lblDoing.Location = new System.Drawing.Point(181, 16);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(38, 13);
            this.lblDoing.TabIndex = 4;
            this.lblDoing.Text = "Doing:";
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(6, 16);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(38, 13);
            this.lblToDo.TabIndex = 3;
            this.lblToDo.Text = "To do:";
            // 
            // lstDone
            // 
            this.lstDone.AllowDrop = true;
            this.lstDone.FormattingEnabled = true;
            this.lstDone.Location = new System.Drawing.Point(359, 32);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(160, 95);
            this.lstDone.TabIndex = 4;
            this.lstDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAll_DragDrop);
            this.lstDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAll_DragEnter);
            this.lstDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseDown);
            this.lstDone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseMove);
            // 
            // lstDoing
            // 
            this.lstDoing.AllowDrop = true;
            this.lstDoing.FormattingEnabled = true;
            this.lstDoing.Location = new System.Drawing.Point(184, 32);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(160, 95);
            this.lstDoing.TabIndex = 2;
            this.lstDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAll_DragDrop);
            this.lstDoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAll_DragEnter);
            this.lstDoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseDown);
            this.lstDoing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseMove);
            // 
            // lstToDo
            // 
            this.lstToDo.AllowDrop = true;
            this.lstToDo.FormattingEnabled = true;
            this.lstToDo.Location = new System.Drawing.Point(9, 32);
            this.lstToDo.Name = "lstToDo";
            this.lstToDo.Size = new System.Drawing.Size(160, 95);
            this.lstToDo.TabIndex = 0;
            this.lstToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAll_DragDrop);
            this.lstToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAll_DragEnter);
            this.lstToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseDown);
            this.lstToDo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstAll_MouseMove);
            // 
            // grpNewTask
            // 
            this.grpNewTask.Controls.Add(this.btnAddTask);
            this.grpNewTask.Controls.Add(this.btnDeleteText);
            this.grpNewTask.Controls.Add(this.txtDescription);
            this.grpNewTask.Location = new System.Drawing.Point(12, 12);
            this.grpNewTask.Name = "grpNewTask";
            this.grpNewTask.Size = new System.Drawing.Size(376, 113);
            this.grpNewTask.TabIndex = 0;
            this.grpNewTask.TabStop = false;
            this.grpNewTask.Text = "New Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(292, 73);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteText
            // 
            this.btnDeleteText.Location = new System.Drawing.Point(292, 30);
            this.btnDeleteText.Name = "btnDeleteText";
            this.btnDeleteText.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteText.TabIndex = 1;
            this.btnDeleteText.Text = "Delete text";
            this.btnDeleteText.UseVisualStyleBackColor = true;
            this.btnDeleteText.Click += new System.EventHandler(this.btnDeleteText_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 19);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(280, 87);
            this.txtDescription.TabIndex = 0;
            // 
            // btnBackToToDo
            // 
            this.btnBackToToDo.Location = new System.Drawing.Point(184, 133);
            this.btnBackToToDo.Name = "btnBackToToDo";
            this.btnBackToToDo.Size = new System.Drawing.Size(77, 23);
            this.btnBackToToDo.TabIndex = 6;
            this.btnBackToToDo.Text = "Back";
            this.btnBackToToDo.UseVisualStyleBackColor = true;
            this.btnBackToToDo.Click += new System.EventHandler(this.btnBackToToDo_Click);
            // 
            // btnBackToDoing
            // 
            this.btnBackToDoing.Location = new System.Drawing.Point(359, 133);
            this.btnBackToDoing.Name = "btnBackToDoing";
            this.btnBackToDoing.Size = new System.Drawing.Size(77, 23);
            this.btnBackToDoing.TabIndex = 7;
            this.btnBackToDoing.Text = "Back";
            this.btnBackToDoing.UseVisualStyleBackColor = true;
            this.btnBackToDoing.Click += new System.EventHandler(this.btnBackToDoing_Click);
            // 
            // btnDeleteTaskFromToDo
            // 
            this.btnDeleteTaskFromToDo.Location = new System.Drawing.Point(9, 133);
            this.btnDeleteTaskFromToDo.Name = "btnDeleteTaskFromToDo";
            this.btnDeleteTaskFromToDo.Size = new System.Drawing.Size(77, 23);
            this.btnDeleteTaskFromToDo.TabIndex = 8;
            this.btnDeleteTaskFromToDo.Text = "Delete task";
            this.btnDeleteTaskFromToDo.UseVisualStyleBackColor = true;
            this.btnDeleteTaskFromToDo.Click += new System.EventHandler(this.btnAllDeleteTask_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 310);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 349);
            this.MinimumSize = new System.Drawing.Size(570, 349);
            this.Name = "FormMain";
            this.Text = "Kanban";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.grpTasks.ResumeLayout(false);
            this.grpTasks.PerformLayout();
            this.grpNewTask.ResumeLayout(false);
            this.grpNewTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.ListBox lstDoing;
        private System.Windows.Forms.ListBox lstToDo;
        private System.Windows.Forms.GroupBox grpNewTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteText;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Button btnDeleteTaskFromDone;
        private System.Windows.Forms.Button btnMoveToDone;
        private System.Windows.Forms.Button btnMoveToDoing;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.Button btnDeleteTaskFromToDo;
        private System.Windows.Forms.Button btnBackToDoing;
        private System.Windows.Forms.Button btnBackToToDo;
    }
}

