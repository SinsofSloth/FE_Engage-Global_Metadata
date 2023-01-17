// Namespace: UnityEngine.Rendering
[DefaultMemberAttribute] // RVA: 0x3B7A0 Offset: 0x3B8A1 VA: 0x3B7A0
[DebuggerDisplayAttribute] // RVA: 0x3B7A0 Offset: 0x3B8A1 VA: 0x3B7A0
[Serializable]
public struct BitArray16 : IBitArray // TypeDefIndex: 4614
{
	// Fields
	[SerializeField] // RVA: 0x3CC80 Offset: 0x3CD81 VA: 0x3CC80
	private ushort data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1B27850 Offset: 0x1B27951 VA: 0x1B27850 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x1B27860 Offset: 0x1B27961 VA: 0x1B27860 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x1B27870 Offset: 0x1B27971 VA: 0x1B27870 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x1B27880 Offset: 0x1B27981 VA: 0x1B27880 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x1B27A40 Offset: 0x1B27B41 VA: 0x1B27A40 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x1B27A60 Offset: 0x1B27B61 VA: 0x1B27A60 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x1B27AC0 Offset: 0x1B27BC1 VA: 0x1B27AC0
	public void .ctor(ushort initValue) { }

	// RVA: 0x1B27AD0 Offset: 0x1B27BD1 VA: 0x1B27AD0
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x1B27BA0 Offset: 0x1B27CA1 VA: 0x1B27BA0
	public static BitArray16 op_OnesComplement(BitArray16 a) { }

	// RVA: 0x1B27BB0 Offset: 0x1B27CB1 VA: 0x1B27BB0
	public static BitArray16 op_BitwiseOr(BitArray16 a, BitArray16 b) { }

	// RVA: 0x1B27BC0 Offset: 0x1B27CC1 VA: 0x1B27BC0
	public static BitArray16 op_BitwiseAnd(BitArray16 a, BitArray16 b) { }

	// RVA: 0x1B27BD0 Offset: 0x1B27CD1 VA: 0x1B27BD0 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x1B27C70 Offset: 0x1B27D71 VA: 0x1B27C70 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x1B27D10 Offset: 0x1B27E11 VA: 0x1B27D10 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x1B27D80 Offset: 0x1B27E81 VA: 0x1B27D80
	public static bool op_Equality(BitArray16 a, BitArray16 b) { }

	// RVA: 0x1B27D90 Offset: 0x1B27E91 VA: 0x1B27D90
	public static bool op_Inequality(BitArray16 a, BitArray16 b) { }

	// RVA: 0x1B27DA0 Offset: 0x1B27EA1 VA: 0x1B27DA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B27E30 Offset: 0x1B27F31 VA: 0x1B27E30 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3B860 Offset: 0x3B961 VA: 0x3B860
[DefaultMemberAttribute] // RVA: 0x3B860 Offset: 0x3B961 VA: 0x3B860
[Serializable]
public struct BitArray64 : IBitArray // TypeDefIndex: 4616
{
	// Fields
	[SerializeField] // RVA: 0x3CCA0 Offset: 0x3CDA1 VA: 0x3CCA0
	private ulong data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1B290F0 Offset: 0x1B291F1 VA: 0x1B290F0 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x1B29100 Offset: 0x1B29201 VA: 0x1B29100 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x1B29110 Offset: 0x1B29211 VA: 0x1B29110 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x1B29120 Offset: 0x1B29221 VA: 0x1B29120 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x1B292E0 Offset: 0x1B293E1 VA: 0x1B292E0 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x1B29300 Offset: 0x1B29401 VA: 0x1B29300 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x1B29360 Offset: 0x1B29461 VA: 0x1B29360
	public void .ctor(ulong initValue) { }

	// RVA: 0x1B29370 Offset: 0x1B29471 VA: 0x1B29370
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x1B29440 Offset: 0x1B29541 VA: 0x1B29440
	public static BitArray64 op_OnesComplement(BitArray64 a) { }

	// RVA: 0x1B29450 Offset: 0x1B29551 VA: 0x1B29450
	public static BitArray64 op_BitwiseOr(BitArray64 a, BitArray64 b) { }

	// RVA: 0x1B29460 Offset: 0x1B29561 VA: 0x1B29460
	public static BitArray64 op_BitwiseAnd(BitArray64 a, BitArray64 b) { }

	// RVA: 0x1B29470 Offset: 0x1B29571 VA: 0x1B29470 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x1B29510 Offset: 0x1B29611 VA: 0x1B29510 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x1B295B0 Offset: 0x1B296B1 VA: 0x1B295B0 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x1B29620 Offset: 0x1B29721 VA: 0x1B29620
	public static bool op_Equality(BitArray64 a, BitArray64 b) { }

	// RVA: 0x1B29630 Offset: 0x1B29731 VA: 0x1B29630
	public static bool op_Inequality(BitArray64 a, BitArray64 b) { }

	// RVA: 0x1B29640 Offset: 0x1B29741 VA: 0x1B29640 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B296D0 Offset: 0x1B297D1 VA: 0x1B296D0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DefaultMemberAttribute] // RVA: 0x3B920 Offset: 0x3BA21 VA: 0x3B920
[DebuggerDisplayAttribute] // RVA: 0x3B920 Offset: 0x3BA21 VA: 0x3B920
[Serializable]
public struct BitArray256 : IBitArray // TypeDefIndex: 4618
{
	// Fields
	[SerializeField] // RVA: 0x3CCD0 Offset: 0x3CDD1 VA: 0x3CCD0
	private ulong data1; // 0x0
	[SerializeField] // RVA: 0x3CCE0 Offset: 0x3CDE1 VA: 0x3CCE0
	private ulong data2; // 0x8
	[SerializeField] // RVA: 0x3CCF0 Offset: 0x3CDF1 VA: 0x3CCF0
	private ulong data3; // 0x10
	[SerializeField] // RVA: 0x3CD00 Offset: 0x3CE01 VA: 0x3CD00
	private ulong data4; // 0x18

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1B27E60 Offset: 0x1B27F61 VA: 0x1B27E60 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x1B27E70 Offset: 0x1B27F71 VA: 0x1B27E70 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x1B27EB0 Offset: 0x1B27FB1 VA: 0x1B27EB0 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x1B27F00 Offset: 0x1B28001 VA: 0x1B27F00 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x1B28230 Offset: 0x1B28331 VA: 0x1B28230 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x1B282C0 Offset: 0x1B283C1 VA: 0x1B282C0 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x1B28420 Offset: 0x1B28521 VA: 0x1B28420
	public void .ctor(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4) { }

	// RVA: 0x1B28430 Offset: 0x1B28531 VA: 0x1B28430
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x1B28550 Offset: 0x1B28651 VA: 0x1B28550
	public static BitArray256 op_OnesComplement(BitArray256 a) { }

	// RVA: 0x1B28580 Offset: 0x1B28681 VA: 0x1B28580
	public static BitArray256 op_BitwiseOr(BitArray256 a, BitArray256 b) { }

	// RVA: 0x1B285B0 Offset: 0x1B286B1 VA: 0x1B285B0
	public static BitArray256 op_BitwiseAnd(BitArray256 a, BitArray256 b) { }

	// RVA: 0x1B285E0 Offset: 0x1B286E1 VA: 0x1B285E0 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x1B286B0 Offset: 0x1B287B1 VA: 0x1B286B0 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x1B28780 Offset: 0x1B28881 VA: 0x1B28780 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x1B28800 Offset: 0x1B28901 VA: 0x1B28800
	public static bool op_Equality(BitArray256 a, BitArray256 b) { }

	// RVA: 0x1B28850 Offset: 0x1B28951 VA: 0x1B28850
	public static bool op_Inequality(BitArray256 a, BitArray256 b) { }

	// RVA: 0x1B288A0 Offset: 0x1B289A1 VA: 0x1B288A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B289E0 Offset: 0x1B28AE1 VA: 0x1B289E0 Slot: 2
	public override int GetHashCode() { }
}

