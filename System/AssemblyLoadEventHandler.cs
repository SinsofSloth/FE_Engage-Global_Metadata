// Namespace: System
[ComVisibleAttribute] // RVA: 0x470FF0 Offset: 0x4710F1 VA: 0x470FF0
[Serializable]
public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 351
{
	// Methods

	// RVA: 0x3567190 Offset: 0x3567291 VA: 0x3567190
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x355D6A0 Offset: 0x355D7A1 VA: 0x355D6A0 Slot: 13
	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

	// RVA: 0x35671B0 Offset: 0x35672B1 VA: 0x35671B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, AssemblyLoadEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x35671E0 Offset: 0x35672E1 VA: 0x35671E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

