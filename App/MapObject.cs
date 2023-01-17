// Namespace: App
[ExecuteAlways] // RVA: 0x275010 Offset: 0x275111 VA: 0x275010
[DisallowMultipleComponent] // RVA: 0x275010 Offset: 0x275111 VA: 0x275010
public abstract class MapObject : MonoBehaviour // TypeDefIndex: 9044
{
	// Fields
	public const int InvalidState = -1;
	public MapObject.Kinds m_Kind; // 0x18
	[HideInInspector] // RVA: 0x2863F0 Offset: 0x2864F1 VA: 0x2863F0
	public MapObject.Lods m_Lods; // 0x1C
	[HideInInspector] // RVA: 0x286400 Offset: 0x286501 VA: 0x286400
	public bool m_LodManual; // 0x20
	[HideInInspector] // RVA: 0x286410 Offset: 0x286511 VA: 0x286410
	public bool m_LodAssign; // 0x21
	[HideInInspector] // RVA: 0x286420 Offset: 0x286521 VA: 0x286420
	public bool m_DisableBake; // 0x22
	[HideInInspector] // RVA: 0x286430 Offset: 0x286531 VA: 0x286430
	public bool m_DisableOccluder; // 0x23
	[HideInInspector] // RVA: 0x286440 Offset: 0x286541 VA: 0x286440
	public MapObject.BakeTypes m_BakeTypes; // 0x24
	[SpaceAttribute] // RVA: 0x286450 Offset: 0x286551 VA: 0x286450
	public GameObject エフェクト発生位置; // 0x28
	public GameObject 停止エフェクト; // 0x30
	public GameObject 起動エフェクト; // 0x38
	public GameObject 破壊エフェクト; // 0x40
	[SpaceAttribute] // RVA: 0x286470 Offset: 0x286571 VA: 0x286470
	public bool 動作透過無効化; // 0x48
	[RangeAttribute] // RVA: 0x286490 Offset: 0x286591 VA: 0x286490
	public float 動作透過遅延; // 0x4C
	[RangeAttribute] // RVA: 0x2864B0 Offset: 0x2865B1 VA: 0x2864B0
	public float 動作透過時間; // 0x50
	public MapObject.State[] 状態変化; // 0x58
	public GameObject[] 破壊前オブジェクト; // 0x60
	public GameObject[] 破壊後オブジェクト; // 0x68
	public MapSoundLabel m_MapSoundLabel; // 0x70
	public List<MapObject.Pair> m_LightmapPairs; // 0x78
	[HideInInspector] // RVA: 0x2864D0 Offset: 0x2865D1 VA: 0x2864D0
	public MapObject.LightmapScales m_LightmapScale; // 0x80
	[RangeAttribute] // RVA: 0x2864E0 Offset: 0x2865E1 VA: 0x2864E0
	public float m_ViewDistance; // 0x84
	[RangeAttribute] // RVA: 0x286500 Offset: 0x286601 VA: 0x286500
	public float m_EditAlpha; // 0x88
	[HideInInspector] // RVA: 0x286520 Offset: 0x286621 VA: 0x286520
	public string m_Terrain; // 0x90
	private float m_FadeAlpha; // 0x98
	private float m_ActionAlpha; // 0x9C
	private float m_TransparentAlpha; // 0xA0
	private float m_DestructoniAlpha; // 0xA4
	private MapObject.Actions m_Action; // 0xA8
	private MapObject.Actions m_PreviwAction; // 0xAC
	private int m_State; // 0xB0
	private int m_PreviwState; // 0xB4
	private Animator m_Animator; // 0xB8
	private MapMaterial m_MapMaterial; // 0xC0
	private bool m_IsBroken; // 0xC8
	private MapObject.RigidList m_BrokenList; // 0xD0
	private MapObject.DitherManager m_DitherManager; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x286530 Offset: 0x286631 VA: 0x286530
	private string <SerializeKey>k__BackingField; // 0xE0
	private const int Version = 0;

	// Properties
	public MapMaterial MapMaterial { get; }
	public string SerializeKey { get; set; }

	// Methods

	// RVA: 0x2212EC0 Offset: 0x2212FC1 VA: 0x2212EC0
	public MapMaterial get_MapMaterial() { }

	// RVA: 0x2212ED0 Offset: 0x2212FD1 VA: 0x2212ED0
	private void Awake() { }

	// RVA: 0x22130C0 Offset: 0x22131C1 VA: 0x22130C0
	private MapObject.Actions GetStartAction() { }

	// RVA: 0x2213240 Offset: 0x2213341 VA: 0x2213240
	private int GetStartState() { }

	// RVA: 0x2213430 Offset: 0x2213531 VA: 0x2213430
	private bool GetStartBreak() { }

	// RVA: 0x22134B0 Offset: 0x22135B1 VA: 0x22134B0
	private bool CanDitherAlpha() { }

	// RVA: 0x2213600 Offset: 0x2213701 VA: 0x2213600
	private void Start() { }

	// RVA: 0x2213B60 Offset: 0x2213C61 VA: 0x2213B60
	public TerrainData GetTerrain() { }

	// RVA: 0x2213C00 Offset: 0x2213D01 VA: 0x2213C00
	private void PlaySound(string label) { }

	// RVA: 0x2213DA0 Offset: 0x2213EA1 VA: 0x2213DA0
	public int GetState() { }

	// RVA: 0x2213DB0 Offset: 0x2213EB1 VA: 0x2213DB0
	public MapObject.Actions GetAction() { }

	// RVA: 0x2213DC0 Offset: 0x2213EC1 VA: 0x2213DC0
	private void PlayEffect(GameObject original) { }

	// RVA: 0x2213820 Offset: 0x2213921 VA: 0x2213820
	private static int GetReverseValue(MapObject.Kinds kind) { }

	// RVA: 0x2214060 Offset: 0x2214161 VA: 0x2214060
	private static int GetActionValue(MapObject.Actions action) { }

	// RVA: 0x2213830 Offset: 0x2213931 VA: 0x2213830
	private void SetAction(MapObject.Actions action, bool update = False) { }

	// RVA: 0x22141F0 Offset: 0x22142F1 VA: 0x22141F0
	private void PlayActionAlpha(float alpha) { }

	// RVA: 0x22140A0 Offset: 0x22141A1 VA: 0x22140A0
	private void SetActionAlpha(float alpha) { }

	// RVA: 0x2214350 Offset: 0x2214451 VA: 0x2214350
	private bool AddElapsed(ref float elapsed, float time) { }

	[IteratorStateMachineAttribute] // RVA: 0x2ADE10 Offset: 0x2ADF11 VA: 0x2ADE10
	// RVA: 0x22142A0 Offset: 0x22143A1 VA: 0x22142A0
	private IEnumerator ActionAlphaCoroutine(float alpha) { }

	// RVA: 0x2214440 Offset: 0x2214541 VA: 0x2214440
	public void ChangeAction(MapObject.Actions action, bool update = False) { }

	// RVA: 0x2214500 Offset: 0x2214601 VA: 0x2214500
	public bool IsPlaying() { }

	// RVA: 0x2214070 Offset: 0x2214171 VA: 0x2214070
	private float GetActionAlpha(MapObject.Actions action) { }

	// RVA: 0x2213D10 Offset: 0x2213E11 VA: 0x2213D10
	private bool IsSkip() { }

	// RVA: 0x2214570 Offset: 0x2214671 VA: 0x2214570
	private bool IsActionSkip() { }

	// RVA: 0x2214670 Offset: 0x2214771 VA: 0x2214670
	public void PlayAction(MapObject.Actions action) { }

	// RVA: 0x2214940 Offset: 0x2214A41 VA: 0x2214940
	public void PlayEndurance(float ratio) { }

	// RVA: 0x2213410 Offset: 0x2213511 VA: 0x2213410
	private int GetStateCount() { }

	// RVA: 0x2214AF0 Offset: 0x2214BF1 VA: 0x2214AF0
	private MapObject.State GetState(int index) { }

	// RVA: 0x2214B40 Offset: 0x2214C41 VA: 0x2214B40
	private void SetState(int index, bool enable) { }

	// RVA: 0x22139F0 Offset: 0x2213AF1 VA: 0x22139F0
	public void ChangeState(int index) { }

	// RVA: 0x2214A00 Offset: 0x2214B01 VA: 0x2214A00
	public void PlayState(int index) { }

	// RVA: 0x2214B90 Offset: 0x2214C91 VA: 0x2214B90
	public void SetRenderAlpha(Renderer render, float alpha) { }

	// RVA: 0x2214BA0 Offset: 0x2214CA1 VA: 0x2214BA0
	public void SetRendersAlpha(Renderer[] renders, float alpha) { }

	// RVA: 0x2214330 Offset: 0x2214431 VA: 0x2214330
	private void CommitAlpha() { }

	// RVA: 0x2213FC0 Offset: 0x22140C1 VA: 0x2213FC0
	private Transform GetEffectRoot() { }

	// RVA: 0x22140E0 Offset: 0x22141E1 VA: 0x22140E0
	private void UpdateAction() { }

	// RVA: 0x2212EE0 Offset: 0x2212FE1 VA: 0x2212EE0
	public void ApplyLightmap() { }

	// RVA: 0x2214BB0 Offset: 0x2214CB1 VA: 0x2214BB0
	public void ApplyPreview() { }

	// RVA: 0x2214C80 Offset: 0x2214D81 VA: 0x2214C80
	public bool CanBreakable() { }

	// RVA: 0x2214D80 Offset: 0x2214E81 VA: 0x2214D80
	public bool IsBroken() { }

	// RVA: 0x2214D90 Offset: 0x2214E91 VA: 0x2214D90
	private void SetGameObjectsActive(GameObject[] objects, bool enabled) { }

	// RVA: 0x2213B00 Offset: 0x2213C01 VA: 0x2213B00
	public void SetBreak(bool enabled) { }

	// RVA: 0x2214E90 Offset: 0x2214F91 VA: 0x2214E90
	public void PlayBreak(Vector3 hit, float pow) { }

	// RVA: 0x2215050 Offset: 0x2215151 VA: 0x2215050
	private float GetDestructoniAlpha() { }

	// RVA: 0x2215060 Offset: 0x2215161 VA: 0x2215060
	private void SetDestructoniAlpha(float alpha) { }

	[IteratorStateMachineAttribute] // RVA: 0x2ADE80 Offset: 0x2ADF81 VA: 0x2ADE80
	// RVA: 0x2214FD0 Offset: 0x22150D1 VA: 0x2214FD0
	private IEnumerator BreakCoroutine() { }

	// RVA: 0x2215090 Offset: 0x2215191 VA: 0x2215090
	public void ResumeBreak() { }

	// RVA: 0x22150E0 Offset: 0x22151E1 VA: 0x22150E0
	public void UpdateView(Camera camera, float speed) { }

	// RVA: 0x22152D0 Offset: 0x22153D1 VA: 0x22152D0
	private bool TryGetTransform(string name, out Transform result) { }

	// RVA: 0x22153B0 Offset: 0x22154B1 VA: 0x22153B0
	private Transform GetTransform(string name) { }

	// RVA: 0x22153E0 Offset: 0x22154E1 VA: 0x22153E0
	private Transform GetRotateTransform() { }

	// RVA: 0x2215450 Offset: 0x2215551 VA: 0x2215450
	public Quaternion Rotation() { }

	// RVA: 0x2215530 Offset: 0x2215631 VA: 0x2215530
	public void Rotation(Quaternion rotation) { }

	[IteratorStateMachineAttribute] // RVA: 0x2ADEF0 Offset: 0x2ADFF1 VA: 0x2ADEF0
	// RVA: 0x2215640 Offset: 0x2215741 VA: 0x2215640
	private IEnumerator RotationCoroutine(Quaternion rotation, float time) { }

	// RVA: 0x2215700 Offset: 0x2215801 VA: 0x2215700
	public void Rotation(Quaternion rotation, float time) { }

	// RVA: 0x2215850 Offset: 0x2215951 VA: 0x2215850
	public Vector3 GetLaunchPoint() { }

	// RVA: 0x22158D0 Offset: 0x22159D1 VA: 0x22158D0
	public Transform GetLaunchTransform() { }

	// RVA: 0x2215940 Offset: 0x2215A41 VA: 0x2215940
	private static bool IsBmapView() { }

	// RVA: 0x2215A10 Offset: 0x2215B11 VA: 0x2215A10
	public Transform GetShootTransform() { }

	// RVA: 0x2215BB0 Offset: 0x2215CB1 VA: 0x2215BB0
	private void PlayShootImpl(EffectSequence effect) { }

	// RVA: 0x2215D40 Offset: 0x2215E41 VA: 0x2215D40
	public void PlayShoot(UnitItem item) { }

	// RVA: 0x2215D90 Offset: 0x2215E91 VA: 0x2215D90
	public void PlayShoot(string effect) { }

	// RVA: 0x2215E20 Offset: 0x2215F21 VA: 0x2215E20
	public void StopShoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADF60 Offset: 0x2AE061 VA: 0x2ADF60
	// RVA: 0x2215E30 Offset: 0x2215F31 VA: 0x2215E30
	public string get_SerializeKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADF70 Offset: 0x2AE071 VA: 0x2ADF70
	// RVA: 0x2215E40 Offset: 0x2215F41 VA: 0x2215E40
	private void set_SerializeKey(string value) { }

	// RVA: 0x2215E50 Offset: 0x2215F51 VA: 0x2215E50
	private bool HasCollider(int layer) { }

	// RVA: 0x2215F20 Offset: 0x2216021 VA: 0x2215F20
	public string CalcSerializeKey() { }

	// RVA: 0x2216100 Offset: 0x2216201 VA: 0x2216100
	private Material FindMaterial(string material, string property) { }

	// RVA: 0x22162F0 Offset: 0x22163F1 VA: 0x22162F0
	private MapMaterial.Node TryAddMaterialNode(MapMaterial.Kinds kind, string material, string property) { }

	// RVA: 0x2216400 Offset: 0x2216501 VA: 0x2216400
	public float SetMaterialFloat(string material, string property, float value) { }

	// RVA: 0x2216500 Offset: 0x2216601 VA: 0x2216500
	public Color SetMaterialColor(string material, string property, Color color) { }

	// RVA: 0x2216660 Offset: 0x2216761 VA: 0x2216660
	public void Serialize(Stream stream) { }

	// RVA: 0x22166B0 Offset: 0x22167B1 VA: 0x22166B0
	public void Deserialize(Stream stream) { }

	// RVA: 0x2216830 Offset: 0x2216931 VA: 0x2216830
	protected void .ctor() { }
}

