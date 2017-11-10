using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseManager
    {
        private const String DefaultCategory = "Android";

        private readonly Course[] courses;
        int currentIndex = 0;
        private readonly int lastIndex;

       public CourseManager() : this(DefaultCategory) { }

        //public CourseManager()
        //{
        //    //courses = InitCourses();
        //    //lastIndex = courses.Length - 1;
        //    : this(DefaultCategory){ }
        //}

        public CourseManager(String categoryTitle)
        {
            switch (categoryTitle)
            {
                case "Android":
                    courses = InitCourseAndroid();
                    break;
                case "iOS":
                    courses = InitCourseAndroid();
                    break;
                case "Windows Phone":
                    courses = InitCourseAndroid();
                    break;
            }
            if(courses != null)
            {
                lastIndex = courses.Length - 1;
            }
        }

        private Course[] InitCourseAndroid()
        {
            var initCourses = new Course[]
            {
                new Course()
                {
                    Title = "Martin's Course Android",
                    Description = "Martin will lead this course",
                    Image = "member04_on"
                },
                new Course()
                {
                    Title = "John's Course Android",
                    Description = "John will lead this course",
                    Image = "member03_on"
                },
                new Course()
                {
                    Title = "Alick's Course Android",
                    Description = "Alick will lead this course",
                    Image = "member02_on"
                },
                new Course()
                {
                    Title = "Ev's Course Android",
                    Description = "Ev will lead this course",
                    Image = "member01_on"
                }
            };
            return initCourses;
        }

        private Course[] InitCourseiOS()
        {
            var initCourses = new Course[]
            {
                new Course()
                {
                    Title = "Martin's Course iOS",
                    Description = "Martin will lead this course",
                    Image = "member04_on"
                },
                new Course()
                {
                    Title = "John's Course iOS",
                    Description = "John will lead this course",
                    Image = "member03_on"
                },
                new Course()
                {
                    Title = "Alick's Course iOS",
                    Description = "Alick will lead this course",
                    Image = "member02_on"
                },
                new Course()
                {
                    Title = "Ev's Course iOS",
                    Description = "Ev will lead this course",
                    Image = "member01_on"
                }
            };
            return initCourses;
        }

        private Course[] InitCourseWindows()
        {
            var initCourses = new Course[]
            {
                new Course()
                {
                    Title = "Martin's Course Windows",
                    Description = "Martin will lead this course",
                    Image = "member04_on"
                },
                new Course()
                {
                    Title = "John's Course Windows",
                    Description = "John will lead this course",
                    Image = "member03_on"
                },
                new Course()
                {
                    Title = "Alick's Course Windows",
                    Description = "Alick will lead this course",
                    Image = "member02_on"
                },
                new Course()
                {
                    Title = "Ev's Course Windows",
                    Description = "Ev will lead this course",
                    Image = "member01_on"
                }
            };
            return initCourses;
        }

        //private Course[] InitCourses()
        //{
        //    var initCourses = new Course[] {
        //        new Course()
        //        {
        //            Title = "Martin's Course",
        //            Description = "Martin will lead this course",
        //            Image = "member04_on"
        //        },
        //        new Course()
        //        {
        //            Title = "John's Course",
        //            Description = "John will lead this course",
        //            Image = "member03_on"
        //        },
        //        new Course()
        //        {
        //            Title = "Alick's Course",
        //            Description = "Alick will lead this course",
        //            Image = "member02_on"
        //        },
        //        new Course()
        //        {
        //            Title = "Ev's Course",
        //            Description = "Ev will lead this course",
        //            Image = "member01_on"
        //        }
        //    };

        //    return initCourses;

        //}

        public int Length
        {
            get
            {
                return courses.Length;
            }
        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
        }

        public void MoveNext()
        {
            if (currentIndex < courses.Length - 1)
            {
                currentIndex++;
            }
        }

        public void MoveTo(int position)
        {
            if(position >= 0 && position <= lastIndex)
            {
                currentIndex = position;
            }
            else
            {
                throw new IndexOutOfRangeException(String.Format("{0} is an invalid position.  Must be between 0 and {1}", position, lastIndex));
            }
        }

        public Course Current
        {
            get
            {
                return courses[currentIndex];
            }

        }

        public int CurrentPosition
        {
            get { return currentIndex; }
        }

        public Boolean CanMovePrev
        {
            get { return currentIndex > 0; }
        }

        public Boolean CanMoveNext
        {
            get { return currentIndex < lastIndex; }
        }
    }
}
