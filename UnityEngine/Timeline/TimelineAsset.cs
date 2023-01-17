// Namespace: UnityEngine.Timeline
[ExcludeFromPresetAttribute] // RVA: 0x56AA0 Offset: 0x56BA1 VA: 0x56AA0
[Serializable]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 5646
{
	// Fields
	private const int k_LatestVersion = 0;
	[HideInInspector] // RVA: 0x57700 Offset: 0x57801 VA: 0x57700
	[SerializeField] // RVA: 0x57700 Offset: 0x57801 VA: 0x57700
	private int m_Version; // 0x18
	[HideInInspector] // RVA: 0x57740 Offset: 0x57841 VA: 0x57740
	[SerializeField] // RVA: 0x57740 Offset: 0x57841 VA: 0x57740
	private List<ScriptableObject> m_Tracks; // 0x20
	[HideInInspector] // RVA: 0x57780 Offset: 0x57881 VA: 0x57780
	[SerializeField] // RVA: 0x57780 Offset: 0x57881 VA: 0x57780
	private double m_FixedDuration; // 0x28
	[HideInInspector] // RVA: 0x577C0 Offset: 0x578C1 VA: 0x577C0
	private TrackAsset[] m_CacheOutputTracks; // 0x30
	[HideInInspector] // RVA: 0x577D0 Offset: 0x578D1 VA: 0x577D0
	private List<TrackAsset> m_CacheRootTracks; // 0x38
	[HideInInspector] // RVA: 0x577E0 Offset: 0x578E1 VA: 0x577E0
	private List<TrackAsset> m_CacheFlattenedTracks; // 0x40
	[HideInInspector] // RVA: 0x577F0 Offset: 0x578F1 VA: 0x577F0
	[SerializeField] // RVA: 0x577F0 Offset: 0x578F1 VA: 0x577F0
	private TimelineAsset.EditorSettings m_EditorSettings; // 0x48
	[SerializeField] // RVA: 0x57830 Offset: 0x57931 VA: 0x57830
	private TimelineAsset.DurationMode m_DurationMode; // 0x50
	[HideInInspector] // RVA: 0x57840 Offset: 0x57941 VA: 0x57840
	[SerializeField] // RVA: 0x57840 Offset: 0x57941 VA: 0x57840
	private MarkerTrack m_MarkerTrack; // 0x58

	// Properties
	public TimelineAsset.EditorSettings editorSettings { get; }
	public override double duration { get; }
	public double fixedDuration { get; set; }
	public TimelineAsset.DurationMode durationMode { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }
	public int outputTrackCount { get; }
	public int rootTrackCount { get; }
	internal IEnumerable<TrackAsset> flattenedTracks { get; }
	public MarkerTrack markerTrack { get; }
	internal List<ScriptableObject> trackObjects { get; }

	// Methods

	// RVA: 0x36AAB80 Offset: 0x36AAC81 VA: 0x36AAB80
	private void UpgradeToLatestVersion() { }

	// RVA: 0x36AAB90 Offset: 0x36AAC91 VA: 0x36AAB90
	public TimelineAsset.EditorSettings get_editorSettings() { }

	// RVA: 0x36AABA0 Offset: 0x36AACA1 VA: 0x36AABA0 Slot: 7
	public override double get_duration() { }

	// RVA: 0x36AB220 Offset: 0x36AB321 VA: 0x36AB220
	public double get_fixedDuration() { }

	// RVA: 0x36AB3C0 Offset: 0x36AB4C1 VA: 0x36AB3C0
	public void set_fixedDuration(double value) { }

	// RVA: 0x36AB450 Offset: 0x36AB551 VA: 0x36AB450
	public TimelineAsset.DurationMode get_durationMode() { }

	// RVA: 0x36AB460 Offset: 0x36AB561 VA: 0x36AB460
	public void set_durationMode(TimelineAsset.DurationMode value) { }

	[IteratorStateMachineAttribute] // RVA: 0x57FA0 Offset: 0x580A1 VA: 0x57FA0
	// RVA: 0x36AB470 Offset: 0x36AB571 VA: 0x36AB470 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x36AB540 Offset: 0x36AB641 VA: 0x36AB540 Slot: 11
	public ClipCaps get_clipCaps() { }

	// RVA: 0x36AB960 Offset: 0x36ABA61 VA: 0x36AB960
	public int get_outputTrackCount() { }

	// RVA: 0x36ABDA0 Offset: 0x36ABEA1 VA: 0x36ABDA0
	public int get_rootTrackCount() { }

	// RVA: 0x36AC0C0 Offset: 0x36AC1C1 VA: 0x36AC0C0
	private void OnValidate() { }

	// RVA: 0x36AC1A0 Offset: 0x36AC2A1 VA: 0x36AC1A0
	internal static float GetValidFramerate(float framerate) { }

	// RVA: 0x36AC2B0 Offset: 0x36AC3B1 VA: 0x36AC2B0
	public TrackAsset GetRootTrack(int index) { }

	// RVA: 0x36AB830 Offset: 0x36AB931 VA: 0x36AB830
	public IEnumerable<TrackAsset> GetRootTracks() { }

	// RVA: 0x36AC330 Offset: 0x36AC431 VA: 0x36AC330
	public TrackAsset GetOutputTrack(int index) { }

	// RVA: 0x36AC380 Offset: 0x36AC481 VA: 0x36AC380
	public IEnumerable<TrackAsset> GetOutputTracks() { }

	// RVA: 0x36ABDF0 Offset: 0x36ABEF1 VA: 0x36ABDF0
	private void UpdateRootTrackCache() { }

	// RVA: 0x36AB990 Offset: 0x36ABA91 VA: 0x36AB990
	private void UpdateOutputTrackCache() { }

	// RVA: 0x36AC3B0 Offset: 0x36AC4B1 VA: 0x36AC3B0
	internal IEnumerable<TrackAsset> get_flattenedTracks() { }

	// RVA: 0x36AC7F0 Offset: 0x36AC8F1 VA: 0x36AC7F0
	public MarkerTrack get_markerTrack() { }

	// RVA: 0x36AC800 Offset: 0x36AC901 VA: 0x36AC800
	internal List<ScriptableObject> get_trackObjects() { }

	// RVA: 0x36AC810 Offset: 0x36AC911 VA: 0x36AC810
	internal void AddTrackInternal(TrackAsset track) { }

	// RVA: 0x36AC900 Offset: 0x36ACA01 VA: 0x36AC900
	internal void RemoveTrack(TrackAsset track) { }

	// RVA: 0x36ACB40 Offset: 0x36ACC41 VA: 0x36ACB40 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x36ACF10 Offset: 0x36AD011 VA: 0x36ACF10 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x36ACF20 Offset: 0x36AD021 VA: 0x36ACF20 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x36ACF70 Offset: 0x36AD071 VA: 0x36ACF70
	private void __internalAwake() { }

	// RVA: 0x36AD140 Offset: 0x36AD241 VA: 0x36AD140 Slot: 12
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x36AD5D0 Offset: 0x36AD6D1 VA: 0x36AD5D0
	public void CreateMarkerTrack() { }

	// RVA: 0x36AC8B0 Offset: 0x36AC9B1 VA: 0x36AC8B0
	internal void Invalidate() { }

	// RVA: 0x36AD700 Offset: 0x36AD801 VA: 0x36AD700
	internal void UpdateFixedDurationWithItemsDuration() { }

	// RVA: 0x36AAD30 Offset: 0x36AAE31 VA: 0x36AAD30
	private DiscreteTime CalculateItemsDuration() { }

	// RVA: 0x36AC4F0 Offset: 0x36AC5F1 VA: 0x36AC4F0
	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks) { }

	// RVA: 0x36AD8C0 Offset: 0x36AD9C1 VA: 0x36AD8C0
	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name) { }

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(TrackAsset parent, string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2027F30 Offset: 0x2028031 VA: 0x2027F30
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2027E50 Offset: 0x2027F51 VA: 0x2027E50
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2027D60 Offset: 0x2027E61 VA: 0x2027D60
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: 0x36AE5D0 Offset: 0x36AE6D1 VA: 0x36AE5D0
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x36AEB70 Offset: 0x36AEC71 VA: 0x36AEB70
	public bool DeleteTrack(TrackAsset track) { }

	// RVA: 0x36AF2E0 Offset: 0x36AF3E1 VA: 0x36AF2E0
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x36AE310 Offset: 0x36AE411 VA: 0x36AE310
	internal TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType) { }

	// RVA: 0x36AF0B0 Offset: 0x36AF1B1 VA: 0x36AF0B0
	private void DeleteRecordedAnimation(TrackAsset track) { }

	// RVA: 0x36AE8C0 Offset: 0x36AE9C1 VA: 0x36AE8C0
	private void DeleteRecordedAnimation(TimelineClip clip) { }

	// RVA: 0x36AF620 Offset: 0x36AF721 VA: 0x36AF620
	public void .ctor() { }
}

