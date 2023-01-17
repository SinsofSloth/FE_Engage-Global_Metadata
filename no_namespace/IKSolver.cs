// Namespace: 
[Serializable]
public class IKSolver.Point // TypeDefIndex: 14368
{
	// Fields
	public Transform transform; // 0x10
	[RangeAttribute] // RVA: 0x2A0AC0 Offset: 0x2A0BC1 VA: 0x2A0AC0
	public float weight; // 0x18
	public Vector3 solverPosition; // 0x1C
	public Quaternion solverRotation; // 0x28
	public Vector3 defaultLocalPosition; // 0x38
	public Quaternion defaultLocalRotation; // 0x44

	// Methods

	// RVA: 0x35FC880 Offset: 0x35FC981 VA: 0x35FC880
	public void StoreDefaultLocalState() { }

	// RVA: 0x35FC8D0 Offset: 0x35FC9D1 VA: 0x35FC8D0
	public void FixTransform() { }

	// RVA: 0x35FC960 Offset: 0x35FCA61 VA: 0x35FC960
	public void UpdateSolverPosition() { }

	// RVA: 0x35FC9A0 Offset: 0x35FCAA1 VA: 0x35FC9A0
	public void UpdateSolverLocalPosition() { }

	// RVA: 0x35FC9E0 Offset: 0x35FCAE1 VA: 0x35FC9E0
	public void UpdateSolverState() { }

	// RVA: 0x35FCA30 Offset: 0x35FCB31 VA: 0x35FCA30
	public void UpdateSolverLocalState() { }

	// RVA: 0x35FC300 Offset: 0x35FC401 VA: 0x35FC300
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class IKSolver.Bone : IKSolver.Point // TypeDefIndex: 14369
{
	// Fields
	public float length; // 0x54
	public float sqrMag; // 0x58
	public Vector3 axis; // 0x5C
	private RotationLimit _rotationLimit; // 0x68
	private bool isLimited; // 0x70

	// Properties
	public RotationLimit rotationLimit { get; set; }

	// Methods

	// RVA: 0x35FBC80 Offset: 0x35FBD81 VA: 0x35FBC80
	public RotationLimit get_rotationLimit() { }

	// RVA: 0x35FBD90 Offset: 0x35FBE91 VA: 0x35FBD90
	public void set_rotationLimit(RotationLimit value) { }

	// RVA: 0x35FBE20 Offset: 0x35FBF21 VA: 0x35FBE20
	public void Swing(Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x35FBF70 Offset: 0x35FC071 VA: 0x35FBF70
	public static void SolverSwing(IKSolver.Bone[] bones, int index, Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x35FC130 Offset: 0x35FC231 VA: 0x35FC130
	public void Swing2D(Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x35FC270 Offset: 0x35FC371 VA: 0x35FC270
	public void SetToSolverPosition() { }

	// RVA: 0x35FC290 Offset: 0x35FC391 VA: 0x35FC290
	public void .ctor() { }

	// RVA: 0x35FC350 Offset: 0x35FC451 VA: 0x35FC350
	public void .ctor(Transform transform) { }

	// RVA: 0x35FC3D0 Offset: 0x35FC4D1 VA: 0x35FC3D0
	public void .ctor(Transform transform, float weight) { }
}

// Namespace: 
[Serializable]
public class IKSolver.Node : IKSolver.Point // TypeDefIndex: 14370
{
	// Fields
	public float length; // 0x54
	public float effectorPositionWeight; // 0x58
	public float effectorRotationWeight; // 0x5C
	public Vector3 offset; // 0x60

	// Methods

	// RVA: 0x35FC760 Offset: 0x35FC861 VA: 0x35FC760
	public void .ctor() { }

	// RVA: 0x35FC7B0 Offset: 0x35FC8B1 VA: 0x35FC7B0
	public void .ctor(Transform transform) { }

	// RVA: 0x35FC810 Offset: 0x35FC911 VA: 0x35FC810
	public void .ctor(Transform transform, float weight) { }
}

// Namespace: 
public sealed class IKSolver.UpdateDelegate : MulticastDelegate // TypeDefIndex: 14371
{
	// Methods

	// RVA: 0x35FCA80 Offset: 0x35FCB81 VA: 0x35FCA80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35FCAA0 Offset: 0x35FCBA1 VA: 0x35FCAA0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x35FCCB0 Offset: 0x35FCDB1 VA: 0x35FCCB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x35FCCE0 Offset: 0x35FCDE1 VA: 0x35FCCE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class IKSolver.IterationDelegate : MulticastDelegate // TypeDefIndex: 14372
{
	// Methods

	// RVA: 0x35FC470 Offset: 0x35FC571 VA: 0x35FC470
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35FC490 Offset: 0x35FC591 VA: 0x35FC490 Slot: 13
	public virtual void Invoke(int i) { }

	// RVA: 0x35FC6C0 Offset: 0x35FC7C1 VA: 0x35FC6C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int i, AsyncCallback callback, object object) { }

	// RVA: 0x35FC750 Offset: 0x35FC851 VA: 0x35FC750 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

