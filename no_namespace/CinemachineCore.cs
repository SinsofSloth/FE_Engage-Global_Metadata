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

