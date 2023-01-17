// Namespace: nn.hid
public struct SixAxisSensorState // TypeDefIndex: 14665
{
	// Fields
	public const float AccelerometerMax = 7;
	public const float AngularVelocityMax = 5;
	public long deltaTimeNanoSeconds; // 0x0
	public long samplingNumber; // 0x8
	public Float3 acceleration; // 0x10
	public Float3 angularVelocity; // 0x1C
	public Float3 angle; // 0x28
	public DirectionState direction; // 0x34
	public SixAxisSensorAttribute attributes; // 0x58

	// Methods

	// RVA: 0x23436D0 Offset: 0x23437D1 VA: 0x23436D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2343A10 Offset: 0x2343B11 VA: 0x2343A10
	public void GetQuaternion(ref float x, ref float y, ref float z, ref float w) { }

	// RVA: 0x2343A30 Offset: 0x2343B31 VA: 0x2343A30
	public void GetQuaternion(ref Float4 quaternion) { }

	// RVA: 0x2343A20 Offset: 0x2343B21 VA: 0x2343A20
	private static extern void GetQuaternion(ref SixAxisSensorState state, ref float pOutX, ref float pOutY, ref float pOutZ, ref float pOutW) { }
}

