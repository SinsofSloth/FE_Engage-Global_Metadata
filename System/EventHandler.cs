// Namespace: System
[ComVisibleAttribute] // RVA: 0x470120 Offset: 0x470221 VA: 0x470120
[Serializable]
public sealed class EventHandler : MulticastDelegate // TypeDefIndex: 215
{
	// Methods

	// RVA: 0x3B5FEA0 Offset: 0x3B5FFA1 VA: 0x3B5FEA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3B5FEC0 Offset: 0x3B5FFC1 VA: 0x3B5FEC0 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0x3B60230 Offset: 0x3B60331 VA: 0x3B60230 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3B60260 Offset: 0x3B60361 VA: 0x3B60260 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

