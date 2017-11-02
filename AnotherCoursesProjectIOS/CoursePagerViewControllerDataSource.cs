using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoursesLibrary;

namespace AnotherCoursesProjectIOS
{
    class CoursePagerViewControllerDataSource : UIPageViewControllerDataSource
    {
        CourseManager courseManager;

        public CoursePagerViewControllerDataSource (CourseManager courseManager)
        {
            this.courseManager = courseManager;
        }

        public AnotherCourseViewController GetFirstViewController()
        {
            courseManager.MoveFirst();

            return CreateCourseViewController();
        }

        public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            AnotherCourseViewController returnCourseViewController = null;

            AnotherCourseViewController referenceCourseViewController = referenceViewController as AnotherCourseViewController;

            if (referenceCourseViewController != null)
            {
                courseManager.MoveTo(referenceCourseViewController.coursePosition);
                if (courseManager.CanMoveNext)
                {
                    courseManager.MoveNext();
                    returnCourseViewController = CreateCourseViewController();
                }
            }

            return returnCourseViewController;
        }

        public override UIViewController GetPreviousViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            AnotherCourseViewController returnCourseViewController = null;

            AnotherCourseViewController referenceCourseViewController = referenceViewController as AnotherCourseViewController;

            if (referenceCourseViewController != null)
            {
                courseManager.MoveTo(referenceCourseViewController.coursePosition);
                if (courseManager.CanMovePrev)
                {
                    courseManager.MovePrev();
                    returnCourseViewController = CreateCourseViewController();
                }
            }

            return returnCourseViewController;
        }

        AnotherCourseViewController CreateCourseViewController()
        {
            AnotherCourseViewController courseViewController = new AnotherCourseViewController();
            courseViewController.course = courseManager.Current;
            courseViewController.coursePosition = courseManager.CurrentPosition;

            return courseViewController;
        }
    }
}