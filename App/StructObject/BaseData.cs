// Namespace: App.StructObject
public class BaseData<T_Data, T_Item, T_Piece> : ScriptableObject // TypeDefIndex: 14279
{
	// Fields
	private static T_Data instance; // 0x0
	private Dictionary<string, int> IndexKey; // 0x0
	[SerializeField] // RVA: 0x29E460 Offset: 0x29E561 VA: 0x29E460
	private List<T_Item> Items; // 0x0
	[SerializeField] // RVA: 0x29E470 Offset: 0x29E571 VA: 0x29E470
	protected T_Piece MinItem; // 0x0
	[SerializeField] // RVA: 0x29E480 Offset: 0x29E581 VA: 0x29E480
	protected T_Piece MaxItem; // 0x0
	[SerializeField] // RVA: 0x29E490 Offset: 0x29E591 VA: 0x29E490
	protected T_Piece ChgItem; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static int Load(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF7070 Offset: 0x1DF7171 VA: 0x1DF7070
	|-BaseData<object, object, object>.Load
	*/

	// RVA: -1 Offset: -1
	public static void Unload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF7080 Offset: 0x1DF7181 VA: 0x1DF7080
	|-BaseData<object, object, object>.Unload
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void Setup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF7450 Offset: 0x1DF7551 VA: 0x1DF7450
	|-BaseData<object, object, object>.Setup
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void Cleanup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF7620 Offset: 0x1DF7721 VA: 0x1DF7620
	|-BaseData<object, object, object>.Cleanup
	*/

	// RVA: -1 Offset: -1
	public void AddItem(T_Item item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF77F0 Offset: 0x1DF78F1 VA: 0x1DF77F0
	|-BaseData<object, object, object>.AddItem
	*/

	// RVA: -1 Offset: -1
	public void SetMaxItem(T_Piece piece) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF78A0 Offset: 0x1DF79A1 VA: 0x1DF78A0
	|-BaseData<object, object, object>.SetMaxItem
	*/

	// RVA: -1 Offset: -1
	public void SetMinItem(T_Piece piece) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF78B0 Offset: 0x1DF79B1 VA: 0x1DF78B0
	|-BaseData<object, object, object>.SetMinItem
	*/

	// RVA: -1 Offset: -1
	public void SetChgItem(T_Piece piece) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF78C0 Offset: 0x1DF79C1 VA: 0x1DF78C0
	|-BaseData<object, object, object>.SetChgItem
	*/

	// RVA: -1 Offset: -1
	public void CreateDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF78D0 Offset: 0x1DF79D1 VA: 0x1DF78D0
	|-BaseData<object, object, object>.CreateDictionary
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF79A0 Offset: 0x1DF7AA1 VA: 0x1DF79A0
	|-BaseData<object, object, object>.Clear
	*/

	// RVA: -1 Offset: -1
	public static int GetIndex(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF7A10 Offset: 0x1DF7B11 VA: 0x1DF7A10
	|-BaseData<object, object, object>.GetIndex
	*/

	// RVA: -1 Offset: -1
	public static string GetKey(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF7CF0 Offset: 0x1DF7DF1 VA: 0x1DF7CF0
	|-BaseData<object, object, object>.GetKey
	*/

	// RVA: -1 Offset: -1
	public static T_Item Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF8010 Offset: 0x1DF8111 VA: 0x1DF8010
	|-BaseData<object, object, object>.Get
	*/

	// RVA: -1 Offset: -1
	public static T_Item Get(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF8330 Offset: 0x1DF8431 VA: 0x1DF8330
	|-BaseData<object, object, object>.Get
	*/

	// RVA: -1 Offset: -1
	public static T_Item TryGet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF86A0 Offset: 0x1DF87A1 VA: 0x1DF86A0
	|-BaseData<object, object, object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static T_Item TryGet(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF89C0 Offset: 0x1DF8AC1 VA: 0x1DF89C0
	|-BaseData<object, object, object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static int GetItemCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF8DE0 Offset: 0x1DF8EE1 VA: 0x1DF8DE0
	|-BaseData<object, object, object>.GetItemCount
	*/

	// RVA: -1 Offset: -1
	public static List<T_Item> GetItemList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9100 Offset: 0x1DF9201 VA: 0x1DF9100
	|-BaseData<object, object, object>.GetItemList
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF93B0 Offset: 0x1DF94B1 VA: 0x1DF93B0
	|-BaseData<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF94A0 Offset: 0x1DF95A1 VA: 0x1DF94A0
	|-BaseData<object, object, object>..cctor
	*/
}

