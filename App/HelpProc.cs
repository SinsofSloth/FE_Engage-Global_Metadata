// Namespace: App
public class HelpProc : SingletonProcInst<HelpProc> // TypeDefIndex: 11820
{
	// Fields
	private static bool m_isTempGod; // 0x0
	private static GodUnit m_TempGod; // 0x8
	private static bool m_isTempCommon; // 0x10
	private static UnitRing m_TempCommon; // 0x18
	private static bool m_isTempUnit; // 0x20
	private static Unit m_TempUnit; // 0x28
	private HelpManager m_helpManager; // 0x78
	private HelpParamSetter m_helpParamSetter; // 0x80
	private static HelpProc.EventHandler m_enter; // 0x30
	private static HelpProc.EventHandler m_exit; // 0x38
	private static bool m_isDisable; // 0x40

	// Methods

	// RVA: 0x26639C0 Offset: 0x2663AC1 VA: 0x26639C0
	private void Begin() { }

	// RVA: 0x2663D00 Offset: 0x2663E01 VA: 0x2663D00
	private void Tick() { }

	// RVA: 0x2664920 Offset: 0x2664A21 VA: 0x2664920
	private void CommitMapPanelTarget() { }

	// RVA: 0x2664E70 Offset: 0x2664F71 VA: 0x2664E70
	private void End() { }

	// RVA: 0x2665090 Offset: 0x2665191 VA: 0x2665090
	public static void Enable() { }

	// RVA: 0x2665100 Offset: 0x2665201 VA: 0x2665100
	public static void Disable() { }

	// RVA: 0x2665170 Offset: 0x2665271 VA: 0x2665170
	public static void CreateBind(ProcInst parent, GameObject targetObject, HelpProc.EventHandler enter, HelpProc.EventHandler exit, bool isTempGod = False, GodUnit god, bool isTempRing = False, UnitRing ring, bool isTempUnit = False, Unit unit) { }

	// RVA: 0x26656F0 Offset: 0x26657F1 VA: 0x26656F0
	public static void CreateBindUnitStatus(ProcInst parent, HelpProc.EventHandler enter, HelpProc.EventHandler exit, Unit unit) { }

	// RVA: 0x26657E0 Offset: 0x26658E1 VA: 0x26657E0
	public static void CreateBindUnitInfo(ProcInst parent, HelpProc.EventHandler enter, HelpProc.EventHandler exit) { }

	// RVA: 0x26658C0 Offset: 0x26659C1 VA: 0x26658C0
	public static void CraeteBindEngageLink(ProcInst parent, HelpProc.EventHandler enter, HelpProc.EventHandler exit, GameObject targetObject, GodUnit god, Unit unit) { }

	// RVA: 0x2665980 Offset: 0x2665A81 VA: 0x2665980
	public static void CreateBindGodRingSelect(ProcInst parent, GameObject targetObject, GodUnit god, Unit unit) { }

	// RVA: 0x2665A30 Offset: 0x2665B31 VA: 0x2665A30
	public static void CreateBindCommonRingSelect(ProcInst parent, GameObject targetObject, UnitRing ring, Unit unit) { }

	// RVA: 0x2665AE0 Offset: 0x2665BE1 VA: 0x2665AE0
	public static void CreateBindShopUnitSelect(ProcInst parent, GameObject gameObject) { }

	// RVA: 0x2665670 Offset: 0x2665771 VA: 0x2665670
	public void .ctor() { }

	// RVA: 0x2665B80 Offset: 0x2665C81 VA: 0x2665B80
	private static void .cctor() { }
}

