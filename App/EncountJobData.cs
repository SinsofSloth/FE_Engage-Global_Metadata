// Namespace: App
public class EncountJobData : StructData<EncountJobData> // TypeDefIndex: 9889
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28A080 Offset: 0x28A181 VA: 0x28A080
	private string <EJid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28A090 Offset: 0x28A191 VA: 0x28A090
	private string[] <Jobs>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28A0A0 Offset: 0x28A1A1 VA: 0x28A0A0
	private EncountJobData.FlagField <Flag>k__BackingField; // 0x30

	// Properties
	public string EJid { get; set; }
	public string[] Jobs { get; set; }
	public EncountJobData.FlagField Flag { get; set; }

	// Methods

	// RVA: 0x25F5510 Offset: 0x25F5611 VA: 0x25F5510
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5FA0 Offset: 0x2B60A1 VA: 0x2B5FA0
	// RVA: 0x25F89D0 Offset: 0x25F8AD1 VA: 0x25F89D0
	public string get_EJid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5FB0 Offset: 0x2B60B1 VA: 0x2B5FB0
	// RVA: 0x25F89E0 Offset: 0x25F8AE1 VA: 0x25F89E0
	private void set_EJid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5FC0 Offset: 0x2B60C1 VA: 0x2B5FC0
	// RVA: 0x25F89F0 Offset: 0x25F8AF1 VA: 0x25F89F0
	public string[] get_Jobs() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5FD0 Offset: 0x2B60D1 VA: 0x2B5FD0
	// RVA: 0x25F8A00 Offset: 0x25F8B01 VA: 0x25F8A00
	private void set_Jobs(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5FE0 Offset: 0x2B60E1 VA: 0x2B5FE0
	// RVA: 0x25F8A10 Offset: 0x25F8B11 VA: 0x25F8A10
	public EncountJobData.FlagField get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5FF0 Offset: 0x2B60F1 VA: 0x2B5FF0
	// RVA: 0x25F8A20 Offset: 0x25F8B21 VA: 0x25F8A20
	private void set_Flag(EncountJobData.FlagField value) { }

	// RVA: 0x25F8A30 Offset: 0x25F8B31 VA: 0x25F8A30 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x25F8A40 Offset: 0x25F8B41 VA: 0x25F8A40 Slot: 3
	public override string ToString() { }

	// RVA: 0x25F8A90 Offset: 0x25F8B91 VA: 0x25F8A90
	public string GetJid(int index) { }

	// RVA: 0x25F8AD0 Offset: 0x25F8BD1 VA: 0x25F8AD0
	public List<string> GetJidList() { }

	// RVA: 0x25F8B30 Offset: 0x25F8C31 VA: 0x25F8B30
	public int GetJidCount() { }

	// RVA: 0x25F8B40 Offset: 0x25F8C41 VA: 0x25F8B40
	public string GetPrefixlessEJid() { }

	// RVA: 0x25F8B50 Offset: 0x25F8C51 VA: 0x25F8B50
	public bool IsCcRandomSelected() { }

	// RVA: 0x25F8BB0 Offset: 0x25F8CB1 VA: 0x25F8BB0
	public static EncountJobData GetFromJid(string jid) { }

	// RVA: 0x25F8CF0 Offset: 0x25F8DF1 VA: 0x25F8CF0
	private bool IsContainsFromJid(string jid) { }

	// RVA: 0x25F8D50 Offset: 0x25F8E51 VA: 0x25F8D50
	public void .ctor() { }
}

