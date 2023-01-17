// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 2330
{
	// Fields
	private readonly int nativeErrorCode; // 0x88
	private static bool s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<int, string> s_ErrorMessage; // 0x8

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x1954A10 Offset: 0x1954B11 VA: 0x1954A10
	public void .ctor() { }

	// RVA: 0x1954AE0 Offset: 0x1954BE1 VA: 0x1954AE0
	public void .ctor(int error) { }

	// RVA: 0x1954CD0 Offset: 0x1954DD1 VA: 0x1954CD0
	public void .ctor(int error, string message) { }

	// RVA: 0x1954D00 Offset: 0x1954E01 VA: 0x1954D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1954D90 Offset: 0x1954E91 VA: 0x1954D90
	public int get_NativeErrorCode() { }

	// RVA: 0x1954DA0 Offset: 0x1954EA1 VA: 0x1954DA0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1954B70 Offset: 0x1954C71 VA: 0x1954B70
	internal static string GetErrorMessage(int error) { }

	// RVA: 0x1954E80 Offset: 0x1954F81 VA: 0x1954E80
	private static void InitializeErrorMessages() { }

	// RVA: 0x1955040 Offset: 0x1955141 VA: 0x1955040
	public static void InitializeErrorMessages1() { }

	// RVA: 0x1955AC0 Offset: 0x1955BC1 VA: 0x1955AC0
	private static void .cctor() { }
}

