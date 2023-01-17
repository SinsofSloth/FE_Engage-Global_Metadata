// Namespace: System.Threading
[DebuggerDisplayAttribute] // RVA: 0x4730A0 Offset: 0x4731A1 VA: 0x4730A0
[ComVisibleAttribute] // RVA: 0x4730A0 Offset: 0x4731A1 VA: 0x4730A0
public struct CancellationToken // TypeDefIndex: 731
{
	// Fields
	private CancellationTokenSource m_source; // 0x0
	private static readonly Action<object> s_ActionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x3516370 Offset: 0x3516471 VA: 0x3516370
	public static CancellationToken get_None() { }

	// RVA: 0x3516380 Offset: 0x3516481 VA: 0x3516380
	public bool get_IsCancellationRequested() { }

	// RVA: 0x35163F0 Offset: 0x35164F1 VA: 0x35163F0
	public bool get_CanBeCanceled() { }

	// RVA: 0x3516460 Offset: 0x3516561 VA: 0x3516460
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x3516470 Offset: 0x3516571 VA: 0x3516470
	private static void ActionToActionObjShunt(object obj) { }

	// RVA: 0x35164E0 Offset: 0x35165E1 VA: 0x35164E0
	public CancellationTokenRegistration Register(Action callback) { }

	// RVA: 0x3516770 Offset: 0x3516871 VA: 0x3516770
	public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext) { }

	// RVA: 0x3516870 Offset: 0x3516971 VA: 0x3516870
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext) { }

	// RVA: 0x35168C0 Offset: 0x35169C1 VA: 0x35168C0
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x35165E0 Offset: 0x35166E1 VA: 0x35165E0
	private CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x3516CF0 Offset: 0x3516DF1 VA: 0x3516CF0
	public bool Equals(CancellationToken other) { }

	// RVA: 0x3516EE0 Offset: 0x3516FE1 VA: 0x3516EE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3516F70 Offset: 0x3517071 VA: 0x3516F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3517020 Offset: 0x3517121 VA: 0x3517020
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x3517050 Offset: 0x3517151 VA: 0x3517050
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x3517080 Offset: 0x3517181 VA: 0x3517080
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x3517130 Offset: 0x3517231 VA: 0x3517130
	internal void ThrowIfSourceDisposed() { }

	// RVA: 0x35170C0 Offset: 0x35171C1 VA: 0x35170C0
	private void ThrowOperationCanceledException() { }

	// RVA: 0x35171A0 Offset: 0x35172A1 VA: 0x35171A0
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x3517200 Offset: 0x3517301 VA: 0x3517200
	private static void .cctor() { }
}

