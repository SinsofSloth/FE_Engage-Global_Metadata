// Namespace: 
public class Iron19CharacterFader : MonoBehaviour // TypeDefIndex: 7789
{
	// Fields
	private bool m_isInitialized; // 0x18
	private float m_FadeAlpha; // 0x1C
	private float m_CameraAlpha; // 0x20
	private float m_MergeAlpha; // 0x24
	private float m_CameraOutline; // 0x28
	private float m_MergeOutline; // 0x2C
	private int m_TargetLayer; // 0x30
	private SkinQuality m_SkinQuality; // 0x34
	private SkinQuality m_PreSkinQuality; // 0x38
	[RangeAttribute] // RVA: 0x27D1B0 Offset: 0x27D2B1 VA: 0x27D1B0
	[TooltipAttribute] // RVA: 0x27D1B0 Offset: 0x27D2B1 VA: 0x27D1B0
	public float m_Radius; // 0x3C
	[TooltipAttribute] // RVA: 0x27D210 Offset: 0x27D311 VA: 0x27D210
	[RangeAttribute] // RVA: 0x27D210 Offset: 0x27D311 VA: 0x27D210
	public float m_Distance; // 0x40
	[TooltipAttribute] // RVA: 0x27D270 Offset: 0x27D371 VA: 0x27D270
	[RangeAttribute] // RVA: 0x27D270 Offset: 0x27D371 VA: 0x27D270
	public float m_Outline; // 0x44
	[RangeAttribute] // RVA: 0x27D2D0 Offset: 0x27D3D1 VA: 0x27D2D0
	public float m_EditAlpha; // 0x48
	[RangeAttribute] // RVA: 0x27D2F0 Offset: 0x27D3F1 VA: 0x27D2F0
	public float m_EditOutline; // 0x4C
	[TooltipAttribute] // RVA: 0x27D310 Offset: 0x27D411 VA: 0x27D310
	public bool m_SpringControl; // 0x50
	[TooltipAttribute] // RVA: 0x27D350 Offset: 0x27D451 VA: 0x27D350
	public bool m_SolverControl; // 0x51
	[TooltipAttribute] // RVA: 0x27D390 Offset: 0x27D491 VA: 0x27D390
	public bool m_ProportionControl; // 0x52
	[TooltipAttribute] // RVA: 0x27D3D0 Offset: 0x27D4D1 VA: 0x27D3D0
	public bool m_MouthControl; // 0x53
	private bool m_AnimatorControl; // 0x54
	private List<Renderer> m_Renderers; // 0x58
	private List<Material> m_Materials; // 0x60
	private List<Material> m_Particles; // 0x68
	private List<Animator> m_Animators; // 0x70
	private List<SkinnedMeshRenderer> m_SkinnedMeshRenderers; // 0x78
	private List<ISpringManager> m_SpringManagers; // 0x80
	private List<SolverManager> m_SolverManagers; // 0x88
	private List<CharacterProportion> m_Proportions; // 0x90
	private List<EventCharacterMouthController> m_MouthControllers; // 0x98
	private List<SkinQualityLodAdjuster> m_SkinQualityLodAdjusters; // 0xA0
	private Character m_Character; // 0xA8
	private int m_OutlineMaterialDisableProp; // 0xB0

	// Methods

	// RVA: 0x2B60800 Offset: 0x2B60901 VA: 0x2B60800
	private void Start() { }

	// RVA: 0x2B60A70 Offset: 0x2B60B71 VA: 0x2B60A70
	private void TryInitialize() { }

	// RVA: 0x2B61140 Offset: 0x2B61241 VA: 0x2B61140
	private void TryRelease() { }

	// RVA: 0x2B61500 Offset: 0x2B61601 VA: 0x2B61500
	public void SetFadeAlpha(float alpha) { }

	// RVA: 0x2B61510 Offset: 0x2B61611 VA: 0x2B61510
	public float GetAlpha() { }

	// RVA: 0x2B61520 Offset: 0x2B61621 VA: 0x2B61520
	public void SetTargetLayer(int layer) { }

	// RVA: 0x2B61530 Offset: 0x2B61631 VA: 0x2B61530
	public void DisableAnimatorControl() { }

	// RVA: 0x2B61540 Offset: 0x2B61641 VA: 0x2B61540
	private Vector3 GetPivot() { }

	// RVA: 0x2B61580 Offset: 0x2B61681 VA: 0x2B61580
	private bool IsReject(Camera camera) { }

	// RVA: 0x2B61720 Offset: 0x2B61821 VA: 0x2B61720
	private bool IsOutline(Camera camera) { }

	// RVA: 0x2B618B0 Offset: 0x2B619B1 VA: 0x2B618B0
	private bool IsSkinWeights1(Camera camera) { }

	// RVA: 0x2B61B30 Offset: 0x2B61C31 VA: 0x2B61B30
	private bool IsSkinWeights2(Camera camera) { }

	// RVA: 0x2B61DB0 Offset: 0x2B61EB1 VA: 0x2B61DB0
	private void UpdateCameraAlpha(float speed) { }

	// RVA: 0x2B61E40 Offset: 0x2B61F41 VA: 0x2B61E40
	private void UpdateCameraOutline(float speed) { }

	// RVA: 0x2B61ED0 Offset: 0x2B61FD1 VA: 0x2B61ED0
	private void UpdateCameraSkinWeights() { }

	// RVA: 0x2B61F70 Offset: 0x2B62071 VA: 0x2B61F70
	private void UpdateEnabled(bool enabled) { }

	// RVA: 0x2B62400 Offset: 0x2B62501 VA: 0x2B62400
	private void SetOutlineEnabled(bool enabled) { }

	// RVA: 0x2B625E0 Offset: 0x2B626E1 VA: 0x2B625E0
	private void SetOutlineScale(float scale) { }

	// RVA: 0x2B62760 Offset: 0x2B62861 VA: 0x2B62760
	private void SetSkinQuality(SkinQuality skinQuality) { }

	// RVA: 0x2B629B0 Offset: 0x2B62AB1 VA: 0x2B629B0
	private void OnDestroy() { }

	// RVA: 0x2B629C0 Offset: 0x2B62AC1 VA: 0x2B629C0
	private void UpdateAlpha() { }

	// RVA: 0x2B62C80 Offset: 0x2B62D81 VA: 0x2B62C80
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6E10 Offset: 0x2A6F11 VA: 0x2A6E10
	// RVA: 0x2B62FE0 Offset: 0x2B630E1 VA: 0x2B62FE0
	private void <Start>b__31_0(Unit _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6E20 Offset: 0x2A6F21 VA: 0x2A6E20
	// RVA: 0x2B62FF0 Offset: 0x2B630F1 VA: 0x2B62FF0
	private void <Start>b__31_1() { }
}

// Namespace: 
public class Iron19CharacterSuperEngage : MonoBehaviour // TypeDefIndex: 7790
{
	// Fields
	public const string EditorPrefsDisable = "Iron19CharacterSuperEngage.DisableSuperEngage";
	private bool m_bInitialized; // 0x18
	private bool m_Dirty; // 0x19
	private List<Material> m_ModifiableMaterials; // 0x20
	private List<Material> m_InstancedMaterials; // 0x28
	private bool m_isSuperEngage; // 0x30
	private const string SUPER_ENGAGE_KEYWORD = "_KEY_ENGAGE";
	private const string SUPER_ENGAGE_PROPERTY_NAME = "_Key_Engage";
	private static readonly int m_superEngagePropertyID; // 0x0

	// Methods

	// RVA: 0x2B63000 Offset: 0x2B63101 VA: 0x2B63000
	public bool IsSuperEngage() { }

	// RVA: 0x2B63010 Offset: 0x2B63111 VA: 0x2B63010
	private void Start() { }

	// RVA: 0x2B63100 Offset: 0x2B63201 VA: 0x2B63100
	public void UpdateMaterials(bool isForce = False) { }

	// RVA: 0x2B63450 Offset: 0x2B63551 VA: 0x2B63450
	private void OnDestroy() { }

	// RVA: 0x2B63640 Offset: 0x2B63741 VA: 0x2B63640
	public void SetSuperEngage(bool isSuperEngage) { }

	// RVA: 0x2B63660 Offset: 0x2B63761 VA: 0x2B63660
	private void MyUpdate() { }

	// RVA: 0x2B63670 Offset: 0x2B63771 VA: 0x2B63670
	public void UpdateShader() { }

	// RVA: 0x2B63870 Offset: 0x2B63971 VA: 0x2B63870
	public void .ctor() { }

	// RVA: 0x2B63880 Offset: 0x2B63981 VA: 0x2B63880
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6E30 Offset: 0x2A6F31 VA: 0x2A6E30
	// RVA: 0x2B63900 Offset: 0x2B63A01 VA: 0x2B63900
	private void <Start>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6E40 Offset: 0x2A6F41 VA: 0x2A6E40
	// RVA: 0x2B63910 Offset: 0x2B63A11 VA: 0x2B63910
	private void <Start>b__10_1() { }
}

// Namespace: 
[ExecuteInEditMode] // RVA: 0x2718D0 Offset: 0x2719D1 VA: 0x2718D0
public class Iron19MaterialColorChanger : MonoBehaviour // TypeDefIndex: 7791
{
	// Fields
	public GameObject Target; // 0x18
	public Color Color; // 0x20
	private int m_colorPropertyID; // 0x30
	private int m_ditherPropertyID; // 0x34
	private List<Material> m_aList; // 0x38

	// Methods

	// RVA: 0x2B63920 Offset: 0x2B63A21 VA: 0x2B63920
	private void Start() { }

	// RVA: 0x2B63930 Offset: 0x2B63A31 VA: 0x2B63930
	private void Refresh() { }

	// RVA: 0x2B63B30 Offset: 0x2B63C31 VA: 0x2B63B30
	private void Update() { }

	// RVA: 0x2B63D10 Offset: 0x2B63E11 VA: 0x2B63D10
	public void OnGUI() { }

	// RVA: 0x2B63E60 Offset: 0x2B63F61 VA: 0x2B63E60
	public void .ctor() { }
}

