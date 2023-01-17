// Namespace: System.Net
internal class WebCompletionSource // TypeDefIndex: 2582
{
	// Fields
	private TaskCompletionSource<WebCompletionSource.Result> completion; // 0x10

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1945F80 Offset: 0x1946081 VA: 0x1945F80
	public void .ctor() { }

	// RVA: 0x1946010 Offset: 0x1946111 VA: 0x1946010
	public bool TrySetCompleted() { }

	// RVA: 0x19460A0 Offset: 0x19461A1 VA: 0x19460A0
	public bool TrySetCanceled() { }

	// RVA: 0x1946170 Offset: 0x1946271 VA: 0x1946170
	public bool TrySetException(Exception error) { }

	// RVA: 0x1946220 Offset: 0x1946321 VA: 0x1946220
	public bool get_IsCompleted() { }

	// RVA: 0x1946270 Offset: 0x1946371 VA: 0x1946270
	public void ThrowOnError() { }

	[AsyncStateMachineAttribute] // RVA: 0x329A0 Offset: 0x32AA1 VA: 0x329A0
	// RVA: 0x1946300 Offset: 0x1946401 VA: 0x1946300
	public Task<bool> WaitForCompletion(bool throwOnError) { }
}

