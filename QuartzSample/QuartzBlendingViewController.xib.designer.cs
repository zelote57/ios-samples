// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace QuartzSample {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("QuartzBlendingViewController")]
	public partial class QuartzBlendingViewController {
		
		private UIKit.UIScrollView __mt_scrollView;
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIPickerView __mt_picker;
		
		#pragma warning disable 0169
		[Foundation.Connect("scrollView")]
		private UIKit.UIScrollView scrollView {
			get {
				this.__mt_scrollView = ((UIKit.UIScrollView)(this.GetNativeField("scrollView")));
				return this.__mt_scrollView;
			}
			set {
				this.__mt_scrollView = value;
				this.SetNativeField("scrollView", value);
			}
		}
		
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("picker")]
		private UIKit.UIPickerView picker {
			get {
				this.__mt_picker = ((UIKit.UIPickerView)(this.GetNativeField("picker")));
				return this.__mt_picker;
			}
			set {
				this.__mt_picker = value;
				this.SetNativeField("picker", value);
			}
		}
	}
}
