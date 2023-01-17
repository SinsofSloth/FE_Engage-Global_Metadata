// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x34B20 Offset: 0x34C21 VA: 0x34B20
[DefaultMemberAttribute] // RVA: 0x34B20 Offset: 0x34C21 VA: 0x34B20
[UsedByNativeCodeAttribute] // RVA: 0x34B20 Offset: 0x34C21 VA: 0x34B20
[NativeHeaderAttribute] // RVA: 0x34B20 Offset: 0x34C21 VA: 0x34B20
public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4102
{
	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public AnimationClip Item { get; set; }
	public AnimationClip Item { get; set; }
	public int overridesCount { get; }
	[ObsoleteAttribute] // RVA: 0x39CC0 Offset: 0x39DC1 VA: 0x39CC0
	public AnimationClipPair[] clips { get; set; }

	// Methods

	// RVA: 0x3EDBF50 Offset: 0x3EDC051 VA: 0x3EDBF50
	public void .ctor() { }

	// RVA: 0x3EDC0C0 Offset: 0x3EDC1C1 VA: 0x3EDC0C0
	public void .ctor(RuntimeAnimatorController controller) { }

	[FreeFunctionAttribute] // RVA: 0x380A0 Offset: 0x381A1 VA: 0x380A0
	// RVA: 0x3EDC070 Offset: 0x3EDC171 VA: 0x3EDC070
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	[NativeMethodAttribute] // RVA: 0x380E0 Offset: 0x381E1 VA: 0x380E0
	// RVA: 0x3EDC170 Offset: 0x3EDC271 VA: 0x3EDC170
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	[NativeMethodAttribute] // RVA: 0x38120 Offset: 0x38221 VA: 0x38120
	// RVA: 0x3EDC1C0 Offset: 0x3EDC2C1 VA: 0x3EDC1C0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x3EDC210 Offset: 0x3EDC311 VA: 0x3EDC210
	public AnimationClip get_Item(string name) { }

	// RVA: 0x3EDC2D0 Offset: 0x3EDC3D1 VA: 0x3EDC2D0
	public void set_Item(string name, AnimationClip value) { }

	[NativeMethodAttribute] // RVA: 0x38160 Offset: 0x38261 VA: 0x38160
	// RVA: 0x3EDC270 Offset: 0x3EDC371 VA: 0x3EDC270
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[NativeMethodAttribute] // RVA: 0x381A0 Offset: 0x382A1 VA: 0x381A0
	// RVA: 0x3EDC330 Offset: 0x3EDC431 VA: 0x3EDC330
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	// RVA: 0x3EDC390 Offset: 0x3EDC491 VA: 0x3EDC390
	public AnimationClip get_Item(AnimationClip clip) { }

	// RVA: 0x3EDC450 Offset: 0x3EDC551 VA: 0x3EDC450
	public void set_Item(AnimationClip clip, AnimationClip value) { }

	// RVA: 0x3EDC3F0 Offset: 0x3EDC4F1 VA: 0x3EDC3F0
	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	// RVA: 0x3EDC4B0 Offset: 0x3EDC5B1 VA: 0x3EDC4B0
	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x3EDC520 Offset: 0x3EDC621 VA: 0x3EDC520
	private void SendNotification() { }

	// RVA: 0x3EDC570 Offset: 0x3EDC671 VA: 0x3EDC570
	private AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x3EDC5C0 Offset: 0x3EDC6C1 VA: 0x3EDC5C0
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	[NativeMethodAttribute] // RVA: 0x381E0 Offset: 0x382E1 VA: 0x381E0
	// RVA: 0x3EDC610 Offset: 0x3EDC711 VA: 0x3EDC610
	public int get_overridesCount() { }

	// RVA: 0x3EDC660 Offset: 0x3EDC761 VA: 0x3EDC660
	public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides) { }

	// RVA: 0x3EDC870 Offset: 0x3EDC971 VA: 0x3EDC870
	public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides) { }

	// RVA: 0x3EDCAE0 Offset: 0x3EDCBE1 VA: 0x3EDCAE0
	public AnimationClipPair[] get_clips() { }

	// RVA: 0x3EDCCC0 Offset: 0x3EDCDC1 VA: 0x3EDCCC0
	public void set_clips(AnimationClipPair[] value) { }

	[NativeConditionalAttribute] // RVA: 0x38220 Offset: 0x38321 VA: 0x38220
	// RVA: 0x3EDCDA0 Offset: 0x3EDCEA1 VA: 0x3EDCDA0
	internal void PerformOverrideClipListCleanup() { }

	[NativeConditionalAttribute] // RVA: 0x38260 Offset: 0x38361 VA: 0x38260
	[RequiredByNativeCodeAttribute] // RVA: 0x38260 Offset: 0x38361 VA: 0x38260
	// RVA: 0x3EDCDF0 Offset: 0x3EDCEF1 VA: 0x3EDCDF0
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }
}

