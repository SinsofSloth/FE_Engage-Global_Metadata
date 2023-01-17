// Namespace: App
public abstract class StructBase // TypeDefIndex: 13971
{
	// Fields
	public int Index; // 0x10
	public int Hash; // 0x14
	public string Key; // 0x18

	// Methods

	// RVA: 0x29258E0 Offset: 0x29259E1 VA: 0x29258E0 Slot: 4
	public virtual void OnBuild() { }

	// RVA: 0x29258F0 Offset: 0x29259F1 VA: 0x29258F0 Slot: 5
	public virtual void OnCompleted() { }

	// RVA: 0x2925900 Offset: 0x2925A01 VA: 0x2925900 Slot: 6
	public virtual void OnCompletedEnd() { }

	// RVA: 0x2925910 Offset: 0x2925A11 VA: 0x2925910 Slot: 7
	public virtual void OnRelease() { }

	// RVA: 0x2925920 Offset: 0x2925A21 VA: 0x2925920 Slot: 8
	public virtual string GetDebugName() { }

	// RVA: 0x2925970 Offset: 0x2925A71 VA: 0x2925970
	public int GetIndex() { }

	// RVA: 0x2925980 Offset: 0x2925A81 VA: 0x2925980
	protected void .ctor() { }
}

