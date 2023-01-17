// Namespace: Combat
internal class FieldLoader : MonoBehaviour // TypeDefIndex: 8855
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284A30 Offset: 0x284B31 VA: 0x284A30
	private bool <IsLoading>k__BackingField; // 0x18
	private ResourceHandle m_MapHandle; // 0x20

	// Properties
	public bool IsLoading { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AD660 Offset: 0x2AD761 VA: 0x2AD660
	// RVA: 0x2A1F170 Offset: 0x2A1F271 VA: 0x2A1F170
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD670 Offset: 0x2AD771 VA: 0x2AD670
	// RVA: 0x2A1F180 Offset: 0x2A1F281 VA: 0x2A1F180
	public void set_IsLoading(bool value) { }

	// RVA: 0x2A1F190 Offset: 0x2A1F291 VA: 0x2A1F190
	public static List<string> GetSceneNames() { }

	// RVA: 0x2A1F560 Offset: 0x2A1F661 VA: 0x2A1F560
	public void LoadScene(string mapName, Action callback) { }

	// RVA: 0x2A1F770 Offset: 0x2A1F871 VA: 0x2A1F770
	public void UnloadScene() { }

	// RVA: 0x2A1F500 Offset: 0x2A1F601 VA: 0x2A1F500
	private static string FieldNameToPath(string fieldName) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AD680 Offset: 0x2AD781 VA: 0x2AD680
	// RVA: 0x2A1F780 Offset: 0x2A1F881 VA: 0x2A1F780
	public static IEnumerator LoadMapImpl() { }

	// RVA: 0x2A1F7E0 Offset: 0x2A1F8E1 VA: 0x2A1F7E0
	public void .ctor() { }
}

