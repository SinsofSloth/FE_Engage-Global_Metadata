// Namespace: RootMotion.FinalIK
public class Recoil : OffsetModifier // TypeDefIndex: 14480
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5A20 Offset: 0x2A5B21 VA: 0x2A5A20
	public AimIK aimIK; // 0x30
	[TooltipAttribute] // RVA: 0x2A5A60 Offset: 0x2A5B61 VA: 0x2A5A60
	public bool aimIKSolvedLast; // 0x38
	[TooltipAttribute] // RVA: 0x2A5AA0 Offset: 0x2A5BA1 VA: 0x2A5AA0
	public Recoil.Handedness handedness; // 0x3C
	[TooltipAttribute] // RVA: 0x2A5AE0 Offset: 0x2A5BE1 VA: 0x2A5AE0
	public bool twoHanded; // 0x40
	[TooltipAttribute] // RVA: 0x2A5B20 Offset: 0x2A5C21 VA: 0x2A5B20
	public AnimationCurve recoilWeight; // 0x48
	[TooltipAttribute] // RVA: 0x2A5B60 Offset: 0x2A5C61 VA: 0x2A5B60
	public float magnitudeRandom; // 0x50
	[TooltipAttribute] // RVA: 0x2A5BA0 Offset: 0x2A5CA1 VA: 0x2A5BA0
	public Vector3 rotationRandom; // 0x54
	[TooltipAttribute] // RVA: 0x2A5BE0 Offset: 0x2A5CE1 VA: 0x2A5BE0
	public Vector3 handRotationOffset; // 0x60
	[TooltipAttribute] // RVA: 0x2A5C20 Offset: 0x2A5D21 VA: 0x2A5C20
	public float blendTime; // 0x6C
	[SpaceAttribute] // RVA: 0x2A5C60 Offset: 0x2A5D61 VA: 0x2A5C60
	[TooltipAttribute] // RVA: 0x2A5C60 Offset: 0x2A5D61 VA: 0x2A5C60
	public Recoil.RecoilOffset[] offsets; // 0x70
	[HideInInspector] // RVA: 0x2A5CB0 Offset: 0x2A5DB1 VA: 0x2A5CB0
	public Quaternion rotationOffset; // 0x78
	private float magnitudeMlp; // 0x88
	private float endTime; // 0x8C
	private Quaternion handRotation; // 0x90
	private Quaternion secondaryHandRelativeRotation; // 0xA0
	private Quaternion randomRotation; // 0xB0
	private float length; // 0xC0
	private bool initiated; // 0xC4
	private float blendWeight; // 0xC8
	private float w; // 0xCC
	private Quaternion primaryHandRotation; // 0xD0
	private bool handRotationsSet; // 0xE0
	private Vector3 aimIKAxis; // 0xE4

	// Properties
	public bool isFinished { get; }
	private IKEffector primaryHandEffector { get; }
	private IKEffector secondaryHandEffector { get; }
	private Transform primaryHand { get; }
	private Transform secondaryHand { get; }

	// Methods

	// RVA: 0x27729A0 Offset: 0x2772AA1 VA: 0x27729A0
	public bool get_isFinished() { }

	// RVA: 0x27729D0 Offset: 0x2772AD1 VA: 0x27729D0
	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

	// RVA: 0x2772A10 Offset: 0x2772B11 VA: 0x2772A10
	public void Fire(float magnitude) { }

	// RVA: 0x2772B40 Offset: 0x2772C41 VA: 0x2772B40 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x2773520 Offset: 0x2773621 VA: 0x2773520
	private void AfterFBBIK() { }

	// RVA: 0x2773600 Offset: 0x2773701 VA: 0x2773600
	private void AfterAimIK() { }

	// RVA: 0x27734E0 Offset: 0x27735E1 VA: 0x27734E0
	private IKEffector get_primaryHandEffector() { }

	// RVA: 0x2773500 Offset: 0x2773601 VA: 0x2773500
	private IKEffector get_secondaryHandEffector() { }

	// RVA: 0x2773460 Offset: 0x2773561 VA: 0x2773460
	private Transform get_primaryHand() { }

	// RVA: 0x27734A0 Offset: 0x27735A1 VA: 0x27734A0
	private Transform get_secondaryHand() { }

	// RVA: 0x2773630 Offset: 0x2773731 VA: 0x2773630 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x2773810 Offset: 0x2773911 VA: 0x2773810
	public void .ctor() { }
}

