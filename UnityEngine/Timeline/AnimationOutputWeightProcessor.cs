// Namespace: UnityEngine.Timeline
internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 5626
{
	// Fields
	private AnimationPlayableOutput m_Output; // 0x10
	private readonly List<AnimationOutputWeightProcessor.WeightInfo> m_Mixers; // 0x20

	// Methods

	// RVA: 0x369DE10 Offset: 0x369DF11 VA: 0x369DE10
	public void .ctor(AnimationPlayableOutput output) { }

	// RVA: 0x369DEF0 Offset: 0x369DFF1 VA: 0x369DEF0
	private void FindMixers() { }

	// RVA: 0x369DFE0 Offset: 0x369E0E1 VA: 0x369DFE0
	private void FindMixers(Playable parent, int port, Playable node) { }

	// RVA: 0x369E260 Offset: 0x369E361 VA: 0x369E260 Slot: 4
	public void Evaluate() { }
}

