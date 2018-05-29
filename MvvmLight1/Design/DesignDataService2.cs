using System;
using MvvmLight1.Model;

namespace MvvmLight1.Design
{
    public class DesignDataService2 : IDataService2
    {
        public void GetData(Action<DataItem2, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem2("DataService2 [design]");
            callback(item, null);
        }
    }
}