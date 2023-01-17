// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43F070 Offset: 0x43F171 VA: 0x43F070
[NativeHeaderAttribute] // RVA: 0x43F070 Offset: 0x43F171 VA: 0x43F070
[NativeHeaderAttribute] // RVA: 0x43F070 Offset: 0x43F171 VA: 0x43F070
[NativeHeaderAttribute] // RVA: 0x43F070 Offset: 0x43F171 VA: 0x43F070
public class Transform : Component, IEnumerable // TypeDefIndex: 3651
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; set; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	[NativeConditionalAttribute] // RVA: 0x45A4D0 Offset: 0x45A5D1 VA: 0x45A4D0
	internal RotationOrder rotationOrder { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativePropertyAttribute] // RVA: 0x45A510 Offset: 0x45A611 VA: 0x45A510
	public bool hasChanged { get; set; }
	public int hierarchyCapacity { get; set; }
	public int hierarchyCount { get; }

	// Methods

	// RVA: 0x3846EA0 Offset: 0x3846FA1 VA: 0x3846EA0
	protected void .ctor() { }

	// RVA: 0x3846EB0 Offset: 0x3846FB1 VA: 0x3846EB0
	public Vector3 get_position() { }

	// RVA: 0x3846F60 Offset: 0x3847061 VA: 0x3846F60
	public void set_position(Vector3 value) { }

	// RVA: 0x3847010 Offset: 0x3847111 VA: 0x3847010
	public Vector3 get_localPosition() { }

	// RVA: 0x38470C0 Offset: 0x38471C1 VA: 0x38470C0
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x3847170 Offset: 0x3847271 VA: 0x3847170
	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	// RVA: 0x3847240 Offset: 0x3847341 VA: 0x3847240
	internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	[NativeConditionalAttribute] // RVA: 0x451630 Offset: 0x451731 VA: 0x451630
	// RVA: 0x3847310 Offset: 0x3847411 VA: 0x3847310
	internal void SetLocalEulerHint(Vector3 euler) { }

	// RVA: 0x38473C0 Offset: 0x38474C1 VA: 0x38473C0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x38474A0 Offset: 0x38475A1 VA: 0x38474A0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x3847560 Offset: 0x3847661 VA: 0x3847560
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x3847640 Offset: 0x3847741 VA: 0x3847640
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x3847700 Offset: 0x3847801 VA: 0x3847700
	public Vector3 get_right() { }

	// RVA: 0x3847810 Offset: 0x3847911 VA: 0x3847810
	public void set_right(Vector3 value) { }

	// RVA: 0x38478E0 Offset: 0x38479E1 VA: 0x38478E0
	public Vector3 get_up() { }

	// RVA: 0x38479F0 Offset: 0x3847AF1 VA: 0x38479F0
	public void set_up(Vector3 value) { }

	// RVA: 0x3847AC0 Offset: 0x3847BC1 VA: 0x3847AC0
	public Vector3 get_forward() { }

	// RVA: 0x3847BD0 Offset: 0x3847CD1 VA: 0x3847BD0
	public void set_forward(Vector3 value) { }

	// RVA: 0x3847440 Offset: 0x3847541 VA: 0x3847440
	public Quaternion get_rotation() { }

	// RVA: 0x3847500 Offset: 0x3847601 VA: 0x3847500
	public void set_rotation(Quaternion value) { }

	// RVA: 0x38475E0 Offset: 0x38476E1 VA: 0x38475E0
	public Quaternion get_localRotation() { }

	// RVA: 0x38476A0 Offset: 0x38477A1 VA: 0x38476A0
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x3847D70 Offset: 0x3847E71 VA: 0x3847D70
	internal RotationOrder get_rotationOrder() { }

	// RVA: 0x3847E10 Offset: 0x3847F11 VA: 0x3847E10
	internal void set_rotationOrder(RotationOrder value) { }

	[NativeConditionalAttribute] // RVA: 0x451670 Offset: 0x451771 VA: 0x451670
	[NativeMethodAttribute] // RVA: 0x451670 Offset: 0x451771 VA: 0x451670
	// RVA: 0x3847DC0 Offset: 0x3847EC1 VA: 0x3847DC0
	internal int GetRotationOrderInternal() { }

	[NativeConditionalAttribute] // RVA: 0x4516D0 Offset: 0x4517D1 VA: 0x4516D0
	[NativeMethodAttribute] // RVA: 0x4516D0 Offset: 0x4517D1 VA: 0x4516D0
	// RVA: 0x3847E60 Offset: 0x3847F61 VA: 0x3847E60
	internal void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	// RVA: 0x3847EB0 Offset: 0x3847FB1 VA: 0x3847EB0
	public Vector3 get_localScale() { }

	// RVA: 0x3847F60 Offset: 0x3848061 VA: 0x3847F60
	public void set_localScale(Vector3 value) { }

	// RVA: 0x3848010 Offset: 0x3848111 VA: 0x3848010
	public Transform get_parent() { }

	// RVA: 0x38480B0 Offset: 0x38481B1 VA: 0x38480B0
	public void set_parent(Transform value) { }

	// RVA: 0x3848060 Offset: 0x3848161 VA: 0x3848060
	internal Transform get_parentInternal() { }

	// RVA: 0x38481A0 Offset: 0x38482A1 VA: 0x38481A0
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x3848200 Offset: 0x3848301 VA: 0x3848200
	private Transform GetParent() { }

	// RVA: 0x3848250 Offset: 0x3848351 VA: 0x3848250
	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0x451730 Offset: 0x451831 VA: 0x451730
	// RVA: 0x38482B0 Offset: 0x38483B1 VA: 0x38482B0
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x3848310 Offset: 0x3848411 VA: 0x3848310
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x38483F0 Offset: 0x38484F1 VA: 0x38483F0
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x38484D0 Offset: 0x38485D1 VA: 0x38484D0
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x38485A0 Offset: 0x38486A1 VA: 0x38485A0
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x3848740 Offset: 0x3848841 VA: 0x3848740
	public void Translate(Vector3 translation) { }

	// RVA: 0x3848750 Offset: 0x3848851 VA: 0x3848750
	public void Translate(float x, float y, float z, Space relativeTo) { }

	// RVA: 0x3848760 Offset: 0x3848861 VA: 0x3848760
	public void Translate(float x, float y, float z) { }

	// RVA: 0x3848770 Offset: 0x3848871 VA: 0x3848770
	public void Translate(Vector3 translation, Transform relativeTo) { }

	// RVA: 0x38488F0 Offset: 0x38489F1 VA: 0x38488F0
	public void Translate(float x, float y, float z, Transform relativeTo) { }

	// RVA: 0x3848900 Offset: 0x3848A01 VA: 0x3848900
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x3848B30 Offset: 0x3848C31 VA: 0x3848B30
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x3848B40 Offset: 0x3848C41 VA: 0x3848B40
	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	// RVA: 0x3848B50 Offset: 0x3848C51 VA: 0x3848B50
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	[NativeMethodAttribute] // RVA: 0x451780 Offset: 0x451881 VA: 0x451780
	// RVA: 0x3848B60 Offset: 0x3848C61 VA: 0x3848B60
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x3848C30 Offset: 0x3848D31 VA: 0x3848C30
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x3848D50 Offset: 0x3848E51 VA: 0x3848D50
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x3848E40 Offset: 0x3848F41 VA: 0x3848E40
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x3848F90 Offset: 0x3849091 VA: 0x3848F90
	public void LookAt(Transform target, Vector3 worldUp) { }

	// RVA: 0x3849130 Offset: 0x3849231 VA: 0x3849130
	public void LookAt(Transform target) { }

	// RVA: 0x38490C0 Offset: 0x38491C1 VA: 0x38490C0
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x38492F0 Offset: 0x38493F1 VA: 0x38492F0
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0x4517C0 Offset: 0x4518C1 VA: 0x4517C0
	// RVA: 0x3849280 Offset: 0x3849381 VA: 0x3849280
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x38486D0 Offset: 0x38487D1 VA: 0x38486D0
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x3849470 Offset: 0x3849571 VA: 0x3849470
	public Vector3 TransformDirection(float x, float y, float z) { }

	// RVA: 0x38494E0 Offset: 0x38495E1 VA: 0x38494E0
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x38495B0 Offset: 0x38496B1 VA: 0x38495B0
	public Vector3 InverseTransformDirection(float x, float y, float z) { }

	// RVA: 0x3849620 Offset: 0x3849721 VA: 0x3849620
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x38496F0 Offset: 0x38497F1 VA: 0x38496F0
	public Vector3 TransformVector(float x, float y, float z) { }

	// RVA: 0x3849760 Offset: 0x3849861 VA: 0x3849760
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x3849830 Offset: 0x3849931 VA: 0x3849830
	public Vector3 InverseTransformVector(float x, float y, float z) { }

	// RVA: 0x38498A0 Offset: 0x38499A1 VA: 0x38498A0
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x3849970 Offset: 0x3849A71 VA: 0x3849970
	public Vector3 TransformPoint(float x, float y, float z) { }

	// RVA: 0x38499E0 Offset: 0x3849AE1 VA: 0x38499E0
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x3849AB0 Offset: 0x3849BB1 VA: 0x3849AB0
	public Vector3 InverseTransformPoint(float x, float y, float z) { }

	// RVA: 0x3849B20 Offset: 0x3849C21 VA: 0x3849B20
	public Transform get_root() { }

	// RVA: 0x3849B70 Offset: 0x3849C71 VA: 0x3849B70
	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0x451810 Offset: 0x451911 VA: 0x451810
	// RVA: 0x3849BC0 Offset: 0x3849CC1 VA: 0x3849BC0
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0x451850 Offset: 0x451951 VA: 0x451850
	// RVA: 0x3849C10 Offset: 0x3849D11 VA: 0x3849C10
	public void DetachChildren() { }

	// RVA: 0x3849C60 Offset: 0x3849D61 VA: 0x3849C60
	public void SetAsFirstSibling() { }

	// RVA: 0x3849CB0 Offset: 0x3849DB1 VA: 0x3849CB0
	public void SetAsLastSibling() { }

	// RVA: 0x3849D00 Offset: 0x3849E01 VA: 0x3849D00
	public void SetSiblingIndex(int index) { }

	[NativeMethodAttribute] // RVA: 0x4518A0 Offset: 0x4519A1 VA: 0x4518A0
	// RVA: 0x3849D50 Offset: 0x3849E51 VA: 0x3849D50
	internal void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty) { }

	// RVA: 0x3849DB0 Offset: 0x3849EB1 VA: 0x3849DB0
	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0x4518E0 Offset: 0x4519E1 VA: 0x4518E0
	// RVA: 0x3849E00 Offset: 0x3849F01 VA: 0x3849E00
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x3849E60 Offset: 0x3849F61 VA: 0x3849E60
	public Transform Find(string n) { }

	[NativeConditionalAttribute] // RVA: 0x4518F0 Offset: 0x4519F1 VA: 0x4518F0
	// RVA: 0x3849F00 Offset: 0x384A001 VA: 0x3849F00
	internal void SendTransformChangedScale() { }

	[NativeMethodAttribute] // RVA: 0x451930 Offset: 0x451A31 VA: 0x451930
	// RVA: 0x3849F50 Offset: 0x384A051 VA: 0x3849F50
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0x451970 Offset: 0x451A71 VA: 0x451970
	// RVA: 0x384A000 Offset: 0x384A101 VA: 0x384A000
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x384A050 Offset: 0x384A151 VA: 0x384A050
	public bool get_hasChanged() { }

	// RVA: 0x384A0A0 Offset: 0x384A1A1 VA: 0x384A0A0
	public void set_hasChanged(bool value) { }

	[ObsoleteAttribute] // RVA: 0x4519C0 Offset: 0x451AC1 VA: 0x4519C0
	// RVA: 0x384A0F0 Offset: 0x384A1F1 VA: 0x384A0F0
	public Transform FindChild(string n) { }

	// RVA: 0x384A100 Offset: 0x384A201 VA: 0x384A100 Slot: 4
	public IEnumerator GetEnumerator() { }

	[ObsoleteAttribute] // RVA: 0x451A00 Offset: 0x451B01 VA: 0x451A00
	// RVA: 0x384A1C0 Offset: 0x384A2C1 VA: 0x384A1C0
	public void RotateAround(Vector3 axis, float angle) { }

	[ObsoleteAttribute] // RVA: 0x451A40 Offset: 0x451B41 VA: 0x451A40
	// RVA: 0x384A290 Offset: 0x384A391 VA: 0x384A290
	public void RotateAroundLocal(Vector3 axis, float angle) { }

	[NativeThrowsAttribute] // RVA: 0x451A80 Offset: 0x451B81 VA: 0x451A80
	[FreeFunctionAttribute] // RVA: 0x451A80 Offset: 0x451B81 VA: 0x451A80
	// RVA: 0x384A360 Offset: 0x384A461 VA: 0x384A360
	public Transform GetChild(int index) { }

	[NativeMethodAttribute] // RVA: 0x451AE0 Offset: 0x451BE1 VA: 0x451AE0
	[ObsoleteAttribute] // RVA: 0x451AE0 Offset: 0x451BE1 VA: 0x451AE0
	// RVA: 0x384A3B0 Offset: 0x384A4B1 VA: 0x384A3B0
	public int GetChildCount() { }

	// RVA: 0x384A400 Offset: 0x384A501 VA: 0x384A400
	public int get_hierarchyCapacity() { }

	// RVA: 0x384A4A0 Offset: 0x384A5A1 VA: 0x384A4A0
	public void set_hierarchyCapacity(int value) { }

	[FreeFunctionAttribute] // RVA: 0x451B50 Offset: 0x451C51 VA: 0x451B50
	// RVA: 0x384A450 Offset: 0x384A551 VA: 0x384A450
	private int internal_getHierarchyCapacity() { }

	[FreeFunctionAttribute] // RVA: 0x451BA0 Offset: 0x451CA1 VA: 0x451BA0
	// RVA: 0x384A4F0 Offset: 0x384A5F1 VA: 0x384A4F0
	private void internal_setHierarchyCapacity(int value) { }

	// RVA: 0x384A540 Offset: 0x384A641 VA: 0x384A540
	public int get_hierarchyCount() { }

	[FreeFunctionAttribute] // RVA: 0x451BF0 Offset: 0x451CF1 VA: 0x451BF0
	// RVA: 0x384A590 Offset: 0x384A691 VA: 0x384A590
	private int internal_getHierarchyCount() { }

	[NativeConditionalAttribute] // RVA: 0x451C40 Offset: 0x451D41 VA: 0x451C40
	[FreeFunctionAttribute] // RVA: 0x451C40 Offset: 0x451D41 VA: 0x451C40
	// RVA: 0x384A5E0 Offset: 0x384A6E1 VA: 0x384A5E0
	internal bool IsNonUniformScaleTransform() { }

	// RVA: 0x3846F10 Offset: 0x3847011 VA: 0x3846F10
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x3846FC0 Offset: 0x38470C1 VA: 0x3846FC0
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x3847070 Offset: 0x3847171 VA: 0x3847070
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x3847120 Offset: 0x3847221 VA: 0x3847120
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x38471E0 Offset: 0x38472E1 VA: 0x38471E0
	private void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret) { }

	// RVA: 0x38472B0 Offset: 0x38473B1 VA: 0x38472B0
	private void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order) { }

	// RVA: 0x3847370 Offset: 0x3847471 VA: 0x3847370
	private void SetLocalEulerHint_Injected(ref Vector3 euler) { }

	// RVA: 0x3847C30 Offset: 0x3847D31 VA: 0x3847C30
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x3847C80 Offset: 0x3847D81 VA: 0x3847C80
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x3847CD0 Offset: 0x3847DD1 VA: 0x3847CD0
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x3847D20 Offset: 0x3847E21 VA: 0x3847D20
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x3847F10 Offset: 0x3848011 VA: 0x3847F10
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x3847FC0 Offset: 0x38480C1 VA: 0x3847FC0
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x38483A0 Offset: 0x38484A1 VA: 0x38483A0
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x3848480 Offset: 0x3848581 VA: 0x3848480
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x3848540 Offset: 0x3848641 VA: 0x3848540
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x3848BD0 Offset: 0x3848CD1 VA: 0x3848BD0
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x38493B0 Offset: 0x38494B1 VA: 0x38493B0
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x3849410 Offset: 0x3849511 VA: 0x3849410
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x3849550 Offset: 0x3849651 VA: 0x3849550
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x3849690 Offset: 0x3849791 VA: 0x3849690
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x38497D0 Offset: 0x38498D1 VA: 0x38497D0
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x3849910 Offset: 0x3849A11 VA: 0x3849910
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x3849A50 Offset: 0x3849B51 VA: 0x3849A50
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x3849FB0 Offset: 0x384A0B1 VA: 0x3849FB0
	private void get_lossyScale_Injected(out Vector3 ret) { }

	// RVA: 0x384A230 Offset: 0x384A331 VA: 0x384A230
	private void RotateAround_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x384A300 Offset: 0x384A401 VA: 0x384A300
	private void RotateAroundLocal_Injected(ref Vector3 axis, float angle) { }
}

