// Namespace: UnityEngine
[NativeClassAttribute] // RVA: 0x43F010 Offset: 0x43F111 VA: 0x43F010
[NativeHeaderAttribute] // RVA: 0x43F010 Offset: 0x43F111 VA: 0x43F010
public sealed class RectTransform : Transform // TypeDefIndex: 3648
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x4439D0 Offset: 0x443AD1 VA: 0x4439D0
	[CompilerGeneratedAttribute] // RVA: 0x4439D0 Offset: 0x443AD1 VA: 0x4439D0
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }
	internal Object drivenByObject { get; set; }
	internal DrivenTransformProperties drivenProperties { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4515C0 Offset: 0x4516C1 VA: 0x4515C0
	// RVA: 0x31D4100 Offset: 0x31D4201 VA: 0x31D4100
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4515D0 Offset: 0x4516D1 VA: 0x4515D0
	// RVA: 0x31D41C0 Offset: 0x31D42C1 VA: 0x31D41C0
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x31D4280 Offset: 0x31D4381 VA: 0x31D4280
	public Rect get_rect() { }

	// RVA: 0x31D4330 Offset: 0x31D4431 VA: 0x31D4330
	public Vector2 get_anchorMin() { }

	// RVA: 0x31D43E0 Offset: 0x31D44E1 VA: 0x31D43E0
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x31D4490 Offset: 0x31D4591 VA: 0x31D4490
	public Vector2 get_anchorMax() { }

	// RVA: 0x31D4540 Offset: 0x31D4641 VA: 0x31D4540
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x31D45F0 Offset: 0x31D46F1 VA: 0x31D45F0
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x31D46A0 Offset: 0x31D47A1 VA: 0x31D46A0
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x31D4750 Offset: 0x31D4851 VA: 0x31D4750
	public Vector2 get_sizeDelta() { }

	// RVA: 0x31D4800 Offset: 0x31D4901 VA: 0x31D4800
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x31D48B0 Offset: 0x31D49B1 VA: 0x31D48B0
	public Vector2 get_pivot() { }

	// RVA: 0x31D4960 Offset: 0x31D4A61 VA: 0x31D4960
	public void set_pivot(Vector2 value) { }

	// RVA: 0x31D4A10 Offset: 0x31D4B11 VA: 0x31D4A10
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x31D4A90 Offset: 0x31D4B91 VA: 0x31D4A90
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x31D4B10 Offset: 0x31D4C11 VA: 0x31D4B10
	public Vector2 get_offsetMin() { }

	// RVA: 0x31D4BF0 Offset: 0x31D4CF1 VA: 0x31D4BF0
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x31D4E10 Offset: 0x31D4F11 VA: 0x31D4E10
	public Vector2 get_offsetMax() { }

	// RVA: 0x31D4F10 Offset: 0x31D5011 VA: 0x31D4F10
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x31D5140 Offset: 0x31D5241 VA: 0x31D5140
	internal Object get_drivenByObject() { }

	// RVA: 0x31D5190 Offset: 0x31D5291 VA: 0x31D5190
	internal void set_drivenByObject(Object value) { }

	// RVA: 0x31D51E0 Offset: 0x31D52E1 VA: 0x31D51E0
	internal DrivenTransformProperties get_drivenProperties() { }

	// RVA: 0x31D5230 Offset: 0x31D5331 VA: 0x31D5230
	internal void set_drivenProperties(DrivenTransformProperties value) { }

	[NativeMethodAttribute] // RVA: 0x4515E0 Offset: 0x4516E1 VA: 0x4515E0
	// RVA: 0x31D5280 Offset: 0x31D5381 VA: 0x31D5280
	public void ForceUpdateRectTransforms() { }

	// RVA: 0x31D52D0 Offset: 0x31D53D1 VA: 0x31D52D0
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x31D5410 Offset: 0x31D5511 VA: 0x31D5410
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x31D55E0 Offset: 0x31D56E1 VA: 0x31D55E0
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x31D58C0 Offset: 0x31D59C1 VA: 0x31D58C0
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x451620 Offset: 0x451721 VA: 0x451620
	// RVA: 0x31D5B70 Offset: 0x31D5C71 VA: 0x31D5B70
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x31D5BF0 Offset: 0x31D5CF1 VA: 0x31D5BF0
	internal Rect GetRectInParentSpace() { }

	// RVA: 0x31D5A50 Offset: 0x31D5B51 VA: 0x31D5A50
	private Vector2 GetParentSize() { }

	// RVA: 0x31D5E30 Offset: 0x31D5F31 VA: 0x31D5E30
	public void .ctor() { }

	// RVA: 0x31D42E0 Offset: 0x31D43E1 VA: 0x31D42E0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x31D4390 Offset: 0x31D4491 VA: 0x31D4390
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x31D4440 Offset: 0x31D4541 VA: 0x31D4440
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x31D44F0 Offset: 0x31D45F1 VA: 0x31D44F0
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x31D45A0 Offset: 0x31D46A1 VA: 0x31D45A0
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x31D4650 Offset: 0x31D4751 VA: 0x31D4650
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x31D4700 Offset: 0x31D4801 VA: 0x31D4700
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x31D47B0 Offset: 0x31D48B1 VA: 0x31D47B0
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x31D4860 Offset: 0x31D4961 VA: 0x31D4860
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x31D4910 Offset: 0x31D4A11 VA: 0x31D4910
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x31D49C0 Offset: 0x31D4AC1 VA: 0x31D49C0
	private void set_pivot_Injected(ref Vector2 value) { }
}

