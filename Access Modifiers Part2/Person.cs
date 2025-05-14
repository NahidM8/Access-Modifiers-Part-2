namespace Access_Modifiers_Part2
{
    public class Person
    {
        private string _name;
        private string _surname;
        public string Name 
        {
            get => _name;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name bos ola bilmez");
                if (value.Length>=3 && value.Length<=30)
                    throw new ArgumentException("Name dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər");
                if (!Char.IsUpper(value[0]))
                    throw new ArgumentException("Name və Surname dəyərləri mütləq böyük hərf ilə başlamalıdır");

                _name = value;
            } 
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname bos ola bilmez");
                if (value.Length >= 3 && value.Length <= 35)
                    throw new ArgumentException("Surname dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər");
                if (!Char.IsUpper(value[0]))
                    throw new ArgumentException("Name və Surname dəyərləri mütləq böyük hərf ilə başlamalıdır");

                _surname = value;
            }
        }
        public byte Age { get; set; }

        public Person(string name, string surname, byte age)
        {
            _name = name;
            _surname = surname;
            Age = age;
        }
    }
}
