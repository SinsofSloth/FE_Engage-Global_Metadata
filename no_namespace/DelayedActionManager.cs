// Namespace: 
private struct DelayedActionManager.DelegateInfo // TypeDefIndex: 5555
{
	// Fields
	private static int s_Id; // 0x0
	private int m_Id; // 0x0
	private Delegate m_Delegate; // 0x8
	private object[] m_Target; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x72610 Offset: 0x72711 VA: 0x72610
	private float <InvocationTime>k__BackingField; // 0x18

	// Properties
	public float InvocationTime { get; set; }

	// Methods

	// RVA: 0x3629840 Offset: 0x3629941 VA: 0x3629840
	public void .ctor(Delegate d, float invocationTime, object[] p) { }

	[IsReadOnlyAttribute] // RVA: 0x72DF0 Offset: 0x72EF1 VA: 0x72DF0
	[CompilerGeneratedAttribute] // RVA: 0x72DF0 Offset: 0x72EF1 VA: 0x72DF0
	// RVA: 0x3638E80 Offset: 0x3638F81 VA: 0x3638E80
	public float get_InvocationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x72E30 Offset: 0x72F31 VA: 0x72E30
	// RVA: 0x3638E90 Offset: 0x3638F91 VA: 0x3638E90
	private void set_InvocationTime(float value) { }

	// RVA: 0x3638EA0 Offset: 0x3638FA1 VA: 0x3638EA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3629EE0 Offset: 0x3629FE1 VA: 0x3629EE0
	public void Invoke() { }
}

