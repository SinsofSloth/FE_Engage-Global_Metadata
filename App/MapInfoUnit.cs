// Namespace: App
public class MapInfoUnit : SingletonMonoBehaviour<MapInfoUnit> // TypeDefIndex: 9025
{
	// Fields
	public const int BeginPage = 0;
	public const int EndPage = 6;
	[SpaceAttribute] // RVA: 0x285B30 Offset: 0x285C31 VA: 0x285B30
	[HeaderAttribute] // RVA: 0x285B30 Offset: 0x285C31 VA: 0x285B30
	[SerializeField] // RVA: 0x285B30 Offset: 0x285C31 VA: 0x285B30
	private AnimationCurve m_ScaleCurve; // 0x20
	private MapInfoUnit.InputState m_Input; // 0x28
	private bool m_IsOpenMapNavigation; // 0x2C
	private bool m_IsVisible; // 0x2D
	private bool m_IsSuppress; // 0x2E
	private MapInfoUnit.SuppressScene m_SuppressFlag; // 0x30
	[RangeAttribute] // RVA: 0x285B90 Offset: 0x285C91 VA: 0x285B90
	[SerializeField] // RVA: 0x285B90 Offset: 0x285C91 VA: 0x285B90
	private float m_AlphaChangeRatio; // 0x34
	[SerializeField] // RVA: 0x285BD0 Offset: 0x285CD1 VA: 0x285BD0
	private int m_WaitFrame; // 0x38
	private int m_Count; // 0x3C
	public SpriteAtlas m_SpriteAtlas; // 0x40
	private Sprite[] m_Sprites; // 0x48
	private static readonly string[] SpriteNames; // 0x0

	// Properties
	public AnimationCurve ScaleCurve { get; }
	public MapInfoUnit.InputState Input { get; set; }
	public bool IsVisible { get; set; }
	public bool IsSuppress { get; }
	public float AlphaChangeRatio { get; }
	public bool IsOpenMapNavigation { get; }

	// Methods

	// RVA: 0x2491E30 Offset: 0x2491F31 VA: 0x2491E30
	private void Start() { }

	// RVA: 0x2491EB0 Offset: 0x2491FB1 VA: 0x2491EB0
	private void Update() { }

	// RVA: 0x2491E70 Offset: 0x2491F71 VA: 0x2491E70
	private void Init() { }

	// RVA: 0x2492750 Offset: 0x2492851 VA: 0x2492750
	private void GetSprites() { }

	// RVA: 0x2492960 Offset: 0x2492A61 VA: 0x2492960
	public Sprite GetSprite(int index) { }

	// RVA: 0x2492200 Offset: 0x2492301 VA: 0x2492200
	private void UpdateVisible() { }

	// RVA: 0x2492480 Offset: 0x2492581 VA: 0x2492480
	private void UpdatePage() { }

	// RVA: 0x2492AA0 Offset: 0x2492BA1 VA: 0x2492AA0
	public void ForceUpdateAllUnit() { }

	// RVA: 0x2492CB0 Offset: 0x2492DB1 VA: 0x2492CB0
	public void SetSuppressFlag(MapInfoUnit.SuppressScene flag) { }

	// RVA: 0x2492CC0 Offset: 0x2492DC1 VA: 0x2492CC0
	public void UnsetSuppressFlag(MapInfoUnit.SuppressScene flag) { }

	// RVA: 0x2491EF0 Offset: 0x2491FF1 VA: 0x2491EF0
	public void UpdateSuppress() { }

	// RVA: 0x24929A0 Offset: 0x2492AA1 VA: 0x24929A0
	private bool CanSwitchUnitInfo() { }

	// RVA: 0x2492CD0 Offset: 0x2492DD1 VA: 0x2492CD0
	public bool IsSwitchUnitInfo() { }

	// RVA: 0x2492DD0 Offset: 0x2492ED1 VA: 0x2492DD0
	public AnimationCurve get_ScaleCurve() { }

	// RVA: 0x2492DE0 Offset: 0x2492EE1 VA: 0x2492DE0
	public MapInfoUnit.InputState get_Input() { }

	// RVA: 0x2492DF0 Offset: 0x2492EF1 VA: 0x2492DF0
	public void set_Input(MapInfoUnit.InputState value) { }

	// RVA: 0x2492E00 Offset: 0x2492F01 VA: 0x2492E00
	public bool get_IsVisible() { }

	// RVA: 0x2492E10 Offset: 0x2492F11 VA: 0x2492E10
	public void set_IsVisible(bool value) { }

	// RVA: 0x2492E20 Offset: 0x2492F21 VA: 0x2492E20
	public bool get_IsSuppress() { }

	// RVA: 0x2492E30 Offset: 0x2492F31 VA: 0x2492E30
	public float get_AlphaChangeRatio() { }

	// RVA: 0x2492E40 Offset: 0x2492F41 VA: 0x2492E40
	public bool get_IsOpenMapNavigation() { }

	// RVA: 0x2492E50 Offset: 0x2492F51 VA: 0x2492E50
	public void .ctor() { }

	// RVA: 0x2492EE0 Offset: 0x2492FE1 VA: 0x2492EE0
	private static void .cctor() { }
}

