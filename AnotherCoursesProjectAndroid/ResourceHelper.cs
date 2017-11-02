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
using System.Reflection;

namespace AnotherCoursesProjectAndroid
{
    public static class ResourceHelper
    {
        static Dictionary<String, int> resourceDictionary = new Dictionary<string, int>();

        public static int TranslateDrawable(String drawableName)
        {
            int resourceValue = -1;

            switch(drawableName)
            {
                case "member01_on":
                    resourceValue = Resource.Drawable.member01_on;
                    break;
                case "member02_on":
                    resourceValue = Resource.Drawable.member02_on;
                    break;
                case "member03_on":
                    resourceValue = Resource.Drawable.member03_on;
                    break;
                case "member04_on":
                    resourceValue = Resource.Drawable.member04_on;
                    break;

            }

            return resourceValue;
        }

        public static int TranslateDrawableWithReflection(String drawableName)
        {
            int resourceValue = -1;

            if(resourceDictionary.ContainsKey(drawableName))
            {
                resourceValue = resourceDictionary[drawableName];

            }
            else
            {
                Type drawableType = typeof(Resource.Drawable);
                FieldInfo resourceFieldInfo = drawableType.GetField(drawableName);

                resourceValue = (int)resourceFieldInfo.GetValue(null);

                resourceDictionary.Add(drawableName, resourceValue);
            }
            
            return resourceValue;
        }
    }
}