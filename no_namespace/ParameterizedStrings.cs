// Namespace: 
public struct ParameterizedStrings.FormatParam // TypeDefIndex: 396
{
	// Fields
	private readonly int _int32; // 0x0
	private readonly string _string; // 0x8

	// Properties
	public int Int32 { get; }
	public string String { get; }
	public object Object { get; }

	// Methods

	// RVA: 0x35F25B0 Offset: 0x35F26B1 VA: 0x35F25B0
	public void .ctor(int value) { }

	// RVA: 0x35F25C0 Offset: 0x35F26C1 VA: 0x35F25C0
	private void .ctor(int intValue, string stringValue) { }

	// RVA: 0x35F25D0 Offset: 0x35F26D1 VA: 0x35F25D0
	public static ParameterizedStrings.FormatParam op_Implicit(int value) { }

	// RVA: 0x35F2610 Offset: 0x35F2711 VA: 0x35F2610
	public int get_Int32() { }

	// RVA: 0x35F2620 Offset: 0x35F2721 VA: 0x35F2620
	public string get_String() { }

	// RVA: 0x35F2690 Offset: 0x35F2791 VA: 0x35F2690
	public object get_Object() { }
}

// Namespace: 
private sealed class ParameterizedStrings.LowLevelStack // TypeDefIndex: 397
{
	// Fields
	private ParameterizedStrings.FormatParam[] _arr; // 0x10
	private int _count; // 0x18

	// Methods

	// RVA: 0x35F2710 Offset: 0x35F2811 VA: 0x35F2710
	public void .ctor() { }

	// RVA: 0x35F2780 Offset: 0x35F2881 VA: 0x35F2780
	public ParameterizedStrings.FormatParam Pop() { }

	// RVA: 0x35F2820 Offset: 0x35F2921 VA: 0x35F2820
	public void Push(ParameterizedStrings.FormatParam item) { }

	// RVA: 0x35F2910 Offset: 0x35F2A11 VA: 0x35F2910
	public void Clear() { }
}

