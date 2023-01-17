// Namespace: UnityEngine.Experimental.Rendering.Universal
internal interface ILight2DCullResult // TypeDefIndex: 5473
{
	// Properties
	public abstract List<Light2D> visibleLights { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract List<Light2D> get_visibleLights();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract LightStats GetLightStatsByLayer(int layer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsSceneLit();
}

