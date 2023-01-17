// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43B910 Offset: 0x43BA11 VA: 0x43B910
[DefaultMemberAttribute] // RVA: 0x43B910 Offset: 0x43BA11 VA: 0x43B910
[RequiredByNativeCodeAttribute] // RVA: 0x43B910 Offset: 0x43BA11 VA: 0x43B910
public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 3399
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { set; }
	public WrapMode postWrapMode { set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x445D50 Offset: 0x445E51 VA: 0x445D50
	// RVA: 0x2F08E30 Offset: 0x2F08F31 VA: 0x2F08E30
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0x445DA0 Offset: 0x445EA1 VA: 0x445DA0
	// RVA: 0x2F08E80 Offset: 0x2F08F81 VA: 0x2F08E80
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0x445DF0 Offset: 0x445EF1 VA: 0x445DF0
	// RVA: 0x2F08ED0 Offset: 0x2F08FD1 VA: 0x2F08ED0
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x2F08F20 Offset: 0x2F09021 VA: 0x2F08F20 Slot: 1
	protected override void Finalize() { }

	[ThreadSafeAttribute] // RVA: 0x445E40 Offset: 0x445F41 VA: 0x445E40
	// RVA: 0x2F08FC0 Offset: 0x2F090C1 VA: 0x2F08FC0
	public float Evaluate(float time) { }

	// RVA: 0x2F09010 Offset: 0x2F09111 VA: 0x2F09010
	public Keyframe[] get_keys() { }

	// RVA: 0x2F090B0 Offset: 0x2F091B1 VA: 0x2F090B0
	public void set_keys(Keyframe[] value) { }

	[FreeFunctionAttribute] // RVA: 0x445E50 Offset: 0x445F51 VA: 0x445E50
	// RVA: 0x2F09150 Offset: 0x2F09251 VA: 0x2F09150
	public int AddKey(float time, float value) { }

	// RVA: 0x2F091B0 Offset: 0x2F092B1 VA: 0x2F091B0
	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] // RVA: 0x445EA0 Offset: 0x445FA1 VA: 0x445EA0
	// RVA: 0x2F09220 Offset: 0x2F09321 VA: 0x2F09220
	private int AddKey_Internal(Keyframe key) { }

	[FreeFunctionAttribute] // RVA: 0x445EF0 Offset: 0x445FF1 VA: 0x445EF0
	[NativeThrowsAttribute] // RVA: 0x445EF0 Offset: 0x445FF1 VA: 0x445EF0
	// RVA: 0x2F092C0 Offset: 0x2F093C1 VA: 0x2F092C0
	public int MoveKey(int index, Keyframe key) { }

	[NativeThrowsAttribute] // RVA: 0x445F50 Offset: 0x446051 VA: 0x445F50
	[FreeFunctionAttribute] // RVA: 0x445F50 Offset: 0x446051 VA: 0x445F50
	// RVA: 0x2F09380 Offset: 0x2F09481 VA: 0x2F09380
	public void RemoveKey(int index) { }

	// RVA: 0x2F093D0 Offset: 0x2F094D1 VA: 0x2F093D0
	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] // RVA: 0x445FB0 Offset: 0x4460B1 VA: 0x445FB0
	// RVA: 0x2F09500 Offset: 0x2F09601 VA: 0x2F09500
	public int get_length() { }

	[FreeFunctionAttribute] // RVA: 0x446000 Offset: 0x446101 VA: 0x446000
	// RVA: 0x2F09100 Offset: 0x2F09201 VA: 0x2F09100
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0x446050 Offset: 0x446151 VA: 0x446050
	[NativeThrowsAttribute] // RVA: 0x446050 Offset: 0x446151 VA: 0x446050
	// RVA: 0x2F09470 Offset: 0x2F09571 VA: 0x2F09470
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] // RVA: 0x4460B0 Offset: 0x4461B1 VA: 0x4460B0
	// RVA: 0x2F09060 Offset: 0x2F09161 VA: 0x2F09060
	private Keyframe[] GetKeys() { }

	[NativeThrowsAttribute] // RVA: 0x446100 Offset: 0x446201 VA: 0x446100
	[FreeFunctionAttribute] // RVA: 0x446100 Offset: 0x446201 VA: 0x446100
	// RVA: 0x2F095B0 Offset: 0x2F096B1 VA: 0x2F095B0
	public void SmoothTangents(int index, float weight) { }

	// RVA: 0x2F09610 Offset: 0x2F09711 VA: 0x2F09610
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x2F09810 Offset: 0x2F09911 VA: 0x2F09810
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] // RVA: 0x446160 Offset: 0x446261 VA: 0x446160
	// RVA: 0x2F09960 Offset: 0x2F09A61 VA: 0x2F09960
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] // RVA: 0x4461B0 Offset: 0x4462B1 VA: 0x4461B0
	// RVA: 0x2F099B0 Offset: 0x2F09AB1 VA: 0x2F099B0
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x2F09790 Offset: 0x2F09891 VA: 0x2F09790
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x446200 Offset: 0x446301 VA: 0x446200
	// RVA: 0x2F09A00 Offset: 0x2F09B01 VA: 0x2F09A00
	public void .ctor() { }

	// RVA: 0x2F09A50 Offset: 0x2F09B51 VA: 0x2F09A50 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2F09BB0 Offset: 0x2F09CB1 VA: 0x2F09BB0 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x2F09C80 Offset: 0x2F09D81 VA: 0x2F09C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F09270 Offset: 0x2F09371 VA: 0x2F09270
	private int AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0x2F09320 Offset: 0x2F09421 VA: 0x2F09320
	private int MoveKey_Injected(int index, ref Keyframe key) { }

	// RVA: 0x2F09550 Offset: 0x2F09651 VA: 0x2F09550
	private void GetKey_Injected(int index, out Keyframe ret) { }
}

