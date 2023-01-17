// Namespace: App
public class MapBattleInfoWindow : SingletonClass<MapBattleInfoWindow> // TypeDefIndex: 12482
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	private static readonly string LeftSideObjName; // 0x8
	private static readonly string RightSideObjName; // 0x10
	private static readonly string BattleSequenceObjName; // 0x18
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x20
	private bool m_IsValid; // 0x28
	private GameObject m_GameObject; // 0x30
	private GameObject m_BattleInfoL; // 0x38
	private GameObject m_BattleInfoR; // 0x40
	private MapBattleInfoWindowSingle[] m_Singles; // 0x48
	private MapBattleInfoSequence m_BattleSequence; // 0x50
	private SupportInfo[] m_SupportInfos; // 0x58

	// Properties
	public GameObject BattleInfoL { get; }
	public GameObject BattleInfoR { get; }

	// Methods

	// RVA: 0x2C873C0 Offset: 0x2C874C1 VA: 0x2C873C0
	public bool IsLoading() { }

	// RVA: 0x2C873F0 Offset: 0x2C874F1 VA: 0x2C873F0
	public void SetBattleInfo(BattleInfo info, BattleSceneList sceneList) { }

	// RVA: 0x2C87780 Offset: 0x2C87881 VA: 0x2C87780
	public void SetWeaponChangeVisible(bool isVisible) { }

	// RVA: 0x2C87840 Offset: 0x2C87941 VA: 0x2C87840
	public void SetEngageCommandVisible(Unit unit, Unit target) { }

	// RVA: 0x2C876A0 Offset: 0x2C877A1 VA: 0x2C876A0
	public void Activate() { }

	// RVA: 0x2C87960 Offset: 0x2C87A61 VA: 0x2C87960
	public void Deactivate() { }

	// RVA: 0x2C87A10 Offset: 0x2C87B11 VA: 0x2C87A10
	public bool IsActive() { }

	// RVA: 0x2C87AC0 Offset: 0x2C87BC1 VA: 0x2C87AC0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2C87C20 Offset: 0x2C87D21 VA: 0x2C87C20 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x2C87E70 Offset: 0x2C87F71 VA: 0x2C87E70
	private void CreateObjects() { }

	// RVA: 0x2C87C30 Offset: 0x2C87D31 VA: 0x2C87C30
	private void DestroyObjects() { }

	// RVA: 0x2C88650 Offset: 0x2C88751 VA: 0x2C88650
	public GameObject get_BattleInfoL() { }

	// RVA: 0x2C88660 Offset: 0x2C88761 VA: 0x2C88660
	public GameObject get_BattleInfoR() { }

	// RVA: 0x2C88670 Offset: 0x2C88771 VA: 0x2C88670
	public void .ctor() { }

	// RVA: 0x2C886F0 Offset: 0x2C887F1 VA: 0x2C886F0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9610 Offset: 0x2C9711 VA: 0x2C9610
	// RVA: 0x2C887E0 Offset: 0x2C888E1 VA: 0x2C887E0
	private void <OnCreate>b__19_0(GameObject _) { }
}

