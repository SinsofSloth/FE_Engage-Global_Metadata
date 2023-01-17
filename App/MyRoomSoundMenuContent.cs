// Namespace: App
public class MyRoomSoundMenuContent : BasicMenuContent // TypeDefIndex: 11334
{
	// Fields
	private const string PrefabPath = "UI/Hub/MyRoom/Prefabs/SoundSelectRoot";
	private GameObject m_playStateName; // 0xE8
	private GameObject m_musicHelpRoot; // 0xF0
	private GameObject m_musicHelp; // 0xF8
	private GameObject m_musicNameRoot; // 0x100

	// Methods

	// RVA: 0x28394F0 Offset: 0x28395F1 VA: 0x28394F0
	public static void LoadPrefabAsync() { }

	// RVA: 0x283E100 Offset: 0x283E201 VA: 0x283E100
	public static bool IsLoadingPrefab() { }

	// RVA: 0x283A730 Offset: 0x283A831 VA: 0x283A730
	public static void UnloadPrefab() { }

	// RVA: 0x283C860 Offset: 0x283C961 VA: 0x283C860
	public static MyRoomSoundMenuContent Create() { }

	// RVA: 0x283E180 Offset: 0x283E281 VA: 0x283E180
	public static void Destroy(MyRoomSoundMenuContent menuContent) { }

	// RVA: 0x283E200 Offset: 0x283E301 VA: 0x283E200 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x283E210 Offset: 0x283E311 VA: 0x283E210 Slot: 21
	public override float CalcW() { }

	// RVA: 0x283E280 Offset: 0x283E381 VA: 0x283E280 Slot: 22
	public override float CalcH() { }

	// RVA: 0x283E2F0 Offset: 0x283E3F1 VA: 0x283E2F0 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x283D380 Offset: 0x283D481 VA: 0x283D380
	public void HideMenuHelp() { }

	// RVA: 0x283D390 Offset: 0x283D491 VA: 0x283D390
	public void HideMusicName() { }

	// RVA: 0x283D790 Offset: 0x283D891 VA: 0x283D790
	public void SetMusicHelpText(string text) { }

	// RVA: 0x283E300 Offset: 0x283E401 VA: 0x283E300 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x283E3C0 Offset: 0x283E4C1 VA: 0x283E3C0 Slot: 30
	protected override void Awake() { }

	// RVA: 0x283D520 Offset: 0x283D621 VA: 0x283D520
	public void SetMusicName(string musicName) { }

	// RVA: 0x283E610 Offset: 0x283E711 VA: 0x283E610
	public void .ctor() { }
}

