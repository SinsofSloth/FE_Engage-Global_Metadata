// Namespace: 
public enum TargetPositionCache.Mode // TypeDefIndex: 5860
{
	// Fields
	public int value__; // 0x0
	public const TargetPositionCache.Mode Disabled = 0;
	public const TargetPositionCache.Mode Record = 1;
	public const TargetPositionCache.Mode Playback = 2;
}

// Namespace: 
private class TargetPositionCache.CacheCurve // TypeDefIndex: 5862
{
	// Fields
	public float StartTime; // 0x10
	public float StepSize; // 0x14
	private List<TargetPositionCache.CacheCurve.Item> m_Cache; // 0x18

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x1A8B780 Offset: 0x1A8B881 VA: 0x1A8B780
	public int get_Count() { }

	// RVA: 0x1A8B7D0 Offset: 0x1A8B8D1 VA: 0x1A8B7D0
	public void .ctor(float startTime, float endTime, float stepSize) { }

	// RVA: 0x1A8B8A0 Offset: 0x1A8B9A1 VA: 0x1A8B8A0
	public void Add(TargetPositionCache.CacheCurve.Item item) { }

	// RVA: 0x1A8B930 Offset: 0x1A8BA31 VA: 0x1A8B930
	public void AddUntil(TargetPositionCache.CacheCurve.Item item, float time, bool isCut) { }

	// RVA: 0x1A86440 Offset: 0x1A86541 VA: 0x1A86440
	public TargetPositionCache.CacheCurve.Item Evaluate(float time) { }
}

// Namespace: 
private class TargetPositionCache.CacheEntry // TypeDefIndex: 5864
{
	// Fields
	public TargetPositionCache.CacheCurve Curve; // 0x10
	private List<TargetPositionCache.CacheEntry.RecordingItem> RawItems; // 0x18

	// Methods

	// RVA: 0x1A86220 Offset: 0x1A86321 VA: 0x1A86220
	public void AddRawItem(float time, bool isCut, Transform target) { }

	// RVA: 0x1A85E90 Offset: 0x1A85F91 VA: 0x1A85E90
	public void CreateCurves() { }

	// RVA: 0x1A86190 Offset: 0x1A86291 VA: 0x1A86190
	public void .ctor() { }
}

