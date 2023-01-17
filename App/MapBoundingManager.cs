// Namespace: App
public abstract class MapBoundingManager : SingletonMonoBehaviour<MapBoundingManager> // TypeDefIndex: 14021
{
	// Fields
	public GameObject m_Prefab; // 0x20
	private BoxCollider[] m_Colliders; // 0x28

	// Methods

	// RVA: 0x2C895C0 Offset: 0x2C896C1 VA: 0x2C895C0
	private void Start() { }

	// RVA: 0x2C89680 Offset: 0x2C89781 VA: 0x2C89680
	public static bool TryGetIntercect(Vector3 pos, out MapBounding bounding) { }

	// RVA: 0x2C89880 Offset: 0x2C89981 VA: 0x2C89880
	protected void .ctor() { }
}

