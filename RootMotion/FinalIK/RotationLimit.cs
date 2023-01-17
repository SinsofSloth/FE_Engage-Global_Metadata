// Namespace: RootMotion.FinalIK
public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 14433
{
	// Fields
	public Vector3 axis; // 0x18
	[HideInInspector] // RVA: 0x2A3B10 Offset: 0x2A3C11 VA: 0x2A3B10
	public Quaternion defaultLocalRotation; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x2A3B20 Offset: 0x2A3C21 VA: 0x2A3B20
	private bool <defaultLocalRotationOverride>k__BackingField; // 0x34
	private bool initiated; // 0x35
	private bool applicationQuit; // 0x36
	private bool defaultLocalRotationSet; // 0x37

	// Properties
	public Vector3 secondaryAxis { get; }
	public Vector3 crossAxis { get; }
	public bool defaultLocalRotationOverride { get; set; }

	// Methods

	// RVA: 0x205BAC0 Offset: 0x205BBC1 VA: 0x205BAC0
	public void SetDefaultLocalRotation() { }

	// RVA: 0x205BB10 Offset: 0x205BC11 VA: 0x205BB10
	public void SetDefaultLocalRotation(Quaternion localRotation) { }

	// RVA: 0x205BB30 Offset: 0x205BC31 VA: 0x205BB30
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	// RVA: 0x205BCF0 Offset: 0x205BDF1 VA: 0x205BCF0
	public bool Apply() { }

	// RVA: 0x205BD60 Offset: 0x205BE61 VA: 0x205BD60
	public void Disable() { }

	// RVA: 0x205BDA0 Offset: 0x205BEA1 VA: 0x205BDA0
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x205BDB0 Offset: 0x205BEB1 VA: 0x205BDB0
	public Vector3 get_crossAxis() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D04C0 Offset: 0x2D05C1 VA: 0x2D04C0
	// RVA: 0x205BDD0 Offset: 0x205BED1 VA: 0x205BDD0
	public bool get_defaultLocalRotationOverride() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D04D0 Offset: 0x2D05D1 VA: 0x2D04D0
	// RVA: 0x205BDE0 Offset: 0x205BEE1 VA: 0x205BDE0
	private void set_defaultLocalRotationOverride(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Quaternion LimitRotation(Quaternion rotation);

	// RVA: 0x205BC50 Offset: 0x205BD51 VA: 0x205BC50
	private void Awake() { }

	// RVA: 0x205BDF0 Offset: 0x205BEF1 VA: 0x205BDF0
	private void LateUpdate() { }

	// RVA: 0x205BE50 Offset: 0x205BF51 VA: 0x205BE50
	public void LogWarning(string message) { }

	// RVA: 0x205BE90 Offset: 0x205BF91 VA: 0x205BE90
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x205BF10 Offset: 0x205C011 VA: 0x205BF10
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	// RVA: 0x205C0A0 Offset: 0x205C1A1 VA: 0x205C0A0
	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	// RVA: 0x205C110 Offset: 0x205C211 VA: 0x205C110
	protected void .ctor() { }
}

