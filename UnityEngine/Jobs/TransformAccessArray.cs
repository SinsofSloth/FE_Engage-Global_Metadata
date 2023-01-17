// Namespace: UnityEngine.Jobs
[NativeTypeAttribute] // RVA: 0x43F850 Offset: 0x43F951 VA: 0x43F850
[DefaultMemberAttribute] // RVA: 0x43F850 Offset: 0x43F951 VA: 0x43F850
public struct TransformAccessArray : IDisposable // TypeDefIndex: 3679
{
	// Fields
	private IntPtr m_TransformArray; // 0x0

	// Properties
	public int Item { set; }

	// Methods

	// RVA: 0x384A840 Offset: 0x384A941 VA: 0x384A840
	public void .ctor(Transform[] transforms, int desiredJobCount = -1) { }

	// RVA: 0x384A8E0 Offset: 0x384A9E1 VA: 0x384A8E0
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	// RVA: 0x384A9E0 Offset: 0x384AAE1 VA: 0x384A9E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x384AAB0 Offset: 0x384ABB1 VA: 0x384AAB0
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	// RVA: 0x384AAC0 Offset: 0x384ABC1 VA: 0x384AAC0
	public void set_Item(int index, Transform value) { }

	[NativeMethodAttribute] // RVA: 0x452660 Offset: 0x452761 VA: 0x452660
	// RVA: 0x384A990 Offset: 0x384AA91 VA: 0x384A990
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0x4526B0 Offset: 0x4527B1 VA: 0x4526B0
	// RVA: 0x384AA60 Offset: 0x384AB61 VA: 0x384AA60
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0x452700 Offset: 0x452801 VA: 0x452700
	// RVA: 0x384A940 Offset: 0x384AA41 VA: 0x384A940
	private static void SetTransforms(IntPtr transformArrayIntPtr, Transform[] transforms) { }

	[NativeMethodAttribute] // RVA: 0x452750 Offset: 0x452851 VA: 0x452750
	// RVA: 0x384AB80 Offset: 0x384AC81 VA: 0x384AB80
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0x4527B0 Offset: 0x4528B1 VA: 0x4527B0
	// RVA: 0x384ABD0 Offset: 0x384ACD1 VA: 0x384ABD0
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0x452810 Offset: 0x452911 VA: 0x452810
	// RVA: 0x384AB20 Offset: 0x384AC21 VA: 0x384AB20
	internal static void SetTransform(IntPtr transformArrayIntPtr, int index, Transform transform) { }
}

