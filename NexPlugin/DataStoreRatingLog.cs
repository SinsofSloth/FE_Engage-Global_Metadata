// Namespace: NexPlugin
public class DataStoreRatingLog // TypeDefIndex: 14876
{
	// Fields
	internal NpDateTime lockExpirationTime; // 0x10
	internal ulong pid; // 0x18
	internal int ratingValue; // 0x20
	internal bool isRated; // 0x24

	// Methods

	// RVA: 0x2E957B0 Offset: 0x2E958B1 VA: 0x2E957B0
	public void .ctor() { }

	// RVA: 0x2E957E0 Offset: 0x2E958E1 VA: 0x2E957E0
	public bool IsRated() { }

	// RVA: 0x2E957F0 Offset: 0x2E958F1 VA: 0x2E957F0
	public ulong GetPrincipalId() { }

	// RVA: 0x2E95800 Offset: 0x2E95901 VA: 0x2E95800
	public int GetRatingValue() { }

	// RVA: 0x2E95810 Offset: 0x2E95911 VA: 0x2E95810
	public NpDateTime GetLockExpirationTime() { }

	// RVA: 0x2E95820 Offset: 0x2E95921 VA: 0x2E95820
	public void Trace() { }

	// RVA: 0x2E95830 Offset: 0x2E95931 VA: 0x2E95830 Slot: 3
	public override string ToString() { }
}

