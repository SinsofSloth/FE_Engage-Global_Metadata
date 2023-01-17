// Namespace: 
private class RangeObservable.Range : OperatorObserverBase<int, int> // TypeDefIndex: 7010
{
	// Methods

	// RVA: 0x1B04700 Offset: 0x1B04801 VA: 0x1B04700
	public void .ctor(IObserver<int> observer, IDisposable cancel) { }

	// RVA: 0x1B04770 Offset: 0x1B04871 VA: 0x1B04770 Slot: 8
	public override void OnNext(int value) { }

	// RVA: 0x1B048D0 Offset: 0x1B049D1 VA: 0x1B048D0 Slot: 9
	public override void OnError(Exception error) { }

	// RVA: 0x1B049F0 Offset: 0x1B04AF1 VA: 0x1B049F0 Slot: 10
	public override void OnCompleted() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x139C0 Offset: 0x13AC1 VA: 0x139C0
private sealed class RangeObservable.<>c__DisplayClass4_0 // TypeDefIndex: 7011
{
	// Fields
	public RangeObservable <>4__this; // 0x10
	public IObserver<int> observer; // 0x18
	public int i; // 0x20

	// Methods

	// RVA: 0x1B045A0 Offset: 0x1B046A1 VA: 0x1B045A0
	public void .ctor() { }

	// RVA: 0x1B045B0 Offset: 0x1B046B1 VA: 0x1B045B0
	internal void <SubscribeCore>b__0(Action self) { }
}

