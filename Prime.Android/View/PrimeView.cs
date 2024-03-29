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
using MvvmCross.Platforms.Android.Views;
using Prime.Core.ViewModels;

namespace Prime.Android.View
{
    [Activity(Label = "@string/app_name")]
    public class PrimeView : MvxActivity<PrimeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PrimePage);
        }
    }
}