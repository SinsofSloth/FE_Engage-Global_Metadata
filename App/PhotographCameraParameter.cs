// Namespace: App
public class PhotographCameraParameter : MonoBehaviour // TypeDefIndex: 11467
{
	// Fields
	[SerializeField] // RVA: 0x2984B0 Offset: 0x2985B1 VA: 0x2984B0
	[HeaderAttribute] // RVA: 0x2984B0 Offset: 0x2985B1 VA: 0x2984B0
	private float m_LimitZoomDistance; // 0x18
	[SerializeField] // RVA: 0x298500 Offset: 0x298601 VA: 0x298500
	[HeaderAttribute] // RVA: 0x298500 Offset: 0x298601 VA: 0x298500
	private float m_LimitMoveHorizontal; // 0x1C
	[HeaderAttribute] // RVA: 0x298550 Offset: 0x298651 VA: 0x298550
	[SerializeField] // RVA: 0x298550 Offset: 0x298651 VA: 0x298550
	private float m_LimitMoveVertical; // 0x20
	[SerializeField] // RVA: 0x2985A0 Offset: 0x2986A1 VA: 0x2985A0
	[HeaderAttribute] // RVA: 0x2985A0 Offset: 0x2986A1 VA: 0x2985A0
	private float m_LimitAngleY; // 0x24
	[HeaderAttribute] // RVA: 0x2985F0 Offset: 0x2986F1 VA: 0x2985F0
	[SerializeField] // RVA: 0x2985F0 Offset: 0x2986F1 VA: 0x2985F0
	private float m_FieldOfView; // 0x28
	[SerializeField] // RVA: 0x298640 Offset: 0x298741 VA: 0x298640
	private float m_LimitFov; // 0x2C

	// Properties
	public float Distance { get; }
	public float LimitMoveX { get; }
	public float LimitMoveY { get; }
	public float LimitAngleY { get; }
	public float Fov { get; }
	public float LimitFov { get; }

	// Methods

	// RVA: 0x2A28A90 Offset: 0x2A28B91 VA: 0x2A28A90
	public float get_Distance() { }

	// RVA: 0x2A28AA0 Offset: 0x2A28BA1 VA: 0x2A28AA0
	public float get_LimitMoveX() { }

	// RVA: 0x2A28AB0 Offset: 0x2A28BB1 VA: 0x2A28AB0
	public float get_LimitMoveY() { }

	// RVA: 0x2A28AC0 Offset: 0x2A28BC1 VA: 0x2A28AC0
	public float get_LimitAngleY() { }

	// RVA: 0x2A28AD0 Offset: 0x2A28BD1 VA: 0x2A28AD0
	public float get_Fov() { }

	// RVA: 0x2A28910 Offset: 0x2A28A11 VA: 0x2A28910
	public float get_LimitFov() { }

	// RVA: 0x2A28AE0 Offset: 0x2A28BE1 VA: 0x2A28AE0
	public void .ctor() { }
}

