using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Read configuration settings
        private static readonly string endPointUri = System.Configuration.ConfigurationManager.AppSettings["EndPointUri"];
        private static readonly string primaryKey = System.Configuration.ConfigurationManager.AppSettings["PrimaryKey"];
        private static readonly string connectionSource = System.Configuration.ConfigurationManager.AppSettings["ConnectionSource"];
        private static readonly string id = System.Configuration.ConfigurationManager.AppSettings["ID"];
        private static readonly string name = System.Configuration.ConfigurationManager.AppSettings["Name"];
        private static readonly string emulatorUI = System.Configuration.ConfigurationManager.AppSettings["EmulatorUI"];
        private static readonly string azureUI = System.Configuration.ConfigurationManager.AppSettings["AzureUI"];

        CloudDataAndActivities cloudDataAndActivities;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cloudDataAndActivities = new CloudDataAndActivities(endPointUri, primaryKey);
            if(connectionSource == "Emulator")
                linkLabel_AzureUI.Text = emulatorUI;
            else if (connectionSource == "Azure")
                linkLabel_AzureUI.Text = azureUI;

            //linkLabel_AzureUI.Text = azureUI;
            /*            stam = "https://localhost:8081/_explorer/index.html"; // temp!!
            */
            textBox_EndPointUri.Text = endPointUri;
            textBox_PrimaryKey.Text = primaryKey;
            textBox_ConnectionSource.Text = connectionSource;
            issCreated.Text = cloudDataAndActivities.GetClientCreated().ToString();
            //issCreated.Text = "Not Created";
            textBox_ID.Text = id;
            textBox_Name.Text = name;
            
        }

        private void btn_CreateClient_Click(object sender, EventArgs e)
        {
            try
            {
                cloudDataAndActivities.CreateCosmosClient();
                MessageBox.Show("Azure COSMOS Client was Created!",
                                "Client Created",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                btn_CreateClient.Enabled = false; // Disable the create button
                btn_DisposeClient.Enabled = true;
                richTextBox_ExceptionDuringLastActivity.Text = "Created Client Successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clien was not created and the following error occured:\n" + ex.Message,
                                "Client created failure", MessageBoxButtons.OK,MessageBoxIcon.Error);
                btn_DisposeClient.Enabled = false;
                richTextBox_ExceptionDuringLastActivity.Text = ex.ToString();
            }

            textBox_LastActivity.Text = cloudDataAndActivities.GetlastActivity().ToString();
            textBox_LastActivityDateTime.Text = cloudDataAndActivities.GetlastActivityDateTime().ToString();

            issCreated.Text = cloudDataAndActivities.GetClientCreated().ToString();

            /*if (cloudDataAndActivities.GetClientCreated())
                issCreated.Text = "Client Created";   */
        }

        

        private async void btn_CreateInCloud_Click(object sender, EventArgs e)
        {
            // Read the information that the user typed on the screen
            // (Database name, Table name)
            string databaseName = textBox_DatabaseName.Text;
            string tableName = textBox_tableName.Text;

            // Create in cloud the entities that were typed above:
            await CreateDatabaseAndTableInCloudAsync(databaseName, tableName);
        }
       public async Task CreateDatabaseAndTableInCloudAsync(string databaseName, string tableName)
        {
            Microsoft.Azure.Cosmos.DatabaseResponse databaseResult = null;
            #region Step A: Create Database
            try
            {
                if (String.IsNullOrEmpty(databaseName.Trim()))
                {
                    MessageBox.Show("Please type a DB name");
                    return;
                }
                 databaseResult =
                   await cloudDataAndActivities.CreateDataBaseAsync(databaseName);
                // Read the status code
                System.Net.HttpStatusCode statusCode = databaseResult.StatusCode;

                // Present relevant message to the user
                if (statusCode == System.Net.HttpStatusCode.Created)
                {
                    // The database was created
                    MessageBox.Show("The database '" + databaseName + "' was created",
                                "Database Created",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    richTextBox_ExceptionDuringLastActivity.Text = "Database was created successfully";
                }
                else if (statusCode == System.Net.HttpStatusCode.OK)
                {
                    // The database already exists
                    MessageBox.Show("The database '" + databaseName + "' already exists",
                                "Database Exists",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    richTextBox_ExceptionDuringLastActivity.Text = "The database already exist";

                }
                else
                {
                    // Another status code
                    MessageBox.Show("Your request failed, and we got the following status code: " + statusCode,
                                "Request Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    richTextBox_ExceptionDuringLastActivity.Text = statusCode.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your request failed, and the following exception occured: " + ex.Message,
                                "Request Failed", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                richTextBox_ExceptionDuringLastActivity.Text = ex.Message;
            }
            #endregion

            // If the database result will be null - then we can not proceed to the table creation process
            if (databaseResult == null)
                return;
                
            #region Step B: Create Table

            /*if (String.IsNullOrEmpty(databaseName.Trim()))
                return;*/

            try
            {
                Microsoft.Azure.Cosmos.ContainerResponse containerResult =
                        await cloudDataAndActivities.CreateContainerAsync(databaseResult.Database, tableName, "/id");

                System.Net.HttpStatusCode containerStatusCode = containerResult.StatusCode;

                if (containerStatusCode == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("Table '" + tableName + "' was created",
                        "Table Created",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    richTextBox_ExceptionDuringLastActivity.Text = "Table was created successfully";

                }
                else if (containerStatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Table '" + tableName + "' was not created, since it already exists",
                        "Table already exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    richTextBox_ExceptionDuringLastActivity.Text = "Table already exist";

                }
                else
                {
                    MessageBox.Show("Table '" + tableName + "' was not created, and we got the following http status code: " + containerStatusCode,
                        "Table was not created",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    richTextBox_ExceptionDuringLastActivity.Text = "Failed to creat table\n"+containerStatusCode.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Table '" + tableName + "' was not created, and we got the following exception: " + ex.Message,
                        "Table was not created",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                richTextBox_ExceptionDuringLastActivity.Text = ex.Message;
            }
            #endregion

        }

        private void textBox_DatabaseName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_DatabaseName.Text.Trim().Equals(String.Empty))
                btn_CreateInCloud.Enabled = false;
            else
                btn_CreateInCloud.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cloudDataAndActivities.DisposeClient();
            issCreated.Text = cloudDataAndActivities.GetClientCreated().ToString();

            btn_CreateClient.Enabled = true;
            btn_DisposeClient.Enabled = false;
            issCreated.Text = cloudDataAndActivities.GetClientCreated().ToString();
            richTextBox_ExceptionDuringLastActivity.Text = "Clien Disposed";
        }


       /* private void btn_CheckIfExists_Click(object sender, EventArgs e)
        {
            // Talk  the user's data
            string userDB = textBox_UserDB.Text;

            bool result =  cloudDataAndActivities.CheckIfDatabaseExists(userDB);

            textBox_IsDatabaseExists.Text = result.ToString();
        }*/

        private async void button1_Click_1(object sender, EventArgs e)
        {
            // Stage1: Take the user's data
            string userDB = textBox_userDB.Text;

            // Stage2: Check if the database exists in the cloud account
            //bool result = await cloudDataAndActivities.CheckIfDatabaseExistsAsync_option1(userDB);
            //bool result = await cloudDataAndActivities.CheckIfDatabaseExistsAsync_option2(userDB);
            bool result = await cloudDataAndActivities.CheckIfDatabaseExistsAsync_option3(userDB);

            // Stage3: Present the results
            textBox_IsDatabaseExists.Text = result.ToString();
        }

        private void linkLabel_AzureUI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    FileName = linkLabel_AzureUI.Text
                }
            };
            process.Start();
        }

        private async void btn_CheckIfTableExists_Click(object sender, EventArgs e)
        {
            string userTable = textBox_TableToChk.Text;

            //bool result = await cloudDataAndActivities.CheckIfTableExist_option1(userTable);
            //bool result = await cloudDataAndActivities.CheckIfTableExist_option2(userTable);
            bool result = await cloudDataAndActivities.CheckIfTableExist_option3(userTable);

            textBox_IsTableExists.Text = result.ToString();
        }

        private async void btn_RefreshDatabases_Click(object sender, EventArgs e)
        {
            await cloudDataAndActivities.GetDataBasesFromCloudAsync();
            PopulateDatabasesInCombo();

        }

        private void PopulateDatabasesInCombo()
        {
            comboBox_CloudDatabase.DataSource = null;
            comboBox_CloudDatabase.Items.Clear();

            comboBox_CloudDatabase.DataSource = cloudDataAndActivities.GetCloudDatabases();
            comboBox_CloudDatabase.DisplayMember = "databaseId";
        }

        private async void btn_RefreshTableList_Click(object sender, EventArgs e)
        {
            await cloudDataAndActivities.GetTablesFromCloudAsync();
            PopulateTablesInCombo();

        }

        private void PopulateTablesInCombo()
        {
            comboBox_CloudTables.DataSource = null;
            comboBox_CloudTables.Items.Clear();

            comboBox_CloudTables.DataSource = cloudDataAndActivities.GetCloudTables();
            comboBox_CloudTables.DisplayMember = "tableId";
        }

        private async void btn_GetDBThatContainsTablesWithMyUserName_Click(object sender, EventArgs e)
        {
            // הגדרה של מבנה הנתונים שצריך לקלוט את המידע מהענן 
            List<string> databases = new List<string>();

            // Just this is connected to the exam
            // הפעלה של הפעולה שתפקידה להביא את המידע הנדרש
            //databases = await cloudDataAndActivities.GetDBsWithTablesAsMyUserNameAsync_option2(name);
            databases = await cloudDataAndActivities.GetDBsWithTablesAsMyUserName(name);
            comboBox_GetDBContainsTablesWithMyUserName.DataSource = databases;
        }

        private void comboBox_CloudDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filterTablesAccordingToDB();

            // אם הבחירה של מסד הנתונים השתנתה ערך החדש חייב להיות מוצג בתוך הכרטיסייה הטחרונה
            string selectedDB = ((Models.Database)comboBox_CloudDatabase.SelectedItem).databaseId;
            textBox_SelectedDatabaseName.Text = selectedDB;
            textBox_CheckDB.Text = selectedDB;

            textBox_selectedDB3.Text = selectedDB;

            textBox_DBLast.Text = selectedDB;
        }

        private void filterTablesAccordingToDB(string database = "")
        {
            comboBox_CloudTables.Items.Clear();

            // Present only those tables that relates to the input Database
            foreach (Models.Container currentTable in cloudDataAndActivities.GetCloudTables())
            {
                if (!currentTable.databaseId.Equals(database))
                    continue;

                // Add the current Table into the comboBox
                comboBox_CloudTables.Items.Add(currentTable);
            }
            comboBox_CloudTables.DisplayMember = "tableId";
        }


        // event for button the activity on the מידע that sent to the cloud
        private async void button1_Click_2(object sender, EventArgs e)
        {
            // Before going to the cloud and save/update/delete we need: 
            // SelectedDatabase
            // SelectedTable
            // Data that we want to work on
            // Selected Activity

            string dataOnScreen = richTextBox1.Text;

            string selectedDB = textBox_SelectedDatabaseName.Text;
            string selectedTable = textBox_SelectedTableName.Text;

            // Selected Activity
            
            string selectedActivity = checkedListBox1.CheckedItems[0].ToString();

            string selectedObjectType = checkedListBox2.CheckedItems[0].ToString();
            Enums.ObjectType objectType = (Enums.ObjectType)Enum.Parse(typeof(Enums.ObjectType),
                                            selectedObjectType);// How to cast a string into enum

            // Now we will continue according to the object type:
            if (objectType == Enums.ObjectType.Student)
            {
                List<Models.Student> students = Models.Student.ConvertStudentStringIntoList(dataOnScreen);
                await cloudDataAndActivities.PerformDataActivityInCloudAsync(selectedDB,
                                                                             selectedTable,
                                                                             students, // כולם תחת אותה פעולה
                                                                             selectedActivity);
            }
            else if(objectType == Enums.ObjectType.Adult)
            {
                List<Models.Adult> adults = Models.Adult.ConvertAdultStringIntoList(dataOnScreen);
                await cloudDataAndActivities.PerformDataActivityInCloudAsync(selectedDB,
                                                                             selectedTable,
                                                                             adults, // כולם תחת אותה פעולה
                                                                             selectedActivity);
            }
            MessageBox.Show("Activity '" + selectedActivity + "' was completed");
        }

        private async void btn_GetDBsWithAtLeastXtables_Click(object sender, EventArgs e)
        {
            // Stage1: Get X from the table
            int minNumOfTables = Convert.ToInt32(textBox_MinNumOfTables.Text);

            if (minNumOfTables < 0)
            {
                MessageBox.Show("Can not enter a minus number", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            // Stage2: Trigger the relevant method
            List<string> results = await cloudDataAndActivities.GetDBsWithAtLeastXtables(minNumOfTables);

            // Stage3: Present the results
            comboBox_DBsWithAtLeastXtables.DataSource = results;

        }

        private async void btn_DelSelectedDB_Click(object sender, EventArgs e)
        {
            //comboBox_CloudDatabase.Text;
            //MessageBox.Show(((Models.Database)comboBox_CloudDatabase.SelectedItem).databaseId);
            string selectedDB = ((Models.Database)comboBox_CloudDatabase.SelectedItem).databaseId;

            await cloudDataAndActivities.DeleteSelectedDBAsync(selectedDB);

            MessageBox.Show("DB '" + selectedDB + "' was deleted");
        }

        private async void btn_DelSelectedTable_Click(object sender, EventArgs e)
        {
            string selectedDB = ((Models.Database)comboBox_CloudDatabase.SelectedItem).databaseId;
            string selectedTable = ((Models.Container)comboBox_CloudTables.SelectedItem).tableId;

            await cloudDataAndActivities.DeteleSelectedContainerAsync(selectedDB ,selectedTable);

            MessageBox.Show("Table '" + selectedTable + "' was deleted");

        }

        private void btn_DeleteAllDBsInCloud_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show(name + ", you are about to delete" +
                "                    all Databases in your Cloud account.\nPlease Confirm",
                                     "Confirm Delete",
                                     MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question);

            if (result == DialogResult.OK)
                cloudDataAndActivities.DeleteAllDBsFromCloud();
            else if (result == DialogResult.Cancel)
                MessageBox.Show("Activity was cancelled");
        }

        private async void btn_GetNumOfDBs_Click(object sender, EventArgs e)
        {
            int counter = await cloudDataAndActivities.GetNumberOfDBs();
            textBox_NumOfDatabases.Text = counter.ToString();
        }

        private async void btn_GetNumOfTables_Click(object sender, EventArgs e)
        {
            int counter = await cloudDataAndActivities.GetNumberOfTables();
            textBox_NumOfTables.Text = counter.ToString();
        }

        private void comboBox_CloudTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = ((Models.Container)comboBox_CloudTables.SelectedItem).tableId;
            textBox_SelectedTableName.Text = selectedTable;
            textBox_CheckTable.Text = selectedTable;

            textBox_SelectedTable3.Text = selectedTable;

            textBox_TableLast.Text = selectedTable;
        }

        // Event does not need task

        /*string selectedDB = textBox_SelectedDatabaseName.Text;
        string selectedTable = textBox_SelectedTableName.Text;*/

        private async void btn_ChkIfItemIdExists_Click(object sender, EventArgs e)
        {
            string idToChk = textBox_IdToChkInCloud.Text;
            string selectedDB = textBox_CheckDB.Text;
            string selectedTable = textBox_CheckTable.Text;

            // Option1
            /*Models.Student a = await cloudDataAndActivities.CheckIfItemIdExists1(selectedDB, selectedTable, idToChk);
            if (a == null)
                richTextBox_FullRecord.Text = "No ID match the id we are looking for.";
            else
            {
                richTextBox_FullRecord.Text = Newtonsoft.Json.JsonConvert.SerializeObject(a);
                // To make the format looks like JSON
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(a, Newtonsoft.Json.Formatting.Indented);
                richTextBox_FullRecord.Text = json;
            }*/

            // Option2
            /*string test2 = await cloudDataAndActivities.CheckIfItemIdExists2(selectedDB, selectedTable, idToChk);
            richTextBox_FullRecord.Text = test2.ToString();*/

            // Option3
            Models.Student record = await cloudDataAndActivities.CheckIfItemIdExistsAsync3(selectedDB, selectedTable, idToChk);
            if (record == null)
                richTextBox_FullRecord.Text = "No ID match the id we are looking for.";
            else
            {
                richTextBox_FullRecord.Text = record.ToString();
                // To make the format looks like JSON
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(record, Newtonsoft.Json.Formatting.Indented);
                richTextBox_FullRecord.Text = json;
            }
        }


        private async void btn_Filter_Click(object sender, EventArgs e)
        {
            string filter = textBox_DefineFilter.Text;
            string selectedDB = textBox_CheckDB.Text;
            string selectedTable = textBox_CheckTable.Text;
            string a = await cloudDataAndActivities.FilterJSON(selectedDB, selectedTable, filter);
            richTextBox_Filter.Text = Newtonsoft.Json.JsonConvert.SerializeObject(a);
        }

        private async void btn_ExecuteFilter_Click_1(object sender, EventArgs e)
        {
            string selectedDB = textBox_CheckDB.Text;
            string selectedTable = textBox_CheckTable.Text;

            string firstName = textBox_FirstNameFilter.Text;
            string city = textBox_CityFilter.Text;
            string courseName = textBox_CourseNameFilter.Text;

            List<Models.Student> record = await cloudDataAndActivities.ExecuteFilter(selectedDB,
                                                    selectedTable, firstName, city, courseName);
            if (record == null)
                richTextBox_FullRecord.Text = "No Student found";
            else
                foreach (Models.Student students in record)
                    richTextBox_FullRecord.AppendText(students.ToString() + "\n");    
        }


        private async void btn_ExecuteFilterLast_Click(object sender, EventArgs e)
        {
            // Read the destination
            string selectedDB = textBox_DBLast.Text;
            string selectedTable = textBox_TableLast.Text;

            // Read the filter
            string firstNameContains = textBox_FirstNameContains.Text;
            string cityStartsWith = textBox_CityStartsWith.Text;
            //string minCoursesNum = textBox_MinCoursesNum.Text;

            int minCoursesNumLior = Convert.ToInt32(textBox_MinCoursesNum.Text);

            List<Models.Student> result = await
                             cloudDataAndActivities.SearchFirstNameContainsAndAllLior(selectedDB,
                                                                                     selectedTable,
                                                                                     firstNameContains,
                                                                                     cityStartsWith,
                                                                                     minCoursesNumLior);
            dataGridView_LastEx.DataSource = result;
            /*Models.Student result = await
             *                      cloudDataAndActivities.SearchFirstNameContainsAndAll(selectedDB,
                                                                                      selectedTable,
                                                                                      firstNameContains,
                                                                                      cityStartsWith,
                                                                                      minCoursesNum1);
            if (result == null)
                richTextBox_FullRecord.Text = "No ID match the id we are looking for.";
            else
            {
                richTextBox_FullRecord.Text = result.ToString();
                // To make the format looks like JSON
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(result,
                                            Newtonsoft.Json.Formatting.Indented);
                richTextBox_Last.Text = json;
            }*/
        }

        private async void btn_GetFinalEx_Click(object sender, EventArgs e)
        {
            string dbFilter = textBox_DBendsWith.Text;
            string tableFilter = textBox_TableStartsWith.Text;
            int firstNameFilter = Convert.ToInt32(textBox_firstNameLength.Text);

            List<Models.Student> results = await cloudDataAndActivities.getAllRecordsAsync(dbFilter,
                                                                        tableFilter, firstNameFilter);
            dataGridView_LastEx.DataSource = results;
        }
    }
}
