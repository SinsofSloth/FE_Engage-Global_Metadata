// Namespace: UnityEngine.UI
[ExecuteAlways] // RVA: 0x43610 Offset: 0x43711 VA: 0x43610
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 4369
{
	// Fields
	private Graphic m_Graphic; // 0x18

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x1A3F400 Offset: 0x1A3F501 VA: 0x1A3F400
	protected Graphic get_graphic() { }

	// RVA: 0x1A3F4C0 Offset: 0x1A3F5C1 VA: 0x1A3F4C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A3F580 Offset: 0x1A3F681 VA: 0x1A3F580 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A3F630 Offset: 0x1A3F731 VA: 0x1A3F630 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A3F6E0 Offset: 0x1A3F7E1 VA: 0x1A3F6E0 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x1A3F860 Offset: 0x1A3F961 VA: 0x1A3F860
	protected void .ctor() { }
}

