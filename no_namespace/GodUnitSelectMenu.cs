// Namespace: 
public sealed class GodUnitSelectMenu.SelectEventHandler : MulticastDelegate // TypeDefIndex: 11733
{
	// Methods

	// RVA: 0x1FA45E0 Offset: 0x1FA46E1 VA: 0x1FA45E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FA4600 Offset: 0x1FA4701 VA: 0x1FA4600 Slot: 13
	public virtual void Invoke(GodUnit god, RingCleaningSequence.GodType optionalType) { }

	// RVA: 0x1FA4970 Offset: 0x1FA4A71 VA: 0x1FA4970 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodUnit god, RingCleaningSequence.GodType optionalType, AsyncCallback callback, object object) { }

	// RVA: 0x1FA4A10 Offset: 0x1FA4B11 VA: 0x1FA4A10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

