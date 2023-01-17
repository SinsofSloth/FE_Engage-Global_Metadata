// Namespace: nn.os
public static class OS // TypeDefIndex: 14528
{
	// Methods

	// RVA: 0x23618C0 Offset: 0x23619C1 VA: 0x23618C0
	public static void SetUserExceptionHandler(UserExceptionHandler pHandler, string mapFileBinPath, byte[] stack, ulong stackSize, ref UserExceptionInfo pExceptionInfo) { }

	// RVA: 0x23618D0 Offset: 0x23619D1 VA: 0x23618D0
	public static void SetUserExceptionHandler(UserExceptionHandler pHandler, string mapFileBinPath, byte[] stack, ulong stackSize, OS.ExceptionInfoUsesType exceptionInfoUsesType) { }

	// RVA: 0x23618E0 Offset: 0x23619E1 VA: 0x23618E0
	public static void ClearUserExceptionHandler() { }

	// RVA: 0x23618F0 Offset: 0x23619F1 VA: 0x23618F0
	public static void EnableUserExceptionHandlerOnDebugging(bool isEnabled) { }

	// RVA: 0x2361900 Offset: 0x2361A01 VA: 0x2361900
	public static void Print(string text) { }

	// RVA: 0x2361910 Offset: 0x2361A11 VA: 0x2361910
	public static void RaiseException() { }
}

