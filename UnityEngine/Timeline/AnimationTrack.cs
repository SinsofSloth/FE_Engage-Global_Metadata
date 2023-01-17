// Namespace: UnityEngine.Timeline
[TrackClipTypeAttribute] // RVA: 0x569E0 Offset: 0x56AE1 VA: 0x569E0
[TrackBindingTypeAttribute] // RVA: 0x569E0 Offset: 0x56AE1 VA: 0x569E0
[ExcludeFromPresetAttribute] // RVA: 0x569E0 Offset: 0x56AE1 VA: 0x569E0
[Serializable]
public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 5637
{
	// Fields
	private const string k_DefaultInfiniteClipName = "Recorded";
	private const string k_DefaultRecordableClipName = "Recorded";
	[SerializeField] // RVA: 0x57130 Offset: 0x57231 VA: 0x57130
	[FormerlySerializedAsAttribute] // RVA: 0x57130 Offset: 0x57231 VA: 0x57130
	private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xA0
	[SerializeField] // RVA: 0x57180 Offset: 0x57281 VA: 0x57180
	[FormerlySerializedAsAttribute] // RVA: 0x57180 Offset: 0x57281 VA: 0x57180
	private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xA4
	[SerializeField] // RVA: 0x571D0 Offset: 0x572D1 VA: 0x571D0
	[FormerlySerializedAsAttribute] // RVA: 0x571D0 Offset: 0x572D1 VA: 0x571D0
	private Vector3 m_InfiniteClipOffsetPosition; // 0xA8
	[SerializeField] // RVA: 0x57220 Offset: 0x57321 VA: 0x57220
	[FormerlySerializedAsAttribute] // RVA: 0x57220 Offset: 0x57321 VA: 0x57220
	private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xB4
	[FormerlySerializedAsAttribute] // RVA: 0x57270 Offset: 0x57371 VA: 0x57270
	[SerializeField] // RVA: 0x57270 Offset: 0x57371 VA: 0x57270
	private double m_InfiniteClipTimeOffset; // 0xC0
	[SerializeField] // RVA: 0x572C0 Offset: 0x573C1 VA: 0x572C0
	[FormerlySerializedAsAttribute] // RVA: 0x572C0 Offset: 0x573C1 VA: 0x572C0
	private bool m_InfiniteClipRemoveOffset; // 0xC8
	[SerializeField] // RVA: 0x57310 Offset: 0x57411 VA: 0x57310
	private bool m_InfiniteClipApplyFootIK; // 0xC9
	[SerializeField] // RVA: 0x57320 Offset: 0x57421 VA: 0x57320
	[HideInInspector] // RVA: 0x57320 Offset: 0x57421 VA: 0x57320
	private AnimationPlayableAsset.LoopMode mInfiniteClipLoop; // 0xCC
	[SerializeField] // RVA: 0x57360 Offset: 0x57461 VA: 0x57360
	private MatchTargetFields m_MatchTargetFields; // 0xD0
	[SerializeField] // RVA: 0x57370 Offset: 0x57471 VA: 0x57370
	private Vector3 m_Position; // 0xD4
	[SerializeField] // RVA: 0x57380 Offset: 0x57481 VA: 0x57380
	private Vector3 m_EulerAngles; // 0xE0
	[SerializeField] // RVA: 0x57390 Offset: 0x57491 VA: 0x57390
	private AvatarMask m_AvatarMask; // 0xF0
	[SerializeField] // RVA: 0x573A0 Offset: 0x574A1 VA: 0x573A0
	private bool m_ApplyAvatarMask; // 0xF8
	[SerializeField] // RVA: 0x573B0 Offset: 0x574B1 VA: 0x573B0
	private TrackOffset m_TrackOffset; // 0xFC
	[SerializeField] // RVA: 0x573C0 Offset: 0x574C1 VA: 0x573C0
	[HideInInspector] // RVA: 0x573C0 Offset: 0x574C1 VA: 0x573C0
	private AnimationClip m_InfiniteClip; // 0x100
	private static readonly Queue<Transform> s_CachedQueue; // 0x0
	[HideInInspector] // RVA: 0x57400 Offset: 0x57501 VA: 0x57400
	[ObsoleteAttribute] // RVA: 0x57400 Offset: 0x57501 VA: 0x57400
	[SerializeField] // RVA: 0x57400 Offset: 0x57501 VA: 0x57400
	private Quaternion m_OpenClipOffsetRotation; // 0x108
	[HideInInspector] // RVA: 0x57460 Offset: 0x57561 VA: 0x57460
	[SerializeField] // RVA: 0x57460 Offset: 0x57561 VA: 0x57460
	[ObsoleteAttribute] // RVA: 0x57460 Offset: 0x57561 VA: 0x57460
	private Quaternion m_Rotation; // 0x118
	[SerializeField] // RVA: 0x574C0 Offset: 0x575C1 VA: 0x574C0
	[ObsoleteAttribute] // RVA: 0x574C0 Offset: 0x575C1 VA: 0x574C0
	[HideInInspector] // RVA: 0x574C0 Offset: 0x575C1 VA: 0x574C0
	private bool m_ApplyOffsets; // 0x128

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	[ObsoleteAttribute] // RVA: 0x58260 Offset: 0x58361 VA: 0x58260
	public bool applyOffsets { get; set; }
	public TrackOffset trackOffset { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public AnimationClip infiniteClip { get; set; }
	internal bool infiniteClipRemoveOffset { get; set; }
	public AvatarMask avatarMask { get; set; }
	public bool applyAvatarMask { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public bool inClipMode { get; }
	public Vector3 infiniteClipOffsetPosition { get; set; }
	public Quaternion infiniteClipOffsetRotation { get; set; }
	public Vector3 infiniteClipOffsetEulerAngles { get; set; }
	internal bool infiniteClipApplyFootIK { get; set; }
	internal double infiniteClipTimeOffset { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; set; }
	internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get; set; }
	[ObsoleteAttribute] // RVA: 0x582A0 Offset: 0x583A1 VA: 0x582A0
	[EditorBrowsableAttribute] // RVA: 0x582A0 Offset: 0x583A1 VA: 0x582A0
	public Vector3 openClipOffsetPosition { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x58300 Offset: 0x58401 VA: 0x58300
	[ObsoleteAttribute] // RVA: 0x58300 Offset: 0x58401 VA: 0x58300
	public Quaternion openClipOffsetRotation { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x58360 Offset: 0x58461 VA: 0x58360
	[ObsoleteAttribute] // RVA: 0x58360 Offset: 0x58461 VA: 0x58360
	public Vector3 openClipOffsetEulerAngles { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x583C0 Offset: 0x584C1 VA: 0x583C0
	[ObsoleteAttribute] // RVA: 0x583C0 Offset: 0x584C1 VA: 0x583C0
	public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; set; }
	[ObsoleteAttribute] // RVA: 0x58420 Offset: 0x58521 VA: 0x58420
	[EditorBrowsableAttribute] // RVA: 0x58420 Offset: 0x58521 VA: 0x58420
	public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; set; }

	// Methods

	// RVA: 0x369F710 Offset: 0x369F811 VA: 0x369F710
	public Vector3 get_position() { }

	// RVA: 0x369F720 Offset: 0x369F821 VA: 0x369F720
	public void set_position(Vector3 value) { }

	// RVA: 0x369F730 Offset: 0x369F831 VA: 0x369F730
	public Quaternion get_rotation() { }

	// RVA: 0x369F740 Offset: 0x369F841 VA: 0x369F740
	public void set_rotation(Quaternion value) { }

	// RVA: 0x369F790 Offset: 0x369F891 VA: 0x369F790
	public Vector3 get_eulerAngles() { }

	// RVA: 0x369F7A0 Offset: 0x369F8A1 VA: 0x369F7A0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x369F7B0 Offset: 0x369F8B1 VA: 0x369F7B0
	public bool get_applyOffsets() { }

	// RVA: 0x369F7C0 Offset: 0x369F8C1 VA: 0x369F7C0
	public void set_applyOffsets(bool value) { }

	// RVA: 0x369F7D0 Offset: 0x369F8D1 VA: 0x369F7D0
	public TrackOffset get_trackOffset() { }

	// RVA: 0x369F7E0 Offset: 0x369F8E1 VA: 0x369F7E0
	public void set_trackOffset(TrackOffset value) { }

	// RVA: 0x369F7F0 Offset: 0x369F8F1 VA: 0x369F7F0
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0x369F800 Offset: 0x369F901 VA: 0x369F800
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x369F880 Offset: 0x369F981 VA: 0x369F880
	public AnimationClip get_infiniteClip() { }

	// RVA: 0x369F890 Offset: 0x369F991 VA: 0x369F890
	internal void set_infiniteClip(AnimationClip value) { }

	// RVA: 0x369F8A0 Offset: 0x369F9A1 VA: 0x369F8A0
	internal bool get_infiniteClipRemoveOffset() { }

	// RVA: 0x369F8B0 Offset: 0x369F9B1 VA: 0x369F8B0
	internal void set_infiniteClipRemoveOffset(bool value) { }

	// RVA: 0x369F8C0 Offset: 0x369F9C1 VA: 0x369F8C0
	public AvatarMask get_avatarMask() { }

	// RVA: 0x369F8D0 Offset: 0x369F9D1 VA: 0x369F8D0
	public void set_avatarMask(AvatarMask value) { }

	// RVA: 0x369F8E0 Offset: 0x369F9E1 VA: 0x369F8E0
	public bool get_applyAvatarMask() { }

	// RVA: 0x369F8F0 Offset: 0x369F9F1 VA: 0x369F8F0
	public void set_applyAvatarMask(bool value) { }

	// RVA: 0x369F900 Offset: 0x369FA01 VA: 0x369F900 Slot: 32
	internal override bool CanCompileClips() { }

	[IteratorStateMachineAttribute] // RVA: 0x57E80 Offset: 0x57F81 VA: 0x57E80
	// RVA: 0x369F9E0 Offset: 0x369FAE1 VA: 0x369F9E0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x369FAB0 Offset: 0x369FBB1 VA: 0x369FAB0
	public bool get_inClipMode() { }

	// RVA: 0x369FBF0 Offset: 0x369FCF1 VA: 0x369FBF0
	public Vector3 get_infiniteClipOffsetPosition() { }

	// RVA: 0x369FC00 Offset: 0x369FD01 VA: 0x369FC00
	public void set_infiniteClipOffsetPosition(Vector3 value) { }

	// RVA: 0x369FC10 Offset: 0x369FD11 VA: 0x369FC10
	public Quaternion get_infiniteClipOffsetRotation() { }

	// RVA: 0x369FC20 Offset: 0x369FD21 VA: 0x369FC20
	public void set_infiniteClipOffsetRotation(Quaternion value) { }

	// RVA: 0x369FC70 Offset: 0x369FD71 VA: 0x369FC70
	public Vector3 get_infiniteClipOffsetEulerAngles() { }

	// RVA: 0x369FC80 Offset: 0x369FD81 VA: 0x369FC80
	public void set_infiniteClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x369FC90 Offset: 0x369FD91 VA: 0x369FC90
	internal bool get_infiniteClipApplyFootIK() { }

	// RVA: 0x369FCA0 Offset: 0x369FDA1 VA: 0x369FCA0
	internal void set_infiniteClipApplyFootIK(bool value) { }

	// RVA: 0x369FCB0 Offset: 0x369FDB1 VA: 0x369FCB0
	internal double get_infiniteClipTimeOffset() { }

	// RVA: 0x369FCC0 Offset: 0x369FDC1 VA: 0x369FCC0
	internal void set_infiniteClipTimeOffset(double value) { }

	// RVA: 0x369FCD0 Offset: 0x369FDD1 VA: 0x369FCD0
	public TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation() { }

	// RVA: 0x369FCE0 Offset: 0x369FDE1 VA: 0x369FCE0
	public void set_infiniteClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x369FCF0 Offset: 0x369FDF1 VA: 0x369FCF0
	public TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation() { }

	// RVA: 0x369FD00 Offset: 0x369FE01 VA: 0x369FD00
	public void set_infiniteClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x369FD10 Offset: 0x369FE11 VA: 0x369FD10
	internal AnimationPlayableAsset.LoopMode get_infiniteClipLoop() { }

	// RVA: 0x369FD20 Offset: 0x369FE21 VA: 0x369FD20
	internal void set_infiniteClipLoop(AnimationPlayableAsset.LoopMode value) { }

	[ContextMenu] // RVA: 0x57EF0 Offset: 0x57FF1 VA: 0x57EF0
	// RVA: 0x369FD30 Offset: 0x369FE31 VA: 0x369FD30
	private void ResetOffsets() { }

	// RVA: 0x369FD90 Offset: 0x369FE91 VA: 0x369FD90
	public TimelineClip CreateClip(AnimationClip clip) { }

	// RVA: 0x36A00D0 Offset: 0x36A01D1 VA: 0x36A00D0
	public void CreateInfiniteClip(string infiniteClipName) { }

	// RVA: 0x36A03F0 Offset: 0x36A04F1 VA: 0x36A03F0
	public TimelineClip CreateRecordableClip(string animClipName) { }

	// RVA: 0x36A0740 Offset: 0x36A0841 VA: 0x36A0740 Slot: 29
	protected override void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x36A0950 Offset: 0x36A0A51 VA: 0x36A0950 Slot: 30
	protected internal override int CalculateItemsHash() { }

	// RVA: 0x369FD80 Offset: 0x369FE81 VA: 0x369FD80
	internal void UpdateClipOffsets() { }

	// RVA: 0x36A0BD0 Offset: 0x36A0CD1 VA: 0x36A0BD0
	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x36A1660 Offset: 0x36A1761 VA: 0x36A1660 Slot: 34
	private Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x36A16D0 Offset: 0x36A17D1 VA: 0x36A16D0 Slot: 25
	internal override Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x36A25E0 Offset: 0x36A26E1 VA: 0x36A25E0
	private int GetDefaultBlendCount() { }

	// RVA: 0x36A2B50 Offset: 0x36A2C51 VA: 0x36A2B50
	private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset) { }

	// RVA: 0x36A2B80 Offset: 0x36A2C81 VA: 0x36A2B80
	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) { }

	// RVA: 0x36A2A30 Offset: 0x36A2B31 VA: 0x36A2A30
	private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) { }

	// RVA: 0x36A2B60 Offset: 0x36A2C61 VA: 0x36A2B60
	private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) { }

	// RVA: 0x36A2F10 Offset: 0x36A3011 VA: 0x36A2F10
	private bool HasController(GameObject gameObject) { }

	// RVA: 0x36A2CF0 Offset: 0x36A2DF1 VA: 0x36A2CF0
	internal Animator GetBinding(PlayableDirector director) { }

	// RVA: 0x36A25F0 Offset: 0x36A26F1 VA: 0x36A25F0
	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x36A2680 Offset: 0x36A2781 VA: 0x36A2680
	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x36A14B0 Offset: 0x36A15B1 VA: 0x36A14B0
	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) { }

	// RVA: 0x36A3080 Offset: 0x36A3181 VA: 0x36A3080 Slot: 26
	internal override void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0x36A3420 Offset: 0x36A3521 VA: 0x36A3420 Slot: 27
	internal override void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x369FE50 Offset: 0x369FF51 VA: 0x369FE50
	private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) { }

	// RVA: 0x36A38E0 Offset: 0x36A39E1 VA: 0x36A38E0 Slot: 28
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x36A38F0 Offset: 0x36A39F1 VA: 0x36A38F0
	private void GetAnimationClips(List<AnimationClip> animClips) { }

	// RVA: 0x36A2550 Offset: 0x36A2651 VA: 0x36A2550
	private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) { }

	// RVA: 0x36A22B0 Offset: 0x36A23B1 VA: 0x36A22B0
	private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) { }

	// RVA: 0x36A20C0 Offset: 0x36A21C1 VA: 0x36A20C0
	private Transform GetGenericRootNode(GameObject gameObject) { }

	// RVA: 0x36A1100 Offset: 0x36A1201 VA: 0x36A1100
	internal bool AnimatesRootTransform() { }

	// RVA: 0x36A3DB0 Offset: 0x36A3EB1 VA: 0x36A3DB0
	private static Transform FindInHierarchyBreadthFirst(Transform t, string name) { }

	// RVA: 0x36A3FB0 Offset: 0x36A40B1 VA: 0x36A3FB0
	public Vector3 get_openClipOffsetPosition() { }

	// RVA: 0x36A3FC0 Offset: 0x36A40C1 VA: 0x36A3FC0
	public void set_openClipOffsetPosition(Vector3 value) { }

	// RVA: 0x36A3FD0 Offset: 0x36A40D1 VA: 0x36A3FD0
	public Quaternion get_openClipOffsetRotation() { }

	// RVA: 0x36A3FE0 Offset: 0x36A40E1 VA: 0x36A3FE0
	public void set_openClipOffsetRotation(Quaternion value) { }

	// RVA: 0x36A4030 Offset: 0x36A4131 VA: 0x36A4030
	public Vector3 get_openClipOffsetEulerAngles() { }

	// RVA: 0x36A4040 Offset: 0x36A4141 VA: 0x36A4040
	public void set_openClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x36A4050 Offset: 0x36A4151 VA: 0x36A4050
	public TimelineClip.ClipExtrapolation get_openClipPreExtrapolation() { }

	// RVA: 0x36A4060 Offset: 0x36A4161 VA: 0x36A4060
	public void set_openClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x36A4070 Offset: 0x36A4171 VA: 0x36A4070
	public TimelineClip.ClipExtrapolation get_openClipPostExtrapolation() { }

	// RVA: 0x36A4080 Offset: 0x36A4181 VA: 0x36A4080
	public void set_openClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x36A4090 Offset: 0x36A4191 VA: 0x36A4090 Slot: 18
	internal override void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x36A4240 Offset: 0x36A4341 VA: 0x36A4240
	public void .ctor() { }

	// RVA: 0x36A4470 Offset: 0x36A4571 VA: 0x36A4470
	private static void .cctor() { }
}

