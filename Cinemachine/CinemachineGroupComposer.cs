// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B400 Offset: 0x1B501 VA: 0x1B400
[AddComponentMenu] // RVA: 0x1B400 Offset: 0x1B501 VA: 0x1B400
[SaveDuringPlayAttribute] // RVA: 0x1B400 Offset: 0x1B501 VA: 0x1B400
public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 5791
{
	// Fields
	[TooltipAttribute] // RVA: 0x1FDE0 Offset: 0x1FEE1 VA: 0x1FDE0
	[SpaceAttribute] // RVA: 0x1FDE0 Offset: 0x1FEE1 VA: 0x1FDE0
	public float m_GroupFramingSize; // 0x128
	[TooltipAttribute] // RVA: 0x1FE30 Offset: 0x1FF31 VA: 0x1FE30
	public CinemachineGroupComposer.FramingMode m_FramingMode; // 0x12C
	[RangeAttribute] // RVA: 0x1FE70 Offset: 0x1FF71 VA: 0x1FE70
	[TooltipAttribute] // RVA: 0x1FE70 Offset: 0x1FF71 VA: 0x1FE70
	public float m_FrameDamping; // 0x130
	[TooltipAttribute] // RVA: 0x1FED0 Offset: 0x1FFD1 VA: 0x1FED0
	public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode; // 0x134
	[TooltipAttribute] // RVA: 0x1FF10 Offset: 0x20011 VA: 0x1FF10
	public float m_MaxDollyIn; // 0x138
	[TooltipAttribute] // RVA: 0x1FF50 Offset: 0x20051 VA: 0x1FF50
	public float m_MaxDollyOut; // 0x13C
	[TooltipAttribute] // RVA: 0x1FF90 Offset: 0x20091 VA: 0x1FF90
	public float m_MinimumDistance; // 0x140
	[TooltipAttribute] // RVA: 0x1FFD0 Offset: 0x200D1 VA: 0x1FFD0
	public float m_MaximumDistance; // 0x144
	[TooltipAttribute] // RVA: 0x20010 Offset: 0x20111 VA: 0x20010
	[RangeAttribute] // RVA: 0x20010 Offset: 0x20111 VA: 0x20010
	public float m_MinimumFOV; // 0x148
	[RangeAttribute] // RVA: 0x20070 Offset: 0x20171 VA: 0x20070
	[TooltipAttribute] // RVA: 0x20070 Offset: 0x20171 VA: 0x20070
	public float m_MaximumFOV; // 0x14C
	[TooltipAttribute] // RVA: 0x200D0 Offset: 0x201D1 VA: 0x200D0
	public float m_MinimumOrthoSize; // 0x150
	[TooltipAttribute] // RVA: 0x20110 Offset: 0x20211 VA: 0x20110
	public float m_MaximumOrthoSize; // 0x154
	private float m_prevFramingDistance; // 0x158
	private float m_prevFOV; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x20150 Offset: 0x20251 VA: 0x20150
	private Bounds <LastBounds>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x20160 Offset: 0x20261 VA: 0x20160
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178

	// Properties
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1B9E840 Offset: 0x1B9E941 VA: 0x1B9E840
	private void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x23790 Offset: 0x23891 VA: 0x23790
	// RVA: 0x1B9E930 Offset: 0x1B9EA31 VA: 0x1B9E930
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x237A0 Offset: 0x238A1 VA: 0x237A0
	// RVA: 0x1B9E950 Offset: 0x1B9EA51 VA: 0x1B9E950
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x237B0 Offset: 0x238B1 VA: 0x237B0
	// RVA: 0x1B9E970 Offset: 0x1B9EA71 VA: 0x1B9E970
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x237C0 Offset: 0x238C1 VA: 0x237C0
	// RVA: 0x1B9E9A0 Offset: 0x1B9EAA1 VA: 0x1B9E9A0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1B9E9C0 Offset: 0x1B9EAC1 VA: 0x1B9E9C0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1B9E9F0 Offset: 0x1B9EAF1 VA: 0x1B9E9F0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B9F690 Offset: 0x1B9F791 VA: 0x1B9F690
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1B9F400 Offset: 0x1B9F501 VA: 0x1B9F400
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	// RVA: 0x1B9F830 Offset: 0x1B9F931 VA: 0x1B9F830
	public void .ctor() { }
}

