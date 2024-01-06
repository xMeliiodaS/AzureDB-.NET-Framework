
namespace WindowsFormsApp1
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
            this.tabControl_ImmediateActivities = new System.Windows.Forms.TabControl();
            this.tabPageCloudKeys = new System.Windows.Forms.TabPage();
            this.linkLabel_AzureUI = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ConnectionSource = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.btn_DisposeClient = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_CreateClient = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PrimaryKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_EndPointUri = new System.Windows.Forms.TextBox();
            this.tabPage_DatabasesAndTables = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CheckIfTableExists = new System.Windows.Forms.Button();
            this.textBox_IsTableExists = new System.Windows.Forms.TextBox();
            this.textBox_TableToChk = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkIfExists = new System.Windows.Forms.Button();
            this.textBox_IsDatabaseExists = new System.Windows.Forms.TextBox();
            this.textBox_userDB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_DelSelectedTable = new System.Windows.Forms.Button();
            this.btn_DelSelectedDB = new System.Windows.Forms.Button();
            this.btn_RefreshTableList = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_CloudTables = new System.Windows.Forms.ComboBox();
            this.btn_RefreshDatabases = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_CloudDatabase = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CreateInCloud = new System.Windows.Forms.Button();
            this.textBox_tableName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_DatabaseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageActivityLog = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox_ExceptionDuringLastActivity = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_LastActivityDateTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_LastActivity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_additionalDBandTables = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_DBsWithAtLeastXtables = new System.Windows.Forms.ComboBox();
            this.btn_GetDBsWithAtLeastXtables = new System.Windows.Forms.Button();
            this.textBox_MinNumOfTables = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_GetDBThatContainsTablesWithMyUserName = new System.Windows.Forms.Button();
            this.comboBox_GetDBContainsTablesWithMyUserName = new System.Windows.Forms.ComboBox();
            this.tabPage_DataActivities = new System.Windows.Forms.TabPage();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_SelectedTableName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_SelectedDatabaseName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_UpdateCloudWithSelectedActivity = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tab_MoreTirgul = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteAllDBsInCloud = new System.Windows.Forms.Button();
            this.btn_GetNumOfTables = new System.Windows.Forms.Button();
            this.textBox_NumOfTables = new System.Windows.Forms.TextBox();
            this.btn_GetNumOfDBs = new System.Windows.Forms.Button();
            this.textBox_NumOfDatabases = new System.Windows.Forms.TextBox();
            this.tabPage_DataImmiedateActivities = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_ExecuteFilter = new System.Windows.Forms.Button();
            this.textBox_CityFilter = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_CourseNameFilter = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_FirstNameFilter = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_CheckTable = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_CheckDB = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.richTextBox_FullRecord = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_ChkIfItemIdExists = new System.Windows.Forms.Button();
            this.textBox_IdToChkInCloud = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.richTextBox_Filter = new System.Windows.Forms.RichTextBox();
            this.textBox_SelectedTable3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_selectedDB3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_DefineFilter = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btn_GetFinalEx = new System.Windows.Forms.Button();
            this.textBox_firstNameLength = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox_TableStartsWith = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox_DBendsWith = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.dataGridView_LastEx = new System.Windows.Forms.DataGridView();
            this.richTextBox_Last = new System.Windows.Forms.RichTextBox();
            this.textBox_TableLast = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_DBLast = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btn_ExecuteFilterLast = new System.Windows.Forms.Button();
            this.textBox_CityStartsWith = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox_MinCoursesNum = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox_FirstNameContains = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.issCreated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl_ImmediateActivities.SuspendLayout();
            this.tabPageCloudKeys.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_DatabasesAndTables.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageActivityLog.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage_additionalDBandTables.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage_DataActivities.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tab_MoreTirgul.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage_DataImmiedateActivities.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LastEx)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_ImmediateActivities
            // 
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPageCloudKeys);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPage_DatabasesAndTables);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPageActivityLog);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPage_additionalDBandTables);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPage_DataActivities);
            this.tabControl_ImmediateActivities.Controls.Add(this.tab_MoreTirgul);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPage_DataImmiedateActivities);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPage1);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPage2);
            this.tabControl_ImmediateActivities.Controls.Add(this.tabPage3);
            this.tabControl_ImmediateActivities.Location = new System.Drawing.Point(12, 42);
            this.tabControl_ImmediateActivities.Name = "tabControl_ImmediateActivities";
            this.tabControl_ImmediateActivities.SelectedIndex = 0;
            this.tabControl_ImmediateActivities.Size = new System.Drawing.Size(986, 661);
            this.tabControl_ImmediateActivities.TabIndex = 1;
            // 
            // tabPageCloudKeys
            // 
            this.tabPageCloudKeys.Controls.Add(this.linkLabel_AzureUI);
            this.tabPageCloudKeys.Controls.Add(this.label12);
            this.tabPageCloudKeys.Controls.Add(this.groupBox2);
            this.tabPageCloudKeys.Controls.Add(this.label2);
            this.tabPageCloudKeys.Controls.Add(this.textBox_PrimaryKey);
            this.tabPageCloudKeys.Controls.Add(this.label1);
            this.tabPageCloudKeys.Controls.Add(this.textBox_EndPointUri);
            this.tabPageCloudKeys.Location = new System.Drawing.Point(4, 25);
            this.tabPageCloudKeys.Name = "tabPageCloudKeys";
            this.tabPageCloudKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCloudKeys.Size = new System.Drawing.Size(978, 632);
            this.tabPageCloudKeys.TabIndex = 0;
            this.tabPageCloudKeys.Text = "Cloud Keys and Client Creation";
            this.tabPageCloudKeys.UseVisualStyleBackColor = true;
            // 
            // linkLabel_AzureUI
            // 
            this.linkLabel_AzureUI.AutoSize = true;
            this.linkLabel_AzureUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel_AzureUI.Location = new System.Drawing.Point(219, 162);
            this.linkLabel_AzureUI.Name = "linkLabel_AzureUI";
            this.linkLabel_AzureUI.Size = new System.Drawing.Size(323, 20);
            this.linkLabel_AzureUI.TabIndex = 14;
            this.linkLabel_AzureUI.TabStop = true;
            this.linkLabel_AzureUI.Text = "https://localhost:8081/_explorer/index.html";
            this.linkLabel_AzureUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AzureUI_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(32, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = ":Relevant Link";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_ConnectionSource);
            this.groupBox2.Controls.Add(this.textBox_ID);
            this.groupBox2.Controls.Add(this.btn_DisposeClient);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_CreateClient);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(966, 122);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(32, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = ":ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(673, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Connection Source:";
            // 
            // textBox_ConnectionSource
            // 
            this.textBox_ConnectionSource.Location = new System.Drawing.Point(860, 54);
            this.textBox_ConnectionSource.Name = "textBox_ConnectionSource";
            this.textBox_ConnectionSource.ReadOnly = true;
            this.textBox_ConnectionSource.Size = new System.Drawing.Size(100, 22);
            this.textBox_ConnectionSource.TabIndex = 6;
            this.textBox_ConnectionSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(213, 25);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(248, 22);
            this.textBox_ID.TabIndex = 11;
            this.textBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_DisposeClient
            // 
            this.btn_DisposeClient.Enabled = false;
            this.btn_DisposeClient.Location = new System.Drawing.Point(498, 66);
            this.btn_DisposeClient.Name = "btn_DisposeClient";
            this.btn_DisposeClient.Size = new System.Drawing.Size(169, 49);
            this.btn_DisposeClient.TabIndex = 11;
            this.btn_DisposeClient.Text = "Dispose COSMOS Client";
            this.btn_DisposeClient.UseVisualStyleBackColor = true;
            this.btn_DisposeClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(32, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = ":Name";
            // 
            // btn_CreateClient
            // 
            this.btn_CreateClient.Location = new System.Drawing.Point(498, 12);
            this.btn_CreateClient.Name = "btn_CreateClient";
            this.btn_CreateClient.Size = new System.Drawing.Size(169, 49);
            this.btn_CreateClient.TabIndex = 4;
            this.btn_CreateClient.Text = "Create COSMOS Client";
            this.btn_CreateClient.UseVisualStyleBackColor = true;
            this.btn_CreateClient.Click += new System.EventHandler(this.btn_CreateClient_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(213, 79);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(248, 22);
            this.textBox_Name.TabIndex = 9;
            this.textBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(32, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = ":Primary Key";
            // 
            // textBox_PrimaryKey
            // 
            this.textBox_PrimaryKey.Location = new System.Drawing.Point(219, 291);
            this.textBox_PrimaryKey.Name = "textBox_PrimaryKey";
            this.textBox_PrimaryKey.ReadOnly = true;
            this.textBox_PrimaryKey.Size = new System.Drawing.Size(706, 22);
            this.textBox_PrimaryKey.TabIndex = 2;
            this.textBox_PrimaryKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(32, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = ":End Point URI";
            // 
            // textBox_EndPointUri
            // 
            this.textBox_EndPointUri.Location = new System.Drawing.Point(219, 219);
            this.textBox_EndPointUri.Name = "textBox_EndPointUri";
            this.textBox_EndPointUri.ReadOnly = true;
            this.textBox_EndPointUri.Size = new System.Drawing.Size(706, 22);
            this.textBox_EndPointUri.TabIndex = 0;
            this.textBox_EndPointUri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage_DatabasesAndTables
            // 
            this.tabPage_DatabasesAndTables.Controls.Add(this.panel2);
            this.tabPage_DatabasesAndTables.Controls.Add(this.panel1);
            this.tabPage_DatabasesAndTables.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DatabasesAndTables.Name = "tabPage_DatabasesAndTables";
            this.tabPage_DatabasesAndTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DatabasesAndTables.Size = new System.Drawing.Size(978, 632);
            this.tabPage_DatabasesAndTables.TabIndex = 1;
            this.tabPage_DatabasesAndTables.Text = "Databases and Tables";
            this.tabPage_DatabasesAndTables.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_CheckIfTableExists);
            this.panel2.Controls.Add(this.textBox_IsTableExists);
            this.panel2.Controls.Add(this.textBox_TableToChk);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.checkIfExists);
            this.panel2.Controls.Add(this.textBox_IsDatabaseExists);
            this.panel2.Controls.Add(this.textBox_userDB);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(43, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 103);
            this.panel2.TabIndex = 1;
            // 
            // btn_CheckIfTableExists
            // 
            this.btn_CheckIfTableExists.Location = new System.Drawing.Point(296, 57);
            this.btn_CheckIfTableExists.Name = "btn_CheckIfTableExists";
            this.btn_CheckIfTableExists.Size = new System.Drawing.Size(149, 36);
            this.btn_CheckIfTableExists.TabIndex = 8;
            this.btn_CheckIfTableExists.Text = "Check if Exists";
            this.btn_CheckIfTableExists.UseVisualStyleBackColor = true;
            this.btn_CheckIfTableExists.Click += new System.EventHandler(this.btn_CheckIfTableExists_Click);
            // 
            // textBox_IsTableExists
            // 
            this.textBox_IsTableExists.Location = new System.Drawing.Point(451, 64);
            this.textBox_IsTableExists.Name = "textBox_IsTableExists";
            this.textBox_IsTableExists.Size = new System.Drawing.Size(81, 22);
            this.textBox_IsTableExists.TabIndex = 11;
            // 
            // textBox_TableToChk
            // 
            this.textBox_TableToChk.Location = new System.Drawing.Point(114, 64);
            this.textBox_TableToChk.Name = "textBox_TableToChk";
            this.textBox_TableToChk.Size = new System.Drawing.Size(176, 22);
            this.textBox_TableToChk.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(22, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = ":Table";
            // 
            // checkIfExists
            // 
            this.checkIfExists.Location = new System.Drawing.Point(296, 14);
            this.checkIfExists.Name = "checkIfExists";
            this.checkIfExists.Size = new System.Drawing.Size(149, 36);
            this.checkIfExists.TabIndex = 5;
            this.checkIfExists.Text = "Check if Exists";
            this.checkIfExists.UseVisualStyleBackColor = true;
            this.checkIfExists.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_IsDatabaseExists
            // 
            this.textBox_IsDatabaseExists.Location = new System.Drawing.Point(451, 21);
            this.textBox_IsDatabaseExists.Name = "textBox_IsDatabaseExists";
            this.textBox_IsDatabaseExists.Size = new System.Drawing.Size(81, 22);
            this.textBox_IsDatabaseExists.TabIndex = 7;
            // 
            // textBox_userDB
            // 
            this.textBox_userDB.Location = new System.Drawing.Point(114, 21);
            this.textBox_userDB.Name = "textBox_userDB";
            this.textBox_userDB.Size = new System.Drawing.Size(176, 22);
            this.textBox_userDB.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(22, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = ":Database";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(43, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 218);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Location = new System.Drawing.Point(-2, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(874, 112);
            this.panel5.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_DelSelectedTable);
            this.groupBox4.Controls.Add(this.btn_DelSelectedDB);
            this.groupBox4.Controls.Add(this.btn_RefreshTableList);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.comboBox_CloudTables);
            this.groupBox4.Controls.Add(this.btn_RefreshDatabases);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.comboBox_CloudDatabase);
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(868, 105);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data from Cloud";
            // 
            // btn_DelSelectedTable
            // 
            this.btn_DelSelectedTable.Location = new System.Drawing.Point(658, 66);
            this.btn_DelSelectedTable.Name = "btn_DelSelectedTable";
            this.btn_DelSelectedTable.Size = new System.Drawing.Size(204, 34);
            this.btn_DelSelectedTable.TabIndex = 7;
            this.btn_DelSelectedTable.Text = "Delete Selected Table";
            this.btn_DelSelectedTable.UseVisualStyleBackColor = true;
            this.btn_DelSelectedTable.Click += new System.EventHandler(this.btn_DelSelectedTable_Click);
            // 
            // btn_DelSelectedDB
            // 
            this.btn_DelSelectedDB.Location = new System.Drawing.Point(658, 22);
            this.btn_DelSelectedDB.Name = "btn_DelSelectedDB";
            this.btn_DelSelectedDB.Size = new System.Drawing.Size(204, 34);
            this.btn_DelSelectedDB.TabIndex = 6;
            this.btn_DelSelectedDB.Text = "Delete Selected Database";
            this.btn_DelSelectedDB.UseVisualStyleBackColor = true;
            this.btn_DelSelectedDB.Click += new System.EventHandler(this.btn_DelSelectedDB_Click);
            // 
            // btn_RefreshTableList
            // 
            this.btn_RefreshTableList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_RefreshTableList.Location = new System.Drawing.Point(348, 65);
            this.btn_RefreshTableList.Name = "btn_RefreshTableList";
            this.btn_RefreshTableList.Size = new System.Drawing.Size(165, 34);
            this.btn_RefreshTableList.TabIndex = 5;
            this.btn_RefreshTableList.Text = "Refresh Table List";
            this.btn_RefreshTableList.UseVisualStyleBackColor = true;
            this.btn_RefreshTableList.Click += new System.EventHandler(this.btn_RefreshTableList_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(16, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tables:";
            // 
            // comboBox_CloudTables
            // 
            this.comboBox_CloudTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CloudTables.FormattingEnabled = true;
            this.comboBox_CloudTables.Location = new System.Drawing.Point(144, 71);
            this.comboBox_CloudTables.Name = "comboBox_CloudTables";
            this.comboBox_CloudTables.Size = new System.Drawing.Size(176, 24);
            this.comboBox_CloudTables.TabIndex = 3;
            this.comboBox_CloudTables.SelectedIndexChanged += new System.EventHandler(this.comboBox_CloudTables_SelectedIndexChanged);
            // 
            // btn_RefreshDatabases
            // 
            this.btn_RefreshDatabases.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_RefreshDatabases.Location = new System.Drawing.Point(348, 22);
            this.btn_RefreshDatabases.Name = "btn_RefreshDatabases";
            this.btn_RefreshDatabases.Size = new System.Drawing.Size(165, 34);
            this.btn_RefreshDatabases.TabIndex = 2;
            this.btn_RefreshDatabases.Text = "Refresh Database List";
            this.btn_RefreshDatabases.UseVisualStyleBackColor = true;
            this.btn_RefreshDatabases.Click += new System.EventHandler(this.btn_RefreshDatabases_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(16, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Databases:";
            // 
            // comboBox_CloudDatabase
            // 
            this.comboBox_CloudDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CloudDatabase.FormattingEnabled = true;
            this.comboBox_CloudDatabase.Location = new System.Drawing.Point(144, 28);
            this.comboBox_CloudDatabase.Name = "comboBox_CloudDatabase";
            this.comboBox_CloudDatabase.Size = new System.Drawing.Size(176, 24);
            this.comboBox_CloudDatabase.TabIndex = 0;
            this.comboBox_CloudDatabase.SelectedIndexChanged += new System.EventHandler(this.comboBox_CloudDatabase_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CreateInCloud);
            this.groupBox1.Controls.Add(this.textBox_tableName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_DatabaseName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(-2, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(874, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Database and Table to be created in cloud:";
            // 
            // btn_CreateInCloud
            // 
            this.btn_CreateInCloud.Enabled = false;
            this.btn_CreateInCloud.Location = new System.Drawing.Point(605, 28);
            this.btn_CreateInCloud.Name = "btn_CreateInCloud";
            this.btn_CreateInCloud.Size = new System.Drawing.Size(213, 36);
            this.btn_CreateInCloud.TabIndex = 4;
            this.btn_CreateInCloud.Text = "Create Entity in Cloud";
            this.btn_CreateInCloud.UseVisualStyleBackColor = true;
            this.btn_CreateInCloud.Click += new System.EventHandler(this.btn_CreateInCloud_Click);
            // 
            // textBox_tableName
            // 
            this.textBox_tableName.Location = new System.Drawing.Point(385, 35);
            this.textBox_tableName.Name = "textBox_tableName";
            this.textBox_tableName.Size = new System.Drawing.Size(176, 22);
            this.textBox_tableName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(324, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Table:";
            // 
            // textBox_DatabaseName
            // 
            this.textBox_DatabaseName.Location = new System.Drawing.Point(119, 35);
            this.textBox_DatabaseName.Name = "textBox_DatabaseName";
            this.textBox_DatabaseName.Size = new System.Drawing.Size(176, 22);
            this.textBox_DatabaseName.TabIndex = 1;
            this.textBox_DatabaseName.TextChanged += new System.EventHandler(this.textBox_DatabaseName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(28, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Database:";
            // 
            // tabPageActivityLog
            // 
            this.tabPageActivityLog.Controls.Add(this.panel3);
            this.tabPageActivityLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageActivityLog.Name = "tabPageActivityLog";
            this.tabPageActivityLog.Size = new System.Drawing.Size(978, 632);
            this.tabPageActivityLog.TabIndex = 2;
            this.tabPageActivityLog.Text = "Activity Log";
            this.tabPageActivityLog.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.richTextBox_ExceptionDuringLastActivity);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox_LastActivityDateTime);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox_LastActivity);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 301);
            this.panel3.TabIndex = 0;
            // 
            // richTextBox_ExceptionDuringLastActivity
            // 
            this.richTextBox_ExceptionDuringLastActivity.Location = new System.Drawing.Point(30, 151);
            this.richTextBox_ExceptionDuringLastActivity.Name = "richTextBox_ExceptionDuringLastActivity";
            this.richTextBox_ExceptionDuringLastActivity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_ExceptionDuringLastActivity.Size = new System.Drawing.Size(924, 143);
            this.richTextBox_ExceptionDuringLastActivity.TabIndex = 7;
            this.richTextBox_ExceptionDuringLastActivity.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(30, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = ":Exception during last activity";
            // 
            // textBox_LastActivityDateTime
            // 
            this.textBox_LastActivityDateTime.Location = new System.Drawing.Point(231, 75);
            this.textBox_LastActivityDateTime.Name = "textBox_LastActivityDateTime";
            this.textBox_LastActivityDateTime.ReadOnly = true;
            this.textBox_LastActivityDateTime.Size = new System.Drawing.Size(403, 22);
            this.textBox_LastActivityDateTime.TabIndex = 3;
            this.textBox_LastActivityDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(30, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = ":Last Activity DateTime";
            // 
            // textBox_LastActivity
            // 
            this.textBox_LastActivity.Location = new System.Drawing.Point(231, 15);
            this.textBox_LastActivity.Name = "textBox_LastActivity";
            this.textBox_LastActivity.ReadOnly = true;
            this.textBox_LastActivity.Size = new System.Drawing.Size(403, 22);
            this.textBox_LastActivity.TabIndex = 1;
            this.textBox_LastActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(30, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = ":Last Activity";
            // 
            // tabPage_additionalDBandTables
            // 
            this.tabPage_additionalDBandTables.Controls.Add(this.groupBox6);
            this.tabPage_additionalDBandTables.Controls.Add(this.groupBox3);
            this.tabPage_additionalDBandTables.Location = new System.Drawing.Point(4, 25);
            this.tabPage_additionalDBandTables.Name = "tabPage_additionalDBandTables";
            this.tabPage_additionalDBandTables.Size = new System.Drawing.Size(978, 632);
            this.tabPage_additionalDBandTables.TabIndex = 3;
            this.tabPage_additionalDBandTables.Text = "Immedite Activities";
            this.tabPage_additionalDBandTables.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox_DBsWithAtLeastXtables);
            this.groupBox6.Controls.Add(this.btn_GetDBsWithAtLeastXtables);
            this.groupBox6.Controls.Add(this.textBox_MinNumOfTables);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(19, 157);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(937, 102);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Databases that contains AT LEAST X Table";
            // 
            // comboBox_DBsWithAtLeastXtables
            // 
            this.comboBox_DBsWithAtLeastXtables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DBsWithAtLeastXtables.FormattingEnabled = true;
            this.comboBox_DBsWithAtLeastXtables.Location = new System.Drawing.Point(587, 32);
            this.comboBox_DBsWithAtLeastXtables.Name = "comboBox_DBsWithAtLeastXtables";
            this.comboBox_DBsWithAtLeastXtables.Size = new System.Drawing.Size(227, 24);
            this.comboBox_DBsWithAtLeastXtables.TabIndex = 3;
            // 
            // btn_GetDBsWithAtLeastXtables
            // 
            this.btn_GetDBsWithAtLeastXtables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_GetDBsWithAtLeastXtables.Location = new System.Drawing.Point(321, 25);
            this.btn_GetDBsWithAtLeastXtables.Name = "btn_GetDBsWithAtLeastXtables";
            this.btn_GetDBsWithAtLeastXtables.Size = new System.Drawing.Size(194, 49);
            this.btn_GetDBsWithAtLeastXtables.TabIndex = 2;
            this.btn_GetDBsWithAtLeastXtables.Text = "Get Databases that contains at least X tables";
            this.btn_GetDBsWithAtLeastXtables.UseVisualStyleBackColor = true;
            this.btn_GetDBsWithAtLeastXtables.Click += new System.EventHandler(this.btn_GetDBsWithAtLeastXtables_Click);
            // 
            // textBox_MinNumOfTables
            // 
            this.textBox_MinNumOfTables.Location = new System.Drawing.Point(74, 38);
            this.textBox_MinNumOfTables.Name = "textBox_MinNumOfTables";
            this.textBox_MinNumOfTables.Size = new System.Drawing.Size(134, 22);
            this.textBox_MinNumOfTables.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(24, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_GetDBThatContainsTablesWithMyUserName);
            this.groupBox3.Controls.Add(this.comboBox_GetDBContainsTablesWithMyUserName);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(19, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(412, 98);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Databases That contains tables with my User Name";
            // 
            // btn_GetDBThatContainsTablesWithMyUserName
            // 
            this.btn_GetDBThatContainsTablesWithMyUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_GetDBThatContainsTablesWithMyUserName.ForeColor = System.Drawing.Color.Black;
            this.btn_GetDBThatContainsTablesWithMyUserName.Location = new System.Drawing.Point(24, 39);
            this.btn_GetDBThatContainsTablesWithMyUserName.Name = "btn_GetDBThatContainsTablesWithMyUserName";
            this.btn_GetDBThatContainsTablesWithMyUserName.Size = new System.Drawing.Size(90, 44);
            this.btn_GetDBThatContainsTablesWithMyUserName.TabIndex = 13;
            this.btn_GetDBThatContainsTablesWithMyUserName.Text = "Get";
            this.btn_GetDBThatContainsTablesWithMyUserName.UseVisualStyleBackColor = true;
            this.btn_GetDBThatContainsTablesWithMyUserName.Click += new System.EventHandler(this.btn_GetDBThatContainsTablesWithMyUserName_Click);
            // 
            // comboBox_GetDBContainsTablesWithMyUserName
            // 
            this.comboBox_GetDBContainsTablesWithMyUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GetDBContainsTablesWithMyUserName.FormattingEnabled = true;
            this.comboBox_GetDBContainsTablesWithMyUserName.Location = new System.Drawing.Point(141, 50);
            this.comboBox_GetDBContainsTablesWithMyUserName.Name = "comboBox_GetDBContainsTablesWithMyUserName";
            this.comboBox_GetDBContainsTablesWithMyUserName.Size = new System.Drawing.Size(228, 24);
            this.comboBox_GetDBContainsTablesWithMyUserName.TabIndex = 14;
            // 
            // tabPage_DataActivities
            // 
            this.tabPage_DataActivities.Controls.Add(this.checkedListBox2);
            this.tabPage_DataActivities.Controls.Add(this.panel6);
            this.tabPage_DataActivities.Controls.Add(this.btn_UpdateCloudWithSelectedActivity);
            this.tabPage_DataActivities.Controls.Add(this.checkedListBox1);
            this.tabPage_DataActivities.Controls.Add(this.richTextBox1);
            this.tabPage_DataActivities.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DataActivities.Name = "tabPage_DataActivities";
            this.tabPage_DataActivities.Size = new System.Drawing.Size(978, 632);
            this.tabPage_DataActivities.TabIndex = 4;
            this.tabPage_DataActivities.Text = "Data Activities";
            this.tabPage_DataActivities.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Student",
            "Adult"});
            this.checkedListBox2.Location = new System.Drawing.Point(52, 493);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox2.Size = new System.Drawing.Size(242, 104);
            this.checkedListBox2.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Location = new System.Drawing.Point(29, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(915, 88);
            this.panel6.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_SelectedTableName);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBox_SelectedDatabaseName);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(904, 78);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Database and Tables that you Selected in the previous Tab:";
            // 
            // textBox_SelectedTableName
            // 
            this.textBox_SelectedTableName.Enabled = false;
            this.textBox_SelectedTableName.Location = new System.Drawing.Point(618, 37);
            this.textBox_SelectedTableName.Name = "textBox_SelectedTableName";
            this.textBox_SelectedTableName.Size = new System.Drawing.Size(193, 22);
            this.textBox_SelectedTableName.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(525, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Table:";
            // 
            // textBox_SelectedDatabaseName
            // 
            this.textBox_SelectedDatabaseName.Enabled = false;
            this.textBox_SelectedDatabaseName.Location = new System.Drawing.Point(132, 37);
            this.textBox_SelectedDatabaseName.Name = "textBox_SelectedDatabaseName";
            this.textBox_SelectedDatabaseName.Size = new System.Drawing.Size(193, 22);
            this.textBox_SelectedDatabaseName.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(39, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Database:";
            // 
            // btn_UpdateCloudWithSelectedActivity
            // 
            this.btn_UpdateCloudWithSelectedActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_UpdateCloudWithSelectedActivity.Location = new System.Drawing.Point(626, 519);
            this.btn_UpdateCloudWithSelectedActivity.Name = "btn_UpdateCloudWithSelectedActivity";
            this.btn_UpdateCloudWithSelectedActivity.Size = new System.Drawing.Size(329, 73);
            this.btn_UpdateCloudWithSelectedActivity.TabIndex = 2;
            this.btn_UpdateCloudWithSelectedActivity.Text = "Update Cloud with Selected Activity";
            this.btn_UpdateCloudWithSelectedActivity.UseVisualStyleBackColor = true;
            this.btn_UpdateCloudWithSelectedActivity.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Insert Data into Cloud",
            "Modify Data in Cloud",
            "Delete Data in Cloud"});
            this.checkedListBox1.Location = new System.Drawing.Point(354, 497);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(236, 119);
            this.checkedListBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(915, 361);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tab_MoreTirgul
            // 
            this.tab_MoreTirgul.Controls.Add(this.groupBox7);
            this.tab_MoreTirgul.Location = new System.Drawing.Point(4, 25);
            this.tab_MoreTirgul.Name = "tab_MoreTirgul";
            this.tab_MoreTirgul.Size = new System.Drawing.Size(978, 632);
            this.tab_MoreTirgul.TabIndex = 5;
            this.tab_MoreTirgul.Text = "More and more Exercises";
            this.tab_MoreTirgul.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_DeleteAllDBsInCloud);
            this.groupBox7.Controls.Add(this.btn_GetNumOfTables);
            this.groupBox7.Controls.Add(this.textBox_NumOfTables);
            this.groupBox7.Controls.Add(this.btn_GetNumOfDBs);
            this.groupBox7.Controls.Add(this.textBox_NumOfDatabases);
            this.groupBox7.Location = new System.Drawing.Point(25, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(928, 198);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Count and Delete";
            // 
            // btn_DeleteAllDBsInCloud
            // 
            this.btn_DeleteAllDBsInCloud.Location = new System.Drawing.Point(585, 73);
            this.btn_DeleteAllDBsInCloud.Name = "btn_DeleteAllDBsInCloud";
            this.btn_DeleteAllDBsInCloud.Size = new System.Drawing.Size(167, 64);
            this.btn_DeleteAllDBsInCloud.TabIndex = 4;
            this.btn_DeleteAllDBsInCloud.Text = "Delete all DBs in Cloud";
            this.btn_DeleteAllDBsInCloud.UseVisualStyleBackColor = true;
            this.btn_DeleteAllDBsInCloud.Click += new System.EventHandler(this.btn_DeleteAllDBsInCloud_Click);
            // 
            // btn_GetNumOfTables
            // 
            this.btn_GetNumOfTables.Location = new System.Drawing.Point(6, 116);
            this.btn_GetNumOfTables.Name = "btn_GetNumOfTables";
            this.btn_GetNumOfTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_GetNumOfTables.Size = new System.Drawing.Size(300, 60);
            this.btn_GetNumOfTables.TabIndex = 2;
            this.btn_GetNumOfTables.Text = "Present number of Tables in Cloud:";
            this.btn_GetNumOfTables.UseVisualStyleBackColor = true;
            this.btn_GetNumOfTables.Click += new System.EventHandler(this.btn_GetNumOfTables_Click);
            // 
            // textBox_NumOfTables
            // 
            this.textBox_NumOfTables.Location = new System.Drawing.Point(409, 135);
            this.textBox_NumOfTables.Name = "textBox_NumOfTables";
            this.textBox_NumOfTables.Size = new System.Drawing.Size(80, 22);
            this.textBox_NumOfTables.TabIndex = 3;
            // 
            // btn_GetNumOfDBs
            // 
            this.btn_GetNumOfDBs.Location = new System.Drawing.Point(6, 33);
            this.btn_GetNumOfDBs.Name = "btn_GetNumOfDBs";
            this.btn_GetNumOfDBs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_GetNumOfDBs.Size = new System.Drawing.Size(300, 60);
            this.btn_GetNumOfDBs.TabIndex = 0;
            this.btn_GetNumOfDBs.Text = "Present number of Databases in Cloud:";
            this.btn_GetNumOfDBs.UseVisualStyleBackColor = true;
            this.btn_GetNumOfDBs.Click += new System.EventHandler(this.btn_GetNumOfDBs_Click);
            // 
            // textBox_NumOfDatabases
            // 
            this.textBox_NumOfDatabases.Location = new System.Drawing.Point(409, 52);
            this.textBox_NumOfDatabases.Name = "textBox_NumOfDatabases";
            this.textBox_NumOfDatabases.Size = new System.Drawing.Size(80, 22);
            this.textBox_NumOfDatabases.TabIndex = 1;
            // 
            // tabPage_DataImmiedateActivities
            // 
            this.tabPage_DataImmiedateActivities.Controls.Add(this.groupBox9);
            this.tabPage_DataImmiedateActivities.Controls.Add(this.textBox_CheckTable);
            this.tabPage_DataImmiedateActivities.Controls.Add(this.label20);
            this.tabPage_DataImmiedateActivities.Controls.Add(this.textBox_CheckDB);
            this.tabPage_DataImmiedateActivities.Controls.Add(this.label21);
            this.tabPage_DataImmiedateActivities.Controls.Add(this.richTextBox_FullRecord);
            this.tabPage_DataImmiedateActivities.Controls.Add(this.groupBox8);
            this.tabPage_DataImmiedateActivities.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DataImmiedateActivities.Name = "tabPage_DataImmiedateActivities";
            this.tabPage_DataImmiedateActivities.Size = new System.Drawing.Size(978, 632);
            this.tabPage_DataImmiedateActivities.TabIndex = 6;
            this.tabPage_DataImmiedateActivities.Text = "Again_Excercise";
            this.tabPage_DataImmiedateActivities.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_ExecuteFilter);
            this.groupBox9.Controls.Add(this.textBox_CityFilter);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.textBox_CourseNameFilter);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.textBox_FirstNameFilter);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Location = new System.Drawing.Point(70, 142);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox9.Size = new System.Drawing.Size(839, 175);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "משימה מתאריך 26.1.2023";
            // 
            // btn_ExecuteFilter
            // 
            this.btn_ExecuteFilter.Location = new System.Drawing.Point(458, 68);
            this.btn_ExecuteFilter.Name = "btn_ExecuteFilter";
            this.btn_ExecuteFilter.Size = new System.Drawing.Size(351, 60);
            this.btn_ExecuteFilter.TabIndex = 6;
            this.btn_ExecuteFilter.Text = "Execute filter";
            this.btn_ExecuteFilter.UseVisualStyleBackColor = true;
            this.btn_ExecuteFilter.Click += new System.EventHandler(this.btn_ExecuteFilter_Click_1);
            // 
            // textBox_CityFilter
            // 
            this.textBox_CityFilter.Location = new System.Drawing.Point(201, 91);
            this.textBox_CityFilter.Name = "textBox_CityFilter";
            this.textBox_CityFilter.Size = new System.Drawing.Size(188, 22);
            this.textBox_CityFilter.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Maroon;
            this.label30.Location = new System.Drawing.Point(53, 94);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 17);
            this.label30.TabIndex = 4;
            this.label30.Text = "City Filter:";
            // 
            // textBox_CourseNameFilter
            // 
            this.textBox_CourseNameFilter.Location = new System.Drawing.Point(201, 142);
            this.textBox_CourseNameFilter.Name = "textBox_CourseNameFilter";
            this.textBox_CourseNameFilter.Size = new System.Drawing.Size(188, 22);
            this.textBox_CourseNameFilter.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Maroon;
            this.label29.Location = new System.Drawing.Point(53, 145);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(131, 17);
            this.label29.TabIndex = 2;
            this.label29.Text = "Course name Filter:";
            // 
            // textBox_FirstNameFilter
            // 
            this.textBox_FirstNameFilter.Location = new System.Drawing.Point(201, 35);
            this.textBox_FirstNameFilter.Name = "textBox_FirstNameFilter";
            this.textBox_FirstNameFilter.Size = new System.Drawing.Size(188, 22);
            this.textBox_FirstNameFilter.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Maroon;
            this.label28.Location = new System.Drawing.Point(53, 38);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(115, 17);
            this.label28.TabIndex = 0;
            this.label28.Text = "First Name Filter:";
            // 
            // textBox_CheckTable
            // 
            this.textBox_CheckTable.Enabled = false;
            this.textBox_CheckTable.Location = new System.Drawing.Point(596, 29);
            this.textBox_CheckTable.Name = "textBox_CheckTable";
            this.textBox_CheckTable.Size = new System.Drawing.Size(193, 22);
            this.textBox_CheckTable.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(503, 29);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(55, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "Table:";
            // 
            // textBox_CheckDB
            // 
            this.textBox_CheckDB.Enabled = false;
            this.textBox_CheckDB.Location = new System.Drawing.Point(281, 29);
            this.textBox_CheckDB.Name = "textBox_CheckDB";
            this.textBox_CheckDB.Size = new System.Drawing.Size(193, 22);
            this.textBox_CheckDB.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label21.ForeColor = System.Drawing.Color.Maroon;
            this.label21.Location = new System.Drawing.Point(188, 29);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(86, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Database:";
            // 
            // richTextBox_FullRecord
            // 
            this.richTextBox_FullRecord.Location = new System.Drawing.Point(70, 323);
            this.richTextBox_FullRecord.Name = "richTextBox_FullRecord";
            this.richTextBox_FullRecord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_FullRecord.Size = new System.Drawing.Size(839, 306);
            this.richTextBox_FullRecord.TabIndex = 1;
            this.richTextBox_FullRecord.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btn_ChkIfItemIdExists);
            this.groupBox8.Controls.Add(this.textBox_IdToChkInCloud);
            this.groupBox8.Location = new System.Drawing.Point(70, 57);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(839, 79);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "משימה מתאריך 19.1.2023";
            // 
            // btn_ChkIfItemIdExists
            // 
            this.btn_ChkIfItemIdExists.Location = new System.Drawing.Point(78, 23);
            this.btn_ChkIfItemIdExists.Name = "btn_ChkIfItemIdExists";
            this.btn_ChkIfItemIdExists.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ChkIfItemIdExists.Size = new System.Drawing.Size(294, 43);
            this.btn_ChkIfItemIdExists.TabIndex = 2;
            this.btn_ChkIfItemIdExists.Text = "Get Item with Specific ID:";
            this.btn_ChkIfItemIdExists.UseVisualStyleBackColor = true;
            this.btn_ChkIfItemIdExists.Click += new System.EventHandler(this.btn_ChkIfItemIdExists_Click);
            // 
            // textBox_IdToChkInCloud
            // 
            this.textBox_IdToChkInCloud.Location = new System.Drawing.Point(520, 33);
            this.textBox_IdToChkInCloud.Name = "textBox_IdToChkInCloud";
            this.textBox_IdToChkInCloud.Size = new System.Drawing.Size(313, 22);
            this.textBox_IdToChkInCloud.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Filter);
            this.tabPage1.Controls.Add(this.richTextBox_Filter);
            this.tabPage1.Controls.Add(this.textBox_SelectedTable3);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.textBox_selectedDB3);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.textBox_DefineFilter);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(978, 632);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Reshut_1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(767, 121);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(113, 37);
            this.btn_Filter.TabIndex = 9;
            this.btn_Filter.Text = "Execute Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // richTextBox_Filter
            // 
            this.richTextBox_Filter.Location = new System.Drawing.Point(56, 200);
            this.richTextBox_Filter.Name = "richTextBox_Filter";
            this.richTextBox_Filter.Size = new System.Drawing.Size(857, 344);
            this.richTextBox_Filter.TabIndex = 8;
            this.richTextBox_Filter.Text = "";
            // 
            // textBox_SelectedTable3
            // 
            this.textBox_SelectedTable3.Enabled = false;
            this.textBox_SelectedTable3.Location = new System.Drawing.Point(650, 46);
            this.textBox_SelectedTable3.Name = "textBox_SelectedTable3";
            this.textBox_SelectedTable3.Size = new System.Drawing.Size(193, 22);
            this.textBox_SelectedTable3.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label23.ForeColor = System.Drawing.Color.Maroon;
            this.label23.Location = new System.Drawing.Point(557, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "Table:";
            // 
            // textBox_selectedDB3
            // 
            this.textBox_selectedDB3.Enabled = false;
            this.textBox_selectedDB3.Location = new System.Drawing.Point(164, 46);
            this.textBox_selectedDB3.Name = "textBox_selectedDB3";
            this.textBox_selectedDB3.Size = new System.Drawing.Size(193, 22);
            this.textBox_selectedDB3.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(71, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 20);
            this.label24.TabIndex = 4;
            this.label24.Text = "Database:";
            // 
            // textBox_DefineFilter
            // 
            this.textBox_DefineFilter.Location = new System.Drawing.Point(346, 128);
            this.textBox_DefineFilter.Name = "textBox_DefineFilter";
            this.textBox_DefineFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_DefineFilter.Size = new System.Drawing.Size(345, 22);
            this.textBox_DefineFilter.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(172, 131);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 17);
            this.label22.TabIndex = 0;
            this.label22.Text = "Define Filter";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(978, 632);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "Mega_Reshut";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(544, 72);
            this.button3.TabIndex = 12;
            this.button3.Text = "Retrieve picture from cloud";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(693, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label26.ForeColor = System.Drawing.Color.Maroon;
            this.label26.Location = new System.Drawing.Point(600, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 20);
            this.label26.TabIndex = 10;
            this.label26.Text = "Table:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(207, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 22);
            this.textBox4.TabIndex = 9;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label27.ForeColor = System.Drawing.Color.Maroon;
            this.label27.Location = new System.Drawing.Point(114, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 20);
            this.label27.TabIndex = 8;
            this.label27.Text = "Database:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(544, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Upload picture into cloud";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(593, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(106, 76);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label25.Size = new System.Drawing.Size(147, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "Type the picture path:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.dataGridView_LastEx);
            this.tabPage3.Controls.Add(this.richTextBox_Last);
            this.tabPage3.Controls.Add(this.textBox_TableLast);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.textBox_DBLast);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(978, 632);
            this.tabPage3.TabIndex = 9;
            this.tabPage3.Text = "Last ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btn_GetFinalEx);
            this.groupBox11.Controls.Add(this.textBox_firstNameLength);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.textBox_TableStartsWith);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.textBox_DBendsWith);
            this.groupBox11.Controls.Add(this.label36);
            this.groupBox11.Location = new System.Drawing.Point(58, 294);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox11.Size = new System.Drawing.Size(900, 128);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Last Ex";
            // 
            // btn_GetFinalEx
            // 
            this.btn_GetFinalEx.Location = new System.Drawing.Point(660, 45);
            this.btn_GetFinalEx.Name = "btn_GetFinalEx";
            this.btn_GetFinalEx.Size = new System.Drawing.Size(185, 49);
            this.btn_GetFinalEx.TabIndex = 24;
            this.btn_GetFinalEx.Text = "Get";
            this.btn_GetFinalEx.UseVisualStyleBackColor = true;
            this.btn_GetFinalEx.Click += new System.EventHandler(this.btn_GetFinalEx_Click);
            // 
            // textBox_firstNameLength
            // 
            this.textBox_firstNameLength.Location = new System.Drawing.Point(506, 58);
            this.textBox_firstNameLength.Name = "textBox_firstNameLength";
            this.textBox_firstNameLength.Size = new System.Drawing.Size(115, 22);
            this.textBox_firstNameLength.TabIndex = 23;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label38.ForeColor = System.Drawing.Color.Maroon;
            this.label38.Location = new System.Drawing.Point(336, 58);
            this.label38.Name = "label38";
            this.label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label38.Size = new System.Drawing.Size(153, 20);
            this.label38.TabIndex = 22;
            this.label38.Text = "First Name Length:";
            // 
            // textBox_TableStartsWith
            // 
            this.textBox_TableStartsWith.Location = new System.Drawing.Point(183, 83);
            this.textBox_TableStartsWith.Name = "textBox_TableStartsWith";
            this.textBox_TableStartsWith.Size = new System.Drawing.Size(115, 22);
            this.textBox_TableStartsWith.TabIndex = 21;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label37.ForeColor = System.Drawing.Color.Maroon;
            this.label37.Location = new System.Drawing.Point(13, 83);
            this.label37.Name = "label37";
            this.label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label37.Size = new System.Drawing.Size(140, 20);
            this.label37.TabIndex = 20;
            this.label37.Text = "Table Starts with:";
            // 
            // textBox_DBendsWith
            // 
            this.textBox_DBendsWith.Location = new System.Drawing.Point(183, 35);
            this.textBox_DBendsWith.Name = "textBox_DBendsWith";
            this.textBox_DBendsWith.Size = new System.Drawing.Size(115, 22);
            this.textBox_DBendsWith.TabIndex = 19;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label36.ForeColor = System.Drawing.Color.Maroon;
            this.label36.Location = new System.Drawing.Point(13, 35);
            this.label36.Name = "label36";
            this.label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label36.Size = new System.Drawing.Size(164, 20);
            this.label36.TabIndex = 18;
            this.label36.Text = "Database Ends with:";
            // 
            // dataGridView_LastEx
            // 
            this.dataGridView_LastEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LastEx.Location = new System.Drawing.Point(469, 440);
            this.dataGridView_LastEx.Name = "dataGridView_LastEx";
            this.dataGridView_LastEx.RowHeadersWidth = 51;
            this.dataGridView_LastEx.RowTemplate.Height = 24;
            this.dataGridView_LastEx.Size = new System.Drawing.Size(489, 160);
            this.dataGridView_LastEx.TabIndex = 16;
            // 
            // richTextBox_Last
            // 
            this.richTextBox_Last.Location = new System.Drawing.Point(58, 440);
            this.richTextBox_Last.Name = "richTextBox_Last";
            this.richTextBox_Last.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_Last.Size = new System.Drawing.Size(392, 160);
            this.richTextBox_Last.TabIndex = 15;
            this.richTextBox_Last.Text = "";
            // 
            // textBox_TableLast
            // 
            this.textBox_TableLast.Enabled = false;
            this.textBox_TableLast.Location = new System.Drawing.Point(572, 44);
            this.textBox_TableLast.Name = "textBox_TableLast";
            this.textBox_TableLast.Size = new System.Drawing.Size(193, 22);
            this.textBox_TableLast.TabIndex = 14;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label34.ForeColor = System.Drawing.Color.Maroon;
            this.label34.Location = new System.Drawing.Point(479, 44);
            this.label34.Name = "label34";
            this.label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label34.Size = new System.Drawing.Size(55, 20);
            this.label34.TabIndex = 13;
            this.label34.Text = "Table:";
            // 
            // textBox_DBLast
            // 
            this.textBox_DBLast.Enabled = false;
            this.textBox_DBLast.Location = new System.Drawing.Point(257, 44);
            this.textBox_DBLast.Name = "textBox_DBLast";
            this.textBox_DBLast.Size = new System.Drawing.Size(193, 22);
            this.textBox_DBLast.TabIndex = 12;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label35.ForeColor = System.Drawing.Color.Maroon;
            this.label35.Location = new System.Drawing.Point(164, 44);
            this.label35.Name = "label35";
            this.label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label35.Size = new System.Drawing.Size(86, 20);
            this.label35.TabIndex = 11;
            this.label35.Text = "Database:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btn_ExecuteFilterLast);
            this.groupBox10.Controls.Add(this.textBox_CityStartsWith);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.textBox_MinCoursesNum);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.textBox_FirstNameContains);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Location = new System.Drawing.Point(58, 100);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox10.Size = new System.Drawing.Size(845, 188);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "משימה מתאריך 26.1.2023";
            // 
            // btn_ExecuteFilterLast
            // 
            this.btn_ExecuteFilterLast.Location = new System.Drawing.Point(458, 68);
            this.btn_ExecuteFilterLast.Name = "btn_ExecuteFilterLast";
            this.btn_ExecuteFilterLast.Size = new System.Drawing.Size(351, 60);
            this.btn_ExecuteFilterLast.TabIndex = 6;
            this.btn_ExecuteFilterLast.Text = "Execute filter";
            this.btn_ExecuteFilterLast.UseVisualStyleBackColor = true;
            this.btn_ExecuteFilterLast.Click += new System.EventHandler(this.btn_ExecuteFilterLast_Click);
            // 
            // textBox_CityStartsWith
            // 
            this.textBox_CityStartsWith.Location = new System.Drawing.Point(201, 91);
            this.textBox_CityStartsWith.Name = "textBox_CityStartsWith";
            this.textBox_CityStartsWith.Size = new System.Drawing.Size(188, 22);
            this.textBox_CityStartsWith.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Maroon;
            this.label31.Location = new System.Drawing.Point(53, 94);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(108, 17);
            this.label31.TabIndex = 4;
            this.label31.Text = "City Starts With:";
            // 
            // textBox_MinCoursesNum
            // 
            this.textBox_MinCoursesNum.Location = new System.Drawing.Point(201, 142);
            this.textBox_MinCoursesNum.Name = "textBox_MinCoursesNum";
            this.textBox_MinCoursesNum.Size = new System.Drawing.Size(188, 22);
            this.textBox_MinCoursesNum.TabIndex = 3;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Maroon;
            this.label32.Location = new System.Drawing.Point(53, 145);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(123, 17);
            this.label32.TabIndex = 2;
            this.label32.Text = "Min Courses Num:";
            // 
            // textBox_FirstNameContains
            // 
            this.textBox_FirstNameContains.Location = new System.Drawing.Point(201, 35);
            this.textBox_FirstNameContains.Name = "textBox_FirstNameContains";
            this.textBox_FirstNameContains.Size = new System.Drawing.Size(188, 22);
            this.textBox_FirstNameContains.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.Maroon;
            this.label33.Location = new System.Drawing.Point(53, 38);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(139, 17);
            this.label33.TabIndex = 0;
            this.label33.Text = "First Name Contains:";
            // 
            // issCreated
            // 
            this.issCreated.Location = new System.Drawing.Point(843, 22);
            this.issCreated.Name = "issCreated";
            this.issCreated.Size = new System.Drawing.Size(136, 22);
            this.issCreated.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(727, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = ":Client Status";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.issCreated);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(16, 709);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 60);
            this.panel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 781);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl_ImmediateActivities);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_ImmediateActivities.ResumeLayout(false);
            this.tabPageCloudKeys.ResumeLayout(false);
            this.tabPageCloudKeys.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_DatabasesAndTables.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageActivityLog.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage_additionalDBandTables.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage_DataActivities.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tab_MoreTirgul.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage_DataImmiedateActivities.ResumeLayout(false);
            this.tabPage_DataImmiedateActivities.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LastEx)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_ImmediateActivities;
        private System.Windows.Forms.TabPage tabPageCloudKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PrimaryKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EndPointUri;
        private System.Windows.Forms.TabPage tabPage_DatabasesAndTables;
        private System.Windows.Forms.TabPage tabPageActivityLog;
        private System.Windows.Forms.Button btn_CreateClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ConnectionSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox issCreated;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tableName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_DatabaseName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CreateInCloud;
        private System.Windows.Forms.Button btn_DisposeClient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_LastActivityDateTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_LastActivity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox_ExceptionDuringLastActivity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage_additionalDBandTables;
        private System.Windows.Forms.TextBox textBox_IsDatabaseExists;
        private System.Windows.Forms.TextBox textBox_userDB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button checkIfExists;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_CloudDatabase;
        private System.Windows.Forms.Button btn_RefreshTableList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_CloudTables;
        private System.Windows.Forms.Button btn_RefreshDatabases;
        private System.Windows.Forms.LinkLabel linkLabel_AzureUI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_CheckIfTableExists;
        private System.Windows.Forms.TextBox textBox_IsTableExists;
        private System.Windows.Forms.TextBox textBox_TableToChk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_GetDBThatContainsTablesWithMyUserName;
        private System.Windows.Forms.ComboBox comboBox_GetDBContainsTablesWithMyUserName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage_DataActivities;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_UpdateCloudWithSelectedActivity;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_SelectedTableName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_SelectedDatabaseName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_GetDBsWithAtLeastXtables;
        private System.Windows.Forms.TextBox textBox_MinNumOfTables;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox_DBsWithAtLeastXtables;
        private System.Windows.Forms.Button btn_DelSelectedDB;
        private System.Windows.Forms.Button btn_DelSelectedTable;
        private System.Windows.Forms.TabPage tab_MoreTirgul;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_DeleteAllDBsInCloud;
        private System.Windows.Forms.Button btn_GetNumOfTables;
        private System.Windows.Forms.TextBox textBox_NumOfTables;
        private System.Windows.Forms.Button btn_GetNumOfDBs;
        private System.Windows.Forms.TextBox textBox_NumOfDatabases;
        private System.Windows.Forms.TabPage tabPage_DataImmiedateActivities;
        private System.Windows.Forms.TextBox textBox_CheckTable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_CheckDB;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_ChkIfItemIdExists;
        private System.Windows.Forms.RichTextBox richTextBox_FullRecord;
        private System.Windows.Forms.TextBox textBox_IdToChkInCloud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox_Filter;
        private System.Windows.Forms.TextBox textBox_SelectedTable3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_selectedDB3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_DefineFilter;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_ExecuteFilter;
        private System.Windows.Forms.TextBox textBox_CityFilter;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox_CourseNameFilter;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox_FirstNameFilter;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btn_ExecuteFilterLast;
        private System.Windows.Forms.TextBox textBox_CityStartsWith;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox_MinCoursesNum;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox_FirstNameContains;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox_TableLast;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox_DBLast;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.RichTextBox richTextBox_Last;
        private System.Windows.Forms.DataGridView dataGridView_LastEx;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox_TableStartsWith;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox_DBendsWith;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox_firstNameLength;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btn_GetFinalEx;
    }
}

