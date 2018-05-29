using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmLight1
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {

        //#region ----------------- Label DP ------------------
        ///// <summary>
        ///// Gets or sets the Label which is displayed next to the field
        ///// </summary>
        //public object Value
        //{
        //    get { return (object)GetValue(ValueProperty); }
        //    set { SetValue(ValueProperty, value); }
        //}

        ///// <summary>
        ///// Identified the Label dependency property
        ///// </summary>
        //public static readonly DependencyProperty ValueProperty =
        //    DependencyProperty.Register("Value", typeof(object),
        //      typeof(UserControl2), new PropertyMetadata(""));
        //#endregion

        #region Value DP

        /// <summary>
        /// Gets or sets the Value which is being displayed
        /// </summary>
        public object Value
        {
            get { return (object)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(object),
              typeof(UserControl2), new PropertyMetadata(null));

        #endregion


        public UserControl2()
        {
            InitializeComponent();
        }

    }
}
