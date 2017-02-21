﻿using System;
using Ads;
using Android.Gms.Ads;
using Ads.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdBanner), typeof(AdBanner_Droid))]
namespace Ads.Droid
{
    public class AdBanner_Droid : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var adView = new AdView(Context);

                switch ((Element as AdBanner).Size)
                {
                    case "Standardbanner":
                        adView.AdSize = AdSize.Banner;
                        break;
                    case "LargeBanner":
                        adView.AdSize = AdSize.LargeBanner;
                        break;
                    case "MediumRectangle":
                        adView.AdSize = AdSize.MediumRectangle;
                        break;
                    case "FullBanner":
                        adView.AdSize = AdSize.FullBanner;
                        break;
                    case "Leaderboard":
                        adView.AdSize = AdSize.Leaderboard;
                        break;
                    case "SmartBannerPortrait":
                        adView.AdSize = AdSize.SmartBanner;
                        break;
                    default:
                        adView.AdSize = AdSize.Banner;
                        break;
                }

                adView.AdUnitId = "ca-app-pub-3940256099942544/6300978111";

                var requestbuilder = new AdRequest.Builder();
                adView.LoadAd(requestbuilder.Build());

                SetNativeControl(adView);
            }
        }
    }
}