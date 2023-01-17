// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42D00 Offset: 0x42E01 VA: 0x42D00
[ExecuteAlways] // RVA: 0x42D00 Offset: 0x42E01 VA: 0x42D00
[RequireComponent] // RVA: 0x42D00 Offset: 0x42E01 VA: 0x42D00
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4301
{
	// Fields
	[SerializeField] // RVA: 0x44D60 Offset: 0x44E61 VA: 0x44D60
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x18
	[SerializeField] // RVA: 0x44D70 Offset: 0x44E71 VA: 0x44D70
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x1C
	private RectTransform m_Rect; // 0x20
	private DrivenRectTransformTracker m_Tracker; // 0x28

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x1A43730 Offset: 0x1A43831 VA: 0x1A43730
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x1A43740 Offset: 0x1A43841 VA: 0x1A43740
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x1A438B0 Offset: 0x1A439B1 VA: 0x1A438B0
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x1A438C0 Offset: 0x1A439C1 VA: 0x1A438C0
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x1A439A0 Offset: 0x1A43AA1 VA: 0x1A439A0
	private RectTransform get_rectTransform() { }

	// RVA: 0x1A43A60 Offset: 0x1A43B61 VA: 0x1A43A60
	protected void .ctor() { }

	// RVA: 0x1A43A70 Offset: 0x1A43B71 VA: 0x1A43A70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A43B10 Offset: 0x1A43C11 VA: 0x1A43B10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A43BA0 Offset: 0x1A43CA1 VA: 0x1A43BA0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A43C30 Offset: 0x1A43D31 VA: 0x1A43C30
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x1A43D00 Offset: 0x1A43E01 VA: 0x1A43D00 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1A43D30 Offset: 0x1A43E31 VA: 0x1A43D30 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1A43820 Offset: 0x1A43921 VA: 0x1A43820
	protected void SetDirty() { }
}

