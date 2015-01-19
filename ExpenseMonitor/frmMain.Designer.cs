namespace ExpenseMonitor
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogImportExpense = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelTotalAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabFirstLevel = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearFind = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoryFind = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFindAmount = new System.Windows.Forms.TextBox();
            this.txtDescFind = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dateFindTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFindFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateExpense = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.datagridExpense = new System.Windows.Forms.DataGridView();
            this.expenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabSecondLevel = new System.Windows.Forms.TabControl();
            this.tabReportsSummary = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chartSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioReportsSummaryLast12 = new System.Windows.Forms.RadioButton();
            this.radioReportsSummaryLast3 = new System.Windows.Forms.RadioButton();
            this.radioReportsSummaryLast6 = new System.Windows.Forms.RadioButton();
            this.radioReportsSummaryMonthly = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevMonthlyReports = new System.Windows.Forms.Button();
            this.cmbMonthsMonthlyReport = new System.Windows.Forms.ComboBox();
            this.btnNextMonthlyReports = new System.Windows.Forms.Button();
            this.cmbYearsMonthlyReport = new System.Windows.Forms.ComboBox();
            this.chkMonthlyTabInitialized = new System.Windows.Forms.CheckBox();
            this.dataGridCatgTotalsMonthlyReport = new System.Windows.Forms.DataGridView();
            this.catgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridExpenseMonthlyReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.expenseGridContextMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabFirstLevel.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExpense)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabSecondLevel.SuspendLayout();
            this.tabReportsSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatgTotalsMonthlyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenseMonthlyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importExpensesToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportExpensesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importExpensesToolStripMenuItem
            // 
            this.importExpensesToolStripMenuItem.Name = "importExpensesToolStripMenuItem";
            this.importExpensesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.importExpensesToolStripMenuItem.Text = "Import Expense Records";
            this.importExpensesToolStripMenuItem.Click += new System.EventHandler(this.importExpensesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // exportExpensesToolStripMenuItem
            // 
            this.exportExpensesToolStripMenuItem.Name = "exportExpensesToolStripMenuItem";
            this.exportExpensesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exportExpensesToolStripMenuItem.Text = "Export Expenses Records";
            this.exportExpensesToolStripMenuItem.Click += new System.EventHandler(this.exportExpensesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.toolsToolStripMenuItem.Text = "Admin";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.categoryToolStripMenuItem.Text = "Edit Categories";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRecentLogFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openRecentLogFileToolStripMenuItem
            // 
            this.openRecentLogFileToolStripMenuItem.Name = "openRecentLogFileToolStripMenuItem";
            this.openRecentLogFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openRecentLogFileToolStripMenuItem.Text = "Open Recent Log File";
            this.openRecentLogFileToolStripMenuItem.Click += new System.EventHandler(this.openRecentLogFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // expenseGridContextMenu
            // 
            this.expenseGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.expenseGridContextMenu.Name = "expenseGridContextMenu";
            this.expenseGridContextMenu.Size = new System.Drawing.Size(108, 26);
            this.expenseGridContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.expenseGridContextMenu_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Delete";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 20);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 17);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 17);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 17);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelRecordCount,
            this.toolStripStatusLabel2,
            this.statusLabelTotalAmount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelRecordCount
            // 
            this.statusLabelRecordCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusLabelRecordCount.Name = "statusLabelRecordCount";
            this.statusLabelRecordCount.Size = new System.Drawing.Size(130, 17);
            this.statusLabelRecordCount.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(687, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // statusLabelTotalAmount
            // 
            this.statusLabelTotalAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusLabelTotalAmount.Name = "statusLabelTotalAmount";
            this.statusLabelTotalAmount.Size = new System.Drawing.Size(130, 17);
            this.statusLabelTotalAmount.Text = "toolStripStatusLabel3";
            // 
            // tabFirstLevel
            // 
            this.tabFirstLevel.Controls.Add(this.tabMain);
            this.tabFirstLevel.Controls.Add(this.tabReports);
            this.tabFirstLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFirstLevel.Location = new System.Drawing.Point(0, 24);
            this.tabFirstLevel.Name = "tabFirstLevel";
            this.tabFirstLevel.SelectedIndex = 0;
            this.tabFirstLevel.Size = new System.Drawing.Size(962, 567);
            this.tabFirstLevel.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.AutoScroll = true;
            this.tabMain.Controls.Add(this.splitContainer1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(954, 541);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "   Main   ";
            this.tabMain.UseVisualStyleBackColor = true;
            this.tabMain.Enter += new System.EventHandler(this.tabMain_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1MinSize = 240;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.datagridExpense);
            this.splitContainer1.Size = new System.Drawing.Size(948, 535);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearFind);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(535, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(362, 217);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find an Expense";
            // 
            // btnClearFind
            // 
            this.btnClearFind.Location = new System.Drawing.Point(256, 188);
            this.btnClearFind.Name = "btnClearFind";
            this.btnClearFind.Size = new System.Drawing.Size(75, 23);
            this.btnClearFind.TabIndex = 12;
            this.btnClearFind.Text = "Clear";
            this.btnClearFind.UseVisualStyleBackColor = true;
            this.btnClearFind.Click += new System.EventHandler(this.btnClearFind_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(167, 188);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbCategoryFind, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtFindAmount, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDescFind, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 160);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "From Date";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Category";
            // 
            // cmbCategoryFind
            // 
            this.cmbCategoryFind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCategoryFind.DisplayMember = "description";
            this.cmbCategoryFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFind.FormattingEnabled = true;
            this.cmbCategoryFind.Location = new System.Drawing.Point(69, 34);
            this.cmbCategoryFind.MaxDropDownItems = 20;
            this.cmbCategoryFind.Name = "cmbCategoryFind";
            this.cmbCategoryFind.Size = new System.Drawing.Size(254, 21);
            this.cmbCategoryFind.TabIndex = 2;
            this.cmbCategoryFind.Tag = "";
            this.cmbCategoryFind.ValueMember = "id";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Amount";
            // 
            // txtFindAmount
            // 
            this.txtFindAmount.Location = new System.Drawing.Point(69, 133);
            this.txtFindAmount.MaxLength = 12;
            this.txtFindAmount.Name = "txtFindAmount";
            this.txtFindAmount.Size = new System.Drawing.Size(97, 20);
            this.txtFindAmount.TabIndex = 7;
            // 
            // txtDescFind
            // 
            this.txtDescFind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescFind.Location = new System.Drawing.Point(69, 64);
            this.txtDescFind.MaxLength = 255;
            this.txtDescFind.Multiline = true;
            this.txtDescFind.Name = "txtDescFind";
            this.txtDescFind.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescFind.Size = new System.Drawing.Size(254, 61);
            this.txtDescFind.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.85567F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52577F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.61856F));
            this.tableLayoutPanel3.Controls.Add(this.dateFindTo, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateFindFrom, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(68, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(291, 25);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // dateFindTo
            // 
            this.dateFindTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateFindTo.CustomFormat = "dd-MMM-yyyy";
            this.dateFindTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFindTo.Location = new System.Drawing.Point(160, 3);
            this.dateFindTo.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateFindTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFindTo.Name = "dateFindTo";
            this.dateFindTo.Size = new System.Drawing.Size(94, 20);
            this.dateFindTo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "To Date";
            // 
            // dateFindFrom
            // 
            this.dateFindFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateFindFrom.CustomFormat = "dd-MMM-yyyy";
            this.dateFindFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFindFrom.Location = new System.Drawing.Point(3, 3);
            this.dateFindFrom.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateFindFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFindFrom.Name = "dateFindFrom";
            this.dateFindFrom.Size = new System.Drawing.Size(97, 20);
            this.dateFindFrom.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(462, 217);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add an Expense";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateExpense, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateCategory, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dateExpense
            // 
            this.dateExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateExpense.CustomFormat = "dd-MMM-yyyy";
            this.dateExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExpense.Location = new System.Drawing.Point(69, 5);
            this.dateExpense.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateExpense.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateExpense.Name = "dateExpense";
            this.dateExpense.Size = new System.Drawing.Size(97, 20);
            this.dateExpense.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCategory.DisplayMember = "description";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(69, 34);
            this.cmbCategory.MaxDropDownItems = 20;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(254, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.Tag = "";
            this.cmbCategory.ValueMember = "id";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDesc.Location = new System.Drawing.Point(69, 64);
            this.txtDesc.MaxLength = 255;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(254, 61);
            this.txtDesc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(335, 33);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(112, 23);
            this.btnCreateCategory.TabIndex = 3;
            this.btnCreateCategory.Text = "Create New Category";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(69, 133);
            this.txtAmount.MaxLength = 12;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(97, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(164, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(251, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // datagridExpense
            // 
            this.datagridExpense.AllowUserToAddRows = false;
            this.datagridExpense.AllowUserToDeleteRows = false;
            this.datagridExpense.AllowUserToResizeRows = false;
            this.datagridExpense.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datagridExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expenseDate,
            this.category,
            this.description,
            this.amount});
            this.datagridExpense.ContextMenuStrip = this.expenseGridContextMenu;
            this.datagridExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridExpense.Location = new System.Drawing.Point(0, 0);
            this.datagridExpense.MultiSelect = false;
            this.datagridExpense.Name = "datagridExpense";
            this.datagridExpense.ReadOnly = true;
            this.datagridExpense.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridExpense.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridExpense.RowTemplate.Height = 24;
            this.datagridExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridExpense.Size = new System.Drawing.Size(946, 289);
            this.datagridExpense.TabIndex = 40;
            // 
            // expenseDate
            // 
            this.expenseDate.DataPropertyName = "expense_date";
            this.expenseDate.HeaderText = "Date";
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "description";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 200;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "expense_description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "expense_amount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabSecondLevel);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(954, 541);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            this.tabReports.Enter += new System.EventHandler(this.tabReports_Enter);
            // 
            // tabSecondLevel
            // 
            this.tabSecondLevel.Controls.Add(this.tabReportsSummary);
            this.tabSecondLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSecondLevel.Location = new System.Drawing.Point(3, 3);
            this.tabSecondLevel.Margin = new System.Windows.Forms.Padding(2);
            this.tabSecondLevel.Name = "tabSecondLevel";
            this.tabSecondLevel.SelectedIndex = 0;
            this.tabSecondLevel.Size = new System.Drawing.Size(948, 535);
            this.tabSecondLevel.TabIndex = 1;
            // 
            // tabReportsSummary
            // 
            this.tabReportsSummary.Controls.Add(this.splitContainer2);
            this.tabReportsSummary.Location = new System.Drawing.Point(4, 22);
            this.tabReportsSummary.Margin = new System.Windows.Forms.Padding(2);
            this.tabReportsSummary.Name = "tabReportsSummary";
            this.tabReportsSummary.Padding = new System.Windows.Forms.Padding(2);
            this.tabReportsSummary.Size = new System.Drawing.Size(940, 509);
            this.tabReportsSummary.TabIndex = 0;
            this.tabReportsSummary.Text = "Summary";
            this.tabReportsSummary.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(2, 2);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.Controls.Add(this.chkMonthlyTabInitialized);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridCatgTotalsMonthlyReport);
            this.splitContainer2.Panel1MinSize = 400;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridExpenseMonthlyReport);
            this.splitContainer2.Size = new System.Drawing.Size(936, 505);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chartSummary);
            this.groupBox5.Location = new System.Drawing.Point(336, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(592, 291);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Top 7 categories";
            // 
            // chartSummary
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSummary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSummary.Legends.Add(legend1);
            this.chartSummary.Location = new System.Drawing.Point(7, 20);
            this.chartSummary.Name = "chartSummary";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSummary.Series.Add(series1);
            this.chartSummary.Size = new System.Drawing.Size(579, 265);
            this.chartSummary.TabIndex = 0;
            this.chartSummary.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioReportsSummaryLast12);
            this.groupBox3.Controls.Add(this.radioReportsSummaryLast3);
            this.groupBox3.Controls.Add(this.radioReportsSummaryLast6);
            this.groupBox3.Controls.Add(this.radioReportsSummaryMonthly);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(336, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(592, 82);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select the criteria";
            // 
            // radioReportsSummaryLast12
            // 
            this.radioReportsSummaryLast12.AutoSize = true;
            this.radioReportsSummaryLast12.Location = new System.Drawing.Point(494, 41);
            this.radioReportsSummaryLast12.Margin = new System.Windows.Forms.Padding(2);
            this.radioReportsSummaryLast12.Name = "radioReportsSummaryLast12";
            this.radioReportsSummaryLast12.Size = new System.Drawing.Size(98, 17);
            this.radioReportsSummaryLast12.TabIndex = 12;
            this.radioReportsSummaryLast12.Text = "Last 12 Months";
            this.radioReportsSummaryLast12.UseVisualStyleBackColor = true;
            this.radioReportsSummaryLast12.CheckedChanged += new System.EventHandler(this.radioReportsSummaryLast12_CheckedChanged);
            // 
            // radioReportsSummaryLast3
            // 
            this.radioReportsSummaryLast3.AutoSize = true;
            this.radioReportsSummaryLast3.Location = new System.Drawing.Point(304, 41);
            this.radioReportsSummaryLast3.Margin = new System.Windows.Forms.Padding(2);
            this.radioReportsSummaryLast3.Name = "radioReportsSummaryLast3";
            this.radioReportsSummaryLast3.Size = new System.Drawing.Size(92, 17);
            this.radioReportsSummaryLast3.TabIndex = 9;
            this.radioReportsSummaryLast3.Text = "Last 3 Months";
            this.radioReportsSummaryLast3.UseVisualStyleBackColor = true;
            this.radioReportsSummaryLast3.CheckedChanged += new System.EventHandler(this.radioReportsSummaryLast3_CheckedChanged);
            // 
            // radioReportsSummaryLast6
            // 
            this.radioReportsSummaryLast6.AutoSize = true;
            this.radioReportsSummaryLast6.Location = new System.Drawing.Point(398, 41);
            this.radioReportsSummaryLast6.Margin = new System.Windows.Forms.Padding(2);
            this.radioReportsSummaryLast6.Name = "radioReportsSummaryLast6";
            this.radioReportsSummaryLast6.Size = new System.Drawing.Size(92, 17);
            this.radioReportsSummaryLast6.TabIndex = 10;
            this.radioReportsSummaryLast6.Text = "Last 6 Months";
            this.radioReportsSummaryLast6.UseVisualStyleBackColor = true;
            this.radioReportsSummaryLast6.CheckedChanged += new System.EventHandler(this.radioReportsSummaryLast6_CheckedChanged);
            // 
            // radioReportsSummaryMonthly
            // 
            this.radioReportsSummaryMonthly.AutoSize = true;
            this.radioReportsSummaryMonthly.Checked = true;
            this.radioReportsSummaryMonthly.Location = new System.Drawing.Point(14, 41);
            this.radioReportsSummaryMonthly.Margin = new System.Windows.Forms.Padding(2);
            this.radioReportsSummaryMonthly.Name = "radioReportsSummaryMonthly";
            this.radioReportsSummaryMonthly.Size = new System.Drawing.Size(14, 13);
            this.radioReportsSummaryMonthly.TabIndex = 7;
            this.radioReportsSummaryMonthly.TabStop = true;
            this.radioReportsSummaryMonthly.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(32, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(267, 50);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monthly Report";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel4.Controls.Add(this.btnPrevMonthlyReports, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbMonthsMonthlyReport, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNextMonthlyReports, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbYearsMonthlyReport, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 16);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(246, 28);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnPrevMonthlyReports
            // 
            this.btnPrevMonthlyReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevMonthlyReports.Location = new System.Drawing.Point(80, 4);
            this.btnPrevMonthlyReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevMonthlyReports.Name = "btnPrevMonthlyReports";
            this.btnPrevMonthlyReports.Size = new System.Drawing.Size(37, 20);
            this.btnPrevMonthlyReports.TabIndex = 5;
            this.btnPrevMonthlyReports.Text = "<<";
            this.btnPrevMonthlyReports.UseVisualStyleBackColor = true;
            this.btnPrevMonthlyReports.Click += new System.EventHandler(this.btnPrevMonthlyReports_Click);
            // 
            // cmbMonthsMonthlyReport
            // 
            this.cmbMonthsMonthlyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonthsMonthlyReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthsMonthlyReport.FormattingEnabled = true;
            this.cmbMonthsMonthlyReport.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonthsMonthlyReport.Location = new System.Drawing.Point(121, 3);
            this.cmbMonthsMonthlyReport.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonthsMonthlyReport.MaxDropDownItems = 12;
            this.cmbMonthsMonthlyReport.Name = "cmbMonthsMonthlyReport";
            this.cmbMonthsMonthlyReport.Size = new System.Drawing.Size(81, 21);
            this.cmbMonthsMonthlyReport.TabIndex = 2;
            this.cmbMonthsMonthlyReport.SelectedIndexChanged += new System.EventHandler(this.cmbMonthsMonthlyReport_SelectedIndexChanged);
            // 
            // btnNextMonthlyReports
            // 
            this.btnNextMonthlyReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextMonthlyReports.Location = new System.Drawing.Point(206, 4);
            this.btnNextMonthlyReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextMonthlyReports.Name = "btnNextMonthlyReports";
            this.btnNextMonthlyReports.Size = new System.Drawing.Size(38, 20);
            this.btnNextMonthlyReports.TabIndex = 4;
            this.btnNextMonthlyReports.Text = ">>";
            this.btnNextMonthlyReports.UseVisualStyleBackColor = true;
            this.btnNextMonthlyReports.Click += new System.EventHandler(this.btnNextMonthlyReports_Click);
            // 
            // cmbYearsMonthlyReport
            // 
            this.cmbYearsMonthlyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYearsMonthlyReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearsMonthlyReport.FormattingEnabled = true;
            this.cmbYearsMonthlyReport.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbYearsMonthlyReport.Location = new System.Drawing.Point(2, 3);
            this.cmbYearsMonthlyReport.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYearsMonthlyReport.Name = "cmbYearsMonthlyReport";
            this.cmbYearsMonthlyReport.Size = new System.Drawing.Size(59, 21);
            this.cmbYearsMonthlyReport.TabIndex = 3;
            this.cmbYearsMonthlyReport.SelectedIndexChanged += new System.EventHandler(this.cmbYearsMonthlyReport_SelectedIndexChanged);
            // 
            // chkMonthlyTabInitialized
            // 
            this.chkMonthlyTabInitialized.AutoSize = true;
            this.chkMonthlyTabInitialized.Location = new System.Drawing.Point(195, 2);
            this.chkMonthlyTabInitialized.Margin = new System.Windows.Forms.Padding(2);
            this.chkMonthlyTabInitialized.Name = "chkMonthlyTabInitialized";
            this.chkMonthlyTabInitialized.Size = new System.Drawing.Size(143, 17);
            this.chkMonthlyTabInitialized.TabIndex = 2;
            this.chkMonthlyTabInitialized.Text = "chkMonthlyTabInitialized";
            this.chkMonthlyTabInitialized.UseVisualStyleBackColor = true;
            this.chkMonthlyTabInitialized.Visible = false;
            // 
            // dataGridCatgTotalsMonthlyReport
            // 
            this.dataGridCatgTotalsMonthlyReport.AllowUserToAddRows = false;
            this.dataGridCatgTotalsMonthlyReport.AllowUserToDeleteRows = false;
            this.dataGridCatgTotalsMonthlyReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridCatgTotalsMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCatgTotalsMonthlyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catgColumn,
            this.totalColumn});
            this.dataGridCatgTotalsMonthlyReport.Location = new System.Drawing.Point(2, 13);
            this.dataGridCatgTotalsMonthlyReport.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCatgTotalsMonthlyReport.MultiSelect = false;
            this.dataGridCatgTotalsMonthlyReport.Name = "dataGridCatgTotalsMonthlyReport";
            this.dataGridCatgTotalsMonthlyReport.ReadOnly = true;
            this.dataGridCatgTotalsMonthlyReport.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCatgTotalsMonthlyReport.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCatgTotalsMonthlyReport.RowTemplate.Height = 24;
            this.dataGridCatgTotalsMonthlyReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCatgTotalsMonthlyReport.Size = new System.Drawing.Size(321, 378);
            this.dataGridCatgTotalsMonthlyReport.TabIndex = 1;
            // 
            // catgColumn
            // 
            this.catgColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catgColumn.DataPropertyName = "category";
            this.catgColumn.HeaderText = "Top Categories";
            this.catgColumn.MinimumWidth = 200;
            this.catgColumn.Name = "catgColumn";
            this.catgColumn.ReadOnly = true;
            // 
            // totalColumn
            // 
            this.totalColumn.DataPropertyName = "total";
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.MinimumWidth = 100;
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
            // 
            // dataGridExpenseMonthlyReport
            // 
            this.dataGridExpenseMonthlyReport.AllowUserToAddRows = false;
            this.dataGridExpenseMonthlyReport.AllowUserToDeleteRows = false;
            this.dataGridExpenseMonthlyReport.AllowUserToResizeRows = false;
            this.dataGridExpenseMonthlyReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridExpenseMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExpenseMonthlyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridExpenseMonthlyReport.ContextMenuStrip = this.expenseGridContextMenu;
            this.dataGridExpenseMonthlyReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridExpenseMonthlyReport.Location = new System.Drawing.Point(0, 0);
            this.dataGridExpenseMonthlyReport.MultiSelect = false;
            this.dataGridExpenseMonthlyReport.Name = "dataGridExpenseMonthlyReport";
            this.dataGridExpenseMonthlyReport.ReadOnly = true;
            this.dataGridExpenseMonthlyReport.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridExpenseMonthlyReport.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridExpenseMonthlyReport.RowTemplate.Height = 24;
            this.dataGridExpenseMonthlyReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExpenseMonthlyReport.Size = new System.Drawing.Size(936, 102);
            this.dataGridExpenseMonthlyReport.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "expense_date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "expense_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "expense_amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.FileName = "exported_expenses.xls";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.tabFirstLevel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(970, 647);
            this.Name = "frmMain";
            this.Text = "Expense Monitor 2009";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.expenseGridContextMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabFirstLevel.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExpense)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabSecondLevel.ResumeLayout(false);
            this.tabReportsSummary.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatgTotalsMonthlyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenseMonthlyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ContextMenuStrip expenseGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportExpense;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTotalAmount;
        private System.Windows.Forms.TabControl tabFirstLevel;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategoryFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFindAmount;
        private System.Windows.Forms.TextBox txtDescFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dateFindTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFindFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView datagridExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabControl tabSecondLevel;
        private System.Windows.Forms.TabPage tabReportsSummary;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioReportsSummaryLast12;
        private System.Windows.Forms.RadioButton radioReportsSummaryLast3;
        private System.Windows.Forms.RadioButton radioReportsSummaryLast6;
        private System.Windows.Forms.RadioButton radioReportsSummaryMonthly;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnPrevMonthlyReports;
        private System.Windows.Forms.ComboBox cmbMonthsMonthlyReport;
        private System.Windows.Forms.Button btnNextMonthlyReports;
        private System.Windows.Forms.ComboBox cmbYearsMonthlyReport;
        private System.Windows.Forms.CheckBox chkMonthlyTabInitialized;
        private System.Windows.Forms.DataGridView dataGridCatgTotalsMonthlyReport;
        private System.Windows.Forms.DataGridView dataGridExpenseMonthlyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem openRecentLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn catgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSummary;
    }
}

