namespace WeatherApp
{

    internal class Atest
    {
        private int _Semester;
       
        private Student _student;

        public int Temperature
        {
            get => _Semester;
        }

     
        private Student Student
        {
            get => _student;
        }

        public string CityName
        {
            get { return Student != null ? Student.Name : "Не назначено"; }
      
        }

        public Atest(int Semester, Student city)
        {
            _Semester = Semester;
            
            _student = city;
        }


    }
}
