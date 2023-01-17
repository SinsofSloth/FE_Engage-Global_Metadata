// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B5C0 Offset: 0x1B6C1 VA: 0x1B5C0
public enum CinemachineOrbitalTransposer.Heading.HeadingDefinition // TypeDefIndex: 5794
{
	// Fields
	public int value__; // 0x0
	public const CinemachineOrbitalTransposer.Heading.HeadingDefinition PositionDelta = 0;
	public const CinemachineOrbitalTransposer.Heading.HeadingDefinition Velocity = 1;
	public const CinemachineOrbitalTransposer.Heading.HeadingDefinition TargetForward = 2;
	public const CinemachineOrbitalTransposer.Heading.HeadingDefinition WorldForward = 3;
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B5A0 Offset: 0x1B6A1 VA: 0x1B5A0
[Serializable]
public struct CinemachineOrbitalTransposer.Heading // TypeDefIndex: 5795
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x20420 Offset: 0x20521 VA: 0x20420
	[TooltipAttribute] // RVA: 0x20420 Offset: 0x20521 VA: 0x20420
	public CinemachineOrbitalTransposer.Heading.HeadingDefinition m_Definition; // 0x0
	[TooltipAttribute] // RVA: 0x20480 Offset: 0x20581 VA: 0x20480
	[RangeAttribute] // RVA: 0x20480 Offset: 0x20581 VA: 0x20480
	public int m_VelocityFilterStrength; // 0x4
	[RangeAttribute] // RVA: 0x204E0 Offset: 0x205E1 VA: 0x204E0
	[FormerlySerializedAsAttribute] // RVA: 0x204E0 Offset: 0x205E1 VA: 0x204E0
	[TooltipAttribute] // RVA: 0x204E0 Offset: 0x205E1 VA: 0x204E0
	public float m_Bias; // 0x8

	// Methods

	// RVA: 0x1A8AF10 Offset: 0x1A8B011 VA: 0x1A8AF10
	public void .ctor(CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias) { }
}

// Namespace: 
internal sealed class CinemachineOrbitalTransposer.UpdateHeadingDelegate : MulticastDelegate // TypeDefIndex: 5796
{
	// Methods

	// RVA: 0x1A8AF20 Offset: 0x1A8B021 VA: 0x1A8AF20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A8AF40 Offset: 0x1A8B041 VA: 0x1A8AF40 Slot: 13
	public virtual float Invoke(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	// RVA: 0x1A8B320 Offset: 0x1A8B421 VA: 0x1A8B320 Slot: 14
	public virtual IAsyncResult BeginInvoke(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up, AsyncCallback callback, object object) { }

	// RVA: 0x1A8B3F0 Offset: 0x1A8B4F1 VA: 0x1A8B3F0 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x1B5E0 Offset: 0x1B6E1 VA: 0x1B5E0
[Serializable]
private sealed class CinemachineOrbitalTransposer.<>c // TypeDefIndex: 5797
{
	// Fields
	public static readonly CinemachineOrbitalTransposer.<>c <>9; // 0x0
	public static CinemachineOrbitalTransposer.UpdateHeadingDelegate <>9__34_0; // 0x8

	// Methods

	// RVA: 0x1A8ADB0 Offset: 0x1A8AEB1 VA: 0x1A8ADB0
	private static void .cctor() { }

	// RVA: 0x1A8AE20 Offset: 0x1A8AF21 VA: 0x1A8AE20
	public void .ctor() { }

	// RVA: 0x1A8AE30 Offset: 0x1A8AF31 VA: 0x1A8AE30
	internal float <.ctor>b__34_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }
}

