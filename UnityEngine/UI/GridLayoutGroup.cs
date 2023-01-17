// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42DA0 Offset: 0x42EA1 VA: 0x42DA0
public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 4305
{
	// Fields
	[SerializeField] // RVA: 0x44D80 Offset: 0x44E81 VA: 0x44D80
	protected GridLayoutGroup.Corner m_StartCorner; // 0x58
	[SerializeField] // RVA: 0x44D90 Offset: 0x44E91 VA: 0x44D90
	protected GridLayoutGroup.Axis m_StartAxis; // 0x5C
	[SerializeField] // RVA: 0x44DA0 Offset: 0x44EA1 VA: 0x44DA0
	protected Vector2 m_CellSize; // 0x60
	[SerializeField] // RVA: 0x44DB0 Offset: 0x44EB1 VA: 0x44DB0
	protected Vector2 m_Spacing; // 0x68
	[SerializeField] // RVA: 0x44DC0 Offset: 0x44EC1 VA: 0x44DC0
	protected GridLayoutGroup.Constraint m_Constraint; // 0x70
	[SerializeField] // RVA: 0x44DD0 Offset: 0x44ED1 VA: 0x44DD0
	protected int m_ConstraintCount; // 0x74

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0x1A55BB0 Offset: 0x1A55CB1 VA: 0x1A55BB0
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x1A55BC0 Offset: 0x1A55CC1 VA: 0x1A55BC0
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x1A55C20 Offset: 0x1A55D21 VA: 0x1A55C20
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x1A55C30 Offset: 0x1A55D31 VA: 0x1A55C30
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x1A55C90 Offset: 0x1A55D91 VA: 0x1A55C90
	public Vector2 get_cellSize() { }

	// RVA: 0x1A55CA0 Offset: 0x1A55DA1 VA: 0x1A55CA0
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x1A55D10 Offset: 0x1A55E11 VA: 0x1A55D10
	public Vector2 get_spacing() { }

	// RVA: 0x1A55D20 Offset: 0x1A55E21 VA: 0x1A55D20
	public void set_spacing(Vector2 value) { }

	// RVA: 0x1A55D90 Offset: 0x1A55E91 VA: 0x1A55D90
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x1A55DA0 Offset: 0x1A55EA1 VA: 0x1A55DA0
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0x1A55E00 Offset: 0x1A55F01 VA: 0x1A55E00
	public int get_constraintCount() { }

	// RVA: 0x1A55E10 Offset: 0x1A55F11 VA: 0x1A55E10
	public void set_constraintCount(int value) { }

	// RVA: 0x1A55E90 Offset: 0x1A55F91 VA: 0x1A55E90
	protected void .ctor() { }

	// RVA: 0x1A55EE0 Offset: 0x1A55FE1 VA: 0x1A55EE0 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A56030 Offset: 0x1A56131 VA: 0x1A56030 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1A561B0 Offset: 0x1A562B1 VA: 0x1A561B0 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1A56790 Offset: 0x1A56891 VA: 0x1A56790 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x1A561C0 Offset: 0x1A562C1 VA: 0x1A561C0
	private void SetCellsAlongAxis(int axis) { }
}

