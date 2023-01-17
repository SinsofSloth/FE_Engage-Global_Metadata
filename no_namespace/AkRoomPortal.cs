// Namespace: 
public enum AkRoomPortal.State // TypeDefIndex: 8041
{
	// Fields
	public int value__; // 0x0
	public const AkRoomPortal.State Closed = 0;
	public const AkRoomPortal.State Open = 1;
}

// Namespace: 
[DisallowMultipleComponent] // RVA: 0x2729A0 Offset: 0x272AA1 VA: 0x2729A0
[AddComponentMenu] // RVA: 0x2729A0 Offset: 0x272AA1 VA: 0x2729A0
[RequireComponent] // RVA: 0x2729A0 Offset: 0x272AA1 VA: 0x2729A0
public class AkRoomPortal : AkTriggerHandler // TypeDefIndex: 8042
{
	// Fields
	public const int MAX_ROOMS_PER_PORTAL = 2;
	public AkRoomPortal.State initialState; // 0x2C
	private bool active; // 0x30
	public List<int> closePortalTriggerList; // 0x38
	[SerializeField] // RVA: 0x27EF30 Offset: 0x27F031 VA: 0x27EF30
	private AkRoom[] rooms; // 0x40
	private AkRoom.PriorityList[] roomList; // 0x48
	private AkTransform portalTransform; // 0x50
	private BoxCollider portalCollider; // 0x58
	private bool portalSet; // 0x60

	// Properties
	public bool portalActive { get; set; }
	private ulong frontRoomID { get; }
	private ulong backRoomID { get; }
	public AkRoom frontRoom { get; }
	public AkRoom backRoom { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x318D890 Offset: 0x318D991 VA: 0x318D890
	public bool get_portalActive() { }

	// RVA: 0x318D8A0 Offset: 0x318D9A1 VA: 0x318D8A0
	public void set_portalActive(bool value) { }

	// RVA: 0x318D8B0 Offset: 0x318D9B1 VA: 0x318D8B0
	private ulong get_frontRoomID() { }

	// RVA: 0x318DAC0 Offset: 0x318DBC1 VA: 0x318DAC0
	private ulong get_backRoomID() { }

	// RVA: 0x318DC30 Offset: 0x318DD31 VA: 0x318DC30
	public AkRoom GetRoom(int index) { }

	// RVA: 0x318CF10 Offset: 0x318D011 VA: 0x318CF10
	public AkRoom get_frontRoom() { }

	// RVA: 0x318CF40 Offset: 0x318D041 VA: 0x318CF40
	public AkRoom get_backRoom() { }

	// RVA: 0x318DC70 Offset: 0x318DD71 VA: 0x318DC70
	private void SetRoomPortal() { }

	// RVA: 0x318D1A0 Offset: 0x318D2A1 VA: 0x318D1A0
	public void UpdateRoomPortal() { }

	// RVA: 0x318CF70 Offset: 0x318D071 VA: 0x318CF70
	public bool Overlaps(AkRoom room) { }

	// RVA: 0x318DF30 Offset: 0x318E031 VA: 0x318DF30
	public bool get_IsValid() { }

	// RVA: 0x318DF70 Offset: 0x318E071 VA: 0x318DF70
	public ulong GetID() { }

	// RVA: 0x318E2A0 Offset: 0x318E3A1 VA: 0x318E2A0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x318E3E0 Offset: 0x318E4E1 VA: 0x318E3E0 Slot: 6
	protected override void Start() { }

	// RVA: 0x318E480 Offset: 0x318E581 VA: 0x318E480 Slot: 4
	public override void HandleEvent(GameObject in_gameObject) { }

	// RVA: 0x318E470 Offset: 0x318E571 VA: 0x318E470
	public void ClosePortal(GameObject in_gameObject) { }

	// RVA: 0x318E4B0 Offset: 0x318E5B1 VA: 0x318E4B0 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x318E550 Offset: 0x318E651 VA: 0x318E550 Slot: 8
	public override void OnEnable() { }

	// RVA: 0x318E580 Offset: 0x318E681 VA: 0x318E580
	private void OnDisable() { }

	// RVA: 0x318DA20 Offset: 0x318DB21 VA: 0x318DA20
	private bool IsRoomActive(AkRoom in_room) { }

	// RVA: 0x318E490 Offset: 0x318E591 VA: 0x318E490
	public void Open() { }

	// RVA: 0x318E4A0 Offset: 0x318E5A1 VA: 0x318E4A0
	public void Close() { }

	// RVA: 0x318E150 Offset: 0x318E251 VA: 0x318E150
	public void FindOverlappingRooms(AkRoom.PriorityList[] roomList) { }

	// RVA: 0x318E690 Offset: 0x318E791 VA: 0x318E690
	private void FillRoomList(Vector3 position, AkRoom.PriorityList list) { }

	// RVA: 0x318DF90 Offset: 0x318E091 VA: 0x318DF90
	public void UpdateRooms() { }

	[ObsoleteAttribute] // RVA: 0x2A73C0 Offset: 0x2A74C1 VA: 0x2A73C0
	// RVA: 0x318E810 Offset: 0x318E911 VA: 0x318E810
	public void SetRoom(int in_roomIndex, AkRoom in_room) { }

	[ObsoleteAttribute] // RVA: 0x2A7400 Offset: 0x2A7501 VA: 0x2A7400
	// RVA: 0x318E930 Offset: 0x318EA31 VA: 0x318E930
	public void SetFrontRoom(AkRoom room) { }

	[ObsoleteAttribute] // RVA: 0x2A7440 Offset: 0x2A7541 VA: 0x2A7440
	// RVA: 0x318EA50 Offset: 0x318EB51 VA: 0x318EA50
	public void SetBackRoom(AkRoom room) { }

	[ObsoleteAttribute] // RVA: 0x2A7480 Offset: 0x2A7581 VA: 0x2A7480
	// RVA: 0x318EB70 Offset: 0x318EC71 VA: 0x318EB70
	public void UpdateSoundEngineRoomIDs() { }

	[ObsoleteAttribute] // RVA: 0x2A74C0 Offset: 0x2A75C1 VA: 0x2A74C0
	// RVA: 0x318EBA0 Offset: 0x318ECA1 VA: 0x318EBA0
	public void UpdateOverlappingRooms() { }

	// RVA: 0x318EBB0 Offset: 0x318ECB1 VA: 0x318EBB0
	public void .ctor() { }
}

