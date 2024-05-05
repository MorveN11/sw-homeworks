namespace HomeWorks.JeffersonCoronel.May.Fourth
{
    abstract class DataMiner {
        public void MineData()
        {
            ConnectToDatabase();
            SelectDataSource();
            ProcessData();
            ParseAndFormatData();
            SendFormattedData();
            DisconnectFromDatabase();
        }

        protected abstract void ConnectToDatabase();
        protected abstract void SelectDataSource();
        protected abstract void ProcessData();
        protected virtual void ParseAndFormatData() { }
        protected virtual void SendFormattedData() { }

        protected virtual void DisconnectFromDatabase()
        {
            Console.WriteLine("Finalizing the connection with the database ...");
        }
    }

    class SQLDataMiner : DataMiner
    {
        protected override void ConnectToDatabase()
        {
            Console.WriteLine("Connecting to SQL database...");
        }

        protected override void SelectDataSource()
        {
            Console.WriteLine("Selecting tables from SQL database...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Processing data from SQL database...");
        }
    }

    class MongoDataMiner : DataMiner
    {
        protected override void ConnectToDatabase()
        {
            Console.WriteLine("Connecting to MongoDB database...");
        }

        protected override void SelectDataSource()
        {
            Console.WriteLine("Selecting collections from MongoDB...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Processing data from MongoDB...");
        }

        protected override void ParseAndFormatData()
        {
            Console.WriteLine("Parsing and formatting data from MongoDB...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataMiner sqlMiner = new SQLDataMiner();
            sqlMiner.MineData();

            Console.WriteLine();

            DataMiner mongoMiner = new MongoDataMiner();
            mongoMiner.MineData();
        }
    }
}
