// Namespace: App
public class GmapSpotController : MonoBehaviour // TypeDefIndex: 10344
{
	// Fields
	[HeaderAttribute] // RVA: 0x28DDE0 Offset: 0x28DEE1 VA: 0x28DDE0
	[SerializeField] // RVA: 0x28DDE0 Offset: 0x28DEE1 VA: 0x28DDE0
	private MeshRenderer m_StandMeshRenderer; // 0x18
	[SerializeField] // RVA: 0x28DE30 Offset: 0x28DF31 VA: 0x28DE30
	private MeshRenderer m_StoneMeshRenderer; // 0x20
	[SerializeField] // RVA: 0x28DE40 Offset: 0x28DF41 VA: 0x28DE40
	[HeaderAttribute] // RVA: 0x28DE40 Offset: 0x28DF41 VA: 0x28DE40
	private List<Material> m_Materials; // 0x28
	[SerializeField] // RVA: 0x28DE90 Offset: 0x28DF91 VA: 0x28DE90
	private MeshRenderer m_MeshRenderer; // 0x30
	private GmapSpot m_Spot; // 0x38
	public static readonly string NextSpotEffectPath; // 0x0
	private GameObject m_Effect; // 0x40
	private bool m_IsInitialized; // 0x48
	private InterpolatorColor m_StandEmissionColor; // 0x50
	private InterpolatorColor m_StoneEmissionColor; // 0x58

	// Methods

	// RVA: 0x2CF3F60 Offset: 0x2CF4061 VA: 0x2CF3F60
	private void Start() { }

	// RVA: 0x2CF4130 Offset: 0x2CF4231 VA: 0x2CF4130
	public void Initialize() { }

	// RVA: 0x2CF19C0 Offset: 0x2CF1AC1 VA: 0x2CF19C0
	public bool StartAppear() { }

	// RVA: 0x2CF1BC0 Offset: 0x2CF1CC1 VA: 0x2CF1BC0
	public bool AppearTick() { }

	// RVA: 0x2CF0C30 Offset: 0x2CF0D31 VA: 0x2CF0C30
	public void UpdateSpotColor() { }

	// RVA: 0x2CF4140 Offset: 0x2CF4241 VA: 0x2CF4140
	private void SetMaterial(GmapSpotController.Type type) { }

	// RVA: 0x2CF4050 Offset: 0x2CF4151 VA: 0x2CF4050
	private void AdjustPos() { }

	// RVA: 0x2CF41E0 Offset: 0x2CF42E1 VA: 0x2CF41E0
	public void .ctor() { }

	// RVA: 0x2CF4290 Offset: 0x2CF4391 VA: 0x2CF4290
	private static void .cctor() { }
}

