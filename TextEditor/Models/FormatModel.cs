using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace TextEditor.Models
{
    public class FormatModel : ObservableObjects
    {
        private FontStyle style;
        public FontStyle Style
        {
            get
            {
                return style;
            }
            set
            {
                OnPropertyChanged(ref style, value);
            }
        }

        private FontWeight weight;
        public FontWeight Weight
        {
            get
            {
                return weight;
            }
            set
            {
                OnPropertyChanged(ref weight, value);
            }
        }
        private FontFamily family;
        public FontFamily Family
        {
            get
            {
                return family;
            }
            set
            {
                OnPropertyChanged(ref family, value); 
            }
        }

        private TextWrapping wrap;
        public TextWrapping Wrap
        {
            get
            {
                return wrap;
            }
            set
            {
                OnPropertyChanged(ref wrap, value);
                isWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        private bool isWrapped;
        public bool IsWrapped
        {
            get
            {
                return isWrapped;
            }
            set
            {
                OnPropertyChanged(ref isWrapped, value);
            }
        }

        private double size;
        public double Size
        {
            get
            {
                return size;
            }
            set
            {
                OnPropertyChanged(ref size, value);
            }
        }

    }
}