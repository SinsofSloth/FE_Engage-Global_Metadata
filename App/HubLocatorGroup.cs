// Namespace: App
public class HubLocatorGroup // TypeDefIndex: 10688
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294BA0 Offset: 0x294CA1 VA: 0x294BA0
	private readonly GameObject <ActiveGroupRoot>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x294BB0 Offset: 0x294CB1 VA: 0x294BB0
	private readonly List<GameObject> <UnitList>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x294BC0 Offset: 0x294CC1 VA: 0x294BC0
	private List<HubAccess> <AccessList>k__BackingField; // 0x20
	private bool m_Active; // 0x28
	private bool m_SystemActive; // 0x29
	private bool m_EventActive; // 0x2A
	private List<GameObject> m_inactiveObjects; // 0x30
	private int m_LoadingCharaCount; // 0x38
	private List<int> m_hashTable; // 0x40

	// Properties
	public GameObject ActiveGroupRoot { get; }
	public List<GameObject> UnitList { get; }
	public List<HubAccess> AccessList { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0850 Offset: 0x2C0951 VA: 0x2C0850
	// RVA: 0x2BDDD20 Offset: 0x2BDDE21 VA: 0x2BDDD20
	public GameObject get_ActiveGroupRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0860 Offset: 0x2C0961 VA: 0x2C0860
	// RVA: 0x2BDDD30 Offset: 0x2BDDE31 VA: 0x2BDDD30
	public List<GameObject> get_UnitList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0870 Offset: 0x2C0971 VA: 0x2C0870
	// RVA: 0x2BDDD40 Offset: 0x2BDDE41 VA: 0x2BDDD40
	public List<HubAccess> get_AccessList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0880 Offset: 0x2C0981 VA: 0x2C0880
	// RVA: 0x2BDDD50 Offset: 0x2BDDE51 VA: 0x2BDDD50
	public void set_AccessList(List<HubAccess> value) { }

	// RVA: 0x2BDDD60 Offset: 0x2BDDE61 VA: 0x2BDDD60
	public void SetActive(bool active) { }

	// RVA: 0x2BDDE00 Offset: 0x2BDDF01 VA: 0x2BDDE00
	public void SetSystemActive(bool systemActive) { }

	// RVA: 0x2BDDE50 Offset: 0x2BDDF51 VA: 0x2BDDE50
	public void SetEventActive(bool active) { }

	// RVA: 0x2BDDEB0 Offset: 0x2BDDFB1 VA: 0x2BDDEB0
	private bool Contains(string[] param, string value) { }

	// RVA: 0x2BDDF50 Offset: 0x2BDE051 VA: 0x2BDDF50
	public void SetCaseActive(bool active, string[] ignoreNode) { }

	// RVA: 0x2BDDDC0 Offset: 0x2BDDEC1 VA: 0x2BDDDC0
	private void UpdateActive() { }

	// RVA: 0x2BDE240 Offset: 0x2BDE341 VA: 0x2BDE240
	public bool IsValid() { }

	// RVA: 0x2BDE2C0 Offset: 0x2BDE3C1 VA: 0x2BDE2C0
	public void .ctor() { }

	// RVA: 0x2BDE570 Offset: 0x2BDE671 VA: 0x2BDE570
	public HubAccess AddNewLocator(GameObject locator, string pid) { }

	// RVA: 0x2BDE6E0 Offset: 0x2BDE7E1 VA: 0x2BDE6E0
	public void ClearLocator(GameObject locator) { }

	// RVA: 0x2BDE800 Offset: 0x2BDE901 VA: 0x2BDE800
	public void ReloadLocator(HubAccess access) { }

	// RVA: 0x2BDED50 Offset: 0x2BDEE51 VA: 0x2BDED50
	public void ReleaseCharacters() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C0890 Offset: 0x2C0991 VA: 0x2C0890
	// RVA: 0x2BDED60 Offset: 0x2BDEE61 VA: 0x2BDED60
	public IEnumerator LocateAccessObjects() { }

	// RVA: 0x2BDEDE0 Offset: 0x2BDEEE1 VA: 0x2BDEDE0
	public void SetupAfter() { }

	// RVA: 0x2BDEEB0 Offset: 0x2BDEFB1 VA: 0x2BDEEB0
	public void RefreshConfirmContent(string pid) { }

	// RVA: 0x2BDEFD0 Offset: 0x2BDF0D1 VA: 0x2BDEFD0
	public void RefreshConfirmAll() { }

	// RVA: 0x2BDF0F0 Offset: 0x2BDF1F1 VA: 0x2BDF0F0
	public HubAccess FindAccess(string pid) { }

	// RVA: 0x2BDF240 Offset: 0x2BDF341 VA: 0x2BDF240
	public void UpdateLocator(string locator) { }

	// RVA: 0x2BDF390 Offset: 0x2BDF491 VA: 0x2BDF390
	public void RelocateAccess() { }

	// RVA: 0x2BDF760 Offset: 0x2BDF861 VA: 0x2BDF760
	internal bool IsCharacterLoading() { }

	// RVA: 0x2BDF770 Offset: 0x2BDF871 VA: 0x2BDF770
	private void SetupCharacterFadeLength(Character chara, float fadeDistance) { }

	// RVA: 0x2BDF830 Offset: 0x2BDF931 VA: 0x2BDF830
	private void SetupCharacterFadeRadius(Character chara, float radius) { }

	// RVA: 0x2BDF900 Offset: 0x2BDFA01 VA: 0x2BDF900
	private string GetPlaceWaer(string pid, HubAccess access) { }

	// RVA: 0x2BDFB30 Offset: 0x2BDFC31 VA: 0x2BDFB30
	public void SaveAccessory() { }

	// RVA: 0x2BDFCD0 Offset: 0x2BDFDD1 VA: 0x2BDFCD0
	public void RestoreAccessory() { }

	// RVA: 0x2BDFEA0 Offset: 0x2BDFFA1 VA: 0x2BDFEA0
	public void ResetLookAt() { }

	// RVA: 0x2BE0020 Offset: 0x2BE0121 VA: 0x2BE0020
	public void ResetBody() { }

	// RVA: 0x2BE01A0 Offset: 0x2BE02A1 VA: 0x2BE01A0
	public void Reload(string pid) { }

	// RVA: 0x2BE0320 Offset: 0x2BE0421 VA: 0x2BE0320
	public void IncrementLoadingCount() { }

	// RVA: 0x2BDEB00 Offset: 0x2BDEC01 VA: 0x2BDEB00
	public void CreateCharacter(string pid, GameObject locator, HubAccess access, Action<HubUnitController> callback) { }
}

