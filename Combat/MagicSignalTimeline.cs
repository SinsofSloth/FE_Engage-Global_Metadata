// Namespace: Combat
internal sealed class MagicSignalTimeline // TypeDefIndex: 8787
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284520 Offset: 0x284621 VA: 0x284520
	private MagicSignalTrack <Track>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x284530 Offset: 0x284631 VA: 0x284530
	private float <PrevTime>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284540 Offset: 0x284641 VA: 0x284540
	private float <Time>k__BackingField; // 0x1C

	// Properties
	public MagicSignalTrack Track { get; set; }
	public float PrevTime { get; set; }
	public float Time { get; set; }
	public bool IsEnd { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ACC20 Offset: 0x2ACD21 VA: 0x2ACC20
	// RVA: 0x1F97300 Offset: 0x1F97401 VA: 0x1F97300
	public MagicSignalTrack get_Track() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC30 Offset: 0x2ACD31 VA: 0x2ACC30
	// RVA: 0x1F97310 Offset: 0x1F97411 VA: 0x1F97310
	private void set_Track(MagicSignalTrack value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC40 Offset: 0x2ACD41 VA: 0x2ACC40
	// RVA: 0x1F97320 Offset: 0x1F97421 VA: 0x1F97320
	public float get_PrevTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC50 Offset: 0x2ACD51 VA: 0x2ACC50
	// RVA: 0x1F97330 Offset: 0x1F97431 VA: 0x1F97330
	private void set_PrevTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC60 Offset: 0x2ACD61 VA: 0x2ACC60
	// RVA: 0x1F97340 Offset: 0x1F97441 VA: 0x1F97340
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC70 Offset: 0x2ACD71 VA: 0x2ACC70
	// RVA: 0x1F97350 Offset: 0x1F97451 VA: 0x1F97350
	private void set_Time(float value) { }

	// RVA: 0x1F94BB0 Offset: 0x1F94CB1 VA: 0x1F94BB0
	public void .ctor(MagicSignalTrack track) { }

	// RVA: 0x1F95AC0 Offset: 0x1F95BC1 VA: 0x1F95AC0
	public bool get_IsEnd() { }

	// RVA: 0x1F94BF0 Offset: 0x1F94CF1 VA: 0x1F94BF0
	public void Start() { }

	// RVA: 0x1F95AB0 Offset: 0x1F95BB1 VA: 0x1F95AB0
	public void Stop() { }

	// RVA: 0x1F95C00 Offset: 0x1F95D01 VA: 0x1F95C00
	public void Advance(float dt) { }
}

