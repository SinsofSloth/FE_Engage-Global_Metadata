// Namespace: App
public class BitField32 : BitFieldCommon // TypeDefIndex: 9174
{
	// Fields
	protected int m_Value; // 0x10

	// Properties
	protected override Type ValueType { get; }
	public int Value { get; set; }

	// Methods

	// RVA: 0x2C76810 Offset: 0x2C76911 VA: 0x2C76810
	public void .ctor() { }

	// RVA: 0x2C76850 Offset: 0x2C76951 VA: 0x2C76850
	public void .ctor(int f) { }

	// RVA: 0x2C76880 Offset: 0x2C76981 VA: 0x2C76880
	public void .ctor(BitField32 f) { }

	// RVA: 0x2C768B0 Offset: 0x2C769B1 VA: 0x2C768B0
	public void Set(int f) { }

	// RVA: 0x2C768C0 Offset: 0x2C769C1 VA: 0x2C768C0
	public void Set(BitField32 f) { }

	// RVA: 0x2C768E0 Offset: 0x2C769E1 VA: 0x2C768E0
	public void Clear(int f) { }

	// RVA: 0x2C768F0 Offset: 0x2C769F1 VA: 0x2C768F0
	public void Clear(BitField32 f) { }

	// RVA: 0x2C76910 Offset: 0x2C76A11 VA: 0x2C76910
	public void Change(int f) { }

	// RVA: 0x2C76920 Offset: 0x2C76A21 VA: 0x2C76920
	public void Change(BitField32 f) { }

	// RVA: 0x2C76940 Offset: 0x2C76A41 VA: 0x2C76940
	public void Copy(int f) { }

	// RVA: 0x2C76950 Offset: 0x2C76A51 VA: 0x2C76950
	public void Copy(BitField32 f) { }

	// RVA: 0x2C76960 Offset: 0x2C76A61 VA: 0x2C76960
	public void SetOrClear(bool isSet, int f) { }

	// RVA: 0x2C76980 Offset: 0x2C76A81 VA: 0x2C76980
	public bool Exclusive(int n, int m) { }

	// RVA: 0x2C769A0 Offset: 0x2C76AA1 VA: 0x2C769A0
	public int Mask(int f) { }

	// RVA: 0x2C769B0 Offset: 0x2C76AB1 VA: 0x2C769B0
	public int Mask(BitField32 f) { }

	// RVA: 0x2C769C0 Offset: 0x2C76AC1 VA: 0x2C769C0
	public bool Test(int f) { }

	// RVA: 0x2C769D0 Offset: 0x2C76AD1 VA: 0x2C769D0
	public bool Test(BitField32 f) { }

	// RVA: 0x2C769F0 Offset: 0x2C76AF1 VA: 0x2C769F0
	public bool Not(int f) { }

	// RVA: 0x2C76A00 Offset: 0x2C76B01 VA: 0x2C76A00
	public bool Not(BitField32 f) { }

	// RVA: 0x2C76A20 Offset: 0x2C76B21 VA: 0x2C76A20
	public void Reset() { }

	// RVA: 0x2C76A30 Offset: 0x2C76B31 VA: 0x2C76A30
	public void Reset(int f) { }

	// RVA: 0x2C76A40 Offset: 0x2C76B41 VA: 0x2C76A40
	public void Reset(BitField32 f) { }

	// RVA: 0x2C76A50 Offset: 0x2C76B51 VA: 0x2C76A50 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C76A90 Offset: 0x2C76B91 VA: 0x2C76A90 Slot: 4
	protected override Type get_ValueType() { }

	// RVA: 0x2C76B00 Offset: 0x2C76C01 VA: 0x2C76B00
	public int get_Value() { }

	// RVA: 0x2C76B10 Offset: 0x2C76C11 VA: 0x2C76B10
	public void set_Value(int value) { }

	// RVA: 0x2C76B20 Offset: 0x2C76C21 VA: 0x2C76B20
	public static bool op_Equality(BitField32 lhs, int rhs) { }

	// RVA: 0x2C76B30 Offset: 0x2C76C31 VA: 0x2C76B30
	public static bool op_Inequality(BitField32 lhs, int rhs) { }

	// RVA: 0x2C76B40 Offset: 0x2C76C41 VA: 0x2C76B40
	public static bool op_Equality(BitField32 lhs, BitField32 rhs) { }

	// RVA: 0x2C76B80 Offset: 0x2C76C81 VA: 0x2C76B80
	public static bool op_Inequality(BitField32 lhs, BitField32 rhs) { }

	// RVA: 0x2C76BC0 Offset: 0x2C76CC1 VA: 0x2C76BC0 Slot: 0
	public override bool Equals(object rhsObj) { }

	// RVA: 0x2C76C70 Offset: 0x2C76D71 VA: 0x2C76C70
	public bool Equals(BitField32 rhs) { }

	// RVA: 0x2C76C90 Offset: 0x2C76D91 VA: 0x2C76C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2C76CA0 Offset: 0x2C76DA1 VA: 0x2C76CA0
	public void Read(Stream stream) { }

	// RVA: 0x2C76D50 Offset: 0x2C76E51 VA: 0x2C76D50
	public void Write(Stream stream) { }
}

