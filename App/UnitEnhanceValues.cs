// Namespace: App
[DefaultMemberAttribute] // RVA: 0x278F00 Offset: 0x279001 VA: 0x278F00
public class UnitEnhanceValues // TypeDefIndex: 13525
{
	// Fields
	public const int Num = 11;
	private const int Version = 1;
	private int[] m_Values; // 0x10

	// Properties
	public int Item { get; set; }

	// Methods

	// RVA: 0x23E4380 Offset: 0x23E4481 VA: 0x23E4380
	public bool IsZero() { }

	// RVA: 0x23E4400 Offset: 0x23E4501 VA: 0x23E4400
	public void Set(UnitEnhanceValues values) { }

	// RVA: 0x23E45E0 Offset: 0x23E46E1 VA: 0x23E45E0
	public void Add(UnitEnhanceValues values, bool isNotEnhance = False) { }

	// RVA: 0x23E4AD0 Offset: 0x23E4BD1 VA: 0x23E4AD0
	public void Sub(UnitEnhanceValues values) { }

	// RVA: 0x23E4D10 Offset: 0x23E4E11 VA: 0x23E4D10
	public void Merge(UnitEnhanceValues values, bool isNotEnhance = False) { }

	// RVA: 0x23E4E90 Offset: 0x23E4F91 VA: 0x23E4E90
	public void Set(CapabilitySbyte capability) { }

	// RVA: 0x23E50B0 Offset: 0x23E51B1 VA: 0x23E50B0
	public void Add(CapabilitySbyte capability, bool isNotEnhance = False) { }

	// RVA: 0x23E55D0 Offset: 0x23E56D1 VA: 0x23E55D0
	public void Merge(CapabilitySbyte capability) { }

	// RVA: 0x23E56B0 Offset: 0x23E57B1 VA: 0x23E56B0
	public void Add(CapabilitySbyte capability, int decay, bool isNotEnhance = False) { }

	// RVA: 0x23E5830 Offset: 0x23E5931 VA: 0x23E5830
	public void Add(CapabilityDefinition.Type type, int value, bool isNotEnhance = False) { }

	// RVA: 0x23E58A0 Offset: 0x23E59A1 VA: 0x23E58A0
	public void Clear(int value = 0) { }

	// RVA: 0x23E59A0 Offset: 0x23E5AA1 VA: 0x23E59A0
	public void Clamp(int min, int max) { }

	// RVA: 0x23E2780 Offset: 0x23E2881 VA: 0x23E2780
	public void Serialize(Stream stream) { }

	// RVA: 0x23E2B10 Offset: 0x23E2C11 VA: 0x23E2B10
	public void Deserialize(Stream stream) { }

	// RVA: 0x23E1520 Offset: 0x23E1621 VA: 0x23E1520
	public int get_Item(int index) { }

	// RVA: 0x23E3A40 Offset: 0x23E3B41 VA: 0x23E3A40
	public void set_Item(int index, int value) { }

	// RVA: 0x23E5C20 Offset: 0x23E5D21 VA: 0x23E5C20
	public static string GetNameForDebug(int index) { }

	// RVA: 0x23DDE40 Offset: 0x23DDF41 VA: 0x23DDE40
	public void .ctor() { }
}

