// Namespace: 
private enum MapPanelImpact.MeshIndex // TypeDefIndex: 7634
{
	// Fields
	public int value__; // 0x0
	public const MapPanelImpact.MeshIndex Land = 0;
	public const MapPanelImpact.MeshIndex Num = 1;
}

// Namespace: 
public class MapPanelImpact : MapPanelBase<MapPanelImpact> // TypeDefIndex: 7635
{
	// Fields
	private InterpolatorFloat m_Alpha; // 0x40
	[SerializeField] // RVA: 0x27B540 Offset: 0x27B641 VA: 0x27B540
	[HeaderAttribute] // RVA: 0x27B540 Offset: 0x27B641 VA: 0x27B540
	[SpaceAttribute] // RVA: 0x27B540 Offset: 0x27B641 VA: 0x27B540
	private Material m_LandImage; // 0x48
	[HeaderAttribute] // RVA: 0x27B5A0 Offset: 0x27B6A1 VA: 0x27B5A0
	[SpaceAttribute] // RVA: 0x27B5A0 Offset: 0x27B6A1 VA: 0x27B5A0
	[SerializeField] // RVA: 0x27B5A0 Offset: 0x27B6A1 VA: 0x27B5A0
	private Color m_FriendlyLandColor; // 0x50
	[SerializeField] // RVA: 0x27B600 Offset: 0x27B701 VA: 0x27B600
	private Color m_HostileLandColor; // 0x60
	private MapImageCoreBit m_FriendlyLandImage; // 0x70
	private MapImageCoreBit m_HostileLandImage; // 0x78
	private Unit m_CurrentUnit; // 0x80
	private MapSkill.UnitFunc m_LandImageFunc; // 0x88
	private MapFor.PosFunction m_LandCellFunc; // 0x90
	private MapPanelBase.ImageGetFunction<MapPanelImpact> m_FriendlyLandImageGetter; // 0x98
	private MapPanelBase.ImageGetFunction<MapPanelImpact> m_HostileLandImageGetter; // 0xA0

	// Properties
	public override int SubMeshCount { get; }

	// Methods

	// RVA: 0x2783F60 Offset: 0x2784061 VA: 0x2783F60 Slot: 6
	public override int get_SubMeshCount() { }

	// RVA: 0x2783F70 Offset: 0x2784071 VA: 0x2783F70
	private void Start() { }

	// RVA: 0x2784150 Offset: 0x2784251 VA: 0x2784150
	private void Update() { }

	// RVA: 0x2784270 Offset: 0x2784371 VA: 0x2784270 Slot: 5
	protected override Material[] GetSourceMaterials() { }

	// RVA: 0x2784230 Offset: 0x2784331 VA: 0x2784230
	private void SetVertex() { }

	// RVA: 0x27846F0 Offset: 0x27847F1 VA: 0x27846F0
	private void SetLandImage(int x, int z, Unit target) { }

	// RVA: 0x27847F0 Offset: 0x27848F1 VA: 0x27847F0
	private void AddLandCell(int x, int z) { }

	// RVA: 0x2784320 Offset: 0x2784421 VA: 0x2784320
	private void SetMesh() { }

	// RVA: 0x2784A20 Offset: 0x2784B21 VA: 0x2784A20
	public void .ctor() { }
}

