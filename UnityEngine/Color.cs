// Namespace: UnityEngine
[NativeClassAttribute] // RVA: 0x43D770 Offset: 0x43D871 VA: 0x43D770
[DefaultMemberAttribute] // RVA: 0x43D770 Offset: 0x43D871 VA: 0x43D770
[NativeHeaderAttribute] // RVA: 0x43D770 Offset: 0x43D871 VA: 0x43D770
[RequiredByNativeCodeAttribute] // RVA: 0x43D770 Offset: 0x43D871 VA: 0x43D770
public struct Color : IEquatable<Color>, IFormattable // TypeDefIndex: 3536
{
	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color grey { get; }
	public static Color clear { get; }
	public Color linear { get; }
	public Color gamma { get; }
	public float maxColorComponent { get; }

	// Methods

	// RVA: 0x2F15080 Offset: 0x2F15181 VA: 0x2F15080
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x2F150A0 Offset: 0x2F151A1 VA: 0x2F150A0
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x2F150C0 Offset: 0x2F151C1 VA: 0x2F150C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F15150 Offset: 0x2F15251 VA: 0x2F15150 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2F15350 Offset: 0x2F15451 VA: 0x2F15350 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F153D0 Offset: 0x2F154D1 VA: 0x2F153D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2F154C0 Offset: 0x2F155C1 VA: 0x2F154C0 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x2F15550 Offset: 0x2F15651 VA: 0x2F15550
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x2F15570 Offset: 0x2F15671 VA: 0x2F15570
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x2F15590 Offset: 0x2F15691 VA: 0x2F15590
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x2F155B0 Offset: 0x2F156B1 VA: 0x2F155B0
	public static Color op_Multiply(float b, Color a) { }

	// RVA: 0x2F155D0 Offset: 0x2F156D1 VA: 0x2F155D0
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x2F156A0 Offset: 0x2F157A1 VA: 0x2F156A0
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x2F15770 Offset: 0x2F15871 VA: 0x2F15770
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x2F15800 Offset: 0x2F15901 VA: 0x2F15800
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x2F15820 Offset: 0x2F15921 VA: 0x2F15820
	public static Color get_red() { }

	// RVA: 0x2F15840 Offset: 0x2F15941 VA: 0x2F15840
	public static Color get_green() { }

	// RVA: 0x2F15860 Offset: 0x2F15961 VA: 0x2F15860
	public static Color get_blue() { }

	// RVA: 0x2F15880 Offset: 0x2F15981 VA: 0x2F15880
	public static Color get_white() { }

	// RVA: 0x2F158A0 Offset: 0x2F159A1 VA: 0x2F158A0
	public static Color get_black() { }

	// RVA: 0x2F158C0 Offset: 0x2F159C1 VA: 0x2F158C0
	public static Color get_yellow() { }

	// RVA: 0x2F158F0 Offset: 0x2F159F1 VA: 0x2F158F0
	public static Color get_cyan() { }

	// RVA: 0x2F15910 Offset: 0x2F15A11 VA: 0x2F15910
	public static Color get_magenta() { }

	// RVA: 0x2F15930 Offset: 0x2F15A31 VA: 0x2F15930
	public static Color get_gray() { }

	// RVA: 0x2F15950 Offset: 0x2F15A51 VA: 0x2F15950
	public static Color get_grey() { }

	// RVA: 0x2F15970 Offset: 0x2F15A71 VA: 0x2F15970
	public static Color get_clear() { }

	// RVA: 0x2F15990 Offset: 0x2F15A91 VA: 0x2F15990
	public Color get_linear() { }

	// RVA: 0x2F159F0 Offset: 0x2F15AF1 VA: 0x2F159F0
	public Color get_gamma() { }

	// RVA: 0x2F15A50 Offset: 0x2F15B51 VA: 0x2F15A50
	public float get_maxColorComponent() { }

	// RVA: 0x2F153A0 Offset: 0x2F154A1 VA: 0x2F153A0
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x2F15A80 Offset: 0x2F15B81 VA: 0x2F15A80
	public static Color op_Implicit(Vector4 v) { }
}

// Namespace: UnityEngine
[DefaultMemberAttribute] // RVA: 0x43D820 Offset: 0x43D921 VA: 0x43D820
[UsedByNativeCodeAttribute] // RVA: 0x43D820 Offset: 0x43D921 VA: 0x43D820
public struct Color32 : IFormattable // TypeDefIndex: 3537
{
	// Fields
	[IgnoreAttribute] // RVA: 0x4432D0 Offset: 0x4433D1 VA: 0x4432D0
	private int rgba; // 0x0
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

	// Methods

	// RVA: 0x2F15A90 Offset: 0x2F15B91 VA: 0x2F15A90
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x2F15AB0 Offset: 0x2F15BB1 VA: 0x2F15AB0
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x2F15D50 Offset: 0x2F15E51 VA: 0x2F15D50
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x2F15D90 Offset: 0x2F15E91 VA: 0x2F15D90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F15E20 Offset: 0x2F15F21 VA: 0x2F15E20 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

