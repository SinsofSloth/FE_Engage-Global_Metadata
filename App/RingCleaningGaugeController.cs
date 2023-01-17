// Namespace: App
public class RingCleaningGaugeController : MonoBehaviour // TypeDefIndex: 11753
{
	// Fields
	public GameObject GaugeObject; // 0x18
	[SpaceAttribute] // RVA: 0x298FF0 Offset: 0x2990F1 VA: 0x298FF0
	public GameObject ConditionIcon; // 0x20
	[SpaceAttribute] // RVA: 0x299010 Offset: 0x299111 VA: 0x299010
	public AnimationCurve DirtyTextureCurve; // 0x28
	private IntReactiveProperty m_ReactiveDirty; // 0x30
	private float MaxGaugeWidth; // 0x38
	private InterpolatorFloat m_InterpolatorWidth; // 0x40
	private RingCleaningConditionIcon m_ConditionIcon; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x299030 Offset: 0x299131 VA: 0x299030
	private bool <IsFinishCleaning>k__BackingField; // 0x50

	// Properties
	public float DirtyRate { get; }
	public bool IsFinishCleaning { get; set; }

	// Methods

	// RVA: 0x2679270 Offset: 0x2679371 VA: 0x2679270
	public float get_DirtyRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C65A0 Offset: 0x2C66A1 VA: 0x2C65A0
	// RVA: 0x26793D0 Offset: 0x26794D1 VA: 0x26793D0
	public bool get_IsFinishCleaning() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C65B0 Offset: 0x2C66B1 VA: 0x2C65B0
	// RVA: 0x26793E0 Offset: 0x26794E1 VA: 0x26793E0
	private void set_IsFinishCleaning(bool value) { }

	// RVA: 0x26793F0 Offset: 0x26794F1 VA: 0x26793F0
	private void Awake() { }

	// RVA: 0x26794E0 Offset: 0x26795E1 VA: 0x26794E0
	public void Initialize(int dirty) { }

	// RVA: 0x2679830 Offset: 0x2679931 VA: 0x2679830
	private void ChangeDirty(int oldDirty, int newDirty) { }

	// RVA: 0x2679980 Offset: 0x2679A81 VA: 0x2679980
	public void Tick() { }

	// RVA: 0x26796B0 Offset: 0x26797B1 VA: 0x26796B0
	public void SetDirty(int dirty) { }

	// RVA: 0x2679C00 Offset: 0x2679D01 VA: 0x2679C00
	public float GetDirtyTextureValue(float value) { }

	// RVA: 0x2679C10 Offset: 0x2679D11 VA: 0x2679C10
	private float GetGuageWidth(int dirty) { }

	// RVA: 0x2679710 Offset: 0x2679811 VA: 0x2679710
	private void InitGaugeWidth(int dirty) { }

	// RVA: 0x2679B80 Offset: 0x2679C81 VA: 0x2679B80
	private void SetConditionIcon(RectTransform rect) { }

	// RVA: 0x26798F0 Offset: 0x26799F1 VA: 0x26798F0
	private void UpdateGaugeWidth() { }

	// RVA: 0x2679C40 Offset: 0x2679D41 VA: 0x2679C40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C65C0 Offset: 0x2C66C1 VA: 0x2C65C0
	// RVA: 0x2679CC0 Offset: 0x2679DC1 VA: 0x2679CC0
	private void <Initialize>b__14_0(Pair<int> x) { }
}

