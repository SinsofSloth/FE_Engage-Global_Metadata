// Namespace: 
public class Debug // TypeDefIndex: 7658
{
	// Properties
	public static ILogger unityLogger { get; }

	// Methods

	[ConditionalAttribute] // RVA: 0x2A66D0 Offset: 0x2A67D1 VA: 0x2A66D0
	// RVA: 0x2E9AD30 Offset: 0x2E9AE31 VA: 0x2E9AD30
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0x2A6710 Offset: 0x2A6811 VA: 0x2A6710
	// RVA: 0x2E9AD40 Offset: 0x2E9AE41 VA: 0x2E9AD40
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x2A6750 Offset: 0x2A6851 VA: 0x2A6750
	// RVA: 0x2E9AD50 Offset: 0x2E9AE51 VA: 0x2E9AD50
	public static void AssertFormat(bool condition, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x2A6790 Offset: 0x2A6891 VA: 0x2A6790
	// RVA: 0x2E9AD60 Offset: 0x2E9AE61 VA: 0x2E9AD60
	public static void LogAssertion(object message, Object context) { }

	[ConditionalAttribute] // RVA: 0x2A67D0 Offset: 0x2A68D1 VA: 0x2A67D0
	// RVA: 0x2E9AD70 Offset: 0x2E9AE71 VA: 0x2E9AD70
	public static void LogAssertion(object message) { }

	[ConditionalAttribute] // RVA: 0x2A6810 Offset: 0x2A6911 VA: 0x2A6810
	// RVA: 0x2E9AD80 Offset: 0x2E9AE81 VA: 0x2E9AD80
	public static void LogAssertionFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x2A6850 Offset: 0x2A6951 VA: 0x2A6850
	// RVA: 0x2E9AD90 Offset: 0x2E9AE91 VA: 0x2E9AD90
	public static void LogAssertionFormat(string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x2A6890 Offset: 0x2A6991 VA: 0x2A6890
	// RVA: 0x2E9ADA0 Offset: 0x2E9AEA1 VA: 0x2E9ADA0
	public static void LogWarning(object message, Object context) { }

	[ConditionalAttribute] // RVA: 0x2A68D0 Offset: 0x2A69D1 VA: 0x2A68D0
	// RVA: 0x2E9ADB0 Offset: 0x2E9AEB1 VA: 0x2E9ADB0
	public static void LogWarning(object message) { }

	[ConditionalAttribute] // RVA: 0x2A6910 Offset: 0x2A6A11 VA: 0x2A6910
	// RVA: 0x2E9ADC0 Offset: 0x2E9AEC1 VA: 0x2E9ADC0
	public static void LogWarningFormat(string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x2A6950 Offset: 0x2A6A51 VA: 0x2A6950
	// RVA: 0x2E9ADD0 Offset: 0x2E9AED1 VA: 0x2E9ADD0
	public static void Log(object message) { }

	[ConditionalAttribute] // RVA: 0x2A6990 Offset: 0x2A6A91 VA: 0x2A6990
	// RVA: 0x2E9ADE0 Offset: 0x2E9AEE1 VA: 0x2E9ADE0
	public static void Log(object message, Object context) { }

	[ConditionalAttribute] // RVA: 0x2A69D0 Offset: 0x2A6AD1 VA: 0x2A69D0
	// RVA: 0x2E9ADF0 Offset: 0x2E9AEF1 VA: 0x2E9ADF0
	public static void LogFormat(string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x2A6A10 Offset: 0x2A6B11 VA: 0x2A6A10
	// RVA: 0x2E9AE00 Offset: 0x2E9AF01 VA: 0x2E9AE00
	public static void LogError(object message) { }

	[ConditionalAttribute] // RVA: 0x2A6A50 Offset: 0x2A6B51 VA: 0x2A6A50
	// RVA: 0x2E9AE10 Offset: 0x2E9AF11 VA: 0x2E9AE10
	public static void LogError(object message, Object context) { }

	[ConditionalAttribute] // RVA: 0x2A6A90 Offset: 0x2A6B91 VA: 0x2A6A90
	// RVA: 0x2E9AE20 Offset: 0x2E9AF21 VA: 0x2E9AE20
	public static void LogErrorFormat(string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x2A6AD0 Offset: 0x2A6BD1 VA: 0x2A6AD0
	// RVA: 0x2E9AE30 Offset: 0x2E9AF31 VA: 0x2E9AE30
	public static void LogException(Exception exception, Object context) { }

	[ConditionalAttribute] // RVA: 0x2A6B10 Offset: 0x2A6C11 VA: 0x2A6B10
	// RVA: 0x2E9AE40 Offset: 0x2E9AF41 VA: 0x2E9AE40
	public static void LogException(Exception exception) { }

	[ConditionalAttribute] // RVA: 0x2A6B50 Offset: 0x2A6C51 VA: 0x2A6B50
	// RVA: 0x2E9AE50 Offset: 0x2E9AF51 VA: 0x2E9AE50
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ConditionalAttribute] // RVA: 0x2A6B90 Offset: 0x2A6C91 VA: 0x2A6B90
	// RVA: 0x2E9AE60 Offset: 0x2E9AF61 VA: 0x2E9AE60
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[ConditionalAttribute] // RVA: 0x2A6BD0 Offset: 0x2A6CD1 VA: 0x2A6BD0
	// RVA: 0x2E9AE70 Offset: 0x2E9AF71 VA: 0x2E9AE70
	public static void DrawLine(Vector3 start, Vector3 end) { }

	[ConditionalAttribute] // RVA: 0x2A6C10 Offset: 0x2A6D11 VA: 0x2A6C10
	// RVA: 0x2E9AE80 Offset: 0x2E9AF81 VA: 0x2E9AE80
	public static void DrawRay(Vector3 start, Vector3 dir) { }

	[ConditionalAttribute] // RVA: 0x2A6C50 Offset: 0x2A6D51 VA: 0x2A6C50
	// RVA: 0x2E9AE90 Offset: 0x2E9AF91 VA: 0x2E9AE90
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	[ConditionalAttribute] // RVA: 0x2A6C90 Offset: 0x2A6D91 VA: 0x2A6C90
	// RVA: 0x2E9AEA0 Offset: 0x2E9AFA1 VA: 0x2E9AEA0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ConditionalAttribute] // RVA: 0x2A6CD0 Offset: 0x2A6DD1 VA: 0x2A6CD0
	// RVA: 0x2E9AEB0 Offset: 0x2E9AFB1 VA: 0x2E9AEB0
	public static void DebugBreak() { }

	// RVA: 0x2E9AEC0 Offset: 0x2E9AFC1 VA: 0x2E9AEC0
	public static ILogger get_unityLogger() { }

	// RVA: 0x2E9AF80 Offset: 0x2E9B081 VA: 0x2E9AF80
	public void .ctor() { }
}

