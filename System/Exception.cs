// Namespace: System
[ClassInterfaceAttribute] // RVA: 0x470140 Offset: 0x470241 VA: 0x470140
[ComDefaultInterfaceAttribute] // RVA: 0x470140 Offset: 0x470241 VA: 0x470140
[ComVisibleAttribute] // RVA: 0x470140 Offset: 0x470241 VA: 0x470140
[Serializable]
public class Exception : ISerializable, _Exception // TypeDefIndex: 218
{
	// Fields
	[OptionalFieldAttribute] // RVA: 0x478050 Offset: 0x478151 VA: 0x478050
	private static object s_EDILock; // 0x0
	private string _className; // 0x10
	internal string _message; // 0x18
	private IDictionary _data; // 0x20
	private Exception _innerException; // 0x28
	private string _helpURL; // 0x30
	private object _stackTrace; // 0x38
	private string _stackTraceString; // 0x40
	private string _remoteStackTraceString; // 0x48
	private int _remoteStackIndex; // 0x50
	private object _dynamicMethods; // 0x58
	internal int _HResult; // 0x60
	private string _source; // 0x68
	[OptionalFieldAttribute] // RVA: 0x478060 Offset: 0x478161 VA: 0x478060
	private SafeSerializationManager _safeSerializationManager; // 0x70
	internal StackTrace[] captured_traces; // 0x78
	private IntPtr[] native_trace_ips; // 0x80
	private const int _COMPlusExceptionCode = -532462766;

	// Properties
	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public MethodBase TargetSite { get; }
	public virtual string StackTrace { get; }
	public virtual string HelpLink { get; set; }
	public virtual string Source { get; set; }
	internal string RemoteStackTrace { get; }
	public int HResult { get; set; }
	internal bool IsTransient { get; }

	// Methods

	// RVA: 0x3B60C60 Offset: 0x3B60D61 VA: 0x3B60C60
	private void Init() { }

	// RVA: 0x3B60D10 Offset: 0x3B60E11 VA: 0x3B60D10
	public void .ctor() { }

	// RVA: 0x3B60D40 Offset: 0x3B60E41 VA: 0x3B60D40
	public void .ctor(string message) { }

	// RVA: 0x3B60D80 Offset: 0x3B60E81 VA: 0x3B60D80
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x3B60DE0 Offset: 0x3B60EE1 VA: 0x3B60DE0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3B612D0 Offset: 0x3B613D1 VA: 0x3B612D0 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x3B614A0 Offset: 0x3B615A1 VA: 0x3B614A0 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x3B61560 Offset: 0x3B61661 VA: 0x3B61560
	private static bool IsImmutableAgileException(Exception e) { }

	// RVA: 0x3B61440 Offset: 0x3B61541 VA: 0x3B61440
	private string GetClassName() { }

	// RVA: 0x3B61580 Offset: 0x3B61681 VA: 0x3B61580 Slot: 7
	public virtual Exception GetBaseException() { }

	// RVA: 0x3B615A0 Offset: 0x3B616A1 VA: 0x3B615A0 Slot: 8
	public Exception get_InnerException() { }

	// RVA: 0x3B615B0 Offset: 0x3B616B1 VA: 0x3B615B0
	private static IRuntimeMethodInfo GetMethodFromStackTrace(object stackTrace) { }

	// RVA: 0x3B615C0 Offset: 0x3B616C1 VA: 0x3B615C0 Slot: 9
	public MethodBase get_TargetSite() { }

	// RVA: 0x3B61670 Offset: 0x3B61771 VA: 0x3B61670 Slot: 10
	public virtual string get_StackTrace() { }

	// RVA: 0x3B61680 Offset: 0x3B61781 VA: 0x3B61680
	private string GetStackTrace(bool needFileInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47A720 Offset: 0x47A821 VA: 0x47A720
	// RVA: 0x3B58B90 Offset: 0x3B58C91 VA: 0x3B58B90
	internal void SetErrorCode(int hr) { }

	// RVA: 0x3B61750 Offset: 0x3B61851 VA: 0x3B61750 Slot: 11
	public virtual string get_HelpLink() { }

	// RVA: 0x3B61760 Offset: 0x3B61861 VA: 0x3B61760 Slot: 12
	public virtual void set_HelpLink(string value) { }

	// RVA: 0x3B61770 Offset: 0x3B61871 VA: 0x3B61770 Slot: 13
	public virtual string get_Source() { }

	// RVA: 0x3B61880 Offset: 0x3B61981 VA: 0x3B61880 Slot: 14
	public virtual void set_Source(string value) { }

	// RVA: 0x3B61890 Offset: 0x3B61991 VA: 0x3B61890 Slot: 3
	public override string ToString() { }

	// RVA: 0x3B618A0 Offset: 0x3B619A1 VA: 0x3B618A0
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x3B61CC0 Offset: 0x3B61DC1 VA: 0x3B61CC0
	protected void add_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x3B61CD0 Offset: 0x3B61DD1 VA: 0x3B61CD0
	protected void remove_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x3B61CE0 Offset: 0x3B61DE1 VA: 0x3B61CE0 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3B62220 Offset: 0x3B62321 VA: 0x3B62220
	internal Exception PrepForRemoting() { }

	[OnDeserializedAttribute] // RVA: 0x47A730 Offset: 0x47A831 VA: 0x47A730
	// RVA: 0x3B62A00 Offset: 0x3B62B01 VA: 0x3B62A00
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x3B62AA0 Offset: 0x3B62BA1 VA: 0x3B62AA0
	internal void InternalPreserveStackTrace() { }

	// RVA: 0x3B62B80 Offset: 0x3B62C81 VA: 0x3B62B80
	internal string get_RemoteStackTrace() { }

	// RVA: 0x3B61740 Offset: 0x3B61841 VA: 0x3B61740
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x3B62B90 Offset: 0x3B62C91 VA: 0x3B62B90
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x3B62C40 Offset: 0x3B62D41 VA: 0x3B62C40
	public int get_HResult() { }

	// RVA: 0x3B62C50 Offset: 0x3B62D51 VA: 0x3B62C50
	protected void set_HResult(int value) { }

	// RVA: 0x3B62C60 Offset: 0x3B62D61 VA: 0x3B62C60 Slot: 16
	internal virtual string InternalToString() { }

	// RVA: 0x3B61570 Offset: 0x3B61671 VA: 0x3B61570 Slot: 17
	public Type GetType() { }

	// RVA: 0x3B62C70 Offset: 0x3B62D71 VA: 0x3B62C70
	internal bool get_IsTransient() { }

	// RVA: 0x3B62CE0 Offset: 0x3B62DE1 VA: 0x3B62CE0
	private static bool nIsTransient(int hr) { }

	// RVA: 0x3B62CF0 Offset: 0x3B62DF1 VA: 0x3B62CF0
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x3B62D60 Offset: 0x3B62E61 VA: 0x3B62D60
	internal void SetMessage(string s) { }

	// RVA: 0x3B62D70 Offset: 0x3B62E71 VA: 0x3B62D70
	internal void SetStackTrace(string s) { }

	// RVA: 0x3B62D80 Offset: 0x3B62E81 VA: 0x3B62D80
	internal Exception FixRemotingException() { }

	// RVA: 0x3B62EF0 Offset: 0x3B62FF1 VA: 0x3B62EF0
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x3B62F00 Offset: 0x3B63001 VA: 0x3B62F00
	private static void .cctor() { }
}

