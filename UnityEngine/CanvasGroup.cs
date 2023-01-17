// Namespace: UnityEngine
[NativeClassAttribute] // RVA: 0x684D0 Offset: 0x685D1 VA: 0x684D0
[NativeHeaderAttribute] // RVA: 0x684D0 Offset: 0x685D1 VA: 0x684D0
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4226
{
	// Properties
	[NativePropertyAttribute] // RVA: 0x68B30 Offset: 0x68C31 VA: 0x68B30
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0x68B70 Offset: 0x68C71 VA: 0x68B70
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0x68BB0 Offset: 0x68CB1 VA: 0x68BB0
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0x68BF0 Offset: 0x68CF1 VA: 0x68BF0
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x1C516F0 Offset: 0x1C517F1 VA: 0x1C516F0
	public float get_alpha() { }

	// RVA: 0x1C51740 Offset: 0x1C51841 VA: 0x1C51740
	public void set_alpha(float value) { }

	// RVA: 0x1C51790 Offset: 0x1C51891 VA: 0x1C51790
	public bool get_interactable() { }

	// RVA: 0x1C517E0 Offset: 0x1C518E1 VA: 0x1C517E0
	public void set_interactable(bool value) { }

	// RVA: 0x1C51830 Offset: 0x1C51931 VA: 0x1C51830
	public bool get_blocksRaycasts() { }

	// RVA: 0x1C51880 Offset: 0x1C51981 VA: 0x1C51880
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x1C518D0 Offset: 0x1C519D1 VA: 0x1C518D0
	public bool get_ignoreParentGroups() { }

	// RVA: 0x1C51920 Offset: 0x1C51A21 VA: 0x1C51920
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x1C51970 Offset: 0x1C51A71 VA: 0x1C51970 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1C519C0 Offset: 0x1C51AC1 VA: 0x1C519C0
	public void .ctor() { }
}

