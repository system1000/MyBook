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

namespace FlyOutMenu
{
    [Activity(Label = "FileActivity")]
    public class SearchFile : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SearchFileMain);
            
            var backBtn = FindViewById(Resource.Id.GO_Back);
            if (backBtn != null)
            {
                FileListFragment ff = new FileListFragment();
                backBtn.Click += (o, e) =>
                {
                    ff.GoBack();
                };
            }
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back)
            {
                StartActivity(typeof(Activity1));
                this.Finish();
                return false;
            }
            return base.OnKeyDown(keyCode, e);
        }
    }
}