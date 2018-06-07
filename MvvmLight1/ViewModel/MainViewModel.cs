using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight1.Messages;
using MvvmLight1.Model;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace MvvmLight1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

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

                Messenger.Default.Send<StatusMessage>(new StatusMessage(value));
            }
        }

        public ModelObject model2 { get; set; }



        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
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
                });


            var model2 = new ModelObject()
            {
                Shoesize = 12,
                Height = 34.5
            };
        }





        RelayCommand _btnT92;
        public ICommand BtnT92
        {
            get
            {
                if (_btnT92 == null)
                {
                    _btnT92 = new RelayCommand(() =>
                    {
                        MessageBoxResult result = MessageBox.Show("Charge(_dataService, 4) ?", "Traitement", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {

                            WelcomeTitle = "réinit du message";
                            //Messenger.Default.Send<StatusMessage>(new StatusMessage("réinit du message"));

                            //this.Dispatcher.Invoke(DispatcherPriority.Background,
                            //     new Action<object>(SetStatus),
                            //     new object[2] { tir, listeComb });
                            //private void SetStatus(object xxx)
                            //{
                            //    //object[] xxxs = (object[])xxx;
                            //    //Tirage tir = (Tirage)xxxs[0];
                            //    //label1.Content = tir.Id.ToString() + "   " + ((List<string>)xxxs[1]).Count.ToString();
                            //    if (label1 != null)
                            //    {
                            //        object[] xxxs = (object[])xxx;
                            //        string tir = (string)xxxs[0];
                            //        label1.Content = tir.ToString() + "   " + ((List<string>)xxxs[1]).Count.ToString();
                            //    }
                            //}






                            //////File.Delete(fichierFinTraitementT4);

                            //timerT = new System.Timers.Timer();
                            //timerT.Elapsed += new System.Timers.ElapsedEventHandler(tickT9);
                            //timerT.Interval = 1000;
                            //timerT.Start();
                            //var uiContext = TaskScheduler.Default;// FromCurrentSynchronizationContext();
                            //http://blogs.msdn.com/b/pfxteam/archive/2011/10/24/10229468.aspx
                            //Task.Factory.StartNew(() =>
                            //{
                            //    //-------------------- 
                            //    //Charge(4);
                            //    ///////////////////LoadFichierT9();
                            //    Messenger.Default.Send<StatusMessage>(new StatusMessage("réinit du message"));

                            //    return true;
                            //}, CancellationToken.None, TaskCreationOptions.LongRunning, uiContext);
                        }
                    }, () => { return true; });
                }
                return _btnT92;
            }
        }




        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}