// Namespace: UnityEngine.VFX
[RequiredByNativeCodeAttribute] // RVA: 0x6A330 Offset: 0x6A431 VA: 0x6A330
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 7576
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: 0x1C6BCE0 Offset: 0x1C6BDE1 VA: 0x1C6BCE0
	protected void .ctor() { }
}

