// Namespace: 
public static class AkRoomAwareManager // TypeDefIndex: 7950
{
	// Fields
	private static readonly HashSet<AkRoomAwareObject> m_RoomAwareObjects; // 0x0
	private static readonly HashSet<AkRoomAwareObject> m_RoomAwareObjectToUpdate; // 0x8

	// Methods

	// RVA: 0x318BC20 Offset: 0x318BD21 VA: 0x318BC20
	public static void RegisterRoomAwareObject(AkRoomAwareObject roomAwareObject) { }

	// RVA: 0x318BD10 Offset: 0x318BE11 VA: 0x318BD10
	public static void UnregisterRoomAwareObject(AkRoomAwareObject roomAwareObject) { }

	// RVA: 0x318B520 Offset: 0x318B621 VA: 0x318B520
	public static void RegisterRoomAwareObjectForUpdate(AkRoomAwareObject roomAwareObject) { }

	// RVA: 0x318B620 Offset: 0x318B721 VA: 0x318B620
	public static void ObjectEnteredRoom(Collider collider, AkRoom room) { }

	// RVA: 0x318B020 Offset: 0x318B121 VA: 0x318B020
	public static void ObjectEnteredRoom(AkRoomAwareObject roomAwareObject, AkRoom room) { }

	// RVA: 0x318B810 Offset: 0x318B911 VA: 0x318B810
	public static void ObjectExitedRoom(Collider collider, AkRoom room) { }

	// RVA: 0x318BE80 Offset: 0x318BF81 VA: 0x318BE80
	public static void ObjectExitedRoom(AkRoomAwareObject roomAwareObject, AkRoom room) { }

	// RVA: 0x318C000 Offset: 0x318C101 VA: 0x318C000
	public static void UpdateRoomAwareObjects() { }

	// RVA: 0x318C210 Offset: 0x318C311 VA: 0x318C210
	private static void .cctor() { }
}

