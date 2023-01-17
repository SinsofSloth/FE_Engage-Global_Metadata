// Namespace: 
public sealed class AccessoryShopChangeMenu.RequestCloseEventHandler : MulticastDelegate // TypeDefIndex: 10903
{
	// Methods

	// RVA: 0x24AA5C0 Offset: 0x24AA6C1 VA: 0x24AA5C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24AA5E0 Offset: 0x24AA6E1 VA: 0x24AA5E0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x24AA7F0 Offset: 0x24AA8F1 VA: 0x24AA7F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x24AA820 Offset: 0x24AA921 VA: 0x24AA820 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class AccessoryShopChangeMenu.ChangeKindEventHandler : MulticastDelegate // TypeDefIndex: 10904
{
	// Methods

	// RVA: 0x24AA200 Offset: 0x24AA301 VA: 0x24AA200
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24AA220 Offset: 0x24AA321 VA: 0x24AA220 Slot: 13
	public virtual void Invoke(AccessoryData accessoryData) { }

	// RVA: 0x24AA580 Offset: 0x24AA681 VA: 0x24AA580 Slot: 14
	public virtual IAsyncResult BeginInvoke(AccessoryData accessoryData, AsyncCallback callback, object object) { }

	// RVA: 0x24AA5B0 Offset: 0x24AA6B1 VA: 0x24AA5B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

