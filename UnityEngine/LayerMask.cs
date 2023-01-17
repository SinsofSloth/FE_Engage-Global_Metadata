// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43E850 Offset: 0x43E951 VA: 0x43E850
[NativeClassAttribute] // RVA: 0x43E850 Offset: 0x43E951 VA: 0x43E850
[RequiredByNativeCodeAttribute] // RVA: 0x43E850 Offset: 0x43E951 VA: 0x43E850
[NativeHeaderAttribute] // RVA: 0x43E850 Offset: 0x43E951 VA: 0x43E850
public struct LayerMask // TypeDefIndex: 3595
{
	// Fields
	[NativeNameAttribute] // RVA: 0x443910 Offset: 0x443A11 VA: 0x443910
	private int m_Mask; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x2F276F0 Offset: 0x2F277F1 VA: 0x2F276F0
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x2F27700 Offset: 0x2F27801 VA: 0x2F27700
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x2F27710 Offset: 0x2F27811 VA: 0x2F27710
	public int get_value() { }

	[StaticAccessorAttribute] // RVA: 0x44FE70 Offset: 0x44FF71 VA: 0x44FE70
	[NativeMethodAttribute] // RVA: 0x44FE70 Offset: 0x44FF71 VA: 0x44FE70
	// RVA: 0x2F27720 Offset: 0x2F27821 VA: 0x2F27720
	public static string LayerToName(int layer) { }

	[StaticAccessorAttribute] // RVA: 0x44FEE0 Offset: 0x44FFE1 VA: 0x44FEE0
	[NativeMethodAttribute] // RVA: 0x44FEE0 Offset: 0x44FFE1 VA: 0x44FEE0
	// RVA: 0x2F27770 Offset: 0x2F27871 VA: 0x2F27770
	public static int NameToLayer(string layerName) { }

	// RVA: 0x2F277C0 Offset: 0x2F278C1 VA: 0x2F277C0
	public static int GetMask(string[] layerNames) { }
}

