// Namespace: 
public class AkTransform : IDisposable // TypeDefIndex: 7904
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Methods

	// RVA: 0x20DD570 Offset: 0x20DD671 VA: 0x20DD570
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x20C8E90 Offset: 0x20C8F91 VA: 0x20C8E90
	internal static IntPtr getCPtr(AkTransform obj) { }

	// RVA: 0x20DD5B0 Offset: 0x20DD6B1 VA: 0x20DD5B0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x20DD5E0 Offset: 0x20DD6E1 VA: 0x20DD5E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x20DD650 Offset: 0x20DD751 VA: 0x20DD650 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x20DD7D0 Offset: 0x20DD8D1 VA: 0x20DD7D0
	public Vector3 Position() { }

	// RVA: 0x20DD840 Offset: 0x20DD941 VA: 0x20DD840
	public Vector3 OrientationFront() { }

	// RVA: 0x20DD8B0 Offset: 0x20DD9B1 VA: 0x20DD8B0
	public Vector3 OrientationTop() { }

	// RVA: 0x20DD920 Offset: 0x20DDA21 VA: 0x20DD920
	public void Set(Vector3 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop) { }

	// RVA: 0x20DDA30 Offset: 0x20DDB31 VA: 0x20DDA30
	public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) { }

	// RVA: 0x20DDB60 Offset: 0x20DDC61 VA: 0x20DDB60
	public void SetPosition(Vector3 in_position) { }

	// RVA: 0x20DDC00 Offset: 0x20DDD01 VA: 0x20DDC00
	public void SetPosition(float in_x, float in_y, float in_z) { }

	// RVA: 0x20DDCA0 Offset: 0x20DDDA1 VA: 0x20DDCA0
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop) { }

	// RVA: 0x20DDD60 Offset: 0x20DDE61 VA: 0x20DDD60
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) { }

	// RVA: 0x20DDE20 Offset: 0x20DDF21 VA: 0x20DDE20
	public void .ctor() { }
}

