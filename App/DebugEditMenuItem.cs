// Namespace: App
public class DebugEditMenuItem : MenuItem // TypeDefIndex: 10125
{
	// Properties
	public virtual int Value { get; set; }
	public virtual int MinValue { get; }
	public virtual int MaxValue { get; }
	public virtual int Step { get; }
	public virtual int Fast { get; }
	public virtual bool IsLoop { get; }

	// Methods

	// RVA: 0x2E9C130 Offset: 0x2E9C231 VA: 0x2E9C130
	protected bool TickValue() { }

	// RVA: 0x2E9CE60 Offset: 0x2E9CF61 VA: 0x2E9CE60 Slot: 68
	public override void OnTick() { }

	// RVA: 0x2E9CE70 Offset: 0x2E9CF71 VA: 0x2E9CE70 Slot: 72
	public virtual bool IsSkip(int v) { }

	// RVA: 0x2E9CE80 Offset: 0x2E9CF81 VA: 0x2E9CE80 Slot: 73
	public virtual int get_Value() { }

	// RVA: 0x2E9CE90 Offset: 0x2E9CF91 VA: 0x2E9CE90 Slot: 74
	public virtual void set_Value(int value) { }

	// RVA: 0x2E9CEA0 Offset: 0x2E9CFA1 VA: 0x2E9CEA0 Slot: 75
	public virtual int get_MinValue() { }

	// RVA: 0x2E9CEB0 Offset: 0x2E9CFB1 VA: 0x2E9CEB0 Slot: 76
	public virtual int get_MaxValue() { }

	// RVA: 0x2E9CEC0 Offset: 0x2E9CFC1 VA: 0x2E9CEC0 Slot: 77
	public virtual int get_Step() { }

	// RVA: 0x2E9CED0 Offset: 0x2E9CFD1 VA: 0x2E9CED0 Slot: 78
	public virtual int get_Fast() { }

	// RVA: 0x2E9CEE0 Offset: 0x2E9CFE1 VA: 0x2E9CEE0 Slot: 79
	public virtual bool get_IsLoop() { }

	// RVA: 0x2E9CDD0 Offset: 0x2E9CED1 VA: 0x2E9CDD0
	private bool CanIncrement(int value) { }

	// RVA: 0x2E9CEF0 Offset: 0x2E9CFF1 VA: 0x2E9CEF0
	public void .ctor() { }
}

