// Namespace: 
[RequireComponent] // RVA: 0x272920 Offset: 0x272A21 VA: 0x272920
[DisallowMultipleComponent] // RVA: 0x272920 Offset: 0x272A21 VA: 0x272920
public class AkRoomAwareObject : MonoBehaviour // TypeDefIndex: 8040
{
	// Fields
	private static readonly Dictionary<Collider, AkRoomAwareObject> ColliderToRoomAwareObjectMap; // 0x0
	public Collider m_Collider; // 0x18
	private readonly AkRoom.PriorityList roomPriorityList; // 0x20

	// Methods

	// RVA: 0x318BDC0 Offset: 0x318BEC1 VA: 0x318BDC0
	public static AkRoomAwareObject GetAkRoomAwareObjectFromCollider(Collider collider) { }

	// RVA: 0x318C2D0 Offset: 0x318C3D1 VA: 0x318C2D0
	private void Awake() { }

	// RVA: 0x318C3F0 Offset: 0x318C4F1 VA: 0x318C3F0
	private void OnEnable() { }

	// RVA: 0x318C4B0 Offset: 0x318C5B1 VA: 0x318C4B0
	private void OnDisable() { }

	// RVA: 0x318C6E0 Offset: 0x318C7E1 VA: 0x318C6E0
	private void OnDestroy() { }

	// RVA: 0x318C1E0 Offset: 0x318C2E1 VA: 0x318C1E0
	public void SetGameObjectInHighestPriorityActiveAndEnabledRoom() { }

	// RVA: 0x318C570 Offset: 0x318C671 VA: 0x318C570
	private void SetGameObjectInRoom(AkRoom room) { }

	// RVA: 0x318BE70 Offset: 0x318BF71 VA: 0x318BE70
	public void EnteredRoom(AkRoom room) { }

	// RVA: 0x318B510 Offset: 0x318B611 VA: 0x318B510
	public void ExitedRoom(AkRoom room) { }

	// RVA: 0x318C770 Offset: 0x318C871 VA: 0x318C770
	public void .ctor() { }

	// RVA: 0x318C7F0 Offset: 0x318C8F1 VA: 0x318C7F0
	private static void .cctor() { }
}

