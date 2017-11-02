using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AnotherCoursesProjectAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class CategoryActivitiy : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            String[] categoryTitles = { "Cat 1", "Cat 2", "Cat 3" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, categoryTitles);
        }
    }
}