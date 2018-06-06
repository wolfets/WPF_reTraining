using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using MvvmLight1.Messages;
using MvvmLight1.Model;

namespace MvvmLight1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModelUC3 : ViewModelBase
    {
        private readonly IDataServiceUC3 _dataService;

        //public MainViewModel vmMain;

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle2222";

        private string _welcomeTitle = string.Empty;
        private string _welcomeTitle1 = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
                RaisePropertyChanged("WelcomeTitle");

            }
        }
        public string WelcomeTitle1
        {
            get
            {
                MainViewModel vmMain = ServiceLocator.Current.GetInstance<MainViewModel>();
                return vmMain.WelcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle1, value);
                //if (vmMain!=null)
                //    vmMain.WelcomeTitle = value;
                RaisePropertyChanged("WelcomeTitle1");

            }
        }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModelUC3(IDataServiceUC3 dataServiceUC3, IDataService dataServiceMain)
        {
            _dataService = dataServiceUC3;
            DataItem _di = new DataItem("Di créé par..... DIUC3");
            _dataService.GetData(
                (item, itemMain, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    WelcomeTitle = item.Title;
                    //var diM = item.getDataItemMain();
                    //WelcomeTitle1 = "?????";
                    //if (diM!=null)
                    //    WelcomeTitle1 = item.getDataItemMain().Title;
                });


            ////------au moment de la réception du message ...on maj
            //_dataService.SetData(_di.Title, (item, error) =>
            //{
            //    WelcomeTitle = item.Title;
            //});
            //var model2 = new ModelObject()
            //{
            //    Shoesize = 12,
            //    Height = 34.5
            //};

            //----messages 
            Messenger.Default.Register<StatusMessage>(this, (e) =>
            {
                WelcomeTitle1 = e.Message;
            });



        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}