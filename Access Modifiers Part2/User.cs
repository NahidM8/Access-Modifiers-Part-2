namespace Access_Modifiers_Part2
{
    public class User
    {
        public string Username {  get; set; }
        private string _password;
        public string Password 
        { 
            get 
            { 
                return _password;
            }
            set 
            {
                if (value.Length < 8)
                    throw new ArgumentException("Password uzunluğu 8-dən kiçik ola bilməz");
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Password boş ola bilməz");
                if (HasNumber(value))
                    throw new ArgumentException("Passwordun içində ən az bir rəqəm olmalıdır");
                if (HasUppercaseLetter(value))
                    throw new ArgumentException("Passwordun içində ən az bir böyük hərf olmalıdır");

                _password = value;
            }
        }
        public byte Age { get; set; }

        private bool HasNumber(string input)
        {
            foreach (char a in input)
            {
                if (!char.IsDigit(a))
                {
                    return false;
                }
            }
            return true;
        }
        private bool HasUppercaseLetter(string input)
        {
            foreach (char a in input)
            {
                if (!char.IsUpper(a))
                {
                    return false;
                }
            }
            return true;
        }
        public User(string username, string password, byte age)
        {
            Username = username;
            _password = password;
            Age = age;
        }


    }
}
