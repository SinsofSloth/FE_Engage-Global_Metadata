// Namespace: App
[ExecuteInEditMode] // RVA: 0x276F90 Offset: 0x277091 VA: 0x276F90
[Serializable]
public abstract class WaypointSync : MonoBehaviour // TypeDefIndex: 10563
{
	// Fields
	public GameObject m_TargetAsset; // 0x18
	private GameObject _pastTargetAsset; // 0x20
	private static double waitTime; // 0x0
	[SerializeField] // RVA: 0x28F5B0 Offset: 0x28F6B1 VA: 0x28F5B0
	private WaypointSync.Relative[] m_relatives; // 0x28
	private CinemachineSmoothPath m_TargetPath; // 0x30
	private CinemachineSmoothPath m_RecieverPath; // 0x38

	// Methods

	// RVA: 0x26C9E80 Offset: 0x26C9F81 VA: 0x26C9E80
	private void Init() { }

	// RVA: 0x26C9F00 Offset: 0x26CA001 VA: 0x26C9F00
	private void OnEnable() { }

	// RVA: 0x26C9F10 Offset: 0x26CA011 VA: 0x26C9F10
	private void OnValidate() { }

	// RVA: 0x26CA150 Offset: 0x26CA251 VA: 0x26CA150
	private void Update() { }

	// RVA: 0x26CA160 Offset: 0x26CA261 VA: 0x26CA160
	private void OnDestroy() { }

	// RVA: 0x26CA1C0 Offset: 0x26CA2C1 VA: 0x26CA1C0
	protected void .ctor() { }

	// RVA: 0x26CA230 Offset: 0x26CA331 VA: 0x26CA230
	private static void .cctor() { }
}

