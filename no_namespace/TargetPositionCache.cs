// Namespace: 
public struct TargetPositionCache.TimeRange // TypeDefIndex: 5865
{
	// Fields
	public float Start; // 0x0
	public float End; // 0x4

	// Properties
	public bool IsEmpty { get; }
	public static TargetPositionCache.TimeRange Empty { get; }

	// Methods

	// RVA: 0x1C6C460 Offset: 0x1C6C561 VA: 0x1C6C460
	public bool get_IsEmpty() { }

	// RVA: 0x1C6C470 Offset: 0x1C6C571 VA: 0x1C6C470
	public bool Contains(float time) { }

	// RVA: 0x1C6C4A0 Offset: 0x1C6C5A1 VA: 0x1C6C4A0
	public static TargetPositionCache.TimeRange get_Empty() { }

	// RVA: 0x1C6C4C0 Offset: 0x1C6C5C1 VA: 0x1C6C4C0
	public void Include(float time) { }
}

