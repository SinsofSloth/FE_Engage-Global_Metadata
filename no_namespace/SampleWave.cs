// Namespace: 
private struct SampleWave.Data // TypeDefIndex: 7653
{
	// Fields
	public float VectorU; // 0x0
	public float VectorV; // 0x4
	public float OffsetU; // 0x8
	public float OffsetV; // 0xC
}

// Namespace: 
private struct SampleWave.Temp // TypeDefIndex: 7654
{
	// Fields
	public float OffsetU; // 0x0
	public float OffsetV; // 0x4
}

// Namespace: 
[ExecuteInEditMode] // RVA: 0x2717A0 Offset: 0x2718A1 VA: 0x2717A0
public class SampleWave : MonoBehaviour // TypeDefIndex: 7655
{
	// Fields
	private Texture2D m_WaveTex; // 0x18
	private Color[] m_Colors; // 0x20
	private SampleWave.Data[] m_Datas; // 0x28
	private SampleWave.Temp[] m_Temps; // 0x30
	private const int SIZE = 32;
	public Material m_Material; // 0x38
	[SerializeField] // RVA: 0x27BE60 Offset: 0x27BF61 VA: 0x27BE60
	[RangeAttribute] // RVA: 0x27BE60 Offset: 0x27BF61 VA: 0x27BE60
	public float m_Ratio; // 0x40
	[SerializeField] // RVA: 0x27BEA0 Offset: 0x27BFA1 VA: 0x27BEA0
	[RangeAttribute] // RVA: 0x27BEA0 Offset: 0x27BFA1 VA: 0x27BEA0
	public float m_Scale; // 0x44

	// Methods

	// RVA: 0x205F060 Offset: 0x205F161 VA: 0x205F060
	private void Start() { }

	// RVA: 0x205F610 Offset: 0x205F711 VA: 0x205F610
	private void Update() { }

	// RVA: 0x205F620 Offset: 0x205F721 VA: 0x205F620
	private void UpdateWave() { }

	// RVA: 0x205F340 Offset: 0x205F441 VA: 0x205F340
	private void ResetWave() { }

	// RVA: 0x205F1E0 Offset: 0x205F2E1 VA: 0x205F1E0
	private void UpdateColor(Color color) { }

	// RVA: 0x205F470 Offset: 0x205F571 VA: 0x205F470
	private void CreateMaterial() { }

	// RVA: 0x205FA80 Offset: 0x205FB81 VA: 0x205FA80
	public void .ctor() { }
}

