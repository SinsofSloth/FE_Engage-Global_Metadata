// Namespace: Cinemachine
public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 5835
{
	// Fields
	[RangeAttribute] // RVA: 0x219F0 Offset: 0x21AF1 VA: 0x219F0
	[TooltipAttribute] // RVA: 0x219F0 Offset: 0x21AF1 VA: 0x219F0
	public int m_Resolution; // 0x18
	[TooltipAttribute] // RVA: 0x21A50 Offset: 0x21B51 VA: 0x21A50
	public CinemachinePathBase.Appearance m_Appearance; // 0x20
	private float[] m_DistanceToPos; // 0x28
	private float[] m_PosToDistance; // 0x30
	private int m_CachedSampleSteps; // 0x38
	private float m_PathLength; // 0x3C
	private float m_cachedPosStepSize; // 0x40
	private float m_cachedDistanceStepSize; // 0x44

	// Properties
	public abstract float MinPos { get; }
	public abstract float MaxPos { get; }
	public abstract bool Looped { get; }
	public abstract int DistanceCacheSampleStepsPerSegment { get; }
	public float PathLength { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_MinPos();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_MaxPos();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_Looped();

	// RVA: 0x1BA5B80 Offset: 0x1BA5C81 VA: 0x1BA5B80 Slot: 7
	public virtual float StandardizePos(float pos) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Vector3 EvaluatePosition(float pos);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Vector3 EvaluateTangent(float pos);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Quaternion EvaluateOrientation(float pos);

	// RVA: 0x1BA5C40 Offset: 0x1BA5D41 VA: 0x1BA5C40 Slot: 11
	public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) { }

	// RVA: 0x1BA5F10 Offset: 0x1BA6011 VA: 0x1BA5F10
	public float MinUnit(CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1BA5F30 Offset: 0x1BA6031 VA: 0x1BA5F30
	public float MaxUnit(CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1BA6130 Offset: 0x1BA6231 VA: 0x1BA6130 Slot: 12
	public virtual float StandardizeUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1B976D0 Offset: 0x1B977D1 VA: 0x1B976D0
	public Vector3 EvaluatePositionAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1BA6650 Offset: 0x1BA6751 VA: 0x1BA6650
	public Vector3 EvaluateTangentAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1B97700 Offset: 0x1B97801 VA: 0x1B97700
	public Quaternion EvaluateOrientationAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_DistanceCacheSampleStepsPerSegment();

	// RVA: 0x1BA6680 Offset: 0x1BA6781 VA: 0x1BA6680 Slot: 14
	public virtual void InvalidateDistanceCache() { }

	// RVA: 0x1BA66C0 Offset: 0x1BA67C1 VA: 0x1BA66C0
	public bool DistanceCacheIsValid() { }

	// RVA: 0x1BA6050 Offset: 0x1BA6151 VA: 0x1BA6050
	public float get_PathLength() { }

	// RVA: 0x1BA6280 Offset: 0x1BA6381 VA: 0x1BA6280
	public float StandardizePathDistance(float distance) { }

	// RVA: 0x1BA63C0 Offset: 0x1BA64C1 VA: 0x1BA63C0
	public float ToNativePathUnits(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1BA6A70 Offset: 0x1BA6B71 VA: 0x1BA6A70
	public float FromPathNativeUnits(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1BA6770 Offset: 0x1BA6871 VA: 0x1BA6770
	private void ResamplePath(int stepsPerSegment) { }

	// RVA: 0x1BA5B00 Offset: 0x1BA5C01 VA: 0x1BA5B00
	protected void .ctor() { }
}

