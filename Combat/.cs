// Namespace: Combat
[ExtensionAttribute] // RVA: 0x273760 Offset: 0x273861 VA: 0x273760
internal static class __SkillStackEx // TypeDefIndex: 8506
{
	// Methods

	[ExtensionAttribute] // RVA: 0x2A8B40 Offset: 0x2A8C41 VA: 0x2A8B40
	// RVA: 0x26D9C40 Offset: 0x26D9D41 VA: 0x26D9C40
	public static bool IsNotNull(SkillStack ss) { }

	[ExtensionAttribute] // RVA: 0x2A8B50 Offset: 0x2A8C51 VA: 0x2A8B50
	// RVA: 0x26D9C60 Offset: 0x26D9D61 VA: 0x26D9C60
	public static bool IsNull(SkillStack ss) { }

	[ExtensionAttribute] // RVA: 0x2A8B60 Offset: 0x2A8C61 VA: 0x2A8B60
	// RVA: 0x26D9DB0 Offset: 0x26D9EB1 VA: 0x26D9DB0
	public static bool IsNotNull(SkillStack ss, int fromSide) { }

	[ExtensionAttribute] // RVA: 0x2A8B70 Offset: 0x2A8C71 VA: 0x2A8B70
	// RVA: 0x26D9DD0 Offset: 0x26D9ED1 VA: 0x26D9DD0
	public static bool IsNull(SkillStack ss, int fromSide) { }

	[ExtensionAttribute] // RVA: 0x2A8B80 Offset: 0x2A8C81 VA: 0x2A8B80
	// RVA: 0x26D9F30 Offset: 0x26DA031 VA: 0x26D9F30
	public static bool Has(SkillStack ss, string name) { }

	[ExtensionAttribute] // RVA: 0x2A8B90 Offset: 0x2A8C91 VA: 0x2A8B90
	// RVA: 0x26D9F50 Offset: 0x26DA051 VA: 0x26D9F50
	public static SkillStack.Packet Get(SkillStack ss, string name) { }

	[ExtensionAttribute] // RVA: 0x2A8BA0 Offset: 0x2A8CA1 VA: 0x2A8BA0
	// RVA: 0x26DA0C0 Offset: 0x26DA1C1 VA: 0x26DA0C0
	public static bool Has(SkillStack ss, int fromSide, string name) { }

	[ExtensionAttribute] // RVA: 0x2A8BB0 Offset: 0x2A8CB1 VA: 0x2A8BB0
	// RVA: 0x26DA0E0 Offset: 0x26DA1E1 VA: 0x26DA0E0
	public static SkillData Get(SkillStack ss, int fromSide, string name) { }
}

