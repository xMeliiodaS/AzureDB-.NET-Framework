using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public class CloudDataAndActivities
    {

        private string endPointUri;
        private string primaryKey;

        private Microsoft.Azure.Cosmos.CosmosClient cosmosClient;
        private bool isClientCreated = false;
        private string lastActivity = string.Empty;
        private string lastActivityDateTime = string.Empty;

        private List<Models.Database> cloudDatabases = new List<Models.Database>();
        private List<Models.Container> cloudTables = new List<Models.Container>();

        public string GetlastActivity()
        {
            return lastActivity;
        }

        public string GetlastActivityDateTime()
        {
            return lastActivityDateTime;
        }
        public List<Models.Database> GetCloudDatabases()
        {
            return cloudDatabases;
        }
        public List<Models.Container> GetCloudTables()
        {
            return cloudTables;
        }

        public CloudDataAndActivities(string endPointUri, string primaryKey)
        {
            this.endPointUri = endPointUri;
            this.primaryKey = primaryKey;
        }

        public string getLastActivity()
        {
            return lastActivity;
        }

        public void CreateCosmosClient()
        {

            lastActivity = "Create Client";
            lastActivityDateTime = DateTime.Now.ToString();
            try
            {
                cosmosClient = new Microsoft.Azure.Cosmos.CosmosClient(endPointUri, primaryKey);
                // If the code came here - then no exception was thrown
                isClientCreated = true;

            }
            catch (Exception ex)
            {
                // If the code came here then we have an exception
                isClientCreated = false;
                throw ex;
            }
        }
        public bool GetClientCreated()
        {
            return isClientCreated;
        }

        public async Task<Microsoft.Azure.Cosmos.DatabaseResponse> CreateDataBaseAsync(string databaseName)
        {

            // string sql = "Create table ......"
            Microsoft.Azure.Cosmos.DatabaseResponse result = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseName);
            return result;
        }

        public async Task<Microsoft.Azure.Cosmos.ContainerResponse> CreateContainerAsync(Microsoft.Azure.Cosmos.Database databaseObj, 
                        string tableName,
                        string partitionKey)
        {

            // string sql = "Create table...."
            Microsoft.Azure.Cosmos.ContainerResponse result =  await databaseObj.CreateContainerIfNotExistsAsync(tableName, partitionKey);
            return result;
        }

        public void DisposeClient()
        {
            cosmosClient.Dispose();
            isClientCreated = false;

        }
        // Fill the local list of cloudDatabases

        public async Task GetDataBasesFromCloudAsync()
        {
            // Have more databases on cloud ?
            // Iterator => Has next/more ? yes ? Next Set Of Result
            // We are about to fetch the most updated data so we start
            // by cleaning the existing data
            cloudDatabases.Clear();

            // Cant get databases, just 1 database!!
            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> iterator =
                 cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();

            do
            {
                foreach (Microsoft.Azure.Cosmos.DatabaseProperties currentDB in await iterator.ReadNextAsync())
                {
                    Models.Database localDB = new Models.Database();
                    localDB.databaseId = currentDB.Id;
                    //localDB.eTag = currentDB.ETag;
                    // Add the local db into the local list
                    cloudDatabases.Add(localDB);
                    // LocalListOfCloudDatabases.Add...
                }


            } while (iterator.HasMoreResults);


            // When the code comes to this point then the local list is populated with all the db from cloud

            /*int[] a = new int[10];

            foreach (int current in a)
            {
                Console.WriteLine(current);
            }

            string[] b = new string[10];

            foreach (string current in b)
            {
                Console.WriteLine(current);
            }*/
        }

        public async Task GetTablesFromCloudAsync()
        {
            // We are about to fetch the most updated data so we start
            // by cleaning the existing data
            cloudTables.Clear();

            // Scan all the databases
            foreach(Models.Database db in cloudDatabases)
            {
                string currentDatabaseId = db.databaseId; // "Only" the db id

                // The Database object from the cloud
                Microsoft.Azure.Cosmos.Database currentCloudDB = cosmosClient.GetDatabase(currentDatabaseId);

                Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.ContainerProperties> tableIterator =
                    currentCloudDB.GetContainerQueryIterator<Microsoft.Azure.Cosmos.ContainerProperties>();

                do
                {
                    foreach(Microsoft.Azure.Cosmos.ContainerProperties table in await tableIterator.ReadNextAsync())
                    {
                        Models.Container currentLocalTable = new Models.Container();

                        currentLocalTable.databaseId = currentDatabaseId; // All the tables in the current DB have the same database ID
                        currentLocalTable.tableId = table.Id;
                        //currentLocalTable.selfLink = table.SelfLink;

                        cloudTables.Add(currentLocalTable);
                        
                    }

                } while (tableIterator.HasMoreResults);
                // We finish our work on the current DB (We retrived its tables)
            }
            // When the code comes to this point then the local list is populated with all the tables from cloud

        }

        public async Task<bool> CheckIfDatabaseExistsAsync_option1(string db)
        {
            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> iterator =
                 cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();

            do
            {
                foreach (Microsoft.Azure.Cosmos.DatabaseProperties currentDB in await iterator.ReadNextAsync())
                    if (currentDB.Id == db)
                        return true; // We found what we are looking for


            } while (iterator.HasMoreResults);
            // We didnt find what we are looking for
            return false;
        }


        public async Task<bool> CheckIfDatabaseExistsAsync_option2(string db)
        {
            // Fill the local list of Databases
            await GetDataBasesFromCloudAsync();
            // After this method is triggered - then cloudDatabases is populated

            // Scan the local DBs
            foreach (Models.Database localDB in cloudDatabases)
                if (localDB.databaseId == db)
                    return true;

            // We didnt find what we are looking for
            return false;
        }

        public async Task<bool> CheckIfDatabaseExistsAsync_option3(string db)
        {
            try
            {
                Microsoft.Azure.Cosmos.DatabaseResponse result = await cosmosClient.GetDatabase(db).ReadAsync();
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CheckIfTableExist_option1(string tableToFind)
        {
            // Populate the local lists
            await GetDataBasesFromCloudAsync(); // Populate cloudDatabases in LOCAL
            await GetTablesFromCloudAsync(); // Populate cloudTables       in LOCAL

            foreach (Models.Container table in cloudTables)
                if (table.tableId.Equals(tableToFind))
                    return true;

            // The input table was not found
            return true;
        }

        /*public async Task<List<string>> GetDBsWithTablesAsMyUserNameAsync_option1(string userName)
        {

            List<string> result = new List<string>();

            // Populate the local lists
            await GetDataBasesFromCloudAsync(); // Populate cloudDatabases in LOCAL
            await GetTablesFromCloudAsync(); // Populate cloudTables       in LOCAL

            foreach (Models.Container table in cloudTables)
                if (table.tableId.Equals(userName))
                    result.Add(GetCloudDatabases().ToString());

            return result;
        }*/

        public async Task<List<string>> GetDBsWithTablesAsMyUserName(string name)
        {
            List<string> result = new List<string>();

            // external iterator get the DB always
            // internal iteraton get the tables

            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> databaseIterator =
                cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();

            // HasMoreResults just have get
            while (databaseIterator.HasMoreResults) // Work as long as the iterator has more results
            {

                foreach(Microsoft.Azure.Cosmos.DatabaseProperties currentDatabase in await databaseIterator.ReadNextAsync())
                {
                    // working on the current Database (databaseIterator.ReadNextAsync())
                    // We will create a table iterator for the DB, and scan them

                    // bc there is no databaseS we use the GetDatabaseQueryIterator<...>
                    // for the container too

                    Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.ContainerProperties> containerIterator =
                        cosmosClient.GetDatabase(currentDatabase.Id).GetContainerQueryIterator<Microsoft.Azure.Cosmos.ContainerProperties>();

                    while (containerIterator.HasMoreResults) // כל זמן שיש לי עדיין טבלאות במסד נתונים הנוכחי
                    {
                        foreach(Microsoft.Azure.Cosmos.ContainerProperties currentTable in await containerIterator.ReadNextAsync())
                        {
                            // התנאי של התרגיל זה החזרת מסדי התונים שמכילים את טבלאות מסוימות
                            if (currentTable.Id.Contains(name) && (!result.Contains(currentDatabase.Id))) // to prevent repetitions
                                result.Add(currentDatabase.Id);
                        }
                    }
                }
            }
            
            return result;
        }

        public async Task<List<string>> GetDBsWithTablesAsMyUserNameAsync_option2(string userName)
        {

            List<string> result = new List<string>();

            // Populate the local lists
            await GetDataBasesFromCloudAsync(); // Populate cloudDatabases in LOCAL
            await GetTablesFromCloudAsync(); // Populate cloudTables       in LOCAL


                foreach (Models.Container table in cloudTables)
                    if (table.tableId.Equals(userName))
                        result.Add(table.databaseId);


            return result;
        }


        public async Task<bool> CheckIfTableExist_option2(string tableToFind)
        {
            // Populate the local lists
            await GetDataBasesFromCloudAsync(); // Populate cloudDatabases


            // GetDataBasesFromCloudAsync memale it cloudDatabases
            foreach (Models.Database currentDB in cloudDatabases)
            {
                string databaseId = currentDB.databaseId;

                // Get table's iterator = current database
                Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.ContainerProperties> iterator =
                    cosmosClient.GetDatabase(databaseId).GetContainerQueryIterator<Microsoft.Azure.Cosmos.ContainerProperties>();

                while (iterator.HasMoreResults)
                {
                    foreach (Microsoft.Azure.Cosmos.ContainerProperties container in await iterator.ReadNextAsync())
                        if (container.Id == tableToFind)
                            return true;
                }
            }
            return false;
        }


        public async Task<bool> CheckIfTableExist_option3(string tableToFind)
        {
            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> databaseIterator =
                cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();

            while(databaseIterator.HasMoreResults)
            {
                foreach(Microsoft.Azure.Cosmos.DatabaseProperties database in await databaseIterator.ReadNextAsync())
                {
                    string currentId = database.Id;

                    Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.ContainerProperties> containerIterator = 
                        cosmosClient.GetDatabase(currentId).GetContainerQueryIterator<Microsoft.Azure.Cosmos.ContainerProperties>(); 

                    while(containerIterator.HasMoreResults)
                    {
                        foreach (Microsoft.Azure.Cosmos.ContainerProperties container in await containerIterator.ReadNextAsync())
                            if (container.Id == tableToFind)
                                return true;                        
                    }
                }
            }
            return false;
        }


        public async Task<bool> CheckIfTableExist(string table)
        {
         
            await GetDataBasesFromCloudAsync();
            await GetTablesFromCloudAsync();  

            foreach (Models.Container localTable in cloudTables)
            {
                if (localTable.tableId == table)
                    return true;
            }
            return false;
        }

        public async Task<List<string>> GetDBsWithAtLeastXtables(int minNumOfTables)
        {
            List<string> result = new List<string>();

            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> databaseIterator =
                cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();

            int count = 0;
            while (databaseIterator.HasMoreResults) 
            {
                foreach (Microsoft.Azure.Cosmos.DatabaseProperties currentDatabase in await databaseIterator.ReadNextAsync())
                {
                    count = 0;

                    Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.ContainerProperties> containerIterator =
                        cosmosClient.GetDatabase(currentDatabase.Id).GetContainerQueryIterator<Microsoft.Azure.Cosmos.ContainerProperties>();

                    while (containerIterator.HasMoreResults) // כל זמן שיש לי עדיין טבלאות במסד נתונים הנוכחי
                    {
                        foreach (Microsoft.Azure.Cosmos.ContainerProperties currentTable in await containerIterator.ReadNextAsync())
                        {
                            count++;
                            // התנאי של התרגיל זה החזרת מסדי המתונים שמכילים את טבלאות מסוימות
                        }
                    }
                    if (count >= minNumOfTables && (!result.Contains(currentDatabase.Id))) // to prevent חזרות
                        result.Add(currentDatabase.Id);
                }
            }
            return result;
        }

        public async Task DeleteSelectedDBAsync(string selectedDB)
        {
            // Was void but we have to do it async
            // ReadAsync --> 
            Microsoft.Azure.Cosmos.DatabaseResponse databaseResponse =
                   await cosmosClient.GetDatabase(selectedDB).DeleteAsync();

        }

        public async Task PerformDataActivityInCloudAsync(string selectedDB,
                                                           string selectedTable,
                                                           List<Student> students, // The Data from the json (המשתמש הקליד) 
                                                           string selectedActivity)

        {
            // Get Container object
            // Option1:

            /*Microsoft.Azure.Cosmos.ContainerResponse containerResponse = 
                await cosmosClient.GetContainer(selectedDB, selectedTable).ReadContainerAsync();*/

            // Option2:
            Microsoft.Azure.Cosmos.ContainerResponse containerResponse =
                await cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;

            bool isStudentExist = false;


            List<Student> failures = new List<Student>();

            // Review all students
            foreach(Models.Student student in students)
            {
                string currentId = student.id;

                try
                {
                    Microsoft.Azure.Cosmos.ItemResponse<Models.Student> result =
                        await container.ReadItemAsync<Models.Student>(currentId,
                            new Microsoft.Azure.Cosmos.PartitionKey(currentId));

                    isStudentExist = true;
                }
                catch (Exception ex)
                {
                    isStudentExist = false;
                }

                // בשלב הזה יודעים אם הסטודינט הנוכחי קיים או לא
                if (selectedActivity.ToLower().Trim().Contains("insert")) // לשפר את הקוד !!!!!!
                {
                    if (!isStudentExist)
                    {
                        // insert studnt process
                        await container.CreateItemAsync(student, new Microsoft.Azure.Cosmos.PartitionKey(currentId));
                        continue;
                    }

                    else
                    {
                        failures.Add(student); // רשות
                        continue;
                    }
                }

                if (selectedActivity.ToLower().Contains("delete"))
                {
                    if (isStudentExist)
                    {
                        await container.DeleteItemAsync<Student>(currentId, new Microsoft.Azure.Cosmos.PartitionKey(currentId));
                        continue; ;
                    }
                    else
                    {
                        failures.Add(student);
                        continue;
                    }
                }

                if (selectedActivity.ToLower().Contains("modify"))
                {
                    if (isStudentExist)
                    {
                        await container.ReplaceItemAsync(student, currentId, new Microsoft.Azure.Cosmos.PartitionKey(currentId));
                        continue;
                    }

                    else
                    {
                        failures.Add(student);
                        continue;
                    }
                }
                
            }
        }

        public async Task PerformDataActivityInCloudAsync(string selectedDB,
                                                           string selectedTable,
                                                           List<Adult> adults, // The Data from the json (המשתמש הקליד) 
                                                           string selectedActivity)

        {
            // Get Container object
            // Option1:

            /*Microsoft.Azure.Cosmos.ContainerResponse containerResponse = 
                await cosmosClient.GetContainer(selectedDB, selectedTable).ReadContainerAsync();*/

            // Option2:
            Microsoft.Azure.Cosmos.ContainerResponse containerResponse =
                await cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;

            bool isAdultExist = false;


            List<Adult> failures = new List<Adult>();

            // Review all students
            foreach (Models.Adult adult in adults)
            {
                string currentId = adult.id;

                try
                {
                    Microsoft.Azure.Cosmos.ItemResponse<Models.Adult> result =
                        await container.ReadItemAsync<Models.Adult>(currentId,
                            new Microsoft.Azure.Cosmos.PartitionKey(currentId));

                    isAdultExist = true;
                }
                catch (Exception ex)
                {
                    isAdultExist = false;
                }

                // בשלב הזה יודעים אם הסטודינט הנוכחי קיים או לא
                if (selectedActivity.ToLower().Trim().Contains("insert")) // לשפר את הקוד !!!!!!
                {
                    if (!isAdultExist)
                    {
                        // insert studnt process
                        await container.CreateItemAsync(adult, new Microsoft.Azure.Cosmos.PartitionKey(currentId));
                        continue;
                    }

                    else
                    {
                        failures.Add(adult); // רשות
                        continue;
                    }
                }

                if (selectedActivity.ToLower().Contains("delete"))
                {
                    if (isAdultExist)
                    {
                        await container.DeleteItemAsync<Adult>(currentId, new Microsoft.Azure.Cosmos.PartitionKey(currentId));
                        continue; ;
                    }
                    else
                    {
                        failures.Add(adult);
                        continue;
                    }
                }

                if (selectedActivity.ToLower().Contains("modify"))
                {
                    if (isAdultExist)
                    {
                        await container.ReplaceItemAsync(adult, currentId, new Microsoft.Azure.Cosmos.PartitionKey(currentId));
                        continue;
                    }

                    else
                    {
                        failures.Add(adult);
                        continue;
                    }
                }

            }
        }

        public async Task DeteleSelectedContainerAsync(string selectedDB, string selectedTable)
        {
            // Option 1
            Microsoft.Azure.Cosmos.ContainerResponse containerResponse =
                  await cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).DeleteContainerAsync();

            // Option 2
            // Microsoft.Azure.Cosmos.ContainerResponse containerResponse =
            //     cosmosClient.GetContainer(selectedDB, selectedTable).DeleteContainerAsync();
        }

        public async void DeleteAllDBsFromCloud()
        {
            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> iterator =
                 cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();
            do
            {
                foreach (Microsoft.Azure.Cosmos.DatabaseProperties currentDB in
                                                await iterator.ReadNextAsync())
                    await cosmosClient.GetDatabase(currentDB.Id).DeleteAsync();
            } while (iterator.HasMoreResults);
        }

        public async Task<int> GetNumberOfDBs()
        {
            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> iterator =
                 cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();
            int count = 0;
            while (iterator.HasMoreResults)
                foreach (Microsoft.Azure.Cosmos.DatabaseProperties currentDatabase in await iterator.ReadNextAsync())
                    count++;
            return count;
        }

        public async Task<int> GetNumberOfTables()
        {
            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> databaseIterator =
                cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();

            int count = 0;

            while (databaseIterator.HasMoreResults)
            {
                foreach (Microsoft.Azure.Cosmos.DatabaseProperties currentDatabase in await databaseIterator.ReadNextAsync())
                {
                    Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.ContainerProperties> containerIterator =
                        cosmosClient.GetDatabase(currentDatabase.Id).GetContainerQueryIterator<Microsoft.Azure.Cosmos.ContainerProperties>();
                    while (containerIterator.HasMoreResults) 
                        foreach (Microsoft.Azure.Cosmos.ContainerProperties currentTable in await containerIterator.ReadNextAsync())
                            count++;
                }
            }
            return count;
        }

        /*public string FilterJSON(string filter)
        {



        }*/

        /*public async Task<Models.Student> CheckIfItemIdExists(string selectedDB, string selectedTable, string idToChk)
        {
            Microsoft.Azure.Cosmos.ContainerResponse containerResponse =
                await cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

           // Microsoft.Azure.Cosmos.Container container = containerResponse.Container;
            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;


            *//*Microsoft.Azure.Cosmos.FeedIterator<Models.Student> itemsId =
                await container.GetItemQueryIterator<Models.Student>();*//*

            Microsoft.Azure.Cosmos.ItemResponse<Models.Student> itemId =
                        await container.ReadItemAsync<Models.Student>(idToChk,
                            new Microsoft.Azure.Cosmos.PartitionKey(idToChk));

                try
                {
                    Microsoft.Azure.Cosmos.ItemResponse<Models.Student> result =
                        await container.ReadItemAsync<Models.Student>(idToChk,
                            new Microsoft.Azure.Cosmos.PartitionKey(idToChk));

                if (itemId.StatusCode == System.Net.HttpStatusCode.OK)
                    return result.Resource;

                }
                catch (Exception ex)
                {
                return null;
                }
            return null;

        }*/
        public async Task<Models.Student> CheckIfItemIdExists1(string selectedDB, string selectedTable, string idToChk)
        {
            Microsoft.Azure.Cosmos.Container container =
                cosmosClient.GetContainer(selectedDB, selectedTable);

            try
            {
                Microsoft.Azure.Cosmos.ItemResponse<Models.Student> result =
                    await container.ReadItemAsync<Models.Student>(idToChk,
                        new Microsoft.Azure.Cosmos.PartitionKey(idToChk));
                return result.Resource;
            }
            catch
            {
                return null;
            }
        }

        public async Task<string> CheckIfItemIdExists2(string selectedDB, string selectedTable, string idToChk)
        {
            string result = string.Empty;

            Microsoft.Azure.Cosmos.ContainerResponse containerResponse = await
                cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;

            try
            {
                Microsoft.Azure.Cosmos.ItemResponse<Models.Student> record =
                    await container.ReadItemAsync<Models.Student>(idToChk,
                        new Microsoft.Azure.Cosmos.PartitionKey(idToChk));

                result = System.Text.Json.JsonSerializer.Serialize(record.Resource);
            }
            catch
            {
                result = "Item " + idToChk + " Does not exist in table '" +
                    selectedTable + "' within DB '" + selectedDB + "'";
            }
            return result;
        }

        public async Task<Student> CheckIfItemIdExistsAsync3(string selectedDB, string selectedTable,
                                                              string idToChk)
        { // with iterator
            Models.Student result = null; //async Task<Student>

            List<Student> res = new List<Student>(); //async Task<List<Student>>

            Microsoft.Azure.Cosmos.ContainerResponse containerResponse = await
                cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

            // Get the Table object
            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;
            try
            {
                Microsoft.Azure.Cosmos.FeedIterator<Models.Student> iterator =
                    container.GetItemQueryIterator<Models.Student>();

                while (iterator.HasMoreResults)
                    foreach (Student student in await iterator.ReadNextAsync())
                        if (student.id == idToChk) return student;
            }
            catch
            {
                return null;
            }
            return result;
        }
        /*{
                            if(student.FirstName == "Bahaa") // Search by name and address
                            {
                                Address[] addresses = student.addresses;
                                for (int i = 0; i < addresses.Length; i++)
                                    if (addresses[i].City.Equals("Haifa"))
                                    {
                                        //res.Add(student);
                                        Course[] courses = student.courses;
                                    }
                            }
                        }*/



        public async Task<List<Student>> ExecuteFilter(string selectedDB, string selectedTable,
                                                       string firstName, string city, string courseName)
        {
            List<Student> res = new List<Student>(); //async Task<List<Student>>

            Microsoft.Azure.Cosmos.ContainerResponse containerResponse =
                 await cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;
            
            try
            {
                Microsoft.Azure.Cosmos.FeedIterator<Models.Student> iterator =
                    container.GetItemQueryIterator<Models.Student>();

                while (iterator.HasMoreResults)
                    foreach (Student student in await iterator.ReadNextAsync())
                        if (student.FirstName == firstName) // Search by name and address
                        {
                            Address[] addresses = student.addresses;
                            for (int i = 0; i < addresses.Length; i++)
                                if (addresses[i].City.Equals(city))
                                {
                                    Course[] courses = student.courses;
                                    for (int j = 0; j < courses.Length; j++)
                                        if (courses[j].CourseName.Equals(courseName))
                                            res.Add(student);
                                }
                        }
            }
            catch
            {
                return null;
            }
            return res;
        }

        public async Task<string> FilterJSON(string selectedDB, string selectedTable, string filter)
        {

            string result = string.Empty;

            Microsoft.Azure.Cosmos.ContainerResponse containerResponse =
               await cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

            // Microsoft.Azure.Cosmos.Container container = containerResponse.Container;
            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;

            Task<ItemResponse<Student>> items = container.ReadItemAsync<Student>(filter, new Microsoft.Azure.Cosmos.PartitionKey(filter));

            try
            {
                result = System.Text.Json.JsonSerializer.Serialize(items.Result);
            }
            catch
            {
                result = "Item " + filter + " Does not exist in table '" + selectedTable + "' within DB '" + selectedDB + "'";
            }

            return result;

        }

        public async Task<Student> SearchFirstNameContainsAndAll(string selectedDB, string selectedTable,
                                                                  string firstNameContains,
                                                                  string cityStartsWith,
                                                                  int minCoursesNum)
        {
            List<Student> res = new List<Student>();

            Microsoft.Azure.Cosmos.ContainerResponse containerResponse = await
                cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();
            int count = 0;
            // Get the Table object
            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;
            try
            {
                Microsoft.Azure.Cosmos.FeedIterator<Models.Student> iterator =
                    container.GetItemQueryIterator<Models.Student>();

                while (iterator.HasMoreResults)
                    foreach (Student student in await iterator.ReadNextAsync())
                        if (student.FirstName.Contains(firstNameContains))
                        {
                            Address[] addresses = student.addresses;
                                for (int i = 0; i < addresses.Length; i++)
                                    if (addresses[i].City.StartsWith(cityStartsWith))
                                    {
                                        Course[] courses = student.courses;
                                        for (int j = 0; j < courses.Length; j++)
                                            count++;
                                        
                                        if (count >= minCoursesNum)
                                        return student;

                                    }
                        }
            }
            catch
            {
                return null;
            }
            return null;
        }
        public async Task<List<Student>> SearchFirstNameContainsAndAllLior(string selectedDB, string selectedTable,
                                                                  string firstNameContains,
                                                                  string cityStartsWith,
                                                                  int minCoursesNum)
        {
            List<Student> students = new List<Student>();

            Microsoft.Azure.Cosmos.ContainerResponse containerResponse = await
                cosmosClient.GetDatabase(selectedDB).GetContainer(selectedTable).ReadContainerAsync();

            Microsoft.Azure.Cosmos.Container container = containerResponse.Container;

            Microsoft.Azure.Cosmos.FeedIterator<Student> studentIterator =
                container.GetItemQueryIterator<Models.Student>();
            // so in the foreach we take this (Student) his type
            while (studentIterator.HasMoreResults)
            {
                foreach(Student student in await studentIterator.ReadNextAsync())
                {
                    // Review all the items according to the filter
                    if (String.IsNullOrEmpty(student.FirstName)) continue;
                    if (!student.FirstName.Contains(firstNameContains)) continue;

                    // if the code come here then the student's name is עונה to the filter name
                    Address[] addresses = student.addresses;
                    if (addresses == null) continue;

                    foreach(Address address in addresses)
                    {
                        if (!address.City.StartsWith(cityStartsWith)) continue;

                        // כעת ניתן לבחון את הקורסים שלו
                        Course[] courses = student.courses;
                        if (courses == null) continue; // מקיים CITY ו NAME START WITH

                        if (courses.Length >= minCoursesNum)
                            students.Add(student);
                    }
                }
            }
            return students;
        }
        public async Task<List<Student>> getAllRecordsAsync(string dbFilter, string tableFilter, int firstNameLenFilter)
        {

            List<Student> students = new List<Student>();

            Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.DatabaseProperties> dbIterator =
                 cosmosClient.GetDatabaseQueryIterator<Microsoft.Azure.Cosmos.DatabaseProperties>();

            while(dbIterator.HasMoreResults)
            {
                foreach(Microsoft.Azure.Cosmos.DatabaseProperties databaseProperties in
                        await dbIterator.ReadNextAsync())
                {
                    if (!databaseProperties.Id.EndsWith(dbFilter)) continue;

                    Microsoft.Azure.Cosmos.FeedIterator<Microsoft.Azure.Cosmos.ContainerProperties>
                        containerIterator = cosmosClient.GetDatabase(databaseProperties.Id)
                            .GetContainerQueryIterator<Microsoft.Azure.Cosmos.ContainerProperties>();

                    while(containerIterator.HasMoreResults)
                    {
                        // when i want to do foreach i look here -->
                        foreach(Microsoft.Azure.Cosmos.ContainerProperties containerProperties in
                                await containerIterator.ReadNextAsync())
                        {
                            if (!containerProperties.Id.StartsWith(tableFilter)) continue;

                            Microsoft.Azure.Cosmos.FeedIterator<Models.Student> studentsIterator =
                                cosmosClient.GetDatabase(databaseProperties.Id).GetContainer
                                    (containerProperties.Id).GetItemQueryIterator<Models.Student>();

                            while(studentsIterator.HasMoreResults)
                            {
                                // Here we search student that his name's length is exactly as the filter
                                foreach (Models.Student student in await studentsIterator.ReadNextAsync())
                                {
                                    if (String.IsNullOrEmpty(student.FirstName)) continue;
                                    if (student.FirstName.Length == firstNameLenFilter)
                                        students.Add(student);
                                }
                            }
                        }
                    }
                }
            }
            return students;
        }
    }
}
