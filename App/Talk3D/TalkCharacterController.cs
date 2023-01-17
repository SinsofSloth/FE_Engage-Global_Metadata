// Namespace: App.Talk3D
public class TalkCharacterController : MonoBehaviour // TypeDefIndex: 14113
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29D940 Offset: 0x29DA41 VA: 0x29D940
	[SerializeField] // RVA: 0x29D940 Offset: 0x29DA41 VA: 0x29D940
	private string <Pid>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29D980 Offset: 0x29DA81 VA: 0x29D980
	private string <LocationNameProxy>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29D990 Offset: 0x29DA91 VA: 0x29D990
	private string <DefaultBodyAnime>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29D9A0 Offset: 0x29DAA1 VA: 0x29D9A0
	private bool <DisabledAnime>k__BackingField; // 0x30
	private TalkCharacterController.FadeType m_FadeType; // 0x34
	private float m_FadeTimeTo; // 0x38
	private float m_FadeTimer; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x29D9B0 Offset: 0x29DAB1 VA: 0x29D9B0
	private Character <Character>k__BackingField; // 0x40
	private Queue<ValueTuple<string, float>> m_AnimQueue; // 0x48
	private string m_CurrentAnimeName; // 0x50
	private string m_ReservedFaceAnime; // 0x58

	// Properties
	public string Pid { get; set; }
	public string LocationNameProxy { get; set; }
	public string DefaultBodyAnime { get; set; }
	public bool DisabledAnime { get; set; }
	public Character Character { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDD20 Offset: 0x2CDE21 VA: 0x2CDD20
	// RVA: 0x2C23A90 Offset: 0x2C23B91 VA: 0x2C23A90
	public string get_Pid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDD30 Offset: 0x2CDE31 VA: 0x2CDD30
	// RVA: 0x2C23AA0 Offset: 0x2C23BA1 VA: 0x2C23AA0
	public void set_Pid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDD40 Offset: 0x2CDE41 VA: 0x2CDD40
	// RVA: 0x2C23AB0 Offset: 0x2C23BB1 VA: 0x2C23AB0
	public string get_LocationNameProxy() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDD50 Offset: 0x2CDE51 VA: 0x2CDD50
	// RVA: 0x2C23AC0 Offset: 0x2C23BC1 VA: 0x2C23AC0
	public void set_LocationNameProxy(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDD60 Offset: 0x2CDE61 VA: 0x2CDD60
	// RVA: 0x2C23AD0 Offset: 0x2C23BD1 VA: 0x2C23AD0
	public string get_DefaultBodyAnime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDD70 Offset: 0x2CDE71 VA: 0x2CDD70
	// RVA: 0x2C23AE0 Offset: 0x2C23BE1 VA: 0x2C23AE0
	public void set_DefaultBodyAnime(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDD80 Offset: 0x2CDE81 VA: 0x2CDD80
	// RVA: 0x2C23AF0 Offset: 0x2C23BF1 VA: 0x2C23AF0
	public bool get_DisabledAnime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDD90 Offset: 0x2CDE91 VA: 0x2CDD90
	// RVA: 0x2C23B00 Offset: 0x2C23C01 VA: 0x2C23B00
	public void set_DisabledAnime(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDDA0 Offset: 0x2CDEA1 VA: 0x2CDDA0
	// RVA: 0x2C23B10 Offset: 0x2C23C11 VA: 0x2C23B10
	public Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDDB0 Offset: 0x2CDEB1 VA: 0x2CDDB0
	// RVA: 0x2C23B20 Offset: 0x2C23C21 VA: 0x2C23B20
	private void set_Character(Character value) { }

	// RVA: 0x2C23B30 Offset: 0x2C23C31 VA: 0x2C23B30
	public void PoolNeedFieldCopyTo(TalkCharacterController controller) { }

	// RVA: 0x2C23B50 Offset: 0x2C23C51 VA: 0x2C23B50
	public void Reset() { }

	// RVA: 0x2C23C60 Offset: 0x2C23D61 VA: 0x2C23C60
	private void Awake() { }

	// RVA: 0x2C23C70 Offset: 0x2C23D71 VA: 0x2C23C70
	public void TryFindCharacterComponent() { }

	// RVA: 0x2C23D10 Offset: 0x2C23E11 VA: 0x2C23D10
	private void Play(string clipName, float blendTime) { }

	// RVA: 0x2C23DE0 Offset: 0x2C23EE1 VA: 0x2C23DE0
	private void Update() { }

	// RVA: 0x2C24200 Offset: 0x2C24301 VA: 0x2C24200
	private void LateUpdate() { }

	// RVA: 0x2C23EB0 Offset: 0x2C23FB1 VA: 0x2C23EB0
	private void UpdateFadeIn() { }

	// RVA: 0x2C23FD0 Offset: 0x2C240D1 VA: 0x2C23FD0
	private void UpdateFadeOut() { }

	// RVA: 0x2C24750 Offset: 0x2C24851 VA: 0x2C24750
	public void StartFadeIn(float sec) { }

	// RVA: 0x2C24780 Offset: 0x2C24881 VA: 0x2C24780
	public void StartFadeOut(float sec) { }

	// RVA: 0x2C247B0 Offset: 0x2C248B1 VA: 0x2C247B0
	public string GetCurrentPlayAnime() { }

	// RVA: 0x2C247C0 Offset: 0x2C248C1 VA: 0x2C247C0
	public void ClearBodyAnimeQueue() { }

	// RVA: 0x2C24820 Offset: 0x2C24921 VA: 0x2C24820
	public void PlayDefaultAnime(bool soon = False) { }

	// RVA: 0x2C24840 Offset: 0x2C24941 VA: 0x2C24840
	public void PlayBodyAnime(string name, float transitionDuration = 1, bool soon = False, bool force = False) { }

	// RVA: 0x2C249D0 Offset: 0x2C24AD1 VA: 0x2C249D0
	public void PlayFaceAnime(string name, bool isFastForward = False) { }

	// RVA: 0x2C249F0 Offset: 0x2C24AF1 VA: 0x2C249F0
	public void ReserveFaceAnime(string name) { }

	// RVA: 0x2C24A00 Offset: 0x2C24B01 VA: 0x2C24A00
	public void PlayReservedFaceAnime(bool isFastForward) { }

	// RVA: 0x2C24A50 Offset: 0x2C24B51 VA: 0x2C24A50
	public List<string> GetBodyAnimeNameList() { }

	// RVA: 0x2C24D40 Offset: 0x2C24E41 VA: 0x2C24D40
	public List<string> GetFaceAnimeNameList() { }

	// RVA: 0x2C24A80 Offset: 0x2C24B81 VA: 0x2C24A80
	private List<string> GetAnimeNameList(Animator animator) { }

	// RVA: 0x2C24D70 Offset: 0x2C24E71 VA: 0x2C24D70
	public bool IsBodyAnimeEnd() { }

	// RVA: 0x2C24DE0 Offset: 0x2C24EE1 VA: 0x2C24DE0
	public bool IsFading() { }

	// RVA: 0x2C24DF0 Offset: 0x2C24EF1 VA: 0x2C24DF0
	public void .ctor() { }
}

