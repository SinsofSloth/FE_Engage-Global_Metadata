// Namespace: 
private class MapAction.ProcRouteMove.Spline // TypeDefIndex: 11890
{
	// Fields
	public const int CurveMax = 4;
	public Vector3 From; // 0x10
	public Vector3 To; // 0x1C
	public Vector3[] Curves; // 0x28

	// Methods

	// RVA: 0x21E2CB0 Offset: 0x21E2DB1 VA: 0x21E2CB0
	public void .ctor() { }
}

// Namespace: 
public abstract class MapAction.ProcUnitAction : ProcInst // TypeDefIndex: 11892
{
	// Fields
	protected UnitActor m_Actor; // 0x70
	protected Vector3 m_From; // 0x78
	protected Vector3 m_To; // 0x84
	protected float m_Dist; // 0x90
	protected float m_Range; // 0x94
	protected float m_Time; // 0x98

	// Properties
	protected override bool CanWaitSkip { get; }
	protected virtual float Speed { get; }
	protected Unit Unit { get; }

	// Methods

	// RVA: 0x1D334A0 Offset: 0x1D335A1 VA: 0x1D334A0 Slot: 4
	protected override bool get_CanWaitSkip() { }

	// RVA: 0x1D334B0 Offset: 0x1D335B1 VA: 0x1D334B0 Slot: 18
	protected virtual float get_Speed() { }

	// RVA: 0x1D2F3E0 Offset: 0x1D2F4E1 VA: 0x1D2F3E0
	protected void .ctor(UnitActor actor) { }

	// RVA: 0x1D311E0 Offset: 0x1D312E1 VA: 0x1D311E0
	protected void .ctor(UnitActor actor, int toX, int toZ) { }

	// RVA: 0x1D334C0 Offset: 0x1D335C1 VA: 0x1D334C0
	protected void CalcRange(float dx, float dz) { }

	// RVA: 0x1D332C0 Offset: 0x1D333C1 VA: 0x1D332C0
	protected bool AddTime() { }

	// RVA: 0x1D333A0 Offset: 0x1D334A1 VA: 0x1D333A0
	protected float GetRatio() { }

	// RVA: 0x1D32040 Offset: 0x1D32141 VA: 0x1D32040 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1D321D0 Offset: 0x1D322D1 VA: 0x1D321D0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1D335A0 Offset: 0x1D336A1 VA: 0x1D335A0
	protected Unit get_Unit() { }
}

// Namespace: 
internal class MapAction.ProcWarp : MapAction.ProcUnitAction // TypeDefIndex: 11894
{
	// Fields
	private const float FadeTime = 0.25;

	// Methods

	// RVA: 0x1D335B0 Offset: 0x1D336B1 VA: 0x1D335B0
	private void .ctor(UnitActor actor, int toX, int toZ) { }

	// RVA: 0x1D335C0 Offset: 0x1D336C1 VA: 0x1D335C0
	private static string GetWarpOutEffect(Unit unit) { }

	// RVA: 0x1D33680 Offset: 0x1D33781 VA: 0x1D33680
	private static string GetWarpInEffect(Unit unit) { }

	// RVA: 0x1D33790 Offset: 0x1D33891 VA: 0x1D33790
	private void WarpOut() { }

	// RVA: 0x1D35060 Offset: 0x1D35161 VA: 0x1D35060
	private void WarpIn() { }

	// RVA: 0x1D368B0 Offset: 0x1D369B1 VA: 0x1D368B0
	private void FadeOut() { }

	// RVA: 0x1D368F0 Offset: 0x1D369F1 VA: 0x1D368F0
	private void FadeIn() { }

	// RVA: 0x1D36930 Offset: 0x1D36A31 VA: 0x1D36930
	private void WaitTick() { }

	// RVA: 0x1D369D0 Offset: 0x1D36AD1 VA: 0x1D369D0
	public static void WarpBind(ProcInst super, UnitActor actor, int toX, int toZ) { }

	// RVA: 0x1D36E00 Offset: 0x1D36F01 VA: 0x1D36E00
	public static void WarpInBind(ProcInst super, UnitActor actor, int toX, int toZ) { }

	// RVA: 0x1D370F0 Offset: 0x1D371F1 VA: 0x1D370F0
	public static void WarpOutBind(ProcInst super, UnitActor actor, int toX, int toZ) { }
}

// Namespace: 
internal class MapAction.ProcRevive : MapAction.ProcUnitAction // TypeDefIndex: 11896
{
	// Fields
	private const float FadeTime = 0.4;

	// Methods

	// RVA: 0x1D2F380 Offset: 0x1D2F481 VA: 0x1D2F380
	private void .ctor(UnitActor actor) { }

	// RVA: 0x1D2F440 Offset: 0x1D2F541 VA: 0x1D2F440
	private void Executed() { }

	// RVA: 0x1D2F490 Offset: 0x1D2F591 VA: 0x1D2F490
	public static void CreateBind(ProcInst super, UnitActor actor) { }
}

// Namespace: 
internal class MapAction.ProcBounce : MapAction.ProcUnitAction // TypeDefIndex: 11898
{
	// Fields
	private bool m_impacted; // 0x9C
	private Vector3 m_Hit; // 0xA0

	// Properties
	protected override float Speed { get; }

	// Methods

	// RVA: 0x223F0A0 Offset: 0x223F1A1 VA: 0x223F0A0
	private void .ctor(UnitActor actor, int dx, int dz, int distance) { }

	// RVA: 0x223F150 Offset: 0x223F251 VA: 0x223F150 Slot: 18
	protected override float get_Speed() { }

	// RVA: 0x223F160 Offset: 0x223F261 VA: 0x223F160 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x223F2F0 Offset: 0x223F3F1 VA: 0x223F2F0
	public static void CreateBind(ProcInst super, UnitActor actor, int dx, int dz, int distance) { }
}

// Namespace: 
internal class MapAction.ProcJump : MapAction.ProcUnitAction // TypeDefIndex: 11900
{
	// Methods

	// RVA: 0x223FB00 Offset: 0x223FC01 VA: 0x223FB00
	private void .ctor(UnitActor actor, int toX, int toZ, float range = 1) { }

	// RVA: 0x223FB40 Offset: 0x223FC41 VA: 0x223FB40 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x223FCB0 Offset: 0x223FDB1 VA: 0x223FCB0
	public static void Create(ProcInst super, UnitActor actor, int toX, int toZ, float range) { }
}

