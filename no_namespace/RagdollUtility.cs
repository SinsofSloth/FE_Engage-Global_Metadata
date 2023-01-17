// Namespace: 
public class RagdollUtility.Rigidbone // TypeDefIndex: 14429
{
	// Fields
	public Rigidbody r; // 0x10
	public Transform t; // 0x18
	public Collider collider; // 0x20
	public Joint joint; // 0x28
	public Rigidbody c; // 0x30
	public bool updateAnchor; // 0x38
	public Vector3 deltaPosition; // 0x3C
	public Quaternion deltaRotation; // 0x48
	public float deltaTime; // 0x58
	public Vector3 lastPosition; // 0x5C
	public Quaternion lastRotation; // 0x68

	// Methods

	// RVA: 0x1F2A5E0 Offset: 0x1F2A6E1 VA: 0x1F2A5E0
	public void .ctor(Rigidbody r) { }

	// RVA: 0x1F2A790 Offset: 0x1F2A891 VA: 0x1F2A790
	public void RecordVelocity() { }

	// RVA: 0x1F2A880 Offset: 0x1F2A981 VA: 0x1F2A880
	public void WakeUp(float velocityWeight, float angularVelocityWeight) { }
}

// Namespace: 
public class RagdollUtility.Child // TypeDefIndex: 14430
{
	// Fields
	public Transform t; // 0x10
	public Vector3 localPosition; // 0x18
	public Quaternion localRotation; // 0x24

	// Methods

	// RVA: 0x1F2A400 Offset: 0x1F2A501 VA: 0x1F2A400
	public void .ctor(Transform transform) { }

	// RVA: 0x1F2A470 Offset: 0x1F2A571 VA: 0x1F2A470
	public void FixTransform(float weight) { }

	// RVA: 0x1F2A590 Offset: 0x1F2A691 VA: 0x1F2A590
	public void StoreLocalState() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A0C0 Offset: 0x27A1C1 VA: 0x27A0C0
private sealed class RagdollUtility.<DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 14431
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RagdollUtility <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D0470 Offset: 0x2D0571 VA: 0x2D0470
	// RVA: 0x1F2A180 Offset: 0x1F2A281 VA: 0x1F2A180
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0480 Offset: 0x2D0581 VA: 0x2D0480
	// RVA: 0x1F2A1B0 Offset: 0x1F2A2B1 VA: 0x1F2A1B0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F2A1C0 Offset: 0x1F2A2C1 VA: 0x1F2A1C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0490 Offset: 0x2D0591 VA: 0x2D0490
	// RVA: 0x1F2A3A0 Offset: 0x1F2A4A1 VA: 0x1F2A3A0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D04A0 Offset: 0x2D05A1 VA: 0x2D04A0
	// RVA: 0x1F2A3B0 Offset: 0x1F2A4B1 VA: 0x1F2A3B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D04B0 Offset: 0x2D05B1 VA: 0x2D04B0
	// RVA: 0x1F2A3F0 Offset: 0x1F2A4F1 VA: 0x1F2A3F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

