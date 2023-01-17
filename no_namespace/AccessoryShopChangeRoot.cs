// Namespace: 
public sealed class AccessoryShopChangeRoot.ReturnEventHandler : MulticastDelegate // TypeDefIndex: 10908
{
	// Methods

	// RVA: 0x24AA840 Offset: 0x24AA941 VA: 0x24AA840
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24AA860 Offset: 0x24AA961 VA: 0x24AA860 Slot: 13
	public virtual void Invoke(Unit unit, bool changed) { }

	// RVA: 0x24AABD0 Offset: 0x24AACD1 VA: 0x24AABD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, bool changed, AsyncCallback callback, object object) { }

	// RVA: 0x24AAC70 Offset: 0x24AAD71 VA: 0x24AAC70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

