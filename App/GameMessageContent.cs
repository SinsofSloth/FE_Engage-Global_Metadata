// Namespace: App
public class GameMessageContent : MonoBehaviour // TypeDefIndex: 12556
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	public GameObject m_objText; // 0x18
	public GameObject m_objKeyWaitIcon; // 0x20
	public GameObject m_objLoadingIcon; // 0x28
	public Animator m_animator; // 0x30
	protected GameMessage m_proc; // 0x38
	private float m_posX; // 0x40
	private float m_posY; // 0x44

	// Methods

	// RVA: 0x26A8100 Offset: 0x26A8201 VA: 0x26A8100
	public bool IsOpening() { }

	// RVA: 0x26A8300 Offset: 0x26A8401 VA: 0x26A8300
	public bool IsClosing() { }

	// RVA: 0x26A9B40 Offset: 0x26A9C41 VA: 0x26A9B40
	public bool IsClosed() { }

	// RVA: 0x26A8010 Offset: 0x26A8111 VA: 0x26A8010
	public void Open() { }

	// RVA: 0x26A8220 Offset: 0x26A8321 VA: 0x26A8220
	public void Close() { }

	// RVA: 0x26A9BA0 Offset: 0x26A9CA1 VA: 0x26A9BA0
	public void SetProc(GameMessage proc) { }

	// RVA: 0x26A9BB0 Offset: 0x26A9CB1 VA: 0x26A9BB0
	protected TextMeshProUGUI GetTextMeshProComponent() { }

	// RVA: 0x26A7C00 Offset: 0x26A7D01 VA: 0x26A7C00
	public void Build() { }

	// RVA: 0x26A7A60 Offset: 0x26A7B61 VA: 0x26A7A60
	public void Delete() { }

	// RVA: 0x26A9C70 Offset: 0x26A9D71 VA: 0x26A9C70 Slot: 4
	protected virtual float CalcPosX() { }

	// RVA: 0x26A9C80 Offset: 0x26A9D81 VA: 0x26A9C80 Slot: 5
	protected virtual float CalcPosY() { }

	// RVA: 0x26A9C90 Offset: 0x26A9D91 VA: 0x26A9C90 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x26A96D0 Offset: 0x26A97D1 VA: 0x26A96D0
	public void SetShadowOff() { }

	// RVA: 0x26A9810 Offset: 0x26A9911 VA: 0x26A9810
	public void SetPosition(float x, float y) { }

	// RVA: 0x26A9D10 Offset: 0x26A9E11 VA: 0x26A9D10
	public static void LoadPrefabAsync() { }

	// RVA: 0x26A8710 Offset: 0x26A8811 VA: 0x26A8710
	public static GameMessageContent Create() { }

	// RVA: 0x26A9DB0 Offset: 0x26A9EB1 VA: 0x26A9DB0
	public void .ctor() { }

	// RVA: 0x26A9DC0 Offset: 0x26A9EC1 VA: 0x26A9DC0
	private static void .cctor() { }
}

