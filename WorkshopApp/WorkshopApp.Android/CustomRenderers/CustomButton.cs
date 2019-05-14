using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using WorkshopApp.CustomRenderers;
using WorkshopApp.View.CustomRendered;
using Xamarin.Forms.Material.Android;

[assembly:ExportRenderer(typeof(CustomRenderedButton), typeof(CustomButton))]
namespace WorkshopApp.CustomRenderers
{
    public  class CustomButton : MaterialButtonRenderer
    {
        public CustomButton(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.SetAllCaps(false);
        }
    }
}