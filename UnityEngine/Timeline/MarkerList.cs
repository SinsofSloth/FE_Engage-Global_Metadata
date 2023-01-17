// Namespace: UnityEngine.Timeline
[DefaultMemberAttribute] // RVA: 0x56B30 Offset: 0x56C31 VA: 0x56B30
[Serializable]
internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 5666
{
	// Fields
	[SerializeField] // RVA: 0x57C80 Offset: 0x57D81 VA: 0x57C80
	[HideInInspector] // RVA: 0x57C80 Offset: 0x57D81 VA: 0x57C80
	private List<ScriptableObject> m_Objects; // 0x0
	[HideInInspector] // RVA: 0x57CC0 Offset: 0x57DC1 VA: 0x57CC0
	private List<IMarker> m_Cache; // 0x8
	private bool m_CacheDirty; // 0x10
	private bool m_HasNotifications; // 0x11

	// Properties
	public List<IMarker> markers { get; }
	public int Count { get; }
	public IMarker Item { get; }

	// Methods

	// RVA: 0x36A5BD0 Offset: 0x36A5CD1 VA: 0x36A5BD0
	public List<IMarker> get_markers() { }

	// RVA: 0x36A5E60 Offset: 0x36A5F61 VA: 0x36A5E60
	public void .ctor(int capacity) { }

	// RVA: 0x36A5F60 Offset: 0x36A6061 VA: 0x36A5F60
	public void Add(ScriptableObject item) { }

	// RVA: 0x36A6010 Offset: 0x36A6111 VA: 0x36A6010
	public bool Remove(IMarker item) { }

	// RVA: 0x36A63A0 Offset: 0x36A64A1 VA: 0x36A63A0
	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	// RVA: 0x36A6570 Offset: 0x36A6671 VA: 0x36A6570
	public void Clear() { }

	// RVA: 0x36A65D0 Offset: 0x36A66D1 VA: 0x36A65D0
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0x36A6600 Offset: 0x36A6701 VA: 0x36A6600
	public int get_Count() { }

	// RVA: 0x36A6650 Offset: 0x36A6751 VA: 0x36A6650
	public IMarker get_Item(int idx) { }

	// RVA: 0x36A66D0 Offset: 0x36A67D1 VA: 0x36A66D0
	public List<ScriptableObject> GetRawMarkerList() { }

	// RVA: 0x36A66E0 Offset: 0x36A67E1 VA: 0x36A66E0
	public IMarker CreateMarker(Type type, double time, TrackAsset owner) { }

	// RVA: 0x36A6C30 Offset: 0x36A6D31 VA: 0x36A6C30
	public bool HasNotifications() { }

	// RVA: 0x36A6C60 Offset: 0x36A6D61 VA: 0x36A6C60 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x36A6C70 Offset: 0x36A6D71 VA: 0x36A6C70 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x36A5C00 Offset: 0x36A5D01 VA: 0x36A5C00
	private void BuildCache() { }
}

