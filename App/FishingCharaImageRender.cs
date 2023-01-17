// Namespace: App
public abstract class FishingCharaImageRender : MonoBehaviour // TypeDefIndex: 10576
{
	// Fields
	private Camera m_Camera; // 0x18
	private Character m_Chara; // 0x20
	private Character m_Sola; // 0x28
	private GameObject m_Lure; // 0x30
	private bool m_IsPlayingHitAnime; // 0x38

	// Methods

	// RVA: 0x2EF2480 Offset: 0x2EF2581 VA: 0x2EF2480
	public void .ctor() { }

	// RVA: 0x2EF2490 Offset: 0x2EF2591 VA: 0x2EF2490
	private void OnDestroy() { }

	// RVA: 0x2EF26F0 Offset: 0x2EF27F1 VA: 0x2EF26F0
	private void Update() { }

	// RVA: 0x2EF2900 Offset: 0x2EF2A01 VA: 0x2EF2900
	private void SetLayer(GameObject obj, int setLayer) { }

	// RVA: 0x2EF27D0 Offset: 0x2EF28D1 VA: 0x2EF27D0
	public void PlayCharaAnime(string name, string faceState = "", bool changeSoon = False) { }

	// RVA: 0x2EF2C00 Offset: 0x2EF2D01 VA: 0x2EF2C00
	public void StartHitAnime() { }

	// RVA: 0x2EF2C80 Offset: 0x2EF2D81 VA: 0x2EF2C80
	public void StartAssistAnime() { }

	// RVA: 0x2EF2CF0 Offset: 0x2EF2DF1 VA: 0x2EF2CF0
	public void Init(string rodID) { }

	// RVA: 0x2EF33C0 Offset: 0x2EF34C1 VA: 0x2EF33C0
	public void ChangeRodType(string rodID) { }

	// RVA: 0x2EF35D0 Offset: 0x2EF36D1 VA: 0x2EF35D0
	public void SetSolaVisible(bool set) { }

	// RVA: 0x2EF3600 Offset: 0x2EF3701 VA: 0x2EF3600
	public void PlaySolaAnime(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF500 Offset: 0x2BF601 VA: 0x2BF500
	// RVA: 0x2EF3260 Offset: 0x2EF3361 VA: 0x2EF3260
	internal static Character <Init>g__CreateFishingImageChara|12_0(CharacterAppearance app, Transform parent, bool invisible) { }
}

