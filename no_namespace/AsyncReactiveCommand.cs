// Namespace: 
private class AsyncReactiveCommand.Subscription<T> : IDisposable // TypeDefIndex: 6750
{
	// Fields
	private readonly AsyncReactiveCommand<T> parent; // 0x0
	private readonly Func<T, IObservable<Unit>> asyncAction; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AsyncReactiveCommand<T> parent, Func<T, IObservable<Unit>> asyncAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AFBB0 Offset: 0x34AFCB1 VA: 0x34AFBB0
	|-AsyncReactiveCommand.Subscription<object>..ctor
	|
	|-RVA: 0x34B0ED0 Offset: 0x34B0FD1 VA: 0x34B0ED0
	|-AsyncReactiveCommand.Subscription<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AFC00 Offset: 0x34AFD01 VA: 0x34AFC00
	|-AsyncReactiveCommand.Subscription<object>.Dispose
	|
	|-RVA: 0x34B0F20 Offset: 0x34B1021 VA: 0x34B0F20
	|-AsyncReactiveCommand.Subscription<Unit>.Dispose
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x133E0 Offset: 0x134E1 VA: 0x133E0
[Serializable]
private sealed class AsyncReactiveCommand.<>c<T> // TypeDefIndex: 6751
{
	// Fields
	public static readonly AsyncReactiveCommand.<>c<T> <>9; // 0x0
	public static Func<bool, bool, bool> <>9__11_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B32A90 Offset: 0x2B32B91 VA: 0x2B32A90
	|-AsyncReactiveCommand.<>c<object>..cctor
	|
	|-RVA: 0x2B34600 Offset: 0x2B34701 VA: 0x2B34600
	|-AsyncReactiveCommand.<>c<Unit>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B32B70 Offset: 0x2B32C71 VA: 0x2B32B70
	|-AsyncReactiveCommand.<>c<object>..ctor
	|
	|-RVA: 0x2B346E0 Offset: 0x2B347E1 VA: 0x2B346E0
	|-AsyncReactiveCommand.<>c<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <.ctor>b__11_0(bool x, bool y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B32B80 Offset: 0x2B32C81 VA: 0x2B32B80
	|-AsyncReactiveCommand.<>c<object>.<.ctor>b__11_0
	|
	|-RVA: 0x2B346F0 Offset: 0x2B347F1 VA: 0x2B346F0
	|-AsyncReactiveCommand.<>c<Unit>.<.ctor>b__11_0
	*/
}

