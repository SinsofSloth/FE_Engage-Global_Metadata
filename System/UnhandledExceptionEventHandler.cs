// Namespace: System
[ComVisibleAttribute] // RVA: 0x470EC0 Offset: 0x470FC1 VA: 0x470EC0
[Serializable]
public sealed class UnhandledExceptionEventHandler : MulticastDelegate // TypeDefIndex: 334
{
	// Methods

	// RVA: 0x3651A60 Offset: 0x3651B61 VA: 0x3651A60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3651A80 Offset: 0x3651B81 VA: 0x3651A80 Slot: 13
	public virtual void Invoke(object sender, UnhandledExceptionEventArgs e) { }

	// RVA: 0x3651DF0 Offset: 0x3651EF1 VA: 0x3651DF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UnhandledExceptionEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3651E20 Offset: 0x3651F21 VA: 0x3651E20 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

