// Namespace: App
public abstract class GrassMeshHolder : ScriptableObject // TypeDefIndex: 14010
{
	// Fields
	public static readonly int StartNameWithOrgMeshNoVersion; // 0x0
	public static readonly int UV3MeshNoVersion; // 0x4
	public static readonly int CurrentVersion; // 0x8
	public int m_version; // 0x18
	public int m_splitNum; // 0x1C
	public Vector3 m_offset; // 0x20
	public Vector3 m_size; // 0x2C
	public List<Mesh> m_meshes; // 0x38

	// Methods

	// RVA: 0x27C1BF0 Offset: 0x27C1CF1 VA: 0x27C1BF0
	public void .ctor() { }

	// RVA: 0x27C1CB0 Offset: 0x27C1DB1 VA: 0x27C1CB0
	private static void .cctor() { }
}

