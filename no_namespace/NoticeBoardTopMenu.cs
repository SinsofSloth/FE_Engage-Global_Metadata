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

