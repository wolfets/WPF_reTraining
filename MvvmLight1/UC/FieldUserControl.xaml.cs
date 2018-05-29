using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MvvmLight1
{
  public partial class FieldUserControl : UserControl
  {
    #region Label DP

    /// <summary>
    /// Gets or sets the Label which is displayed next to the field
    /// </summary>
    public String Label
    {
      get { return (String)GetValue(LabelProperty); }
      set { SetValue(LabelProperty, value); }
    }

    /// <summary>
    /// Identified the Label dependency property
    /// </summary>
    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register("Label", typeof(string),
          typeof(FieldUserControl), new PropertyMetadata(""));

    #endregion

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
          typeof(FieldUserControl), new PropertyMetadata(null));

    #endregion

    public FieldUserControl()
    {
      InitializeComponent();
    }
  }
}
