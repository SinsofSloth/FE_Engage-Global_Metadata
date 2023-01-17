// Namespace: UnityEngine.Rendering.LookDev
public class StageRuntimeInterface // TypeDefIndex: 4695
{
	// Fields
	private Func<bool, GameObject> m_AddGameObject; // 0x10
	private Func<Camera> m_GetCamera; // 0x18
	private Func<Light> m_GetSunLight; // 0x20
	public object SRPData; // 0x28

	// Properties
	public Camera camera { get; }
	public Light sunLight { get; }

	// Methods

	// RVA: 0x3546390 Offset: 0x3546491 VA: 0x3546390
	public void .ctor(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight) { }

	// RVA: 0x3546400 Offset: 0x3546501 VA: 0x3546400
	public GameObject AddGameObject(bool persistent = False) { }

	// RVA: 0x3546470 Offset: 0x3546571 VA: 0x3546470
	public Camera get_camera() { }

	// RVA: 0x35464D0 Offset: 0x35465D1 VA: 0x35464D0
	public Light get_sunLight() { }
}

