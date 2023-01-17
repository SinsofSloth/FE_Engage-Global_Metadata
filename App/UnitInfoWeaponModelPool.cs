// Namespace: App
public class UnitInfoWeaponModelPool // TypeDefIndex: 11863
{
	// Fields
	private Dictionary<string, CharacterAsset> m_LeftWeaponDictionary; // 0x10
	private Dictionary<string, CharacterAsset> m_RightWeaponDictionary; // 0x18
	private static CharacterAsset m_ShopWeaponAsset; // 0x0
	private static CharacterAsset m_ShopWeaponAssetNewest; // 0x8
	private static UnitItem m_ShopWeaponItemNewest; // 0x10

	// Methods

	// RVA: 0x242C4D0 Offset: 0x242C5D1 VA: 0x242C4D0
	private CharacterAsset GetAndLoadWeapon(Unit unit, UnitItem equipped, AssetType assetType) { }

	// RVA: 0x242C6A0 Offset: 0x242C7A1 VA: 0x242C6A0
	private CharacterAsset GetAndLoadWeaponShop(UnitItem equipped, AssetType assetType) { }

	// RVA: 0x242C9F0 Offset: 0x242CAF1 VA: 0x242C9F0
	public void AddLeft(Unit unit, UnitItem equipped) { }

	// RVA: 0x242CAC0 Offset: 0x242CBC1 VA: 0x242CAC0
	public void AddRight(Unit unit, UnitItem equipped) { }

	// RVA: 0x242CB80 Offset: 0x242CC81 VA: 0x242CB80
	public GameObject TryGetLeft(UnitItem equipped) { }

	// RVA: 0x242CD00 Offset: 0x242CE01 VA: 0x242CD00
	public GameObject TryGetRight(UnitItem equipped) { }

	// RVA: 0x242CE80 Offset: 0x242CF81 VA: 0x242CE80
	public void TryActiveLeft(UnitItem equipped) { }

	// RVA: 0x242D0D0 Offset: 0x242D1D1 VA: 0x242D0D0
	public void TryActiveRight(UnitItem equipped) { }

	// RVA: 0x242D320 Offset: 0x242D421 VA: 0x242D320
	public void SetShopWeapon(UnitItem equipped) { }

	// RVA: 0x242D680 Offset: 0x242D781 VA: 0x242D680
	public static void ClearShopWeapon() { }

	// RVA: 0x242D7D0 Offset: 0x242D8D1 VA: 0x242D7D0
	public static bool IsShopWeapon() { }

	// RVA: 0x242D920 Offset: 0x242DA21 VA: 0x242D920
	internal void LoadAsync(Action callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C6E30 Offset: 0x2C6F31 VA: 0x2C6E30
	// RVA: 0x242DAC0 Offset: 0x242DBC1 VA: 0x242DAC0
	internal IEnumerator WaitLoaded() { }

	// RVA: 0x242DB40 Offset: 0x242DC41 VA: 0x242DB40
	internal bool IsLoaded() { }

	// RVA: 0x242D430 Offset: 0x242D531 VA: 0x242D430
	public void Delete() { }

	// RVA: 0x242DDD0 Offset: 0x242DED1 VA: 0x242DDD0
	public void .ctor() { }

	// RVA: 0x242DE80 Offset: 0x242DF81 VA: 0x242DE80
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6EA0 Offset: 0x2C6FA1 VA: 0x2C6EA0
	// RVA: 0x242DE90 Offset: 0x242DF91 VA: 0x242DE90
	private void <GetAndLoadWeaponShop>b__6_0() { }
}

