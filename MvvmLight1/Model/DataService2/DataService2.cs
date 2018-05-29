using System;

namespace MvvmLight1.Model
{
    public class DataService2 : IDataService2
    {
        public void GetData(Action<DataItem2, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item2 = new DataItem2("DataService2");
            callback(item2, null);
        }
    }
}