namespace CourseApp.Models
{
    public class Repository{
        private static readonly List<Course> _courses = new();


        static Repository(){
            _courses = new List<Course>(){
                new Course(){
                    Id = 1,
                    Title = "Asp.net",
                    Description ="Çok iyi kurs",
                    Image="1.jpeg",
                    Tags = new string[]{"Web development", ".net"},
                    isHome=true,
                },
                new Course(){
                    Id = 2,
                    Title = "PHP",
                    Description ="iğrenç kurs",
                    Image="2.png",
                    Tags = new string[]{"Web development", "php"},
                    isHome=true,
                    },
                new Course(){
                    Id = 3,
                    Title = "React Native",
                    Description ="harika kurs",
                    Image="3.png",
                    Tags = new string[]{"Mobile development", "Node.js"},
                    isHome=false,
                    },
                new Course(){
                    Id = 4,
                    Title = "SQL",
                    Description ="saçma kurs",
                    Image="4.jpg",
                    Tags = new string[]{"Database"},
                    isHome=true,
                    },
            };
        }

        public static List<Course> Courses {
             get {
                 return _courses;}
            }

        public static Course? getById(int id){
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}