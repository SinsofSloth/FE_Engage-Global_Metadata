// Namespace: 
public class MapPointerLocatorRoot : MonoBehaviour // TypeDefIndex: 7620
{
	// Fields
	[SerializeField] // RVA: 0x27B060 Offset: 0x27B161 VA: 0x27B060
	[HeaderAttribute] // RVA: 0x27B060 Offset: 0x27B161 VA: 0x27B060
	[SpaceAttribute] // RVA: 0x27B060 Offset: 0x27B161 VA: 0x27B060
	private Transform m_Pointer; // 0x18
	[SerializeField] // RVA: 0x27B0C0 Offset: 0x27B1C1 VA: 0x27B0C0
	private Transform m_Attack; // 0x20
	[SerializeField] // RVA: 0x27B0D0 Offset: 0x27B1D1 VA: 0x27B0D0
	private Transform m_Rod; // 0x28
	[SerializeField] // RVA: 0x27B0E0 Offset: 0x27B1E1 VA: 0x27B0E0
	private Transform m_Dance; // 0x30
	[SerializeField] // RVA: 0x27B0F0 Offset: 0x27B1F1 VA: 0x27B0F0
	private Transform m_Cannon; // 0x38
	private MapCursorColor m_Color; // 0x40

	// Properties
	public Transform Pointer { get; }
	public Transform Attack { get; }
	public Transform Rod { get; }
	public Transform Dance { get; }
	public Transform Cannon { get; }

	// Methods

	// RVA: 0x278C2A0 Offset: 0x278C3A1 VA: 0x278C2A0
	private void Awake() { }

	// RVA: 0x278C310 Offset: 0x278C411 VA: 0x278C310
	private void GetMapCursorColor() { }

	// RVA: 0x278C380 Offset: 0x278C481 VA: 0x278C380
	public void SetColor(Color color) { }

	// RVA: 0x278C390 Offset: 0x278C491 VA: 0x278C390
	public Transform get_Pointer() { }

	// RVA: 0x278C3A0 Offset: 0x278C4A1 VA: 0x278C3A0
	public Transform get_Attack() { }

	// RVA: 0x278C3B0 Offset: 0x278C4B1 VA: 0x278C3B0
	public Transform get_Rod() { }

	// RVA: 0x278C3C0 Offset: 0x278C4C1 VA: 0x278C3C0
	public Transform get_Dance() { }

	// RVA: 0x278C3D0 Offset: 0x278C4D1 VA: 0x278C3D0
	public Transform get_Cannon() { }

	// RVA: 0x278C3E0 Offset: 0x278C4E1 VA: 0x278C3E0
	public void .ctor() { }
}

