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

