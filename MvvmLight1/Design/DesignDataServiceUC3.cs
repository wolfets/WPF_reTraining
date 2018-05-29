using System;
using MvvmLight1.Model;

namespace MvvmLight1.Design
{
    public class DesignDataServiceUC3 : IDataServiceUC3
    {
        public void GetData(Action<DataItemUC3, DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItemUC3("DataServiceUC3 [design]");
            var itemMain = new DataItem("DataService from UC3 [design]");
            callback(item, itemMain, null);
        }

        public void SetData(Action<DataItemUC3, Exception> callback)
        {
            throw new NotImplementedException();
        }
    }
}