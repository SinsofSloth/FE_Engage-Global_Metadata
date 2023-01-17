// Namespace: TMPro
public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 7468
{
	// Fields
	public int value__; // 0x0
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;
}

// Namespace: TMPro
public class Compute_DT_EventArgs // TypeDefIndex: 7470
{
	// Fields
	public Compute_DistanceTransform_EventTypes EventType; // 0x10
	public float ProgressPercentage; // 0x14
	public Color[] Colors; // 0x18

	// Methods

	// RVA: 0x192CF20 Offset: 0x192D021 VA: 0x192CF20
	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	// RVA: 0x192CF60 Offset: 0x192D061 VA: 0x192CF60
	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }
}

