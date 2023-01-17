// Namespace: UnityEngine.Animations
[UsedByNativeCodeAttribute] // RVA: 0x35C70 Offset: 0x35D71 VA: 0x35C70
[NativeHeaderAttribute] // RVA: 0x35C70 Offset: 0x35D71 VA: 0x35C70
[RequireComponent] // RVA: 0x35C70 Offset: 0x35D71 VA: 0x35C70
[NativeHeaderAttribute] // RVA: 0x35C70 Offset: 0x35D71 VA: 0x35C70
public sealed class ScaleConstraint : Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 4138
{
	// Properties
	public float weight { get; set; }
	public Vector3 scaleAtRest { get; set; }
	public Vector3 scaleOffset { get; set; }
	public Axis scalingAxis { get; set; }
	public bool constraintActive { get; set; }
	public bool locked { get; set; }
	public int sourceCount { get; }

	// Methods

	// RVA: 0x3EDFA60 Offset: 0x3EDFB61 VA: 0x3EDFA60
	private void .ctor() { }

	// RVA: 0x3EDFAC0 Offset: 0x3EDFBC1 VA: 0x3EDFAC0
	private static void Internal_Create(ScaleConstraint self) { }

	// RVA: 0x3EDFB10 Offset: 0x3EDFC11 VA: 0x3EDFB10 Slot: 4
	public float get_weight() { }

	// RVA: 0x3EDFB60 Offset: 0x3EDFC61 VA: 0x3EDFB60 Slot: 5
	public void set_weight(float value) { }

	// RVA: 0x3EDFBB0 Offset: 0x3EDFCB1 VA: 0x3EDFBB0
	public Vector3 get_scaleAtRest() { }

	// RVA: 0x3EDFC60 Offset: 0x3EDFD61 VA: 0x3EDFC60
	public void set_scaleAtRest(Vector3 value) { }

	// RVA: 0x3EDFD10 Offset: 0x3EDFE11 VA: 0x3EDFD10
	public Vector3 get_scaleOffset() { }

	// RVA: 0x3EDFDC0 Offset: 0x3EDFEC1 VA: 0x3EDFDC0
	public void set_scaleOffset(Vector3 value) { }

	// RVA: 0x3EDFE70 Offset: 0x3EDFF71 VA: 0x3EDFE70
	public Axis get_scalingAxis() { }

	// RVA: 0x3EDFEC0 Offset: 0x3EDFFC1 VA: 0x3EDFEC0
	public void set_scalingAxis(Axis value) { }

	// RVA: 0x3EDFF10 Offset: 0x3EE0011 VA: 0x3EDFF10 Slot: 6
	public bool get_constraintActive() { }

	// RVA: 0x3EDFF60 Offset: 0x3EE0061 VA: 0x3EDFF60 Slot: 7
	public void set_constraintActive(bool value) { }

	// RVA: 0x3EDFFB0 Offset: 0x3EE00B1 VA: 0x3EDFFB0 Slot: 8
	public bool get_locked() { }

	// RVA: 0x3EE0000 Offset: 0x3EE0101 VA: 0x3EE0000 Slot: 9
	public void set_locked(bool value) { }

	// RVA: 0x3EE0050 Offset: 0x3EE0151 VA: 0x3EE0050 Slot: 10
	public int get_sourceCount() { }

	[FreeFunctionAttribute] // RVA: 0x38740 Offset: 0x38841 VA: 0x38740
	// RVA: 0x3EE00A0 Offset: 0x3EE01A1 VA: 0x3EE00A0
	private static int GetSourceCountInternal(ScaleConstraint self) { }

	[FreeFunctionAttribute] // RVA: 0x38780 Offset: 0x38881 VA: 0x38780
	// RVA: 0x3EE00F0 Offset: 0x3EE01F1 VA: 0x3EE00F0 Slot: 11
	public void GetSources(List<ConstraintSource> sources) { }

	// RVA: 0x3EE0140 Offset: 0x3EE0241 VA: 0x3EE0140 Slot: 12
	public void SetSources(List<ConstraintSource> sources) { }

	[FreeFunctionAttribute] // RVA: 0x387D0 Offset: 0x388D1 VA: 0x387D0
	// RVA: 0x3EE01E0 Offset: 0x3EE02E1 VA: 0x3EE01E0
	private static void SetSourcesInternal(ScaleConstraint self, List<ConstraintSource> sources) { }

	// RVA: 0x3EE0230 Offset: 0x3EE0331 VA: 0x3EE0230 Slot: 13
	public int AddSource(ConstraintSource source) { }

	// RVA: 0x3EE02E0 Offset: 0x3EE03E1 VA: 0x3EE02E0 Slot: 14
	public void RemoveSource(int index) { }

	[NativeNameAttribute] // RVA: 0x38820 Offset: 0x38921 VA: 0x38820
	// RVA: 0x3EE04C0 Offset: 0x3EE05C1 VA: 0x3EE04C0
	private void RemoveSourceInternal(int index) { }

	// RVA: 0x3EE0510 Offset: 0x3EE0611 VA: 0x3EE0510 Slot: 15
	public ConstraintSource GetSource(int index) { }

	[NativeNameAttribute] // RVA: 0x38860 Offset: 0x38961 VA: 0x38860
	// RVA: 0x3EE0580 Offset: 0x3EE0681 VA: 0x3EE0580
	private ConstraintSource GetSourceInternal(int index) { }

	// RVA: 0x3EE0650 Offset: 0x3EE0751 VA: 0x3EE0650 Slot: 16
	public void SetSource(int index, ConstraintSource source) { }

	[NativeNameAttribute] // RVA: 0x388A0 Offset: 0x389A1 VA: 0x388A0
	// RVA: 0x3EE06C0 Offset: 0x3EE07C1 VA: 0x3EE06C0
	private void SetSourceInternal(int index, ConstraintSource source) { }

	// RVA: 0x3EE0340 Offset: 0x3EE0441 VA: 0x3EE0340
	private void ValidateSourceIndex(int index) { }

	// RVA: 0x3EDFC10 Offset: 0x3EDFD11 VA: 0x3EDFC10
	private void get_scaleAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x3EDFCC0 Offset: 0x3EDFDC1 VA: 0x3EDFCC0
	private void set_scaleAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x3EDFD70 Offset: 0x3EDFE71 VA: 0x3EDFD70
	private void get_scaleOffset_Injected(out Vector3 ret) { }

	// RVA: 0x3EDFE20 Offset: 0x3EDFF21 VA: 0x3EDFE20
	private void set_scaleOffset_Injected(ref Vector3 value) { }

	// RVA: 0x3EE0290 Offset: 0x3EE0391 VA: 0x3EE0290 Slot: 17
	private int AddSource_Injected(ref ConstraintSource source) { }

	// RVA: 0x3EE05F0 Offset: 0x3EE06F1 VA: 0x3EE05F0
	private void GetSourceInternal_Injected(int index, out ConstraintSource ret) { }

	// RVA: 0x3EE0730 Offset: 0x3EE0831 VA: 0x3EE0730
	private void SetSourceInternal_Injected(int index, ref ConstraintSource source) { }
}

