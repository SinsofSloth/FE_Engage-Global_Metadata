// Namespace: System.Configuration
[DefaultMemberAttribute] // RVA: 0x89F30 Offset: 0x8A031 VA: 0x89F30
public abstract class ConfigurationElement // TypeDefIndex: 1516
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1C6D530 Offset: 0x1C6D631 VA: 0x1C6D530 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1C6D570 Offset: 0x1C6D671 VA: 0x1C6D570 Slot: 5
	protected internal virtual bool IsModified() { }

	// RVA: 0x1C6D5B0 Offset: 0x1C6D6B1 VA: 0x1C6D5B0 Slot: 6
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x1C6D5F0 Offset: 0x1C6D6F1 VA: 0x1C6D5F0 Slot: 7
	protected internal virtual void ResetModified() { }
}

