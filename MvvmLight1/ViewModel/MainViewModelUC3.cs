using GalaSoft.MvvmLight;
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
                return _welcomeTitle1;
            }
            set
            {
                Set(ref _welcomeTitle1, value);
                RaisePropertyChanged("WelcomeTitle1");

            }
        }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModelUC3(IDataServiceUC3 dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                    var diM = item.getDataItemMain();
                    WelcomeTitle1 = "?????";
                    if (diM!=null)
                        WelcomeTitle1 = item.getDataItemMain().Title;
                });


            var model2 = new ModelObject()
            {
                Shoesize = 12,
                Height = 34.5
            };
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}