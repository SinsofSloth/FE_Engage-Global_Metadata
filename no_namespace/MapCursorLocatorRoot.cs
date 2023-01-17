// Namespace: 
private enum MapCursorLocatorRoot.PartType // TypeDefIndex: 7617
{
	// Fields
	public int value__; // 0x0
	public const MapCursorLocatorRoot.PartType MapCursor1 = 0;
	public const MapCursorLocatorRoot.PartType MapCursor2 = 1;
	public const MapCursorLocatorRoot.PartType MapCursor3 = 2;
	public const MapCursorLocatorRoot.PartType MapCursor4 = 3;
	public const MapCursorLocatorRoot.PartType LockRoot1 = 4;
	public const MapCursorLocatorRoot.PartType LockRoot2 = 5;
	public const MapCursorLocatorRoot.PartType LockRoot3 = 6;
	public const MapCursorLocatorRoot.PartType LockRoot4 = 7;
	public const MapCursorLocatorRoot.PartType Num = 8;
}

// Namespace: 
public class MapCursorLocatorRoot : MonoBehaviour // TypeDefIndex: 7618
{
	// Fields
	[SerializeField] // RVA: 0x27AEB0 Offset: 0x27AFB1 VA: 0x27AEB0
	[SpaceAttribute] // RVA: 0x27AEB0 Offset: 0x27AFB1 VA: 0x27AEB0
	[HeaderAttribute] // RVA: 0x27AEB0 Offset: 0x27AFB1 VA: 0x27AEB0
	private Transform m_MapCursor1; // 0x18
	[SerializeField] // RVA: 0x27AF10 Offset: 0x27B011 VA: 0x27AF10
	private Transform m_MapCursor2; // 0x20
	[SerializeField] // RVA: 0x27AF20 Offset: 0x27B021 VA: 0x27AF20
	private Transform m_MapCursor3; // 0x28
	[SerializeField] // RVA: 0x27AF30 Offset: 0x27B031 VA: 0x27AF30
	private Transform m_MapCursor4; // 0x30
	[SpaceAttribute] // RVA: 0x27AF40 Offset: 0x27B041 VA: 0x27AF40
	[SerializeField] // RVA: 0x27AF40 Offset: 0x27B041 VA: 0x27AF40
	private Transform m_LockRoot1; // 0x38
	[SerializeField] // RVA: 0x27AF80 Offset: 0x27B081 VA: 0x27AF80
	private Transform m_LockRoot2; // 0x40
	[SerializeField] // RVA: 0x27AF90 Offset: 0x27B091 VA: 0x27AF90
	private Transform m_LockRoot3; // 0x48
	[SerializeField] // RVA: 0x27AFA0 Offset: 0x27B0A1 VA: 0x27AFA0
	private Transform m_LockRoot4; // 0x50
	[SpaceAttribute] // RVA: 0x27AFB0 Offset: 0x27B0B1 VA: 0x27AFB0
	[SerializeField] // RVA: 0x27AFB0 Offset: 0x27B0B1 VA: 0x27AFB0
	private Transform m_LockCursor1; // 0x58
	[SerializeField] // RVA: 0x27AFF0 Offset: 0x27B0F1 VA: 0x27AFF0
	private Transform m_LockCursor2; // 0x60
	[SerializeField] // RVA: 0x27B000 Offset: 0x27B101 VA: 0x27B000
	private Transform m_LockCursor3; // 0x68
	[SerializeField] // RVA: 0x27B010 Offset: 0x27B111 VA: 0x27B010
	private Transform m_LockCursor4; // 0x70
	private GameObject[] m_MapCursors; // 0x78
	private MapCursorColor[] m_Colors; // 0x80
	private Vector3[] m_OrigPos; // 0x88
	private int m_SizeX; // 0x90
	private int m_SizeZ; // 0x94
	private int m_CursorCount; // 0x98
	private const int MOVE_CURSOR_FRAME = 12;

	// Methods

	// RVA: 0x2CB1DE0 Offset: 0x2CB1EE1 VA: 0x2CB1DE0
	private void Awake() { }

	// RVA: 0x2CB2620 Offset: 0x2CB2721 VA: 0x2CB2620
	private void OnDestroy() { }

	// RVA: 0x2CB1E20 Offset: 0x2CB1F21 VA: 0x2CB1E20
	private void GetGameObject() { }

	// RVA: 0x2CB20E0 Offset: 0x2CB21E1 VA: 0x2CB20E0
	private void GetMapCursorColor() { }

	// RVA: 0x2CB23B0 Offset: 0x2CB24B1 VA: 0x2CB23B0
	private void GetOrigPos() { }

	// RVA: 0x2CA0B70 Offset: 0x2CA0C71 VA: 0x2CA0B70
	public void InitMapCursor() { }

	// RVA: 0x2C9F410 Offset: 0x2C9F511 VA: 0x2C9F410
	public void ScaleCursor(int frame = 12) { }

	// RVA: 0x2CB2660 Offset: 0x2CB2761 VA: 0x2CB2660
	private bool IsScaleCursor() { }

	// RVA: 0x2CAE530 Offset: 0x2CAE631 VA: 0x2CAE530
	public void SetColor(Color color) { }

	// RVA: 0x2CB27A0 Offset: 0x2CB28A1 VA: 0x2CB27A0
	public void .ctor() { }
}

