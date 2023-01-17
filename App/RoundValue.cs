// Namespace: App
public struct RoundValue : IDisposable // TypeDefIndex: 9215
{
	// Fields
	private int m_Min; // 0x0
	private int m_Max; // 0x4
	private int m_Value; // 0x8

	// Properties
	public int Value { get; }
	public int Min { get; }
	public int Max { get; }

	// Methods

	// RVA: 0x205E550 Offset: 0x205E651 VA: 0x205E550
	public void .ctor(int max) { }

	// RVA: 0x205E560 Offset: 0x205E661 VA: 0x205E560
	public void .ctor(int max, int value) { }

	// RVA: 0x205E570 Offset: 0x205E671 VA: 0x205E570
	public void .ctor(int min, int max, int value) { }

	// RVA: 0x205E580 Offset: 0x205E681 VA: 0x205E580 Slot: 4
	public void Dispose() { }

	// RVA: 0x205E590 Offset: 0x205E691 VA: 0x205E590
	public void Inc() { }

	// RVA: 0x205E670 Offset: 0x205E771 VA: 0x205E670
	public void Dec() { }

	// RVA: 0x205E5D0 Offset: 0x205E6D1 VA: 0x205E5D0
	public void Add(int addend) { }

	// RVA: 0x205E6B0 Offset: 0x205E7B1 VA: 0x205E6B0
	public void Sub(int subtrahend) { }

	// RVA: 0x205E700 Offset: 0x205E801 VA: 0x205E700
	public int get_Value() { }

	// RVA: 0x205E710 Offset: 0x205E811 VA: 0x205E710
	public int get_Min() { }

	// RVA: 0x205E720 Offset: 0x205E821 VA: 0x205E720
	public int get_Max() { }

	// RVA: 0x205E730 Offset: 0x205E831 VA: 0x205E730
	public static int op_Implicit(RoundValue value) { }
}

