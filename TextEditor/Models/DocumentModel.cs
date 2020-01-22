using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor.Models
{
    public class DocumentModel: ObservableObjects
    {
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                OnPropertyChanged(ref text, value);
            }
        }

        private string filePath;
        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                OnPropertyChanged(ref filePath, value);
            }
        }

        private string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                OnPropertyChanged(ref fileName, value);
            }
        }

        public bool isEmpty
        {
            get
            {
                if(string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {

            }
        }

    }
}
