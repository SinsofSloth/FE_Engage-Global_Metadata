// Namespace: UniRx
public static class Disposable // TypeDefIndex: 6479
{
	// Fields
	public static readonly IDisposable Empty; // 0x0

	// Methods

	// RVA: 0x19CFE40 Offset: 0x19CFF41 VA: 0x19CFE40
	public static IDisposable Create(Action disposeAction) { }

	// RVA: -1 Offset: -1
	public static IDisposable CreateWithState<TState>(TState state, Action<TState> disposeAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1250 Offset: 0x22A1351 VA: 0x22A1250
	|-Disposable.CreateWithState<object>
	*/

	// RVA: 0x19D00A0 Offset: 0x19D01A1 VA: 0x19D00A0
	private static void .cctor() { }
}

