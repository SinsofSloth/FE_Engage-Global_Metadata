// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x27A130 Offset: 0x27A231 VA: 0x27A130
[AddComponentMenu] // RVA: 0x27A130 Offset: 0x27A231 VA: 0x27A130
public class RotationLimitHinge : RotationLimit // TypeDefIndex: 14435
{
	// Fields
	public bool useLimits; // 0x38
	public float min; // 0x3C
	public float max; // 0x40
	[HideInInspector] // RVA: 0x2A3B70 Offset: 0x2A3C71 VA: 0x2A3B70
	public float zeroAxisDisplayOffset; // 0x44
	private float lastAngle; // 0x48

	// Methods

	[ContextMenu] // RVA: 0x2D05E0 Offset: 0x2D06E1 VA: 0x2D05E0
	// RVA: 0x205C4E0 Offset: 0x205C5E1 VA: 0x205C4E0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2D0620 Offset: 0x2D0721 VA: 0x2D0620
	// RVA: 0x205C530 Offset: 0x205C631 VA: 0x205C530
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2D0660 Offset: 0x2D0761 VA: 0x2D0660
	// RVA: 0x205C580 Offset: 0x205C681 VA: 0x205C580
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2D06A0 Offset: 0x2D07A1 VA: 0x2D06A0
	// RVA: 0x205C5D0 Offset: 0x205C6D1 VA: 0x205C5D0
	private void ASThread() { }

	// RVA: 0x205C620 Offset: 0x205C721 VA: 0x205C620 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x205C630 Offset: 0x205C731 VA: 0x205C630
	private Quaternion LimitHinge(Quaternion rotation) { }

	// RVA: 0x205C810 Offset: 0x205C911 VA: 0x205C810
	public void .ctor() { }
}

