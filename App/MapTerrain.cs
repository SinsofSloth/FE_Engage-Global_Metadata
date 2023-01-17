// Namespace: App
[Serializable]
public abstract class MapTerrain : ScriptableObject // TypeDefIndex: 14045
{
	// Fields
	public const string Root = "GameData/Terrains/";
	[SerializeField] // RVA: 0x29D6A0 Offset: 0x29D7A1 VA: 0x29D6A0
	[HideInInspector] // RVA: 0x29D6A0 Offset: 0x29D7A1 VA: 0x29D6A0
	public int m_X; // 0x18
	[SerializeField] // RVA: 0x29D6E0 Offset: 0x29D7E1 VA: 0x29D6E0
	[HideInInspector] // RVA: 0x29D6E0 Offset: 0x29D7E1 VA: 0x29D6E0
	public int m_Z; // 0x1C
	[HideInInspector] // RVA: 0x29D720 Offset: 0x29D821 VA: 0x29D720
	[RangeAttribute] // RVA: 0x29D720 Offset: 0x29D821 VA: 0x29D720
	[SerializeField] // RVA: 0x29D720 Offset: 0x29D821 VA: 0x29D720
	public int m_Width; // 0x20
	[RangeAttribute] // RVA: 0x29D780 Offset: 0x29D881 VA: 0x29D780
	[SerializeField] // RVA: 0x29D780 Offset: 0x29D881 VA: 0x29D780
	[HideInInspector] // RVA: 0x29D780 Offset: 0x29D881 VA: 0x29D780
	public int m_Height; // 0x24
	[SerializeField] // RVA: 0x29D7E0 Offset: 0x29D8E1 VA: 0x29D7E0
	public List<MapTerrain.LayerData> m_Layers; // 0x28
	[SerializeField] // RVA: 0x29D7F0 Offset: 0x29D8F1 VA: 0x29D7F0
	public List<MapTerrain.OverlapData> m_Overlaps; // 0x30
	[SerializeField] // RVA: 0x29D800 Offset: 0x29D901 VA: 0x29D800
	public string[] m_Terrains; // 0x38

	// Methods

	// RVA: 0x2752720 Offset: 0x2752821 VA: 0x2752720
	public void SetTid(int x, int z, string tid) { }

	// RVA: 0x27527A0 Offset: 0x27528A1 VA: 0x27527A0
	public string GetTid(int x, int z) { }

	// RVA: 0x27527E0 Offset: 0x27528E1 VA: 0x27527E0
	public void .ctor() { }

	// RVA: 0x2752920 Offset: 0x2752A21 VA: 0x2752920
	public void Clear(string tid) { }

	// RVA: 0x2752A70 Offset: 0x2752B71 VA: 0x2752A70
	public void UpdateMapImage() { }
}

