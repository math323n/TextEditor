using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TextEditor.ViewModels
{
    public class HelpViewModel : ObservableObjects
    {
        public ICommand HelpCommand
        {
            get;
        }
        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DisplayAbout);
        }

        private void DisplayAbout()
        {
            //Display about
        }
    }
}