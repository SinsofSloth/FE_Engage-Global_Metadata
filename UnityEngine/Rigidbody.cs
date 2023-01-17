// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x5C8F0 Offset: 0x5C9F1 VA: 0x5C8F0
[RequireComponent] // RVA: 0x5C8F0 Offset: 0x5C9F1 VA: 0x5C8F0
public sealed class Rigidbody2D : Component // TypeDefIndex: 4052
{
	// Properties
	public Vector2 velocity { get; }
	public float mass { get; }

	// Methods

	// RVA: 0x1C5D6C0 Offset: 0x1C5D7C1 VA: 0x1C5D6C0
	public Vector2 get_velocity() { }

	// RVA: 0x1C5D770 Offset: 0x1C5D871 VA: 0x1C5D770
	public float get_mass() { }

	// RVA: 0x1C5D7C0 Offset: 0x1C5D8C1 VA: 0x1C5D7C0
	public void .ctor() { }

	// RVA: 0x1C5D720 Offset: 0x1C5D821 VA: 0x1C5D720
	private void get_velocity_Injected(out Vector2 ret) { }
}

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x485800 Offset: 0x485901 VA: 0x485800
[RequireComponent] // RVA: 0x485800 Offset: 0x485901 VA: 0x485800
public class Rigidbody : Component // TypeDefIndex: 4199
{
	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float mass { get; set; }
	public bool useGravity { get; set; }
	public float maxDepenetrationVelocity { get; set; }
	public bool isKinematic { get; set; }
	public bool freezeRotation { get; set; }
	public RigidbodyConstraints constraints { get; set; }
	public CollisionDetectionMode collisionDetectionMode { get; set; }
	public Vector3 centerOfMass { get; set; }
	public Vector3 worldCenterOfMass { get; }
	public Quaternion inertiaTensorRotation { get; set; }
	public Vector3 inertiaTensor { get; set; }
	public bool detectCollisions { get; set; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public RigidbodyInterpolation interpolation { get; set; }
	public int solverIterations { get; set; }
	public float sleepThreshold { get; set; }
	public float maxAngularVelocity { get; set; }
	public int solverVelocityIterations { get; set; }
	[ObsoleteAttribute] // RVA: 0x488960 Offset: 0x488A61 VA: 0x488960
	public float sleepVelocity { get; set; }
	[ObsoleteAttribute] // RVA: 0x4889A0 Offset: 0x488AA1 VA: 0x4889A0
	public float sleepAngularVelocity { get; set; }
	[ObsoleteAttribute] // RVA: 0x4889E0 Offset: 0x488AE1 VA: 0x4889E0
	public bool useConeFriction { get; set; }
	[ObsoleteAttribute] // RVA: 0x488A20 Offset: 0x488B21 VA: 0x488A20
	public int solverIterationCount { get; set; }
	[ObsoleteAttribute] // RVA: 0x488A60 Offset: 0x488B61 VA: 0x488A60
	public int solverVelocityIterationCount { get; set; }

	// Methods

	// RVA: 0x3EEA3E0 Offset: 0x3EEA4E1 VA: 0x3EEA3E0
	public Vector3 get_velocity() { }

	// RVA: 0x3EEA490 Offset: 0x3EEA591 VA: 0x3EEA490
	public void set_velocity(Vector3 value) { }

	// RVA: 0x3EEA540 Offset: 0x3EEA641 VA: 0x3EEA540
	public Vector3 get_angularVelocity() { }

	// RVA: 0x3EEA5F0 Offset: 0x3EEA6F1 VA: 0x3EEA5F0
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x3EEA6A0 Offset: 0x3EEA7A1 VA: 0x3EEA6A0
	public float get_drag() { }

	// RVA: 0x3EEA6F0 Offset: 0x3EEA7F1 VA: 0x3EEA6F0
	public void set_drag(float value) { }

	// RVA: 0x3EEA740 Offset: 0x3EEA841 VA: 0x3EEA740
	public float get_angularDrag() { }

	// RVA: 0x3EEA790 Offset: 0x3EEA891 VA: 0x3EEA790
	public void set_angularDrag(float value) { }

	// RVA: 0x3EEA7E0 Offset: 0x3EEA8E1 VA: 0x3EEA7E0
	public float get_mass() { }

	// RVA: 0x3EEA830 Offset: 0x3EEA931 VA: 0x3EEA830
	public void set_mass(float value) { }

	// RVA: 0x3EEA880 Offset: 0x3EEA981 VA: 0x3EEA880
	public void SetDensity(float density) { }

	// RVA: 0x3EEA8D0 Offset: 0x3EEA9D1 VA: 0x3EEA8D0
	public bool get_useGravity() { }

	// RVA: 0x3EEA920 Offset: 0x3EEAA21 VA: 0x3EEA920
	public void set_useGravity(bool value) { }

	// RVA: 0x3EEA970 Offset: 0x3EEAA71 VA: 0x3EEA970
	public float get_maxDepenetrationVelocity() { }

	// RVA: 0x3EEA9C0 Offset: 0x3EEAAC1 VA: 0x3EEA9C0
	public void set_maxDepenetrationVelocity(float value) { }

	// RVA: 0x3EEAA10 Offset: 0x3EEAB11 VA: 0x3EEAA10
	public bool get_isKinematic() { }

	// RVA: 0x3EEAA60 Offset: 0x3EEAB61 VA: 0x3EEAA60
	public void set_isKinematic(bool value) { }

	// RVA: 0x3EEAAB0 Offset: 0x3EEABB1 VA: 0x3EEAAB0
	public bool get_freezeRotation() { }

	// RVA: 0x3EEAB00 Offset: 0x3EEAC01 VA: 0x3EEAB00
	public void set_freezeRotation(bool value) { }

	// RVA: 0x3EEAB50 Offset: 0x3EEAC51 VA: 0x3EEAB50
	public RigidbodyConstraints get_constraints() { }

	// RVA: 0x3EEABA0 Offset: 0x3EEACA1 VA: 0x3EEABA0
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x3EEABF0 Offset: 0x3EEACF1 VA: 0x3EEABF0
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x3EEAC40 Offset: 0x3EEAD41 VA: 0x3EEAC40
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x3EEAC90 Offset: 0x3EEAD91 VA: 0x3EEAC90
	public Vector3 get_centerOfMass() { }

	// RVA: 0x3EEAD40 Offset: 0x3EEAE41 VA: 0x3EEAD40
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x3EEADF0 Offset: 0x3EEAEF1 VA: 0x3EEADF0
	public Vector3 get_worldCenterOfMass() { }

	// RVA: 0x3EEAEA0 Offset: 0x3EEAFA1 VA: 0x3EEAEA0
	public Quaternion get_inertiaTensorRotation() { }

	// RVA: 0x3EEAF50 Offset: 0x3EEB051 VA: 0x3EEAF50
	public void set_inertiaTensorRotation(Quaternion value) { }

	// RVA: 0x3EEB000 Offset: 0x3EEB101 VA: 0x3EEB000
	public Vector3 get_inertiaTensor() { }

	// RVA: 0x3EEB0B0 Offset: 0x3EEB1B1 VA: 0x3EEB0B0
	public void set_inertiaTensor(Vector3 value) { }

	// RVA: 0x3EEB160 Offset: 0x3EEB261 VA: 0x3EEB160
	public bool get_detectCollisions() { }

	// RVA: 0x3EEB1B0 Offset: 0x3EEB2B1 VA: 0x3EEB1B0
	public void set_detectCollisions(bool value) { }

	// RVA: 0x3EEB200 Offset: 0x3EEB301 VA: 0x3EEB200
	public Vector3 get_position() { }

	// RVA: 0x3EEB2B0 Offset: 0x3EEB3B1 VA: 0x3EEB2B0
	public void set_position(Vector3 value) { }

	// RVA: 0x3EEB360 Offset: 0x3EEB461 VA: 0x3EEB360
	public Quaternion get_rotation() { }

	// RVA: 0x3EEB410 Offset: 0x3EEB511 VA: 0x3EEB410
	public void set_rotation(Quaternion value) { }

	// RVA: 0x3EEB4C0 Offset: 0x3EEB5C1 VA: 0x3EEB4C0
	public RigidbodyInterpolation get_interpolation() { }

	// RVA: 0x3EEB510 Offset: 0x3EEB611 VA: 0x3EEB510
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x3EEB560 Offset: 0x3EEB661 VA: 0x3EEB560
	public int get_solverIterations() { }

	// RVA: 0x3EEB5B0 Offset: 0x3EEB6B1 VA: 0x3EEB5B0
	public void set_solverIterations(int value) { }

	// RVA: 0x3EEB600 Offset: 0x3EEB701 VA: 0x3EEB600
	public float get_sleepThreshold() { }

	// RVA: 0x3EEB650 Offset: 0x3EEB751 VA: 0x3EEB650
	public void set_sleepThreshold(float value) { }

	// RVA: 0x3EEB6A0 Offset: 0x3EEB7A1 VA: 0x3EEB6A0
	public float get_maxAngularVelocity() { }

	// RVA: 0x3EEB6F0 Offset: 0x3EEB7F1 VA: 0x3EEB6F0
	public void set_maxAngularVelocity(float value) { }

	// RVA: 0x3EEB740 Offset: 0x3EEB841 VA: 0x3EEB740
	public void MovePosition(Vector3 position) { }

	// RVA: 0x3EEB7F0 Offset: 0x3EEB8F1 VA: 0x3EEB7F0
	public void MoveRotation(Quaternion rot) { }

	// RVA: 0x3EEB8A0 Offset: 0x3EEB9A1 VA: 0x3EEB8A0
	public void Sleep() { }

	// RVA: 0x3EEB8F0 Offset: 0x3EEB9F1 VA: 0x3EEB8F0
	public bool IsSleeping() { }

	// RVA: 0x3EEB940 Offset: 0x3EEBA41 VA: 0x3EEB940
	public void WakeUp() { }

	// RVA: 0x3EEB990 Offset: 0x3EEBA91 VA: 0x3EEB990
	public void ResetCenterOfMass() { }

	// RVA: 0x3EEB9E0 Offset: 0x3EEBAE1 VA: 0x3EEB9E0
	public void ResetInertiaTensor() { }

	// RVA: 0x3EEBA30 Offset: 0x3EEBB31 VA: 0x3EEBA30
	public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { }

	// RVA: 0x3EEBB00 Offset: 0x3EEBC01 VA: 0x3EEBB00
	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	// RVA: 0x3EEBBD0 Offset: 0x3EEBCD1 VA: 0x3EEBBD0
	public int get_solverVelocityIterations() { }

	// RVA: 0x3EEBC20 Offset: 0x3EEBD21 VA: 0x3EEBC20
	public void set_solverVelocityIterations(int value) { }

	// RVA: 0x3EEBC70 Offset: 0x3EEBD71 VA: 0x3EEBC70
	public float get_sleepVelocity() { }

	// RVA: 0x3EEBCC0 Offset: 0x3EEBDC1 VA: 0x3EEBCC0
	public void set_sleepVelocity(float value) { }

	// RVA: 0x3EEBD10 Offset: 0x3EEBE11 VA: 0x3EEBD10
	public float get_sleepAngularVelocity() { }

	// RVA: 0x3EEBD60 Offset: 0x3EEBE61 VA: 0x3EEBD60
	public void set_sleepAngularVelocity(float value) { }

	[ObsoleteAttribute] // RVA: 0x485F60 Offset: 0x486061 VA: 0x485F60
	// RVA: 0x3EEBDB0 Offset: 0x3EEBEB1 VA: 0x3EEBDB0
	public void SetMaxAngularVelocity(float a) { }

	// RVA: 0x3EEBE00 Offset: 0x3EEBF01 VA: 0x3EEBE00
	public bool get_useConeFriction() { }

	// RVA: 0x3EEBE10 Offset: 0x3EEBF11 VA: 0x3EEBE10
	public void set_useConeFriction(bool value) { }

	// RVA: 0x3EEBE20 Offset: 0x3EEBF21 VA: 0x3EEBE20
	public int get_solverIterationCount() { }

	// RVA: 0x3EEBE70 Offset: 0x3EEBF71 VA: 0x3EEBE70
	public void set_solverIterationCount(int value) { }

	// RVA: 0x3EEBEC0 Offset: 0x3EEBFC1 VA: 0x3EEBEC0
	public int get_solverVelocityIterationCount() { }

	// RVA: 0x3EEBF10 Offset: 0x3EEC011 VA: 0x3EEBF10
	public void set_solverVelocityIterationCount(int value) { }

	// RVA: 0x3EEBF60 Offset: 0x3EEC061 VA: 0x3EEBF60
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x485FA0 Offset: 0x4860A1 VA: 0x485FA0
	// RVA: 0x3EEC030 Offset: 0x3EEC131 VA: 0x3EEC030
	public void AddForce(Vector3 force) { }

	// RVA: 0x3EEC090 Offset: 0x3EEC191 VA: 0x3EEC090
	public void AddForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x485FB0 Offset: 0x4860B1 VA: 0x485FB0
	// RVA: 0x3EEC100 Offset: 0x3EEC201 VA: 0x3EEC100
	public void AddForce(float x, float y, float z) { }

	// RVA: 0x3EEC160 Offset: 0x3EEC261 VA: 0x3EEC160
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x485FC0 Offset: 0x4860C1 VA: 0x485FC0
	// RVA: 0x3EEC230 Offset: 0x3EEC331 VA: 0x3EEC230
	public void AddRelativeForce(Vector3 force) { }

	// RVA: 0x3EEC290 Offset: 0x3EEC391 VA: 0x3EEC290
	public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x485FD0 Offset: 0x4860D1 VA: 0x485FD0
	// RVA: 0x3EEC300 Offset: 0x3EEC401 VA: 0x3EEC300
	public void AddRelativeForce(float x, float y, float z) { }

	// RVA: 0x3EEC360 Offset: 0x3EEC461 VA: 0x3EEC360
	public void AddTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x485FE0 Offset: 0x4860E1 VA: 0x485FE0
	// RVA: 0x3EEC430 Offset: 0x3EEC531 VA: 0x3EEC430
	public void AddTorque(Vector3 torque) { }

	// RVA: 0x3EEC490 Offset: 0x3EEC591 VA: 0x3EEC490
	public void AddTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x485FF0 Offset: 0x4860F1 VA: 0x485FF0
	// RVA: 0x3EEC500 Offset: 0x3EEC601 VA: 0x3EEC500
	public void AddTorque(float x, float y, float z) { }

	// RVA: 0x3EEC560 Offset: 0x3EEC661 VA: 0x3EEC560
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486000 Offset: 0x486101 VA: 0x486000
	// RVA: 0x3EEC630 Offset: 0x3EEC731 VA: 0x3EEC630
	public void AddRelativeTorque(Vector3 torque) { }

	// RVA: 0x3EEC690 Offset: 0x3EEC791 VA: 0x3EEC690
	public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486010 Offset: 0x486111 VA: 0x486010
	// RVA: 0x3EEC700 Offset: 0x3EEC801 VA: 0x3EEC700
	public void AddRelativeTorque(float x, float y, float z) { }

	// RVA: 0x3EEC760 Offset: 0x3EEC861 VA: 0x3EEC760
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486020 Offset: 0x486121 VA: 0x486020
	// RVA: 0x3EEC850 Offset: 0x3EEC951 VA: 0x3EEC850
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	// RVA: 0x3EEC8C0 Offset: 0x3EEC9C1 VA: 0x3EEC8C0
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486030 Offset: 0x486131 VA: 0x486030
	// RVA: 0x3EEC9D0 Offset: 0x3EECAD1 VA: 0x3EEC9D0
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486040 Offset: 0x486141 VA: 0x486040
	// RVA: 0x3EECA60 Offset: 0x3EECB61 VA: 0x3EECA60
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }

	[NativeNameAttribute] // RVA: 0x486050 Offset: 0x486151 VA: 0x486050
	// RVA: 0x3EECAE0 Offset: 0x3EECBE1 VA: 0x3EECAE0
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x3EECBC0 Offset: 0x3EECCC1 VA: 0x3EECBC0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x3EECC60 Offset: 0x3EECD61 VA: 0x3EECC60
	private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) { }

	// RVA: 0x3EECDA0 Offset: 0x3EECEA1 VA: 0x3EECDA0
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486090 Offset: 0x486191 VA: 0x486090
	// RVA: 0x3EECED0 Offset: 0x3EECFD1 VA: 0x3EECED0
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4860A0 Offset: 0x4861A1 VA: 0x4860A0
	// RVA: 0x3EED000 Offset: 0x3EED101 VA: 0x3EED000
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) { }

	[NativeNameAttribute] // RVA: 0x4860B0 Offset: 0x4861B1 VA: 0x4860B0
	// RVA: 0x3EED120 Offset: 0x3EED221 VA: 0x3EED120
	private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EED210 Offset: 0x3EED311 VA: 0x3EED210
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4860F0 Offset: 0x4861F1 VA: 0x4860F0
	// RVA: 0x3EED300 Offset: 0x3EED401 VA: 0x3EED300
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486100 Offset: 0x486201 VA: 0x486100
	// RVA: 0x3EED310 Offset: 0x3EED411 VA: 0x3EED310
	public RaycastHit[] SweepTestAll(Vector3 direction) { }

	// RVA: 0x3EED320 Offset: 0x3EED421 VA: 0x3EED320
	public void .ctor() { }

	// RVA: 0x3EEA440 Offset: 0x3EEA541 VA: 0x3EEA440
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x3EEA4F0 Offset: 0x3EEA5F1 VA: 0x3EEA4F0
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x3EEA5A0 Offset: 0x3EEA6A1 VA: 0x3EEA5A0
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x3EEA650 Offset: 0x3EEA751 VA: 0x3EEA650
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x3EEACF0 Offset: 0x3EEADF1 VA: 0x3EEACF0
	private void get_centerOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x3EEADA0 Offset: 0x3EEAEA1 VA: 0x3EEADA0
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x3EEAE50 Offset: 0x3EEAF51 VA: 0x3EEAE50
	private void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x3EEAF00 Offset: 0x3EEB001 VA: 0x3EEAF00
	private void get_inertiaTensorRotation_Injected(out Quaternion ret) { }

	// RVA: 0x3EEAFB0 Offset: 0x3EEB0B1 VA: 0x3EEAFB0
	private void set_inertiaTensorRotation_Injected(ref Quaternion value) { }

	// RVA: 0x3EEB060 Offset: 0x3EEB161 VA: 0x3EEB060
	private void get_inertiaTensor_Injected(out Vector3 ret) { }

	// RVA: 0x3EEB110 Offset: 0x3EEB211 VA: 0x3EEB110
	private void set_inertiaTensor_Injected(ref Vector3 value) { }

	// RVA: 0x3EEB260 Offset: 0x3EEB361 VA: 0x3EEB260
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x3EEB310 Offset: 0x3EEB411 VA: 0x3EEB310
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x3EEB3C0 Offset: 0x3EEB4C1 VA: 0x3EEB3C0
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x3EEB470 Offset: 0x3EEB571 VA: 0x3EEB470
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x3EEB7A0 Offset: 0x3EEB8A1 VA: 0x3EEB7A0
	private void MovePosition_Injected(ref Vector3 position) { }

	// RVA: 0x3EEB850 Offset: 0x3EEB951 VA: 0x3EEB850
	private void MoveRotation_Injected(ref Quaternion rot) { }

	// RVA: 0x3EEBAA0 Offset: 0x3EEBBA1 VA: 0x3EEBAA0
	private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret) { }

	// RVA: 0x3EEBB70 Offset: 0x3EEBC71 VA: 0x3EEBB70
	private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) { }

	// RVA: 0x3EEBFD0 Offset: 0x3EEC0D1 VA: 0x3EEBFD0
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x3EEC1D0 Offset: 0x3EEC2D1 VA: 0x3EEC1D0
	private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x3EEC3D0 Offset: 0x3EEC4D1 VA: 0x3EEC3D0
	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x3EEC5D0 Offset: 0x3EEC6D1 VA: 0x3EEC5D0
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x3EEC7E0 Offset: 0x3EEC8E1 VA: 0x3EEC7E0
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

	// RVA: 0x3EEC950 Offset: 0x3EECA51 VA: 0x3EEC950
	private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x3EECB50 Offset: 0x3EECC51 VA: 0x3EECB50
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x3EECD20 Offset: 0x3EECE21 VA: 0x3EECD20
	private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x3EED1A0 Offset: 0x3EED2A1 VA: 0x3EED1A0
	private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }
}

