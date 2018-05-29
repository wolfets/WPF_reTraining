using System;

namespace MvvmLight1.Model
{
    public class DataServiceUC3 : IDataServiceUC3
    {
        public void GetData(Action<DataItemUC3, DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item2 = new DataItemUC3("DataServiceUC3");
            var item = new DataItem("DataService de UC3");
            callback(item2, item, null);
        }

        void IDataServiceUC3.SetData(Action<DataItemUC3, Exception> callback)
        {
            throw new NotImplementedException();
        }
    }
}