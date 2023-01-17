// Namespace: UnityEngine.Events
internal class InvokableCallList // TypeDefIndex: 3693
{
	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x2F26040 Offset: 0x2F26141 VA: 0x2F26040
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x2F260B0 Offset: 0x2F261B1 VA: 0x2F260B0
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x2F26120 Offset: 0x2F26221 VA: 0x2F26120
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2F262F0 Offset: 0x2F263F1 VA: 0x2F262F0
	public void ClearPersistent() { }

	// RVA: 0x2F26350 Offset: 0x2F26451 VA: 0x2F26350
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2F263E0 Offset: 0x2F264E1 VA: 0x2F263E0
	public void .ctor() { }
}

