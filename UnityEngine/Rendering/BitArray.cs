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

