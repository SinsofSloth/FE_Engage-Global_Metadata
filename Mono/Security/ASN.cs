// Namespace: Mono.Security
[DefaultMemberAttribute] // RVA: 0x46F690 Offset: 0x46F791 VA: 0x46F690
internal class ASN1 // TypeDefIndex: 44
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x35570F0 Offset: 0x35571F1 VA: 0x35570F0
	public void .ctor(byte tag) { }

	// RVA: 0x3557130 Offset: 0x3557231 VA: 0x3557130
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x3557180 Offset: 0x3557281 VA: 0x3557180
	public void .ctor(byte[] data) { }

	// RVA: 0x3557450 Offset: 0x3557551 VA: 0x3557450
	public int get_Count() { }

	// RVA: 0x3557470 Offset: 0x3557571 VA: 0x3557470
	public byte get_Tag() { }

	// RVA: 0x3557480 Offset: 0x3557581 VA: 0x3557480
	public int get_Length() { }

	// RVA: 0x35574A0 Offset: 0x35575A1 VA: 0x35574A0
	public byte[] get_Value() { }

	// RVA: 0x3557550 Offset: 0x3557651 VA: 0x3557550
	public void set_Value(byte[] value) { }

	// RVA: 0x3557600 Offset: 0x3557701 VA: 0x3557600
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x3557680 Offset: 0x3557781 VA: 0x3557680
	public bool CompareValue(byte[] value) { }

	// RVA: 0x35576E0 Offset: 0x35577E1 VA: 0x35576E0
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x3557870 Offset: 0x3557971 VA: 0x3557870 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x3557310 Offset: 0x3557411 VA: 0x3557310
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x3557F00 Offset: 0x3558001 VA: 0x3557F00
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x3558040 Offset: 0x3558141 VA: 0x3558040
	public ASN1 get_Item(int index) { }

	// RVA: 0x3558180 Offset: 0x3558281 VA: 0x3558180
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x35582D0 Offset: 0x35583D1 VA: 0x35582D0 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
[DefaultMemberAttribute] // RVA: 0x85870 Offset: 0x85971 VA: 0x85870
public class ASN1 // TypeDefIndex: 1526
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1BC10D0 Offset: 0x1BC11D1 VA: 0x1BC10D0
	public void .ctor(byte tag) { }

	// RVA: 0x1BC1110 Offset: 0x1BC1211 VA: 0x1BC1110
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1BC1160 Offset: 0x1BC1261 VA: 0x1BC1160
	public void .ctor(byte[] data) { }

	// RVA: 0x1BC14A0 Offset: 0x1BC15A1 VA: 0x1BC14A0
	public int get_Count() { }

	// RVA: 0x1BC14C0 Offset: 0x1BC15C1 VA: 0x1BC14C0
	public byte get_Tag() { }

	// RVA: 0x1BC14D0 Offset: 0x1BC15D1 VA: 0x1BC14D0
	public int get_Length() { }

	// RVA: 0x1BC14F0 Offset: 0x1BC15F1 VA: 0x1BC14F0
	public byte[] get_Value() { }

	// RVA: 0x1BC15A0 Offset: 0x1BC16A1 VA: 0x1BC15A0
	public void set_Value(byte[] value) { }

	// RVA: 0x1BC1650 Offset: 0x1BC1751 VA: 0x1BC1650
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1BC16D0 Offset: 0x1BC17D1 VA: 0x1BC16D0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1BC1730 Offset: 0x1BC1831 VA: 0x1BC1730
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1BC17D0 Offset: 0x1BC18D1 VA: 0x1BC17D0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1BC12F0 Offset: 0x1BC13F1 VA: 0x1BC12F0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1BC1E00 Offset: 0x1BC1F01 VA: 0x1BC1E00
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1BC1F40 Offset: 0x1BC2041 VA: 0x1BC1F40
	public ASN1 get_Item(int index) { }

	// RVA: 0x1BC2080 Offset: 0x1BC2181 VA: 0x1BC2080
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1BC21D0 Offset: 0x1BC22D1 VA: 0x1BC21D0 Slot: 3
	public override string ToString() { }
}

