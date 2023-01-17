// Namespace: Combat
public class AniBodyRide // TypeDefIndex: 8720
{
	// Fields
	private bool initialized; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x283F40 Offset: 0x284041 VA: 0x283F40
	private GameObject <gameObject>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x283F50 Offset: 0x284051 VA: 0x283F50
	private Animator <animator>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x283F60 Offset: 0x284061 VA: 0x283F60
	private AnimationClip[] <clips>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x283F70 Offset: 0x284071 VA: 0x283F70
	private string[] <clipNames>k__BackingField; // 0x30
	public int playingIndex; // 0x38

	// Properties
	public GameObject gameObject { get; set; }
	public Animator animator { get; set; }
	public AnimationClip[] clips { get; set; }
	public string[] clipNames { get; set; }
	public AnimationClip Playing { get; }
	public float PlayingClipLength { get; }
	public bool IsValid { get; }
	public bool IsPlaying { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AC4D0 Offset: 0x2AC5D1 VA: 0x2AC4D0
	// RVA: 0x20F2440 Offset: 0x20F2541 VA: 0x20F2440
	public GameObject get_gameObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC4E0 Offset: 0x2AC5E1 VA: 0x2AC4E0
	// RVA: 0x20F2450 Offset: 0x20F2551 VA: 0x20F2450
	public void set_gameObject(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC4F0 Offset: 0x2AC5F1 VA: 0x2AC4F0
	// RVA: 0x20F2460 Offset: 0x20F2561 VA: 0x20F2460
	public Animator get_animator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC500 Offset: 0x2AC601 VA: 0x2AC500
	// RVA: 0x20F2470 Offset: 0x20F2571 VA: 0x20F2470
	public void set_animator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC510 Offset: 0x2AC611 VA: 0x2AC510
	// RVA: 0x20F2480 Offset: 0x20F2581 VA: 0x20F2480
	public AnimationClip[] get_clips() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC520 Offset: 0x2AC621 VA: 0x2AC520
	// RVA: 0x20F2490 Offset: 0x20F2591 VA: 0x20F2490
	public void set_clips(AnimationClip[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC530 Offset: 0x2AC631 VA: 0x2AC530
	// RVA: 0x20F24A0 Offset: 0x20F25A1 VA: 0x20F24A0
	public string[] get_clipNames() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC540 Offset: 0x2AC641 VA: 0x2AC540
	// RVA: 0x20F24B0 Offset: 0x20F25B1 VA: 0x20F24B0
	public void set_clipNames(string[] value) { }

	// RVA: 0x20F24C0 Offset: 0x20F25C1 VA: 0x20F24C0
	public AnimationClip get_Playing() { }

	// RVA: 0x20F2510 Offset: 0x20F2611 VA: 0x20F2510
	public float get_PlayingClipLength() { }

	// RVA: 0x20F2650 Offset: 0x20F2751 VA: 0x20F2650
	public bool get_IsValid() { }

	// RVA: 0x20F2590 Offset: 0x20F2691 VA: 0x20F2590
	public bool get_IsPlaying() { }

	// RVA: 0x20F2660 Offset: 0x20F2761 VA: 0x20F2660
	public void .ctor(GameObject go) { }

	// RVA: 0x20F2A40 Offset: 0x20F2B41 VA: 0x20F2A40
	public void Evaluate(float time) { }

	// RVA: 0x20F2AC0 Offset: 0x20F2BC1 VA: 0x20F2AC0
	public void Play(int index) { }

	// RVA: 0x20F2AD0 Offset: 0x20F2BD1 VA: 0x20F2AD0
	public int FindIndex(string name) { }
}

