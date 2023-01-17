// Namespace: System
[ComVisibleAttribute] // RVA: 0x4708A0 Offset: 0x4709A1 VA: 0x4708A0
[Serializable]
public class Random // TypeDefIndex: 291
{
	// Fields
	private int inext; // 0x10
	private int inextp; // 0x14
	private int[] SeedArray; // 0x18

	// Methods

	// RVA: 0x3B6F3E0 Offset: 0x3B6F4E1 VA: 0x3B6F3E0
	public void .ctor() { }

	// RVA: 0x3B6F410 Offset: 0x3B6F511 VA: 0x3B6F410
	public void .ctor(int Seed) { }

	// RVA: 0x3B6F820 Offset: 0x3B6F921 VA: 0x3B6F820 Slot: 4
	protected virtual double Sample() { }

	// RVA: 0x3B6F8C0 Offset: 0x3B6F9C1 VA: 0x3B6F8C0
	private int InternalSample() { }

	// RVA: 0x3B6F950 Offset: 0x3B6FA51 VA: 0x3B6F950 Slot: 5
	public virtual int Next() { }

	// RVA: 0x3B6F9E0 Offset: 0x3B6FAE1 VA: 0x3B6F9E0
	private double GetSampleForLargeRange() { }

	// RVA: 0x3B6FB00 Offset: 0x3B6FC01 VA: 0x3B6FB00 Slot: 6
	public virtual int Next(int minValue, int maxValue) { }

	// RVA: 0x3B6FC80 Offset: 0x3B6FD81 VA: 0x3B6FC80 Slot: 7
	public virtual int Next(int maxValue) { }

	// RVA: 0x3B6FD90 Offset: 0x3B6FE91 VA: 0x3B6FD90 Slot: 8
	public virtual double NextDouble() { }
}

