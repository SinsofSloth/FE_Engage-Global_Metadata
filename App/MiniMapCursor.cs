// Namespace: App
public class MiniMapCursor : MonoBehaviour // TypeDefIndex: 12353
{
	// Fields
	public GameObject m_CursorLT; // 0x18
	public GameObject m_CursorRT; // 0x20
	public GameObject m_CursorLB; // 0x28
	public GameObject m_CursorRB; // 0x30
	private GameObject m_OrgCursorLT; // 0x38
	private GameObject m_OrgCursorRT; // 0x40
	private GameObject m_OrgCursorLB; // 0x48
	private GameObject m_OrgCursorRB; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x299F40 Offset: 0x29A041 VA: 0x299F40
	private float <Scale>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x299F50 Offset: 0x29A051 VA: 0x299F50
	private float <CalculatedGridSize>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x299F60 Offset: 0x29A061 VA: 0x299F60
	private bool <IsCursorVisible>k__BackingField; // 0x60

	// Properties
	public float Scale { get; set; }
	public float CalculatedGridSize { get; set; }
	public bool IsCursorVisible { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C81B0 Offset: 0x2C82B1 VA: 0x2C81B0
	// RVA: 0x2274D10 Offset: 0x2274E11 VA: 0x2274D10
	public float get_Scale() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C81C0 Offset: 0x2C82C1 VA: 0x2C81C0
	// RVA: 0x2274D20 Offset: 0x2274E21 VA: 0x2274D20
	public void set_Scale(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C81D0 Offset: 0x2C82D1 VA: 0x2C81D0
	// RVA: 0x2274D30 Offset: 0x2274E31 VA: 0x2274D30
	public float get_CalculatedGridSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C81E0 Offset: 0x2C82E1 VA: 0x2C81E0
	// RVA: 0x2274D40 Offset: 0x2274E41 VA: 0x2274D40
	public void set_CalculatedGridSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C81F0 Offset: 0x2C82F1 VA: 0x2C81F0
	// RVA: 0x2274D50 Offset: 0x2274E51 VA: 0x2274D50
	public bool get_IsCursorVisible() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8200 Offset: 0x2C8301 VA: 0x2C8200
	// RVA: 0x2274D60 Offset: 0x2274E61 VA: 0x2274D60
	public void set_IsCursorVisible(bool value) { }

	// RVA: 0x2274D70 Offset: 0x2274E71 VA: 0x2274D70
	private void Start() { }

	// RVA: 0x2274D80 Offset: 0x2274E81 VA: 0x2274D80
	private void TryInitializeParts() { }

	// RVA: 0x226F000 Offset: 0x226F101 VA: 0x226F000
	public Vector3 CalculateCursorPosition(float gridSize) { }

	// RVA: 0x2274EE0 Offset: 0x2274FE1 VA: 0x2274EE0
	private void Update() { }

	// RVA: 0x226ED10 Offset: 0x226EE11 VA: 0x226ED10
	public Vector3 GetCenter() { }

	// RVA: 0x2275220 Offset: 0x2275321 VA: 0x2275220
	private static Vector3 GetPosition(GameObject obj) { }

	// RVA: 0x2275280 Offset: 0x2275381 VA: 0x2275280
	public void .ctor() { }
}

