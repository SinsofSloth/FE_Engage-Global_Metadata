// Namespace: App
public abstract class TerrainPaintData : ScriptableObject // TypeDefIndex: 9001
{
	// Fields
	[SerializeField] // RVA: 0x285870 Offset: 0x285971 VA: 0x285870
	[HideInInspector] // RVA: 0x285870 Offset: 0x285971 VA: 0x285870
	private int SplitCount; // 0x18
	[HideInInspector] // RVA: 0x2858B0 Offset: 0x2859B1 VA: 0x2858B0
	[SerializeField] // RVA: 0x2858B0 Offset: 0x2859B1 VA: 0x2858B0
	private Vector2 TerrainSize; // 0x1C
	[SerializeField] // RVA: 0x2858F0 Offset: 0x2859F1 VA: 0x2858F0
	[HideInInspector] // RVA: 0x2858F0 Offset: 0x2859F1 VA: 0x2858F0
	private string[] Name; // 0x28
	[HideInInspector] // RVA: 0x285930 Offset: 0x285A31 VA: 0x285930
	[SerializeField] // RVA: 0x285930 Offset: 0x285A31 VA: 0x285930
	private int[] Index; // 0x30

	// Properties
	public Vector2 _TerrainSize { get; set; }
	public int _SplitCount { get; set; }
	public string[] _Name { get; set; }
	public int[] _Index { get; set; }

	// Methods

	// RVA: 0x25D8E00 Offset: 0x25D8F01 VA: 0x25D8E00
	public void set__TerrainSize(Vector2 value) { }

	// RVA: 0x25D8E10 Offset: 0x25D8F11 VA: 0x25D8E10
	public Vector2 get__TerrainSize() { }

	// RVA: 0x25D8E20 Offset: 0x25D8F21 VA: 0x25D8E20
	public void set__SplitCount(int value) { }

	// RVA: 0x25D8E30 Offset: 0x25D8F31 VA: 0x25D8E30
	public int get__SplitCount() { }

	// RVA: 0x25D8E40 Offset: 0x25D8F41 VA: 0x25D8E40
	public void set__Name(string[] value) { }

	// RVA: 0x25D8E50 Offset: 0x25D8F51 VA: 0x25D8E50
	public string[] get__Name() { }

	// RVA: 0x25D8E60 Offset: 0x25D8F61 VA: 0x25D8E60
	public void set__Index(int[] value) { }

	// RVA: 0x25D8E70 Offset: 0x25D8F71 VA: 0x25D8E70
	public int[] get__Index() { }

	// RVA: 0x25D8E80 Offset: 0x25D8F81 VA: 0x25D8E80
	protected void .ctor() { }
}

