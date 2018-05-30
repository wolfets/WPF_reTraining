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

        public void SetData(string diTitle, Action<DataItemUC3, Exception> callback)
        {
            var item2 = new DataItemUC3(diTitle);
            callback(item2, null);
            //throw new NotImplementedException();
        }
    }
}