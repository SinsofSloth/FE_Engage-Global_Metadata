// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 7522
{
	// Methods

	// RVA: 0x1C6D450 Offset: 0x1C6D551 VA: 0x1C6D450
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C6D060 Offset: 0x1C6D161 VA: 0x1C6D060 Slot: 13
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

	// RVA: 0x1C6D470 Offset: 0x1C6D571 VA: 0x1C6D470 Slot: 14
	public virtual IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, object object) { }

	// RVA: 0x1C6D510 Offset: 0x1C6D611 VA: 0x1C6D510 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

