// Namespace: App
internal class CameraController : SingletonMonoBehaviour<CameraController> // TypeDefIndex: 14080
{
	// Fields
	private int m_Hash; // 0x20
	private CameraParameter m_Original; // 0x24
	private CameraParameter m_Operation; // 0x40
	private bool m_Updated; // 0x5C
	public float m_NearClipPlane; // 0x60
	public float m_FarClipPlane; // 0x64
	private float m_MouseX; // 0x68
	private float m_MouseY; // 0x6C

	// Properties
	public float NearClipPlane { get; set; }
	public float FarClipPlane { get; set; }

	// Methods

	// RVA: 0x2C83F90 Offset: 0x2C84091 VA: 0x2C83F90
	public float get_NearClipPlane() { }

	// RVA: 0x2C83FA0 Offset: 0x2C840A1 VA: 0x2C83FA0
	public void set_NearClipPlane(float value) { }

	// RVA: 0x2C83FB0 Offset: 0x2C840B1 VA: 0x2C83FB0
	public float get_FarClipPlane() { }

	// RVA: 0x2C83FC0 Offset: 0x2C840C1 VA: 0x2C83FC0
	public void set_FarClipPlane(float value) { }

	// RVA: 0x2C83FD0 Offset: 0x2C840D1 VA: 0x2C83FD0
	private void Start() { }

	// RVA: 0x2C83FE0 Offset: 0x2C840E1 VA: 0x2C83FE0
	private void LateUpdate() { }

	// RVA: 0x2C84100 Offset: 0x2C84201 VA: 0x2C84100
	private bool TryChange(Camera camera) { }

	// RVA: 0x2C84260 Offset: 0x2C84361 VA: 0x2C84260
	private bool TryInitialize(Camera camera) { }

	[ConditionalAttribute] // RVA: 0x2CDCA0 Offset: 0x2CDDA1 VA: 0x2CDCA0
	// RVA: 0x2C842C0 Offset: 0x2C843C1 VA: 0x2C842C0
	private void Tick() { }

	// RVA: 0x2C84E80 Offset: 0x2C84F81 VA: 0x2C84E80
	public void .ctor() { }
}

