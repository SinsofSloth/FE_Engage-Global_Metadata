// Namespace: App
[DefaultMemberAttribute] // RVA: 0x278E90 Offset: 0x278F91 VA: 0x278E90
public class UnitAccessoryList // TypeDefIndex: 13507
{
	// Fields
	public const int Version = 0;
	private UnitAccessory[] m_UnitAccessorys; // 0x10

	// Properties
	public int Count { get; }
	public UnitAccessory Item { get; }
	public UnitAccessory Item { get; }

	// Methods

	// RVA: 0x23CAE80 Offset: 0x23CAF81 VA: 0x23CAE80
	public int get_Count() { }

	// RVA: 0x23CAE90 Offset: 0x23CAF91 VA: 0x23CAE90
	public UnitAccessory get_Item(int i) { }

	// RVA: 0x23CAED0 Offset: 0x23CAFD1 VA: 0x23CAED0
	public UnitAccessory get_Item(AccessoryData.Kinds kind) { }

	// RVA: 0x23CAF10 Offset: 0x23CB011 VA: 0x23CAF10
	public void .ctor() { }

	// RVA: 0x23CB0F0 Offset: 0x23CB1F1 VA: 0x23CB0F0
	public void Clear() { }

	// RVA: 0x23CB170 Offset: 0x23CB271 VA: 0x23CB170
	public bool IsExist(AccessoryData accessory) { }

	// RVA: 0x23CB380 Offset: 0x23CB481 VA: 0x23CB380
	public void Clear(int index) { }

	// RVA: 0x23CB3C0 Offset: 0x23CB4C1 VA: 0x23CB3C0
	public void Clear(AccessoryData.Kinds kind) { }

	// RVA: 0x23CB400 Offset: 0x23CB501 VA: 0x23CB400
	public bool Add(AccessoryData accessory, AccessoryData.Kinds kind) { }

	// RVA: 0x23CB410 Offset: 0x23CB511 VA: 0x23CB410
	public bool Add(AccessoryData accessory, int index = -1) { }

	// RVA: 0x23CB790 Offset: 0x23CB891 VA: 0x23CB790
	public void CopyFrom(UnitAccessoryList list) { }

	// RVA: 0x23CB880 Offset: 0x23CB981 VA: 0x23CB880
	public void Serialize(Stream stream) { }

	// RVA: 0x23CB930 Offset: 0x23CBA31 VA: 0x23CB930
	public void Deserialize(Stream stream) { }
}

