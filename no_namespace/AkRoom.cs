// Namespace: 
[DefaultMemberAttribute] // RVA: 0x2728E0 Offset: 0x2729E1 VA: 0x2728E0
public class AkRoom.PriorityList // TypeDefIndex: 8038
{
	// Fields
	private static readonly AkRoom.PriorityList.CompareByPriority s_compareByPriority; // 0x0
	private List<AkRoom> rooms; // 0x10

	// Properties
	public int Count { get; }
	public AkRoom Item { get; }

	// Methods

	// RVA: 0x24B6080 Offset: 0x24B6181 VA: 0x24B6080
	public ulong GetHighestPriorityActiveAndEnabledRoomID() { }

	// RVA: 0x24B6160 Offset: 0x24B6261 VA: 0x24B6160
	public AkRoom GetHighestPriorityActiveAndEnabledRoom() { }

	// RVA: 0x24B6240 Offset: 0x24B6341 VA: 0x24B6240
	public int get_Count() { }

	// RVA: 0x24B6290 Offset: 0x24B6391 VA: 0x24B6290
	public void Clear() { }

	// RVA: 0x24B62F0 Offset: 0x24B63F1 VA: 0x24B62F0
	public void Add(AkRoom room) { }

	// RVA: 0x24B6480 Offset: 0x24B6581 VA: 0x24B6480
	public void Remove(AkRoom room) { }

	// RVA: 0x24B64E0 Offset: 0x24B65E1 VA: 0x24B64E0
	public bool Contains(AkRoom room) { }

	// RVA: 0x24B6380 Offset: 0x24B6481 VA: 0x24B6380
	public int BinarySearch(AkRoom room) { }

	// RVA: 0x24B65A0 Offset: 0x24B66A1 VA: 0x24B65A0
	public AkRoom get_Item(int index) { }

	// RVA: 0x24B6610 Offset: 0x24B6711 VA: 0x24B6610
	public void .ctor() { }

	// RVA: 0x24B66A0 Offset: 0x24B67A1 VA: 0x24B66A0
	private static void .cctor() { }
}

