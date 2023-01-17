// Namespace: App
public class PhotographDisposInfo // TypeDefIndex: 11476
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x298650 Offset: 0x298751 VA: 0x298650
	private List<AccessoryData> <BodyAccDataList>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x298660 Offset: 0x298761 VA: 0x298660
	private AccessoryData <BodyAccData>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x298670 Offset: 0x298771 VA: 0x298670
	private List<AccessoryData> <FaceAccDataList>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x298680 Offset: 0x298781 VA: 0x298680
	private AccessoryData <FaceAccData>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x298690 Offset: 0x298791 VA: 0x298690
	private List<ItemData> <WeaponDataList>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2986A0 Offset: 0x2987A1 VA: 0x2986A0
	private ItemData <WeaponData>k__BackingField; // 0x38
	private static readonly string s_FruitsPath; // 0x0
	private static readonly string s_WaterCanPath; // 0x8
	private static readonly string s_BrushPath; // 0x10
	private bool m_IsVisible; // 0x40
	private GameObject m_Locator; // 0x48
	private GameObject m_LookTarget; // 0x50
	private string[] m_PauseGroupNameList; // 0x58
	private Dictionary<string, RuntimeAnimatorController> m_AnimeControllerDic; // 0x60
	private PhotographDisposInfo.FlagField m_Flag; // 0x68
	private bool m_IsLoadingCharacter; // 0x70
	private List<string> m_CharacterIdList; // 0x78
	private string m_CurrentCharacterId; // 0x80
	private PhotographDisposInfo.CharacterType m_CharacterType; // 0x88
	private Character m_CharacterCmp; // 0x90
	private bool m_IsLookAtCamera; // 0x98
	private float m_LookAtRate; // 0x9C
	private LookAtIK m_LookAtIKEye; // 0xA0
	private LookAtIK m_LookAtIKBody; // 0xA8
	private List<PhotographPauseData> m_PauseDataList; // 0xB0
	private PhotographPauseData m_CurrentPauseData; // 0xB8
	private GameObject m_HoldItem; // 0xC0
	private GameObject m_HoldWeapon; // 0xC8
	private ItemData m_HoldWeaponData; // 0xD0
	private string m_HoldWeaponPath; // 0xD8
	private bool m_IsLoadingWeapon; // 0xE0

	// Properties
	public string[] PauseGroupNameList { get; }
	public PhotographDisposInfo.FlagField Flag { get; }
	public bool IsLoading { get; }
	public List<string> CharacterIdList { get; }
	public string CurrentCharacterId { get; set; }
	public PhotographDisposInfo.CharacterType CharaType { get; }
	public List<PhotographPauseData> PauseDataList { get; }
	public PhotographPauseData CurrentPauseData { get; }
	public bool IsLookAtCamera { get; set; }
	public float LookAtRate { set; }
	public List<AccessoryData> BodyAccDataList { get; set; }
	public AccessoryData BodyAccData { get; set; }
	public List<AccessoryData> FaceAccDataList { get; set; }
	public AccessoryData FaceAccData { get; set; }
	public List<ItemData> WeaponDataList { get; set; }
	public ItemData WeaponData { get; set; }
	public bool IsVisible { set; }
	public AccessoryShopUtility.Female Female { get; }

	// Methods

	// RVA: 0x2A28B20 Offset: 0x2A28C21 VA: 0x2A28B20
	public string[] get_PauseGroupNameList() { }

	// RVA: 0x2A28B30 Offset: 0x2A28C31 VA: 0x2A28B30
	public PhotographDisposInfo.FlagField get_Flag() { }

	// RVA: 0x2A28B40 Offset: 0x2A28C41 VA: 0x2A28B40
	public bool get_IsLoading() { }

	// RVA: 0x2A28B60 Offset: 0x2A28C61 VA: 0x2A28B60
	public List<string> get_CharacterIdList() { }

	// RVA: 0x2A28B70 Offset: 0x2A28C71 VA: 0x2A28B70
	public string get_CurrentCharacterId() { }

	// RVA: 0x2A28B80 Offset: 0x2A28C81 VA: 0x2A28B80
	public void set_CurrentCharacterId(string value) { }

	// RVA: 0x2A28B90 Offset: 0x2A28C91 VA: 0x2A28B90
	public PhotographDisposInfo.CharacterType get_CharaType() { }

	// RVA: 0x2A28BA0 Offset: 0x2A28CA1 VA: 0x2A28BA0
	public List<PhotographPauseData> get_PauseDataList() { }

	// RVA: 0x2A28BB0 Offset: 0x2A28CB1 VA: 0x2A28BB0
	public PhotographPauseData get_CurrentPauseData() { }

	// RVA: 0x2A28BC0 Offset: 0x2A28CC1 VA: 0x2A28BC0
	public bool get_IsLookAtCamera() { }

	// RVA: 0x2A28BD0 Offset: 0x2A28CD1 VA: 0x2A28BD0
	public void set_IsLookAtCamera(bool value) { }

	// RVA: 0x2A28BE0 Offset: 0x2A28CE1 VA: 0x2A28BE0
	public void set_LookAtRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5890 Offset: 0x2C5991 VA: 0x2C5890
	// RVA: 0x2A28BF0 Offset: 0x2A28CF1 VA: 0x2A28BF0
	public List<AccessoryData> get_BodyAccDataList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C58A0 Offset: 0x2C59A1 VA: 0x2C58A0
	// RVA: 0x2A28C00 Offset: 0x2A28D01 VA: 0x2A28C00
	public void set_BodyAccDataList(List<AccessoryData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C58B0 Offset: 0x2C59B1 VA: 0x2C58B0
	// RVA: 0x2A28C10 Offset: 0x2A28D11 VA: 0x2A28C10
	public AccessoryData get_BodyAccData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C58C0 Offset: 0x2C59C1 VA: 0x2C58C0
	// RVA: 0x2A28C20 Offset: 0x2A28D21 VA: 0x2A28C20
	public void set_BodyAccData(AccessoryData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C58D0 Offset: 0x2C59D1 VA: 0x2C58D0
	// RVA: 0x2A28C30 Offset: 0x2A28D31 VA: 0x2A28C30
	public List<AccessoryData> get_FaceAccDataList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C58E0 Offset: 0x2C59E1 VA: 0x2C58E0
	// RVA: 0x2A28C40 Offset: 0x2A28D41 VA: 0x2A28C40
	public void set_FaceAccDataList(List<AccessoryData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C58F0 Offset: 0x2C59F1 VA: 0x2C58F0
	// RVA: 0x2A28C50 Offset: 0x2A28D51 VA: 0x2A28C50
	public AccessoryData get_FaceAccData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5900 Offset: 0x2C5A01 VA: 0x2C5900
	// RVA: 0x2A28C60 Offset: 0x2A28D61 VA: 0x2A28C60
	public void set_FaceAccData(AccessoryData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5910 Offset: 0x2C5A11 VA: 0x2C5910
	// RVA: 0x2A28C70 Offset: 0x2A28D71 VA: 0x2A28C70
	public List<ItemData> get_WeaponDataList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5920 Offset: 0x2C5A21 VA: 0x2C5920
	// RVA: 0x2A28C80 Offset: 0x2A28D81 VA: 0x2A28C80
	public void set_WeaponDataList(List<ItemData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5930 Offset: 0x2C5A31 VA: 0x2C5930
	// RVA: 0x2A28C90 Offset: 0x2A28D91 VA: 0x2A28C90
	public ItemData get_WeaponData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5940 Offset: 0x2C5A41 VA: 0x2C5940
	// RVA: 0x2A28CA0 Offset: 0x2A28DA1 VA: 0x2A28CA0
	public void set_WeaponData(ItemData value) { }

	// RVA: 0x2A28CB0 Offset: 0x2A28DB1 VA: 0x2A28CB0
	public void set_IsVisible(bool value) { }

	// RVA: 0x2A28D80 Offset: 0x2A28E81 VA: 0x2A28D80
	public AccessoryShopUtility.Female get_Female() { }

	// RVA: 0x2A28DB0 Offset: 0x2A28EB1 VA: 0x2A28DB0
	public void .ctor(GameObject locator, PhotographSpotData selectSpot, int locatorNo, Dictionary<string, RuntimeAnimatorController> animeControllerDic) { }

	// RVA: 0x2A297E0 Offset: 0x2A298E1 VA: 0x2A297E0
	public PhotographPauseData GetRandomPause(string charaId) { }

	// RVA: 0x2A29BA0 Offset: 0x2A29CA1 VA: 0x2A29BA0
	public void SetUpCharacter(string characterId, PhotographPauseData pauseData, AccessoryData bodyAcc, AccessoryData faceAcc, ItemData weaponData, bool isRandom = False) { }

	// RVA: 0x2A2C100 Offset: 0x2A2C201 VA: 0x2A2C100
	private void UpdateLook() { }

	// RVA: 0x2A2A3A0 Offset: 0x2A2A4A1 VA: 0x2A2A3A0
	private void InitCharacter(string characterId, PhotographPauseData pauseData, AccessoryData bodyAcc, AccessoryData faceAcc, ItemData weaponData, bool isRandom = False) { }

	// RVA: 0x2A2B810 Offset: 0x2A2B911 VA: 0x2A2B810
	private void SetUpPause() { }

	// RVA: 0x2A2BED0 Offset: 0x2A2BFD1 VA: 0x2A2BED0
	private void SetupWeapon() { }

	// RVA: 0x2A2CD70 Offset: 0x2A2CE71 VA: 0x2A2CD70
	public void DestroyWeapon() { }

	// RVA: 0x2A2CE70 Offset: 0x2A2CF71 VA: 0x2A2CE70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5950 Offset: 0x2C5A51 VA: 0x2C5950
	// RVA: 0x2A2CF40 Offset: 0x2A2D041 VA: 0x2A2CF40
	private void <.ctor>b__75_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5960 Offset: 0x2C5A61 VA: 0x2C5960
	// RVA: 0x2A2CC00 Offset: 0x2A2CD01 VA: 0x2A2CC00
	private void <SetUpPause>g__CreateObj|80_0(string path) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5970 Offset: 0x2C5A71 VA: 0x2C5970
	// RVA: 0x2A2CFC0 Offset: 0x2A2D0C1 VA: 0x2A2CFC0
	private void <SetUpPause>b__80_1(long _) { }
}

