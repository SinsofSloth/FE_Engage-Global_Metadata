// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x4721C0 Offset: 0x4722C1 VA: 0x4721C0
[Serializable]
public sealed class TypeFilter : MulticastDelegate // TypeDefIndex: 551
{
	// Methods

	// RVA: 0x36420C0 Offset: 0x36421C1 VA: 0x36420C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x36420E0 Offset: 0x36421E1 VA: 0x36420E0 Slot: 13
	public virtual bool Invoke(Type m, object filterCriteria) { }

	// RVA: 0x3642460 Offset: 0x3642561 VA: 0x3642460 Slot: 14
	public virtual IAsyncResult BeginInvoke(Type m, object filterCriteria, AsyncCallback callback, object object) { }

	// RVA: 0x3642490 Offset: 0x3642591 VA: 0x3642490 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

