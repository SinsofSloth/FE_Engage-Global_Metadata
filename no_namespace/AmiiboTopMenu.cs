// Namespace: 
public enum AmiiboTopMenu.MenuResult // TypeDefIndex: 10418
{
	// Fields
	public int value__; // 0x0
	public const AmiiboTopMenu.MenuResult Amiibo = 0;
	public const AmiiboTopMenu.MenuResult Accessory = 1;
	public const AmiiboTopMenu.MenuResult Sound = 2;
	public const AmiiboTopMenu.MenuResult End = 3;
}

// Namespace: 
private class AmiiboTopMenu.AmiiboMenuItem : BasicMenuItem // TypeDefIndex: 10420
{
	// Fields
	private GameObject m_AmiiboHelpMenu; // 0x68
	private AmiiboTopMenu.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x1F5CF60 Offset: 0x1F5D061 VA: 0x1F5CF60
	public void .ctor(AmiiboTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1F5CFA0 Offset: 0x1F5D0A1 VA: 0x1F5CFA0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F5D020 Offset: 0x1F5D121 VA: 0x1F5D020
	public bool CanReadAmiibo() { }

	// RVA: 0x1F5D200 Offset: 0x1F5D301 VA: 0x1F5D200 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F5D5D0 Offset: 0x1F5D6D1 VA: 0x1F5D5D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F5D620 Offset: 0x1F5D721 VA: 0x1F5D620 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1F5D630 Offset: 0x1F5D731 VA: 0x1F5D630 Slot: 15
	public override void OnClose() { }
}

// Namespace: 
private class AmiiboTopMenu.SoundMenuItem : BasicMenuItem // TypeDefIndex: 10422
{
	// Fields
	private AmiiboTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F5D770 Offset: 0x1F5D871 VA: 0x1F5D770
	public void .ctor(AmiiboTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1F5D7B0 Offset: 0x1F5D8B1 VA: 0x1F5D7B0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F5D830 Offset: 0x1F5D931 VA: 0x1F5D830 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F5D840 Offset: 0x1F5D941 VA: 0x1F5D840 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F5D870 Offset: 0x1F5D971 VA: 0x1F5D870 Slot: 19
	public override BasicMenu.Result BCall() { }
}

