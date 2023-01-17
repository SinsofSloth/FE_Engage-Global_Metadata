// Namespace: System.Resources
[ComVisibleAttribute] // RVA: 0x471540 Offset: 0x471641 VA: 0x471540
[AttributeUsageAttribute] // RVA: 0x471540 Offset: 0x471641 VA: 0x471540
public sealed class NeutralResourcesLanguageAttribute : Attribute // TypeDefIndex: 489
{
	// Fields
	private string _culture; // 0x10
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x18

	// Properties
	public string CultureName { get; }
	public UltimateResourceFallbackLocation Location { get; }

	// Methods

	// RVA: 0x34FDCF0 Offset: 0x34FDDF1 VA: 0x34FDCF0
	public void .ctor(string cultureName) { }

	// RVA: 0x34FDD80 Offset: 0x34FDE81 VA: 0x34FDD80
	public string get_CultureName() { }

	// RVA: 0x34FDD90 Offset: 0x34FDE91 VA: 0x34FDD90
	public UltimateResourceFallbackLocation get_Location() { }
}

