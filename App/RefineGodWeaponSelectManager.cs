// Namespace: App
public class RefineGodWeaponSelectManager // TypeDefIndex: 11066
{
	// Fields
	protected RefineGodWeaponSelectManager.ReturnEventHandler m_ReturnEventHandler; // 0x10
	private RefineGodWeaponSelectMenu m_Menu; // 0x18
	private RefineGodWeaponRoot m_Root; // 0x20

	// Methods

	// RVA: 0x277AF60 Offset: 0x277B061 VA: 0x277AF60
	public static RefineGodWeaponSelectManager Create(ProcInst super, RefineGodWeaponRoot root, GodUnit initialGodUnit, ItemData initialGodWeapon, int initialScrollIndex, RefineGodWeaponSelectManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x277B1F0 Offset: 0x277B2F1 VA: 0x277B1F0
	public static RefineGodWeaponSelectManager CreateForReset(ProcInst super, RefineGodWeaponRoot root, GodUnit initialGodUnit, ItemData initialGodWeapon, int initialScrollIndex, RefineGodWeaponSelectManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x277B050 Offset: 0x277B151 VA: 0x277B050
	private void .ctor(ProcInst super, RefineGodWeaponRoot root, GodUnit initialGodUnit, ItemData initialGodWeapon, int initialScrollIndex, RefineGodWeaponSelectManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x277B740 Offset: 0x277B841 VA: 0x277B740
	public void OnSelect(GodUnit godUnit, UnitItem unitItem) { }

	// RVA: 0x277B880 Offset: 0x277B981 VA: 0x277B880
	public void OnDecide(GodUnit godUnit, UnitItem godWeapon) { }

	// RVA: 0x277B8E0 Offset: 0x277B9E1 VA: 0x277B8E0
	public void OnRequestClose() { }
}

