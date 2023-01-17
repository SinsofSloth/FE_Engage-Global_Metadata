// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCall : ISerializationCallbackReceiver // TypeDefIndex: 3691
{
	// Fields
	[SerializeField] // RVA: 0x4441C0 Offset: 0x4442C1 VA: 0x4441C0
	[FormerlySerializedAsAttribute] // RVA: 0x4441C0 Offset: 0x4442C1 VA: 0x4441C0
	private Object m_Target; // 0x10
	[SerializeField] // RVA: 0x444210 Offset: 0x444311 VA: 0x444210
	private string m_TargetAssemblyTypeName; // 0x18
	[SerializeField] // RVA: 0x444220 Offset: 0x444321 VA: 0x444220
	[FormerlySerializedAsAttribute] // RVA: 0x444220 Offset: 0x444321 VA: 0x444220
	private string m_MethodName; // 0x20
	[SerializeField] // RVA: 0x444270 Offset: 0x444371 VA: 0x444270
	[FormerlySerializedAsAttribute] // RVA: 0x444270 Offset: 0x444371 VA: 0x444270
	private PersistentListenerMode m_Mode; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x4442C0 Offset: 0x4443C1 VA: 0x4442C0
	[SerializeField] // RVA: 0x4442C0 Offset: 0x4443C1 VA: 0x4442C0
	private ArgumentCache m_Arguments; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x444310 Offset: 0x444411 VA: 0x444310
	[FormerlySerializedAsAttribute] // RVA: 0x444310 Offset: 0x444411 VA: 0x444310
	[SerializeField] // RVA: 0x444310 Offset: 0x444411 VA: 0x444310
	private UnityEventCallState m_CallState; // 0x38

	// Properties
	public Object target { get; }
	public string targetAssemblyTypeName { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x348E990 Offset: 0x348EA91 VA: 0x348E990
	public Object get_target() { }

	// RVA: 0x348E9A0 Offset: 0x348EAA1 VA: 0x348E9A0
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x348EB30 Offset: 0x348EC31 VA: 0x348EB30
	public string get_methodName() { }

	// RVA: 0x348EB40 Offset: 0x348EC41 VA: 0x348EB40
	public PersistentListenerMode get_mode() { }

	// RVA: 0x348EB50 Offset: 0x348EC51 VA: 0x348EB50
	public ArgumentCache get_arguments() { }

	// RVA: 0x348EB60 Offset: 0x348EC61 VA: 0x348EB60
	public bool IsValid() { }

	// RVA: 0x348EBC0 Offset: 0x348ECC1 VA: 0x348EBC0
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x348EF60 Offset: 0x348F061 VA: 0x348EF60
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x348F4C0 Offset: 0x348F5C1 VA: 0x348F4C0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x348F500 Offset: 0x348F601 VA: 0x348F500 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x348F540 Offset: 0x348F641 VA: 0x348F540
	public void .ctor() { }
}

