using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataBindingDemo
{
    class StudentWithoutNotification
    {
        private string name;
        private int grade;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                    this.name = value;
            }
        }
        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }
    }

    class Student: INotifyPropertyChanged
    {
        private string name;
        private int grade;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }    
        public int Grade 
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (this.grade != value)
                {
                    this.grade = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
