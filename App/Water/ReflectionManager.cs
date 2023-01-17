// Namespace: App.Water
[ExecuteInEditMode] // RVA: 0x279650 Offset: 0x279751 VA: 0x279650
[DisallowMultipleComponent] // RVA: 0x279650 Offset: 0x279751 VA: 0x279650
public class ReflectionManager : MonoBehaviour // TypeDefIndex: 14101
{
	// Fields
	private GameObject WaterMeshRoot; // 0x18
	private List<string> m_renderedList; // 0x20

	// Methods

	// RVA: 0x2526680 Offset: 0x2526781 VA: 0x2526680
	private void Start() { }

	// RVA: 0x2526760 Offset: 0x2526861 VA: 0x2526760
	private void Update() { }

	// RVA: 0x2526FE0 Offset: 0x25270E1 VA: 0x2526FE0
	private void LateUpdate() { }

	// RVA: 0x25267C0 Offset: 0x25268C1 VA: 0x25267C0
	private void RemoveNonReferenceCamera() { }

	// RVA: 0x2526F80 Offset: 0x2527081 VA: 0x2526F80
	public void ClearRenderedList() { }

	// RVA: 0x25270B0 Offset: 0x25271B1 VA: 0x25270B0
	public bool RenderReflection(Transform tr, Camera cam, short number) { }

	// RVA: 0x2527480 Offset: 0x2527581 VA: 0x2527480 Slot: 4
	public virtual ReflectionCamera AddReflectionCamera(GameObject objCamera) { }

	// RVA: 0x25274E0 Offset: 0x25275E1 VA: 0x25274E0
	public RenderTexture GetReflectionTexture(short number) { }

	// RVA: 0x2527040 Offset: 0x2527141 VA: 0x2527040
	public string GetCameraName(short number) { }

	// RVA: 0x2527590 Offset: 0x2527691 VA: 0x2527590
	public void .ctor() { }
}

