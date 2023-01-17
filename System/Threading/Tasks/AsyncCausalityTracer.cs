// Namespace: System.Threading.Tasks
[FriendAccessAllowedAttribute] // RVA: 0x473750 Offset: 0x473851 VA: 0x473750
internal static class AsyncCausalityTracer // TypeDefIndex: 819
{
	// Properties
	[FriendAccessAllowedAttribute] // RVA: 0x47E100 Offset: 0x47E201 VA: 0x47E100
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x47CD70 Offset: 0x47CE71 VA: 0x47CD70
	// RVA: 0x3569650 Offset: 0x3569751 VA: 0x3569650
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowedAttribute] // RVA: 0x47CD80 Offset: 0x47CE81 VA: 0x47CD80
	// RVA: 0x3569660 Offset: 0x3569761 VA: 0x3569660
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47CD90 Offset: 0x47CE91 VA: 0x47CD90
	// RVA: 0x3569670 Offset: 0x3569771 VA: 0x3569670
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x3569680 Offset: 0x3569781 VA: 0x3569680
	internal static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation) { }

	// RVA: 0x3569690 Offset: 0x3569791 VA: 0x3569690
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x35696A0 Offset: 0x35697A1 VA: 0x35696A0
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }
}

