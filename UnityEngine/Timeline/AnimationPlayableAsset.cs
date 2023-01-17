// Namespace: UnityEngine.Timeline
[NotKeyableAttribute] // RVA: 0x569A0 Offset: 0x56AA1 VA: 0x569A0
[Serializable]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver // TypeDefIndex: 5630
{
	// Fields
	[SerializeField] // RVA: 0x56F40 Offset: 0x57041 VA: 0x56F40
	private AnimationClip m_Clip; // 0x18
	[SerializeField] // RVA: 0x56F50 Offset: 0x57051 VA: 0x56F50
	private Vector3 m_Position; // 0x20
	[SerializeField] // RVA: 0x56F60 Offset: 0x57061 VA: 0x56F60
	private Vector3 m_EulerAngles; // 0x2C
	[SerializeField] // RVA: 0x56F70 Offset: 0x57071 VA: 0x56F70
	private bool m_UseTrackMatchFields; // 0x38
	[SerializeField] // RVA: 0x56F80 Offset: 0x57081 VA: 0x56F80
	private MatchTargetFields m_MatchTargetFields; // 0x3C
	[SerializeField] // RVA: 0x56F90 Offset: 0x57091 VA: 0x56F90
	private bool m_RemoveStartOffset; // 0x40
	[SerializeField] // RVA: 0x56FA0 Offset: 0x570A1 VA: 0x56FA0
	private bool m_ApplyFootIK; // 0x41
	[SerializeField] // RVA: 0x56FB0 Offset: 0x570B1 VA: 0x56FB0
	private AnimationPlayableAsset.LoopMode m_Loop; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x56FC0 Offset: 0x570C1 VA: 0x56FC0
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; // 0x48
	private static readonly int k_LatestVersion; // 0x0
	[SerializeField] // RVA: 0x56FD0 Offset: 0x570D1 VA: 0x56FD0
	[HideInInspector] // RVA: 0x56FD0 Offset: 0x570D1 VA: 0x56FD0
	private int m_Version; // 0x4C
	[SerializeField] // RVA: 0x57010 Offset: 0x57111 VA: 0x57010
	[ObsoleteAttribute] // RVA: 0x57010 Offset: 0x57111 VA: 0x57010
	[HideInInspector] // RVA: 0x57010 Offset: 0x57111 VA: 0x57010
	private Quaternion m_Rotation; // 0x50

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	public bool useTrackMatchFields { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public bool removeStartOffset { get; set; }
	public bool applyFootIK { get; set; }
	public AnimationPlayableAsset.LoopMode loop { get; set; }
	internal bool hasRootTransforms { get; }
	internal AppliedOffsetMode appliedOffsetMode { get; set; }
	public AnimationClip clip { get; set; }
	public override double duration { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x369E550 Offset: 0x369E651 VA: 0x369E550
	public Vector3 get_position() { }

	// RVA: 0x369E560 Offset: 0x369E661 VA: 0x369E560
	public void set_position(Vector3 value) { }

	// RVA: 0x369E570 Offset: 0x369E671 VA: 0x369E570
	public Quaternion get_rotation() { }

	// RVA: 0x369E580 Offset: 0x369E681 VA: 0x369E580
	public void set_rotation(Quaternion value) { }

	// RVA: 0x369E5D0 Offset: 0x369E6D1 VA: 0x369E5D0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x369E5E0 Offset: 0x369E6E1 VA: 0x369E5E0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x369E5F0 Offset: 0x369E6F1 VA: 0x369E5F0
	public bool get_useTrackMatchFields() { }

	// RVA: 0x369E600 Offset: 0x369E701 VA: 0x369E600
	public void set_useTrackMatchFields(bool value) { }

	// RVA: 0x369E610 Offset: 0x369E711 VA: 0x369E610
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0x369E620 Offset: 0x369E721 VA: 0x369E620
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x369E630 Offset: 0x369E731 VA: 0x369E630
	public bool get_removeStartOffset() { }

	// RVA: 0x369E640 Offset: 0x369E741 VA: 0x369E640
	public void set_removeStartOffset(bool value) { }

	// RVA: 0x369E650 Offset: 0x369E751 VA: 0x369E650
	public bool get_applyFootIK() { }

	// RVA: 0x369E660 Offset: 0x369E761 VA: 0x369E660
	public void set_applyFootIK(bool value) { }

	// RVA: 0x369E670 Offset: 0x369E771 VA: 0x369E670
	public AnimationPlayableAsset.LoopMode get_loop() { }

	// RVA: 0x369E680 Offset: 0x369E781 VA: 0x369E680
	public void set_loop(AnimationPlayableAsset.LoopMode value) { }

	// RVA: 0x369E690 Offset: 0x369E791 VA: 0x369E690
	internal bool get_hasRootTransforms() { }

	[CompilerGeneratedAttribute] // RVA: 0x57D80 Offset: 0x57E81 VA: 0x57D80
	// RVA: 0x369E850 Offset: 0x369E951 VA: 0x369E850
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x57D90 Offset: 0x57E91 VA: 0x57D90
	// RVA: 0x369E860 Offset: 0x369E961 VA: 0x369E860
	internal void set_appliedOffsetMode(AppliedOffsetMode value) { }

	// RVA: 0x369E870 Offset: 0x369E971 VA: 0x369E870
	public AnimationClip get_clip() { }

	// RVA: 0x369E880 Offset: 0x369E981 VA: 0x369E880
	public void set_clip(AnimationClip value) { }

	// RVA: 0x369E950 Offset: 0x369EA51 VA: 0x369E950 Slot: 7
	public override double get_duration() { }

	[IteratorStateMachineAttribute] // RVA: 0x57DA0 Offset: 0x57EA1 VA: 0x57DA0
	// RVA: 0x369EB70 Offset: 0x369EC71 VA: 0x369EB70 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x369EC40 Offset: 0x369ED41 VA: 0x369EC40 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x369ED30 Offset: 0x369EE31 VA: 0x369ED30
	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, AnimationPlayableAsset.LoopMode loop) { }

	// RVA: 0x369F180 Offset: 0x369F281 VA: 0x369F180
	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	// RVA: 0x369F160 Offset: 0x369F261 VA: 0x369F160
	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	// RVA: 0x369F210 Offset: 0x369F311 VA: 0x369F210 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x369F330 Offset: 0x369F431 VA: 0x369F330
	public void ResetOffsets() { }

	// RVA: 0x369F380 Offset: 0x369F481 VA: 0x369F380 Slot: 10
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x369E760 Offset: 0x369E861 VA: 0x369E760
	internal static bool HasRootTransforms(AnimationClip clip) { }

	// RVA: 0x369F430 Offset: 0x369F531 VA: 0x369F430 Slot: 11
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x369F4B0 Offset: 0x369F5B1 VA: 0x369F4B0 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x369F570 Offset: 0x369F671 VA: 0x369F570
	private void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x369F5F0 Offset: 0x369F6F1 VA: 0x369F5F0
	public void .ctor() { }

	// RVA: 0x369F6C0 Offset: 0x369F7C1 VA: 0x369F6C0
	private static void .cctor() { }
}

