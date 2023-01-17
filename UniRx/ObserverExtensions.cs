// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12D60 Offset: 0x12E61 VA: 0x12D60
public static class ObserverExtensions // TypeDefIndex: 6584
{
	// Methods

	[ExtensionAttribute] // RVA: 0x157D0 Offset: 0x158D1 VA: 0x157D0
	// RVA: -1 Offset: -1
	public static IObserver<T> Synchronize<T>(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297FEF0 Offset: 0x297FFF1 VA: 0x297FEF0
	|-ObserverExtensions.Synchronize<object>
	*/

	[ExtensionAttribute] // RVA: 0x157E0 Offset: 0x158E1 VA: 0x157E0
	// RVA: -1 Offset: -1
	public static IObserver<T> Synchronize<T>(IObserver<T> observer, object gate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297FFA0 Offset: 0x29800A1 VA: 0x297FFA0
	|-ObserverExtensions.Synchronize<object>
	*/
}

