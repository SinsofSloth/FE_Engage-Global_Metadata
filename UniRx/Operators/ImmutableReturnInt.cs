// Namespace: UniRx.Operators
internal class ImmutableReturnInt32Observable : IObservable<int>, IOptimizedObservable<int> // TypeDefIndex: 7029
{
	// Fields
	private static ImmutableReturnInt32Observable[] Caches; // 0x0
	private readonly int x; // 0x10

	// Methods

	// RVA: 0x19D0800 Offset: 0x19D0901 VA: 0x19D0800
	public static IObservable<int> GetInt32Observable(int x) { }

	// RVA: 0x19D08F0 Offset: 0x19D09F1 VA: 0x19D08F0
	private void .ctor(int x) { }

	// RVA: 0x19D0920 Offset: 0x19D0A21 VA: 0x19D0920 Slot: 5
	public bool IsRequiredSubscribeOnCurrentThread() { }

	// RVA: 0x19D0930 Offset: 0x19D0A31 VA: 0x19D0930 Slot: 4
	public IDisposable Subscribe(IObserver<int> observer) { }

	// RVA: 0x19D0A80 Offset: 0x19D0B81 VA: 0x19D0A80
	private static void .cctor() { }
}

