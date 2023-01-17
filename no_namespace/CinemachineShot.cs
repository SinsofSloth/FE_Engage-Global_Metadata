// Namespace: 
public sealed class CinemachineShot : PlayableAsset, IPropertyPreview // TypeDefIndex: 5727
{
	// Fields
	public string DisplayName; // 0x18
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x20

	// Methods

	// RVA: 0x1BA7270 Offset: 0x1BA7371 VA: 0x1BA7270 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1BA73B0 Offset: 0x1BA74B1 VA: 0x1BA73B0 Slot: 9
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x1BA7910 Offset: 0x1BA7A11 VA: 0x1BA7910
	public void .ctor() { }
}

