// Namespace: UnityEngine.XR
[UsedByNativeCodeAttribute] // RVA: 0x58C10 Offset: 0x58D11 VA: 0x58C10
[NativeConditionalAttribute] // RVA: 0x58C10 Offset: 0x58D11 VA: 0x58C10
[StaticAccessorAttribute] // RVA: 0x58C10 Offset: 0x58D11 VA: 0x58C10
[NativeHeaderAttribute] // RVA: 0x58C10 Offset: 0x58D11 VA: 0x58C10
public class InputDevices // TypeDefIndex: 4870
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x59400 Offset: 0x59501 VA: 0x59400
	[CompilerGeneratedAttribute] // RVA: 0x59400 Offset: 0x59501 VA: 0x59400
	private static Action<InputDevice> deviceConnected; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x59440 Offset: 0x59541 VA: 0x59440
	[DebuggerBrowsableAttribute] // RVA: 0x59440 Offset: 0x59541 VA: 0x59440
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x59480 Offset: 0x59581 VA: 0x59480
	[DebuggerBrowsableAttribute] // RVA: 0x59480 Offset: 0x59581 VA: 0x59480
	private static Action<InputDevice> deviceConfigChanged; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x596D0 Offset: 0x597D1 VA: 0x596D0
	// RVA: 0x1C4EA80 Offset: 0x1C4EB81 VA: 0x1C4EA80
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
}

