// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x471D20 Offset: 0x471E21 VA: 0x471D20
[Serializable]
public sealed class MemberFilter : MulticastDelegate // TypeDefIndex: 532
{
	// Methods

	// RVA: 0x34E7130 Offset: 0x34E7231 VA: 0x34E7130
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x34E7150 Offset: 0x34E7251 VA: 0x34E7150 Slot: 13
	public virtual bool Invoke(MemberInfo m, object filterCriteria) { }

	// RVA: 0x34E74D0 Offset: 0x34E75D1 VA: 0x34E74D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(MemberInfo m, object filterCriteria, AsyncCallback callback, object object) { }

	// RVA: 0x34E7500 Offset: 0x34E7601 VA: 0x34E7500 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

