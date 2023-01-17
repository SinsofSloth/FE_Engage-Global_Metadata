// Namespace: 
[RequireComponent] // RVA: 0x2714B0 Offset: 0x2715B1 VA: 0x2714B0
[RequireComponent] // RVA: 0x2714B0 Offset: 0x2715B1 VA: 0x2714B0
public class MapInfoEvent : MonoBehaviour // TypeDefIndex: 7624
{
	// Fields
	private Map.CellMesh m_Mesh; // 0x18
	public Material[] m_Materials; // 0x20
	private static readonly Color COLOR_DARK; // 0x0
	private static readonly Color COLOR_VTX0; // 0x10
	private static readonly Color COLOR_VTX1; // 0x20
	private static readonly Color COLOR_VTX2; // 0x30
	private static readonly Color COLOR_VTX3; // 0x40
	private static readonly Vector2 UV_ZERO; // 0x50
	private int m_SubMeshCount; // 0x28
	public Color m_VisitColor; // 0x2C
	public Color m_EscapeColor; // 0x3C
	public Color m_BreakdownEnemyColor; // 0x4C
	public AnimationCurve m_ScrollCurve; // 0x60
	public AnimationCurve m_AlphaCurve; // 0x68
	private int m_SpeedPropertyID; // 0x70
	private int m_AlphaPropertyID; // 0x74
	private float m_Time; // 0x78

	// Methods

	// RVA: 0x247E650 Offset: 0x247E751 VA: 0x247E650
	private void Start() { }

	// RVA: 0x247E770 Offset: 0x247E871 VA: 0x247E770
	private void Draw(int x, int z, Color color) { }

	// RVA: 0x247F0B0 Offset: 0x247F1B1 VA: 0x247F0B0
	private void Draw(int x, int z, Color color, int value) { }

	// RVA: 0x247F8B0 Offset: 0x247F9B1 VA: 0x247F8B0
	private void Draw(int x, int z, Color color, string name) { }

	// RVA: 0x24800B0 Offset: 0x24801B1 VA: 0x24800B0
	private void Draw(MapInspector inspector, Color color) { }

	// RVA: 0x2480CE0 Offset: 0x2480DE1 VA: 0x2480CE0
	private void DrawEventVertex(MapInspector inspector) { }

	// RVA: 0x24816A0 Offset: 0x24817A1 VA: 0x24816A0
	private void Update() { }

	// RVA: 0x2481700 Offset: 0x2481801 VA: 0x2481700
	private void UpdateEventVertex() { }

	// RVA: 0x2481810 Offset: 0x2481911 VA: 0x2481810
	private void UpdateScrollAnimation() { }

	// RVA: 0x2481940 Offset: 0x2481A41 VA: 0x2481940
	public void .ctor() { }

	// RVA: 0x2481950 Offset: 0x2481A51 VA: 0x2481950
	private static void .cctor() { }
}

