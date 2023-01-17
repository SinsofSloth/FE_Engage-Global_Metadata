// Namespace: RootMotion.FinalIK
[Serializable]
public class TwistSolver // TypeDefIndex: 14404
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A25A0 Offset: 0x2A26A1 VA: 0x2A25A0
	public Transform transform; // 0x10
	[TooltipAttribute] // RVA: 0x2A25E0 Offset: 0x2A26E1 VA: 0x2A25E0
	public Transform parent; // 0x18
	[TooltipAttribute] // RVA: 0x2A2620 Offset: 0x2A2721 VA: 0x2A2620
	public Transform[] children; // 0x20
	[RangeAttribute] // RVA: 0x2A2660 Offset: 0x2A2761 VA: 0x2A2660
	[TooltipAttribute] // RVA: 0x2A2660 Offset: 0x2A2761 VA: 0x2A2660
	public float weight; // 0x28
	[TooltipAttribute] // RVA: 0x2A26C0 Offset: 0x2A27C1 VA: 0x2A26C0
	[RangeAttribute] // RVA: 0x2A26C0 Offset: 0x2A27C1 VA: 0x2A26C0
	public float parentChildCrossfade; // 0x2C
	[RangeAttribute] // RVA: 0x2A2720 Offset: 0x2A2821 VA: 0x2A2720
	[TooltipAttribute] // RVA: 0x2A2720 Offset: 0x2A2821 VA: 0x2A2720
	public float twistAngleOffset; // 0x30
	private Vector3 twistAxis; // 0x34
	private Vector3 axis; // 0x40
	private Vector3 axisRelativeToParentDefault; // 0x4C
	private Vector3 axisRelativeToChildDefault; // 0x58
	private Quaternion[] childRotations; // 0x68
	private bool inititated; // 0x70

	// Methods

	// RVA: 0x2887C20 Offset: 0x2887D21 VA: 0x2887C20
	public void .ctor() { }

	// RVA: 0x2887140 Offset: 0x2887241 VA: 0x2887140
	public void Initiate() { }

	// RVA: 0x2887600 Offset: 0x2887701 VA: 0x2887600
	public void Relax() { }
}

