// Namespace: App
public class UnitIcon : Image // TypeDefIndex: 13460
{
	// Fields
	[SerializeField] // RVA: 0x29C280 Offset: 0x29C381 VA: 0x29C280
	private SpriteAtlas m_IndexAtlas; // 0x108
	[SerializeField] // RVA: 0x29C290 Offset: 0x29C391 VA: 0x29C290
	private SpriteAtlas m_PalleteAtlas; // 0x110
	[SerializeField] // RVA: 0x29C2A0 Offset: 0x29C3A1 VA: 0x29C2A0
	private Sprite m_PalleteSprite; // 0x118
	[SerializeField] // RVA: 0x29C2B0 Offset: 0x29C3B1 VA: 0x29C2B0
	private string m_IconName; // 0x120
	[SerializeField] // RVA: 0x29C2C0 Offset: 0x29C3C1 VA: 0x29C2C0
	private string m_PalleteName; // 0x128
	[RangeAttribute] // RVA: 0x29C2D0 Offset: 0x29C3D1 VA: 0x29C2D0
	[SerializeField] // RVA: 0x29C2D0 Offset: 0x29C3D1 VA: 0x29C2D0
	private float m_Brightness; // 0x130
	protected static UIVertex s_TmpVertex; // 0x0
	private static StringBuilder s_strBuilder; // 0x70
	private static Key3Dictionary<string, string> s_Key3Dictionary; // 0x78
	private static Dictionary<string, string> m_EngageNameDictionary; // 0x80
	private static Dictionary<string, string> m_VariationJobIconIdDictionary; // 0x88
	private static string[] s_IdTable; // 0x90
	private const string DARKNESS_ID = "997Darkness";
	private Material m_MaterialInst; // 0x138

	// Properties
	public override Material material { get; set; }

	// Methods

	// RVA: 0x23E9AA0 Offset: 0x23E9BA1 VA: 0x23E9AA0
	public void SetBrightness(Color color) { }

	// RVA: 0x23E9AE0 Offset: 0x23E9BE1 VA: 0x23E9AE0
	public void SetPalleteSprite(Sprite pallete) { }

	// RVA: 0x23E9B20 Offset: 0x23E9C21 VA: 0x23E9B20
	public void SetIcon(Unit unit) { }

	// RVA: 0x23EA780 Offset: 0x23EA881 VA: 0x23EA780
	public void SetIconNoEngaging(Unit unit) { }

	// RVA: 0x23EA6C0 Offset: 0x23EA7C1 VA: 0x23EA6C0
	public void SetIcon(PersonData person, JobData job, bool isFemale, UnitItem equipItem) { }

	// RVA: 0x23EACB0 Offset: 0x23EADB1 VA: 0x23EACB0
	private static void TryInitVariationJobIconIdDictionary() { }

	// RVA: 0x23EB000 Offset: 0x23EB101 VA: 0x23EB000
	private static string GetIconName(string personIconID, string jobIconID, string itemIconID) { }

	// RVA: 0x23EAAB0 Offset: 0x23EABB1 VA: 0x23EAAB0
	public void SetIcon(PersonData person, JobData job, bool isFemale, ItemData.Kinds itemKind) { }

	// RVA: 0x23EA4C0 Offset: 0x23EA5C1 VA: 0x23EA4C0
	public void SetIcon(PersonData person, GodData god, bool isFemale) { }

	// RVA: 0x23EB5F0 Offset: 0x23EB6F1 VA: 0x23EB5F0
	public void SetIcon(GodData god, bool isDarkness = False) { }

	// RVA: 0x23EB840 Offset: 0x23EB941 VA: 0x23EB840
	public void SetIcon(GodData god, bool isFemale, bool isDarkness) { }

	// RVA: 0x23EB260 Offset: 0x23EB361 VA: 0x23EB260
	public static string ConvertPersonIconID(string original, bool isFemale) { }

	// RVA: 0x23EB490 Offset: 0x23EB591 VA: 0x23EB490
	private bool TrySet(string indexName, string palleteName) { }

	// RVA: 0x23EA3F0 Offset: 0x23EA4F1 VA: 0x23EA3F0
	public void ResetIcon() { }

	// RVA: 0x23EB380 Offset: 0x23EB481 VA: 0x23EB380
	private string GetWeaponKindId(ItemData.Kinds itemKind) { }

	// RVA: 0x23EB480 Offset: 0x23EB581 VA: 0x23EB480
	private Sprite GetIndexSprite(string name) { }

	// RVA: 0x23EB470 Offset: 0x23EB571 VA: 0x23EB470
	private Sprite GetPalleteSprite(string name) { }

	// RVA: 0x23EB9C0 Offset: 0x23EBAC1 VA: 0x23EB9C0 Slot: 32
	public override Material get_material() { }

	// RVA: 0x23EBA60 Offset: 0x23EBB61 VA: 0x23EBA60 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x23EBB10 Offset: 0x23EBC11 VA: 0x23EBB10 Slot: 4
	protected override void Awake() { }

	// RVA: 0x23EBCD0 Offset: 0x23EBDD1 VA: 0x23EBCD0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x23EBD60 Offset: 0x23EBE61 VA: 0x23EBD60 Slot: 6
	protected override void Start() { }

	// RVA: 0x23EBD70 Offset: 0x23EBE71 VA: 0x23EBD70 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x23EBF00 Offset: 0x23EC001 VA: 0x23EBF00 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x23EBBE0 Offset: 0x23EBCE1 VA: 0x23EBBE0
	public void UpdateIcon() { }

	// RVA: 0x23EC030 Offset: 0x23EC131 VA: 0x23EC030
	public void SetRandomIcon() { }

	// RVA: 0x23EC200 Offset: 0x23EC301 VA: 0x23EC200
	public void .ctor() { }

	// RVA: 0x23EC280 Offset: 0x23EC381 VA: 0x23EC280
	private static void .cctor() { }
}

