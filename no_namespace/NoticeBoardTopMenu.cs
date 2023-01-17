// Namespace: 
public enum NoticeBoardTopMenu.Result2 // TypeDefIndex: 11442
{
	// Fields
	public int value__; // 0x0
	public const NoticeBoardTopMenu.Result2 Investment = 0;
	public const NoticeBoardTopMenu.Result2 SolanelInfo = 1;
	public const NoticeBoardTopMenu.Result2 Achievement = 2;
	public const NoticeBoardTopMenu.Result2 End = 3;
}

// Namespace: 
public sealed class NoticeBoardTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11443
{
	// Methods

	// RVA: 0x1F1B4F0 Offset: 0x1F1B5F1 VA: 0x1F1B4F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1B290 Offset: 0x1F1B391 VA: 0x1F1B290 Slot: 13
	public virtual void Invoke(NoticeBoardTopMenu.Result2 result) { }

	// RVA: 0x1F1B510 Offset: 0x1F1B611 VA: 0x1F1B510 Slot: 14
	public virtual IAsyncResult BeginInvoke(NoticeBoardTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1F1B5A0 Offset: 0x1F1B6A1 VA: 0x1F1B5A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class NoticeBoardTopMenu.InvestmentItem : BasicMenuItem // TypeDefIndex: 11444
{
	// Fields
	private NoticeBoardTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F1B5B0 Offset: 0x1F1B6B1 VA: 0x1F1B5B0
	public void .ctor(NoticeBoardTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1F1B5F0 Offset: 0x1F1B6F1 VA: 0x1F1B5F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F1B670 Offset: 0x1F1B771 VA: 0x1F1B670 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F1B680 Offset: 0x1F1B781 VA: 0x1F1B680 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class NoticeBoardTopMenu.SolanelInfoItem : BasicMenuItem // TypeDefIndex: 11445
{
	// Fields
	private NoticeBoardTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F1B6B0 Offset: 0x1F1B7B1 VA: 0x1F1B6B0
	public void .ctor(NoticeBoardTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1F1B6F0 Offset: 0x1F1B7F1 VA: 0x1F1B6F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F1B770 Offset: 0x1F1B871 VA: 0x1F1B770 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F1B780 Offset: 0x1F1B881 VA: 0x1F1B780 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class NoticeBoardTopMenu.AchievementItem : BasicMenuItem // TypeDefIndex: 11446
{
	// Fields
	private NoticeBoardTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F1B190 Offset: 0x1F1B291 VA: 0x1F1B190
	public void .ctor(NoticeBoardTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1F1B1D0 Offset: 0x1F1B2D1 VA: 0x1F1B1D0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F1B250 Offset: 0x1F1B351 VA: 0x1F1B250 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F1B260 Offset: 0x1F1B361 VA: 0x1F1B260 Slot: 18
	public override BasicMenu.Result ACall() { }
}

