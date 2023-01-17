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

