// Namespace: UnityEngine.Timeline
internal abstract class RuntimeElement : IInterval // TypeDefIndex: 5662
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x57C00 Offset: 0x57D01 VA: 0x57C00
	private int <intervalBit>k__BackingField; // 0x10

	// Properties
	public abstract long intervalStart { get; }
	public abstract long intervalEnd { get; }
	public int intervalBit { get; set; }
	public abstract bool enable { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_intervalStart();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_intervalEnd();

	[CompilerGeneratedAttribute] // RVA: 0x581E0 Offset: 0x582E1 VA: 0x581E0
	// RVA: 0x36A89B0 Offset: 0x36A8AB1 VA: 0x36A89B0
	public int get_intervalBit() { }

	[CompilerGeneratedAttribute] // RVA: 0x581F0 Offset: 0x582F1 VA: 0x581F0
	// RVA: 0x36A89C0 Offset: 0x36A8AC1 VA: 0x36A89C0
	public void set_intervalBit(int value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_enable(bool value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void EvaluateAt(double localTime, FrameData frameData);

	// RVA: 0x36A89D0 Offset: 0x36A8AD1 VA: 0x36A89D0 Slot: 10
	public virtual void Reset() { }

	// RVA: 0x36A5710 Offset: 0x36A5811 VA: 0x36A5710
	protected void .ctor() { }
}

