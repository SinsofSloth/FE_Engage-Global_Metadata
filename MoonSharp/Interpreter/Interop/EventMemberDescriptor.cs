// Namespace: MoonSharp.Interpreter.Interop
public class EventMemberDescriptor : IMemberDescriptor // TypeDefIndex: 6110
{
	// Fields
	public const int MAX_ARGS_IN_DELEGATE = 16;
	private object m_Lock; // 0x10
	private MultiDictionary<object, Closure> m_Callbacks; // 0x18
	private Dictionary<object, Delegate> m_Delegates; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE7A0 Offset: 0xE8A1 VA: 0xE7A0
	private EventInfo <EventInfo>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xE7B0 Offset: 0xE8B1 VA: 0xE7B0
	private bool <IsStatic>k__BackingField; // 0x30
	private MethodInfo m_Add; // 0x38
	private MethodInfo m_Remove; // 0x40

	// Properties
	public EventInfo EventInfo { get; set; }
	public bool IsStatic { get; set; }
	public string Name { get; }
	public MemberDescriptorAccess MemberAccess { get; }

	// Methods

	// RVA: 0x3309840 Offset: 0x3309941 VA: 0x3309840
	public static EventMemberDescriptor TryCreateIfVisible(EventInfo ei, InteropAccessMode accessMode) { }

	// RVA: 0x3309A60 Offset: 0x3309B61 VA: 0x3309A60
	public static bool CheckEventIsCompatible(EventInfo ei, bool throwException) { }

	// RVA: 0x330A050 Offset: 0x330A151 VA: 0x330A050
	public void .ctor(EventInfo ei, InteropAccessMode accessMode = 7) { }

	[CompilerGeneratedAttribute] // RVA: 0x107A0 Offset: 0x108A1 VA: 0x107A0
	// RVA: 0x330A320 Offset: 0x330A421 VA: 0x330A320
	public EventInfo get_EventInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x107B0 Offset: 0x108B1 VA: 0x107B0
	// RVA: 0x330A330 Offset: 0x330A431 VA: 0x330A330
	private void set_EventInfo(EventInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x107C0 Offset: 0x108C1 VA: 0x107C0
	// RVA: 0x330A340 Offset: 0x330A441 VA: 0x330A340 Slot: 4
	public bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x107D0 Offset: 0x108D1 VA: 0x107D0
	// RVA: 0x330A350 Offset: 0x330A451 VA: 0x330A350
	private void set_IsStatic(bool value) { }

	// RVA: 0x330A360 Offset: 0x330A461 VA: 0x330A360 Slot: 7
	public DynValue GetValue(Script script, object obj) { }

	// RVA: 0x330A430 Offset: 0x330A531 VA: 0x330A430
	internal DynValue AddCallback(object o, ScriptExecutionContext context, CallbackArguments args) { }

	// RVA: 0x330A790 Offset: 0x330A891 VA: 0x330A790
	internal DynValue RemoveCallback(object o, ScriptExecutionContext context, CallbackArguments args) { }

	// RVA: 0x330A670 Offset: 0x330A771 VA: 0x330A670
	private void RegisterCallback(object o) { }

	// RVA: 0x330A9D0 Offset: 0x330AAD1 VA: 0x330A9D0
	private void UnregisterCallback(object o) { }

	// RVA: 0x330ABA0 Offset: 0x330ACA1 VA: 0x330ABA0
	private Delegate CreateDelegate(object sender) { }

	// RVA: 0x330B240 Offset: 0x330B341 VA: 0x330B240
	private void DispatchEvent(object sender, object o01, object o02, object o03, object o04, object o05, object o06, object o07, object o08, object o09, object o10, object o11, object o12, object o13, object o14, object o15, object o16) { }

	// RVA: 0x330B7D0 Offset: 0x330B8D1 VA: 0x330B7D0 Slot: 5
	public string get_Name() { }

	// RVA: 0x330B7E0 Offset: 0x330B8E1 VA: 0x330B7E0 Slot: 6
	public MemberDescriptorAccess get_MemberAccess() { }

	// RVA: 0x330B7F0 Offset: 0x330B8F1 VA: 0x330B7F0 Slot: 8
	public void SetValue(Script script, object obj, DynValue v) { }
}

