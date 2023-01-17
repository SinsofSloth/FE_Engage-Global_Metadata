// Namespace: App
public class MapUnitCommandMenu : MapBasicMenu // TypeDefIndex: 12344
{
	// Fields
	private static int s_SelectIndex; // 0x0
	private MapUnitCommandMenuContent m_MapUnitCommandMenuContent; // 0xC8

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x27613A0 Offset: 0x27614A1 VA: 0x27613A0
	protected void .ctor(List<BasicMenuItem> menuItemList, MapUnitCommandMenuContent menuContent) { }

	// RVA: 0x27613E0 Offset: 0x27614E1 VA: 0x27613E0 Slot: 64
	protected override string get_FlagID() { }

	// RVA: 0x2761430 Offset: 0x2761531 VA: 0x2761430 Slot: 30
	public override string GetName() { }

	// RVA: 0x2761480 Offset: 0x2761581 VA: 0x2761480 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x27614B0 Offset: 0x27615B1 VA: 0x27614B0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x27614C0 Offset: 0x27615C1 VA: 0x27614C0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2761540 Offset: 0x2761641 VA: 0x2761540 Slot: 38
	protected override void Tick() { }

	// RVA: 0x2761620 Offset: 0x2761721 VA: 0x2761620
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2762AE0 Offset: 0x2762BE1 VA: 0x2762AE0
	public static void ResetSelectIndex() { }

	// RVA: 0x2762B50 Offset: 0x2762C51 VA: 0x2762B50
	private static void .cctor() { }
}

