// Namespace: App
public class UnitEdit // TypeDefIndex: 13522
{
	// Fields
	private const int Version = 2;
	public const int MinMonth = 1;
	public const int MaxMonth = 12;
	public const int MinDay = 1;
	public const int MaxDay = 31;
	private string m_Name; // 0x10
	private string m_MorphName; // 0x18
	private Gender m_Gender; // 0x20
	private Language.Langs m_Language; // 0x24
	private byte m_BirthMonth; // 0x28
	private byte m_BirthDay; // 0x29

	// Properties
	public Gender Gender { get; set; }
	public int BirthMonth { get; set; }
	public int BirthDay { get; set; }

	// Methods

	// RVA: 0x23DCDB0 Offset: 0x23DCEB1 VA: 0x23DCDB0
	public bool IsEnable() { }

	// RVA: 0x23DCDC0 Offset: 0x23DCEC1 VA: 0x23DCDC0
	public string GetName() { }

	// RVA: 0x23DCE60 Offset: 0x23DCF61 VA: 0x23DCE60
	public string GetName(bool isMorph) { }

	// RVA: 0x23DCF50 Offset: 0x23DD051 VA: 0x23DCF50
	public void SetName(string name) { }

	// RVA: 0x23DD080 Offset: 0x23DD181 VA: 0x23DD080
	private void UpdateName() { }

	// RVA: 0x23DD1B0 Offset: 0x23DD2B1 VA: 0x23DD1B0
	public Gender get_Gender() { }

	// RVA: 0x23DD1C0 Offset: 0x23DD2C1 VA: 0x23DD1C0
	public void set_Gender(Gender value) { }

	// RVA: 0x23DD1D0 Offset: 0x23DD2D1 VA: 0x23DD1D0
	public int get_BirthMonth() { }

	// RVA: 0x23DD1E0 Offset: 0x23DD2E1 VA: 0x23DD1E0
	public void set_BirthMonth(int value) { }

	// RVA: 0x23DD220 Offset: 0x23DD321 VA: 0x23DD220
	public int get_BirthDay() { }

	// RVA: 0x23DD230 Offset: 0x23DD331 VA: 0x23DD230
	public void set_BirthDay(int value) { }

	// RVA: 0x23DD270 Offset: 0x23DD371 VA: 0x23DD270
	public void Clear() { }

	// RVA: 0x23DD2C0 Offset: 0x23DD3C1 VA: 0x23DD2C0
	public void CopyFrom(UnitEdit src) { }

	// RVA: 0x23DD320 Offset: 0x23DD421 VA: 0x23DD320
	public void Serialize(Stream stream) { }

	// RVA: 0x23DD3D0 Offset: 0x23DD4D1 VA: 0x23DD3D0
	public void Deserialize(Stream stream) { }

	// RVA: 0x23DDB30 Offset: 0x23DDC31 VA: 0x23DDB30
	public void .ctor() { }
}

