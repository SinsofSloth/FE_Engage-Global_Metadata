// Namespace: RootMotion.FinalIK
[Serializable]
public class InteractionLookAt // TypeDefIndex: 14406
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A27B0 Offset: 0x2A28B1 VA: 0x2A27B0
	public LookAtIK ik; // 0x10
	[TooltipAttribute] // RVA: 0x2A27F0 Offset: 0x2A28F1 VA: 0x2A27F0
	public float lerpSpeed; // 0x18
	[TooltipAttribute] // RVA: 0x2A2830 Offset: 0x2A2931 VA: 0x2A2830
	public float weightSpeed; // 0x1C
	[HideInInspector] // RVA: 0x2A2870 Offset: 0x2A2971 VA: 0x2A2870
	public bool isPaused; // 0x20
	private Transform lookAtTarget; // 0x28
	private float stopLookTime; // 0x30
	private float weight; // 0x34
	private bool firstFBBIKSolve; // 0x38

	// Methods

	// RVA: 0x2C52050 Offset: 0x2C52151 VA: 0x2C52050
	public void Look(Transform target, float time) { }

	// RVA: 0x2C52160 Offset: 0x2C52261 VA: 0x2C52160
	public void OnFixTransforms() { }

	// RVA: 0x2C52210 Offset: 0x2C52311 VA: 0x2C52210
	public void Update() { }

	// RVA: 0x2C52410 Offset: 0x2C52511 VA: 0x2C52410
	public void SolveSpine() { }

	// RVA: 0x2C524E0 Offset: 0x2C525E1 VA: 0x2C524E0
	public void SolveHead() { }

	// RVA: 0x2C525A0 Offset: 0x2C526A1 VA: 0x2C525A0
	public void .ctor() { }
}

