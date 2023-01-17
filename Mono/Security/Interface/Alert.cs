// Namespace: Mono.Security.Interface
public class Alert // TypeDefIndex: 1553
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x1BC3570 Offset: 0x1BC3671 VA: 0x1BC3570
	public AlertLevel get_Level() { }

	// RVA: 0x1BC3580 Offset: 0x1BC3681 VA: 0x1BC3580
	public AlertDescription get_Description() { }

	// RVA: 0x1BC3590 Offset: 0x1BC3691 VA: 0x1BC3590
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1BC3610 Offset: 0x1BC3711 VA: 0x1BC3610
	private void inferAlertLevel() { }

	// RVA: 0x1BC3660 Offset: 0x1BC3761 VA: 0x1BC3660 Slot: 3
	public override string ToString() { }
}

