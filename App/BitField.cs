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

// Namespace: App
public class BitField64 : BitFieldCommon // TypeDefIndex: 9175
{
	// Fields
	protected long m_Value; // 0x10

	// Properties
	protected override Type ValueType { get; }
	public long Value { get; set; }

	// Methods

	// RVA: 0x2C76D70 Offset: 0x2C76E71 VA: 0x2C76D70
	public void .ctor() { }

	// RVA: 0x2C76DA0 Offset: 0x2C76EA1 VA: 0x2C76DA0
	public void .ctor(long f) { }

	// RVA: 0x2C76DD0 Offset: 0x2C76ED1 VA: 0x2C76DD0
	public void .ctor(BitField64 f) { }

	// RVA: 0x2C76E00 Offset: 0x2C76F01 VA: 0x2C76E00
	public void Set(long f) { }

	// RVA: 0x2C76E10 Offset: 0x2C76F11 VA: 0x2C76E10
	public void Set(BitField64 f) { }

	// RVA: 0x2C76E30 Offset: 0x2C76F31 VA: 0x2C76E30
	public void Clear(long f) { }

	// RVA: 0x2C76E40 Offset: 0x2C76F41 VA: 0x2C76E40
	public void Clear(BitField64 f) { }

	// RVA: 0x2C76E60 Offset: 0x2C76F61 VA: 0x2C76E60
	public void Change(long f) { }

	// RVA: 0x2C76E70 Offset: 0x2C76F71 VA: 0x2C76E70
	public void Change(BitField64 f) { }

	// RVA: 0x2C76E90 Offset: 0x2C76F91 VA: 0x2C76E90
	public void Copy(int f) { }

	// RVA: 0x2C76EA0 Offset: 0x2C76FA1 VA: 0x2C76EA0
	public void Copy(BitField64 f) { }

	// RVA: 0x2C76EB0 Offset: 0x2C76FB1 VA: 0x2C76EB0
	public void SetOrClear(bool isSet, long f) { }

	// RVA: 0x2C76ED0 Offset: 0x2C76FD1 VA: 0x2C76ED0
	public bool Exclusive(long n, long m) { }

	// RVA: 0x2C76EF0 Offset: 0x2C76FF1 VA: 0x2C76EF0
	public long Mask(long f) { }

	// RVA: 0x2C76F00 Offset: 0x2C77001 VA: 0x2C76F00
	public long Mask(BitField64 f) { }

	// RVA: 0x2C76F10 Offset: 0x2C77011 VA: 0x2C76F10
	public bool Test(long f) { }

	// RVA: 0x2C76F20 Offset: 0x2C77021 VA: 0x2C76F20
	public bool Test(BitField64 f) { }

	// RVA: 0x2C76F40 Offset: 0x2C77041 VA: 0x2C76F40
	public bool Not(long f) { }

	// RVA: 0x2C76F50 Offset: 0x2C77051 VA: 0x2C76F50
	public bool Not(BitField64 f) { }

	// RVA: 0x2C76F70 Offset: 0x2C77071 VA: 0x2C76F70
	public void Reset() { }

	// RVA: 0x2C76F80 Offset: 0x2C77081 VA: 0x2C76F80
	public void Reset(long f) { }

	// RVA: 0x2C76F90 Offset: 0x2C77091 VA: 0x2C76F90
	public void Reset(BitField64 f) { }

	// RVA: 0x2C76FA0 Offset: 0x2C770A1 VA: 0x2C76FA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C772F0 Offset: 0x2C773F1 VA: 0x2C772F0 Slot: 4
	protected override Type get_ValueType() { }

	// RVA: 0x2C77360 Offset: 0x2C77461 VA: 0x2C77360
	public long get_Value() { }

	// RVA: 0x2C77370 Offset: 0x2C77471 VA: 0x2C77370
	public void set_Value(long value) { }

	// RVA: 0x2C77380 Offset: 0x2C77481 VA: 0x2C77380
	public static bool op_Equality(BitField64 lhs, long rhs) { }

	// RVA: 0x2C77390 Offset: 0x2C77491 VA: 0x2C77390
	public static bool op_Inequality(BitField64 lhs, long rhs) { }

	// RVA: 0x2C773A0 Offset: 0x2C774A1 VA: 0x2C773A0
	public static bool op_Equality(BitField64 lhs, BitField64 rhs) { }

	// RVA: 0x2C773E0 Offset: 0x2C774E1 VA: 0x2C773E0
	public static bool op_Inequality(BitField64 lhs, BitField64 rhs) { }

	// RVA: 0x2C77420 Offset: 0x2C77521 VA: 0x2C77420 Slot: 0
	public override bool Equals(object rhsObj) { }

	// RVA: 0x2C774D0 Offset: 0x2C775D1 VA: 0x2C774D0
	public bool Equals(BitField64 rhs) { }

	// RVA: 0x2C774F0 Offset: 0x2C775F1 VA: 0x2C774F0 Slot: 2
	public override int GetHashCode() { }
}

