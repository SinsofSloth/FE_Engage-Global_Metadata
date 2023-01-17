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

