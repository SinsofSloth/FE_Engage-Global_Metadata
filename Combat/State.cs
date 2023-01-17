// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x2734F0 Offset: 0x2735F1 VA: 0x2734F0
public abstract class State : IDisposable // TypeDefIndex: 8467
{
	// Fields
	public StateProgress progress; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual bool AbortByInterrupt { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: 0x291D5B0 Offset: 0x291D6B1 VA: 0x291D5B0
	public void .ctor() { }

	// RVA: 0x291D5E0 Offset: 0x291D6E1 VA: 0x291D5E0 Slot: 6
	public virtual void OnEnter() { }

	// RVA: 0x291D5F0 Offset: 0x291D6F1 VA: 0x291D5F0 Slot: 7
	public virtual void OnUpdate() { }

	// RVA: 0x291D600 Offset: 0x291D701 VA: 0x291D600 Slot: 8
	public virtual void OnLateUpdate() { }

	// RVA: 0x291D610 Offset: 0x291D711 VA: 0x291D610 Slot: 9
	public virtual void OnExit() { }

	// RVA: 0x291D620 Offset: 0x291D721 VA: 0x291D620 Slot: 10
	public virtual void Dispose() { }

	// RVA: 0x291D630 Offset: 0x291D731 VA: 0x291D630
	public void Exit() { }

	// RVA: 0x291D650 Offset: 0x291D751 VA: 0x291D650 Slot: 11
	public virtual bool get_AbortByInterrupt() { }
}

