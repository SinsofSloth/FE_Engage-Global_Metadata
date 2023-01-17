// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCodeAttribute] // RVA: 0x6F3F0 Offset: 0x6F4F1 VA: 0x6F3F0
[NativeTypeAttribute] // RVA: 0x6F3F0 Offset: 0x6F4F1 VA: 0x6F3F0
public struct TileData // TypeDefIndex: 4222
{
	// Fields
	private Sprite m_Sprite; // 0x0
	private Color m_Color; // 0x8
	private Matrix4x4 m_Transform; // 0x18
	private GameObject m_GameObject; // 0x58
	private TileFlags m_Flags; // 0x60
	private Tile.ColliderType m_ColliderType; // 0x64

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0x1C6A100 Offset: 0x1C6A201 VA: 0x1C6A100
	public void set_sprite(Sprite value) { }

	// RVA: 0x1C6A110 Offset: 0x1C6A211 VA: 0x1C6A110
	public void set_color(Color value) { }

	// RVA: 0x1C6A130 Offset: 0x1C6A231 VA: 0x1C6A130
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1C6A150 Offset: 0x1C6A251 VA: 0x1C6A150
	public void set_gameObject(GameObject value) { }

	// RVA: 0x1C6A160 Offset: 0x1C6A261 VA: 0x1C6A160
	public void set_flags(TileFlags value) { }

	// RVA: 0x1C6A170 Offset: 0x1C6A271 VA: 0x1C6A170
	public void set_colliderType(Tile.ColliderType value) { }
}

