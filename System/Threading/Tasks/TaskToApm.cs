// Namespace: System.Threading.Tasks
internal static class TaskToApm // TypeDefIndex: 870
{
	// Methods

	// RVA: 0x366ADE0 Offset: 0x366AEE1 VA: 0x366ADE0
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x366B040 Offset: 0x366B141 VA: 0x366B040
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2026990 Offset: 0x2026A91 VA: 0x2026990
	|-TaskToApm.End<HttpWebResponse>
	|-TaskToApm.End<object>
	|-TaskToApm.End<Stream>
	|
	|-RVA: 0x20268C0 Offset: 0x20269C1 VA: 0x20268C0
	|-TaskToApm.End<int>
	*/

	// RVA: 0x366AF20 Offset: 0x366B021 VA: 0x366AF20
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}

