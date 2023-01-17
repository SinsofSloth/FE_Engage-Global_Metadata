// Namespace: 
public enum CinemachineCore.Stage // TypeDefIndex: 5824
{
	// Fields
	public int value__; // 0x0
	public const CinemachineCore.Stage Body = 0;
	public const CinemachineCore.Stage Aim = 1;
	public const CinemachineCore.Stage Noise = 2;
	public const CinemachineCore.Stage Finalize = 3;
}

// Namespace: 
public sealed class CinemachineCore.AxisInputDelegate : MulticastDelegate // TypeDefIndex: 5825
{
	// Methods

	// RVA: 0x1A76EB0 Offset: 0x1A76FB1 VA: 0x1A76EB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A88B60 Offset: 0x1A88C61 VA: 0x1A88B60 Slot: 13
	public virtual float Invoke(string axisName) { }

	// RVA: 0x1A88EC0 Offset: 0x1A88FC1 VA: 0x1A88EC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string axisName, AsyncCallback callback, object object) { }

	// RVA: 0x1A88EF0 Offset: 0x1A88FF1 VA: 0x1A88EF0 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class CinemachineCore.GetBlendOverrideDelegate : MulticastDelegate // TypeDefIndex: 5826
{
	// Methods

	// RVA: 0x1A88F20 Offset: 0x1A89021 VA: 0x1A88F20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A88F40 Offset: 0x1A89041 VA: 0x1A88F40 Slot: 13
	public virtual CinemachineBlendDefinition Invoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner) { }

	// RVA: 0x1A89320 Offset: 0x1A89421 VA: 0x1A89320 Slot: 14
	public virtual IAsyncResult BeginInvoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner, AsyncCallback callback, object object) { }

	// RVA: 0x1A893D0 Offset: 0x1A894D1 VA: 0x1A893D0 Slot: 15
	public virtual CinemachineBlendDefinition EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class CinemachineCore.UpdateStatus // TypeDefIndex: 5827
{
	// Fields
	public int lastUpdateFrame; // 0x10
	public int lastUpdateFixedFrame; // 0x14
	public UpdateTracker.UpdateClock lastUpdateMode; // 0x18
	public float lastUpdateDeltaTime; // 0x1C

	// Methods

	// RVA: 0x1A89400 Offset: 0x1A89501 VA: 0x1A89400
	public void .ctor() { }
}

// Namespace: 
internal enum CinemachineCore.UpdateFilter // TypeDefIndex: 5828
{
	// Fields
	public int value__; // 0x0
	public const CinemachineCore.UpdateFilter Fixed = 0;
	public const CinemachineCore.UpdateFilter Late = 1;
	public const CinemachineCore.UpdateFilter Smart = 8;
	public const CinemachineCore.UpdateFilter SmartFixed = 8;
	public const CinemachineCore.UpdateFilter SmartLate = 9;
}

