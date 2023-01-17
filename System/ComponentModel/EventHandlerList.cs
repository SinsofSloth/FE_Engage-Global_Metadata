// Namespace: System.ComponentModel
[DefaultMemberAttribute] // RVA: 0x301A0 Offset: 0x302A1 VA: 0x301A0
public sealed class EventHandlerList // TypeDefIndex: 2313
{
	// Fields
	private EventHandlerList.ListEntry head; // 0x10
	private Component parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0x1ADB700 Offset: 0x1ADB801 VA: 0x1ADB700
	public Delegate get_Item(object key) { }

	// RVA: 0x1ADB780 Offset: 0x1ADB881 VA: 0x1ADB780
	private EventHandlerList.ListEntry Find(object key) { }
}

