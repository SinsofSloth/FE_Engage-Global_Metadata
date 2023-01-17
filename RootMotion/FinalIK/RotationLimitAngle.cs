// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x27A0D0 Offset: 0x27A1D1 VA: 0x27A0D0
[AddComponentMenu] // RVA: 0x27A0D0 Offset: 0x27A1D1 VA: 0x27A0D0
public class RotationLimitAngle : RotationLimit // TypeDefIndex: 14434
{
	// Fields
	[RangeAttribute] // RVA: 0x2A3B30 Offset: 0x2A3C31 VA: 0x2A3B30
	public float limit; // 0x38
	[RangeAttribute] // RVA: 0x2A3B50 Offset: 0x2A3C51 VA: 0x2A3B50
	public float twistLimit; // 0x3C

	// Methods

	[ContextMenu] // RVA: 0x2D04E0 Offset: 0x2D05E1 VA: 0x2D04E0
	// RVA: 0x205C150 Offset: 0x205C251 VA: 0x205C150
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2D0520 Offset: 0x2D0621 VA: 0x2D0520
	// RVA: 0x205C1A0 Offset: 0x205C2A1 VA: 0x205C1A0
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2D0560 Offset: 0x2D0661 VA: 0x2D0560
	// RVA: 0x205C1F0 Offset: 0x205C2F1 VA: 0x205C1F0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2D05A0 Offset: 0x2D06A1 VA: 0x2D05A0
	// RVA: 0x205C240 Offset: 0x205C341 VA: 0x205C240
	private void ASThread() { }

	// RVA: 0x205C290 Offset: 0x205C391 VA: 0x205C290 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x205C2E0 Offset: 0x205C3E1 VA: 0x205C2E0
	private Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x205C490 Offset: 0x205C591 VA: 0x205C490
	public void .ctor() { }
}

