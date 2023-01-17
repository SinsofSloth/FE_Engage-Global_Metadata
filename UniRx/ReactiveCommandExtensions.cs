// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x133F0 Offset: 0x134F1 VA: 0x133F0
public static class ReactiveCommandExtensions // TypeDefIndex: 6754
{
	// Methods

	[ExtensionAttribute] // RVA: 0x17260 Offset: 0x17361 VA: 0x17260
	// RVA: 0x19ED830 Offset: 0x19ED931 VA: 0x19ED830
	public static ReactiveCommand ToReactiveCommand(IObservable<bool> canExecuteSource, bool initialValue = True) { }

	[ExtensionAttribute] // RVA: 0x17270 Offset: 0x17371 VA: 0x17270
	// RVA: -1 Offset: -1
	public static ReactiveCommand<T> ToReactiveCommand<T>(IObservable<bool> canExecuteSource, bool initialValue = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20156C0 Offset: 0x20157C1 VA: 0x20156C0
	|-ReactiveCommandExtensions.ToReactiveCommand<object>
	*/

	[ExtensionAttribute] // RVA: 0x17280 Offset: 0x17381 VA: 0x17280
	// RVA: -1 Offset: -1
	public static UniTask.Awaiter<T> GetAwaiter<T>(IReactiveCommand<T> command) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20155B0 Offset: 0x20156B1 VA: 0x20155B0
	|-ReactiveCommandExtensions.GetAwaiter<object>
	*/

	[ExtensionAttribute] // RVA: 0x17290 Offset: 0x17391 VA: 0x17290
	// RVA: 0x19ED900 Offset: 0x19EDA01 VA: 0x19ED900
	public static IDisposable BindTo(IReactiveCommand<Unit> command, Button button) { }

	[ExtensionAttribute] // RVA: 0x172A0 Offset: 0x173A1 VA: 0x172A0
	// RVA: 0x19EDAE0 Offset: 0x19EDBE1 VA: 0x19EDAE0
	public static IDisposable BindToOnClick(IReactiveCommand<Unit> command, Button button, Action<Unit> onClick) { }

	[ExtensionAttribute] // RVA: 0x172B0 Offset: 0x173B1 VA: 0x172B0
	// RVA: 0x19EDCF0 Offset: 0x19EDDF1 VA: 0x19EDCF0
	public static IDisposable BindToButtonOnClick(IObservable<bool> canExecuteSource, Button button, Action<Unit> onClick, bool initialValue = True) { }
}

