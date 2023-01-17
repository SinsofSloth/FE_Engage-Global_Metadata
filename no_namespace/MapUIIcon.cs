// Namespace: 
public class MapUIIcon : SingletonMonoBehaviour<MapUIIcon> // TypeDefIndex: 7650
{
	// Fields
	private static readonly string[] IconNames; // 0x0
	[SerializeField] // RVA: 0x27BDA0 Offset: 0x27BEA1 VA: 0x27BDA0
	[HeaderAttribute] // RVA: 0x27BDA0 Offset: 0x27BEA1 VA: 0x27BDA0
	[SpaceAttribute] // RVA: 0x27BDA0 Offset: 0x27BEA1 VA: 0x27BDA0
	private MapInfoIconLocatorRoot m_IconLocatorRoot; // 0x20
	[SpaceAttribute] // RVA: 0x27BE00 Offset: 0x27BF01 VA: 0x27BE00
	[HeaderAttribute] // RVA: 0x27BE00 Offset: 0x27BF01 VA: 0x27BE00
	[SerializeField] // RVA: 0x27BE00 Offset: 0x27BF01 VA: 0x27BE00
	private SpriteAtlas m_SpriteAtlas; // 0x28
	private Sprite[] m_Sprites; // 0x30
	private MapInfoIconPool m_IconPool; // 0x38
	private Dictionary<int, MapInfoIconLocatorRoot> m_IconTable; // 0x40
	private Dictionary<int, MapInfoIconLocatorRoot> m_TempTable; // 0x48
	private Dictionary<int, MapInfoIconLocatorRoot> m_RemoveTable; // 0x50
	private bool m_IsUpdate; // 0x58

	// Properties
	public bool IsUpdate { set; }

	// Methods

	// RVA: 0x275FD80 Offset: 0x275FE81 VA: 0x275FD80
	private void Start() { }

	// RVA: 0x2760250 Offset: 0x2760351 VA: 0x2760250
	private void OnDestroy() { }

	// RVA: 0x27602D0 Offset: 0x27603D1 VA: 0x27602D0
	public void Update() { }

	// RVA: 0x2760050 Offset: 0x2760151 VA: 0x2760050
	private void GetSprites() { }

	// RVA: 0x27606A0 Offset: 0x27607A1 VA: 0x27606A0
	public Sprite GetSprite(int index) { }

	// RVA: 0x275FE50 Offset: 0x275FF51 VA: 0x275FE50
	public void SetIcon() { }

	// RVA: 0x27606E0 Offset: 0x27607E1 VA: 0x27606E0
	private void RegisteIconTable(int key) { }

	// RVA: 0x27604E0 Offset: 0x27605E1 VA: 0x27604E0
	private void UnregisteIconTable() { }

	// RVA: 0x2760300 Offset: 0x2760401 VA: 0x2760300
	private void UpdateIconTable() { }

	// RVA: 0x27607A0 Offset: 0x27608A1 VA: 0x27607A0
	private bool IsRemove(List<MapInspector> inspectors, int key) { }

	// RVA: 0x2760960 Offset: 0x2760A61 VA: 0x2760960
	public void ClearIconTable() { }

	// RVA: 0x2760AB0 Offset: 0x2760BB1 VA: 0x2760AB0
	public void set_IsUpdate(bool value) { }

	// RVA: 0x2760AC0 Offset: 0x2760BC1 VA: 0x2760AC0
	public void .ctor() { }

	// RVA: 0x2760BE0 Offset: 0x2760CE1 VA: 0x2760BE0
	private static void .cctor() { }
}

