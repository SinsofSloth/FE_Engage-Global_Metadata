// Namespace: UnityEngine.SceneManagement
[NativeHeaderAttribute] // RVA: 0x43F9E0 Offset: 0x43FAE1 VA: 0x43F9E0
[Serializable]
public struct Scene // TypeDefIndex: 3711
{
	// Fields
	[SerializeField] // RVA: 0x444460 Offset: 0x444561 VA: 0x444460
	[HideInInspector] // RVA: 0x444460 Offset: 0x444561 VA: 0x444460
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string path { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0x4529A0 Offset: 0x452AA1 VA: 0x4529A0
	// RVA: 0x31E1AF0 Offset: 0x31E1BF1 VA: 0x31E1AF0
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0x4529E0 Offset: 0x452AE1 VA: 0x4529E0
	// RVA: 0x31E1B40 Offset: 0x31E1C41 VA: 0x31E1B40
	private static string GetPathInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0x452A20 Offset: 0x452B21 VA: 0x452A20
	// RVA: 0x31E1B90 Offset: 0x31E1C91 VA: 0x31E1B90
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0x452A60 Offset: 0x452B61 VA: 0x452A60
	// RVA: 0x31E1BE0 Offset: 0x31E1CE1 VA: 0x31E1BE0
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0x452AA0 Offset: 0x452BA1 VA: 0x452AA0
	// RVA: 0x31E1C30 Offset: 0x31E1D31 VA: 0x31E1C30
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0x452AE0 Offset: 0x452BE1 VA: 0x452AE0
	// RVA: 0x31E1C80 Offset: 0x31E1D81 VA: 0x31E1C80
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x31E1CD0 Offset: 0x31E1DD1 VA: 0x31E1CD0
	public int get_handle() { }

	// RVA: 0x31E1CE0 Offset: 0x31E1DE1 VA: 0x31E1CE0
	public bool IsValid() { }

	// RVA: 0x31E1D30 Offset: 0x31E1E31 VA: 0x31E1D30
	public string get_path() { }

	// RVA: 0x31E1D80 Offset: 0x31E1E81 VA: 0x31E1D80
	public string get_name() { }

	// RVA: 0x31E1DD0 Offset: 0x31E1ED1 VA: 0x31E1DD0
	public bool get_isLoaded() { }

	// RVA: 0x31E1E20 Offset: 0x31E1F21 VA: 0x31E1E20
	public int get_rootCount() { }

	// RVA: 0x31E1E70 Offset: 0x31E1F71 VA: 0x31E1E70
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x31E1F50 Offset: 0x31E2051 VA: 0x31E1F50
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x31E21B0 Offset: 0x31E22B1 VA: 0x31E21B0
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x31E21C0 Offset: 0x31E22C1 VA: 0x31E21C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31E21D0 Offset: 0x31E22D1 VA: 0x31E21D0 Slot: 0
	public override bool Equals(object other) { }
}

