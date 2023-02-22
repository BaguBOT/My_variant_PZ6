using System;
using System.Collections.Generic;

namespace studentApp {
    public class StudentDatabase
    {
        private Random _random = new Random();
        private int RandomInt
        {
            get => _random.Next(0, 9);
        }
        internal List<Atest> Atest { get; private set; }

        public void Initialize()
        {
            Atest = new List<Atest>
            {
                new Atest(RandomInt, new Student("Лазарева","Борислава","Вадимовна"), new subject("Математика"),new atessst ("da")),
                new Atest(RandomInt, new Student("Копылова","Варвара ","-"), new subject("Русский язык"),new atessst ("da")),
                new Atest(RandomInt, new Student("Рогов","Май","Русланович"), new subject("Математика"),new atessst ("da")),
                new Atest(RandomInt, new Student("Михеев","Иннокентий","Максович"), new subject("Математика"),new atessst ("net"))
              
            };
        }
    }
}