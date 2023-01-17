// Namespace: App
[ExecuteAlways] // RVA: 0x2793B0 Offset: 0x2794B1 VA: 0x2793B0
public abstract class CanvasManager : MonoBehaviour // TypeDefIndex: 13985
{
	// Fields
	[HideInInspector] // RVA: 0x29CE80 Offset: 0x29CF81 VA: 0x29CE80
	public Vector3 m_LocalPosition; // 0x18
	[HideInInspector] // RVA: 0x29CE90 Offset: 0x29CF91 VA: 0x29CE90
	public Quaternion m_LocalRotation; // 0x24
	[HideInInspector] // RVA: 0x29CEA0 Offset: 0x29CFA1 VA: 0x29CEA0
	public Vector3 m_LocalScale; // 0x34
	[HideInInspector] // RVA: 0x29CEB0 Offset: 0x29CFB1 VA: 0x29CEB0
	public Vector2 m_AnchorMin; // 0x40
	[HideInInspector] // RVA: 0x29CEC0 Offset: 0x29CFC1 VA: 0x29CEC0
	public Vector2 m_AnchorMax; // 0x48
	[HideInInspector] // RVA: 0x29CED0 Offset: 0x29CFD1 VA: 0x29CED0
	public Vector2 m_AnchoredPosition; // 0x50
	[HideInInspector] // RVA: 0x29CEE0 Offset: 0x29CFE1 VA: 0x29CEE0
	public Vector2 m_SizeDelta; // 0x58
	[HideInInspector] // RVA: 0x29CEF0 Offset: 0x29CFF1 VA: 0x29CEF0
	public Vector2 m_Pivot; // 0x60
	[TooltipAttribute] // RVA: 0x29CF00 Offset: 0x29D001 VA: 0x29CF00
	public bool m_SelfDestroy; // 0x68

	// Methods

	// RVA: 0x29A7530 Offset: 0x29A7631 VA: 0x29A7530
	private static void SetTargetDisplay(Canvas canvas, int index) { }

	// RVA: 0x29A7580 Offset: 0x29A7681 VA: 0x29A7580
	private static void SetTargetDisplay(Canvas canvas, bool enabled) { }

	// RVA: 0x29A76E0 Offset: 0x29A77E1 VA: 0x29A76E0
	private static bool TryGetRootCanvas(Transform transform, out Canvas canvas) { }

	// RVA: 0x29A7800 Offset: 0x29A7901 VA: 0x29A7800
	public bool IsVisible() { }

	// RVA: 0x29A7940 Offset: 0x29A7A41 VA: 0x29A7940
	public void SetVisible(bool enabled) { }

	// RVA: 0x29A7BA0 Offset: 0x29A7CA1 VA: 0x29A7BA0
	public void Show() { }

	// RVA: 0x29A7DE0 Offset: 0x29A7EE1 VA: 0x29A7DE0
	public void Hide() { }

	// RVA: 0x29A8020 Offset: 0x29A8121 VA: 0x29A8020
	public static void SetVisible(GameObject go, bool enabled) { }

	// RVA: 0x29A82A0 Offset: 0x29A83A1 VA: 0x29A82A0
	public static bool IsVisible(GameObject go) { }

	// RVA: 0x29A8400 Offset: 0x29A8501 VA: 0x29A8400
	public static void Show(GameObject go) { }

	// RVA: 0x29A8660 Offset: 0x29A8761 VA: 0x29A8660
	public static void Hide(GameObject go) { }

	// RVA: 0x29A88C0 Offset: 0x29A89C1 VA: 0x29A88C0
	private void Start() { }

	// RVA: 0x29A8A30 Offset: 0x29A8B31 VA: 0x29A8A30
	public void OnTransformChildrenChanged() { }

	// RVA: 0x29A8B60 Offset: 0x29A8C61 VA: 0x29A8B60
	protected void .ctor() { }
}

