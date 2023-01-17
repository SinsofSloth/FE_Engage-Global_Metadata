// Namespace: App
public class PhotographHaveAnimatorController : MonoBehaviour // TypeDefIndex: 11486
{
	// Fields
	[SerializeField] // RVA: 0x298700 Offset: 0x298801 VA: 0x298700
	private List<RuntimeAnimatorController> m_AnimatorController; // 0x18
	[SerializeField] // RVA: 0x298710 Offset: 0x298811 VA: 0x298710
	[RangeAttribute] // RVA: 0x298710 Offset: 0x298811 VA: 0x298710
	private float m_AnimeTime; // 0x20
	private PhotographHaveAnimatorController.UpdateAnime m_Update; // 0x28
	private PhotographHaveAnimatorController.UpdateFaceAnime m_FaceUpdate; // 0x30
	[SerializeField] // RVA: 0x298750 Offset: 0x298851 VA: 0x298750
	private PhotographHaveAnimatorController.FaceAnime m_faceAnime; // 0x38
	private PhotographHaveAnimatorController.FaceAnime m_BeforeFaceAnime; // 0x3C
	[SerializeField] // RVA: 0x298760 Offset: 0x298861 VA: 0x298760
	private Sprite m_Sprite; // 0x40

	// Properties
	public List<RuntimeAnimatorController> AnimatorController { get; }
	public float AnimeTime { get; }

	// Methods

	// RVA: 0x2A324A0 Offset: 0x2A325A1 VA: 0x2A324A0
	public List<RuntimeAnimatorController> get_AnimatorController() { }

	// RVA: 0x2A324B0 Offset: 0x2A325B1 VA: 0x2A324B0
	public float get_AnimeTime() { }

	// RVA: 0x2A324C0 Offset: 0x2A325C1 VA: 0x2A324C0
	public void SetUpdate(PhotographHaveAnimatorController.UpdateAnime update, PhotographHaveAnimatorController.UpdateFaceAnime faceAnime) { }

	// RVA: 0x2A32500 Offset: 0x2A32601 VA: 0x2A32500
	private void Update() { }

	// RVA: 0x2A325D0 Offset: 0x2A326D1 VA: 0x2A325D0
	public Sprite GetSprite() { }

	// RVA: 0x2A325E0 Offset: 0x2A326E1 VA: 0x2A325E0
	public void .ctor() { }
}

