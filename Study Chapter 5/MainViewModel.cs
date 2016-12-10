using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Chapter_5
{
    class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> ListBoxItems { set; get; }

        public MainViewModel()
        {
            ListBoxItems = new ObservableCollection<string>();
        }

        private bool checkBoxChecked;
        public bool CheckBoxChecked
        {
            set
            {
                checkBoxChecked = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CheckBoxChecked"));
                }
            }
            get
            {
                Debug.WriteLine("MainViewModel.CheckBoxChecked: " + checkBoxChecked);
                //ListBoxItems.Add("Auto!!!");
                return checkBoxChecked;
            }
        }

        private string targetText;
        public string TargetText
        {
            set
            {
                targetText = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TargetText"));
                }
            }
            get
            {
                Debug.WriteLine("MainViewModel.TargetText: " + targetText);
                return targetText;
            }
        }

        private void MyBusinessLogic()
        {
            //if (checkBoxChecked == true)
            //{
            //    TargetText = "???";
            //}
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
