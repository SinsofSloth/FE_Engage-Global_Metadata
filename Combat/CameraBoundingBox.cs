// Namespace: Combat
internal class CameraBoundingBox // TypeDefIndex: 8526
{
	// Fields
	private Vector3 m_CameraDirection; // 0x10
	private Matrix4x4 m_MatrixWorldToCamera; // 0x1C
	private Matrix4x4 m_MatrixCameraToWorld; // 0x5C
	private Bounds m_Box; // 0x9C
	private List<ValueTuple<Vector3, float>> m_Objects; // 0xB8
	private readonly float m_ScreenSpaceReprojectionRatio; // 0xC0
	private bool m_IsFinalized; // 0xC4

	// Methods

	// RVA: 0x2C83490 Offset: 0x2C83591 VA: 0x2C83490
	public void .ctor(Vector3 followPos, Vector3 lookAtPos, float screenSpaceReprojectionRatio) { }

	// RVA: 0x2C83710 Offset: 0x2C83811 VA: 0x2C83710
	public void Append(Vector3 pos, float size) { }

	// RVA: 0x2C83800 Offset: 0x2C83901 VA: 0x2C83800
	public void CreateBox() { }

	// RVA: 0x2C83AB0 Offset: 0x2C83BB1 VA: 0x2C83AB0
	public Vector3 GetBoxCenter() { }

	// RVA: 0x2C83B10 Offset: 0x2C83C11 VA: 0x2C83B10
	public float GetNearestDistance(float fov) { }

	// RVA: 0x2C83CA0 Offset: 0x2C83DA1 VA: 0x2C83CA0
	public Vector3 PosInCamera(Vector3 pos) { }
}

