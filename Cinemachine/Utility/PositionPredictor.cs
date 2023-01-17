// Namespace: Cinemachine.Utility
public class PositionPredictor // TypeDefIndex: 5903
{
	// Fields
	private Vector3 m_Velocity; // 0x10
	private Vector3 m_SmoothDampVelocity; // 0x1C
	private Vector3 m_Pos; // 0x28
	private bool m_HavePos; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x23450 Offset: 0x23551 VA: 0x23450
	private float <Smoothing>k__BackingField; // 0x38

	// Properties
	public float Smoothing { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x240F0 Offset: 0x241F1 VA: 0x240F0
	// RVA: 0x1A82F60 Offset: 0x1A83061 VA: 0x1A82F60
	public float get_Smoothing() { }

	[CompilerGeneratedAttribute] // RVA: 0x24100 Offset: 0x24201 VA: 0x24100
	// RVA: 0x1A82F70 Offset: 0x1A83071 VA: 0x1A82F70
	public void set_Smoothing(float value) { }

	// RVA: 0x1A82F80 Offset: 0x1A83081 VA: 0x1A82F80
	public bool IsEmpty() { }

	// RVA: 0x1A82F90 Offset: 0x1A83091 VA: 0x1A82F90
	public void ApplyTransformDelta(Vector3 positionDelta) { }

	// RVA: 0x1A82FC0 Offset: 0x1A830C1 VA: 0x1A82FC0
	public void Reset() { }

	// RVA: 0x1A83010 Offset: 0x1A83111 VA: 0x1A83010
	public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime) { }

	// RVA: 0x1A83160 Offset: 0x1A83261 VA: 0x1A83160
	public Vector3 PredictPositionDelta(float lookaheadTime) { }

	// RVA: 0x1A83180 Offset: 0x1A83281 VA: 0x1A83180
	public Vector3 PredictPosition(float lookaheadTime) { }

	// RVA: 0x1A831B0 Offset: 0x1A832B1 VA: 0x1A831B0
	public void .ctor() { }
}

