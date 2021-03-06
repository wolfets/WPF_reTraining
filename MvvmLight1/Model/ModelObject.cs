﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace MvvmLight1.Model
{
  public class ModelObject : INotifyPropertyChanged
  {
    private int _shoesize;

    public int Shoesize
    {
      get { return _shoesize; }
      set
      {
        _shoesize = value;
        OnPropertyChanged("Shoesize");
      }
    }

    private double _height;

    public double Height
    {
      get { return _height; }
      set
      {
        _height = value;
        OnPropertyChanged("Height");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}
