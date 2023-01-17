// Namespace: UnityEngine.AI
[NativeHeaderAttribute] // RVA: 0x70BB0 Offset: 0x70CB1 VA: 0x70BB0
[MovedFromAttribute] // RVA: 0x70BB0 Offset: 0x70CB1 VA: 0x70BB0
[NativeHeaderAttribute] // RVA: 0x70BB0 Offset: 0x70CB1 VA: 0x70BB0
public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 7502
{
	// Properties
	public Vector3 steeringTarget { get; }
	public float speed { set; }

	// Methods

	// RVA: 0x1C6AB40 Offset: 0x1C6AC41 VA: 0x1C6AB40
	public bool SetDestination(Vector3 target) { }

	// RVA: 0x1C6ABF0 Offset: 0x1C6ACF1 VA: 0x1C6ABF0
	public Vector3 get_steeringTarget() { }

	// RVA: 0x1C6ACA0 Offset: 0x1C6ADA1 VA: 0x1C6ACA0
	public bool CalculatePath(Vector3 targetPosition, NavMeshPath path) { }

	[FreeFunctionAttribute] // RVA: 0x70EA0 Offset: 0x70FA1 VA: 0x70EA0
	// RVA: 0x1C6AD60 Offset: 0x1C6AE61 VA: 0x1C6AD60
	private bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path) { }

	// RVA: 0x1C6AE30 Offset: 0x1C6AF31 VA: 0x1C6AE30
	public void set_speed(float value) { }

	// RVA: 0x1C6ABA0 Offset: 0x1C6ACA1 VA: 0x1C6ABA0
	private bool SetDestination_Injected(ref Vector3 target) { }

	// RVA: 0x1C6AC50 Offset: 0x1C6AD51 VA: 0x1C6AC50
	private void get_steeringTarget_Injected(out Vector3 ret) { }

	// RVA: 0x1C6ADD0 Offset: 0x1C6AED1 VA: 0x1C6ADD0
	private bool CalculatePathInternal_Injected(ref Vector3 targetPosition, NavMeshPath path) { }
}

