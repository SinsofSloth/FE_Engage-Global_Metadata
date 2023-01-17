// Namespace: UniRx
public class CountNotifier : IObservable<CountChangedStatus> // TypeDefIndex: 6561
{
	// Fields
	private readonly object lockObject; // 0x10
	private readonly Subject<CountChangedStatus> statusChanged; // 0x18
	private readonly int max; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x13B30 Offset: 0x13C31 VA: 0x13B30
	private int <Count>k__BackingField; // 0x24

	// Properties
	public int Max { get; }
	public int Count { get; set; }

	// Methods

	// RVA: 0x19CFA10 Offset: 0x19CFB11 VA: 0x19CFA10
	public int get_Max() { }

	[CompilerGeneratedAttribute] // RVA: 0x157B0 Offset: 0x158B1 VA: 0x157B0
	// RVA: 0x19CFA20 Offset: 0x19CFB21 VA: 0x19CFA20
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x157C0 Offset: 0x158C1 VA: 0x157C0
	// RVA: 0x19CFA30 Offset: 0x19CFB31 VA: 0x19CFA30
	private void set_Count(int value) { }

	// RVA: 0x19CFA40 Offset: 0x19CFB41 VA: 0x19CFA40
	public void .ctor(int max = 2147483647) { }

	// RVA: 0x19CFB70 Offset: 0x19CFC71 VA: 0x19CFB70
	public IDisposable Increment(int incrementCount = 1) { }

	// RVA: 0x19CFEB0 Offset: 0x19CFFB1 VA: 0x19CFEB0
	public void Decrement(int decrementCount = 1) { }

	// RVA: 0x19D0040 Offset: 0x19D0141 VA: 0x19D0040 Slot: 4
	public IDisposable Subscribe(IObserver<CountChangedStatus> observer) { }
}

