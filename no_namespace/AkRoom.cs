// Namespace: 
[AddComponentMenu] // RVA: 0x272840 Offset: 0x272941 VA: 0x272840
[RequireComponent] // RVA: 0x272840 Offset: 0x272941 VA: 0x272840
[DisallowMultipleComponent] // RVA: 0x272840 Offset: 0x272941 VA: 0x272840
public class AkRoom : AkTriggerHandler // TypeDefIndex: 8039
{
	// Fields
	public static ulong INVALID_ROOM_ID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x27EE40 Offset: 0x27EF41 VA: 0x27EE40
	private static int <RoomCount>k__BackingField; // 0x8
	[TooltipAttribute] // RVA: 0x27EE50 Offset: 0x27EF51 VA: 0x27EE50
	public int priority; // 0x2C
	public AuxBus reverbAuxBus; // 0x30
	[RangeAttribute] // RVA: 0x27EE90 Offset: 0x27EF91 VA: 0x27EE90
	public float reverbLevel; // 0x38
	[RangeAttribute] // RVA: 0x27EEB0 Offset: 0x27EFB1 VA: 0x27EEB0
	public float wallOcclusion; // 0x3C
	public Event roomToneEvent; // 0x40
	[RangeAttribute] // RVA: 0x27EED0 Offset: 0x27EFD1 VA: 0x27EED0
	[TooltipAttribute] // RVA: 0x27EED0 Offset: 0x27EFD1 VA: 0x27EED0
	public float roomToneAuxSend; // 0x48
	private List<AkRoomAwareObject> roomAwareObjectsEntered; // 0x50
	private List<AkRoomAwareObject> roomAwareObjectsDetectedWhileDisabled; // 0x58

	// Properties
	public static int RoomCount { get; set; }

	// Methods

	// RVA: 0x3189E40 Offset: 0x3189F41 VA: 0x3189E40
	public static ulong GetAkRoomID(AkRoom room) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A73A0 Offset: 0x2A74A1 VA: 0x2A73A0
	// RVA: 0x3189FE0 Offset: 0x318A0E1 VA: 0x3189FE0
	public static int get_RoomCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A73B0 Offset: 0x2A74B1 VA: 0x2A73B0
	// RVA: 0x318A050 Offset: 0x318A151 VA: 0x318A050
	private static void set_RoomCount(int value) { }

	// RVA: 0x318A0C0 Offset: 0x318A1C1 VA: 0x318A0C0
	public bool TryEnter(AkRoomAwareObject roomAwareObject) { }

	// RVA: 0x318A200 Offset: 0x318A301 VA: 0x318A200
	public void Exit(AkRoomAwareObject roomAwareObject) { }

	// RVA: 0x3189F60 Offset: 0x318A061 VA: 0x3189F60
	public ulong GetID() { }

	// RVA: 0x318A2D0 Offset: 0x318A3D1 VA: 0x318A2D0 Slot: 8
	public override void OnEnable() { }

	// RVA: 0x318B1A0 Offset: 0x318B2A1 VA: 0x318B1A0
	private void OnDisable() { }

	// RVA: 0x318B5B0 Offset: 0x318B6B1 VA: 0x318B5B0
	private void OnTriggerEnter(Collider in_other) { }

	// RVA: 0x318B7A0 Offset: 0x318B8A1 VA: 0x318B7A0
	private void OnTriggerExit(Collider in_other) { }

	// RVA: 0x318B990 Offset: 0x318BA91 VA: 0x318B990
	public void PostRoomTone() { }

	// RVA: 0x318BA90 Offset: 0x318BB91 VA: 0x318BA90 Slot: 4
	public override void HandleEvent(GameObject in_gameObject) { }

	// RVA: 0x318BAA0 Offset: 0x318BBA1 VA: 0x318BAA0
	public void .ctor() { }

	// RVA: 0x318BC10 Offset: 0x318BD11 VA: 0x318BC10
	private static void .cctor() { }
}

