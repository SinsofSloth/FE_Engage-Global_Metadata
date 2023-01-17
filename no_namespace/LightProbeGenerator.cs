// Namespace: 
[Serializable]
public class LightProbeGenerator.LightProbeArea // TypeDefIndex: 7797
{
	// Fields
	public Bounds ProbeVolume; // 0x10
	public Vector3 Subdivisions; // 0x28
	public int RandomCount; // 0x34

	// Methods

	// RVA: 0x2231490 Offset: 0x2231591 VA: 0x2231490
	public void .ctor() { }
}

// Namespace: 
public enum LightProbeGenerator.LightProbePlacementType // TypeDefIndex: 7798
{
	// Fields
	public int value__; // 0x0
	public const LightProbeGenerator.LightProbePlacementType Grid = 0;
	public const LightProbeGenerator.LightProbePlacementType Random = 1;
}

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

