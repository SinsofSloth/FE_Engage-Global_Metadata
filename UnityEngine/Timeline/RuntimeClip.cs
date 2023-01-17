// Namespace: UnityEngine.Timeline
internal class RuntimeClip : RuntimeClipBase // TypeDefIndex: 5660
{
	// Fields
	private TimelineClip m_Clip; // 0x18
	private Playable m_Playable; // 0x20
	private Playable m_ParentMixer; // 0x30

	// Properties
	public override double start { get; }
	public override double duration { get; }
	public TimelineClip clip { get; }
	public Playable mixer { get; }
	public Playable playable { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x36A7D20 Offset: 0x36A7E21 VA: 0x36A7D20 Slot: 11
	public override double get_start() { }

	// RVA: 0x36A7D60 Offset: 0x36A7E61 VA: 0x36A7D60 Slot: 12
	public override double get_duration() { }

	// RVA: 0x36A1060 Offset: 0x36A1161 VA: 0x36A1060
	public void .ctor(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x36A7E70 Offset: 0x36A7F71 VA: 0x36A7E70
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x36A7F10 Offset: 0x36A8011 VA: 0x36A7F10
	public TimelineClip get_clip() { }

	// RVA: 0x36A7F20 Offset: 0x36A8021 VA: 0x36A7F20
	public Playable get_mixer() { }

	// RVA: 0x36A7F30 Offset: 0x36A8031 VA: 0x36A7F30
	public Playable get_playable() { }

	// RVA: 0x36A7F40 Offset: 0x36A8041 VA: 0x36A7F40 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x36A8100 Offset: 0x36A8201 VA: 0x36A8100
	public void SetTime(double time) { }

	// RVA: 0x36A8170 Offset: 0x36A8271 VA: 0x36A8170
	public void SetDuration(double duration) { }

	// RVA: 0x36A81E0 Offset: 0x36A82E1 VA: 0x36A81E0 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x36A8800 Offset: 0x36A8901 VA: 0x36A8800 Slot: 10
	public override void Reset() { }
}

