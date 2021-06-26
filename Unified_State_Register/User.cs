using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unified_State_Register
{
    public class User
    {
        private string _username;
        private string _password;
        private char _permission;
        private string _passportId;
        public User(string username, string password, string passportId = null , char permission = 'S')
        {
            setUsername(username);
            setPassword(password);
            setPermission(permission);
            setPassportId(passportId);
        }
        public string Username
        {
            get
            {
                return _username;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
        }
        public char Permission 
        { 
            get 
            {
                return _permission; 
            } 
        }
        public string PassportId
        {
            get
            {
                return _passportId;
            }
        }
        private void setUsername(string username)
        {
            if (username.Length < 4 || username.Length > 12)
            {
                throw UserException.usernameLengthError();
            }
            foreach (var ch in username)
            {
                if (Char.IsNumber(ch) || Char.IsLetter(ch))
                {
                    continue;
                }
                else
                {
                    throw UserException.usernameError();
                }
            }
            _username = username;
        }
        private void setPassword(string password)
        {
            if (password.Length < 8 || password.Length > 32)
            {
                throw UserException.passwordLengthError();
            }
            foreach (var ch in password)
            {
                if (Char.IsNumber(ch) || Char.IsLetter(ch))
                {
                    continue;
                }
                else
                {
                    throw UserException.passwordError();
                }
            }
            _password = password;
        }
        private void setPassportId(string passportId)
        {
            if (_permission != 'S')
            {
                _passportId = null;
                return;
            }
            if (passportId != null)
            {
                if (passportId.Length != 9)
                {
                    throw UserException.passportIdError();
                }
                foreach (var ch in passportId)
                {
                    if (Char.IsNumber(ch))
                    {
                        continue;
                    }
                    else
                    {
                        throw UserException.passportIdError();
                    }
                }
                _passportId = passportId;
            }
            
        }
        private void setPermission(char permission)
        {
            if (permission != 'A' && permission != 'S' && permission != 'C')
            {
                throw UserException.permissionError();
            }
            _permission = permission;
        }
    }
}
