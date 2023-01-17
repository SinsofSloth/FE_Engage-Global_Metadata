// Namespace: App
public class MapSequenceHelper // TypeDefIndex: 12421
{
	// Fields
	private static readonly int[] AroundOffsetXs; // 0x0
	private static readonly int[] AroundOffsetZs; // 0x8
	private const float InsideScreenMin = 0.125;
	private const float InsideScreenMax = 0.875;

	// Methods

	// RVA: 0x1D72CC0 Offset: 0x1D72DC1 VA: 0x1D72CC0
	public static bool GetCursorTurnFirst(Force.Type force, ref int x, ref int z) { }

	// RVA: 0x1D90F00 Offset: 0x1D91001 VA: 0x1D90F00
	public static bool GetCursorTurnHero(Force.Type force, ref int x, ref int z) { }

	// RVA: 0x1D90F70 Offset: 0x1D91071 VA: 0x1D90F70
	public static void WaitCamera(ProcInst super) { }

	// RVA: 0x1D90FB0 Offset: 0x1D910B1 VA: 0x1D90FB0
	public static void MoveCamera(ProcInst super, int x, int z) { }

	// RVA: 0x1D91070 Offset: 0x1D91171 VA: 0x1D91070
	public static void MoveCamera(ProcInst super, float x, float z) { }

	// RVA: 0x1D91140 Offset: 0x1D91241 VA: 0x1D91140
	public static void WaitCameraLoosely(ProcInst super) { }

	// RVA: 0x1D91180 Offset: 0x1D91281 VA: 0x1D91180
	public static void MoveCameraLoosely(ProcInst super, int x, int y) { }

	// RVA: 0x1D91240 Offset: 0x1D91341 VA: 0x1D91240
	public static bool TryMoveCameraLoosely(ProcInst super, Unit unit) { }

	// RVA: 0x1D721E0 Offset: 0x1D722E1 VA: 0x1D721E0
	public static bool CheckPhaseEnd() { }

	// RVA: 0x1D92090 Offset: 0x1D92191 VA: 0x1D92090
	public static bool CheckRemovable(Unit unit) { }

	// RVA: 0x1D92320 Offset: 0x1D92421 VA: 0x1D92320
	private static bool CheckRemovableDetail(Unit unit) { }

	// RVA: 0x1D92AC0 Offset: 0x1D92BC1 VA: 0x1D92AC0
	public static void SetRemovable(Unit unit) { }

	// RVA: 0x1D92C60 Offset: 0x1D92D61 VA: 0x1D92C60
	public static bool CheckRemagicable(Unit unit) { }

	// RVA: 0x1D92E80 Offset: 0x1D92F81 VA: 0x1D92E80
	public static void SetRemagicable(Unit unit) { }

	// RVA: 0x1D93000 Offset: 0x1D93101 VA: 0x1D93000
	public static bool CheckRerewarp(Unit unit) { }

	// RVA: 0x1D93180 Offset: 0x1D93281 VA: 0x1D93180
	public static void SetRerewarp(Unit unit) { }

	// RVA: 0x1D931E0 Offset: 0x1D932E1 VA: 0x1D931E0
	public static int GetRouteCost() { }

	// RVA: 0x1D91370 Offset: 0x1D91471 VA: 0x1D91370
	public static bool IsInsideScreen(Unit unit) { }

	// RVA: 0x1D762F0 Offset: 0x1D763F1 VA: 0x1D762F0
	public static void EngageAttackTelop(ProcInst super) { }

	// RVA: 0x1D932A0 Offset: 0x1D933A1 VA: 0x1D932A0
	private static bool TryGetEngageAttackPair(out GodData main, out GodData link) { }

	// RVA: 0x1D934B0 Offset: 0x1D935B1 VA: 0x1D934B0
	public void .ctor() { }

	// RVA: 0x1D934C0 Offset: 0x1D935C1 VA: 0x1D934C0
	private static void .cctor() { }
}

