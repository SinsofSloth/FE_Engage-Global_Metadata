// Namespace: App
public class RingCleaningClothAnimationEvent : MonoBehaviour // TypeDefIndex: 11751
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x298FC0 Offset: 0x2990C1 VA: 0x298FC0
	private static bool <IsPlayingAnim>k__BackingField; // 0x0
	private static float s_AnimTime; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x298FD0 Offset: 0x2990D1 VA: 0x298FD0
	private Action <CleaningLoopStartAction>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x298FE0 Offset: 0x2990E1 VA: 0x298FE0
	private Action <StrongCleaningLoopStartAction>k__BackingField; // 0x20
	private Animator m_Animator; // 0x28

	// Properties
	public static bool IsPlayingAnim { get; set; }
	public Action CleaningLoopStartAction { get; set; }
	public Action StrongCleaningLoopStartAction { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C6540 Offset: 0x2C6641 VA: 0x2C6540
	// RVA: 0x2678890 Offset: 0x2678991 VA: 0x2678890
	public static bool get_IsPlayingAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6550 Offset: 0x2C6651 VA: 0x2C6550
	// RVA: 0x2678900 Offset: 0x2678A01 VA: 0x2678900
	private static void set_IsPlayingAnim(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6560 Offset: 0x2C6661 VA: 0x2C6560
	// RVA: 0x2678980 Offset: 0x2678A81 VA: 0x2678980
	public Action get_CleaningLoopStartAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6570 Offset: 0x2C6671 VA: 0x2C6570
	// RVA: 0x2678990 Offset: 0x2678A91 VA: 0x2678990
	public void set_CleaningLoopStartAction(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6580 Offset: 0x2C6681 VA: 0x2C6580
	// RVA: 0x26789A0 Offset: 0x2678AA1 VA: 0x26789A0
	public Action get_StrongCleaningLoopStartAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6590 Offset: 0x2C6691 VA: 0x2C6590
	// RVA: 0x26789B0 Offset: 0x2678AB1 VA: 0x26789B0
	public void set_StrongCleaningLoopStartAction(Action value) { }

	// RVA: 0x26789C0 Offset: 0x2678AC1 VA: 0x26789C0
	private void Start() { }

	// RVA: 0x2678A30 Offset: 0x2678B31 VA: 0x2678A30
	private void CleaningStartEvent() { }

	// RVA: 0x2678A50 Offset: 0x2678B51 VA: 0x2678A50
	private void CleaningEndEvent() { }

	// RVA: 0x2678A60 Offset: 0x2678B61 VA: 0x2678A60
	private void StrongCleaningStartEvent() { }

	// RVA: 0x2678A80 Offset: 0x2678B81 VA: 0x2678A80
	private void StrongCleaningEndEvent() { }

	// RVA: 0x2678A90 Offset: 0x2678B91 VA: 0x2678A90
	public static void SetIsPlayingAnim(bool value) { }

	// RVA: 0x2678B60 Offset: 0x2678C61 VA: 0x2678B60
	public void .ctor() { }

	// RVA: 0x2678B70 Offset: 0x2678C71 VA: 0x2678B70
	private static void .cctor() { }
}

