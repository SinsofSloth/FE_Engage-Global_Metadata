// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x2734A0 Offset: 0x2735A1 VA: 0x2734A0
public class FSM : IDisposable // TypeDefIndex: 8466
{
	// Fields
	public LinkedList<State> StateList; // 0x10

	// Properties
	public State CurrentState { get; }
	private string DebuggerDisplay { get; }

	// Methods

	// RVA: 0x2A0C980 Offset: 0x2A0CA81 VA: 0x2A0C980
	public State get_CurrentState() { }

	// RVA: 0x2A0C9F0 Offset: 0x2A0CAF1 VA: 0x2A0C9F0
	public void .ctor() { }

	// RVA: 0x2A0CA80 Offset: 0x2A0CB81 VA: 0x2A0CA80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2A0CAF0 Offset: 0x2A0CBF1 VA: 0x2A0CAF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2A0CC30 Offset: 0x2A0CD31 VA: 0x2A0CC30
	public void Update() { }

	// RVA: 0x2A0CF30 Offset: 0x2A0D031 VA: 0x2A0CF30
	public void LateUpdate() { }

	// RVA: 0x2A0CD50 Offset: 0x2A0CE51 VA: 0x2A0CD50
	private void UpdateCore(Action<State> updateFunc) { }

	// RVA: 0x2A0D050 Offset: 0x2A0D151 VA: 0x2A0D050
	public void Add(State state) { }

	// RVA: 0x2A0D0B0 Offset: 0x2A0D1B1 VA: 0x2A0D0B0
	public void AddFirst(State state) { }

	// RVA: 0x2A0D1B0 Offset: 0x2A0D2B1 VA: 0x2A0D1B0
	public void Clear() { }

	// RVA: 0x2A0D270 Offset: 0x2A0D371 VA: 0x2A0D270
	private string get_DebuggerDisplay() { }

	// RVA: 0x2A0D280 Offset: 0x2A0D381 VA: 0x2A0D280 Slot: 3
	public override string ToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A88F0 Offset: 0x2A89F1 VA: 0x2A88F0
	// RVA: 0x2A0D5F0 Offset: 0x2A0D6F1 VA: 0x2A0D5F0
	internal static string <ToString>g__to_s|14_0(StateProgress prog) { }
}

