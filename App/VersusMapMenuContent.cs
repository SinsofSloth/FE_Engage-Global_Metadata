// Namespace: App
public class VersusMapMenuContent : BasicMenuContent // TypeDefIndex: 13765
{
	// Fields
	private const string PrefabPath = "UI/Network/Versus/Prefabs/VersusMapMenuRoot";
	private const string SpriteAtlasPath = "UI/Network/Versus/MapThumb/MapThumb";
	private TextMeshProUGUI m_HelpTitle; // 0xE8
	private Image m_MapImage; // 0xF0
	private SpriteAtlas m_SpriteAtlas; // 0xF8
	private Sprite m_Sprite; // 0x100

	// Methods

	// RVA: 0x2A4EB30 Offset: 0x2A4EC31 VA: 0x2A4EB30
	public static void LoadPrefabAsync() { }

	// RVA: 0x2A4EC10 Offset: 0x2A4ED11 VA: 0x2A4EC10
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2A4ECE0 Offset: 0x2A4EDE1 VA: 0x2A4ECE0
	public static void UnloadPrefab() { }

	// RVA: 0x2A4ED80 Offset: 0x2A4EE81 VA: 0x2A4ED80
	public static VersusMapMenuContent Create() { }

	// RVA: 0x2A4F020 Offset: 0x2A4F121 VA: 0x2A4F020 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2A4F090 Offset: 0x2A4F191 VA: 0x2A4F090 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2A4EE60 Offset: 0x2A4EF61 VA: 0x2A4EE60
	private void initialize() { }

	// RVA: 0x2A4F100 Offset: 0x2A4F201 VA: 0x2A4F100
	public void SetHelpTitle(string title) { }

	// RVA: 0x2A4F120 Offset: 0x2A4F221 VA: 0x2A4F120
	public void SetMapSprite(string name) { }

	// RVA: 0x2A4F1D0 Offset: 0x2A4F2D1 VA: 0x2A4F1D0 Slot: 33
	protected override void OnDestroy() { }

	// RVA: 0x2A4F250 Offset: 0x2A4F351 VA: 0x2A4F250
	public void .ctor() { }
}

