using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookrent
{
    //模型
    public class User
    {
        public string StudentId { get; set; }
        public string Password { get; set; }
    }

    public static class UserRepository
    {
        //使用者清單，含學號與密碼
        public static List<User> Users { get; } = new List<User>
        {
            new User { StudentId = "001", Password = "0000" },
            new User { StudentId = "002", Password = "6789" },
            new User { StudentId = "003", Password = "0000" },
            new User { StudentId = "004", Password = "1111" },
        };
    }
}
