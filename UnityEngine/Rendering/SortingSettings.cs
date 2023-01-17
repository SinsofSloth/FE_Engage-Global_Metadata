// Namespace: UnityEngine.Rendering
public struct SortingSettings : IEquatable<SortingSettings> // TypeDefIndex: 3965
{
	// Fields
	private Matrix4x4 m_WorldToCameraMatrix; // 0x0
	private Vector3 m_CameraPosition; // 0x40
	private Vector3 m_CustomAxis; // 0x4C
	private SortingCriteria m_Criteria; // 0x58
	private DistanceMetric m_DistanceMetric; // 0x5C
	private Matrix4x4 m_PreviousVPMatrix; // 0x60
	private Matrix4x4 m_NonJitteredVPMatrix; // 0xA0

	// Properties
	public Vector3 customAxis { set; }
	public SortingCriteria criteria { get; set; }
	public DistanceMetric distanceMetric { set; }

	// Methods

	// RVA: 0x31EC750 Offset: 0x31EC851 VA: 0x31EC750
	public void .ctor(Camera camera) { }

	// RVA: 0x31EC800 Offset: 0x31EC901 VA: 0x31EC800
	public void set_customAxis(Vector3 value) { }

	// RVA: 0x31EC7F0 Offset: 0x31EC8F1 VA: 0x31EC7F0
	public SortingCriteria get_criteria() { }

	// RVA: 0x31EC810 Offset: 0x31EC911 VA: 0x31EC810
	public void set_criteria(SortingCriteria value) { }

	// RVA: 0x31EC820 Offset: 0x31EC921 VA: 0x31EC820
	public void set_distanceMetric(DistanceMetric value) { }

	// RVA: 0x31EC830 Offset: 0x31EC931 VA: 0x31EC830 Slot: 4
	public bool Equals(SortingSettings other) { }

	// RVA: 0x31EC980 Offset: 0x31ECA81 VA: 0x31EC980 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31ECA20 Offset: 0x31ECB21 VA: 0x31ECA20 Slot: 2
	public override int GetHashCode() { }
}

