// Namespace: RootMotion.FinalIK
[ExecuteInEditMode] // RVA: 0x27A260 Offset: 0x27A361 VA: 0x27A260
public class EditorIK : MonoBehaviour // TypeDefIndex: 14449
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4580 Offset: 0x2A4681 VA: 0x2A4580
	public Animator animator; // 0x18
	[TooltipAttribute] // RVA: 0x2A45C0 Offset: 0x2A46C1 VA: 0x2A45C0
	public EditorIKPose defaultPose; // 0x20
	[HideInInspector] // RVA: 0x2A4600 Offset: 0x2A4701 VA: 0x2A4600
	public Transform[] bones; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2A4610 Offset: 0x2A4711 VA: 0x2A4610
	private IK <ik>k__BackingField; // 0x30

	// Properties
	public IK ik { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2D09A0 Offset: 0x2D0AA1 VA: 0x2D09A0
	// RVA: 0x25F06A0 Offset: 0x25F07A1 VA: 0x25F06A0
	public IK get_ik() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D09B0 Offset: 0x2D0AB1 VA: 0x2D09B0
	// RVA: 0x25F06B0 Offset: 0x25F07B1 VA: 0x25F06B0
	private void set_ik(IK value) { }

	// RVA: 0x25F06C0 Offset: 0x25F07C1 VA: 0x25F06C0
	private void OnEnable() { }

	// RVA: 0x25F0800 Offset: 0x25F0901 VA: 0x25F0800
	private void OnDisable() { }

	// RVA: 0x25F0A10 Offset: 0x25F0B11 VA: 0x25F0A10
	private void OnDestroy() { }

	// RVA: 0x25F0B50 Offset: 0x25F0C51 VA: 0x25F0B50
	public void StoreDefaultPose() { }

	// RVA: 0x25F0D30 Offset: 0x25F0E31 VA: 0x25F0D30
	public bool Initiate() { }

	// RVA: 0x25F0EE0 Offset: 0x25F0FE1 VA: 0x25F0EE0
	public void Update() { }

	// RVA: 0x25F1130 Offset: 0x25F1231 VA: 0x25F1130
	public void .ctor() { }
}

