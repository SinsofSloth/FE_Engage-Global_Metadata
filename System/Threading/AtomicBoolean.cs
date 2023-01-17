// Namespace: System.Threading
internal class AtomicBoolean // TypeDefIndex: 730
{
	// Fields
	private int flag; // 0x10

	// Methods

	// RVA: 0x356B3D0 Offset: 0x356B4D1 VA: 0x356B3D0
	public bool TryRelaxedSet() { }

	// RVA: 0x356B410 Offset: 0x356B511 VA: 0x356B410
	public bool Exchange(bool newVal) { }

	// RVA: 0x356B440 Offset: 0x356B541 VA: 0x356B440
	public bool Equals(AtomicBoolean rhs) { }

	// RVA: 0x356B460 Offset: 0x356B561 VA: 0x356B460 Slot: 0
	public override bool Equals(object rhs) { }

	// RVA: 0x356B510 Offset: 0x356B611 VA: 0x356B510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x356B520 Offset: 0x356B621 VA: 0x356B520
	public void .ctor() { }
}

