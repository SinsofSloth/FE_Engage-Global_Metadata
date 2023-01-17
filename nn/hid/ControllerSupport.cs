// Namespace: nn.hid
public static class ControllerSupport // TypeDefIndex: 14622
{
	// Fields
	public const int ExplainTextMaxLength = 32;
	public const int Utf8ByteSize = 4;
	public const int ExplainTextMaxBufferSize = 129;
	public const int ControllerSupportPlayerCountMax = 8;

	// Properties
	public static ErrorRange ResultCanceled { get; }
	public static ErrorRange ResultNotSupportedNpadStyle { get; }

	// Methods

	// RVA: 0x23B96B0 Offset: 0x23B97B1 VA: 0x23B96B0
	public static extern Result Show(ControllerSupportArg showControllerSupportArg) { }

	// RVA: 0x23B97B0 Offset: 0x23B98B1 VA: 0x23B97B0
	public static extern Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg) { }

	// RVA: 0x23B98C0 Offset: 0x23B99C1 VA: 0x23B98C0
	public static extern void SetExplainText(ref ControllerSupportArg pOutControllerSupportArg, string pStr, NpadId npadId) { }

	// RVA: 0x23B9A30 Offset: 0x23B9B31 VA: 0x23B9A30
	public static Result Show(ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads) { }

	// RVA: 0x23B9C40 Offset: 0x23B9D41 VA: 0x23B9C40
	public static Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads) { }

	// RVA: 0x23B9E50 Offset: 0x23B9F51 VA: 0x23B9E50
	public static ErrorRange get_ResultCanceled() { }

	// RVA: 0x23B9E90 Offset: 0x23B9F91 VA: 0x23B9E90
	public static ErrorRange get_ResultNotSupportedNpadStyle() { }
}

