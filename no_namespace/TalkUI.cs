// Namespace: 
private class TalkUI.KeyHelpObjects // TypeDefIndex: 14164
{
	// Fields
	private GameObject m_rootObject; // 0x10
	private TalkUI.TalkObjects m_talkObjects; // 0x18

	// Methods

	// RVA: 0x238BE30 Offset: 0x238BF31 VA: 0x238BE30
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x238BF50 Offset: 0x238C051 VA: 0x238BF50
	public void SetTalkObjects(TalkUI.TalkObjects talkObjects) { }

	// RVA: 0x238BE70 Offset: 0x238BF71 VA: 0x238BE70
	public void Reset() { }

	// RVA: 0x238BF60 Offset: 0x238C061 VA: 0x238BF60
	public void Setup() { }

	// RVA: 0x238C090 Offset: 0x238C191 VA: 0x238C090
	public void Show() { }

	// RVA: 0x238C140 Offset: 0x238C241 VA: 0x238C140
	public void Hide() { }

	// RVA: 0x238C1F0 Offset: 0x238C2F1 VA: 0x238C1F0
	public void Update() { }
}

// Namespace: 
private abstract class TalkUI.TalkObjects // TypeDefIndex: 14165
{
	// Fields
	protected GameObject m_RootObject; // 0x10
	protected GameObject m_Window; // 0x18
	protected Image m_WindowImage; // 0x20
	protected Animator m_WindowAnimator; // 0x28
	protected Animator m_MainTextAnimator; // 0x30
	protected TextMeshProUGUI m_MainText; // 0x38
	protected GameObject m_WaitKeyIcon; // 0x40
	protected GameObject m_AutoPlayIcon; // 0x48
	protected TalkUI.KeyHelpObjects m_KeyHelpObjects; // 0x50
	protected bool m_ImmediatelyAfterActivation; // 0x58
	protected bool m_IsShowKeyWaitIcon; // 0x59

	// Methods

	// RVA: 0x238D270 Offset: 0x238D371 VA: 0x238D270
	public Animator GetWindowAnimator() { }

	// RVA: 0x238D060 Offset: 0x238D161 VA: 0x238D060
	protected void .ctor(GameObject rootObject) { }

	// RVA: 0x238D0A0 Offset: 0x238D1A1 VA: 0x238D0A0 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x238D290 Offset: 0x238D391 VA: 0x238D290
	public void SetImmediatelyAfterActivation() { }

	// RVA: 0x238D2A0 Offset: 0x238D3A1 VA: 0x238D2A0
	public void Update() { }

	// RVA: 0x238D2B0 Offset: 0x238D3B1 VA: 0x238D2B0
	public bool IsTextEmpty() { }

	// RVA: 0x238D2E0 Offset: 0x238D3E1 VA: 0x238D2E0
	public bool IsNeedTextScroll() { }

	// RVA: 0x238D320 Offset: 0x238D421 VA: 0x238D320
	public void AddLetter(char c) { }

	// RVA: 0x238D3F0 Offset: 0x238D4F1 VA: 0x238D3F0
	public void AddString(string str) { }

	// RVA: 0x238D4C0 Offset: 0x238D5C1 VA: 0x238D4C0
	public void ClearText() { }

	// RVA: 0x238D540 Offset: 0x238D641 VA: 0x238D540
	public float CalcTotalWidth(string messStr) { }

	// RVA: 0x238D5C0 Offset: 0x238D6C1 VA: 0x238D5C0
	public void SetupWaitIcon() { }

	// RVA: 0x238D650 Offset: 0x238D751 VA: 0x238D650
	public void ShowKeyWaitIcon() { }

	// RVA: 0x238D280 Offset: 0x238D381 VA: 0x238D280
	public void HideKeyWaitIcon() { }

	// RVA: 0x238D660 Offset: 0x238D761 VA: 0x238D660 Slot: 5
	public virtual GameObject GetNameLocator(string locationName) { }

	// RVA: 0x238D670 Offset: 0x238D771 VA: 0x238D670 Slot: 6
	public virtual void SetTalkerName(string name, string location) { }

	// RVA: 0x238D680 Offset: 0x238D781 VA: 0x238D680 Slot: 7
	public virtual bool SetFocus(string location) { }

	// RVA: 0x238D690 Offset: 0x238D791 VA: 0x238D690 Slot: 8
	public virtual void CloseTalkerName() { }

	// RVA: 0x238D6A0 Offset: 0x238D7A1 VA: 0x238D6A0
	public void SetActive(bool isActive) { }

	// RVA: 0x238D740 Offset: 0x238D841 VA: 0x238D740
	public void OpenWindow() { }

	// RVA: 0x238D750 Offset: 0x238D851 VA: 0x238D750
	public void CloseWindow() { }

	// RVA: 0x238CB70 Offset: 0x238CC71 VA: 0x238CB70 Slot: 9
	public virtual void CloseAll() { }

	// RVA: 0x238D760 Offset: 0x238D861 VA: 0x238D760 Slot: 10
	public virtual void ShowWindowBg() { }

	// RVA: 0x238D800 Offset: 0x238D901 VA: 0x238D800 Slot: 11
	public virtual void HideWindowBg() { }

	// RVA: 0x238CE60 Offset: 0x238CF61 VA: 0x238CE60 Slot: 12
	public virtual bool IsPlayingWindowAnimation() { }

	// RVA: 0x238C720 Offset: 0x238C821 VA: 0x238C720
	protected static void TryPlayAnime(Animator animator, string stateName) { }

	// RVA: 0x238BB10 Offset: 0x238BC11 VA: 0x238BB10
	protected static void TryPlayOpen(Animator animator) { }

	// RVA: 0x238BC40 Offset: 0x238BD41 VA: 0x238BC40
	protected static void TryPlayClose(Animator animator) { }

	// RVA: 0x238D8A0 Offset: 0x238D9A1 VA: 0x238D8A0
	public void StartTextScroll() { }

	// RVA: 0x238D900 Offset: 0x238DA01 VA: 0x238D900
	public bool IsTextScrolling() { }

	// RVA: 0x238D9D0 Offset: 0x238DAD1 VA: 0x238D9D0
	public void SetupKeyHelp() { }

	// RVA: 0x238D9E0 Offset: 0x238DAE1 VA: 0x238D9E0 Slot: 13
	public virtual void AddToLog(string label, string talkerName) { }
}

// Namespace: 
private class TalkUI.SystemObjects : TalkUI.TalkObjects // TypeDefIndex: 14166
{
	// Methods

	// RVA: 0x238C370 Offset: 0x238C471 VA: 0x238C370
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x238C710 Offset: 0x238C811 VA: 0x238C710 Slot: 4
	public override void Reset() { }

	// RVA: 0x238D180 Offset: 0x238D281 VA: 0x238D180 Slot: 13
	public override void AddToLog(string label, string talkerName) { }
}

// Namespace: 
private class TalkUI.StandObjects : TalkUI.SystemObjects // TypeDefIndex: 14167
{
	// Fields
	protected GameObject m_NameRoot; // 0x60
	protected string m_CurrentLocationName; // 0x68

	// Methods

	// RVA: 0x238C360 Offset: 0x238C461 VA: 0x238C360
	public string GetCurrentLocationName() { }

	// RVA: 0x238B790 Offset: 0x238B891 VA: 0x238B790
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x238B8A0 Offset: 0x238B9A1 VA: 0x238B8A0 Slot: 4
	public override void Reset() { }

	// RVA: 0x238C7D0 Offset: 0x238C8D1 VA: 0x238C7D0 Slot: 6
	public override void SetTalkerName(string name, string locationName) { }

	// RVA: 0x238C910 Offset: 0x238CA11 VA: 0x238C910 Slot: 7
	public override bool SetFocus(string locationName) { }

	// RVA: 0x238CAC0 Offset: 0x238CBC1 VA: 0x238CAC0 Slot: 8
	public override void CloseTalkerName() { }

	// RVA: 0x238BDD0 Offset: 0x238BED1 VA: 0x238BDD0 Slot: 9
	public override void CloseAll() { }

	// RVA: 0x238CC30 Offset: 0x238CD31 VA: 0x238CC30 Slot: 5
	public override GameObject GetNameLocator(string locationName) { }

	// RVA: 0x238CCB0 Offset: 0x238CDB1 VA: 0x238CCB0 Slot: 12
	public override bool IsPlayingWindowAnimation() { }

	// RVA: 0x238CF80 Offset: 0x238D081 VA: 0x238CF80 Slot: 13
	public override void AddToLog(string label, string talkerName) { }
}

// Namespace: 
private class TalkUI.FaceObjects.Face // TypeDefIndex: 14168
{
	// Fields
	private const float FaceSlideLength = 100;
	public GameObject m_Image; // 0x10
	public Animator m_Animator; // 0x18
	public float m_ImageBaseX; // 0x20
	public bool m_IsDirRight; // 0x24
	private Material m_material; // 0x28

	// Methods

	// RVA: 0x21FC1D0 Offset: 0x21FC2D1 VA: 0x21FC1D0
	public void .ctor(GameObject rootObject, string ImageName, bool isDirRight) { }

	// RVA: 0x21FC3C0 Offset: 0x21FC4C1 VA: 0x21FC3C0
	public void Destroy() { }

	// RVA: 0x21FC480 Offset: 0x21FC581 VA: 0x21FC480
	public void FadeIn() { }

	// RVA: 0x21FC490 Offset: 0x21FC591 VA: 0x21FC490
	public void FadeOut() { }

	// RVA: 0x21FC4A0 Offset: 0x21FC5A1 VA: 0x21FC4A0
	public void SetSlideRate(float faceSlideRate) { }

	// RVA: 0x21FC550 Offset: 0x21FC651 VA: 0x21FC550
	public void EnableSilhouette() { }

	// RVA: 0x21FC660 Offset: 0x21FC761 VA: 0x21FC660
	public void DisableSilhouette() { }

	// RVA: 0x21FC770 Offset: 0x21FC871 VA: 0x21FC770
	public void Close() { }

	// RVA: 0x21FC780 Offset: 0x21FC881 VA: 0x21FC780
	public void ResetAnim() { }
}

// Namespace: 
private class TalkUI.FaceObjects : TalkUI.StandObjects // TypeDefIndex: 14169
{
	// Fields
	private GameObject m_Panel; // 0x70
	private Animator m_PanelAnimator; // 0x78
	private TalkUI.FaceObjects.Face m_FaceL; // 0x80
	private TalkUI.FaceObjects.Face m_FaceR; // 0x88

	// Methods

	// RVA: 0x238B5F0 Offset: 0x238B6F1 VA: 0x238B5F0
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x238B840 Offset: 0x238B941 VA: 0x238B840 Slot: 4
	public override void Reset() { }

	// RVA: 0x238BA60 Offset: 0x238BB61 VA: 0x238BA60
	public void FadeInFaceL() { }

	// RVA: 0x238BA70 Offset: 0x238BB71 VA: 0x238BA70
	public void FadeOutFaceL() { }

	// RVA: 0x238BA80 Offset: 0x238BB81 VA: 0x238BA80
	public void SetFaceSlideRateL(float faceSlideRate) { }

	// RVA: 0x238BA90 Offset: 0x238BB91 VA: 0x238BA90
	public void EnableSilhouetteL() { }

	// RVA: 0x238BAA0 Offset: 0x238BBA1 VA: 0x238BAA0
	public void DisableSilhouetteL() { }

	// RVA: 0x238BAB0 Offset: 0x238BBB1 VA: 0x238BAB0
	public void FadeInFaceR() { }

	// RVA: 0x238BAC0 Offset: 0x238BBC1 VA: 0x238BAC0
	public void FadeOutFaceR() { }

	// RVA: 0x238BAD0 Offset: 0x238BBD1 VA: 0x238BAD0
	public void SetFaceSlideRateR(float faceSlideRate) { }

	// RVA: 0x238BAE0 Offset: 0x238BBE1 VA: 0x238BAE0
	public void EnableSilhouetteR() { }

	// RVA: 0x238BAF0 Offset: 0x238BBF1 VA: 0x238BAF0
	public void DisableSilhouetteR() { }

	// RVA: 0x238BB00 Offset: 0x238BC01 VA: 0x238BB00
	public void OpenPanel() { }

	// RVA: 0x238BA50 Offset: 0x238BB51 VA: 0x238BA50
	public void ClosePanel() { }

	// RVA: 0x238BD80 Offset: 0x238BE81 VA: 0x238BD80 Slot: 9
	public override void CloseAll() { }

	// RVA: 0x238BE00 Offset: 0x238BF01 VA: 0x238BE00
	public void Destroy() { }
}

