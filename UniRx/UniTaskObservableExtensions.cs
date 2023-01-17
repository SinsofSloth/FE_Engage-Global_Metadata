// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12F70 Offset: 0x13071 VA: 0x12F70
public static class UniTaskObservableExtensions // TypeDefIndex: 6660
{
	// Methods

	[ExtensionAttribute] // RVA: 0x16190 Offset: 0x16291 VA: 0x16190
	// RVA: -1 Offset: -1
	public static UniTask<T> ToUniTask<T>(IObservable<T> source, CancellationToken cancellationToken, bool useFirstValue = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D980 Offset: 0x202DA81 VA: 0x202D980
	|-UniTaskObservableExtensions.ToUniTask<object>
	*/

	[ExtensionAttribute] // RVA: 0x161A0 Offset: 0x162A1 VA: 0x161A0
	// RVA: -1 Offset: -1
	public static IObservable<T> ToObservable<T>(UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D790 Offset: 0x202D891 VA: 0x202D790
	|-UniTaskObservableExtensions.ToObservable<object>
	*/

	[ExtensionAttribute] // RVA: 0x161B0 Offset: 0x162B1 VA: 0x161B0
	// RVA: 0x1AFA2E0 Offset: 0x1AFA3E1 VA: 0x1AFA2E0
	public static IObservable<Unit> ToObservable(UniTask task) { }

	[AsyncStateMachineAttribute] // RVA: 0x161C0 Offset: 0x162C1 VA: 0x161C0
	// RVA: -1 Offset: -1
	private static UniTaskVoid Fire<T>(AsyncSubject<T> subject, UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D6C0 Offset: 0x202D7C1 VA: 0x202D6C0
	|-UniTaskObservableExtensions.Fire<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x16230 Offset: 0x16331 VA: 0x16230
	// RVA: 0x1AFA4E0 Offset: 0x1AFA5E1 VA: 0x1AFA4E0
	private static UniTaskVoid Fire(AsyncSubject<Unit> subject, UniTask task) { }
}

