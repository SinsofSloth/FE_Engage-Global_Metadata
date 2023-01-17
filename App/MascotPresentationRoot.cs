// Namespace: App
public class MascotPresentationRoot // TypeDefIndex: 10870
{
	// Fields
	public GameObject Root; // 0x10
	public GameObject MascotRoot; // 0x18
	public GameObject PlayerRoot; // 0x20
	public GameObject CameraRoot; // 0x28
	public Transform PlayerReserveRoot; // 0x30
	public Vector3 PlayerReservePosition; // 0x38
	public float PlayerReserveRotationY; // 0x44
	public Transform MascotReserveRoot; // 0x48
	public Vector3 MascotReservePosition; // 0x50
	public Quaternion MascotReserveRotation; // 0x5C
	public Transform CameraReserveRoot; // 0x70
	private bool m_Apply; // 0x78

	// Properties
	private HubPlayerController PlayerController { get; }
	private HubMascotController MascotController { get; }

	// Methods

	// RVA: 0x2855F70 Offset: 0x2856071 VA: 0x2855F70
	public void Setup(GameObject root) { }

	// RVA: 0x2851D50 Offset: 0x2851E51 VA: 0x2851D50
	public void Apply() { }

	// RVA: 0x2852820 Offset: 0x2852921 VA: 0x2852820
	public void Revert() { }

	// RVA: 0x285A2B0 Offset: 0x285A3B1 VA: 0x285A2B0
	private HubPlayerController get_PlayerController() { }

	// RVA: 0x285A2C0 Offset: 0x285A3C1 VA: 0x285A2C0
	private HubMascotController get_MascotController() { }

	// RVA: 0x2851B20 Offset: 0x2851C21 VA: 0x2851B20
	public static Vector3 GetLocation() { }

	// RVA: 0x2851C90 Offset: 0x2851D91 VA: 0x2851C90
	public static Quaternion GetRotation() { }

	// RVA: 0x285A0B0 Offset: 0x285A1B1 VA: 0x285A0B0
	public void .ctor() { }
}

