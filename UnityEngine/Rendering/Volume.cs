// Namespace: UnityEngine.Rendering
[AddComponentMenu] // RVA: 0x3BAC0 Offset: 0x3BBC1 VA: 0x3BAC0
[HelpURLAttribute] // RVA: 0x3BAC0 Offset: 0x3BBC1 VA: 0x3BAC0
[ExecuteAlways] // RVA: 0x3BAC0 Offset: 0x3BBC1 VA: 0x3BAC0
public class Volume : MonoBehaviour // TypeDefIndex: 4641
{
	// Fields
	[TooltipAttribute] // RVA: 0x3CDD0 Offset: 0x3CED1 VA: 0x3CDD0
	public bool isGlobal; // 0x18
	[TooltipAttribute] // RVA: 0x3CE10 Offset: 0x3CF11 VA: 0x3CE10
	public float priority; // 0x1C
	[TooltipAttribute] // RVA: 0x3CE50 Offset: 0x3CF51 VA: 0x3CE50
	public float blendDistance; // 0x20
	[RangeAttribute] // RVA: 0x3CE90 Offset: 0x3CF91 VA: 0x3CE90
	[TooltipAttribute] // RVA: 0x3CE90 Offset: 0x3CF91 VA: 0x3CE90
	public float weight; // 0x24
	public VolumeProfile sharedProfile; // 0x28
	private int m_PreviousLayer; // 0x30
	private float m_PreviousPriority; // 0x34
	private VolumeProfile m_InternalProfile; // 0x38

	// Properties
	public VolumeProfile profile { get; set; }
	internal VolumeProfile profileRef { get; }

	// Methods

	// RVA: 0x3549E40 Offset: 0x3549F41 VA: 0x3549E40
	public VolumeProfile get_profile() { }

	// RVA: 0x354A060 Offset: 0x354A161 VA: 0x354A060
	public void set_profile(VolumeProfile value) { }

	// RVA: 0x354A070 Offset: 0x354A171 VA: 0x354A070
	internal VolumeProfile get_profileRef() { }

	// RVA: 0x354A100 Offset: 0x354A201 VA: 0x354A100
	public bool HasInstantiatedProfile() { }

	// RVA: 0x354A180 Offset: 0x354A281 VA: 0x354A180
	private void OnEnable() { }

	// RVA: 0x354A4C0 Offset: 0x354A5C1 VA: 0x354A4C0
	private void OnDisable() { }

	// RVA: 0x354A740 Offset: 0x354A841 VA: 0x354A740
	private void Update() { }

	// RVA: 0x354A860 Offset: 0x354A961 VA: 0x354A860
	internal void UpdateLayer() { }

	// RVA: 0x354AB10 Offset: 0x354AC11 VA: 0x354AB10
	public void .ctor() { }
}

