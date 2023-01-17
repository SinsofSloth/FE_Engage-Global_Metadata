// Namespace: UnityEngine.Rendering.LookDev
public interface IDataProvider // TypeDefIndex: 4693
{
	// Properties
	public abstract IEnumerable<string> supportedDebugModes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FirstInitScene(StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateSky(Camera camera, Sky sky, StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<string> get_supportedDebugModes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateDebugMode(int debugIndex);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GetShadowMask(ref RenderTexture output, StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBeginRendering(StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnEndRendering(StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Cleanup(StageRuntimeInterface SRI);
}

