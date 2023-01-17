// Namespace: App
public class EncountRareMonayData : StructDataArray<EncountRareMonayData> // TypeDefIndex: 9890
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28A0B0 Offset: 0x28A1B1 VA: 0x28A0B0
	private ushort <NationLevel>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28A0C0 Offset: 0x28A1C1 VA: 0x28A0C0
	private string <Iid>k__BackingField; // 0x30

	// Properties
	public ushort NationLevel { get; set; }
	public string Iid { get; set; }

	// Methods

	// RVA: 0x25F5460 Offset: 0x25F5561 VA: 0x25F5460
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B6000 Offset: 0x2B6101 VA: 0x2B6000
	// RVA: 0x25FB390 Offset: 0x25FB491 VA: 0x25FB390
	public ushort get_NationLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B6010 Offset: 0x2B6111 VA: 0x2B6010
	// RVA: 0x25FB3A0 Offset: 0x25FB4A1 VA: 0x25FB3A0
	private void set_NationLevel(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B6020 Offset: 0x2B6121 VA: 0x2B6020
	// RVA: 0x25FB3B0 Offset: 0x25FB4B1 VA: 0x25FB3B0
	public string get_Iid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B6030 Offset: 0x2B6131 VA: 0x2B6030
	// RVA: 0x25FB3C0 Offset: 0x25FB4C1 VA: 0x25FB3C0
	private void set_Iid(string value) { }

	// RVA: 0x25FB3D0 Offset: 0x25FB4D1 VA: 0x25FB3D0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x25F6CE0 Offset: 0x25F6DE1 VA: 0x25F6CE0
	public static string GetIid(Difficulty difficulty, int nationLevel) { }

	// RVA: 0x25FB400 Offset: 0x25FB501 VA: 0x25FB400
	private static string GetDifficultyText(Difficulty difficulty) { }

	// RVA: 0x25FB4C0 Offset: 0x25FB5C1 VA: 0x25FB4C0
	public void .ctor() { }
}

