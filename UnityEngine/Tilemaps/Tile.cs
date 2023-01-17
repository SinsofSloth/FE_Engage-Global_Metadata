// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCodeAttribute] // RVA: 0x6F120 Offset: 0x6F221 VA: 0x6F120
[HelpURLAttribute] // RVA: 0x6F120 Offset: 0x6F221 VA: 0x6F120
[Serializable]
public class Tile : TileBase // TypeDefIndex: 4217
{
	// Fields
	[SerializeField] // RVA: 0x6F4B0 Offset: 0x6F5B1 VA: 0x6F4B0
	private Sprite m_Sprite; // 0x18
	[SerializeField] // RVA: 0x6F4C0 Offset: 0x6F5C1 VA: 0x6F4C0
	private Color m_Color; // 0x20
	[SerializeField] // RVA: 0x6F4D0 Offset: 0x6F5D1 VA: 0x6F4D0
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField] // RVA: 0x6F4E0 Offset: 0x6F5E1 VA: 0x6F4E0
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField] // RVA: 0x6F4F0 Offset: 0x6F5F1 VA: 0x6F4F0
	private TileFlags m_Flags; // 0x78
	[SerializeField] // RVA: 0x6F500 Offset: 0x6F601 VA: 0x6F500
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x1C69F90 Offset: 0x1C6A091 VA: 0x1C69F90
	public Sprite get_sprite() { }

	// RVA: 0x1C69FA0 Offset: 0x1C6A0A1 VA: 0x1C69FA0
	public void set_sprite(Sprite value) { }

	// RVA: 0x1C69FB0 Offset: 0x1C6A0B1 VA: 0x1C69FB0
	public Color get_color() { }

	// RVA: 0x1C69FC0 Offset: 0x1C6A0C1 VA: 0x1C69FC0
	public void set_color(Color value) { }

	// RVA: 0x1C69FE0 Offset: 0x1C6A0E1 VA: 0x1C69FE0
	public Matrix4x4 get_transform() { }

	// RVA: 0x1C6A010 Offset: 0x1C6A111 VA: 0x1C6A010
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1C6A030 Offset: 0x1C6A131 VA: 0x1C6A030
	public GameObject get_gameObject() { }

	// RVA: 0x1C6A040 Offset: 0x1C6A141 VA: 0x1C6A040
	public void set_gameObject(GameObject value) { }

	// RVA: 0x1C6A050 Offset: 0x1C6A151 VA: 0x1C6A050
	public TileFlags get_flags() { }

	// RVA: 0x1C6A060 Offset: 0x1C6A161 VA: 0x1C6A060
	public void set_flags(TileFlags value) { }

	// RVA: 0x1C6A070 Offset: 0x1C6A171 VA: 0x1C6A070
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x1C6A080 Offset: 0x1C6A181 VA: 0x1C6A080
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x1C6A090 Offset: 0x1C6A191 VA: 0x1C6A090 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x1C6A180 Offset: 0x1C6A281 VA: 0x1C6A180
	public void .ctor() { }
}

