namespace SSH
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ipdbDataSet3 = new SSH.ipdbDataSet3();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ipdbDataSet = new SSH.ipdbDataSet();
            this.ipdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ipdbDataSet2 = new SSH.ipdbDataSet2();
            this.ipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ipTableAdapter = new SSH.ipdbDataSet2TableAdapters.ipTableAdapter();
            this.ipdbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ipTableAdapter1 = new SSH.ipdbDataSet3TableAdapters.ipTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSetBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "База";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.groupNameDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.Log_H,
            this.Pass_H});
            this.dataGridView1.DataSource = this.ipBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Check";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "Group_Name";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group_Name";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "Host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            // 
            // Log_H
            // 
            this.Log_H.DataPropertyName = "Log_H";
            this.Log_H.HeaderText = "Log_H";
            this.Log_H.Name = "Log_H";
            // 
            // Pass_H
            // 
            this.Pass_H.DataPropertyName = "Pass_H";
            this.Pass_H.HeaderText = "Pass_H";
            this.Pass_H.Name = "Pass_H";
            // 
            // ipBindingSource1
            // 
            this.ipBindingSource1.DataMember = "ip";
            this.ipBindingSource1.DataSource = this.ipdbDataSet3;
            // 
            // ipdbDataSet3
            // 
            this.ipdbDataSet3.DataSetName = "ipdbDataSet3";
            this.ipdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лог";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ipdbDataSet
            // 
            this.ipdbDataSet.DataSetName = "ipdbDataSet";
            this.ipdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ipdbDataSetBindingSource
            // 
            this.ipdbDataSetBindingSource.DataSource = this.ipdbDataSet;
            this.ipdbDataSetBindingSource.Position = 0;
            // 
            // ipdbDataSet2
            // 
            this.ipdbDataSet2.DataSetName = "ipdbDataSet2";
            this.ipdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ipBindingSource
            // 
            this.ipBindingSource.DataMember = "ip";
            this.ipBindingSource.DataSource = this.ipdbDataSet2;
            // 
            // ipTableAdapter
            // 
            this.ipTableAdapter.ClearBeforeFill = true;
            // 
            // ipdbDataSetBindingSource1
            // 
            this.ipdbDataSetBindingSource1.DataSource = this.ipdbDataSet;
            this.ipdbDataSetBindingSource1.Position = 0;
            // 
            // ipTableAdapter1
            // 
            this.ipTableAdapter1.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(276, 404);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(357, 404);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(174, 404);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(96, 23);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Фильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(541, 421);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 88);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(438, 404);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLog.TabIndex = 6;
            this.btnSaveLog.Text = "В лог";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 404);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Запустить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 404);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Остановить";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Список команд";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "SSHHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipdbDataSetBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ipdbDataSetBindingSource;
        private ipdbDataSet ipdbDataSet;
        private ipdbDataSet2 ipdbDataSet2;
        private System.Windows.Forms.BindingSource ipBindingSource;
        private ipdbDataSet2TableAdapters.ipTableAdapter ipTableAdapter;
        private System.Windows.Forms.BindingSource ipdbDataSetBindingSource1;
        private ipdbDataSet3 ipdbDataSet3;
        private System.Windows.Forms.BindingSource ipBindingSource1;
        private ipdbDataSet3TableAdapters.ipTableAdapter ipTableAdapter1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass_H;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

