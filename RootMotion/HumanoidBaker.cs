// Namespace: RootMotion
public class HumanoidBaker : Baker // TypeDefIndex: 14289
{
	// Fields
	[TooltipAttribute] // RVA: 0x29E910 Offset: 0x29EA11 VA: 0x29E910
	public bool bakeHandIK; // 0x74
	[RangeAttribute] // RVA: 0x29E950 Offset: 0x29EA51 VA: 0x29E950
	[TooltipAttribute] // RVA: 0x29E950 Offset: 0x29EA51 VA: 0x29E950
	public float IKKeyReductionError; // 0x78
	[TooltipAttribute] // RVA: 0x29E9B0 Offset: 0x29EAB1 VA: 0x29E9B0
	[RangeAttribute] // RVA: 0x29E9B0 Offset: 0x29EAB1 VA: 0x29E9B0
	public int muscleFrameRateDiv; // 0x7C
	private BakerMuscle[] bakerMuscles; // 0x80
	private BakerHumanoidQT rootQT; // 0x88
	private BakerHumanoidQT leftFootQT; // 0x90
	private BakerHumanoidQT rightFootQT; // 0x98
	private BakerHumanoidQT leftHandQT; // 0xA0
	private BakerHumanoidQT rightHandQT; // 0xA8
	private float[] muscles; // 0xB0
	private HumanPose pose; // 0xB8
	private HumanPoseHandler handler; // 0xE0
	private Vector3 bodyPosition; // 0xE8
	private Quaternion bodyRotation; // 0xF4
	private int mN; // 0x104
	private Quaternion lastBodyRotation; // 0x108

	// Methods

	// RVA: 0x2D61D80 Offset: 0x2D61E81 VA: 0x2D61D80
	private void Awake() { }

	// RVA: 0x2D62240 Offset: 0x2D62341 VA: 0x2D62240 Slot: 4
	protected override Transform GetCharacterRoot() { }

	// RVA: 0x2D62250 Offset: 0x2D62351 VA: 0x2D62250 Slot: 5
	protected override void OnStartBaking() { }

	// RVA: 0x2D62320 Offset: 0x2D62421 VA: 0x2D62320 Slot: 6
	protected override void OnSetLoopFrame(float time) { }

	// RVA: 0x2D623F0 Offset: 0x2D624F1 VA: 0x2D623F0 Slot: 7
	protected override void OnSetCurves(ref AnimationClip clip) { }

	// RVA: 0x2D625A0 Offset: 0x2D626A1 VA: 0x2D625A0 Slot: 8
	protected override void OnSetKeyframes(float time, bool lastFrame) { }

	// RVA: 0x2D62870 Offset: 0x2D62971 VA: 0x2D62870
	private void UpdateHumanPose() { }

	// RVA: 0x2D62960 Offset: 0x2D62A61 VA: 0x2D62960
	public void .ctor() { }
}

