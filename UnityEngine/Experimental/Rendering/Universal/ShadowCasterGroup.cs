// Namespace: UnityEngine.Experimental.Rendering.Universal
public abstract class ShadowCasterGroup2D : MonoBehaviour // TypeDefIndex: 5493
{
	// Fields
	[SerializeField] // RVA: 0x4843A0 Offset: 0x4844A1 VA: 0x4843A0
	internal int m_ShadowGroup; // 0x18
	private List<ShadowCaster2D> m_ShadowCasters; // 0x20

	// Methods

	// RVA: 0x3131EA0 Offset: 0x3131FA1 VA: 0x3131EA0
	public List<ShadowCaster2D> GetShadowCasters() { }

	// RVA: 0x3131EB0 Offset: 0x3131FB1 VA: 0x3131EB0
	public int GetShadowGroup() { }

	// RVA: 0x3131EC0 Offset: 0x3131FC1 VA: 0x3131EC0
	public void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

	// RVA: 0x3131F70 Offset: 0x3132071 VA: 0x3131F70
	public void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

	// RVA: 0x3131E90 Offset: 0x3131F91 VA: 0x3131E90
	protected void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.Universal
internal class ShadowCasterGroup2DManager // TypeDefIndex: 5494
{
	// Fields
	private static List<ShadowCasterGroup2D> s_ShadowCasterGroups; // 0x0

	// Properties
	public static List<ShadowCasterGroup2D> shadowCasterGroups { get; }

	// Methods

	// RVA: 0x3131FE0 Offset: 0x31320E1 VA: 0x3131FE0
	public static List<ShadowCasterGroup2D> get_shadowCasterGroups() { }

	// RVA: 0x3132050 Offset: 0x3132151 VA: 0x3132050
	public static void AddShadowCasterGroupToList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

	// RVA: 0x3132130 Offset: 0x3132231 VA: 0x3132130
	public static void RemoveShadowCasterGroupFromList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

	// RVA: 0x3132190 Offset: 0x3132291 VA: 0x3132190
	private static CompositeShadowCaster2D FindTopMostCompositeShadowCaster(ShadowCaster2D shadowCaster) { }

	// RVA: 0x31319B0 Offset: 0x3131AB1 VA: 0x31319B0
	public static bool AddToShadowCasterGroup(ShadowCaster2D shadowCaster, ref ShadowCasterGroup2D shadowCasterGroup) { }

	// RVA: 0x3131580 Offset: 0x3131681 VA: 0x3131580
	public static void RemoveFromShadowCasterGroup(ShadowCaster2D shadowCaster, ShadowCasterGroup2D shadowCasterGroup) { }

	// RVA: 0x3131C50 Offset: 0x3131D51 VA: 0x3131C50
	public static void AddGroup(ShadowCasterGroup2D group) { }

	// RVA: 0x3131B20 Offset: 0x3131C21 VA: 0x3131B20
	public static void RemoveGroup(ShadowCasterGroup2D group) { }

	// RVA: 0x31322A0 Offset: 0x31323A1 VA: 0x31322A0
	public void .ctor() { }

	// RVA: 0x31322B0 Offset: 0x31323B1 VA: 0x31322B0
	private static void .cctor() { }
}

