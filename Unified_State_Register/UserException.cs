using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unified_State_Register
{
    class UserException
    {
        public static Exception usernameError()
        {
            return new Exception("Не вірний логін. Логін має складатися з літер та цифр.");
        }
        public static Exception usernameLengthError()
        {
            return new Exception("Не вірний логін. Логін має бути від 4 до 12 символів");
        }
        public static Exception passwordError()
        {
            return new Exception("Не вірний пароль. Пароль має складатися з літер та цифр.");
        }
        public static Exception passwordLengthError()
        {
            return new Exception("Не вірний пароль. Пароль має від 8 до 32 символів");
        }
        public static Exception permissionError()
        {
            return new Exception("Невідомий тип доступу.");
        }
        public static Exception passportIdError()
        {
            return new Exception("Невірний номер паспорту.");
        }
    }
}
