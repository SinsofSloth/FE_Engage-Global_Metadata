// Namespace: UnityEngine.Timeline
[IgnoreOnPlayableTrackAttribute] // RVA: 0x56AC0 Offset: 0x56BC1 VA: 0x56AC0
[Serializable]
public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner // TypeDefIndex: 5650
{
	// Fields
	private const int k_LatestVersion = 3;
	[HideInInspector] // RVA: 0x57900 Offset: 0x57A01 VA: 0x57900
	[SerializeField] // RVA: 0x57900 Offset: 0x57A01 VA: 0x57900
	private int m_Version; // 0x18
	[HideInInspector] // RVA: 0x57940 Offset: 0x57A41 VA: 0x57940
	[SerializeField] // RVA: 0x57940 Offset: 0x57A41 VA: 0x57940
	[ObsoleteAttribute] // RVA: 0x57940 Offset: 0x57A41 VA: 0x57940
	[FormerlySerializedAsAttribute] // RVA: 0x57940 Offset: 0x57A41 VA: 0x57940
	internal AnimationClip m_AnimClip; // 0x20
	private static TrackAsset.TransientBuildData s_BuildData; // 0x0
	internal const string kDefaultCurvesName = "Track Parameters";
	[CompilerGeneratedAttribute] // RVA: 0x579D0 Offset: 0x57AD1 VA: 0x579D0
	private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x579E0 Offset: 0x57AE1 VA: 0x579E0
	private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; // 0x20
	[SerializeField] // RVA: 0x579F0 Offset: 0x57AF1 VA: 0x579F0
	[HideInInspector] // RVA: 0x579F0 Offset: 0x57AF1 VA: 0x579F0
	private bool m_Locked; // 0x28
	[HideInInspector] // RVA: 0x57A30 Offset: 0x57B31 VA: 0x57A30
	[SerializeField] // RVA: 0x57A30 Offset: 0x57B31 VA: 0x57A30
	private bool m_Muted; // 0x29
	[SerializeField] // RVA: 0x57A70 Offset: 0x57B71 VA: 0x57A70
	[HideInInspector] // RVA: 0x57A70 Offset: 0x57B71 VA: 0x57A70
	private string m_CustomPlayableFullTypename; // 0x30
	[SerializeField] // RVA: 0x57AB0 Offset: 0x57BB1 VA: 0x57AB0
	[HideInInspector] // RVA: 0x57AB0 Offset: 0x57BB1 VA: 0x57AB0
	private AnimationClip m_Curves; // 0x38
	[SerializeField] // RVA: 0x57AF0 Offset: 0x57BF1 VA: 0x57AF0
	[HideInInspector] // RVA: 0x57AF0 Offset: 0x57BF1 VA: 0x57AF0
	private PlayableAsset m_Parent; // 0x40
	[HideInInspector] // RVA: 0x57B30 Offset: 0x57C31 VA: 0x57B30
	[SerializeField] // RVA: 0x57B30 Offset: 0x57C31 VA: 0x57B30
	private List<ScriptableObject> m_Children; // 0x48
	private int m_ItemsHash; // 0x50
	private TimelineClip[] m_ClipsCache; // 0x58
	private DiscreteTime m_Start; // 0x60
	private DiscreteTime m_End; // 0x68
	private bool m_CacheSorted; // 0x70
	private Nullable<bool> m_SupportsNotifications; // 0x71
	private static TrackAsset[] s_EmptyCache; // 0x28
	private IEnumerable<TrackAsset> m_ChildTrackCache; // 0x78
	private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; // 0x30
	[HideInInspector] // RVA: 0x57B70 Offset: 0x57C71 VA: 0x57B70
	[SerializeField] // RVA: 0x57B70 Offset: 0x57C71 VA: 0x57B70
	protected internal List<TimelineClip> m_Clips; // 0x80
	[SerializeField] // RVA: 0x57BB0 Offset: 0x57CB1 VA: 0x57BB0
	[HideInInspector] // RVA: 0x57BB0 Offset: 0x57CB1 VA: 0x57BB0
	private MarkerList m_Markers; // 0x88

	// Properties
	public double start { get; }
	public double end { get; }
	public sealed override double duration { get; }
	public bool muted { get; set; }
	public bool mutedInHierarchy { get; }
	public TimelineAsset timelineAsset { get; }
	public PlayableAsset parent { get; set; }
	internal TimelineClip[] clips { get; }
	public virtual bool isEmpty { get; }
	public bool hasClips { get; }
	public bool hasCurves { get; }
	public bool isSubTrack { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	internal string customPlayableTypename { get; set; }
	public AnimationClip curves { get; set; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.asset { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	internal List<ScriptableObject> subTracksObjects { get; }
	public bool locked { get; set; }
	public bool lockedInHierarchy { get; }
	public bool supportsNotifications { get; }

	// Methods

	// RVA: 0x36B2EC0 Offset: 0x36B2FC1 VA: 0x36B2EC0 Slot: 16
	protected virtual void OnBeforeTrackSerialize() { }

	// RVA: 0x36B2ED0 Offset: 0x36B2FD1 VA: 0x36B2ED0 Slot: 17
	protected virtual void OnAfterTrackDeserialize() { }

	// RVA: 0x36B2EE0 Offset: 0x36B2FE1 VA: 0x36B2EE0 Slot: 18
	internal virtual void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x36B2EF0 Offset: 0x36B2FF1 VA: 0x36B2EF0 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x36B30A0 Offset: 0x36B31A1 VA: 0x36B30A0 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x36B34C0 Offset: 0x36B35C1 VA: 0x36B34C0
	private void UpgradeToLatestVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x58080 Offset: 0x58181 VA: 0x58080
	// RVA: 0x36B3500 Offset: 0x36B3601 VA: 0x36B3500
	internal static void add_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x58090 Offset: 0x58191 VA: 0x58090
	// RVA: 0x36B3600 Offset: 0x36B3701 VA: 0x36B3600
	internal static void remove_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x580A0 Offset: 0x581A1 VA: 0x580A0
	// RVA: 0x36B3700 Offset: 0x36B3801 VA: 0x36B3700
	internal static void add_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x580B0 Offset: 0x581B1 VA: 0x580B0
	// RVA: 0x36B3800 Offset: 0x36B3901 VA: 0x36B3800
	internal static void remove_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	// RVA: 0x36B3900 Offset: 0x36B3A01 VA: 0x36B3900
	public double get_start() { }

	// RVA: 0x36AD7E0 Offset: 0x36AD8E1 VA: 0x36AD7E0
	public double get_end() { }

	// RVA: 0x36B3B00 Offset: 0x36B3C01 VA: 0x36B3B00 Slot: 7
	public sealed override double get_duration() { }

	// RVA: 0x36B3BE0 Offset: 0x36B3CE1 VA: 0x36B3BE0
	public bool get_muted() { }

	// RVA: 0x36B3BF0 Offset: 0x36B3CF1 VA: 0x36B3BF0
	public void set_muted(bool value) { }

	// RVA: 0x36AD400 Offset: 0x36AD501 VA: 0x36AD400
	public bool get_mutedInHierarchy() { }

	// RVA: 0x36A6200 Offset: 0x36A6301 VA: 0x36A6200
	public TimelineAsset get_timelineAsset() { }

	// RVA: 0x36B3C00 Offset: 0x36B3D01 VA: 0x36B3C00
	public PlayableAsset get_parent() { }

	// RVA: 0x36B3C10 Offset: 0x36B3D11 VA: 0x36B3C10
	internal void set_parent(PlayableAsset value) { }

	// RVA: 0x36A3FA0 Offset: 0x36A40A1 VA: 0x36A3FA0
	public IEnumerable<TimelineClip> GetClips() { }

	// RVA: 0x369FAF0 Offset: 0x369FBF1 VA: 0x369FAF0
	internal TimelineClip[] get_clips() { }

	// RVA: 0x36B3C20 Offset: 0x36B3D21 VA: 0x36B3C20 Slot: 19
	public virtual bool get_isEmpty() { }

	// RVA: 0x36B3D30 Offset: 0x36B3E31 VA: 0x36B3D30
	public bool get_hasClips() { }

	// RVA: 0x36B3D90 Offset: 0x36B3E91 VA: 0x36B3D90 Slot: 20
	public bool get_hasCurves() { }

	// RVA: 0x36A07B0 Offset: 0x36A08B1 VA: 0x36A07B0
	public bool get_isSubTrack() { }

	[IteratorStateMachineAttribute] // RVA: 0x580C0 Offset: 0x581C1 VA: 0x580C0
	// RVA: 0x36A6E70 Offset: 0x36A6F71 VA: 0x36A6E70 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x36A2520 Offset: 0x36A2621 VA: 0x36A2520
	public IEnumerable<TrackAsset> GetChildTracks() { }

	// RVA: 0x36B40F0 Offset: 0x36B41F1 VA: 0x36B40F0
	internal string get_customPlayableTypename() { }

	// RVA: 0x36B4100 Offset: 0x36B4201 VA: 0x36B4100
	internal void set_customPlayableTypename(string value) { }

	// RVA: 0x36B4110 Offset: 0x36B4211 VA: 0x36B4110 Slot: 21
	public AnimationClip get_curves() { }

	// RVA: 0x36B4120 Offset: 0x36B4221 VA: 0x36B4120
	internal void set_curves(AnimationClip value) { }

	// RVA: 0x36B4130 Offset: 0x36B4231 VA: 0x36B4130 Slot: 12
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0x36B4180 Offset: 0x36B4281 VA: 0x36B4180 Slot: 13
	private Object UnityEngine.Timeline.ICurvesOwner.get_asset() { }

	// RVA: 0x36B4190 Offset: 0x36B4291 VA: 0x36B4190 Slot: 14
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0x36B41A0 Offset: 0x36B42A1 VA: 0x36B41A0 Slot: 15
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x36B41B0 Offset: 0x36B42B1 VA: 0x36B41B0
	internal List<ScriptableObject> get_subTracksObjects() { }

	// RVA: 0x36B41C0 Offset: 0x36B42C1 VA: 0x36B41C0
	public bool get_locked() { }

	// RVA: 0x36B41D0 Offset: 0x36B42D1 VA: 0x36B41D0
	public void set_locked(bool value) { }

	// RVA: 0x36B41E0 Offset: 0x36B42E1 VA: 0x36B41E0
	public bool get_lockedInHierarchy() { }

	// RVA: 0x36A6A80 Offset: 0x36A6B81 VA: 0x36A6A80
	public bool get_supportsNotifications() { }

	// RVA: 0x36B43B0 Offset: 0x36B44B1 VA: 0x36B43B0
	private void __internalAwake() { }

	// RVA: 0x36B44B0 Offset: 0x36B45B1 VA: 0x36B44B0 Slot: 22
	public void CreateCurves(string curvesClipName) { }

	// RVA: 0x36B45A0 Offset: 0x36B46A1 VA: 0x36B45A0 Slot: 23
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x36B4630 Offset: 0x36B4731 VA: 0x36B4630 Slot: 6
	public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x36B46A0 Offset: 0x36B47A1 VA: 0x36B46A0
	public TimelineClip CreateDefaultClip() { }

	// RVA: -1 Offset: -1
	public TimelineClip CreateClip<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2028080 Offset: 0x2028181 VA: 0x2028080
	|-TrackAsset.CreateClip<AnimationPlayableAsset>
	|-TrackAsset.CreateClip<object>
	*/

	// RVA: 0x36B4AA0 Offset: 0x36B4BA1 VA: 0x36B4AA0
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x36B4BC0 Offset: 0x36B4CC1 VA: 0x36B4BC0
	public IMarker CreateMarker(Type type, double time) { }

	// RVA: -1 Offset: -1
	public T CreateMarker<T>(double time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2028110 Offset: 0x2028211 VA: 0x2028110
	|-TrackAsset.CreateMarker<object>
	*/

	// RVA: 0x36B4BD0 Offset: 0x36B4CD1 VA: 0x36B4BD0
	public bool DeleteMarker(IMarker marker) { }

	// RVA: 0x36B34D0 Offset: 0x36B35D1 VA: 0x36B34D0
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0x36B3E30 Offset: 0x36B3F31 VA: 0x36B3E30
	public int GetMarkerCount() { }

	// RVA: 0x36B4BE0 Offset: 0x36B4CE1 VA: 0x36B4BE0
	public IMarker GetMarker(int idx) { }

	// RVA: 0x36B4C60 Offset: 0x36B4D61 VA: 0x36B4C60
	internal TimelineClip CreateClip(Type requestedType) { }

	// RVA: 0x36B4A00 Offset: 0x36B4B01 VA: 0x36B4A00
	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType) { }

	// RVA: 0x36B5090 Offset: 0x36B5191 VA: 0x36B5090
	internal TimelineClip CreateClipOfType(Type requestedType) { }

	// RVA: 0x36B5530 Offset: 0x36B5631 VA: 0x36B5530
	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) { }

	// RVA: 0x36B5260 Offset: 0x36B5361 VA: 0x36B5260
	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) { }

	// RVA: 0x36B5A70 Offset: 0x36B5B71 VA: 0x36B5A70
	internal IEnumerable<ScriptableObject> GetMarkersRaw() { }

	// RVA: 0x36B5A80 Offset: 0x36B5B81 VA: 0x36B5A80
	internal void ClearMarkers() { }

	// RVA: 0x36B5AE0 Offset: 0x36B5BE1 VA: 0x36B5AE0
	internal void AddMarker(ScriptableObject e) { }

	// RVA: 0x36B5B90 Offset: 0x36B5C91 VA: 0x36B5B90
	internal bool DeleteMarkerRaw(ScriptableObject marker) { }

	// RVA: 0x36B5BD0 Offset: 0x36B5CD1 VA: 0x36B5BD0
	private int GetTimeRangeHash() { }

	// RVA: 0x36AFDF0 Offset: 0x36AFEF1 VA: 0x36AFDF0
	internal void AddClip(TimelineClip newClip) { }

	// RVA: 0x36B6070 Offset: 0x36B6171 VA: 0x36B6070
	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) { }

	// RVA: 0x36B21F0 Offset: 0x36B22F1 VA: 0x36B21F0
	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	// RVA: 0x36B6980 Offset: 0x36B6A81 VA: 0x36B6980 Slot: 24
	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x36B6FC0 Offset: 0x36B70C1 VA: 0x36B6FC0
	private void GatherCompilableTracks(IList<TrackAsset> tracks) { }

	// RVA: 0x36B62C0 Offset: 0x36B63C1 VA: 0x36B62C0
	private void GatherNotificiations(List<IMarker> markers) { }

	// RVA: 0x36B7390 Offset: 0x36B7491 VA: 0x36B7390 Slot: 25
	internal virtual Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x36B6DE0 Offset: 0x36B6EE1 VA: 0x36B6DE0
	internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) { }

	// RVA: 0x36B14F0 Offset: 0x36B15F1 VA: 0x36B14F0
	internal void SortClips() { }

	// RVA: 0x36B7A30 Offset: 0x36B7B31 VA: 0x36B7A30
	internal void ClearClipsInternal() { }

	// RVA: 0x36B7AC0 Offset: 0x36B7BC1 VA: 0x36B7AC0
	internal void ClearSubTracksInternal() { }

	// RVA: 0x36AFCE0 Offset: 0x36AFDE1 VA: 0x36AFCE0
	internal void OnClipMove() { }

	// RVA: 0x36B57B0 Offset: 0x36B58B1 VA: 0x36B57B0
	internal TimelineClip CreateNewClipContainerInternal() { }

	// RVA: 0x36AF550 Offset: 0x36AF651 VA: 0x36AF550
	internal void AddChild(TrackAsset child) { }

	// RVA: 0x36B7B50 Offset: 0x36B7C51 VA: 0x36B7B50
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x36ACAA0 Offset: 0x36ACBA1 VA: 0x36ACAA0
	internal bool RemoveSubTrack(TrackAsset child) { }

	// RVA: 0x36AEB00 Offset: 0x36AEC01 VA: 0x36AEB00
	internal void RemoveClip(TimelineClip clip) { }

	// RVA: 0x36A3140 Offset: 0x36A3241 VA: 0x36A3140 Slot: 26
	internal virtual void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0x36A3540 Offset: 0x36A3641 VA: 0x36A3540 Slot: 27
	internal virtual void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x36B7DC0 Offset: 0x36B7EC1 VA: 0x36B7DC0 Slot: 28
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x36B84B0 Offset: 0x36B85B1 VA: 0x36B84B0
	internal GameObject GetGameObjectBinding(PlayableDirector director) { }

	// RVA: 0x36B4DF0 Offset: 0x36B4EF1 VA: 0x36B4DF0
	internal bool ValidateClipType(Type clipType) { }

	// RVA: 0x36B8650 Offset: 0x36B8751 VA: 0x36B8650 Slot: 29
	protected virtual void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x36B39E0 Offset: 0x36B3AE1 VA: 0x36B39E0
	private void UpdateDuration() { }

	// RVA: 0x36A0AF0 Offset: 0x36A0BF1 VA: 0x36A0AF0 Slot: 30
	protected internal virtual int CalculateItemsHash() { }

	// RVA: 0x36B8790 Offset: 0x36B8891 VA: 0x36B8790 Slot: 31
	protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) { }

	// RVA: 0x36B33F0 Offset: 0x36B34F1 VA: 0x36B33F0
	internal void Invalidate() { }

	// RVA: 0x36A3550 Offset: 0x36A3651 VA: 0x36A3550
	internal double GetNotificationDuration() { }

	// RVA: 0x36B8A60 Offset: 0x36B8B61 VA: 0x36B8A60 Slot: 32
	internal virtual bool CanCompileClips() { }

	// RVA: 0x36B1160 Offset: 0x36B1261 VA: 0x36B1160
	internal bool IsCompilable() { }

	// RVA: 0x36B3ED0 Offset: 0x36B3FD1 VA: 0x36B3ED0
	private void UpdateChildTrackCache() { }

	// RVA: 0x36B8B30 Offset: 0x36B8C31 VA: 0x36B8B30 Slot: 33
	internal virtual int Hash() { }

	// RVA: 0x36B8660 Offset: 0x36B8761 VA: 0x36B8660
	private int GetClipsHash() { }

	// RVA: 0x36A09F0 Offset: 0x36A0AF1 VA: 0x36A09F0
	protected static int GetAnimationClipHash(AnimationClip clip) { }

	// RVA: 0x36B7D90 Offset: 0x36B7E91 VA: 0x36B7D90
	private bool HasNotifications() { }

	// RVA: 0x36B7340 Offset: 0x36B7441 VA: 0x36B7340
	private bool CanCompileNotifications() { }

	// RVA: 0x36B6600 Offset: 0x36B6701 VA: 0x36B6600
	private bool CanCompileClipsRecursive() { }

	// RVA: 0x36A4370 Offset: 0x36A4471 VA: 0x36A4370
	protected void .ctor() { }

	// RVA: 0x36B8BA0 Offset: 0x36B8CA1 VA: 0x36B8BA0
	private static void .cctor() { }
}

