// Namespace: UniRx.Diagnostics
[ExtensionAttribute] // RVA: 0x13930 Offset: 0x13A31 VA: 0x13930
public static class ObservableDebugExtensions // TypeDefIndex: 6850
{
	// Methods

	[ExtensionAttribute] // RVA: 0x18280 Offset: 0x18381 VA: 0x18280
	// RVA: -1 Offset: -1
	public static IObservable<T> Debug<T>(IObservable<T> source, string label) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297C010 Offset: 0x297C111 VA: 0x297C010
	|-ObservableDebugExtensions.Debug<object>
	*/

	[ExtensionAttribute] // RVA: 0x18290 Offset: 0x18391 VA: 0x18290
	// RVA: -1 Offset: -1
	public static IObservable<T> Debug<T>(IObservable<T> source, Logger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297C020 Offset: 0x297C121 VA: 0x297C020
	|-ObservableDebugExtensions.Debug<object>
	*/
}

