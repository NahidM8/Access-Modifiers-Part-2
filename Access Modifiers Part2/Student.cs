namespace Access_Modifiers_Part2
{
    public class Student:Person
    {
        private int _point;
        public int Point 
        {
            get => _point;
            set
            {
                if (value>=0 && value<=100)
                    throw new ArgumentException("Point dəyəri minimum 0 maximum 100 ola bilər");

                _point = value;
            }
        }

        public Student(int point,string name,string surname,byte age):base(name,surname,age)
        {
            _point = point;
        }
    }
}
