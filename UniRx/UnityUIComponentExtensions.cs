// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x13630 Offset: 0x13731 VA: 0x13630
public static class UnityUIComponentExtensions // TypeDefIndex: 6797
{
	// Methods

	[ExtensionAttribute] // RVA: 0x176E0 Offset: 0x177E1 VA: 0x176E0
	// RVA: 0x1AFAF40 Offset: 0x1AFB041 VA: 0x1AFAF40
	public static IDisposable SubscribeToText(IObservable<string> source, Text text) { }

	[ExtensionAttribute] // RVA: 0x176F0 Offset: 0x177F1 VA: 0x176F0
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeToText<T>(IObservable<T> source, Text text) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202FC60 Offset: 0x202FD61 VA: 0x202FC60
	|-UnityUIComponentExtensions.SubscribeToText<object>
	*/

	[ExtensionAttribute] // RVA: 0x17700 Offset: 0x17801 VA: 0x17700
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeToText<T>(IObservable<T> source, Text text, Func<T, string> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202FE30 Offset: 0x202FF31 VA: 0x202FE30
	|-UnityUIComponentExtensions.SubscribeToText<object>
	*/

	[ExtensionAttribute] // RVA: 0x17710 Offset: 0x17811 VA: 0x17710
	// RVA: 0x1AFB070 Offset: 0x1AFB171 VA: 0x1AFB070
	public static IDisposable SubscribeToInteractable(IObservable<bool> source, Selectable selectable) { }

	[ExtensionAttribute] // RVA: 0x17720 Offset: 0x17821 VA: 0x17720
	// RVA: 0x1AFB1A0 Offset: 0x1AFB2A1 VA: 0x1AFB1A0
	public static IObservable<Unit> OnClickAsObservable(Button button) { }

	[ExtensionAttribute] // RVA: 0x17730 Offset: 0x17831 VA: 0x17730
	// RVA: 0x1AFB1B0 Offset: 0x1AFB2B1 VA: 0x1AFB1B0
	public static IObservable<bool> OnValueChangedAsObservable(Toggle toggle) { }

	[ExtensionAttribute] // RVA: 0x17740 Offset: 0x17841 VA: 0x17740
	// RVA: 0x1AFB310 Offset: 0x1AFB411 VA: 0x1AFB310
	public static IObservable<float> OnValueChangedAsObservable(Scrollbar scrollbar) { }

	[ExtensionAttribute] // RVA: 0x17750 Offset: 0x17851 VA: 0x17750
	// RVA: 0x1AFB470 Offset: 0x1AFB571 VA: 0x1AFB470
	public static IObservable<Vector2> OnValueChangedAsObservable(ScrollRect scrollRect) { }

	[ExtensionAttribute] // RVA: 0x17760 Offset: 0x17861 VA: 0x17760
	// RVA: 0x1AFB5D0 Offset: 0x1AFB6D1 VA: 0x1AFB5D0
	public static IObservable<float> OnValueChangedAsObservable(Slider slider) { }

	[ExtensionAttribute] // RVA: 0x17770 Offset: 0x17871 VA: 0x17770
	// RVA: 0x1AFB730 Offset: 0x1AFB831 VA: 0x1AFB730
	public static IObservable<string> OnEndEditAsObservable(InputField inputField) { }

	[ExtensionAttribute] // RVA: 0x17780 Offset: 0x17881 VA: 0x17780
	// RVA: 0x1AFB790 Offset: 0x1AFB891 VA: 0x1AFB790
	public static IObservable<string> OnValueChangedAsObservable(InputField inputField) { }

	[ExtensionAttribute] // RVA: 0x17790 Offset: 0x17891 VA: 0x17790
	// RVA: 0x1AFB8F0 Offset: 0x1AFB9F1 VA: 0x1AFB8F0
	public static IObservable<int> OnValueChangedAsObservable(Dropdown dropdown) { }
}

