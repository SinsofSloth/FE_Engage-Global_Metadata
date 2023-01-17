// Namespace: App
public abstract class TerrainPaintGetter : MonoBehaviour, IPaintGetter // TypeDefIndex: 9003
{
	// Fields
	public TerrainPaintData m_Data; // 0x18
	public bool m_drawDebugGizmo; // 0x20
	public float m_debugGizmoHeight; // 0x24
	public Color m_debugGizmoGridColor; // 0x28
	public List<int> m_debugGizmoDrawIndex; // 0x38
	[RangeAttribute] // RVA: 0x285970 Offset: 0x285A71 VA: 0x285970
	public float m_debugGizmoDrawAlpha; // 0x40
	public List<Color> m_debugGizmoDrawColor; // 0x48

	// Methods

	// RVA: 0x25D8EA0 Offset: 0x25D8FA1 VA: 0x25D8EA0 Slot: 4
	public string Get(float x, float y) { }

	// RVA: 0x25D9020 Offset: 0x25D9121 VA: 0x25D9020
	public string Get(Vector2 pos) { }

	// RVA: 0x25D9030 Offset: 0x25D9131 VA: 0x25D9030
	private void OnDrawGizmos() { }

	// RVA: 0x25D93C0 Offset: 0x25D94C1 VA: 0x25D93C0
	protected void .ctor() { }
}

