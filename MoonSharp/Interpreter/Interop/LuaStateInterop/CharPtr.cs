// Namespace: MoonSharp.Interpreter.Interop.LuaStateInterop
[DefaultMemberAttribute] // RVA: 0xD900 Offset: 0xDA01 VA: 0xD900
public class CharPtr // TypeDefIndex: 6146
{
	// Fields
	public char[] chars; // 0x10
	public int index; // 0x18

	// Properties
	public char Item { get; set; }
	public char Item { get; set; }
	public char Item { get; set; }

	// Methods

	// RVA: 0x30F5BB0 Offset: 0x30F5CB1 VA: 0x30F5BB0
	public char get_Item(int offset) { }

	// RVA: 0x30F5BF0 Offset: 0x30F5CF1 VA: 0x30F5BF0
	public void set_Item(int offset, char value) { }

	// RVA: 0x30F5C30 Offset: 0x30F5D31 VA: 0x30F5C30
	public char get_Item(uint offset) { }

	// RVA: 0x30F5CB0 Offset: 0x30F5DB1 VA: 0x30F5CB0
	public void set_Item(uint offset, char value) { }

	// RVA: 0x30F5D30 Offset: 0x30F5E31 VA: 0x30F5D30
	public char get_Item(long offset) { }

	// RVA: 0x30F5D70 Offset: 0x30F5E71 VA: 0x30F5D70
	public void set_Item(long offset, char value) { }

	// RVA: 0x30F5DB0 Offset: 0x30F5EB1 VA: 0x30F5DB0
	public static CharPtr op_Implicit(string str) { }

	// RVA: 0x30F5F00 Offset: 0x30F6001 VA: 0x30F5F00
	public static CharPtr op_Implicit(char[] chars) { }

	// RVA: 0x30F5FC0 Offset: 0x30F60C1 VA: 0x30F5FC0
	public static CharPtr op_Implicit(byte[] bytes) { }

	// RVA: 0x30F6110 Offset: 0x30F6211 VA: 0x30F6110
	public void .ctor() { }

	// RVA: 0x30F5E70 Offset: 0x30F5F71 VA: 0x30F5E70
	public void .ctor(string str) { }

	// RVA: 0x30F6150 Offset: 0x30F6251 VA: 0x30F6150
	public void .ctor(CharPtr ptr) { }

	// RVA: 0x30F6190 Offset: 0x30F6291 VA: 0x30F6190
	public void .ctor(CharPtr ptr, int index) { }

	// RVA: 0x30F5F80 Offset: 0x30F6081 VA: 0x30F5F80
	public void .ctor(char[] chars) { }

	// RVA: 0x30F61E0 Offset: 0x30F62E1 VA: 0x30F61E0
	public void .ctor(char[] chars, int index) { }

	// RVA: 0x30F6030 Offset: 0x30F6131 VA: 0x30F6030
	public void .ctor(byte[] bytes) { }

	// RVA: 0x30F6230 Offset: 0x30F6331 VA: 0x30F6230
	public void .ctor(IntPtr ptr) { }

	// RVA: 0x30F62B0 Offset: 0x30F63B1 VA: 0x30F62B0
	public static CharPtr op_Addition(CharPtr ptr, int offset) { }

	// RVA: 0x30F6340 Offset: 0x30F6441 VA: 0x30F6340
	public static CharPtr op_Subtraction(CharPtr ptr, int offset) { }

	// RVA: 0x30F63D0 Offset: 0x30F64D1 VA: 0x30F63D0
	public static CharPtr op_Addition(CharPtr ptr, uint offset) { }

	// RVA: 0x30F6460 Offset: 0x30F6561 VA: 0x30F6460
	public static CharPtr op_Subtraction(CharPtr ptr, uint offset) { }

	// RVA: 0x30F64F0 Offset: 0x30F65F1 VA: 0x30F64F0
	public void inc() { }

	// RVA: 0x30F6500 Offset: 0x30F6601 VA: 0x30F6500
	public void dec() { }

	// RVA: 0x30F6510 Offset: 0x30F6611 VA: 0x30F6510
	public CharPtr next() { }

	// RVA: 0x30F65A0 Offset: 0x30F66A1 VA: 0x30F65A0
	public CharPtr prev() { }

	// RVA: 0x30F6630 Offset: 0x30F6731 VA: 0x30F6630
	public CharPtr add(int ofs) { }

	// RVA: 0x30F66C0 Offset: 0x30F67C1 VA: 0x30F66C0
	public CharPtr sub(int ofs) { }

	// RVA: 0x30F6750 Offset: 0x30F6851 VA: 0x30F6750
	public static bool op_Equality(CharPtr ptr, char ch) { }

	// RVA: 0x30F6790 Offset: 0x30F6891 VA: 0x30F6790
	public static bool op_Equality(char ch, CharPtr ptr) { }

	// RVA: 0x30F67D0 Offset: 0x30F68D1 VA: 0x30F67D0
	public static bool op_Inequality(CharPtr ptr, char ch) { }

	// RVA: 0x30F6810 Offset: 0x30F6911 VA: 0x30F6810
	public static bool op_Inequality(char ch, CharPtr ptr) { }

	// RVA: 0x30F6850 Offset: 0x30F6951 VA: 0x30F6850
	public static CharPtr op_Addition(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6A10 Offset: 0x30F6B11 VA: 0x30F6A10
	public static int op_Subtraction(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6A20 Offset: 0x30F6B21 VA: 0x30F6A20
	public static bool op_LessThan(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6A40 Offset: 0x30F6B41 VA: 0x30F6A40
	public static bool op_LessThanOrEqual(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6A60 Offset: 0x30F6B61 VA: 0x30F6A60
	public static bool op_GreaterThan(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6A80 Offset: 0x30F6B81 VA: 0x30F6A80
	public static bool op_GreaterThanOrEqual(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6AA0 Offset: 0x30F6BA1 VA: 0x30F6AA0
	public static bool op_Equality(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6AF0 Offset: 0x30F6BF1 VA: 0x30F6AF0
	public static bool op_Inequality(CharPtr ptr1, CharPtr ptr2) { }

	// RVA: 0x30F6B40 Offset: 0x30F6C41 VA: 0x30F6B40 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x30F6C10 Offset: 0x30F6D11 VA: 0x30F6C10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x30F6C20 Offset: 0x30F6D21 VA: 0x30F6C20 Slot: 3
	public override string ToString() { }

	// RVA: 0x30F6CF0 Offset: 0x30F6DF1 VA: 0x30F6CF0
	public string ToString(int length) { }
}

