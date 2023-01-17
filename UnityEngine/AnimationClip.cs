// Namespace: UnityEngine
[NativeTypeAttribute] // RVA: 0x347E0 Offset: 0x348E1 VA: 0x347E0
[NativeHeaderAttribute] // RVA: 0x347E0 Offset: 0x348E1 VA: 0x347E0
public sealed class AnimationClip : Motion // TypeDefIndex: 4085
{
	// Properties
	[NativePropertyAttribute] // RVA: 0x39A80 Offset: 0x39B81 VA: 0x39A80
	public float length { get; }
	[NativePropertyAttribute] // RVA: 0x39AC0 Offset: 0x39BC1 VA: 0x39AC0
	internal float startTime { get; }
	[NativePropertyAttribute] // RVA: 0x39B00 Offset: 0x39C01 VA: 0x39B00
	internal float stopTime { get; }
	[NativePropertyAttribute] // RVA: 0x39B40 Offset: 0x39C41 VA: 0x39B40
	public float frameRate { get; set; }
	[NativePropertyAttribute] // RVA: 0x39B80 Offset: 0x39C81 VA: 0x39B80
	public WrapMode wrapMode { get; set; }
	[NativePropertyAttribute] // RVA: 0x39BC0 Offset: 0x39CC1 VA: 0x39BC0
	public Bounds localBounds { get; set; }
	public bool legacy { get; set; }
	public bool humanMotion { get; }
	public bool empty { get; }
	public bool hasGenericRootTransform { get; }
	public bool hasMotionFloatCurves { get; }
	public bool hasMotionCurves { get; }
	public bool hasRootCurves { get; }
	internal bool hasRootMotion { get; }
	public AnimationEvent[] events { get; set; }

	// Methods

	// RVA: 0x3ED0EE0 Offset: 0x3ED0FE1 VA: 0x3ED0EE0
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x36850 Offset: 0x36951 VA: 0x36850
	// RVA: 0x3ED0FF0 Offset: 0x3ED10F1 VA: 0x3ED0FF0
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x3ED1040 Offset: 0x3ED1141 VA: 0x3ED1040
	public void SampleAnimation(GameObject go, float time) { }

	[NativeHeaderAttribute] // RVA: 0x36890 Offset: 0x36991 VA: 0x36890
	[FreeFunctionAttribute] // RVA: 0x36890 Offset: 0x36991 VA: 0x36890
	// RVA: 0x3ED1120 Offset: 0x3ED1221 VA: 0x3ED1120
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	// RVA: 0x3ED1190 Offset: 0x3ED1291 VA: 0x3ED1190
	public float get_length() { }

	// RVA: 0x3ED11E0 Offset: 0x3ED12E1 VA: 0x3ED11E0
	internal float get_startTime() { }

	// RVA: 0x3ED1230 Offset: 0x3ED1331 VA: 0x3ED1230
	internal float get_stopTime() { }

	// RVA: 0x3ED1280 Offset: 0x3ED1381 VA: 0x3ED1280
	public float get_frameRate() { }

	// RVA: 0x3ED12D0 Offset: 0x3ED13D1 VA: 0x3ED12D0
	public void set_frameRate(float value) { }

	[FreeFunctionAttribute] // RVA: 0x368E0 Offset: 0x369E1 VA: 0x368E0
	// RVA: 0x3ED1320 Offset: 0x3ED1421 VA: 0x3ED1320
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	// RVA: 0x3ED1390 Offset: 0x3ED1491 VA: 0x3ED1390
	public void EnsureQuaternionContinuity() { }

	// RVA: 0x3ED13E0 Offset: 0x3ED14E1 VA: 0x3ED13E0
	public void ClearCurves() { }

	// RVA: 0x3ED10D0 Offset: 0x3ED11D1 VA: 0x3ED10D0
	public WrapMode get_wrapMode() { }

	// RVA: 0x3ED1430 Offset: 0x3ED1531 VA: 0x3ED1430
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x3ED1480 Offset: 0x3ED1581 VA: 0x3ED1480
	public Bounds get_localBounds() { }

	// RVA: 0x3ED1550 Offset: 0x3ED1651 VA: 0x3ED1550
	public void set_localBounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x36930 Offset: 0x36A31 VA: 0x36930
	// RVA: 0x3ED15F0 Offset: 0x3ED16F1 VA: 0x3ED15F0
	public bool get_legacy() { }

	[NativeMethodAttribute] // RVA: 0x36970 Offset: 0x36A71 VA: 0x36970
	// RVA: 0x3ED1640 Offset: 0x3ED1741 VA: 0x3ED1640
	public void set_legacy(bool value) { }

	[NativeMethodAttribute] // RVA: 0x369B0 Offset: 0x36AB1 VA: 0x369B0
	// RVA: 0x3ED1690 Offset: 0x3ED1791 VA: 0x3ED1690
	public bool get_humanMotion() { }

	[NativeMethodAttribute] // RVA: 0x369F0 Offset: 0x36AF1 VA: 0x369F0
	// RVA: 0x3ED16E0 Offset: 0x3ED17E1 VA: 0x3ED16E0
	public bool get_empty() { }

	[NativeMethodAttribute] // RVA: 0x36A30 Offset: 0x36B31 VA: 0x36A30
	// RVA: 0x3ED1730 Offset: 0x3ED1831 VA: 0x3ED1730
	public bool get_hasGenericRootTransform() { }

	[NativeMethodAttribute] // RVA: 0x36A70 Offset: 0x36B71 VA: 0x36A70
	// RVA: 0x3ED1780 Offset: 0x3ED1881 VA: 0x3ED1780
	public bool get_hasMotionFloatCurves() { }

	[NativeMethodAttribute] // RVA: 0x36AB0 Offset: 0x36BB1 VA: 0x36AB0
	// RVA: 0x3ED17D0 Offset: 0x3ED18D1 VA: 0x3ED17D0
	public bool get_hasMotionCurves() { }

	[NativeMethodAttribute] // RVA: 0x36AF0 Offset: 0x36BF1 VA: 0x36AF0
	// RVA: 0x3ED1820 Offset: 0x3ED1921 VA: 0x3ED1820
	public bool get_hasRootCurves() { }

	[FreeFunctionAttribute] // RVA: 0x36B30 Offset: 0x36C31 VA: 0x36B30
	// RVA: 0x3ED1870 Offset: 0x3ED1971 VA: 0x3ED1870
	internal bool get_hasRootMotion() { }

	// RVA: 0x3ED18C0 Offset: 0x3ED19C1 VA: 0x3ED18C0
	public void AddEvent(AnimationEvent evt) { }

	[FreeFunctionAttribute] // RVA: 0x36B80 Offset: 0x36C81 VA: 0x36B80
	// RVA: 0x3ED1960 Offset: 0x3ED1A61 VA: 0x3ED1960
	private void AddEventInternal(object evt) { }

	// RVA: 0x3ED19B0 Offset: 0x3ED1AB1 VA: 0x3ED19B0
	public AnimationEvent[] get_events() { }

	// RVA: 0x3ED1AB0 Offset: 0x3ED1BB1 VA: 0x3ED1AB0
	public void set_events(AnimationEvent[] value) { }

	[FreeFunctionAttribute] // RVA: 0x36BD0 Offset: 0x36CD1 VA: 0x36BD0
	// RVA: 0x3ED1B00 Offset: 0x3ED1C01 VA: 0x3ED1B00
	private void SetEventsInternal(Array value) { }

	[FreeFunctionAttribute] // RVA: 0x36C20 Offset: 0x36D21 VA: 0x36C20
	// RVA: 0x3ED1A60 Offset: 0x3ED1B61 VA: 0x3ED1A60
	private Array GetEventsInternal() { }

	// RVA: 0x3ED1500 Offset: 0x3ED1601 VA: 0x3ED1500
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x3ED15A0 Offset: 0x3ED16A1 VA: 0x3ED15A0
	private void set_localBounds_Injected(ref Bounds value) { }
}

