// Namespace: App
public class EncountEquipData : StructDataArray<EncountEquipData> // TypeDefIndex: 9884
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28A020 Offset: 0x28A121 VA: 0x28A020
	private string <Category>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28A030 Offset: 0x28A131 VA: 0x28A030
	private byte <Percentage>k__BackingField; // 0x30
	public const int RankNone = -1;
	private int m_LowerRank; // 0x34
	private int m_UpperRank; // 0x38

	// Properties
	public string Category { get; set; }
	public byte Percentage { get; set; }

	// Methods

	// RVA: 0x25F5300 Offset: 0x25F5401 VA: 0x25F5300
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5EE0 Offset: 0x2B5FE1 VA: 0x2B5EE0
	// RVA: 0x25F6F90 Offset: 0x25F7091 VA: 0x25F6F90
	public string get_Category() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5EF0 Offset: 0x2B5FF1 VA: 0x2B5EF0
	// RVA: 0x25F6FA0 Offset: 0x25F70A1 VA: 0x25F6FA0
	private void set_Category(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5F00 Offset: 0x2B6001 VA: 0x2B5F00
	// RVA: 0x25F6FB0 Offset: 0x25F70B1 VA: 0x25F6FB0
	public byte get_Percentage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5F10 Offset: 0x2B6011 VA: 0x2B5F10
	// RVA: 0x25F6FC0 Offset: 0x25F70C1 VA: 0x25F6FC0
	private void set_Percentage(byte value) { }

	// RVA: 0x25F6FD0 Offset: 0x25F70D1 VA: 0x25F6FD0 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x25F70D0 Offset: 0x25F71D1 VA: 0x25F70D0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x25F70E0 Offset: 0x25F71E1 VA: 0x25F70E0
	public int GetKindCount(ItemData.Kinds kind) { }

	// RVA: 0x25F72B0 Offset: 0x25F73B1 VA: 0x25F72B0
	public int GetKindCount(ItemData.Kinds[] kinds) { }

	// RVA: 0x25F68C0 Offset: 0x25F69C1 VA: 0x25F68C0
	public bool IsContains(int rank) { }

	// RVA: 0x25F7340 Offset: 0x25F7441 VA: 0x25F7340
	public void .ctor() { }
}

