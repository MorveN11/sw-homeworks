namespace HomeWorks.JeferssonCoronel.May.Fourth
{
    interface IDataOperations
    {
        void ConnectToDatabase();
        void SelectDataSource();
        void ProcessData();
        void ParseAndFormatData();
        void SendFormattedData();
        void DisconnectFromDatabase();
    }

    class SQLDataOperations : IDataOperations
    {
        public void ConnectToDatabase()
        {
            Console.WriteLine("Connecting to SQL database...");
        }

        public void SelectDataSource()
        {
            Console.WriteLine("Selecting tables from SQL database...");
        }

        public void ProcessData()
        {
            Console.WriteLine("Processing data from SQL database...");
        }

        public void ParseAndFormatData() { }

        public void SendFormattedData() { }

        public void DisconnectFromDatabase()
        {
            Console.WriteLine("Finalizing the connection with the SQL database...");
        }
    }

    class MongoDataOperations : IDataOperations
    {
        public void ConnectToDatabase()
        {
            Console.WriteLine("Connecting to MongoDB...");
        }

        public void SelectDataSource()
        {
            Console.WriteLine("Selecting collections from MongoDB...");
        }

        public void ProcessData()
        {
            Console.WriteLine("Processing data from MongoDB...");
        }

        public void ParseAndFormatData()
        {
            Console.WriteLine("Parsing and formatting data from MongoDB...");
        }

        public void SendFormattedData() { }

        public void DisconnectFromDatabase()
        {
            Console.WriteLine("Finalizing the connection with the MongoDB database...");
        }
    }

    class DataMiner
    {
        private IDataOperations dataOperations;

        public DataMiner(IDataOperations dataOperations)
        {
            this.dataOperations = dataOperations;
        }

        public void MineData()
        {
            dataOperations.ConnectToDatabase();
            dataOperations.SelectDataSource();
            dataOperations.ProcessData();
            dataOperations.ParseAndFormatData();
            dataOperations.SendFormattedData();
            dataOperations.DisconnectFromDatabase();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataMiner sqlMiner = new DataMiner(new SQLDataOperations());
            sqlMiner.MineData();

            Console.WriteLine();

            DataMiner mongoMiner = new DataMiner(new MongoDataOperations());
            mongoMiner.MineData();
        }
    }
}
