using WpfApp1.Utils;
using WpfApp1.Model;
using System.Collections.ObjectModel;
using System;

namespace WpfApp1.ViewModel
{
    class MainViewModel : NotifyModelBase
    {
        private readonly ILibraryUserService LibraryDataService;
        public ObservableCollection<IUser> Users { get; set; }

        public MainViewModel(ILibraryUserService valueDataService)
        {
            LibraryDataService = valueDataService;
            LibraryDataService.GetData((items, error) =>
            {
                Users = items;
            });
        }

        // Working with the selected // -> 

        private IUser DataSelectedUser = null;
        public IUser SelectedUser
        {
            get { return DataSelectedUser; }
            set
            {
                DataSelectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        // Working with the selected // -> 

        // Working with the commands // -> 

        private RelayCommand DataAppendUserCommand;
        public RelayCommand AppendUserCommand
        {
            get
            {
                return DataAppendUserCommand ?? (DataAppendUserCommand = new RelayCommand(AddNewBook));
            }
        }

        private void AddNewBook(object args)
        {
            LibraryDataService.CreateNewUser();
        }

        private RelayCommand DataRemoveUserCommand;
        public RelayCommand RemoveUserCommand
        {
            get
            {
                return DataRemoveUserCommand ?? (DataRemoveUserCommand = new RelayCommand(RemoveUser, CanRemoveUser));
            }
        }

        private void RemoveUser(object args)
        {
            Users.Remove(SelectedUser);
        }

        private bool CanRemoveUser(object args)
        {
            if (SelectedUser == null)
                return false;

            var book = LibraryDataService.FindUser(SelectedUser);

            if (book == null)
                return false;

            return true;
        }

        // Working with the commands // <-
    }
}
