// Namespace: System.Runtime.ExceptionServices
public sealed class ExceptionDispatchInfo // TypeDefIndex: 1227
{
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0x3B62F80 Offset: 0x3B63081 VA: 0x3B62F80
	private void .ctor(Exception exception) { }

	// RVA: 0x3B630D0 Offset: 0x3B631D1 VA: 0x3B630D0
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0x3B630E0 Offset: 0x3B631E1 VA: 0x3B630E0
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x3B631A0 Offset: 0x3B632A1 VA: 0x3B631A0
	public Exception get_SourceException() { }

	// RVA: 0x3B631B0 Offset: 0x3B632B1 VA: 0x3B631B0
	public void Throw() { }

	// RVA: 0x3B631F0 Offset: 0x3B632F1 VA: 0x3B631F0
	public static void Throw(Exception source) { }
}

