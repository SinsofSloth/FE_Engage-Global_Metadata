// Namespace: 
public class AkRoomManager // TypeDefIndex: 7951
{
	// Fields
	private readonly List<AkRoomPortal> m_Portals; // 0x10
	private readonly List<AkRoomPortal> m_PortalsToUpdate; // 0x18
	private readonly List<AkSurfaceReflector> m_Reflectors; // 0x20
	private readonly List<AkSurfaceReflector> m_ReflectorsToUpdate; // 0x28
	private static AkRoomManager m_Instance; // 0x0

	// Methods

	// RVA: 0x318C890 Offset: 0x318C991 VA: 0x318C890
	public static void Init() { }

	// RVA: 0x318CA40 Offset: 0x318CB41 VA: 0x318CA40
	public static void Terminate() { }

	// RVA: 0x318CAB0 Offset: 0x318CBB1 VA: 0x318CAB0
	public static void RegisterPortal(AkRoomPortal portal) { }

	// RVA: 0x318CBC0 Offset: 0x318CCC1 VA: 0x318CBC0
	public static void UnregisterPortal(AkRoomPortal portal) { }

	// RVA: 0x318CC70 Offset: 0x318CD71 VA: 0x318CC70
	public static void RegisterReflector(AkSurfaceReflector reflector) { }

	// RVA: 0x318CD80 Offset: 0x318CE81 VA: 0x318CD80
	public static void UnregisterReflector(AkSurfaceReflector reflector) { }

	// RVA: 0x318CE30 Offset: 0x318CF31 VA: 0x318CE30
	public static void RegisterPortalUpdate(AkRoomPortal portal) { }

	// RVA: 0x318ACE0 Offset: 0x318ADE1 VA: 0x318ACE0
	public static void RegisterRoomUpdate(AkRoom room) { }

	// RVA: 0x318CFF0 Offset: 0x318D0F1 VA: 0x318CFF0
	public static void Update() { }

	// RVA: 0x318C910 Offset: 0x318CA11 VA: 0x318C910
	public void .ctor() { }
}

