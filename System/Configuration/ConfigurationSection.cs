// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1515
{
	// Methods

	// RVA: 0x1C6D630 Offset: 0x1C6D731 VA: 0x1C6D630 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x1C6D670 Offset: 0x1C6D771 VA: 0x1C6D670 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x1C6D6B0 Offset: 0x1C6D7B1 VA: 0x1C6D6B0 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x1C6D6F0 Offset: 0x1C6D7F1 VA: 0x1C6D6F0 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}

