// Namespace: App
public class GameCalculatorCommand : CalculatorCommand // TypeDefIndex: 9545
{
	// Fields
	private int m_Index; // 0x18
	private string m_Header; // 0x20
	private bool m_IsReverse; // 0x28

	// Properties
	public override string Header { get; }

	// Methods

	// RVA: 0x26A2340 Offset: 0x26A2441 VA: 0x26A2340 Slot: 30
	protected virtual float GetImpl(Unit unit) { }

	// RVA: 0x26A2350 Offset: 0x26A2451 VA: 0x26A2350 Slot: 31
	protected virtual float GetImpl(BattleInfoSide side) { }

	// RVA: 0x26A2380 Offset: 0x26A2481 VA: 0x26A2380
	private float TryGetImpl(Unit unit) { }

	// RVA: 0x26A23A0 Offset: 0x26A24A1 VA: 0x26A23A0 Slot: 32
	protected virtual void SetImpl(Unit unit, float value) { }

	// RVA: 0x26A23B0 Offset: 0x26A24B1 VA: 0x26A23B0 Slot: 33
	protected virtual void SetImpl(BattleInfoSide side, float value) { }

	// RVA: 0x26A23D0 Offset: 0x26A24D1 VA: 0x26A23D0
	private void TrySetImpl(Unit unit, float value) { }

	// RVA: 0x26A23F0 Offset: 0x26A24F1 VA: 0x26A23F0 Slot: 34
	protected virtual float FuncImpl(Unit unit, List<float> args) { }

	// RVA: 0x26A2400 Offset: 0x26A2501 VA: 0x26A2400 Slot: 35
	protected virtual float FuncImpl(BattleInfoSide side, List<float> args) { }

	// RVA: 0x26A2430 Offset: 0x26A2531 VA: 0x26A2430
	private float TryFuncImpl(Unit unit, List<float> args) { }

	// RVA: 0x26A2450 Offset: 0x26A2551 VA: 0x26A2450 Slot: 36
	protected virtual float FuncImpl(Unit unit, string arg) { }

	// RVA: 0x26A2460 Offset: 0x26A2561 VA: 0x26A2460 Slot: 37
	protected virtual float FuncImpl(BattleInfoSide side, string arg) { }

	// RVA: 0x26A2490 Offset: 0x26A2591 VA: 0x26A2490
	private float TryFuncImpl(Unit unit, string arg) { }

	// RVA: 0x26A24B0 Offset: 0x26A25B1 VA: 0x26A24B0 Slot: 38
	protected virtual void AddImpl(Unit unit, float value) { }

	// RVA: 0x26A2510 Offset: 0x26A2611 VA: 0x26A2510 Slot: 39
	protected virtual void AddImpl(BattleInfoSide side, float value) { }

	// RVA: 0x26A2570 Offset: 0x26A2671 VA: 0x26A2570 Slot: 40
	protected virtual void ScaleImpl(Unit unit, float value) { }

	// RVA: 0x26A25D0 Offset: 0x26A26D1 VA: 0x26A25D0 Slot: 41
	protected virtual void ScaleImpl(BattleInfoSide side, float value) { }

	// RVA: 0x26A2630 Offset: 0x26A2731 VA: 0x26A2630 Slot: 42
	protected virtual float GetInvalid() { }

	// RVA: 0x26A2640 Offset: 0x26A2741 VA: 0x26A2640 Slot: 10
	public override float Get(object obj) { }

	// RVA: 0x26A2740 Offset: 0x26A2841 VA: 0x26A2740 Slot: 11
	public override float Get(object obj1, object obj2) { }

	// RVA: 0x26A2780 Offset: 0x26A2881 VA: 0x26A2780 Slot: 13
	public override void Set(float value, object obj) { }

	// RVA: 0x26A2890 Offset: 0x26A2991 VA: 0x26A2890 Slot: 14
	public override void Set(float value, object obj1, object obj2) { }

	// RVA: 0x26A28D0 Offset: 0x26A29D1 VA: 0x26A28D0 Slot: 25
	public override float Func(List<float> args, object obj) { }

	// RVA: 0x26A29E0 Offset: 0x26A2AE1 VA: 0x26A29E0 Slot: 26
	public override float Func(List<float> args, object obj1, object obj2) { }

	// RVA: 0x26A2A20 Offset: 0x26A2B21 VA: 0x26A2A20 Slot: 28
	public override float Func(string arg, object obj) { }

	// RVA: 0x26A2B30 Offset: 0x26A2C31 VA: 0x26A2B30 Slot: 29
	public override float Func(string arg, object obj1, object obj2) { }

	// RVA: 0x26A2B70 Offset: 0x26A2C71 VA: 0x26A2B70 Slot: 16
	public override void Add(float value, object obj) { }

	// RVA: 0x26A2C80 Offset: 0x26A2D81 VA: 0x26A2C80 Slot: 17
	public override void Add(float value, object obj1, object obj2) { }

	// RVA: 0x26A2CC0 Offset: 0x26A2DC1 VA: 0x26A2CC0 Slot: 19
	public override void Scale(float value, object obj) { }

	// RVA: 0x26A2DD0 Offset: 0x26A2ED1 VA: 0x26A2DD0 Slot: 20
	public override void Scale(float value, object obj1, object obj2) { }

	// RVA: 0x26A2E10 Offset: 0x26A2F11 VA: 0x26A2E10 Slot: 5
	public override string get_Header() { }

	// RVA: 0x26A2E20 Offset: 0x26A2F21 VA: 0x26A2E20
	public GameCalculatorCommand Reverse() { }

	// RVA: 0x26A2E90 Offset: 0x26A2F91 VA: 0x26A2E90
	public GameCalculatorCommand Swap() { }

	// RVA: 0x26A2F20 Offset: 0x26A3021 VA: 0x26A2F20
	public bool IsReverse() { }

	// RVA: 0x26A2F30 Offset: 0x26A3031 VA: 0x26A2F30
	public int GetIndex() { }

	// RVA: 0x26A2F40 Offset: 0x26A3041 VA: 0x26A2F40 Slot: 43
	public virtual bool IsVisible() { }

	// RVA: 0x26A2F50 Offset: 0x26A3051 VA: 0x26A2F50
	public void .ctor() { }
}

