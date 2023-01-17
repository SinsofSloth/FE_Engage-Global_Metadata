// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class DeserializationEventHandler : MulticastDelegate // TypeDefIndex: 985
{
	// Methods

	// RVA: 0x3727D60 Offset: 0x3727E61 VA: 0x3727D60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3727D80 Offset: 0x3727E81 VA: 0x3727D80 Slot: 13
	public virtual void Invoke(object sender) { }

	// RVA: 0x37280E0 Offset: 0x37281E1 VA: 0x37280E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCallback callback, object object) { }

	// RVA: 0x3728110 Offset: 0x3728211 VA: 0x3728110 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

