// Namespace: App
public class EventSequence : StackProcInst<EventSequence> // TypeDefIndex: 10251
{
	// Fields
	private EventSequence.Coroutine m_Current; // 0x70
	private List<EventSequence.Coroutine> m_Coroutines; // 0x78
	private bool m_BindingUI; // 0x80

	// Methods

	// RVA: 0x27FB950 Offset: 0x27FBA51 VA: 0x27FB950 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x27FB9E0 Offset: 0x27FBAE1 VA: 0x27FB9E0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x27FBBF0 Offset: 0x27FBCF1 VA: 0x27FBBF0 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x27FBC60 Offset: 0x27FBD61 VA: 0x27FBC60
	private void TryBindUI() { }

	// RVA: 0x27FBA80 Offset: 0x27FBB81 VA: 0x27FBA80
	private void TryUnbindUI() { }

	// RVA: 0x27FBDF0 Offset: 0x27FBEF1 VA: 0x27FBDF0
	private EventSequence.Coroutine GetCurrent() { }

	// RVA: 0x27FBE70 Offset: 0x27FBF71 VA: 0x27FBE70
	protected void Tick() { }

	// RVA: 0x27FBFA0 Offset: 0x27FC0A1 VA: 0x27FBFA0
	public void YieldCoroutine() { }

	// RVA: 0x27FBFC0 Offset: 0x27FC0C1 VA: 0x27FBFC0
	public EventSequence AddCoroutine(DynValue func, DynValue[] args) { }

	// RVA: 0x27FC150 Offset: 0x27FC251 VA: 0x27FC150
	public EventSequence JumpCoroutine(DynValue func, DynValue[] args) { }

	// RVA: 0x27FC260 Offset: 0x27FC361 VA: 0x27FC260 Slot: 17
	public override string GetDebugLog() { }

	// RVA: 0x27FC270 Offset: 0x27FC371 VA: 0x27FC270
	public static List<EventSequence.Coroutine> GetCoroutines() { }

	// RVA: 0x27FC310 Offset: 0x27FC411 VA: 0x27FC310
	public static int GetStackCount() { }

	// RVA: 0x27FC3D0 Offset: 0x27FC4D1 VA: 0x27FC3D0
	public static string GetStackFunction() { }

	// RVA: 0x27FC4B0 Offset: 0x27FC5B1 VA: 0x27FC4B0
	public static int GetCurrentAddress() { }

	// RVA: 0x27FC5B0 Offset: 0x27FC6B1 VA: 0x27FC5B0
	private static void DummyCall(ProcInst p) { }

	// RVA: 0x27FC5C0 Offset: 0x27FC6C1 VA: 0x27FC5C0
	public static bool TryCreateBind(ProcInst super, DynValue func, ProcVoidFunction preCall, ProcVoidFunction postCall, DynValue[] args) { }

	// RVA: 0x27FC9F0 Offset: 0x27FCAF1 VA: 0x27FC9F0
	private static void TryCreateBind(ProcInst super, MapInspector inspector) { }

	// RVA: 0x27FCAD0 Offset: 0x27FCBD1 VA: 0x27FCAD0
	public static bool IsBindingUI() { }

	// RVA: 0x27FCBB0 Offset: 0x27FCCB1 VA: 0x27FCBB0
	public static bool TryCreateBind(ProcInst super, string name) { }

	// RVA: 0x27FCD40 Offset: 0x27FCE41 VA: 0x27FCD40
	public static bool Turn(ProcInst super, int turn, Force.Type force) { }

	// RVA: 0x27FCD60 Offset: 0x27FCE61 VA: 0x27FCD60
	public static bool TurnAfter(ProcInst super, int turn, Force.Type force) { }

	// RVA: 0x27FCD80 Offset: 0x27FCE81 VA: 0x27FCD80
	public static bool TurnEnd(ProcInst super, int turn, Force.Type force) { }

	// RVA: 0x27FCDA0 Offset: 0x27FCEA1 VA: 0x27FCDA0
	public static bool Area(ProcInst super, Unit unit, int x, int z, Force.Type force) { }

	// RVA: 0x27FCDC0 Offset: 0x27FCEC1 VA: 0x27FCDC0
	public static bool Die(ProcInst super, Unit unit) { }

	// RVA: 0x27FCDD0 Offset: 0x27FCED1 VA: 0x27FCDD0
	public static bool ReviveBefore(ProcInst super, Unit unit) { }

	// RVA: 0x27FCDE0 Offset: 0x27FCEE1 VA: 0x27FCDE0
	public static bool ReviveAfter(ProcInst super, Unit unit) { }

	// RVA: 0x27FCDF0 Offset: 0x27FCEF1 VA: 0x27FCDF0
	public static bool Fixed(ProcInst super, Unit unit) { }

	// RVA: 0x27FCE00 Offset: 0x27FCF01 VA: 0x27FCE00
	public static bool Talk(ProcInst super, Unit from, Unit to) { }

	// RVA: 0x27FCE20 Offset: 0x27FCF21 VA: 0x27FCE20
	public static bool HelpSpot(ProcInst super, Unit unit, int x, int z) { }

	// RVA: 0x27FCE40 Offset: 0x27FCF41 VA: 0x27FCE40
	public static bool BattleBefore(ProcInst super, Unit fromUnit, Unit toUnit) { }

	// RVA: 0x27FCE60 Offset: 0x27FCF61 VA: 0x27FCE60
	public static bool BattleTalk(ProcInst super, Unit fromUnit, Unit toUnit) { }

	// RVA: 0x27FCE80 Offset: 0x27FCF81 VA: 0x27FCE80
	public static bool BattleAfter(ProcInst super, Unit fromUnit, Unit toUnit) { }

	// RVA: 0x27FCEA0 Offset: 0x27FCFA1 VA: 0x27FCEA0
	public static bool Pickup(ProcInst super, Unit unit) { }

	// RVA: 0x27FCEB0 Offset: 0x27FCFB1 VA: 0x27FCEB0
	public static bool UnitCommandPrepare(ProcInst super, Unit unit) { }

	// RVA: 0x27FCEC0 Offset: 0x27FCFC1 VA: 0x27FCEC0
	public static bool UnitCommandInterrupt(ProcInst super, Unit unit, string command) { }

	// RVA: 0x27FCF10 Offset: 0x27FD011 VA: 0x27FCF10
	public static bool EngageBefore(ProcInst super, Unit unit) { }

	// RVA: 0x27FCF20 Offset: 0x27FD021 VA: 0x27FCF20
	public static bool EngageAfter(ProcInst super, Unit unit) { }

	// RVA: 0x27FCF30 Offset: 0x27FD031 VA: 0x27FCF30
	public static bool TargetSelect(ProcInst super, Unit unit) { }

	// RVA: 0x27FCF40 Offset: 0x27FD041 VA: 0x27FCF40
	public static bool Poke(ProcInst super, MapInspector.Kind kind, Unit unit, int x, int z) { }

	// RVA: 0x27FCF50 Offset: 0x27FD051 VA: 0x27FCF50
	public static bool Poke(ProcInst super, PokeInspector inspector) { }

	// RVA: 0x27FCF60 Offset: 0x27FD061 VA: 0x27FCF60
	public static void Startup(ProcInst super) { }

	// RVA: 0x27FCFC0 Offset: 0x27FD0C1 VA: 0x27FCFC0
	public static void Cleanup(ProcInst super) { }

	// RVA: 0x27FD020 Offset: 0x27FD121 VA: 0x27FD020
	public static void Main(ProcInst super) { }

	// RVA: 0x27FD080 Offset: 0x27FD181 VA: 0x27FD080
	public static void Opening(ProcInst super) { }

	// RVA: 0x27FD0E0 Offset: 0x27FD1E1 VA: 0x27FD0E0
	public static void Ending(ProcInst super) { }

	// RVA: 0x27FD140 Offset: 0x27FD241 VA: 0x27FD140
	public static void GameOver(ProcInst super) { }

	// RVA: 0x27FD1A0 Offset: 0x27FD2A1 VA: 0x27FD1A0
	public static void MapDispos(ProcInst super) { }

	// RVA: 0x27FD200 Offset: 0x27FD301 VA: 0x27FD200
	public static void MapOpening(ProcInst super) { }

	// RVA: 0x27FD260 Offset: 0x27FD361 VA: 0x27FD260
	public static void MapEnding(ProcInst super) { }

	// RVA: 0x27FC910 Offset: 0x27FCA11 VA: 0x27FC910
	public void .ctor() { }
}

