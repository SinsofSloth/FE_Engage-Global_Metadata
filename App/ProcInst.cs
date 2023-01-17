// Namespace: App
public class ProcInst // TypeDefIndex: 13906
{
	// Fields
	private ProcDesc[] m_Descs; // 0x10
	private int m_DescIndex; // 0x18
	private string m_Name; // 0x20
	private int m_HashCode; // 0x28
	private ProcInst m_Super; // 0x30
	private ProcInst m_Child; // 0x38
	private ProcInst m_Prev; // 0x40
	private ProcInst m_Next; // 0x48
	private ProcVoidMethod m_Persistent; // 0x50
	private ProcInst.State m_State; // 0x58
	private int m_Suspend; // 0x5C
	private float m_WaitTime; // 0x60
	private float m_TickTime; // 0x64
	private RawValueStack m_Stack; // 0x68

	// Properties
	public float TickTime { get; set; }
	public string Name { get; }
	public int HashCode { get; }
	public ProcVoidMethod PersistentMethod { get; set; }
	public ProcDesc Desc { get; }
	public int DescIndex { get; }
	public ProcDesc.Type DescType { get; }
	protected virtual bool CanWaitSkip { get; }

	// Methods

	// RVA: 0x29D18B0 Offset: 0x29D19B1 VA: 0x29D18B0
	public void .ctor() { }

	// RVA: 0x29E2FA0 Offset: 0x29E30A1 VA: 0x29E2FA0
	private ProcDesc[] GetNoDesc() { }

	// RVA: 0x29E3130 Offset: 0x29E3231 VA: 0x29E3130
	private ProcDesc[] GetCoroutine() { }

	// RVA: 0x29E32E0 Offset: 0x29E33E1 VA: 0x29E32E0
	public ProcInst CreateNoDesc(ProcInst super) { }

	// RVA: 0x29E3330 Offset: 0x29E3431 VA: 0x29E3330
	public ProcInst CreateCoroutine(ProcInst super) { }

	// RVA: 0x29E2F60 Offset: 0x29E3061 VA: 0x29E2F60
	public ProcInst CreateBindNoDesc(ProcInst super) { }

	// RVA: 0x29E3370 Offset: 0x29E3471 VA: 0x29E3370
	public ProcInst CreateBindCoroutine(ProcInst super) { }

	// RVA: 0x29E3320 Offset: 0x29E3421 VA: 0x29E3320
	public ProcInst Create(ProcInst super, ProcDesc[] descs, string name) { }

	// RVA: 0x29D05A0 Offset: 0x29D06A1 VA: 0x29D05A0
	public ProcInst CreateBind(ProcInst super, ProcDesc[] descs, string name) { }

	// RVA: 0x29DECA0 Offset: 0x29DEDA1 VA: 0x29DECA0
	public ProcInst CreateRoot(string name) { }

	// RVA: 0x29DEF40 Offset: 0x29DF041 VA: 0x29DEF40
	public void RecursiveTick() { }

	// RVA: 0x29DF240 Offset: 0x29DF341 VA: 0x29DF240
	public void RecursivePersistentTask() { }

	// RVA: 0x29DF440 Offset: 0x29DF541 VA: 0x29DF440
	public void RecursiveRemove() { }

	// RVA: 0x29E39B0 Offset: 0x29E3AB1 VA: 0x29E39B0
	public ProcInst GetSuper() { }

	// RVA: 0x29E39C0 Offset: 0x29E3AC1 VA: 0x29E39C0
	public ProcInst GetChild() { }

	// RVA: 0x29E39D0 Offset: 0x29E3AD1 VA: 0x29E39D0
	public ProcInst GetPrev() { }

	// RVA: 0x29E39E0 Offset: 0x29E3AE1 VA: 0x29E39E0
	public ProcInst GetNext() { }

	// RVA: 0x29E39F0 Offset: 0x29E3AF1 VA: 0x29E39F0
	public int GetLabel() { }

	// RVA: 0x29E3A60 Offset: 0x29E3B61 VA: 0x29E3A60
	public float GetWaitTime() { }

	// RVA: 0x29E3A70 Offset: 0x29E3B71 VA: 0x29E3A70
	public bool IsWait() { }

	// RVA: 0x29E35C0 Offset: 0x29E36C1 VA: 0x29E35C0
	public bool IsBind() { }

	// RVA: 0x29E20B0 Offset: 0x29E21B1 VA: 0x29E20B0
	public bool IsDead() { }

	// RVA: 0x29DF990 Offset: 0x29DFA91 VA: 0x29DF990
	public bool IsParentBind() { }

	// RVA: 0x29E2A70 Offset: 0x29E2B71 VA: 0x29E2A70
	public bool IsContinueExecute() { }

	// RVA: 0x29DF920 Offset: 0x29DFA21 VA: 0x29DF920
	public void Delete() { }

	// RVA: 0x29E2880 Offset: 0x29E2981 VA: 0x29E2880
	public void Next() { }

	// RVA: 0x29E2E50 Offset: 0x29E2F51 VA: 0x29E2E50
	public void NextImm() { }

	// RVA: 0x29E35D0 Offset: 0x29E36D1 VA: 0x29E35D0
	public void Jump(int label) { }

	// RVA: 0x29E3B50 Offset: 0x29E3C51 VA: 0x29E3B50
	public void Jump(ValueType label) { }

	// RVA: 0x29E3C40 Offset: 0x29E3D41 VA: 0x29E3C40
	public bool TryJump(ValueType label) { }

	// RVA: 0x29E3670 Offset: 0x29E3771 VA: 0x29E3670
	public void PushJump(int label) { }

	// RVA: 0x29E3DE0 Offset: 0x29E3EE1 VA: 0x29E3DE0
	public void PushJump(ValueType label) { }

	// RVA: 0x29E3800 Offset: 0x29E3901 VA: 0x29E3800
	public void PopJump() { }

	// RVA: 0x29E3E70 Offset: 0x29E3F71 VA: 0x29E3E70
	public void JumpImm(int label) { }

	// RVA: 0x29E3F20 Offset: 0x29E4021 VA: 0x29E3F20
	public void JumpImm(ValueType label) { }

	// RVA: 0x29E4020 Offset: 0x29E4121 VA: 0x29E4020
	public void WaitTime(float time) { }

	// RVA: 0x29E4030 Offset: 0x29E4131 VA: 0x29E4030
	public void DeleteChild() { }

	// RVA: 0x29E4050 Offset: 0x29E4151 VA: 0x29E4050
	public void Yield() { }

	// RVA: 0x29E4060 Offset: 0x29E4161 VA: 0x29E4060
	public void Assert() { }

	// RVA: 0x29DF6A0 Offset: 0x29DF7A1 VA: 0x29DF6A0
	public ProcInst FindNext(bool isFirst = True) { }

	// RVA: 0x29E4080 Offset: 0x29E4181 VA: 0x29E4080
	public float get_TickTime() { }

	// RVA: 0x29E4090 Offset: 0x29E4191 VA: 0x29E4090
	public void set_TickTime(float value) { }

	// RVA: 0x29E40A0 Offset: 0x29E41A1 VA: 0x29E40A0
	public string get_Name() { }

	// RVA: 0x29E40B0 Offset: 0x29E41B1 VA: 0x29E40B0
	public int get_HashCode() { }

	// RVA: 0x29E40C0 Offset: 0x29E41C1 VA: 0x29E40C0
	public ProcVoidMethod get_PersistentMethod() { }

	// RVA: 0x29E40D0 Offset: 0x29E41D1 VA: 0x29E40D0
	public void set_PersistentMethod(ProcVoidMethod value) { }

	// RVA: 0x29E2840 Offset: 0x29E2941 VA: 0x29E2840
	public ProcDesc get_Desc() { }

	// RVA: 0x29E40E0 Offset: 0x29E41E1 VA: 0x29E40E0
	public int get_DescIndex() { }

	// RVA: 0x29E40F0 Offset: 0x29E41F1 VA: 0x29E40F0
	public ProcDesc.Type get_DescType() { }

	// RVA: 0x29E33B0 Offset: 0x29E34B1 VA: 0x29E33B0
	private ProcInst CreateInternal(ProcInst super, ProcDesc[] descs, string name, bool isBind) { }

	// RVA: 0x29E34B0 Offset: 0x29E35B1 VA: 0x29E34B0
	private ProcInst CreateInternal(ProcDesc[] descs, string name) { }

	// RVA: 0x29E4130 Offset: 0x29E4231 VA: 0x29E4130
	private void Connect(ProcInst super) { }

	// RVA: 0x29E38D0 Offset: 0x29E39D1 VA: 0x29E38D0
	private void Disconnect() { }

	// RVA: 0x29E41B0 Offset: 0x29E42B1 VA: 0x29E41B0
	public void Bind() { }

	// RVA: 0x29E41F0 Offset: 0x29E42F1 VA: 0x29E41F0
	public void Unbind() { }

	// RVA: 0x29E3A80 Offset: 0x29E3B81 VA: 0x29E3A80
	private void MarkingDeath(bool isFirst) { }

	// RVA: 0x29E4210 Offset: 0x29E4311 VA: 0x29E4210 Slot: 4
	protected virtual bool get_CanWaitSkip() { }

	// RVA: 0x29E4220 Offset: 0x29E4321 VA: 0x29E4220 Slot: 5
	protected virtual void OnStart() { }

	// RVA: 0x29E4230 Offset: 0x29E4331 VA: 0x29E4230 Slot: 6
	protected virtual void OnTick() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CD7C0 Offset: 0x2CD8C1 VA: 0x2CD7C0
	// RVA: 0x29E4240 Offset: 0x29E4341 VA: 0x29E4240 Slot: 7
	protected virtual IEnumerator OnCoroutine() { }

	// RVA: 0x29E42A0 Offset: 0x29E43A1 VA: 0x29E42A0 Slot: 8
	protected virtual void OnPersistent() { }

	// RVA: 0x29E42B0 Offset: 0x29E43B1 VA: 0x29E42B0 Slot: 9
	protected virtual void OnCreate() { }

	// RVA: 0x29E42C0 Offset: 0x29E43C1 VA: 0x29E42C0 Slot: 10
	protected virtual void OnDispose() { }

	// RVA: 0x29E42D0 Offset: 0x29E43D1 VA: 0x29E42D0 Slot: 11
	protected virtual void OnBind() { }

	// RVA: 0x29E42E0 Offset: 0x29E43E1 VA: 0x29E42E0 Slot: 12
	protected virtual void OnUnbind() { }

	// RVA: 0x29E42F0 Offset: 0x29E43F1 VA: 0x29E42F0 Slot: 13
	protected virtual void OnSingletonCreate() { }

	// RVA: 0x29E4300 Offset: 0x29E4401 VA: 0x29E4300 Slot: 14
	protected virtual void OnSingletonDispose() { }

	// RVA: 0x29E4310 Offset: 0x29E4411 VA: 0x29E4310 Slot: 15
	protected virtual void OnShutdown() { }

	// RVA: 0x29E4320 Offset: 0x29E4421 VA: 0x29E4320 Slot: 16
	protected virtual void OnDrawMonitor(DebugMonitor monitor) { }

	// RVA: 0x29E4330 Offset: 0x29E4431 VA: 0x29E4330 Slot: 17
	public virtual string GetDebugLog() { }

	// RVA: 0x29E4340 Offset: 0x29E4441 VA: 0x29E4340
	public void Shutdown() { }

	// RVA: 0x29E4390 Offset: 0x29E4491 VA: 0x29E4390
	public void ShutdownChild() { }

	[ConditionalAttribute] // RVA: 0x2CD830 Offset: 0x2CD931 VA: 0x2CD830
	// RVA: 0x29E43C0 Offset: 0x29E44C1 VA: 0x29E43C0
	public void DrawMonitor(DebugMonitor monitor) { }
}

