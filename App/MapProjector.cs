// Namespace: App
[ExecuteInEditMode] // RVA: 0x279490 Offset: 0x279591 VA: 0x279490
public abstract class MapProjector : MonoBehaviour // TypeDefIndex: 14040
{
	// Fields
	public Material m_Material; // 0x18
	public Texture2D m_Texture; // 0x20
	public Color m_Color; // 0x28
	[SerializeField] // RVA: 0x29D500 Offset: 0x29D601 VA: 0x29D500
	[RangeAttribute] // RVA: 0x29D500 Offset: 0x29D601 VA: 0x29D500
	public float m_Scale; // 0x38
	[SerializeField] // RVA: 0x29D550 Offset: 0x29D651 VA: 0x29D550
	[RangeAttribute] // RVA: 0x29D550 Offset: 0x29D651 VA: 0x29D550
	public float m_DirectionX; // 0x3C
	[SerializeField] // RVA: 0x29D590 Offset: 0x29D691 VA: 0x29D590
	[RangeAttribute] // RVA: 0x29D590 Offset: 0x29D691 VA: 0x29D590
	public float m_DirectionY; // 0x40
	[RangeAttribute] // RVA: 0x29D5D0 Offset: 0x29D6D1 VA: 0x29D5D0
	[SerializeField] // RVA: 0x29D5D0 Offset: 0x29D6D1 VA: 0x29D5D0
	public float m_Speed; // 0x44
	[RangeAttribute] // RVA: 0x29D610 Offset: 0x29D711 VA: 0x29D610
	[SerializeField] // RVA: 0x29D610 Offset: 0x29D711 VA: 0x29D610
	public float m_OffsetX; // 0x48
	[SerializeField] // RVA: 0x29D650 Offset: 0x29D751 VA: 0x29D650
	[RangeAttribute] // RVA: 0x29D650 Offset: 0x29D751 VA: 0x29D650
	public float m_OffsetY; // 0x4C
	private Material m_Instance; // 0x50
	private float m_ScrollX; // 0x58
	private float m_ScrollY; // 0x5C

	// Methods

	// RVA: 0x278E440 Offset: 0x278E541 VA: 0x278E440
	private void TryCreateInstance() { }

	// RVA: 0x278E750 Offset: 0x278E851 VA: 0x278E750
	private void Start() { }

	// RVA: 0x278E760 Offset: 0x278E861 VA: 0x278E760
	private void Update() { }

	// RVA: 0x278E790 Offset: 0x278E891 VA: 0x278E790
	private void UpdateScroll() { }

	// RVA: 0x278E630 Offset: 0x278E731 VA: 0x278E630
	private void UpdateMaterial() { }

	// RVA: 0x278E870 Offset: 0x278E971 VA: 0x278E870
	protected void .ctor() { }
}

