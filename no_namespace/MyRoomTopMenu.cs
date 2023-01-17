// Namespace: 
public enum MyRoomTopMenu.MenuResult // TypeDefIndex: 11355
{
	// Fields
	public int value__; // 0x0
	public const MyRoomTopMenu.MenuResult Sleep = 0;
	public const MyRoomTopMenu.MenuResult Recall = 1;
	public const MyRoomTopMenu.MenuResult SetDifficulty = 2;
	public const MyRoomTopMenu.MenuResult End = 3;
}

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
private class MyRoomTopMenu.SleepSelectMenuItem : BasicMenuItem // TypeDefIndex: 11357
{
	// Fields
	private MyRoomTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26E4A50 Offset: 0x26E4B51 VA: 0x26E4A50
	public void .ctor(MyRoomTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26E4A90 Offset: 0x26E4B91 VA: 0x26E4A90 Slot: 4
	public override string GetName() { }

	// RVA: 0x26E4B10 Offset: 0x26E4C11 VA: 0x26E4B10 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26E4B20 Offset: 0x26E4C21 VA: 0x26E4B20 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26E4B50 Offset: 0x26E4C51 VA: 0x26E4B50 Slot: 19
	public override BasicMenu.Result BCall() { }
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

// Namespace: 
private class MyRoomTopMenu.SetDifficultySelectMenuItem : BasicMenuItem // TypeDefIndex: 11359
{
	// Fields
	private MyRoomTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26E4940 Offset: 0x26E4A41 VA: 0x26E4940
	public void .ctor(MyRoomTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26E4980 Offset: 0x26E4A81 VA: 0x26E4980 Slot: 4
	public override string GetName() { }

	// RVA: 0x26E4A00 Offset: 0x26E4B01 VA: 0x26E4A00 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26E4A10 Offset: 0x26E4B11 VA: 0x26E4A10 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26E4A40 Offset: 0x26E4B41 VA: 0x26E4A40 Slot: 19
	public override BasicMenu.Result BCall() { }
}

