// Namespace: System
[DebuggerDisplayAttribute] // RVA: 0x46F860 Offset: 0x46F961 VA: 0x46F860
[Serializable]
public class AggregateException : Exception // TypeDefIndex: 127
{
	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x88

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }

	// Methods

	// RVA: 0x355B820 Offset: 0x355B921 VA: 0x355B820
	public void .ctor() { }

	// RVA: 0x355B930 Offset: 0x355BA31 VA: 0x355B930
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x355BA70 Offset: 0x355BB71 VA: 0x355BA70
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x355B9A0 Offset: 0x355BAA1 VA: 0x355B9A0
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x355BAE0 Offset: 0x355BBE1 VA: 0x355BAE0
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x355BAF0 Offset: 0x355BBF1 VA: 0x355BAF0
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x355BEE0 Offset: 0x355BFE1 VA: 0x355BEE0
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x355BF50 Offset: 0x355C051 VA: 0x355BF50
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x355C020 Offset: 0x355C121 VA: 0x355C020
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x355C470 Offset: 0x355C571 VA: 0x355C470
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x355C680 Offset: 0x355C781 VA: 0x355C680 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x355C820 Offset: 0x355C921 VA: 0x355C820 Slot: 7
	public override Exception GetBaseException() { }

	// RVA: 0x355C8F0 Offset: 0x355C9F1 VA: 0x355C8F0
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x355C900 Offset: 0x355CA01 VA: 0x355C900
	public AggregateException Flatten() { }

	// RVA: 0x355CC00 Offset: 0x355CD01 VA: 0x355CC00 Slot: 3
	public override string ToString() { }
}

