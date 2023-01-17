// Namespace: System.Xml.Schema
[DefaultMemberAttribute] // RVA: 0x470A0 Offset: 0x471A1 VA: 0x470A0
internal sealed class BitSet // TypeDefIndex: 1798
{
	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1A27200 Offset: 0x1A27301 VA: 0x1A27200
	private void .ctor() { }

	// RVA: 0x1A21130 Offset: 0x1A21231 VA: 0x1A21130
	public void .ctor(int count) { }

	// RVA: 0x1A27220 Offset: 0x1A27321 VA: 0x1A27220
	public int get_Count() { }

	// RVA: 0x1A21690 Offset: 0x1A21791 VA: 0x1A21690
	public bool get_Item(int index) { }

	// RVA: 0x1A272A0 Offset: 0x1A273A1 VA: 0x1A272A0
	public void Clear() { }

	// RVA: 0x1A21300 Offset: 0x1A21401 VA: 0x1A21300
	public void Set(int index) { }

	// RVA: 0x1A27230 Offset: 0x1A27331 VA: 0x1A27230
	public bool Get(int index) { }

	// RVA: 0x1A273C0 Offset: 0x1A274C1 VA: 0x1A273C0
	public int NextSet(int startFrom) { }

	// RVA: 0x1A27470 Offset: 0x1A27571 VA: 0x1A27470
	public void And(BitSet other) { }

	// RVA: 0x1A27550 Offset: 0x1A27651 VA: 0x1A27550
	public void Or(BitSet other) { }

	// RVA: 0x1A27680 Offset: 0x1A27781 VA: 0x1A27680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A276C0 Offset: 0x1A277C1 VA: 0x1A276C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A27820 Offset: 0x1A27921 VA: 0x1A27820
	public BitSet Clone() { }

	// RVA: 0x1A278F0 Offset: 0x1A279F1 VA: 0x1A278F0
	public bool get_IsEmpty() { }

	// RVA: 0x1A27960 Offset: 0x1A27A61 VA: 0x1A27960
	public bool Intersects(BitSet other) { }

	// RVA: 0x1A27210 Offset: 0x1A27311 VA: 0x1A27210
	private int Subscript(int bitIndex) { }

	// RVA: 0x1A27310 Offset: 0x1A27411 VA: 0x1A27310
	private void EnsureLength(int nRequiredLength) { }
}

