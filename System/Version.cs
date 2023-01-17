// Namespace: System
[ComVisibleAttribute] // RVA: 0x470EE0 Offset: 0x470FE1 VA: 0x470EE0
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 337
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x34CDDF0 Offset: 0x34CDEF1 VA: 0x34CDDF0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x34CDF60 Offset: 0x34CE061 VA: 0x34CDF60
	public void .ctor(int major, int minor) { }

	// RVA: 0x34CE050 Offset: 0x34CE151 VA: 0x34CE050
	public void .ctor() { }

	// RVA: 0x34CE080 Offset: 0x34CE181 VA: 0x34CE080
	public int get_Major() { }

	// RVA: 0x34CE090 Offset: 0x34CE191 VA: 0x34CE090
	public int get_Minor() { }

	// RVA: 0x34CE0A0 Offset: 0x34CE1A1 VA: 0x34CE0A0
	public int get_Build() { }

	// RVA: 0x34CE0B0 Offset: 0x34CE1B1 VA: 0x34CE0B0
	public int get_Revision() { }

	// RVA: 0x34CE0C0 Offset: 0x34CE1C1 VA: 0x34CE0C0 Slot: 4
	public object Clone() { }

	// RVA: 0x34CE150 Offset: 0x34CE251 VA: 0x34CE150 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x34CE390 Offset: 0x34CE491 VA: 0x34CE390 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x34CE490 Offset: 0x34CE591 VA: 0x34CE490 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34CE580 Offset: 0x34CE681 VA: 0x34CE580 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x34CE660 Offset: 0x34CE761 VA: 0x34CE660 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34CE680 Offset: 0x34CE781 VA: 0x34CE680 Slot: 3
	public override string ToString() { }

	// RVA: 0x34CE6B0 Offset: 0x34CE7B1 VA: 0x34CE6B0
	public string ToString(int fieldCount) { }

	// RVA: 0x34CECE0 Offset: 0x34CEDE1 VA: 0x34CECE0
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x34CE2A0 Offset: 0x34CE3A1 VA: 0x34CE2A0
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x34CED60 Offset: 0x34CEE61 VA: 0x34CED60
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x34CEDE0 Offset: 0x34CEEE1 VA: 0x34CEDE0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x34CEE50 Offset: 0x34CEF51 VA: 0x34CEE50
	private static void .cctor() { }
}

