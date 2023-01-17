// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3B740 Offset: 0x3B841 VA: 0x3B740
[DefaultMemberAttribute] // RVA: 0x3B740 Offset: 0x3B841 VA: 0x3B740
[Serializable]
public struct BitArray8 : IBitArray // TypeDefIndex: 4613
{
	// Fields
	[SerializeField] // RVA: 0x3CC70 Offset: 0x3CD71 VA: 0x3CC70
	private byte data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1B29700 Offset: 0x1B29801 VA: 0x1B29700 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x1B29710 Offset: 0x1B29811 VA: 0x1B29710 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x1B29720 Offset: 0x1B29821 VA: 0x1B29720 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x1B29730 Offset: 0x1B29831 VA: 0x1B29730 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x1B29830 Offset: 0x1B29931 VA: 0x1B29830 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x1B29850 Offset: 0x1B29951 VA: 0x1B29850 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x1B298B0 Offset: 0x1B299B1 VA: 0x1B298B0
	public void .ctor(byte initValue) { }

	// RVA: 0x1B298C0 Offset: 0x1B299C1 VA: 0x1B298C0
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x1B29990 Offset: 0x1B29A91 VA: 0x1B29990
	public static BitArray8 op_OnesComplement(BitArray8 a) { }

	// RVA: 0x1B299A0 Offset: 0x1B29AA1 VA: 0x1B299A0
	public static BitArray8 op_BitwiseOr(BitArray8 a, BitArray8 b) { }

	// RVA: 0x1B299B0 Offset: 0x1B29AB1 VA: 0x1B299B0
	public static BitArray8 op_BitwiseAnd(BitArray8 a, BitArray8 b) { }

	// RVA: 0x1B299C0 Offset: 0x1B29AC1 VA: 0x1B299C0 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x1B29A60 Offset: 0x1B29B61 VA: 0x1B29A60 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x1B29B00 Offset: 0x1B29C01 VA: 0x1B29B00 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x1B29B70 Offset: 0x1B29C71 VA: 0x1B29B70
	public static bool op_Equality(BitArray8 a, BitArray8 b) { }

	// RVA: 0x1B29B80 Offset: 0x1B29C81 VA: 0x1B29B80
	public static bool op_Inequality(BitArray8 a, BitArray8 b) { }

	// RVA: 0x1B29B90 Offset: 0x1B29C91 VA: 0x1B29B90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B29C20 Offset: 0x1B29D21 VA: 0x1B29C20 Slot: 2
	public override int GetHashCode() { }
}

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
[DebuggerDisplayAttribute] // RVA: 0x3B800 Offset: 0x3B901 VA: 0x3B800
[DefaultMemberAttribute] // RVA: 0x3B800 Offset: 0x3B901 VA: 0x3B800
[Serializable]
public struct BitArray32 : IBitArray // TypeDefIndex: 4615
{
	// Fields
	[SerializeField] // RVA: 0x3CC90 Offset: 0x3CD91 VA: 0x3CC90
	private uint data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	private string humanizedVersion { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1B28A60 Offset: 0x1B28B61 VA: 0x1B28A60 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x1B28A70 Offset: 0x1B28B71 VA: 0x1B28A70 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x1B28A80 Offset: 0x1B28B81 VA: 0x1B28A80 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x1B28A90 Offset: 0x1B28B91 VA: 0x1B28A90
	private string get_humanizedVersion() { }

	// RVA: 0x1B28B10 Offset: 0x1B28C11 VA: 0x1B28B10 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x1B28CD0 Offset: 0x1B28DD1 VA: 0x1B28CD0 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x1B28CF0 Offset: 0x1B28DF1 VA: 0x1B28CF0 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x1B28D50 Offset: 0x1B28E51 VA: 0x1B28D50
	public void .ctor(uint initValue) { }

	// RVA: 0x1B28D60 Offset: 0x1B28E61 VA: 0x1B28D60
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x1B28E30 Offset: 0x1B28F31 VA: 0x1B28E30 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x1B28EE0 Offset: 0x1B28FE1 VA: 0x1B28EE0 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x1B28F90 Offset: 0x1B29091 VA: 0x1B28F90 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x1B29000 Offset: 0x1B29101 VA: 0x1B29000
	public static BitArray32 op_OnesComplement(BitArray32 a) { }

	// RVA: 0x1B28F80 Offset: 0x1B29081 VA: 0x1B28F80
	public static BitArray32 op_BitwiseOr(BitArray32 a, BitArray32 b) { }

	// RVA: 0x1B28ED0 Offset: 0x1B28FD1 VA: 0x1B28ED0
	public static BitArray32 op_BitwiseAnd(BitArray32 a, BitArray32 b) { }

	// RVA: 0x1B29010 Offset: 0x1B29111 VA: 0x1B29010
	public static bool op_Equality(BitArray32 a, BitArray32 b) { }

	// RVA: 0x1B29020 Offset: 0x1B29121 VA: 0x1B29020
	public static bool op_Inequality(BitArray32 a, BitArray32 b) { }

	// RVA: 0x1B29030 Offset: 0x1B29131 VA: 0x1B29030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B290C0 Offset: 0x1B291C1 VA: 0x1B290C0 Slot: 2
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
[DefaultMemberAttribute] // RVA: 0x3B8C0 Offset: 0x3B9C1 VA: 0x3B8C0
[DebuggerDisplayAttribute] // RVA: 0x3B8C0 Offset: 0x3B9C1 VA: 0x3B8C0
[Serializable]
public struct BitArray128 : IBitArray // TypeDefIndex: 4617
{
	// Fields
	[SerializeField] // RVA: 0x3CCB0 Offset: 0x3CDB1 VA: 0x3CCB0
	private ulong data1; // 0x0
	[SerializeField] // RVA: 0x3CCC0 Offset: 0x3CDC1 VA: 0x3CCC0
	private ulong data2; // 0x8

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1B270A0 Offset: 0x1B271A1 VA: 0x1B270A0 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x1B270B0 Offset: 0x1B271B1 VA: 0x1B270B0 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x1B270D0 Offset: 0x1B271D1 VA: 0x1B270D0 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x1B27100 Offset: 0x1B27201 VA: 0x1B27100 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x1B27340 Offset: 0x1B27441 VA: 0x1B27340 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x1B27380 Offset: 0x1B27481 VA: 0x1B27380 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x1B27400 Offset: 0x1B27501 VA: 0x1B27400
	public void .ctor(ulong initValue1, ulong initValue2) { }

	// RVA: 0x1B27410 Offset: 0x1B27511 VA: 0x1B27410
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x1B274F0 Offset: 0x1B275F1 VA: 0x1B274F0
	public static BitArray128 op_OnesComplement(BitArray128 a) { }

	// RVA: 0x1B27500 Offset: 0x1B27601 VA: 0x1B27500
	public static BitArray128 op_BitwiseOr(BitArray128 a, BitArray128 b) { }

	// RVA: 0x1B27510 Offset: 0x1B27611 VA: 0x1B27510
	public static BitArray128 op_BitwiseAnd(BitArray128 a, BitArray128 b) { }

	// RVA: 0x1B27520 Offset: 0x1B27621 VA: 0x1B27520 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x1B275D0 Offset: 0x1B276D1 VA: 0x1B275D0 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x1B27680 Offset: 0x1B27781 VA: 0x1B27680 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x1B276F0 Offset: 0x1B277F1 VA: 0x1B276F0
	public static bool op_Equality(BitArray128 a, BitArray128 b) { }

	// RVA: 0x1B27710 Offset: 0x1B27811 VA: 0x1B27710
	public static bool op_Inequality(BitArray128 a, BitArray128 b) { }

	// RVA: 0x1B27730 Offset: 0x1B27831 VA: 0x1B27730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B27800 Offset: 0x1B27901 VA: 0x1B27800 Slot: 2
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

