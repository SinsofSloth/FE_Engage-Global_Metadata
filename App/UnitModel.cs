// Namespace: App
[ExecuteInEditMode] // RVA: 0x274DB0 Offset: 0x274EB1 VA: 0x274DB0
public abstract class UnitModel : MonoBehaviour, IGameColorValidate // TypeDefIndex: 8985
{
	// Fields
	private Unit m_Unit; // 0x18
	private GodUnit m_GodUnit; // 0x20
	private UnitModel.ResourceHandle m_HandleA; // 0x28
	private UnitModel.ResourceHandle m_HandleB; // 0x30
	private UnitModel.ResourceHandle m_Handle; // 0x38
	private List<Material> m_Materials; // 0x40
	private List<Renderer> m_Renderers; // 0x48
	public Color m_HairColor; // 0x50
	public Color m_SkinColor; // 0x60
	public Color m_MaskColor100; // 0x70
	public Color m_MaskColor075; // 0x80
	public Color m_MaskColor050; // 0x90
	public Color m_MaskColor025; // 0xA0
	private GameObject m_Root; // 0xB0
	private Vector3 m_RootScale; // 0xB8
	private Vector3 m_WingScale; // 0xC4
	private UnitModel.LoadMode m_LoadMode; // 0xD0
	private CharacterJoint m_Joint; // 0xD8
	private ProportionParameters m_ProportionParameters; // 0xE0
	private GameObject m_LeftHandObject; // 0xE8
	private GameObject m_RightHandObject; // 0xF0
	private SkinQuality m_SkinQuality; // 0xF8
	private SkinnedMeshRenderer[] m_SkinnedMeshRenderers; // 0x100
	private Animator[] m_Animators; // 0x108
	private UnitAnim.Types m_PlayAnim; // 0x110
	private UnitAnim.Types m_IdleAnim; // 0x114
	private UnitAnim.Times m_PlayTime; // 0x118
	private ItemData m_EquipItem; // 0x120
	private ItemData m_ForceItem; // 0x128
	private int m_ModelHash; // 0x130
	private int m_EquipHash; // 0x134
	private float m_Speed; // 0x138
	private float m_Alpha; // 0x13C
	private float m_MapAlpha; // 0x140
	private bool m_IsVisible; // 0x144
	private UnitModel.ColorFlags m_ColorFlags; // 0x148
	private UnitModel.DirtyFlags m_DirtyFlags; // 0x14C
	private InterpolatorFloat m_InterpolatorShine; // 0x150
	private InterpolatorFloat m_InterpolatorFader; // 0x158
	private InterpolatorFloat m_InterpolatorGoder; // 0x160
	private GameObject m_Head; // 0x168
	private GameObject m_Body; // 0x170
	private GameObject m_Ride; // 0x178
	private Transform m_WingL; // 0x180
	private Transform m_WingR; // 0x188
	private Transform m_Trans; // 0x190
	private AssetTable.Sound m_Sound; // 0x198

	// Properties
	public int ModelHash { get; }
	public int EquipHash { get; }
	public ProportionParameters ProportionParameters { get; }
	public AssetTable.Sound Sound { get; }
	public bool IsVisible { get; }
	public GameObject Head { get; }
	public GameObject Body { get; }
	public GameObject Ride { get; }

	// Methods

	// RVA: 0x24442B0 Offset: 0x24443B1 VA: 0x24442B0
	public int get_ModelHash() { }

	// RVA: 0x24442C0 Offset: 0x24443C1 VA: 0x24442C0
	public int get_EquipHash() { }

	// RVA: 0x24442D0 Offset: 0x24443D1 VA: 0x24442D0
	public ProportionParameters get_ProportionParameters() { }

	// RVA: 0x24442E0 Offset: 0x24443E1 VA: 0x24442E0
	public static UnitModel Create(string name, Unit unit, GodUnit godUnit, GameObject parent) { }

	// RVA: 0x2444550 Offset: 0x2444651 VA: 0x2444550
	public AssetTable.Sound get_Sound() { }

	// RVA: 0x2444570 Offset: 0x2444671 VA: 0x2444570
	public bool get_IsVisible() { }

	// RVA: 0x2444580 Offset: 0x2444681 VA: 0x2444580
	public GameObject get_Head() { }

	// RVA: 0x2444590 Offset: 0x2444691 VA: 0x2444590
	public GameObject get_Body() { }

	// RVA: 0x24445A0 Offset: 0x24446A1 VA: 0x24445A0
	public GameObject get_Ride() { }

	// RVA: 0x24445B0 Offset: 0x24446B1 VA: 0x24445B0
	public GameObject FindObject(string name) { }

	// RVA: 0x2444640 Offset: 0x2444741 VA: 0x2444640
	public float GetAlpha() { }

	// RVA: 0x24444C0 Offset: 0x24445C1 VA: 0x24444C0
	public void Initialize(Unit unit, GodUnit godUnit) { }

	// RVA: 0x2444650 Offset: 0x2444751 VA: 0x2444650
	public void BrightOn() { }

	// RVA: 0x24446A0 Offset: 0x24447A1 VA: 0x24446A0
	public void BrightOff() { }

	// RVA: 0x24446F0 Offset: 0x24447F1 VA: 0x24446F0
	public void Shine(float time) { }

	// RVA: 0x2444740 Offset: 0x2444841 VA: 0x2444740
	public void FadeIn(float time) { }

	// RVA: 0x2444780 Offset: 0x2444881 VA: 0x2444780
	public void FadeOut(float time) { }

	// RVA: 0x24447C0 Offset: 0x24448C1 VA: 0x24447C0
	private void GodChange(float time, float alpha, string name) { }

	// RVA: 0x24448D0 Offset: 0x24449D1 VA: 0x24448D0
	public void GodIn(float time) { }

	// RVA: 0x2444940 Offset: 0x2444A41 VA: 0x2444940
	public void GodOut(float time) { }

	// RVA: 0x24449B0 Offset: 0x2444AB1 VA: 0x24449B0
	private void SetMaterialFloat(string name, float value) { }

	// RVA: 0x2444B20 Offset: 0x2444C21 VA: 0x2444B20
	private void SetMaterialColor(string name, Color color) { }

	// RVA: 0x2444CB0 Offset: 0x2444DB1 VA: 0x2444CB0
	private void SetMaterialColor(string material, string name, Color color) { }

	// RVA: 0x2444E70 Offset: 0x2444F71 VA: 0x2444E70
	private void SetMaterialAlpha(float alpha) { }

	// RVA: 0x2444F60 Offset: 0x2445061 VA: 0x2444F60
	private void CommitModel() { }

	// RVA: 0x2445D60 Offset: 0x2445E61 VA: 0x2445D60
	private void CommitRenader() { }

	// RVA: 0x24467E0 Offset: 0x24468E1 VA: 0x24467E0
	private static string GetRelativePath(Transform root, Transform transform) { }

	// RVA: 0x2445820 Offset: 0x2445921 VA: 0x2445820
	private void CommitAccSkin(Transform root, GameObject acc) { }

	// RVA: 0x2445C90 Offset: 0x2445D91 VA: 0x2445C90
	private void SetAnimatorController(GameObject go, RuntimeAnimatorController controller) { }

	// RVA: 0x2446950 Offset: 0x2446A51 VA: 0x2446950
	public Animator GetAnimator(GameObject go) { }

	// RVA: 0x2446AB0 Offset: 0x2446BB1 VA: 0x2446AB0
	public RuntimeAnimatorController GetAnimatorController(GameObject go) { }

	// RVA: 0x2446B50 Offset: 0x2446C51 VA: 0x2446B50
	private static string GetFolderName(string name) { }

	// RVA: 0x2446D10 Offset: 0x2446E11 VA: 0x2446D10
	private static string GetAssetPath(string root, string name, string[] subs) { }

	// RVA: 0x2446EE0 Offset: 0x2446FE1 VA: 0x2446EE0
	private static string GetFooter(string name) { }

	// RVA: 0x2446F60 Offset: 0x2447061 VA: 0x2446F60
	private static string HeadFolder(string name) { }

	// RVA: 0x24470B0 Offset: 0x24471B1 VA: 0x24470B0
	private static string BodyFolder(string name) { }

	// RVA: 0x2447200 Offset: 0x2447301 VA: 0x2447200
	private static string AccFolder(string name) { }

	// RVA: 0x2447330 Offset: 0x2447431 VA: 0x2447330
	private void Swap() { }

	// RVA: 0x2447360 Offset: 0x2447461 VA: 0x2447360
	public bool LoadAsync(AssetTable.Result result) { }

	// RVA: 0x2447890 Offset: 0x2447991 VA: 0x2447890
	public void LoadAsync(string name) { }

	// RVA: 0x24478C0 Offset: 0x24479C1 VA: 0x24478C0
	private bool TryDestroy(ref GameObject go) { }

	// RVA: 0x2447AB0 Offset: 0x2447BB1 VA: 0x2447AB0
	public void .ctor() { }

	// RVA: 0x2447D50 Offset: 0x2447E51 VA: 0x2447D50
	private void OnDestroy() { }

	// RVA: 0x2447520 Offset: 0x2447621 VA: 0x2447520
	public void Unload() { }

	// RVA: 0x2447D90 Offset: 0x2447E91 VA: 0x2447D90
	public bool IsLoading() { }

	// RVA: 0x2447DB0 Offset: 0x2447EB1 VA: 0x2447DB0
	public void UpdateLoading() { }

	// RVA: 0x2447E00 Offset: 0x2447F01 VA: 0x2447E00
	private void UpdateVisible() { }

	// RVA: 0x2446670 Offset: 0x2446771 VA: 0x2446670
	private void UpdateVisible(bool visible) { }

	// RVA: 0x2447EC0 Offset: 0x2447FC1 VA: 0x2447EC0
	private void TickColor() { }

	// RVA: 0x2448340 Offset: 0x2448441 VA: 0x2448340
	private static float GetMapAlpha() { }

	// RVA: 0x24483A0 Offset: 0x24484A1 VA: 0x24483A0
	private void UpdateColor() { }

	// RVA: 0x24461B0 Offset: 0x24462B1 VA: 0x24461B0
	private void CommitColor(UnitModel.ColorFlags flags) { }

	// RVA: 0x24485D0 Offset: 0x24486D1 VA: 0x24485D0
	private void UpdateDirty() { }

	// RVA: 0x2448610 Offset: 0x2448711 VA: 0x2448610
	private void UpdateWeight() { }

	// RVA: 0x24487A0 Offset: 0x24488A1 VA: 0x24487A0
	public void PreTick() { }

	// RVA: 0x2448C50 Offset: 0x2448D51 VA: 0x2448C50
	public void PostTick() { }

	// RVA: 0x2448C70 Offset: 0x2448D71 VA: 0x2448C70
	public UnitAnim.Types GetAnim() { }

	// RVA: 0x2448C80 Offset: 0x2448D81 VA: 0x2448C80
	public UnitAnim.Types GetIdleAnim() { }

	// RVA: 0x2448C90 Offset: 0x2448D91 VA: 0x2448C90
	public void SetIdleAnim(UnitAnim.Types type, UnitAnim.Times time = 2) { }

	// RVA: 0x2448E60 Offset: 0x2448F61 VA: 0x2448E60
	public void SetIdleAnim(UnitSequence.Action action, UnitAnim.Times time = 2) { }

	// RVA: 0x2448DB0 Offset: 0x2448EB1 VA: 0x2448DB0
	public void PlayIdle(UnitAnim.Times time = 2) { }

	// RVA: 0x2448E70 Offset: 0x2448F71 VA: 0x2448E70
	public void PlayAnim(UnitAnim.Types type, UnitAnim.Times time = 2) { }

	// RVA: 0x2448F20 Offset: 0x2449021 VA: 0x2448F20
	private GameObject Instantiate(GameObject go, string name) { }

	// RVA: 0x24490B0 Offset: 0x24491B1 VA: 0x24490B0
	private void InstantiateLeftWeapon(GameObject go) { }

	// RVA: 0x2449150 Offset: 0x2449251 VA: 0x2449150
	private void InstantiateRightWeapon(GameObject go) { }

	// RVA: 0x24491F0 Offset: 0x24492F1 VA: 0x24491F0
	private static ItemData.Kinds GetItemKind(ItemData item) { }

	// RVA: 0x2449200 Offset: 0x2449301 VA: 0x2449200
	private void UpdateWeapon(ItemData equipItem) { }

	// RVA: 0x2449770 Offset: 0x2449871 VA: 0x2449770
	public Animator GetAnimator() { }

	// RVA: 0x2448970 Offset: 0x2448A71 VA: 0x2448970
	private void UpdateAnim() { }

	// RVA: 0x24497B0 Offset: 0x24498B1 VA: 0x24497B0
	public void SetForceItem(ItemData item) { }

	// RVA: 0x2448BA0 Offset: 0x2448CA1 VA: 0x2448BA0
	private void UpdateSpeed() { }

	// RVA: 0x24497C0 Offset: 0x24498C1 VA: 0x24497C0
	public void SetSpeed(float speed) { }

	// RVA: 0x24497E0 Offset: 0x24498E1 VA: 0x24497E0
	public float GetSpeed() { }

	// RVA: 0x2445F90 Offset: 0x2446091 VA: 0x2445F90
	private void CommitProportion() { }

	// RVA: 0x24497F0 Offset: 0x24498F1 VA: 0x24497F0
	public Animator[] GetAnimators() { }

	// RVA: 0x2449800 Offset: 0x2449901 VA: 0x2449800 Slot: 4
	public void OnGameColorValidate() { }

	// RVA: 0x2449810 Offset: 0x2449911 VA: 0x2449810
	public Vector3 GetEffectPosition() { }
}

