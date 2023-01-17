// Namespace: App
[DisplayNameAttribute] // RVA: 0x276E90 Offset: 0x276F91 VA: 0x276E90
[Serializable]
public abstract class FadeMarker : Marker, INotification // TypeDefIndex: 10554
{
	// Fields
	public bool isFadeOut; // 0x28
	public FadeType FadeSpeedType; // 0x2C

	// Properties
	public PropertyName id { get; }

	// Methods

	// RVA: 0x2A1A370 Offset: 0x2A1A471 VA: 0x2A1A370 Slot: 9
	public PropertyName get_id() { }

	// RVA: 0x2A1A3D0 Offset: 0x2A1A4D1 VA: 0x2A1A3D0
	protected void .ctor() { }
}

