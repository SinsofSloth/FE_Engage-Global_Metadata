// Namespace: 
public enum RelayModeMenu.Result2 // TypeDefIndex: 12888
{
	// Fields
	public int value__; // 0x0
	public const RelayModeMenu.Result2 PlayNew = 0;
	public const RelayModeMenu.Result2 PlayTakeOver = 1;
	public const RelayModeMenu.Result2 Replay = 2;
	public const RelayModeMenu.Result2 End = 3;
}

// Namespace: 
private class RelayModeMenu.MenuItem : BasicMenuItem // TypeDefIndex: 12889
{
	// Fields
	private TextMeshProUGUI m_TitleText; // 0x68
	private TextMeshProUGUI m_CommentText; // 0x70
	private string m_NameLabel; // 0x78
	private string m_CommentLabel; // 0x80
	private Relay.Modes m_Mode; // 0x88

	// Methods

	// RVA: 0x1F3F470 Offset: 0x1F3F571 VA: 0x1F3F470
	public void .ctor(GameObject menuObj, Relay.Modes mode) { }

	// RVA: 0x1F3F6D0 Offset: 0x1F3F7D1 VA: 0x1F3F6D0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F3F740 Offset: 0x1F3F841 VA: 0x1F3F740 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F3F760 Offset: 0x1F3F861 VA: 0x1F3F760 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
private class RelayModeMenu.ReplayMenuItem : RelayModeMenu.MenuItem // TypeDefIndex: 12890
{
	// Methods

	// RVA: 0x1F3F820 Offset: 0x1F3F921 VA: 0x1F3F820
	public void .ctor(GameObject menuObj, Relay.Modes mode) { }
}

