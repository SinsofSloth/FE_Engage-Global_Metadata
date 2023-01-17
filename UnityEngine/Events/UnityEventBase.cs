// Namespace: UnityEngine.Events
[UsedByNativeCodeAttribute] // RVA: 0x43F8D0 Offset: 0x43F9D1 VA: 0x43F8D0
[Serializable]
public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3694
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x4443D0 Offset: 0x4444D1 VA: 0x4443D0
	[SerializeField] // RVA: 0x4443D0 Offset: 0x4444D1 VA: 0x4443D0
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x384B0D0 Offset: 0x384B1D1 VA: 0x384B0D0
	protected void .ctor() { }

	// RVA: 0x384B790 Offset: 0x384B891 VA: 0x384B790 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x384B7A0 Offset: 0x384B8A1 VA: 0x384B7A0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x384B800 Offset: 0x384B901 VA: 0x384B800
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x384BA40 Offset: 0x384BB41 VA: 0x384BA40
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x384B7D0 Offset: 0x384B8D1 VA: 0x384B7D0
	private void DirtyPersistentCalls() { }

	// RVA: 0x384BD20 Offset: 0x384BE21 VA: 0x384BD20
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x384B280 Offset: 0x384B381 VA: 0x384B280
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x384B2D0 Offset: 0x384B3D1 VA: 0x384B2D0
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x384B750 Offset: 0x384B851 VA: 0x384B750
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x384BD60 Offset: 0x384BE61 VA: 0x384BD60 Slot: 3
	public override string ToString() { }

	// RVA: 0x384B350 Offset: 0x384B451 VA: 0x384B350
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }
}

