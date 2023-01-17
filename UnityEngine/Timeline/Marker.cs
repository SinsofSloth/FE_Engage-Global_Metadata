// Namespace: UnityEngine.Timeline
public abstract class Marker : ScriptableObject, IMarker // TypeDefIndex: 5665
{
	// Fields
	[TimeFieldAttribute] // RVA: 0x57C10 Offset: 0x57D11 VA: 0x57C10
	[SerializeField] // RVA: 0x57C10 Offset: 0x57D11 VA: 0x57C10
	[TooltipAttribute] // RVA: 0x57C10 Offset: 0x57D11 VA: 0x57C10
	private double m_Time; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x57C70 Offset: 0x57D71 VA: 0x57C70
	private TrackAsset <parent>k__BackingField; // 0x20

	// Properties
	public TrackAsset parent { get; set; }
	public double time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x58200 Offset: 0x58301 VA: 0x58200
	// RVA: 0x36A5960 Offset: 0x36A5A61 VA: 0x36A5960 Slot: 6
	public TrackAsset get_parent() { }

	[CompilerGeneratedAttribute] // RVA: 0x58210 Offset: 0x58311 VA: 0x58210
	// RVA: 0x36A5970 Offset: 0x36A5A71 VA: 0x36A5970
	private void set_parent(TrackAsset value) { }

	// RVA: 0x36A5980 Offset: 0x36A5A81 VA: 0x36A5980 Slot: 4
	public double get_time() { }

	// RVA: 0x36A5990 Offset: 0x36A5A91 VA: 0x36A5990 Slot: 5
	public void set_time(double value) { }

	// RVA: 0x36A5A20 Offset: 0x36A5B21 VA: 0x36A5A20 Slot: 7
	private void UnityEngine.Timeline.IMarker.Initialize(TrackAsset parentTrack) { }

	// RVA: 0x36A5BB0 Offset: 0x36A5CB1 VA: 0x36A5BB0 Slot: 8
	public virtual void OnInitialize(TrackAsset aPent) { }

	// RVA: 0x36A5BC0 Offset: 0x36A5CC1 VA: 0x36A5BC0
	protected void .ctor() { }
}

