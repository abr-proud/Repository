using System;
using WpfApp1.Utils;

namespace WpfApp1.Model
{
    class LibraryUser : NotifyModelBase, IUser
    {
        private String DataSurname = String.Empty;
        public String Surname
        {
            get
            {
                return DataSurname;
            }
            set
            {
                DataSurname = value;
                OnPropertyChanged("Surname");
            }
        }

        private String DataName = String.Empty;
        public String Name
        {
            get
            {
                return DataName;
            }
            set
            {
                DataName = value;
                OnPropertyChanged("Name");
            }
        }

        private String DataMiddle = String.Empty;
        public String Middle
        {
            get
            {
                return DataMiddle;
            }
            set
            {
                DataMiddle = value;
                OnPropertyChanged("Middle");
            }
        }
    }
}
