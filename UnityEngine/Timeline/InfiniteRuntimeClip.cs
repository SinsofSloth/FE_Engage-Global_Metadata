// Namespace: UnityEngine.Timeline
internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 5655
{
	// Fields
	private Playable m_Playable; // 0x18
	private static readonly long kIntervalEnd; // 0x0

	// Properties
	public override long intervalStart { get; }
	public override long intervalEnd { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x36A3040 Offset: 0x36A3141 VA: 0x36A3040
	public void .ctor(Playable playable) { }

	// RVA: 0x36A5720 Offset: 0x36A5821 VA: 0x36A5720 Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x36A5730 Offset: 0x36A5831 VA: 0x36A5730 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x36A57A0 Offset: 0x36A58A1 VA: 0x36A57A0 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x36A5830 Offset: 0x36A5931 VA: 0x36A5830 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x36A58A0 Offset: 0x36A59A1 VA: 0x36A58A0
	private static void .cctor() { }
}

