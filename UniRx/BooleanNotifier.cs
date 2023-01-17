// Namespace: UniRx
public class BooleanNotifier : IObservable<bool> // TypeDefIndex: 6558
{
	// Fields
	private readonly Subject<bool> boolTrigger; // 0x10
	private bool boolValue; // 0x18

	// Properties
	public bool Value { get; set; }

	// Methods

	// RVA: 0x19CD9D0 Offset: 0x19CDAD1 VA: 0x19CD9D0
	public bool get_Value() { }

	// RVA: 0x19CD9E0 Offset: 0x19CDAE1 VA: 0x19CD9E0
	public void set_Value(bool value) { }

	// RVA: 0x19CDA40 Offset: 0x19CDB41 VA: 0x19CDA40
	public void .ctor(bool initialValue = False) { }

	// RVA: 0x19CDB20 Offset: 0x19CDC21 VA: 0x19CDB20
	public void TurnOn() { }

	// RVA: 0x19CDBA0 Offset: 0x19CDCA1 VA: 0x19CDBA0
	public void TurnOff() { }

	// RVA: 0x19CDC20 Offset: 0x19CDD21 VA: 0x19CDC20
	public void SwitchValue() { }

	// RVA: 0x19CDC90 Offset: 0x19CDD91 VA: 0x19CDC90 Slot: 4
	public IDisposable Subscribe(IObserver<bool> observer) { }
}

