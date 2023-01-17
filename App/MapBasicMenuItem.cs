// Namespace: App
public abstract class MapBasicMenuItem : BasicMenuItem // TypeDefIndex: 12250
{
	// Properties
	protected abstract string FlagID { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract string get_FlagID();

	// RVA: 0x231BA40 Offset: 0x231BB41 VA: 0x231BA40 Slot: 28
	public virtual string GetHelpText() { }

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract BasicMenuItem.Attribute GetMapAttribute();

	// RVA: 0x231BA90 Offset: 0x231BB91 VA: 0x231BA90 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x231BC30 Offset: 0x231BD31 VA: 0x231BC30 Slot: 6
	public override float GetHeight() { }

	// RVA: 0x231BD80 Offset: 0x231BE81 VA: 0x231BD80
	protected void .ctor() { }
}

