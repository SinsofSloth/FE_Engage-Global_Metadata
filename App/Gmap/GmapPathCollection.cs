// Namespace: App.Gmap
public class GmapPathCollection // TypeDefIndex: 14274
{
	// Fields
	private GameObject m_Root; // 0x10
	private List<GameObject> m_PathList; // 0x18

	// Methods

	// RVA: 0x2CE30E0 Offset: 0x2CE31E1 VA: 0x2CE30E0
	public void .ctor(GameObject root) { }

	// RVA: 0x2CE3270 Offset: 0x2CE3371 VA: 0x2CE3270
	public void UpdateVisible() { }

	// RVA: 0x2CE3370 Offset: 0x2CE3471 VA: 0x2CE3370
	public void SetChild(GameObject pathObject) { }

	// RVA: 0x2CE33C0 Offset: 0x2CE34C1 VA: 0x2CE33C0
	public void ForEach(Action<GameObject> action) { }

	// RVA: 0x2CE34F0 Offset: 0x2CE35F1 VA: 0x2CE34F0
	public CinemachinePathBase GetGmapPath(GmapSpot now, GmapSpot next, out bool isForward) { }

	// RVA: 0x2CE3190 Offset: 0x2CE3291 VA: 0x2CE3190
	private void UpdatePathList() { }

	// RVA: 0x2CE37B0 Offset: 0x2CE38B1 VA: 0x2CE37B0
	public GameObject CheckAppearGmapPath(out GmapSpot startSpot, out GmapSpot appearSpot) { }
}

