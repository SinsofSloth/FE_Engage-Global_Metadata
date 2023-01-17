// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x472430 Offset: 0x472531 VA: 0x472430
[ClassInterfaceAttribute] // RVA: 0x472430 Offset: 0x472531 VA: 0x472430
[ComDefaultInterfaceAttribute] // RVA: 0x472430 Offset: 0x472531 VA: 0x472430
[Serializable]
public abstract class EventInfo : MemberInfo, _EventInfo // TypeDefIndex: 564
{
	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public abstract EventAttributes Attributes { get; }
	public virtual Type EventHandlerType { get; }
	public bool IsSpecialName { get; }
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract EventAttributes get_Attributes();

	// RVA: 0x3B60270 Offset: 0x3B60371 VA: 0x3B60270 Slot: 17
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x3B602E0 Offset: 0x3B603E1 VA: 0x3B602E0 Slot: 18
	public bool get_IsSpecialName() { }

	// RVA: 0x3B60310 Offset: 0x3B60411 VA: 0x3B60310 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x3B60320 Offset: 0x3B60421 VA: 0x3B60320
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: 0x3B60330 Offset: 0x3B60431 VA: 0x3B60330 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3B60340 Offset: 0x3B60441 VA: 0x3B60340 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3B60350 Offset: 0x3B60451 VA: 0x3B60350
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x3B60390 Offset: 0x3B60491 VA: 0x3B60390
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x3B603F0 Offset: 0x3B604F1 VA: 0x3B603F0
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x3B60400 Offset: 0x3B60501 VA: 0x3B60400
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }
}

