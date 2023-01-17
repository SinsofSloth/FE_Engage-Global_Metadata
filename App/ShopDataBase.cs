// Namespace: App
public abstract class ShopDataBase<T> : StructDataArray<T> // TypeDefIndex: 10062
{
	// Fields
	public const int Infinity = -1;
	[CompilerGeneratedAttribute] // RVA: 0x28CF90 Offset: 0x28D091 VA: 0x28CF90
	private string <Iid>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x28CFA0 Offset: 0x28D0A1 VA: 0x28CFA0
	private int <Stock>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x28CFB0 Offset: 0x28D0B1 VA: 0x28CFB0
	private int <Attribute>k__BackingField; // 0x0
	protected static List<ItemData> m_RandomGiftList; // 0x0

	// Properties
	public string Iid { get; set; }
	public int Stock { get; set; }
	public int Attribute { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public static void Load() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433300 Offset: 0x3433401 VA: 0x3433300
	|-ShopDataBase<object>.Load
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2BBDD0 Offset: 0x2BBED1 VA: 0x2BBDD0
	// RVA: -1 Offset: -1
	public string get_Iid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433310 Offset: 0x3433411 VA: 0x3433310
	|-ShopDataBase<object>.get_Iid
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2BBDE0 Offset: 0x2BBEE1 VA: 0x2BBDE0
	// RVA: -1 Offset: -1
	protected void set_Iid(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433320 Offset: 0x3433421 VA: 0x3433320
	|-ShopDataBase<object>.set_Iid
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2BBDF0 Offset: 0x2BBEF1 VA: 0x2BBDF0
	// RVA: -1 Offset: -1
	public int get_Stock() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433330 Offset: 0x3433431 VA: 0x3433330
	|-ShopDataBase<object>.get_Stock
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2BBE00 Offset: 0x2BBF01 VA: 0x2BBE00
	// RVA: -1 Offset: -1
	protected void set_Stock(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433340 Offset: 0x3433441 VA: 0x3433340
	|-ShopDataBase<object>.set_Stock
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2BBE10 Offset: 0x2BBF11 VA: 0x2BBE10
	// RVA: -1 Offset: -1
	public int get_Attribute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433350 Offset: 0x3433451 VA: 0x3433350
	|-ShopDataBase<object>.get_Attribute
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2BBE20 Offset: 0x2BBF21 VA: 0x2BBE20
	// RVA: -1 Offset: -1
	protected void set_Attribute(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433360 Offset: 0x3433461 VA: 0x3433360
	|-ShopDataBase<object>.set_Attribute
	*/

	// RVA: -1 Offset: -1
	public static string GetWithoutPrefix(string Iid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433370 Offset: 0x3433471 VA: 0x3433370
	|-ShopDataBase<FleaMarketData>.GetWithoutPrefix
	|-ShopDataBase<ItemShopData>.GetWithoutPrefix
	|-ShopDataBase<object>.GetWithoutPrefix
	|-ShopDataBase<WeaponShopData>.GetWithoutPrefix
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void OnBuild() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433380 Offset: 0x3433481 VA: 0x3433380
	|-ShopDataBase<object>.OnBuild
	*/

	// RVA: -1 Offset: -1
	protected static void RegistImpl(ShopDataBase.GetStockAddedKeyFunc<T> GetStockAddedKey, ShopDataBase.GetStockKeyFunc<T> GetStockKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433390 Offset: 0x3433491 VA: 0x3433390
	|-ShopDataBase<FleaMarketData>.RegistImpl
	|-ShopDataBase<ItemShopData>.RegistImpl
	|-ShopDataBase<object>.RegistImpl
	|-ShopDataBase<WeaponShopData>.RegistImpl
	*/

	// RVA: -1 Offset: -1
	protected static ShopContent[] SetupContentListImpl(ShopDataBase.GetStockAddedKeyFunc<T> GetStockAddedKey, ShopDataBase.GetStockKeyFunc<T> GetStockKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433CE0 Offset: 0x3433DE1 VA: 0x3433CE0
	|-ShopDataBase<FleaMarketData>.SetupContentListImpl
	|-ShopDataBase<ItemShopData>.SetupContentListImpl
	|-ShopDataBase<object>.SetupContentListImpl
	|-ShopDataBase<WeaponShopData>.SetupContentListImpl
	*/

	// RVA: -1 Offset: -1
	protected static bool IsExistAdditionalStockImpl(ShopDataBase.GetStockAddedKeyFunc<T> GetStockAddedKey, ShopDataBase.GetStockKeyFunc<T> GetStockKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3435270 Offset: 0x3435371 VA: 0x3435270
	|-ShopDataBase<FleaMarketData>.IsExistAdditionalStockImpl
	|-ShopDataBase<ItemShopData>.IsExistAdditionalStockImpl
	|-ShopDataBase<object>.IsExistAdditionalStockImpl
	|-ShopDataBase<WeaponShopData>.IsExistAdditionalStockImpl
	*/

	// RVA: -1 Offset: -1
	protected static void PurchaseImpl(string Iid, int value, ShopDataBase.GetStockAddedKeyFunc<T> GetStockAddedKey, ShopDataBase.GetStockKeyFunc<T> GetStockKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3435760 Offset: 0x3435861 VA: 0x3435760
	|-ShopDataBase<FleaMarketData>.PurchaseImpl
	|-ShopDataBase<ItemShopData>.PurchaseImpl
	|-ShopDataBase<object>.PurchaseImpl
	|-ShopDataBase<WeaponShopData>.PurchaseImpl
	*/

	// RVA: -1 Offset: -1
	protected static int GetStockNumImpl(string Iid, ShopDataBase.GetStockKeyFunc<T> GetStockKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3435A10 Offset: 0x3435B11 VA: 0x3435A10
	|-ShopDataBase<FleaMarketData>.GetStockNumImpl
	|-ShopDataBase<ItemShopData>.GetStockNumImpl
	|-ShopDataBase<object>.GetStockNumImpl
	|-ShopDataBase<WeaponShopData>.GetStockNumImpl
	*/

	// RVA: -1 Offset: -1
	protected static bool IsInfinityImpl(string Iid, ShopDataBase.GetStockKeyFunc<T> GetStockKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3435B50 Offset: 0x3435C51 VA: 0x3435B50
	|-ShopDataBase<FleaMarketData>.IsInfinityImpl
	|-ShopDataBase<ItemShopData>.IsInfinityImpl
	|-ShopDataBase<object>.IsInfinityImpl
	|-ShopDataBase<WeaponShopData>.IsInfinityImpl
	*/

	// RVA: -1 Offset: -1
	public static void SetRandomGift(List<string> IidList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3435C90 Offset: 0x3435D91 VA: 0x3435C90
	|-ShopDataBase<FleaMarketData>.SetRandomGift
	|-ShopDataBase<object>.SetRandomGift
	*/

	// RVA: -1 Offset: -1
	public static List<ItemData> GenerateRandomGift(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3436070 Offset: 0x3436171 VA: 0x3436070
	|-ShopDataBase<FleaMarketData>.GenerateRandomGift
	|-ShopDataBase<object>.GenerateRandomGift
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3436630 Offset: 0x3436731 VA: 0x3436630
	|-ShopDataBase<FleaMarketData>..ctor
	|-ShopDataBase<ItemShopData>..ctor
	|-ShopDataBase<object>..ctor
	|-ShopDataBase<WeaponShopData>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34366E0 Offset: 0x34367E1 VA: 0x34366E0
	|-ShopDataBase<object>..cctor
	*/
}

