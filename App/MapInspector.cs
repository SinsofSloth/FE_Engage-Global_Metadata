// Namespace: App
public abstract class MapInspector : ScriptUtil // TypeDefIndex: 12122
{
	// Fields
	private MapInspector.Kind m_Kind; // 0x10
	private DynValue m_Condition; // 0x18
	private DynValue m_Function; // 0x20
	private DynValue[] m_Args; // 0x28

	// Properties
	public virtual Color Color { get; }
	public virtual int X { get; }
	public virtual int Z { get; }
	public virtual int X1 { get; }
	public virtual int Z1 { get; }
	public virtual int X2 { get; }
	public virtual int Z2 { get; }
	public virtual int W { get; }
	public virtual int H { get; }
	public virtual int Hp { get; set; }
	public virtual int MaxHp { get; set; }

	// Methods

	// RVA: 0x21FE7C0 Offset: 0x21FE8C1 VA: 0x21FE7C0
	protected void .ctor(MapInspector.Kind kind) { }

	// RVA: 0x21FE840 Offset: 0x21FE941 VA: 0x21FE840
	public MapInspector.Kind GetKind() { }

	// RVA: 0x21FE850 Offset: 0x21FE951 VA: 0x21FE850
	public DynValue GetFunction() { }

	// RVA: 0x21FE860 Offset: 0x21FE961 VA: 0x21FE860
	public DynValue[] GetArgs() { }

	// RVA: 0x21FE870 Offset: 0x21FE971 VA: 0x21FE870
	public DynValue GetCondition() { }

	// RVA: 0x21FE880 Offset: 0x21FE981 VA: 0x21FE880
	public bool IsCondition() { }

	// RVA: 0x21FE9E0 Offset: 0x21FEAE1 VA: 0x21FE9E0
	public bool IsInside(int x, int z) { }

	// RVA: 0x21FEA90 Offset: 0x21FEB91 VA: 0x21FEA90 Slot: 4
	public virtual void Completed() { }

	// RVA: 0x21FEC90 Offset: 0x21FED91 VA: 0x21FEC90
	protected bool IsValue(int self, int other) { }

	// RVA: 0x21FECB0 Offset: 0x21FEDB1 VA: 0x21FECB0 Slot: 5
	public virtual bool IsEanble() { }

	// RVA: 0x21FECC0 Offset: 0x21FEDC1 VA: 0x21FECC0 Slot: 6
	public virtual bool IsEanble(int arg) { }

	// RVA: 0x21FECD0 Offset: 0x21FEDD1 VA: 0x21FECD0 Slot: 7
	public virtual bool IsEanble(int arg1, int arg2) { }

	// RVA: 0x21FECE0 Offset: 0x21FEDE1 VA: 0x21FECE0 Slot: 8
	public virtual bool IsEanble(int arg1, int arg2, int arg3) { }

	// RVA: 0x21FECF0 Offset: 0x21FEDF1 VA: 0x21FECF0 Slot: 9
	public virtual bool IsEanble(int arg1, int arg2, int arg3, int arg4) { }

	// RVA: 0x21FED00 Offset: 0x21FEE01 VA: 0x21FED00 Slot: 10
	public virtual bool IsTerminated(int arg1, int arg2, int arg3, int arg4) { }

	// RVA: 0x21FED10 Offset: 0x21FEE11 VA: 0x21FED10 Slot: 11
	public virtual Color get_Color() { }

	// RVA: 0x21FED50 Offset: 0x21FEE51 VA: 0x21FED50 Slot: 12
	public virtual int get_X() { }

	// RVA: 0x21FED60 Offset: 0x21FEE61 VA: 0x21FED60 Slot: 13
	public virtual int get_Z() { }

	// RVA: 0x21FED70 Offset: 0x21FEE71 VA: 0x21FED70 Slot: 14
	public virtual int get_X1() { }

	// RVA: 0x21FED80 Offset: 0x21FEE81 VA: 0x21FED80 Slot: 15
	public virtual int get_Z1() { }

	// RVA: 0x21FED90 Offset: 0x21FEE91 VA: 0x21FED90 Slot: 16
	public virtual int get_X2() { }

	// RVA: 0x21FEDA0 Offset: 0x21FEEA1 VA: 0x21FEDA0 Slot: 17
	public virtual int get_Z2() { }

	// RVA: 0x21FEDB0 Offset: 0x21FEEB1 VA: 0x21FEDB0 Slot: 18
	public virtual int get_W() { }

	// RVA: 0x21FEE00 Offset: 0x21FEF01 VA: 0x21FEE00 Slot: 19
	public virtual int get_H() { }

	// RVA: 0x21FEE50 Offset: 0x21FEF51 VA: 0x21FEE50 Slot: 20
	public virtual int get_Hp() { }

	// RVA: 0x21FEE60 Offset: 0x21FEF61 VA: 0x21FEE60 Slot: 21
	public virtual void set_Hp(int value) { }

	// RVA: 0x21FEE70 Offset: 0x21FEF71 VA: 0x21FEE70 Slot: 22
	public virtual int get_MaxHp() { }

	// RVA: 0x21FEE80 Offset: 0x21FEF81 VA: 0x21FEE80 Slot: 23
	public virtual void set_MaxHp(int value) { }

	// RVA: 0x21FEE90 Offset: 0x21FEF91 VA: 0x21FEE90 Slot: 24
	protected virtual int GetCompleted() { }

	// RVA: 0x21FEEA0 Offset: 0x21FEFA1 VA: 0x21FEEA0 Slot: 25
	public virtual bool CanBreakable() { }

	// RVA: 0x21FEEE0 Offset: 0x21FEFE1 VA: 0x21FEEE0 Slot: 26
	public virtual bool CanBreakable(Unit unit) { }

	// RVA: 0x21FEF20 Offset: 0x21FF021 VA: 0x21FEF20 Slot: 27
	public virtual bool CanBreakable(Force.Type force) { }

	// RVA: 0x21FF0E0 Offset: 0x21FF1E1 VA: 0x21FF0E0 Slot: 28
	public virtual bool CanUseCannon() { }

	// RVA: 0x21FF1A0 Offset: 0x21FF2A1 VA: 0x21FF1A0 Slot: 29
	public virtual bool CanShowBreakIcon() { }

	// RVA: 0x21FF3D0 Offset: 0x21FF4D1 VA: 0x21FF3D0 Slot: 30
	public virtual void PreCall(ProcInst super) { }

	// RVA: 0x21FF3E0 Offset: 0x21FF4E1 VA: 0x21FF3E0 Slot: 31
	public virtual void PostCall(ProcInst super) { }

	// RVA: 0x21FF3F0 Offset: 0x21FF4F1 VA: 0x21FF3F0 Slot: 32
	public virtual ProcInst Resume(ProcInst super) { }

	// RVA: 0x21FF400 Offset: 0x21FF501 VA: 0x21FF400
	public MapInspector SetFunction(DynValue value) { }

	// RVA: 0x21FF440 Offset: 0x21FF541 VA: 0x21FF440
	public MapInspector SetArgs(DynValue[] args) { }

	// RVA: 0x21FF470 Offset: 0x21FF571 VA: 0x21FF470
	public MapInspector SetCondition(DynValue condition) { }

	// RVA: 0x21FF550 Offset: 0x21FF651 VA: 0x21FF550
	public MapInspector ResetCondition() { }

	// RVA: 0x21FF740 Offset: 0x21FF841 VA: 0x21FF740 Slot: 33
	public virtual string GetGlobalKey() { }

	// RVA: 0x21FF750 Offset: 0x21FF851 VA: 0x21FF750
	protected void SetGlobalKey() { }

	// RVA: 0x21FF980 Offset: 0x21FFA81 VA: 0x21FF980 Slot: 34
	public virtual void Serialize(Stream stream) { }

	// RVA: 0x21FF990 Offset: 0x21FFA91 VA: 0x21FF990 Slot: 35
	public virtual void Deserialize(Stream stream) { }

	// RVA: 0x21FF190 Offset: 0x21FF291 VA: 0x21FF190
	public static bool op_Implicit(MapInspector exists) { }

	// RVA: 0x21FF9A0 Offset: 0x21FFAA1 VA: 0x21FF9A0
	private static bool CanEnter(int x, int z) { }

	// RVA: 0x21FFB30 Offset: 0x21FFC31 VA: 0x21FFB30
	protected bool CanEnterAround() { }
}

