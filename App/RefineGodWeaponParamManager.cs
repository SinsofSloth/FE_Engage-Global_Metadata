// Namespace: App
public class RefineGodWeaponParamManager // TypeDefIndex: 11046
{
	// Fields
	protected RefineGodWeaponParamManager.ReturnEventHandler m_ReturnEventHandler; // 0x10
	private RefineGodWeaponParamMenu m_Menu; // 0x18
	private RefineGodWeaponRoot m_Root; // 0x20
	private GodUnit m_GodUnit; // 0x28
	private ItemData m_GodWeapon; // 0x30
	private GodWeaponRefineData.Kind m_RefineKind; // 0x38
	private int m_CurrentLevel; // 0x3C

	// Methods

	// RVA: 0x2774490 Offset: 0x2774591 VA: 0x2774490
	public static RefineGodWeaponParamManager Create(ProcInst super, RefineGodWeaponRoot root, GodUnit godUnit, ItemData godWeapon, RefineGodWeaponParamManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2774860 Offset: 0x2774961 VA: 0x2774860
	public static RefineGodWeaponParamManager CreateForReset(ProcInst super, RefineGodWeaponRoot root, GodUnit godUnit, ItemData godWeapon, RefineGodWeaponParamManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2774570 Offset: 0x2774671 VA: 0x2774570
	private void .ctor(ProcInst super, RefineGodWeaponRoot root, GodUnit godUnit, ItemData godWeapon, bool refineOrReset, RefineGodWeaponParamManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2774CF0 Offset: 0x2774DF1 VA: 0x2774CF0
	public void OnSelect(GodUnit godUnit, ItemData itemData, GodWeaponRefineData.Kind kind, bool refineOrReset) { }

	// RVA: 0x2774EA0 Offset: 0x2774FA1 VA: 0x2774EA0
	public void OnDecide(GodWeaponRefineData refineData, GodWeaponRefineData.Kind refineKind, int currentLevel, string sid) { }

	// RVA: 0x2775360 Offset: 0x2775461 VA: 0x2775360
	public void OnYesNoDialogYes() { }

	// RVA: 0x27758E0 Offset: 0x27759E1 VA: 0x27758E0
	public void OnOkResult() { }

	// RVA: 0x2775A40 Offset: 0x2775B41 VA: 0x2775A40
	public void OnDecideToReset(GodWeaponRefineData refineData, GodWeaponRefineData.Kind refineKind, int currentLevel, string sid) { }

	// RVA: 0x2775E30 Offset: 0x2775F31 VA: 0x2775E30
	public void OnResetYesNoDialogYes() { }

	// RVA: 0x27760E0 Offset: 0x27761E1 VA: 0x27760E0
	public void OnOkResultToReset() { }

	// RVA: 0x27755E0 Offset: 0x27756E1 VA: 0x27755E0
	public void RefineGodWeapon_Do(GodUnit godUnit, ItemData godWeapon, GodWeaponRefineData.Kind refineKind, int nextLevel, string sid) { }

	// RVA: 0x2776040 Offset: 0x2776141 VA: 0x2776040
	public void RefineGodWeapon_Reset(GodUnit godUnit, GodWeaponRefineData.Kind kind, ItemData godWeapon) { }

	// RVA: 0x27760F0 Offset: 0x27761F1 VA: 0x27760F0
	public void OnRequestClose() { }

	// RVA: 0x2775040 Offset: 0x2775141 VA: 0x2775040
	private bool TestToHasRejectiveSkill(ItemData godWeaponData) { }
}

