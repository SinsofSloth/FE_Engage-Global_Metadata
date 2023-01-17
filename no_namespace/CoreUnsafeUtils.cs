// Namespace: 
public struct CoreUnsafeUtils.FixedBufferStringQueue // TypeDefIndex: 4516
{
	// Fields
	private byte* m_ReadCursor; // 0x0
	private byte* m_WriteCursor; // 0x8
	private readonly byte* m_BufferEnd; // 0x10
	private readonly byte* m_BufferStart; // 0x18
	private readonly int m_BufferLength; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x3C9F0 Offset: 0x3CAF1 VA: 0x3C9F0
	private int <Count>k__BackingField; // 0x24

	// Properties
	public int Count { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D5D0 Offset: 0x3D6D1 VA: 0x3D5D0
	[IsReadOnlyAttribute] // RVA: 0x3D5D0 Offset: 0x3D6D1 VA: 0x3D5D0
	// RVA: 0x354EE10 Offset: 0x354EF11 VA: 0x354EE10
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D610 Offset: 0x3D711 VA: 0x3D610
	// RVA: 0x354EE20 Offset: 0x354EF21 VA: 0x354EE20
	private void set_Count(int value) { }

	// RVA: 0x354EE30 Offset: 0x354EF31 VA: 0x354EE30
	public void .ctor(byte* ptr, int length) { }

	// RVA: 0x354EE80 Offset: 0x354EF81 VA: 0x354EE80
	public bool TryPush(string v) { }

	// RVA: 0x354EF40 Offset: 0x354F041 VA: 0x354EF40
	public bool TryPop(out string v) { }

	// RVA: 0x354EE60 Offset: 0x354EF61 VA: 0x354EE60
	public void Clear() { }
}

// Namespace: 
internal struct CoreUnsafeUtils.DefaultKeyGetter<T> : CoreUnsafeUtils.IKeyGetter<T, T> // TypeDefIndex: 4518
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T Get(ref T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510E60 Offset: 0x2510F61 VA: 0x2510E60
	|-CoreUnsafeUtils.DefaultKeyGetter<object>.Get
	*/
}

