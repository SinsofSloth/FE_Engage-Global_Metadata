// Namespace: UnityEngine.UI
[RequireComponent] // RVA: 0x42ED0 Offset: 0x42FD1 VA: 0x42ED0
[ExecuteAlways] // RVA: 0x42ED0 Offset: 0x42FD1 VA: 0x42ED0
[DisallowMultipleComponent] // RVA: 0x42ED0 Offset: 0x42FD1 VA: 0x42ED0
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4315
{
	// Fields
	[SerializeField] // RVA: 0x44EE0 Offset: 0x44FE1 VA: 0x44EE0
	protected RectOffset m_Padding; // 0x18
	[SerializeField] // RVA: 0x44EF0 Offset: 0x44FF1 VA: 0x44EF0
	protected TextAnchor m_ChildAlignment; // 0x20
	private RectTransform m_Rect; // 0x28
	protected DrivenRectTransformTracker m_Tracker; // 0x30
	private Vector2 m_TotalMinSize; // 0x34
	private Vector2 m_TotalPreferredSize; // 0x3C
	private Vector2 m_TotalFlexibleSize; // 0x44
	private List<RectTransform> m_RectChildren; // 0x50

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x1BF0A50 Offset: 0x1BF0B51 VA: 0x1BF0A50
	public RectOffset get_padding() { }

	// RVA: 0x1BF0A60 Offset: 0x1BF0B61 VA: 0x1BF0A60
	public void set_padding(RectOffset value) { }

	// RVA: 0x1BF0AC0 Offset: 0x1BF0BC1 VA: 0x1BF0AC0
	public TextAnchor get_childAlignment() { }

	// RVA: 0x1BF0AD0 Offset: 0x1BF0BD1 VA: 0x1BF0AD0
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x1BF0B30 Offset: 0x1BF0C31 VA: 0x1BF0B30
	protected RectTransform get_rectTransform() { }

	// RVA: 0x1BF0BF0 Offset: 0x1BF0CF1 VA: 0x1BF0BF0
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x1BF0C00 Offset: 0x1BF0D01 VA: 0x1BF0C00 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x1BF0F70 Offset: 0x1BF1071 VA: 0x1BF0F70 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x1BF0F90 Offset: 0x1BF1091 VA: 0x1BF0F90 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x1BF0FB0 Offset: 0x1BF10B1 VA: 0x1BF0FB0 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1BF0FD0 Offset: 0x1BF10D1 VA: 0x1BF0FD0 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1BF0FE0 Offset: 0x1BF10E1 VA: 0x1BF0FE0 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x1BF0FF0 Offset: 0x1BF10F1 VA: 0x1BF0FF0 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1BF1000 Offset: 0x1BF1101 VA: 0x1BF1000 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x1BF1010 Offset: 0x1BF1111 VA: 0x1BF1010
	protected void .ctor() { }

	// RVA: 0x1BF1150 Offset: 0x1BF1251 VA: 0x1BF1150 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1BF12C0 Offset: 0x1BF13C1 VA: 0x1BF12C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1BF1350 Offset: 0x1BF1451 VA: 0x1BF1350 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1BF0F80 Offset: 0x1BF1081 VA: 0x1BF0F80
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x1BF0FA0 Offset: 0x1BF10A1 VA: 0x1BF0FA0
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x1BF0FC0 Offset: 0x1BF10C1 VA: 0x1BF0FC0
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x1BF1360 Offset: 0x1BF1461 VA: 0x1BF1360
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x1BF1460 Offset: 0x1BF1561 VA: 0x1BF1460
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x1BF14A0 Offset: 0x1BF15A1 VA: 0x1BF14A0
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x1BF1500 Offset: 0x1BF1601 VA: 0x1BF1500
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x1BF15C0 Offset: 0x1BF16C1 VA: 0x1BF15C0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x1BF1760 Offset: 0x1BF1861 VA: 0x1BF1760
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x1BF1830 Offset: 0x1BF1931 VA: 0x1BF1830
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x1BF19E0 Offset: 0x1BF1AE1 VA: 0x1BF19E0
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x1BF1B30 Offset: 0x1BF1C31 VA: 0x1BF1B30 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1BF1B70 Offset: 0x1BF1C71 VA: 0x1BF1B70 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295AD20 Offset: 0x295AE21 VA: 0x295AD20
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x295ADA0 Offset: 0x295AEA1 VA: 0x295ADA0
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x295AE20 Offset: 0x295AF21 VA: 0x295AE20
	|-LayoutGroup.SetProperty<Int32Enum>
	|-LayoutGroup.SetProperty<TextAnchor>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Axis>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Constraint>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Corner>
	|
	|-RVA: 0x295AEE0 Offset: 0x295AFE1 VA: 0x295AEE0
	|-LayoutGroup.SetProperty<object>
	|-LayoutGroup.SetProperty<RectOffset>
	|
	|-RVA: 0x295AF60 Offset: 0x295B061 VA: 0x295AF60
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x295AFF0 Offset: 0x295B0F1 VA: 0x295AFF0
	|-LayoutGroup.SetProperty<Vector2>
	*/

	// RVA: 0x1BF1180 Offset: 0x1BF1281 VA: 0x1BF1180
	protected void SetDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x45F50 Offset: 0x46051 VA: 0x45F50
	// RVA: 0x1BF1B80 Offset: 0x1BF1C81 VA: 0x1BF1B80
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }
}

