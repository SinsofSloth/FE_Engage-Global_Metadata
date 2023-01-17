// Namespace: 
[AddComponentMenu] // RVA: 0x271950 Offset: 0x271A51 VA: 0x271950
public class LightProbeGenerator : MonoBehaviour // TypeDefIndex: 7799
{
	// Fields
	public LightProbeGenerator.LightProbeArea[] LightProbeVolumes; // 0x18
	public LightProbeGenerator.LightProbePlacementType PlacementAlgorithm; // 0x20

	// Methods

	// RVA: 0x1F8D1B0 Offset: 0x1F8D2B1 VA: 0x1F8D1B0
	public void GenProbes() { }

	// RVA: 0x1F8D1C0 Offset: 0x1F8D2C1 VA: 0x1F8D1C0
	private List<Vector3> GetProbesForVolume_Grid(Bounds ProbeVolume, Vector3 Subdivisions) { }

	// RVA: 0x1F8D3E0 Offset: 0x1F8D4E1 VA: 0x1F8D3E0
	private List<Vector3> GetProbesForVolume_Random(Bounds ProbeVolume, int Count) { }

	// RVA: 0x1F8D560 Offset: 0x1F8D661 VA: 0x1F8D560
	public void .ctor() { }
}

