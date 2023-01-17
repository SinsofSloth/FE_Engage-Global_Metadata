// Namespace: UnityEngine.Animations
[RequireComponent] // RVA: 0x35D30 Offset: 0x35E31 VA: 0x35D30
[NativeHeaderAttribute] // RVA: 0x35D30 Offset: 0x35E31 VA: 0x35D30
[NativeHeaderAttribute] // RVA: 0x35D30 Offset: 0x35E31 VA: 0x35D30
[UsedByNativeCodeAttribute] // RVA: 0x35D30 Offset: 0x35E31 VA: 0x35D30
public sealed class ParentConstraint : Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 4139
{
	// Properties
	public float weight { get; set; }
	public bool constraintActive { get; set; }
	public bool locked { get; set; }
	public int sourceCount { get; }
	public Vector3 translationAtRest { get; set; }
	public Vector3 rotationAtRest { get; set; }
	public Vector3[] translationOffsets { get; set; }
	public Vector3[] rotationOffsets { get; set; }
	public Axis translationAxis { get; set; }
	public Axis rotationAxis { get; set; }

	// Methods

	// RVA: 0x3EDE5A0 Offset: 0x3EDE6A1 VA: 0x3EDE5A0
	private void .ctor() { }

	// RVA: 0x3EDE600 Offset: 0x3EDE701 VA: 0x3EDE600
	private static void Internal_Create(ParentConstraint self) { }

	// RVA: 0x3EDE650 Offset: 0x3EDE751 VA: 0x3EDE650 Slot: 4
	public float get_weight() { }

	// RVA: 0x3EDE6A0 Offset: 0x3EDE7A1 VA: 0x3EDE6A0 Slot: 5
	public void set_weight(float value) { }

	// RVA: 0x3EDE6F0 Offset: 0x3EDE7F1 VA: 0x3EDE6F0 Slot: 6
	public bool get_constraintActive() { }

	// RVA: 0x3EDE740 Offset: 0x3EDE841 VA: 0x3EDE740 Slot: 7
	public void set_constraintActive(bool value) { }

	// RVA: 0x3EDE790 Offset: 0x3EDE891 VA: 0x3EDE790 Slot: 8
	public bool get_locked() { }

	// RVA: 0x3EDE7E0 Offset: 0x3EDE8E1 VA: 0x3EDE7E0 Slot: 9
	public void set_locked(bool value) { }

	// RVA: 0x3EDE830 Offset: 0x3EDE931 VA: 0x3EDE830 Slot: 10
	public int get_sourceCount() { }

	[FreeFunctionAttribute] // RVA: 0x388E0 Offset: 0x389E1 VA: 0x388E0
	// RVA: 0x3EDE880 Offset: 0x3EDE981 VA: 0x3EDE880
	private static int GetSourceCountInternal(ParentConstraint self) { }

	// RVA: 0x3EDE8D0 Offset: 0x3EDE9D1 VA: 0x3EDE8D0
	public Vector3 get_translationAtRest() { }

	// RVA: 0x3EDE980 Offset: 0x3EDEA81 VA: 0x3EDE980
	public void set_translationAtRest(Vector3 value) { }

	// RVA: 0x3EDEA30 Offset: 0x3EDEB31 VA: 0x3EDEA30
	public Vector3 get_rotationAtRest() { }

	// RVA: 0x3EDEAE0 Offset: 0x3EDEBE1 VA: 0x3EDEAE0
	public void set_rotationAtRest(Vector3 value) { }

	// RVA: 0x3EDEB90 Offset: 0x3EDEC91 VA: 0x3EDEB90
	public Vector3[] get_translationOffsets() { }

	// RVA: 0x3EDEBE0 Offset: 0x3EDECE1 VA: 0x3EDEBE0
	public void set_translationOffsets(Vector3[] value) { }

	// RVA: 0x3EDEC30 Offset: 0x3EDED31 VA: 0x3EDEC30
	public Vector3[] get_rotationOffsets() { }

	// RVA: 0x3EDEC80 Offset: 0x3EDED81 VA: 0x3EDEC80
	public void set_rotationOffsets(Vector3[] value) { }

	// RVA: 0x3EDECD0 Offset: 0x3EDEDD1 VA: 0x3EDECD0
	public Axis get_translationAxis() { }

	// RVA: 0x3EDED20 Offset: 0x3EDEE21 VA: 0x3EDED20
	public void set_translationAxis(Axis value) { }

	// RVA: 0x3EDED70 Offset: 0x3EDEE71 VA: 0x3EDED70
	public Axis get_rotationAxis() { }

	// RVA: 0x3EDEDC0 Offset: 0x3EDEEC1 VA: 0x3EDEDC0
	public void set_rotationAxis(Axis value) { }

	// RVA: 0x3EDEE10 Offset: 0x3EDEF11 VA: 0x3EDEE10
	public Vector3 GetTranslationOffset(int index) { }

	// RVA: 0x3EDF080 Offset: 0x3EDF181 VA: 0x3EDF080
	public void SetTranslationOffset(int index, Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x38920 Offset: 0x38A21 VA: 0x38920
	// RVA: 0x3EDF010 Offset: 0x3EDF111 VA: 0x3EDF010
	private Vector3 GetTranslationOffsetInternal(int index) { }

	[NativeNameAttribute] // RVA: 0x38960 Offset: 0x38A61 VA: 0x38960
	// RVA: 0x3EDF110 Offset: 0x3EDF211 VA: 0x3EDF110
	private void SetTranslationOffsetInternal(int index, Vector3 value) { }

	// RVA: 0x3EDF240 Offset: 0x3EDF341 VA: 0x3EDF240
	public Vector3 GetRotationOffset(int index) { }

	// RVA: 0x3EDF330 Offset: 0x3EDF431 VA: 0x3EDF330
	public void SetRotationOffset(int index, Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x389A0 Offset: 0x38AA1 VA: 0x389A0
	// RVA: 0x3EDF2C0 Offset: 0x3EDF3C1 VA: 0x3EDF2C0
	private Vector3 GetRotationOffsetInternal(int index) { }

	[NativeNameAttribute] // RVA: 0x389E0 Offset: 0x38AE1 VA: 0x389E0
	// RVA: 0x3EDF3C0 Offset: 0x3EDF4C1 VA: 0x3EDF3C0
	private void SetRotationOffsetInternal(int index, Vector3 value) { }

	// RVA: 0x3EDEE90 Offset: 0x3EDEF91 VA: 0x3EDEE90
	private void ValidateSourceIndex(int index) { }

	[FreeFunctionAttribute] // RVA: 0x38A20 Offset: 0x38B21 VA: 0x38A20
	// RVA: 0x3EDF4F0 Offset: 0x3EDF5F1 VA: 0x3EDF4F0 Slot: 11
	public void GetSources(List<ConstraintSource> sources) { }

	// RVA: 0x3EDF540 Offset: 0x3EDF641 VA: 0x3EDF540 Slot: 12
	public void SetSources(List<ConstraintSource> sources) { }

	[FreeFunctionAttribute] // RVA: 0x38A70 Offset: 0x38B71 VA: 0x38A70
	// RVA: 0x3EDF5E0 Offset: 0x3EDF6E1 VA: 0x3EDF5E0
	private static void SetSourcesInternal(ParentConstraint self, List<ConstraintSource> sources) { }

	// RVA: 0x3EDF630 Offset: 0x3EDF731 VA: 0x3EDF630 Slot: 13
	public int AddSource(ConstraintSource source) { }

	// RVA: 0x3EDF6E0 Offset: 0x3EDF7E1 VA: 0x3EDF6E0 Slot: 14
	public void RemoveSource(int index) { }

	[NativeNameAttribute] // RVA: 0x38AC0 Offset: 0x38BC1 VA: 0x38AC0
	// RVA: 0x3EDF740 Offset: 0x3EDF841 VA: 0x3EDF740
	private void RemoveSourceInternal(int index) { }

	// RVA: 0x3EDF790 Offset: 0x3EDF891 VA: 0x3EDF790 Slot: 15
	public ConstraintSource GetSource(int index) { }

	[NativeNameAttribute] // RVA: 0x38B00 Offset: 0x38C01 VA: 0x38B00
	// RVA: 0x3EDF800 Offset: 0x3EDF901 VA: 0x3EDF800
	private ConstraintSource GetSourceInternal(int index) { }

	// RVA: 0x3EDF8D0 Offset: 0x3EDF9D1 VA: 0x3EDF8D0 Slot: 16
	public void SetSource(int index, ConstraintSource source) { }

	[NativeNameAttribute] // RVA: 0x38B40 Offset: 0x38C41 VA: 0x38B40
	// RVA: 0x3EDF940 Offset: 0x3EDFA41 VA: 0x3EDF940
	private void SetSourceInternal(int index, ConstraintSource source) { }

	// RVA: 0x3EDE930 Offset: 0x3EDEA31 VA: 0x3EDE930
	private void get_translationAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x3EDE9E0 Offset: 0x3EDEAE1 VA: 0x3EDE9E0
	private void set_translationAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x3EDEA90 Offset: 0x3EDEB91 VA: 0x3EDEA90
	private void get_rotationAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x3EDEB40 Offset: 0x3EDEC41 VA: 0x3EDEB40
	private void set_rotationAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x3EDF180 Offset: 0x3EDF281 VA: 0x3EDF180
	private void GetTranslationOffsetInternal_Injected(int index, out Vector3 ret) { }

	// RVA: 0x3EDF1E0 Offset: 0x3EDF2E1 VA: 0x3EDF1E0
	private void SetTranslationOffsetInternal_Injected(int index, ref Vector3 value) { }

	// RVA: 0x3EDF430 Offset: 0x3EDF531 VA: 0x3EDF430
	private void GetRotationOffsetInternal_Injected(int index, out Vector3 ret) { }

	// RVA: 0x3EDF490 Offset: 0x3EDF591 VA: 0x3EDF490
	private void SetRotationOffsetInternal_Injected(int index, ref Vector3 value) { }

	// RVA: 0x3EDF690 Offset: 0x3EDF791 VA: 0x3EDF690 Slot: 17
	private int AddSource_Injected(ref ConstraintSource source) { }

	// RVA: 0x3EDF870 Offset: 0x3EDF971 VA: 0x3EDF870
	private void GetSourceInternal_Injected(int index, out ConstraintSource ret) { }

	// RVA: 0x3EDF9B0 Offset: 0x3EDFAB1 VA: 0x3EDF9B0
	private void SetSourceInternal_Injected(int index, ref ConstraintSource source) { }
}

