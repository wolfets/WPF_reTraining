using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmLight1.UC
{
    /// <summary>
    /// Logique d'interaction pour UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        #region Value DP
        /// <summary>
        /// Gets or sets the Value which is being displayed
        /// </summary>
        public object ValueDIMain
        {
            get { return (object)GetValue(ValueDIMainProperty); }
            set { SetValue(ValueDIMainProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty ValueDIMainProperty =
            DependencyProperty.Register("ValueDIMain", typeof(object),
              typeof(UserControl3), new PropertyMetadata(null));
        #endregion


        public UserControl3()
        {
            InitializeComponent();
        }
    }
}
