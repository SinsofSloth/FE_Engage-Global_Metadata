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

