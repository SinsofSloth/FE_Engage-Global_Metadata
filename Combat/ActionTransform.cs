// Namespace: Combat
internal sealed class ActionTransform : ActionBase // TypeDefIndex: 8443
{
	// Fields
	private bool m_DoPlayer; // 0x28
	private bool m_DoEnemy; // 0x29
	private ActionTransform.State m_State; // 0x2C
	private IDisposable m_Coroutine; // 0x30

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EC9590 Offset: 0x2EC9691 VA: 0x2EC9590 Slot: 5
	public override string get_Name() { }

	// RVA: 0x2EC95E0 Offset: 0x2EC96E1 VA: 0x2EC95E0
	public void .ctor(bool doPlayer, bool doEnemy) { }

	// RVA: 0x2EC96D0 Offset: 0x2EC97D1 VA: 0x2EC96D0 Slot: 7
	public override void OnUpdate() { }

	// RVA: 0x2EC97D0 Offset: 0x2EC98D1 VA: 0x2EC97D0 Slot: 10
	public override void Dispose() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8670 Offset: 0x2A8771 VA: 0x2A8670
	// RVA: 0x2EC9890 Offset: 0x2EC9991 VA: 0x2EC9890
	private IEnumerator Transform() { }
}

