// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x134E0 Offset: 0x135E1 VA: 0x134E0
public static class UnityEventExtensions // TypeDefIndex: 6786
{
	// Methods

	[ExtensionAttribute] // RVA: 0x17660 Offset: 0x17761 VA: 0x17660
	// RVA: 0x1AFA970 Offset: 0x1AFAA71 VA: 0x1AFA970
	public static IObservable<Unit> AsObservable(UnityEvent unityEvent) { }

	[ExtensionAttribute] // RVA: 0x17670 Offset: 0x17771 VA: 0x17670
	// RVA: -1 Offset: -1
	public static IObservable<T> AsObservable<T>(UnityEvent<T> unityEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202E560 Offset: 0x202E661 VA: 0x202E560
	|-UnityEventExtensions.AsObservable<bool>
	|
	|-RVA: 0x202E840 Offset: 0x202E941 VA: 0x202E840
	|-UnityEventExtensions.AsObservable<int>
	|
	|-RVA: 0x202EB20 Offset: 0x202EC21 VA: 0x202EB20
	|-UnityEventExtensions.AsObservable<object>
	|-UnityEventExtensions.AsObservable<string>
	|
	|-RVA: 0x202EE00 Offset: 0x202EF01 VA: 0x202EE00
	|-UnityEventExtensions.AsObservable<float>
	|
	|-RVA: 0x202F0E0 Offset: 0x202F1E1 VA: 0x202F0E0
	|-UnityEventExtensions.AsObservable<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x17680 Offset: 0x17781 VA: 0x17680
	// RVA: -1 Offset: -1
	public static IObservable<Tuple<T0, T1>> AsObservable<T0, T1>(UnityEvent<T0, T1> unityEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202F3C0 Offset: 0x202F4C1 VA: 0x202F3C0
	|-UnityEventExtensions.AsObservable<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x17690 Offset: 0x17791 VA: 0x17690
	// RVA: -1 Offset: -1
	public static IObservable<Tuple<T0, T1, T2>> AsObservable<T0, T1, T2>(UnityEvent<T0, T1, T2> unityEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202F6A0 Offset: 0x202F7A1 VA: 0x202F6A0
	|-UnityEventExtensions.AsObservable<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x176A0 Offset: 0x177A1 VA: 0x176A0
	// RVA: -1 Offset: -1
	public static IObservable<Tuple<T0, T1, T2, T3>> AsObservable<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> unityEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202F980 Offset: 0x202FA81 VA: 0x202F980
	|-UnityEventExtensions.AsObservable<object, object, object, object>
	*/
}

