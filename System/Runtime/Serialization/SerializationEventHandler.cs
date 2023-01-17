// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 986
{
	// Methods

	// RVA: 0x36181E0 Offset: 0x36182E1 VA: 0x36181E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3618200 Offset: 0x3618301 VA: 0x3618200 Slot: 13
	public virtual void Invoke(StreamingContext context) { }

	// RVA: 0x3618460 Offset: 0x3618561 VA: 0x3618460 Slot: 14
	public virtual IAsyncResult BeginInvoke(StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x36184F0 Offset: 0x36185F1 VA: 0x36184F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

