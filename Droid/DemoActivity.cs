﻿
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

namespace HuePod.Droid
{
	//[Activity(Label = "DemoActivity", MainLauncher = true, Icon = "@mipmap/icon")]
	public class DemoActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_demo);
			// Create your application here
		}
	}
}

