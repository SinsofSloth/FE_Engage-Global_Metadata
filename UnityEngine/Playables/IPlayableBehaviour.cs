// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour // TypeDefIndex: 3982
{
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x454530 Offset: 0x454631 VA: 0x454530
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x454540 Offset: 0x454641 VA: 0x454540
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x454550 Offset: 0x454651 VA: 0x454550
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x454560 Offset: 0x454661 VA: 0x454560
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x454570 Offset: 0x454671 VA: 0x454570
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x454580 Offset: 0x454681 VA: 0x454580
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x454590 Offset: 0x454691 VA: 0x454590
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x4545A0 Offset: 0x4546A1 VA: 0x4545A0
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);
}

