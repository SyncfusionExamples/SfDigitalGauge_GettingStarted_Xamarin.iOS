using System;
using System.Collections.ObjectModel;
using Foundation;
using Syncfusion.SfGauge.iOS;
using UIKit;

namespace Gauge_GettingStarted
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SFDigitalGauge digitalGauge = new SFDigitalGauge();
            digitalGauge.Frame = new CoreGraphics.CGRect(0,50,this.View.Frame.Width,this.View.Frame.Height-50);
            digitalGauge.CharacterHeight = 36;
            digitalGauge.CharacterWidth = 18;
            digitalGauge.CharacterType = SFDigitalGaugeCharacterType.SFDigitalGaugeCharacterTypeSegmentSeven;
            digitalGauge.Value = (NSString)"Syncfusion";
            this.View.AddSubview(digitalGauge);

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
