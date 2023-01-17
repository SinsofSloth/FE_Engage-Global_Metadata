// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12920 Offset: 0x12A21 VA: 0x12920
public static class DisposableExtensions // TypeDefIndex: 6481
{
	// Methods

	[ExtensionAttribute] // RVA: 0x13F00 Offset: 0x14001 VA: 0x13F00
	// RVA: -1 Offset: -1
	public static T AddTo<T>(T disposable, ICollection<IDisposable> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A12C0 Offset: 0x22A13C1 VA: 0x22A12C0
	|-DisposableExtensions.AddTo<IDisposable>
	|-DisposableExtensions.AddTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x13F10 Offset: 0x14011 VA: 0x13F10
	// RVA: -1 Offset: -1
	public static T AddTo<T>(T disposable, GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1520 Offset: 0x22A1621 VA: 0x22A1520
	|-DisposableExtensions.AddTo<IDisposable>
	|-DisposableExtensions.AddTo<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x13F20 Offset: 0x14021 VA: 0x13F20
	// RVA: 0x19D0130 Offset: 0x19D0231 VA: 0x19D0130
	private static IEnumerator MonitorTriggerHealth(ObservableDestroyTrigger trigger, GameObject targetGameObject) { }

	[ExtensionAttribute] // RVA: 0x13F90 Offset: 0x14091 VA: 0x13F90
	// RVA: -1 Offset: -1
	public static T AddTo<T>(T disposable, Component gameObjectComponent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A13F0 Offset: 0x22A14F1 VA: 0x22A13F0
	|-DisposableExtensions.AddTo<IDisposable>
	|-DisposableExtensions.AddTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x13FA0 Offset: 0x140A1 VA: 0x13FA0
	// RVA: -1 Offset: -1
	public static T AddTo<T>(T disposable, ICollection<IDisposable> container, GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A17D0 Offset: 0x22A18D1 VA: 0x22A17D0
	|-DisposableExtensions.AddTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x13FB0 Offset: 0x140B1 VA: 0x13FB0
	// RVA: -1 Offset: -1
	public static T AddTo<T>(T disposable, ICollection<IDisposable> container, Component gameObjectComponent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1790 Offset: 0x22A1891 VA: 0x22A1790
	|-DisposableExtensions.AddTo<object>
	*/
}

