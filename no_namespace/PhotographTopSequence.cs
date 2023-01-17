// Namespace: 
public enum PhotographTopSequence.Label // TypeDefIndex: 11535
{
	// Fields
	public int value__; // 0x0
	public const PhotographTopSequence.Label Entry = 0;
	public const PhotographTopSequence.Label SelectArea = 1;
	public const PhotographTopSequence.Label SetupPhotograph = 2;
	public const PhotographTopSequence.Label Exit = 3;
}

// Namespace: 
public class PhotographTopSequence.UnitAccDataSet // TypeDefIndex: 11536
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x298900 Offset: 0x298A01 VA: 0x298900
	private string <Pid>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x298910 Offset: 0x298A11 VA: 0x298910
	private AccessoryData <BodyAccData>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x298920 Offset: 0x298A21 VA: 0x298920
	private AccessoryData <FaceAccData>k__BackingField; // 0x20
	private string m_RecordPid; // 0x28
	private AccessoryData m_RecordBodyAccData; // 0x30
	private AccessoryData m_RecordFaceAccData; // 0x38

	// Properties
	public string Pid { get; set; }
	public AccessoryData BodyAccData { get; set; }
	public AccessoryData FaceAccData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C5CF0 Offset: 0x2C5DF1 VA: 0x2C5CF0
	// RVA: 0x1F200B0 Offset: 0x1F201B1 VA: 0x1F200B0
	public string get_Pid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5D00 Offset: 0x2C5E01 VA: 0x2C5D00
	// RVA: 0x1F200C0 Offset: 0x1F201C1 VA: 0x1F200C0
	public void set_Pid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5D10 Offset: 0x2C5E11 VA: 0x2C5D10
	// RVA: 0x1F200D0 Offset: 0x1F201D1 VA: 0x1F200D0
	public AccessoryData get_BodyAccData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5D20 Offset: 0x2C5E21 VA: 0x2C5D20
	// RVA: 0x1F200E0 Offset: 0x1F201E1 VA: 0x1F200E0
	public void set_BodyAccData(AccessoryData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5D30 Offset: 0x2C5E31 VA: 0x2C5D30
	// RVA: 0x1F200F0 Offset: 0x1F201F1 VA: 0x1F200F0
	public AccessoryData get_FaceAccData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5D40 Offset: 0x2C5E41 VA: 0x2C5D40
	// RVA: 0x1F20100 Offset: 0x1F20201 VA: 0x1F20100
	public void set_FaceAccData(AccessoryData value) { }

	// RVA: 0x1F20110 Offset: 0x1F20211 VA: 0x1F20110
	public void .ctor(Unit unit) { }

	// RVA: 0x1F20270 Offset: 0x1F20371 VA: 0x1F20270
	public void SaveAccDataSet() { }

	// RVA: 0x1F202C0 Offset: 0x1F203C1 VA: 0x1F202C0
	public void LoadAccDataSet() { }
}

