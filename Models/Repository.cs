namespace CourseApp.Models
{
    public class Repository{
        private static readonly List<Course> _courses = new();


        static Repository(){
            _courses = new List<Course>(){
                new Course(){Id = 1, Title = "Asp.net", Description ="Çok iyi kurs", Image="1.jpeg"},
                new Course(){Id = 2, Title = "PHP", Description ="iğrenç kurs", Image="2.png"},
                new Course(){Id = 3, Title = "React Native", Description ="harika kurs", Image="3.png"},
                new Course(){Id = 4, Title = "SQL", Description ="saçma kurs", Image="4.jpg"},
            };
        }

        public static List<Course> Courses {
             get {
                 return _courses;}
            }
    }
}