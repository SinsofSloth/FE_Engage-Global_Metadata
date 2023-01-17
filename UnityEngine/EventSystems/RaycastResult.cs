// Namespace: UnityEngine.EventSystems
public struct RaycastResult // TypeDefIndex: 4427
{
	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingLayer; // 0x1C
	public int sortingOrder; // 0x20
	public Vector3 worldPosition; // 0x24
	public Vector3 worldNormal; // 0x30
	public Vector2 screenPosition; // 0x3C
	public int displayIndex; // 0x44

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x1B72B70 Offset: 0x1B72C71 VA: 0x1B72B70
	public GameObject get_gameObject() { }

	// RVA: 0x1B72B80 Offset: 0x1B72C81 VA: 0x1B72B80
	public void set_gameObject(GameObject value) { }

	// RVA: 0x1B72B90 Offset: 0x1B72C91 VA: 0x1B72B90
	public bool get_isValid() { }

	// RVA: 0x1B72C50 Offset: 0x1B72D51 VA: 0x1B72C50
	public void Clear() { }

	// RVA: 0x1B70340 Offset: 0x1B70441 VA: 0x1B70340 Slot: 3
	public override string ToString() { }
}

