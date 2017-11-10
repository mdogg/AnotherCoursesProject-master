using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseCategoryManager
    {
        private readonly CourseCategory[] categories;

        int currentIndex = 0;
        private readonly int lastIndex;

        public CourseCategoryManager()
        {
            categories = InitCategories();
            lastIndex = categories.Length - 1;
        }

        private CourseCategory[] InitCategories()
        {
            var initCategories = new CourseCategory[] {
                new CourseCategory()
                {
                    Title = "Martin's Android",
                    Description = "Martin will lead this course on Android"
                    
                },
                new CourseCategory()
                {
                    Title = "Martin's iOS",
                    Description = "Martin will lead this course on iOS"
                    
                },
                new CourseCategory()
                {
                    Title = "Martin's Windows",
                    Description = "Martin will lead this course on Windows",
                    
                }
            };

            return initCategories;
        }

        public int Length
        {
            get
            {
                return categories.Length;
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
            if (currentIndex < categories.Length - 1)
            {
                currentIndex++;
            }
        }

        public void MoveTo(int position)
        {
            if (position >= 0 && position <= lastIndex)
            {
                currentIndex = position;
            }
            else
            {
                throw new IndexOutOfRangeException(String.Format("{0} is an invalid position.  Must be between 0 and {1}", position, lastIndex));
            }
        }

        public CourseCategory Current
        {
            get
            {
                return categories[currentIndex];
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
