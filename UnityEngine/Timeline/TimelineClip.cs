// Namespace: UnityEngine.Timeline
[Serializable]
public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 5642
{
	// Fields
	private const int k_LatestVersion = 1;
	[HideInInspector] // RVA: 0x57520 Offset: 0x57621 VA: 0x57520
	[SerializeField] // RVA: 0x57520 Offset: 0x57621 VA: 0x57520
	private int m_Version; // 0x10
	public static readonly ClipCaps kDefaultClipCaps; // 0x0
	public static readonly float kDefaultClipDurationInSeconds; // 0x4
	public static readonly double kTimeScaleMin; // 0x8
	public static readonly double kTimeScaleMax; // 0x10
	internal static readonly string kDefaultCurvesName; // 0x18
	internal static readonly double kMinDuration; // 0x20
	internal static readonly double kMaxTimeValue; // 0x28
	[SerializeField] // RVA: 0x57560 Offset: 0x57661 VA: 0x57560
	private double m_Start; // 0x18
	[SerializeField] // RVA: 0x57570 Offset: 0x57671 VA: 0x57570
	private double m_ClipIn; // 0x20
	[SerializeField] // RVA: 0x57580 Offset: 0x57681 VA: 0x57580
	private Object m_Asset; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x57590 Offset: 0x57691 VA: 0x57590
	[SerializeField] // RVA: 0x57590 Offset: 0x57691 VA: 0x57590
	private double m_Duration; // 0x30
	[SerializeField] // RVA: 0x575E0 Offset: 0x576E1 VA: 0x575E0
	private double m_TimeScale; // 0x38
	[SerializeField] // RVA: 0x575F0 Offset: 0x576F1 VA: 0x575F0
	private TrackAsset m_ParentTrack; // 0x40
	[SerializeField] // RVA: 0x57600 Offset: 0x57701 VA: 0x57600
	private double m_EaseInDuration; // 0x48
	[SerializeField] // RVA: 0x57610 Offset: 0x57711 VA: 0x57610
	private double m_EaseOutDuration; // 0x50
	[SerializeField] // RVA: 0x57620 Offset: 0x57721 VA: 0x57620
	private double m_BlendInDuration; // 0x58
	[SerializeField] // RVA: 0x57630 Offset: 0x57731 VA: 0x57630
	private double m_BlendOutDuration; // 0x60
	[SerializeField] // RVA: 0x57640 Offset: 0x57741 VA: 0x57640
	private AnimationCurve m_MixInCurve; // 0x68
	[SerializeField] // RVA: 0x57650 Offset: 0x57751 VA: 0x57650
	private AnimationCurve m_MixOutCurve; // 0x70
	[SerializeField] // RVA: 0x57660 Offset: 0x57761 VA: 0x57660
	private TimelineClip.BlendCurveMode m_BlendInCurveMode; // 0x78
	[SerializeField] // RVA: 0x57670 Offset: 0x57771 VA: 0x57670
	private TimelineClip.BlendCurveMode m_BlendOutCurveMode; // 0x7C
	[SerializeField] // RVA: 0x57680 Offset: 0x57781 VA: 0x57680
	private List<string> m_ExposedParameterNames; // 0x80
	[SerializeField] // RVA: 0x57690 Offset: 0x57791 VA: 0x57690
	private AnimationClip m_AnimationCurves; // 0x88
	[SerializeField] // RVA: 0x576A0 Offset: 0x577A1 VA: 0x576A0
	private bool m_Recordable; // 0x90
	[SerializeField] // RVA: 0x576B0 Offset: 0x577B1 VA: 0x576B0
	private TimelineClip.ClipExtrapolation m_PostExtrapolationMode; // 0x94
	[SerializeField] // RVA: 0x576C0 Offset: 0x577C1 VA: 0x576C0
	private TimelineClip.ClipExtrapolation m_PreExtrapolationMode; // 0x98
	[SerializeField] // RVA: 0x576D0 Offset: 0x577D1 VA: 0x576D0
	private double m_PostExtrapolationTime; // 0xA0
	[SerializeField] // RVA: 0x576E0 Offset: 0x577E1 VA: 0x576E0
	private double m_PreExtrapolationTime; // 0xA8
	[SerializeField] // RVA: 0x576F0 Offset: 0x577F1 VA: 0x576F0
	private string m_DisplayName; // 0xB0

	// Properties
	public double timeScale { get; }
	public double start { get; set; }
	public double duration { get; set; }
	public double end { get; }
	public double clipIn { get; }
	public string displayName { get; set; }
	public AnimationClip curves { get; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	public Object asset { get; set; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	public TrackAsset parentTrack { get; set; }
	public double easeInDuration { get; }
	public double easeOutDuration { get; }
	public double blendInDuration { get; }
	public double blendOutDuration { get; }
	public bool hasBlendIn { get; }
	public bool hasBlendOut { get; }
	public AnimationCurve mixInCurve { get; set; }
	public double mixInDuration { get; }
	public AnimationCurve mixOutCurve { get; set; }
	public double mixOutTime { get; }
	public double mixOutDuration { get; }
	public bool recordable { get; set; }
	public ClipCaps clipCaps { get; }
	public AnimationClip animationClip { get; }
	public TimelineClip.ClipExtrapolation postExtrapolationMode { get; set; }
	public TimelineClip.ClipExtrapolation preExtrapolationMode { get; set; }
	public double extrapolatedStart { get; }
	public double extrapolatedDuration { get; }

	// Methods

	// RVA: 0x36AF780 Offset: 0x36AF881 VA: 0x36AF780
	private void UpgradeToLatestVersion() { }

	// RVA: 0x36AF7F0 Offset: 0x36AF8F1 VA: 0x36AF7F0
	internal void .ctor(TrackAsset parent) { }

	// RVA: 0x36AFA10 Offset: 0x36AFB11 VA: 0x36AFA10
	public double get_timeScale() { }

	// RVA: 0x36AFB10 Offset: 0x36AFC11 VA: 0x36AFB10
	public double get_start() { }

	// RVA: 0x36A0550 Offset: 0x36A0651 VA: 0x36A0550
	public void set_start(double value) { }

	// RVA: 0x36AFCF0 Offset: 0x36AFDF1 VA: 0x36AFCF0 Slot: 10
	public double get_duration() { }

	// RVA: 0x36A0670 Offset: 0x36A0771 VA: 0x36A0670
	public void set_duration(double value) { }

	// RVA: 0x36A53F0 Offset: 0x36A54F1 VA: 0x36A53F0
	public double get_end() { }

	// RVA: 0x36A80C0 Offset: 0x36A81C1 VA: 0x36A80C0
	public double get_clipIn() { }

	// RVA: 0x36AFD00 Offset: 0x36AFE01 VA: 0x36AFD00
	public string get_displayName() { }

	// RVA: 0x36AFD10 Offset: 0x36AFE11 VA: 0x36AFD10
	public void set_displayName(string value) { }

	// RVA: 0x36AFD20 Offset: 0x36AFE21 VA: 0x36AFD20 Slot: 11
	public AnimationClip get_curves() { }

	// RVA: 0x36AFD30 Offset: 0x36AFE31 VA: 0x36AFD30 Slot: 4
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0x36AFDA0 Offset: 0x36AFEA1 VA: 0x36AFDA0 Slot: 5
	public Object get_asset() { }

	// RVA: 0x36AFDB0 Offset: 0x36AFEB1 VA: 0x36AFDB0
	public void set_asset(Object value) { }

	// RVA: 0x36AFDC0 Offset: 0x36AFEC1 VA: 0x36AFDC0 Slot: 6
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0x36AFDD0 Offset: 0x36AFED1 VA: 0x36AFDD0 Slot: 7
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x36AFDE0 Offset: 0x36AFEE1 VA: 0x36AFDE0
	public TrackAsset get_parentTrack() { }

	// RVA: 0x36AF830 Offset: 0x36AF931 VA: 0x36AF830
	public void set_parentTrack(TrackAsset value) { }

	// RVA: 0x36AFEA0 Offset: 0x36AFFA1 VA: 0x36AFEA0
	public double get_easeInDuration() { }

	// RVA: 0x36AFF40 Offset: 0x36B0041 VA: 0x36AFF40
	public double get_easeOutDuration() { }

	// RVA: 0x36AFFE0 Offset: 0x36B00E1 VA: 0x36AFFE0
	public double get_blendInDuration() { }

	// RVA: 0x36B0020 Offset: 0x36B0121 VA: 0x36B0020
	public double get_blendOutDuration() { }

	// RVA: 0x36B0060 Offset: 0x36B0161 VA: 0x36B0060
	public bool get_hasBlendIn() { }

	// RVA: 0x36B00A0 Offset: 0x36B01A1 VA: 0x36B00A0
	public bool get_hasBlendOut() { }

	// RVA: 0x36B00E0 Offset: 0x36B01E1 VA: 0x36B00E0
	public AnimationCurve get_mixInCurve() { }

	// RVA: 0x36B01A0 Offset: 0x36B02A1 VA: 0x36B01A0
	public void set_mixInCurve(AnimationCurve value) { }

	// RVA: 0x36B01B0 Offset: 0x36B02B1 VA: 0x36B01B0
	public double get_mixInDuration() { }

	// RVA: 0x36B0290 Offset: 0x36B0391 VA: 0x36B0290
	public AnimationCurve get_mixOutCurve() { }

	// RVA: 0x36B0350 Offset: 0x36B0451 VA: 0x36B0350
	public void set_mixOutCurve(AnimationCurve value) { }

	// RVA: 0x36B0360 Offset: 0x36B0461 VA: 0x36B0360
	public double get_mixOutTime() { }

	// RVA: 0x36B03A0 Offset: 0x36B04A1 VA: 0x36B03A0
	public double get_mixOutDuration() { }

	// RVA: 0x36B0480 Offset: 0x36B0581 VA: 0x36B0480
	public bool get_recordable() { }

	// RVA: 0x36B0490 Offset: 0x36B0591 VA: 0x36B0490
	internal void set_recordable(bool value) { }

	// RVA: 0x36AB860 Offset: 0x36AB961 VA: 0x36AB860
	public ClipCaps get_clipCaps() { }

	// RVA: 0x36B04A0 Offset: 0x36B05A1 VA: 0x36B04A0
	internal int Hash() { }

	// RVA: 0x36A85E0 Offset: 0x36A86E1 VA: 0x36A85E0
	public float EvaluateMixOut(double time) { }

	// RVA: 0x36A84A0 Offset: 0x36A85A1 VA: 0x36A84A0
	public float EvaluateMixIn(double time) { }

	// RVA: 0x36B0180 Offset: 0x36B0281 VA: 0x36B0180
	private static AnimationCurve GetDefaultMixInCurve() { }

	// RVA: 0x36B0330 Offset: 0x36B0431 VA: 0x36B0330
	private static AnimationCurve GetDefaultMixOutCurve() { }

	// RVA: 0x36A86C0 Offset: 0x36A87C1 VA: 0x36A86C0
	public double ToLocalTime(double time) { }

	// RVA: 0x36B06E0 Offset: 0x36B07E1 VA: 0x36B06E0
	public AnimationClip get_animationClip() { }

	// RVA: 0x36AFB30 Offset: 0x36AFC31 VA: 0x36AFB30
	private static double SanitizeTimeValue(double value, double defaultValue) { }

	// RVA: 0x36A5400 Offset: 0x36A5501 VA: 0x36A5400
	public TimelineClip.ClipExtrapolation get_postExtrapolationMode() { }

	// RVA: 0x36A0920 Offset: 0x36A0A21 VA: 0x36A0920
	internal void set_postExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x36B0800 Offset: 0x36B0901 VA: 0x36B0800
	public TimelineClip.ClipExtrapolation get_preExtrapolationMode() { }

	// RVA: 0x36A08F0 Offset: 0x36A09F1 VA: 0x36A08F0
	internal void set_preExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x36B0840 Offset: 0x36B0941 VA: 0x36B0840
	internal void SetPostExtrapolationTime(double time) { }

	// RVA: 0x36B0850 Offset: 0x36B0951 VA: 0x36B0850
	internal void SetPreExtrapolationTime(double time) { }

	// RVA: 0x36A8430 Offset: 0x36A8531 VA: 0x36A8430
	public bool IsPreExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x36A8570 Offset: 0x36A8671 VA: 0x36A8570
	public bool IsPostExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x36A7D40 Offset: 0x36A7E41 VA: 0x36A7D40
	public double get_extrapolatedStart() { }

	// RVA: 0x36A7D70 Offset: 0x36A7E71 VA: 0x36A7D70
	public double get_extrapolatedDuration() { }

	// RVA: 0x36B05A0 Offset: 0x36B06A1 VA: 0x36B05A0
	private static double GetExtrapolatedTime(double time, TimelineClip.ClipExtrapolation mode, double duration) { }

	// RVA: 0x36B0860 Offset: 0x36B0961 VA: 0x36B0860 Slot: 8
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x36B0870 Offset: 0x36B0971 VA: 0x36B0870 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x36B08B0 Offset: 0x36B09B1 VA: 0x36B08B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x36AFB20 Offset: 0x36AFC21 VA: 0x36AFB20
	private void UpdateDirty(double oldValue, double newValue) { }

	// RVA: 0x36B0AD0 Offset: 0x36B0BD1 VA: 0x36B0AD0
	private static void .cctor() { }
}

