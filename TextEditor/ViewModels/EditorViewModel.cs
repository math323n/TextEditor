﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TextEditor.Models;

namespace TextEditor.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand
        {
            get;
        } 
        public ICommand WrapCommand
        {
            get;
        }
        public FormatModel Format
        {
            get; set;
        }
        public DocumentModel Document
        {
            get; set;
        }

        public EditorViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);
            
        }

        private void OpenStyleDialog()
        {
            //
            throw new NotImplementedException();
        }

        private void ToggleWrap()
        {
            if(Format.Wrap == System.Windows.TextWrapping.Wrap)
            {
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                Format.Wrap = System.Windows.TextWrapping.Wrap;
            }
        }
    }
}