// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42BA0 Offset: 0x42CA1 VA: 0x42BA0
[ExecuteAlways] // RVA: 0x42BA0 Offset: 0x42CA1 VA: 0x42BA0
[RequireComponent] // RVA: 0x42BA0 Offset: 0x42CA1 VA: 0x42BA0
[DisallowMultipleComponent] // RVA: 0x42BA0 Offset: 0x42CA1 VA: 0x42BA0
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4295
{
	// Fields
	[SerializeField] // RVA: 0x449F0 Offset: 0x44AF1 VA: 0x449F0
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x18
	[SerializeField] // RVA: 0x44A00 Offset: 0x44B01 VA: 0x44A00
	private float m_AspectRatio; // 0x1C
	private RectTransform m_Rect; // 0x20
	private bool m_DelayedSetDirty; // 0x28
	private bool m_DoesParentExist; // 0x29
	private DrivenRectTransformTracker m_Tracker; // 0x2A

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x1A3D210 Offset: 0x1A3D311 VA: 0x1A3D210
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x1A3D220 Offset: 0x1A3D321 VA: 0x1A3D220
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x1A3D2B0 Offset: 0x1A3D3B1 VA: 0x1A3D2B0
	public float get_aspectRatio() { }

	// RVA: 0x1A3D2C0 Offset: 0x1A3D3C1 VA: 0x1A3D2C0
	public void set_aspectRatio(float value) { }

	// RVA: 0x1A3D350 Offset: 0x1A3D451 VA: 0x1A3D350
	private RectTransform get_rectTransform() { }

	// RVA: 0x1A3D410 Offset: 0x1A3D511 VA: 0x1A3D410
	protected void .ctor() { }

	// RVA: 0x1A3D420 Offset: 0x1A3D521 VA: 0x1A3D420 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A3D4C0 Offset: 0x1A3D5C1 VA: 0x1A3D4C0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1A3D640 Offset: 0x1A3D741 VA: 0x1A3D640 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A3D6D0 Offset: 0x1A3D7D1 VA: 0x1A3D6D0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A3D770 Offset: 0x1A3D871 VA: 0x1A3D770 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x1A3D790 Offset: 0x1A3D891 VA: 0x1A3D790 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A3D7A0 Offset: 0x1A3D8A1 VA: 0x1A3D7A0
	private void UpdateRect() { }

	// RVA: 0x1A3DBE0 Offset: 0x1A3DCE1 VA: 0x1A3DBE0
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x1A3DAD0 Offset: 0x1A3DBD1 VA: 0x1A3DAD0
	private Vector2 GetParentSize() { }

	// RVA: 0x1A3DC90 Offset: 0x1A3DD91 VA: 0x1A3DC90 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1A3DCA0 Offset: 0x1A3DDA1 VA: 0x1A3DCA0 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1A3D2A0 Offset: 0x1A3D3A1 VA: 0x1A3D2A0
	protected void SetDirty() { }

	// RVA: 0x1A3D520 Offset: 0x1A3D621 VA: 0x1A3D520
	public bool IsComponentValidOnObject() { }

	// RVA: 0x1A3D610 Offset: 0x1A3D711 VA: 0x1A3D610
	public bool IsAspectModeValid() { }

	// RVA: 0x1A3DCB0 Offset: 0x1A3DDB1 VA: 0x1A3DCB0
	private bool DoesParentExists() { }
}

