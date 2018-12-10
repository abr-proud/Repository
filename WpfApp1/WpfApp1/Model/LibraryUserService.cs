using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace WpfApp1.Model
{
    class LibraryUserService : ILibraryUserService
    {
        private ObservableCollection<IUser> ValueUsers = null;

        public LibraryUserService()
        {
            ValueUsers = new ObservableCollection<IUser>();
            ValueUsers.Add(new LibraryUser { Surname = "Абрамов", Name = "Никита", Middle = "Олегович" });
            ValueUsers.Add(new LibraryUser { Surname = "Валидов", Name = "Юрий", Middle = "Степанович" });
            ValueUsers.Add(new LibraryUser { Surname = "Грегорий", Name = "Лепс", Middle = "Фанинович" });
        }


        public void CreateNewUser()
        {
            ValueUsers.Add(new LibraryUser { Surname = "Test1_" + ValueUsers.Count, Name = "Test1_" + ValueUsers.Count, Middle = "Test1_" + ValueUsers.Count });
        }

        public IUser FindUser(IUser findUser)
        {
            return findUser != null ? ValueUsers.FirstOrDefault(user => user.Surname == findUser.Surname && user.Name == findUser.Name && user.Middle == findUser.Middle) : null;
        }

        public void GetData(Action<ObservableCollection<IUser>, Exception> callback)
        {
            callback(ValueUsers, null);
        }

        public void RemoveUser(IUser user)
        {
            if (user == null)
                return;

            ValueUsers.Remove(user);
        }
    }
}
