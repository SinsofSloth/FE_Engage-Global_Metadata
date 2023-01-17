// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13640 Offset: 0x13741 VA: 0x13640
[Serializable]
private sealed class UnityUIComponentExtensions.<>c // TypeDefIndex: 6794
{
	// Fields
	public static readonly UnityUIComponentExtensions.<>c <>9; // 0x0
	public static Action<string, Text> <>9__0_0; // 0x8
	public static Action<bool, Selectable> <>9__3_0; // 0x10
	public static Func<Toggle, IObserver<bool>, IDisposable> <>9__5_0; // 0x18
	public static Func<Scrollbar, IObserver<float>, IDisposable> <>9__6_0; // 0x20
	public static Func<ScrollRect, IObserver<Vector2>, IDisposable> <>9__7_0; // 0x28
	public static Func<Slider, IObserver<float>, IDisposable> <>9__8_0; // 0x30
	public static Func<InputField, IObserver<string>, IDisposable> <>9__10_0; // 0x38
	public static Func<Dropdown, IObserver<int>, IDisposable> <>9__11_0; // 0x40

	// Methods

	// RVA: 0x1B0B7B0 Offset: 0x1B0B8B1 VA: 0x1B0B7B0
	private static void .cctor() { }

	// RVA: 0x1B0B820 Offset: 0x1B0B921 VA: 0x1B0B820
	public void .ctor() { }

	// RVA: 0x1B0B830 Offset: 0x1B0B931 VA: 0x1B0B830
	internal void <SubscribeToText>b__0_0(string x, Text t) { }

	// RVA: 0x1B0B850 Offset: 0x1B0B951 VA: 0x1B0B850
	internal void <SubscribeToInteractable>b__3_0(bool x, Selectable s) { }

	// RVA: 0x1B0B860 Offset: 0x1B0B961 VA: 0x1B0B860
	internal IDisposable <OnValueChangedAsObservable>b__5_0(Toggle t, IObserver<bool> observer) { }

	// RVA: 0x1B0B9B0 Offset: 0x1B0BAB1 VA: 0x1B0B9B0
	internal IDisposable <OnValueChangedAsObservable>b__6_0(Scrollbar s, IObserver<float> observer) { }

	// RVA: 0x1B0BB10 Offset: 0x1B0BC11 VA: 0x1B0BB10
	internal IDisposable <OnValueChangedAsObservable>b__7_0(ScrollRect s, IObserver<Vector2> observer) { }

	// RVA: 0x1B0BC80 Offset: 0x1B0BD81 VA: 0x1B0BC80
	internal IDisposable <OnValueChangedAsObservable>b__8_0(Slider s, IObserver<float> observer) { }

	// RVA: 0x1B0BDF0 Offset: 0x1B0BEF1 VA: 0x1B0BDF0
	internal IDisposable <OnValueChangedAsObservable>b__10_0(InputField i, IObserver<string> observer) { }

	// RVA: 0x1B0BF40 Offset: 0x1B0C041 VA: 0x1B0BF40
	internal IDisposable <OnValueChangedAsObservable>b__11_0(Dropdown d, IObserver<int> observer) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13660 Offset: 0x13761 VA: 0x13660
[Serializable]
private sealed class UnityUIComponentExtensions.<>c__2<T> // TypeDefIndex: 6796
{
	// Fields
	public static readonly UnityUIComponentExtensions.<>c__2<T> <>9; // 0x0
	public static Action<T, Text, Func<T, string>> <>9__2_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B35F30 Offset: 0x2B36031 VA: 0x2B35F30
	|-UnityUIComponentExtensions.<>c__2<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36010 Offset: 0x2B36111 VA: 0x2B36010
	|-UnityUIComponentExtensions.<>c__2<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <SubscribeToText>b__2_0(T x, Text t, Func<T, string> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36020 Offset: 0x2B36121 VA: 0x2B36020
	|-UnityUIComponentExtensions.<>c__2<object>.<SubscribeToText>b__2_0
	*/
}

