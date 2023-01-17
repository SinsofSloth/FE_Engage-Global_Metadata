// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0x441200 Offset: 0x441301 VA: 0x441200
[Serializable]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 3988
{
	// Methods

	// RVA: 0x3490400 Offset: 0x3490501 VA: 0x3490400
	public void .ctor() { }

	// RVA: 0x3490410 Offset: 0x3490511 VA: 0x3490410 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x3490420 Offset: 0x3490521 VA: 0x3490420 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x3490430 Offset: 0x3490531 VA: 0x3490430 Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x3490440 Offset: 0x3490541 VA: 0x3490440 Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x3490450 Offset: 0x3490551 VA: 0x3490450 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x3490460 Offset: 0x3490561 VA: 0x3490460 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x3490470 Offset: 0x3490571 VA: 0x3490470 Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x3490480 Offset: 0x3490581 VA: 0x3490480 Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x3490490 Offset: 0x3490591 VA: 0x3490490 Slot: 21
	public virtual object Clone() { }
}

