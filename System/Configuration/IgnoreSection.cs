// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 1522
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1C6D730 Offset: 0x1C6D831 VA: 0x1C6D730
	public void .ctor() { }

	// RVA: 0x1C6D770 Offset: 0x1C6D871 VA: 0x1C6D770 Slot: 4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1C6D7B0 Offset: 0x1C6D8B1 VA: 0x1C6D7B0 Slot: 8
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x1C6D7F0 Offset: 0x1C6D8F1 VA: 0x1C6D7F0 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x1C6D830 Offset: 0x1C6D931 VA: 0x1C6D830 Slot: 6
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x1C6D870 Offset: 0x1C6D971 VA: 0x1C6D870 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x1C6D8B0 Offset: 0x1C6D9B1 VA: 0x1C6D8B0 Slot: 9
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }
}

