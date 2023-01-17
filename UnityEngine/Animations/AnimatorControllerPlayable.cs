// Namespace: UnityEngine.Animations
[RequiredByNativeCodeAttribute] // RVA: 0x35A70 Offset: 0x35B71 VA: 0x35A70
[NativeHeaderAttribute] // RVA: 0x35A70 Offset: 0x35B71 VA: 0x35A70
[NativeHeaderAttribute] // RVA: 0x35A70 Offset: 0x35B71 VA: 0x35A70
[NativeHeaderAttribute] // RVA: 0x35A70 Offset: 0x35B71 VA: 0x35A70
[NativeHeaderAttribute] // RVA: 0x35A70 Offset: 0x35B71 VA: 0x35A70
[StaticAccessorAttribute] // RVA: 0x35A70 Offset: 0x35B71 VA: 0x35A70
[NativeHeaderAttribute] // RVA: 0x35A70 Offset: 0x35B71 VA: 0x35A70
public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 4133
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x3EDBB00 Offset: 0x3EDBC01 VA: 0x3EDBB00
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x3EDBCA0 Offset: 0x3EDBDA1 VA: 0x3EDBCA0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x3EDBB90 Offset: 0x3EDBC91 VA: 0x3EDBB90
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x3EDBCB0 Offset: 0x3EDBDB1 VA: 0x3EDBCB0 Slot: 5
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x3EDBD40 Offset: 0x3EDBE41 VA: 0x3EDBD40
	public void SetFloat(string name, float value) { }

	[NativeThrowsAttribute] // RVA: 0x38730 Offset: 0x38831 VA: 0x38730
	// RVA: 0x3EDBDF0 Offset: 0x3EDBEF1 VA: 0x3EDBDF0
	private static void SetFloatString(ref PlayableHandle handle, string name, float value) { }

	// RVA: 0x3EDBE50 Offset: 0x3EDBF51 VA: 0x3EDBE50
	private static void .cctor() { }
}

