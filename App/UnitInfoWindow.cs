// Namespace: App
public class UnitInfoWindow // TypeDefIndex: 11865
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	private static readonly int AnimHashIsCharaOnly; // 0x8
	private static readonly int AnimHashIsTransition; // 0xC
	private static readonly int AnimHashIsTransparent; // 0x10
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x10
	private GameObject m_GameObject; // 0x18
	private Animator m_Animator; // 0x20
	private Animator m_AnimatorStatus; // 0x28
	private UnitInfoCharaImageMaskOffset m_CharaImageMask; // 0x30
	private bool m_IsValid; // 0x38

	// Properties
	public GameObject gameObject { get; }
	public UnitInfoCharaImageMaskOffset CharaImageMask { get; }

	// Methods

	// RVA: 0x242E060 Offset: 0x242E161 VA: 0x242E060
	public GameObject get_gameObject() { }

	// RVA: 0x242E070 Offset: 0x242E171 VA: 0x242E070
	public UnitInfoCharaImageMaskOffset get_CharaImageMask() { }

	// RVA: 0x242E080 Offset: 0x242E181 VA: 0x242E080
	public void .ctor(RenderTexture renderTexture, bool isReverse, bool isHideStatus) { }

	// RVA: 0x242E0D0 Offset: 0x242E1D1 VA: 0x242E0D0
	public void CreateAsync(RenderTexture renderTexture, bool isReverse, bool isHideStatus) { }

	// RVA: 0x242E2A0 Offset: 0x242E3A1 VA: 0x242E2A0
	public bool IsCreating() { }

	// RVA: 0x242E2D0 Offset: 0x242E3D1 VA: 0x242E2D0
	public void Destroy() { }

	// RVA: 0x242E3C0 Offset: 0x242E4C1 VA: 0x242E3C0
	private void SetActive(bool isActive) { }

	// RVA: 0x242E910 Offset: 0x242EA11 VA: 0x242E910
	private bool IsActive() { }

	// RVA: 0x242EAE0 Offset: 0x242EBE1 VA: 0x242EAE0
	public void SetUnit(Unit unit, int x, int z) { }

	// RVA: 0x242EB80 Offset: 0x242EC81 VA: 0x242EB80
	public void SetUnit(Unit unit, int x, int z, GodUnit god) { }

	// RVA: 0x242EC20 Offset: 0x242ED21 VA: 0x242EC20
	public void CharaMaskOn() { }

	// RVA: 0x242ED10 Offset: 0x242EE11 VA: 0x242ED10
	public void CharaMaskOff() { }

	// RVA: 0x242E8B0 Offset: 0x242E9B1 VA: 0x242E8B0
	private bool TryPlayAnimation(Animator animator, string name) { }

	// RVA: 0x242EE00 Offset: 0x242EF01 VA: 0x242EE00
	public void CharaOnlyOn() { }

	// RVA: 0x242EF40 Offset: 0x242F041 VA: 0x242EF40
	public void CharaOnlyOff() { }

	// RVA: 0x242F0A0 Offset: 0x242F1A1 VA: 0x242F0A0
	public bool IsCharaOnlyTransition() { }

	// RVA: 0x242F190 Offset: 0x242F291 VA: 0x242F190
	public void TransparentOn() { }

	// RVA: 0x242F280 Offset: 0x242F381 VA: 0x242F280
	public void TransparentOff() { }

	// RVA: 0x242F370 Offset: 0x242F471 VA: 0x242F370
	public void Activate() { }

	// RVA: 0x242F420 Offset: 0x242F521 VA: 0x242F420
	public void Deactivate() { }

	// RVA: 0x242F4C0 Offset: 0x242F5C1 VA: 0x242F4C0
	public Image GetCharaImage() { }

	// RVA: 0x242F670 Offset: 0x242F771 VA: 0x242F670
	public void ActiveStatus() { }

	// RVA: 0x242F770 Offset: 0x242F871 VA: 0x242F770
	public void DeactiveStatus() { }

	// RVA: 0x242F870 Offset: 0x242F971 VA: 0x242F870
	public bool IsActiveStatus() { }

	// RVA: 0x242FA00 Offset: 0x242FB01 VA: 0x242FA00
	private void CreateImpl(RenderTexture renderTexture, bool isReverse, bool isHideStatus) { }

	// RVA: 0x242FB20 Offset: 0x242FC21 VA: 0x242FB20
	private bool Setup(RenderTexture renderTexture, bool isReverse, bool isHideStatus) { }

	// RVA: 0x242F560 Offset: 0x242F661 VA: 0x242F560
	private Image GetCharaImage(out GameObject charaImageObj, out GameObject charaImageImageObj) { }

	// RVA: 0x242FF40 Offset: 0x2430041 VA: 0x242FF40
	private static void .cctor() { }
}

