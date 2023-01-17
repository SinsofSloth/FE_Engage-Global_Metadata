// Namespace: 
[NativeHeaderAttribute] // RVA: 0x58E90 Offset: 0x58F91 VA: 0x58E90
public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 4875
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public bool nativeBlitAvailable; // 0x8
	public bool nativeBlitInvalidStates; // 0x9
	public int blitParamsCount; // 0xC

	// Methods

	[NativeMethodAttribute] // RVA: 0x59A20 Offset: 0x59B21 VA: 0x59A20
	[NativeConditionalAttribute] // RVA: 0x59A20 Offset: 0x59B21 VA: 0x59A20
	// RVA: 0x1C50110 Offset: 0x1C50211 VA: 0x1C50110
	public void GetBlitParameter(int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter) { }

	// RVA: 0x1C50170 Offset: 0x1C50271 VA: 0x1C50170
	private static void GetBlitParameter_Injected(ref XRDisplaySubsystem.XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter) { }
}

