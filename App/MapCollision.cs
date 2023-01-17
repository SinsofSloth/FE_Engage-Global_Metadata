// Namespace: App
public abstract class MapCollision : MonoBehaviour // TypeDefIndex: 14022
{
	// Fields
	private MapObject m_MapObject; // 0x18
	private Renderer[] m_Renderers; // 0x20
	private float m_Alpha; // 0x28
	[HideInInspector] // RVA: 0x29D300 Offset: 0x29D401 VA: 0x29D300
	public bool m_DisableCloseTransparent; // 0x2C

	// Methods

	// RVA: 0x2C8D240 Offset: 0x2C8D341 VA: 0x2C8D240
	private static Transform GetRoot(Transform transform) { }

	// RVA: 0x2C8D330 Offset: 0x2C8D431 VA: 0x2C8D330
	private void Start() { }

	// RVA: 0x2C8D5B0 Offset: 0x2C8D6B1 VA: 0x2C8D5B0
	public MapObject GetMapObject() { }

	// RVA: 0x2C8D5C0 Offset: 0x2C8D6C1 VA: 0x2C8D5C0
	public Renderer[] GetRenderers() { }

	// RVA: 0x2C8D5D0 Offset: 0x2C8D6D1 VA: 0x2C8D5D0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2C8D670 Offset: 0x2C8D771 VA: 0x2C8D670
	public float GetAlpha() { }

	// RVA: 0x2C8D680 Offset: 0x2C8D781 VA: 0x2C8D680
	private void CommitAlpha() { }

	// RVA: 0x2C8D730 Offset: 0x2C8D831 VA: 0x2C8D730
	protected void .ctor() { }
}

