// Namespace: UnityEngine.U2D
[VisibleToOtherModulesAttribute] // RVA: 0x43F380 Offset: 0x43F481 VA: 0x43F380
internal struct SpriteChannelInfo // TypeDefIndex: 3662
{
	// Fields
	[NativeNameAttribute] // RVA: 0x443BA0 Offset: 0x443CA1 VA: 0x443BA0
	private IntPtr m_Buffer; // 0x0
	[NativeNameAttribute] // RVA: 0x443BE0 Offset: 0x443CE1 VA: 0x443BE0
	private int m_Count; // 0x8
	[NativeNameAttribute] // RVA: 0x443C20 Offset: 0x443D21 VA: 0x443C20
	private int m_Offset; // 0xC
	[NativeNameAttribute] // RVA: 0x443C60 Offset: 0x443D61 VA: 0x443C60
	private int m_Stride; // 0x10

	// Properties
	public void* buffer { get; }
	public int count { get; }
	public int offset { get; }
	public int stride { get; }

	// Methods

	// RVA: 0x31F1320 Offset: 0x31F1421 VA: 0x31F1320
	public void* get_buffer() { }

	// RVA: 0x31F1330 Offset: 0x31F1431 VA: 0x31F1330
	public int get_count() { }

	// RVA: 0x31F1340 Offset: 0x31F1441 VA: 0x31F1340
	public int get_offset() { }

	// RVA: 0x31F1350 Offset: 0x31F1451 VA: 0x31F1350
	public int get_stride() { }
}

