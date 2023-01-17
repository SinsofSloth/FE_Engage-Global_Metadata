// Namespace: RootMotion.FinalIK
[AddComponentMenu] // RVA: 0x27A000 Offset: 0x27A101 VA: 0x27A000
[HelpURLAttribute] // RVA: 0x27A000 Offset: 0x27A101 VA: 0x27A000
public class InteractionTarget : MonoBehaviour // TypeDefIndex: 14419
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A3150 Offset: 0x2A3251 VA: 0x2A3150
	public FullBodyBipedEffector effectorType; // 0x18
	[TooltipAttribute] // RVA: 0x2A3190 Offset: 0x2A3291 VA: 0x2A3190
	public InteractionTarget.Multiplier[] multipliers; // 0x20
	[TooltipAttribute] // RVA: 0x2A31D0 Offset: 0x2A32D1 VA: 0x2A31D0
	public float interactionSpeedMlp; // 0x28
	[TooltipAttribute] // RVA: 0x2A3210 Offset: 0x2A3311 VA: 0x2A3210
	public Transform pivot; // 0x30
	[TooltipAttribute] // RVA: 0x2A3250 Offset: 0x2A3351 VA: 0x2A3250
	public InteractionTarget.RotationMode rotationMode; // 0x38
	[TooltipAttribute] // RVA: 0x2A3290 Offset: 0x2A3391 VA: 0x2A3290
	public Vector3 twistAxis; // 0x3C
	[TooltipAttribute] // RVA: 0x2A32D0 Offset: 0x2A33D1 VA: 0x2A32D0
	public float twistWeight; // 0x48
	[TooltipAttribute] // RVA: 0x2A3310 Offset: 0x2A3411 VA: 0x2A3310
	public float swingWeight; // 0x4C
	[TooltipAttribute] // RVA: 0x2A3350 Offset: 0x2A3451 VA: 0x2A3350
	[RangeAttribute] // RVA: 0x2A3350 Offset: 0x2A3451 VA: 0x2A3350
	public float threeDOFWeight; // 0x50
	[TooltipAttribute] // RVA: 0x2A33B0 Offset: 0x2A34B1 VA: 0x2A33B0
	public bool rotateOnce; // 0x54
	private Quaternion defaultLocalRotation; // 0x58
	private Transform lastPivot; // 0x68

	// Methods

	[ContextMenu] // RVA: 0x2D0080 Offset: 0x2D0181 VA: 0x2D0080
	// RVA: 0x2B4D1E0 Offset: 0x2B4D2E1 VA: 0x2B4D1E0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2D00C0 Offset: 0x2D01C1 VA: 0x2D00C0
	// RVA: 0x2B4D230 Offset: 0x2B4D331 VA: 0x2B4D230
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2D0100 Offset: 0x2D0201 VA: 0x2D0100
	// RVA: 0x2B4D280 Offset: 0x2B4D381 VA: 0x2B4D280
	private void OpenTutorial1() { }

	[ContextMenu] // RVA: 0x2D0140 Offset: 0x2D0241 VA: 0x2D0140
	// RVA: 0x2B4D2D0 Offset: 0x2B4D3D1 VA: 0x2B4D2D0
	private void OpenTutorial2() { }

	[ContextMenu] // RVA: 0x2D0180 Offset: 0x2D0281 VA: 0x2D0180
	// RVA: 0x2B4D320 Offset: 0x2B4D421 VA: 0x2B4D320
	private void OpenTutorial3() { }

	[ContextMenu] // RVA: 0x2D01C0 Offset: 0x2D02C1 VA: 0x2D01C0
	// RVA: 0x2B4D370 Offset: 0x2B4D471 VA: 0x2B4D370
	private void OpenTutorial4() { }

	[ContextMenu] // RVA: 0x2D0200 Offset: 0x2D0301 VA: 0x2D0200
	// RVA: 0x2B4D3C0 Offset: 0x2B4D4C1 VA: 0x2B4D3C0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2D0240 Offset: 0x2D0341 VA: 0x2D0240
	// RVA: 0x2B4D410 Offset: 0x2B4D511 VA: 0x2B4D410
	private void ASThread() { }

	// RVA: 0x2B4D460 Offset: 0x2B4D561 VA: 0x2B4D460
	public float GetValue(InteractionObject.WeightCurve.Type curveType) { }

	// RVA: 0x2B4D4D0 Offset: 0x2B4D5D1 VA: 0x2B4D4D0
	public void ResetRotation() { }

	// RVA: 0x2B4D570 Offset: 0x2B4D671 VA: 0x2B4D570
	public void RotateTo(Transform bone) { }

	// RVA: 0x2B4DA30 Offset: 0x2B4DB31 VA: 0x2B4DA30
	public void .ctor() { }
}

