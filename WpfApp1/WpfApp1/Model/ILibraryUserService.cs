using System;
using System.Collections.ObjectModel;

namespace WpfApp1.Model
{
    public interface ILibraryUserService
    {
        void GetData(Action<ObservableCollection<IUser>, Exception> callback);
        IUser FindUser(IUser findUser);
        void CreateNewUser();
        void RemoveUser(IUser user);
    }
}
