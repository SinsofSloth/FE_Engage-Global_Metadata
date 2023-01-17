// Namespace: 
public sealed class MyRoomTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11356
{
	// Methods

	// RVA: 0x26E4510 Offset: 0x26E4611 VA: 0x26E4510
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E4530 Offset: 0x26E4631 VA: 0x26E4530 Slot: 13
	public virtual void Invoke(MyRoomTopMenu.MenuResult result) { }

	// RVA: 0x26E4790 Offset: 0x26E4891 VA: 0x26E4790 Slot: 14
	public virtual IAsyncResult BeginInvoke(MyRoomTopMenu.MenuResult result, AsyncCallback callback, object object) { }

	// RVA: 0x26E4820 Offset: 0x26E4921 VA: 0x26E4820 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class MyRoomTopMenu.RecallSelectMenuItem : BasicMenuItem // TypeDefIndex: 11358
{
	// Fields
	private MyRoomTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26E4830 Offset: 0x26E4931 VA: 0x26E4830
	public void .ctor(MyRoomTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26E4870 Offset: 0x26E4971 VA: 0x26E4870 Slot: 4
	public override string GetName() { }

	// RVA: 0x26E48F0 Offset: 0x26E49F1 VA: 0x26E48F0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26E4900 Offset: 0x26E4A01 VA: 0x26E4900 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26E4930 Offset: 0x26E4A31 VA: 0x26E4930 Slot: 19
	public override BasicMenu.Result BCall() { }
}

