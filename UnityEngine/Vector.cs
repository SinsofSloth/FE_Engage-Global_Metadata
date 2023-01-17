// Namespace: UnityEngine
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43DD50 Offset: 0x43DE51 VA: 0x43DD50
[UsedByNativeCodeAttribute] // RVA: 0x43DD50 Offset: 0x43DE51 VA: 0x43DD50
[DefaultMemberAttribute] // RVA: 0x43DD50 Offset: 0x43DE51 VA: 0x43DD50
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable // TypeDefIndex: 3547
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C
	private static readonly Vector3Int s_Forward; // 0x48
	private static readonly Vector3Int s_Back; // 0x54

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int z { get; set; }

	// Methods

	// RVA: 0x3850610 Offset: 0x3850711 VA: 0x3850610
	public int get_x() { }

	// RVA: 0x3850620 Offset: 0x3850721 VA: 0x3850620
	public void set_x(int value) { }

	// RVA: 0x3850630 Offset: 0x3850731 VA: 0x3850630
	public int get_y() { }

	// RVA: 0x3850640 Offset: 0x3850741 VA: 0x3850640
	public void set_y(int value) { }

	// RVA: 0x3850650 Offset: 0x3850751 VA: 0x3850650
	public int get_z() { }

	// RVA: 0x3850660 Offset: 0x3850761 VA: 0x3850660
	public void set_z(int value) { }

	// RVA: 0x3850670 Offset: 0x3850771 VA: 0x3850670
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x3850680 Offset: 0x3850781 VA: 0x3850680
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x38506B0 Offset: 0x38507B1 VA: 0x38506B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3850770 Offset: 0x3850871 VA: 0x3850770 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x38507B0 Offset: 0x38508B1 VA: 0x38507B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3850830 Offset: 0x3850931 VA: 0x3850830 Slot: 3
	public override string ToString() { }

	// RVA: 0x38508C0 Offset: 0x38509C1 VA: 0x38508C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x3850A60 Offset: 0x3850B61 VA: 0x3850A60
	private static void .cctor() { }
}

