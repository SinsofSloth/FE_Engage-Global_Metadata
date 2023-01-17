// Namespace: App
public class MapCamera : SingletonClass<MapCamera> // TypeDefIndex: 11909
{
	// Fields
	private InterpolatorVector3 m_Position; // 0x20
	private InterpolatorVector3 m_Rotation; // 0x28
	private InterpolatorFloat m_Distance; // 0x30
	private MapCamera.InterpolatorShake m_EffectShake; // 0x38
	private MapCamera.InterpolatorShake m_ActionShake; // 0x40
	private float m_Fov; // 0x48

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x2C89980 Offset: 0x2C89A81 VA: 0x2C89980
	public static Camera GetCamera() { }

	// RVA: 0x2C89A60 Offset: 0x2C89B61 VA: 0x2C89A60
	public static void SetPosition(Vector3 pos, float speed = 0) { }

	// RVA: 0x2C8B520 Offset: 0x2C8B621 VA: 0x2C8B520
	public static void SetPosition(int x, int z) { }

	// RVA: 0x2C8B5E0 Offset: 0x2C8B6E1 VA: 0x2C8B5E0
	public static void SetRotation(Vector3 rot) { }

	// RVA: 0x2C8B7E0 Offset: 0x2C8B8E1 VA: 0x2C8B7E0
	public static void SetDistance(float distance) { }

	// RVA: 0x2C8B9C0 Offset: 0x2C8BAC1 VA: 0x2C8B9C0
	public static Vector3 GetRotation() { }

	// RVA: 0x2C8BAA0 Offset: 0x2C8BBA1 VA: 0x2C8BAA0
	public static void Instant(Camera camera) { }

	// RVA: 0x2C8BC20 Offset: 0x2C8BD21 VA: 0x2C8BC20
	public static void EffectShake(float time, float magnitude) { }

	// RVA: 0x2C8BD00 Offset: 0x2C8BE01 VA: 0x2C8BD00
	public static void ActionShake(float time, float magnitude) { }

	// RVA: 0x2C8BDE0 Offset: 0x2C8BEE1 VA: 0x2C8BDE0
	public static bool CheckScrollStrictly() { }

	// RVA: 0x2C8BFD0 Offset: 0x2C8C0D1 VA: 0x2C8BFD0
	public static bool CheckScrollLoosely() { }

	// RVA: 0x2C8C1D0 Offset: 0x2C8C2D1 VA: 0x2C8C1D0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2C8C1E0 Offset: 0x2C8C2E1 VA: 0x2C8C1E0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2C8C2B0 Offset: 0x2C8C3B1 VA: 0x2C8C2B0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2C8C610 Offset: 0x2C8C711 VA: 0x2C8C610 Slot: 7
	protected override void OnTick() { }

	// RVA: 0x2C8C620 Offset: 0x2C8C721 VA: 0x2C8C620 Slot: 8
	protected override void OnUpdate() { }

	// RVA: 0x2C8CA50 Offset: 0x2C8CB51 VA: 0x2C8CA50
	private void Commit(Camera camera) { }

	// RVA: 0x2C8D060 Offset: 0x2C8D161 VA: 0x2C8D060
	private float GetParamTime(string name) { }

	// RVA: 0x2C89B50 Offset: 0x2C89C51 VA: 0x2C89B50
	private void SetPositionImpl(Vector3 pos, float speed) { }

	// RVA: 0x2C8B730 Offset: 0x2C8B831 VA: 0x2C8B730
	private void SetRotationImpl(Vector3 rot) { }

	// RVA: 0x2C8B920 Offset: 0x2C8BA21 VA: 0x2C8B920
	private void SetDistanceImpl(float distance) { }

	// RVA: 0x2C8BBB0 Offset: 0x2C8BCB1 VA: 0x2C8BBB0
	private void InstantImpl(Camera camera) { }

	// RVA: 0x2C8D0A0 Offset: 0x2C8D1A1 VA: 0x2C8D0A0
	public void .ctor() { }
}

