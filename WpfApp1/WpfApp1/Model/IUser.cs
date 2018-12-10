using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public interface IUser
    {
        String Surname { get; set; }
        String Name { get; set; }
        String Middle { get; set; }
    }
}
