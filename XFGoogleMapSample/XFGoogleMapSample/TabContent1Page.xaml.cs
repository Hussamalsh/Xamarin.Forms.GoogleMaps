using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XFGoogleMapSample
{
    public partial class TabContent1Page : ContentPage
    {
        public TabContent1Page()
        {
            InitializeComponent();

            map.CameraChanged += (sender, e) => 
            {
                map.InitialCameraUpdate = CameraUpdateFactory.NewCameraPosition(e.Position);
            };
        }
    }
}
