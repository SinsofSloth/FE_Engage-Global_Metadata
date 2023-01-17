// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x52890 Offset: 0x52991 VA: 0x52890
[StaticAccessorAttribute] // RVA: 0x52890 Offset: 0x52991 VA: 0x52890
public sealed class Event // TypeDefIndex: 4141
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	[NativePropertyAttribute] // RVA: 0x542B0 Offset: 0x543B1 VA: 0x542B0
	public EventType rawType { get; }
	[NativePropertyAttribute] // RVA: 0x542F0 Offset: 0x543F1 VA: 0x542F0
	public Vector2 mousePosition { get; }
	[NativePropertyAttribute] // RVA: 0x54330 Offset: 0x54431 VA: 0x54330
	public Vector2 delta { get; }
	[NativePropertyAttribute] // RVA: 0x54370 Offset: 0x54471 VA: 0x54370
	public PointerType pointerType { get; }
	[NativePropertyAttribute] // RVA: 0x543B0 Offset: 0x544B1 VA: 0x543B0
	public EventModifiers modifiers { get; }
	[NativePropertyAttribute] // RVA: 0x543F0 Offset: 0x544F1 VA: 0x543F0
	public char character { get; }
	[NativePropertyAttribute] // RVA: 0x54430 Offset: 0x54531 VA: 0x54430
	public KeyCode keyCode { get; }
	[NativePropertyAttribute] // RVA: 0x54470 Offset: 0x54571 VA: 0x54470
	public int displayIndex { set; }
	public EventType type { get; }
	public string commandName { get; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public static Event current { get; }
	public bool isKey { get; }
	public bool isMouse { get; }
	internal bool isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0x3C6E090 Offset: 0x3C6E191 VA: 0x3C6E090
	public EventType get_rawType() { }

	// RVA: 0x3C6E0E0 Offset: 0x3C6E1E1 VA: 0x3C6E0E0
	public Vector2 get_mousePosition() { }

	// RVA: 0x3C6E190 Offset: 0x3C6E291 VA: 0x3C6E190
	public Vector2 get_delta() { }

	// RVA: 0x3C6E240 Offset: 0x3C6E341 VA: 0x3C6E240
	public PointerType get_pointerType() { }

	// RVA: 0x3C6E290 Offset: 0x3C6E391 VA: 0x3C6E290
	public EventModifiers get_modifiers() { }

	// RVA: 0x3C6E2E0 Offset: 0x3C6E3E1 VA: 0x3C6E2E0
	public char get_character() { }

	// RVA: 0x3C6E330 Offset: 0x3C6E431 VA: 0x3C6E330
	public KeyCode get_keyCode() { }

	// RVA: 0x3C6E380 Offset: 0x3C6E481 VA: 0x3C6E380
	public void set_displayIndex(int value) { }

	[FreeFunctionAttribute] // RVA: 0x536D0 Offset: 0x537D1 VA: 0x536D0
	// RVA: 0x3C6E3D0 Offset: 0x3C6E4D1 VA: 0x3C6E3D0
	public EventType get_type() { }

	[FreeFunctionAttribute] // RVA: 0x53720 Offset: 0x53821 VA: 0x53720
	// RVA: 0x3C6E420 Offset: 0x3C6E521 VA: 0x3C6E420
	public string get_commandName() { }

	[NativeMethodAttribute] // RVA: 0x53770 Offset: 0x53871 VA: 0x53770
	// RVA: 0x3C6E470 Offset: 0x3C6E571 VA: 0x3C6E470
	private void Internal_Use() { }

	[FreeFunctionAttribute] // RVA: 0x537B0 Offset: 0x538B1 VA: 0x537B0
	// RVA: 0x3C6E4C0 Offset: 0x3C6E5C1 VA: 0x3C6E4C0
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunctionAttribute] // RVA: 0x53800 Offset: 0x53901 VA: 0x53800
	// RVA: 0x3C6E510 Offset: 0x3C6E611 VA: 0x3C6E510
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0x53850 Offset: 0x53951 VA: 0x53850
	// RVA: 0x3C6E560 Offset: 0x3C6E661 VA: 0x3C6E560
	public EventType GetTypeForControl(int controlID) { }

	// RVA: 0x3C6E5B0 Offset: 0x3C6E6B1 VA: 0x3C6E5B0
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x3C6E600 Offset: 0x3C6E701 VA: 0x3C6E600
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x538A0 Offset: 0x539A1 VA: 0x538A0
	// RVA: 0x3C6E650 Offset: 0x3C6E751 VA: 0x3C6E650
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x3C6E800 Offset: 0x3C6E901 VA: 0x3C6E800
	public void .ctor() { }

	// RVA: 0x3C6E7A0 Offset: 0x3C6E8A1 VA: 0x3C6E7A0
	public void .ctor(int displayIndex) { }

	// RVA: 0x3C6E850 Offset: 0x3C6E951 VA: 0x3C6E850 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3C6E930 Offset: 0x3C6EA31 VA: 0x3C6E930
	public bool get_shift() { }

	// RVA: 0x3C6E980 Offset: 0x3C6EA81 VA: 0x3C6E980
	public bool get_control() { }

	// RVA: 0x3C6E9D0 Offset: 0x3C6EAD1 VA: 0x3C6E9D0
	public bool get_alt() { }

	// RVA: 0x3C6EA20 Offset: 0x3C6EB21 VA: 0x3C6EA20
	public bool get_command() { }

	// RVA: 0x3C6EA70 Offset: 0x3C6EB71 VA: 0x3C6EA70
	public static Event get_current() { }

	// RVA: 0x3C6EAC0 Offset: 0x3C6EBC1 VA: 0x3C6EAC0
	public bool get_isKey() { }

	// RVA: 0x3C6EB10 Offset: 0x3C6EC11 VA: 0x3C6EB10
	public bool get_isMouse() { }

	// RVA: 0x3C6EB80 Offset: 0x3C6EC81 VA: 0x3C6EB80
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x3C6EC20 Offset: 0x3C6ED21 VA: 0x3C6EC20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3C6ED80 Offset: 0x3C6EE81 VA: 0x3C6ED80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3C6F060 Offset: 0x3C6F161 VA: 0x3C6F060 Slot: 3
	public override string ToString() { }

	// RVA: 0x3C6FAD0 Offset: 0x3C6FBD1 VA: 0x3C6FAD0
	public void Use() { }

	// RVA: 0x3C6E140 Offset: 0x3C6E241 VA: 0x3C6E140
	private void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x3C6E1F0 Offset: 0x3C6E2F1 VA: 0x3C6E1F0
	private void get_delta_Injected(out Vector2 ret) { }
}

