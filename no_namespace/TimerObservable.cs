// Namespace: 
private class TimerObservable.Timer : OperatorObserverBase<long, long> // TypeDefIndex: 7110
{
	// Fields
	private long index; // 0x20

	// Methods

	// RVA: 0x1AFA240 Offset: 0x1AFA341 VA: 0x1AFA240
	public void .ctor(IObserver<long> observer, IDisposable cancel) { }

	// RVA: 0x1B0A4D0 Offset: 0x1B0A5D1 VA: 0x1B0A4D0
	public void OnNext() { }

	// RVA: 0x1B0A8A0 Offset: 0x1B0A9A1 VA: 0x1B0A8A0 Slot: 8
	public override void OnNext(long value) { }

	// RVA: 0x1B0A8B0 Offset: 0x1B0A9B1 VA: 0x1B0A8B0 Slot: 9
	public override void OnError(Exception error) { }

	// RVA: 0x1B0A9D0 Offset: 0x1B0AAD1 VA: 0x1B0A9D0 Slot: 10
	public override void OnCompleted() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13A50 Offset: 0x13B51 VA: 0x13A50
private sealed class TimerObservable.<>c__DisplayClass6_0 // TypeDefIndex: 7111
{
	// Fields
	public TimerObservable.Timer timerObserver; // 0x10
	public TimerObservable <>4__this; // 0x18

	// Methods

	// RVA: 0x1AFA230 Offset: 0x1AFA331 VA: 0x1AFA230
	public void .ctor() { }

	// RVA: 0x1B0A4A0 Offset: 0x1B0A5A1 VA: 0x1B0A4A0
	internal void <SubscribeCore>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13A60 Offset: 0x13B61 VA: 0x13A60
private sealed class TimerObservable.<>c__DisplayClass6_1 // TypeDefIndex: 7112
{
	// Fields
	public ISchedulerPeriodic periodicScheduler; // 0x10
	public TimerObservable.<>c__DisplayClass6_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1AFA2B0 Offset: 0x1AFA3B1 VA: 0x1AFA2B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13A70 Offset: 0x13B71 VA: 0x13A70
private sealed class TimerObservable.<>c__DisplayClass6_2 // TypeDefIndex: 7113
{
	// Fields
	public SerialDisposable disposable; // 0x10
	public TimerObservable.<>c__DisplayClass6_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x1AFA2C0 Offset: 0x1AFA3C1 VA: 0x1AFA2C0
	public void .ctor() { }

	// RVA: 0x1B0A630 Offset: 0x1B0A731 VA: 0x1B0A630
	internal void <SubscribeCore>b__1() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13A80 Offset: 0x13B81 VA: 0x13A80
private sealed class TimerObservable.<>c__DisplayClass6_3 // TypeDefIndex: 7114
{
	// Fields
	public TimeSpan timeP; // 0x10
	public TimerObservable.<>c__DisplayClass6_1 CS$<>8__locals3; // 0x18

	// Methods

	// RVA: 0x1AFA2D0 Offset: 0x1AFA3D1 VA: 0x1AFA2D0
	public void .ctor() { }

	// RVA: 0x1B0A830 Offset: 0x1B0A931 VA: 0x1B0A830
	internal void <SubscribeCore>b__2(Action<TimeSpan> self) { }
}

