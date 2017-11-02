using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using CoursesLibrary;

namespace AnotherCoursesProjectIOS
{
    

    [Register("CoursePagerViewController")]
    public class CoursePagerViewController : UIViewController
    {
        UIPageViewController pageViewController;
        CourseManager courseManager;
        public CoursePagerViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
          

            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            pageViewController = new UIPageViewController(UIPageViewControllerTransitionStyle.PageCurl, UIPageViewControllerNavigationOrientation.Horizontal, UIPageViewControllerSpineLocation.Min );

            pageViewController.View.Frame = this.View.Bounds;
            this.View.AddSubview(pageViewController.View);

            courseManager = new CourseManager();
            courseManager.MoveFirst();
            CoursePagerViewControllerDataSource dataSource = new CoursePagerViewControllerDataSource(courseManager);
            pageViewController.DataSource = dataSource;


            AnotherCourseViewController firstCourseViewController = dataSource.GetFirstViewController();

            pageViewController.SetViewControllers(new UIViewController[] { firstCourseViewController }, UIPageViewControllerNavigationDirection.Forward, false, null);

            //pageViewController.GetNextViewController = GetNextViewController;
            //pageViewController.GetPreviousViewController = GetPreviousViewController;

        }

        //AnotherCourseViewController CreateCourseViewController()
        //{
        //    AnotherCourseViewController courseViewController = new AnotherCourseViewController();
        //    courseViewController.course = courseManager.Current;
        //    courseViewController.coursePosition = courseManager.CurrentPosition;

        //    return courseViewController;
        //}

        //public UIViewController GetPreviousViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        //{
        //    AnotherCourseViewController returnCourseViewController = null;

        //    AnotherCourseViewController referenceCourseViewController = referenceViewController as AnotherCourseViewController;

        //    if(referenceCourseViewController != null)
        //    {
        //        courseManager.MoveTo(referenceCourseViewController.coursePosition);
        //        if (courseManager.CanMoveNext)
        //        {
        //            courseManager.MoveNext();
        //            returnCourseViewController = CreateCourseViewController();
        //        }
        //    }

        //    return returnCourseViewController;
        //}

        //public UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        //{
        //    AnotherCourseViewController returnCourseViewController = null;

        //    AnotherCourseViewController referenceCourseViewController = referenceViewController as AnotherCourseViewController;

        //    if (referenceCourseViewController != null)
        //    {
        //        courseManager.MoveTo(referenceCourseViewController.coursePosition);
        //        if (courseManager.CanMovePrev)
        //        {
        //            courseManager.MovePrev();
        //            returnCourseViewController = CreateCourseViewController();
        //        }
        //    }

        //    return returnCourseViewController;
        //}
    }
}