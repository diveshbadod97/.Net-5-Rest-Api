namespace Catalog.Settings{
    public class MongoDbSettings{
        public string Host { get; set;}

        public int Port { get; set; }

        public string User { get; private set; }

        public string Password { get; private set; }


        public string ConnectionString { 
            get{
            return $"mongodb://{Host}:{Port}";
            }
        }
    }
}