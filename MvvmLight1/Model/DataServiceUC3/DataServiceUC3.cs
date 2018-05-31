using System;

namespace MvvmLight1.Model
{
    public class DataServiceUC3 : IDataServiceUC3
    {
<<<<<<< HEAD
        public void GetData(Action<DataItemUC3, DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item2 = new DataItemUC3("DataServiceUC3");
            var item = new DataItem("DataService de UC3");
            callback(item2, item, null);
=======
        DataItemUC3 item2 = null;
        public void GetData(Action<DataItemUC3, Exception> callback)
        {
            // Use this to connect to the actual data service

            item2 = new DataItemUC3("DataServiceUC3");
            callback(item2, null);
>>>>>>> c7bf47f347f3d01c4f0d392bbf25547564c1da07
        }

        public void SetData(string diTitle, Action<DataItemUC3, Exception> callback)
        {
            //var item2 = new DataItemUC3(diTitle);
            callback(item2, null);
            //throw new NotImplementedException();
        }
    }
}