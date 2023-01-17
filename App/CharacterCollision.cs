// Namespace: App
public abstract class CharacterCollision : MonoBehaviour // TypeDefIndex: 13987
{
	// Fields
	public CharacterCollision.Kinds m_Kinds; // 0x18
	public Color m_Color; // 0x1C
	private float m_Radius; // 0x2C
	private float m_Result; // 0x30

	// Methods

	// RVA: 0x2B6F480 Offset: 0x2B6F581 VA: 0x2B6F480
	private void Awake() { }

	// RVA: 0x2B6F510 Offset: 0x2B6F611 VA: 0x2B6F510
	private void OnEnable() { }

	// RVA: 0x2B6F520 Offset: 0x2B6F621 VA: 0x2B6F520
	private void OnDisable() { }

	// RVA: 0x2B6F530 Offset: 0x2B6F631 VA: 0x2B6F530
	public CharacterCollision.Kinds GetKind() { }

	// RVA: 0x2B6F540 Offset: 0x2B6F641 VA: 0x2B6F540
	public float GetRadius() { }

	// RVA: 0x2B6F550 Offset: 0x2B6F651 VA: 0x2B6F550
	public void SetOffset(float moveOffset, float sizeOffset) { }

	// RVA: 0x2B6F5D0 Offset: 0x2B6F6D1 VA: 0x2B6F5D0
	protected void .ctor() { }
}

