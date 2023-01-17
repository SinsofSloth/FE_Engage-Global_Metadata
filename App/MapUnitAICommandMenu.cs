// Namespace: App
public class MapUnitAICommandMenu : MapBasicMenu // TypeDefIndex: 11996
{
	// Fields
	private MapUnitCommandMenuContent m_MapUnitMenuContent; // 0xC8
	private Unit m_Unit; // 0xD0
	private Action m_OpenCallback; // 0xD8
	private Action m_CloseCallback; // 0xE0

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2760EC0 Offset: 0x2760FC1 VA: 0x2760EC0
	protected void .ctor(List<BasicMenuItem> menuItemList, MapUnitCommandMenuContent menuContent, Unit unit, Action openCallback, Action closeCallback) { }

	// RVA: 0x2760F40 Offset: 0x2761041 VA: 0x2760F40 Slot: 64
	protected override string get_FlagID() { }

	// RVA: 0x2760F90 Offset: 0x2761091 VA: 0x2760F90
	public static void CreateBind(ProcInst super, Unit unit, Action openCallback, Action closeCallback) { }

	// RVA: 0x2761250 Offset: 0x2761351 VA: 0x2761250 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2761280 Offset: 0x2761381 VA: 0x2761280 Slot: 38
	protected override void Tick() { }

	// RVA: 0x27612B0 Offset: 0x27613B1 VA: 0x27612B0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2761360 Offset: 0x2761461 VA: 0x2761360 Slot: 10
	protected override void OnDispose() { }
}

