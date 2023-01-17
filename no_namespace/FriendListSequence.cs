// Namespace: 
private class FriendListSequence.ProcZoom : ProcInst // TypeDefIndex: 13428
{
	// Fields
	private GameObject m_ZoomObject; // 0x70
	private FriendListContent m_FriendListContent; // 0x78
	private Sprite m_Picture; // 0x80
	private bool m_IsPictureS; // 0x88

	// Methods

	// RVA: 0x22E1240 Offset: 0x22E1341 VA: 0x22E1240
	private void Open() { }

	// RVA: 0x22E1520 Offset: 0x22E1621 VA: 0x22E1520
	private void WaitOpen() { }

	// RVA: 0x22E15B0 Offset: 0x22E16B1 VA: 0x22E15B0
	private void Tick() { }

	// RVA: 0x22E17D0 Offset: 0x22E18D1 VA: 0x22E17D0
	private void WaitClose() { }

	// RVA: 0x22E18A0 Offset: 0x22E19A1 VA: 0x22E18A0
	private void End() { }

	// RVA: 0x22E1910 Offset: 0x22E1A11 VA: 0x22E1910
	public static void CreateBindS(ProcInst parent, GameObject zoomObject, Texture2D texture, FriendListContent friendListContent) { }

	// RVA: 0x22E19D0 Offset: 0x22E1AD1 VA: 0x22E19D0
	public static void CreateBind(ProcInst parent, GameObject zoomObject, Sprite picture, bool isPictureS, FriendListContent friendListContent) { }

	// RVA: 0x22E1E60 Offset: 0x22E1F61 VA: 0x22E1E60
	public void .ctor() { }
}

// Namespace: 
private enum FriendListSequence.Label // TypeDefIndex: 13429
{
	// Fields
	public int value__; // 0x0
	public const FriendListSequence.Label Start = 0;
	public const FriendListSequence.Label Load = 1;
	public const FriendListSequence.Label Open = 2;
	public const FriendListSequence.Label Main = 3;
	public const FriendListSequence.Label PreparePageChange = 4;
	public const FriendListSequence.Label PageChange = 5;
	public const FriendListSequence.Label ListCancel = 6;
	public const FriendListSequence.Label Close = 7;
	public const FriendListSequence.Label End = 8;
}

