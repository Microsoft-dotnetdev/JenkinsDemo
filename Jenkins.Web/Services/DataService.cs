namespace Jenkins.Web.Services
{
    public class DataService : IDataService
    {
        public string GetHost()
        {
            return Environment.MachineName;
        }
    }
}
