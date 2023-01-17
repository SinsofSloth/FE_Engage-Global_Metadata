// Namespace: App
public class MapPanelGimmick : MapPanelBase<MapPanelGimmick> // TypeDefIndex: 9063
{
	// Fields
	private InterpolatorFloat m_Alpha; // 0x40
	[SpaceAttribute] // RVA: 0x286A70 Offset: 0x286B71 VA: 0x286A70
	[HeaderAttribute] // RVA: 0x286A70 Offset: 0x286B71 VA: 0x286A70
	[SerializeField] // RVA: 0x286A70 Offset: 0x286B71 VA: 0x286A70
	private Material m_GimmickImage; // 0x48
	[SpaceAttribute] // RVA: 0x286AD0 Offset: 0x286BD1 VA: 0x286AD0
	[HeaderAttribute] // RVA: 0x286AD0 Offset: 0x286BD1 VA: 0x286AD0
	[SerializeField] // RVA: 0x286AD0 Offset: 0x286BD1 VA: 0x286AD0
	private Color m_GimmickColor; // 0x50
	private bool m_IsUpdate; // 0x60
	private int previousCount; // 0x64

	// Properties
	public override int SubMeshCount { get; }

	// Methods

	// RVA: 0x2782D90 Offset: 0x2782E91 VA: 0x2782D90 Slot: 6
	public override int get_SubMeshCount() { }

	// RVA: 0x2782DA0 Offset: 0x2782EA1 VA: 0x2782DA0
	private void Start() { }

	// RVA: 0x2782DE0 Offset: 0x2782EE1 VA: 0x2782DE0
	private void Update() { }

	// RVA: 0x2782F30 Offset: 0x2783031 VA: 0x2782F30 Slot: 5
	protected override Material[] GetSourceMaterials() { }

	// RVA: 0x2782ED0 Offset: 0x2782FD1 VA: 0x2782ED0
	private void SetVertex() { }

	// RVA: 0x2782FE0 Offset: 0x27830E1 VA: 0x2782FE0
	private void NeedUpdate() { }

	// RVA: 0x27830B0 Offset: 0x27831B1 VA: 0x27830B0
	private void SetMesh() { }

	// RVA: 0x2783590 Offset: 0x2783691 VA: 0x2783590
	public static void UpdateRequest() { }

	// RVA: 0x2783660 Offset: 0x2783761 VA: 0x2783660
	public void .ctor() { }
}

