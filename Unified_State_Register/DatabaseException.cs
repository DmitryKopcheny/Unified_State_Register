using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unified_State_Register
{
    class DatabaseException
    {
        public static Exception unknownError()
        {
            return new Exception("Щось пішло не так(((");
        }
        public static Exception usernameIsUsed()
        {
            return new Exception("Це ім'я користувача вже використовується");
        }
        public static Exception passportIsUsed()
        {
            return new Exception("На цей номер паспорту вже зареєстрован аккаунт");
        }
    }
}
