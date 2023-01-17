// Namespace: App
public class UnitInfoCharaImageMaskOffset : SingletonMonoBehaviourList<UnitInfoCharaImageMaskOffset> // TypeDefIndex: 11848
{
	// Fields
	private const int c_DefaultWidth = 640;
	public UnitInfoCharaImageMaskOffset.Type m_Type; // 0x18
	public float m_OffsetU; // 0x1C
	public Texture m_MaskTexture; // 0x20
	private Texture m_MaskTextureOld; // 0x28
	private float m_Time; // 0x30
	private Vector2 m_Offset; // 0x34
	private CanvasManager m_CanvasManager; // 0x40
	private RectTransform m_RectTransform; // 0x48
	private Image m_Image; // 0x50
	private Material m_MaterialStart; // 0x58
	private Material m_Material; // 0x60
	private RenderTexture m_Texture; // 0x68
	private bool m_IsStartup; // 0x70
	private bool m_IsShow; // 0x71
	private bool m_IsShowFromUnitInfo; // 0x72
	private bool m_IsSetAlphaForced; // 0x73

	// Properties
	public RenderTexture RenderTexture { get; }
	public Image Image { get; }

	// Methods

	// RVA: 0x23F4000 Offset: 0x23F4101 VA: 0x23F4000
	private void Start() { }

	// RVA: 0x23F4540 Offset: 0x23F4641 VA: 0x23F4540
	private void OnEnable() { }

	// RVA: 0x23F4550 Offset: 0x23F4651 VA: 0x23F4550
	private void OnDisable() { }

	// RVA: 0x23F40A0 Offset: 0x23F41A1 VA: 0x23F40A0
	private void Setup() { }

	// RVA: 0x23F4560 Offset: 0x23F4661 VA: 0x23F4560
	private void Cleanup() { }

	// RVA: 0x23F1D80 Offset: 0x23F1E81 VA: 0x23F1D80
	public void ResetAlpha() { }

	// RVA: 0x23F4920 Offset: 0x23F4A21 VA: 0x23F4920
	public void SetAlphaForced(float alpha, bool isShow = True) { }

	// RVA: 0x23F1B00 Offset: 0x23F1C01 VA: 0x23F1B00
	public void SetShowFormUnitInfo(bool isShow) { }

	// RVA: 0x23F4A80 Offset: 0x23F4B81 VA: 0x23F4A80
	public void Show() { }

	// RVA: 0x23F4AF0 Offset: 0x23F4BF1 VA: 0x23F4AF0
	public void Hide() { }

	// RVA: 0x23F4710 Offset: 0x23F4811 VA: 0x23F4710
	private void UpdateCamera(UnitInfo.Side side) { }

	// RVA: 0x23F47E0 Offset: 0x23F48E1 VA: 0x23F47E0
	private void SetCustomOffscreenCameraEnabled(UnitInfo.Side side, bool isEnabled) { }

	// RVA: 0x23F4B30 Offset: 0x23F4C31 VA: 0x23F4B30
	private void Update() { }

	// RVA: 0x23F4EC0 Offset: 0x23F4FC1 VA: 0x23F4EC0
	public RenderTexture get_RenderTexture() { }

	// RVA: 0x23F4ED0 Offset: 0x23F4FD1 VA: 0x23F4ED0
	public Image get_Image() { }

	// RVA: 0x23F4D20 Offset: 0x23F4E21 VA: 0x23F4D20
	public bool IsVisible() { }

	// RVA: 0x23F4EE0 Offset: 0x23F4FE1 VA: 0x23F4EE0
	public void .ctor() { }
}

