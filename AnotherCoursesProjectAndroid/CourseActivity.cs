﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using CoursesLibrary;
using Android.Support.V4.View;

namespace AnotherCoursesProjectAndroid
{
    //[Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    [Activity(Label = "Courses Activity")]
    public class CourseActivity : FragmentActivity
    {
        private const String DEFAULT_CATEGORY_TITLE = "Android";
        CourseManager courseManager;
        CoursePagerAdapter coursePagerAdapter;
        ViewPager viewPager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CourseActivity);

            courseManager = new CourseManager();
            courseManager.MoveFirst();

            coursePagerAdapter = new CoursePagerAdapter(SupportFragmentManager, courseManager);

            viewPager = FindViewById<ViewPager>(Resource.Id.coursePager);
            viewPager.Adapter = coursePagerAdapter;
        }
    }
}