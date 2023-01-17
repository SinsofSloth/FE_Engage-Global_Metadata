// Namespace: RootMotion.FinalIK
[AddComponentMenu] // RVA: 0x27A1F0 Offset: 0x27A2F1 VA: 0x27A1F0
[HelpURLAttribute] // RVA: 0x27A1F0 Offset: 0x27A2F1 VA: 0x27A1F0
public abstract class RotationLimitSpline : RotationLimit // TypeDefIndex: 14439
{
	// Fields
	[RangeAttribute] // RVA: 0x2A3C80 Offset: 0x2A3D81 VA: 0x2A3C80
	public float twistLimit; // 0x38
	[SerializeField] // RVA: 0x2A3CA0 Offset: 0x2A3DA1 VA: 0x2A3CA0
	[HideInInspector] // RVA: 0x2A3CA0 Offset: 0x2A3DA1 VA: 0x2A3CA0
	public AnimationCurve spline; // 0x40

	// Methods

	[ContextMenu] // RVA: 0x2D07E0 Offset: 0x2D08E1 VA: 0x2D07E0
	// RVA: 0x205DFF0 Offset: 0x205E0F1 VA: 0x205DFF0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2D0820 Offset: 0x2D0921 VA: 0x2D0820
	// RVA: 0x205E040 Offset: 0x205E141 VA: 0x205E040
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2D0860 Offset: 0x2D0961 VA: 0x2D0860
	// RVA: 0x205E090 Offset: 0x205E191 VA: 0x205E090
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2D08A0 Offset: 0x2D09A1 VA: 0x2D08A0
	// RVA: 0x205E0E0 Offset: 0x205E1E1 VA: 0x205E0E0
	private void ASThread() { }

	// RVA: 0x205E130 Offset: 0x205E231 VA: 0x205E130
	public void SetSpline(Keyframe[] keyframes) { }

	// RVA: 0x205E140 Offset: 0x205E241 VA: 0x205E140 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x205E190 Offset: 0x205E291 VA: 0x205E190
	public Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x205DFB0 Offset: 0x205E0B1 VA: 0x205DFB0
	protected void .ctor() { }
}

