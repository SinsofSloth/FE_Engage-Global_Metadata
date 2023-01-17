// Namespace: RootMotion.FinalIK
public class BodyTilt : OffsetModifier // TypeDefIndex: 14447
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4460 Offset: 0x2A4561 VA: 0x2A4460
	public float tiltSpeed; // 0x2C
	[TooltipAttribute] // RVA: 0x2A44A0 Offset: 0x2A45A1 VA: 0x2A44A0
	public float tiltSensitivity; // 0x30
	[TooltipAttribute] // RVA: 0x2A44E0 Offset: 0x2A45E1 VA: 0x2A44E0
	public OffsetPose poseLeft; // 0x38
	[TooltipAttribute] // RVA: 0x2A4520 Offset: 0x2A4621 VA: 0x2A4520
	public OffsetPose poseRight; // 0x40
	private float tiltAngle; // 0x48
	private Vector3 lastForward; // 0x4C

	// Methods

	// RVA: 0x2C78E40 Offset: 0x2C78F41 VA: 0x2C78E40 Slot: 5
	protected override void Start() { }

	// RVA: 0x2C78E90 Offset: 0x2C78F91 VA: 0x2C78E90 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x2C79030 Offset: 0x2C79131 VA: 0x2C79030
	public void .ctor() { }
}

