// Namespace: App
public class PhotoAppearContent : MonoBehaviour // TypeDefIndex: 11464
{
	// Fields
	public Image m_Image; // 0x18
	public Animator m_Animator; // 0x20
	public float m_Progress; // 0x28
	private Material m_MaterialInst; // 0x30
	private PhotoAppearContent.State m_State; // 0x38
	private PhotoAppearContent.State m_NextState; // 0x3C

	// Properties
	public bool IsAppear { get; }
	public bool IsEnd { get; }

	// Methods

	// RVA: 0x2A25C10 Offset: 0x2A25D11 VA: 0x2A25C10
	protected void OnDestroy() { }

	// RVA: 0x2A25C90 Offset: 0x2A25D91 VA: 0x2A25C90
	private void Start() { }

	// RVA: 0x2A25DE0 Offset: 0x2A25EE1 VA: 0x2A25DE0
	private void Update() { }

	// RVA: 0x2A26080 Offset: 0x2A26181 VA: 0x2A26080
	private void TickFlash() { }

	// RVA: 0x2A26140 Offset: 0x2A26241 VA: 0x2A26140
	private void TickAppear() { }

	// RVA: 0x2A26200 Offset: 0x2A26301 VA: 0x2A26200
	private void TickScaling() { }

	// RVA: 0x2A263C0 Offset: 0x2A264C1 VA: 0x2A263C0
	public void StartEffect(Sprite sprite) { }

	// RVA: 0x2A26470 Offset: 0x2A26571 VA: 0x2A26470
	public void ResetEffect() { }

	// RVA: 0x2A264D0 Offset: 0x2A265D1 VA: 0x2A264D0
	public void Skip() { }

	// RVA: 0x2A26580 Offset: 0x2A26681 VA: 0x2A26580
	public bool get_IsAppear() { }

	// RVA: 0x2A26590 Offset: 0x2A26691 VA: 0x2A26590
	public bool get_IsEnd() { }

	// RVA: 0x2A26290 Offset: 0x2A26391 VA: 0x2A26290
	protected static void TryPlayAnime(Animator animator, string stateName) { }

	// RVA: 0x2A26560 Offset: 0x2A26661 VA: 0x2A26560
	protected void TrySkipAnime(Animator animator, string stateName) { }

	// RVA: 0x2A26340 Offset: 0x2A26441 VA: 0x2A26340
	protected bool IsEndAnime(Animator animator) { }

	// RVA: 0x2A265A0 Offset: 0x2A266A1 VA: 0x2A265A0
	public void .ctor() { }
}

