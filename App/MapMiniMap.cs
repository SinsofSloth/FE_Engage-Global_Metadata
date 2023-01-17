// Namespace: App
public class MapMiniMap : SingletonProcInst<MapMiniMap> // TypeDefIndex: 12199
{
	// Fields
	private const string PrefabPath = "UI/Battle/BattleMiniMap/Prefabs/MiniMap";
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x78
	private GameObject m_MiniMapObject; // 0x80
	private Stack<MiniMapController.Mode> m_ModeStack; // 0x88
	private MiniMapController.Mode m_MiniMapMode; // 0x90

	// Methods

	// RVA: 0x220EE40 Offset: 0x220EF41 VA: 0x220EE40
	public static void CreateAsync(ProcInst super) { }

	// RVA: 0x220F100 Offset: 0x220F201 VA: 0x220F100
	public bool IsCreating() { }

	// RVA: 0x220F130 Offset: 0x220F231 VA: 0x220F130
	public static void Destroy() { }

	// RVA: 0x220F1F0 Offset: 0x220F2F1 VA: 0x220F1F0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x220F330 Offset: 0x220F431 VA: 0x220F330 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x220F430 Offset: 0x220F531 VA: 0x220F430
	private void CreateImpl() { }

	// RVA: 0x220F590 Offset: 0x220F691 VA: 0x220F590
	private void InitMiniMapObject() { }

	// RVA: 0x220F650 Offset: 0x220F751 VA: 0x220F650
	private void SetModeImpl(MiniMapController.Mode mode) { }

	// RVA: 0x220F6E0 Offset: 0x220F7E1 VA: 0x220F6E0
	private MiniMapController.Mode GetModeImpl() { }

	// RVA: 0x220F6F0 Offset: 0x220F7F1 VA: 0x220F6F0
	private void PushModeImpl() { }

	// RVA: 0x220F750 Offset: 0x220F851 VA: 0x220F750
	private void PopModeImpl() { }

	// RVA: 0x220F810 Offset: 0x220F911 VA: 0x220F810
	private void SetDirtyImpl() { }

	// RVA: 0x220F890 Offset: 0x220F991 VA: 0x220F890
	public static void SetMode(MiniMapController.Mode mode) { }

	// RVA: 0x220F990 Offset: 0x220FA91 VA: 0x220F990
	public static void SetModeHide() { }

	// RVA: 0x220F9A0 Offset: 0x220FAA1 VA: 0x220F9A0
	public static void SetModeShow() { }

	// RVA: 0x220F9B0 Offset: 0x220FAB1 VA: 0x220F9B0
	public static void SetModeMenu() { }

	// RVA: 0x220F9C0 Offset: 0x220FAC1 VA: 0x220F9C0
	public static void PushModeHide() { }

	// RVA: 0x220FB20 Offset: 0x220FC21 VA: 0x220FB20
	public static void PopMode() { }

	// RVA: 0x220FC50 Offset: 0x220FD51 VA: 0x220FC50
	public MiniMapController.Mode GetMode() { }

	// RVA: 0x220FCD0 Offset: 0x220FDD1 VA: 0x220FCD0
	public static void SetDirty() { }

	// RVA: 0x220FDC0 Offset: 0x220FEC1 VA: 0x220FDC0
	public static bool IsControl() { }

	// RVA: 0x220F010 Offset: 0x220F111 VA: 0x220F010
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7F80 Offset: 0x2C8081 VA: 0x2C7F80
	// RVA: 0x220FEE0 Offset: 0x220FFE1 VA: 0x220FEE0
	private void <OnCreate>b__9_0(GameObject _) { }
}

