// Namespace: App
[DisplayNameAttribute] // RVA: 0x276DC0 Offset: 0x276EC1 VA: 0x276DC0
[Serializable]
public abstract class EventMarker : Marker, INotification // TypeDefIndex: 10551
{
	// Fields
	public bool EventMode; // 0x28
	public bool IsIgnoreMarker; // 0x29

	// Properties
	public PropertyName id { get; }

	// Methods

	// RVA: 0x27FA4B0 Offset: 0x27FA5B1 VA: 0x27FA4B0 Slot: 9
	public PropertyName get_id() { }

	// RVA: 0x27FA510 Offset: 0x27FA611 VA: 0x27FA510
	protected void .ctor() { }
}

