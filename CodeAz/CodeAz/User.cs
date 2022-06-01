using System;

namespace CodeAz
{
    public class User
    {
        private string _userName;
        private string _password;

        public void SetUsername(string username)
        {
            if (username.Length >= 6 && username.Length <= 25)
            {
                this._userName = username;
            }
        }

        public string GetUsername()
        {
            return _userName;
        }

        public void SetPassword(string password)
        {
            if(!String.IsNullOrWhiteSpace(password) && password.Length >= 8 && password.Length <= 25 
               &&  HasUpper(password) && HasLower(password) && HasDigit(password))
                this._password = password;
        }

        public string GetPassword()
        {
            return _password;
        }

        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;
            }

            return false;
        }
        
        public bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                    return true;
            }

            return false;
        }

        public bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }
    }
}