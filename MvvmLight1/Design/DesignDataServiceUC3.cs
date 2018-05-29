using System;
using MvvmLight1.Model;

namespace MvvmLight1.Design
{
    public class DesignDataServiceUC3 : IDataServiceUC3
    {
        public void GetData(Action<DataItemUC3, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItemUC3("DataService2 [design]");
            callback(item, null);
        }

        public void SetData(Action<DataItemUC3, Exception> callback)
        {
            throw new NotImplementedException();
        }
    }
}