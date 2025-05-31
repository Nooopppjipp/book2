using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookrent
{
    public class User
    {
        public string StudentId { get; set; }
        public string Password { get; set; }
    }

    public static class UserRepository
    {
        /// <summary>
        /// 初始使用者清單，含學號與密碼
        /// </summary>
        public static List<User> Users { get; } = new List<User>
        {
            new User { StudentId = "001", Password = "1234" },
            new User { StudentId = "002", Password = "6789" },
            new User { StudentId = "003", Password = "0000" }
        };
    }
}
