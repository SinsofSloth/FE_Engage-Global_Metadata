// Namespace: App
public class Proc // TypeDefIndex: 13861
{
	// Fields
	private static ProcInst[] s_Roots; // 0x0

	// Methods

	// RVA: 0x29DE860 Offset: 0x29DE961 VA: 0x29DE860
	public static void Initialize() { }

	// RVA: 0x29DEE50 Offset: 0x29DEF51 VA: 0x29DEE50
	public static void Exec(Proc.RootType type) { }

	// RVA: 0x29DF290 Offset: 0x29DF391 VA: 0x29DF290
	public static void Sweep() { }

	// RVA: 0x29DF490 Offset: 0x29DF591 VA: 0x29DF490
	public static ProcInst FindByName(string name) { }

	// RVA: 0x29DF6F0 Offset: 0x29DF7F1 VA: 0x29DF6F0
	public static void KillByName(string name) { }

	// RVA: 0x29DF940 Offset: 0x29DFA41 VA: 0x29DF940
	public static void KillByBind(ProcInst super) { }

	// RVA: -1 Offset: -1
	public static T FindByClass<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2012530 Offset: 0x2012631 VA: 0x2012530
	|-Proc.FindByClass<ClassChangeSequence>
	|-Proc.FindByClass<CombatSubspaceBack>
	|-Proc.FindByClass<EngageSequence>
	|-Proc.FindByClass<JobIntroSequence>
	|-Proc.FindByClass<LaterTalkSequence>
	|-Proc.FindByClass<MyRoomMovieMenu>
	|-Proc.FindByClass<object>
	|-Proc.FindByClass<RewindMenu>
	|-Proc.FindByClass<UnitInfoSequence>
	|-Proc.FindByClass<TalkCharacterManager.ProcFadeInCharacter>
	|-Proc.FindByClass<TalkCharacterManager.ProcFadeOutCharacter>
	*/

	// RVA: -1 Offset: -1
	public static void KillByClass<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2012740 Offset: 0x2012841 VA: 0x2012740
	|-Proc.KillByClass<ConsoleManager>
	|-Proc.KillByClass<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CallbackByClass<T>(Proc.ProcCallback<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20121C0 Offset: 0x20122C1 VA: 0x20121C0
	|-Proc.CallbackByClass<object>
	*/

	// RVA: 0x29DF9A0 Offset: 0x29DFAA1 VA: 0x29DF9A0
	public static ProcInst GetRoot(Proc.RootType type) { }

	// RVA: 0x29DFA30 Offset: 0x29DFB31 VA: 0x29DFA30
	public static ProcInst GetRootHi() { }

	// RVA: 0x29DFAB0 Offset: 0x29DFBB1 VA: 0x29DFAB0
	public static ProcInst GetRootDef() { }

	// RVA: 0x29DFB30 Offset: 0x29DFC31 VA: 0x29DFB30
	public static ProcInst GetRootLow() { }

	// RVA: 0x29D0940 Offset: 0x29D0A41 VA: 0x29D0940
	public static ProcDesc End() { }

	// RVA: 0x29DFBE0 Offset: 0x29DFCE1 VA: 0x29DFBE0
	public static ProcDesc Halt() { }

	// RVA: 0x29DFC70 Offset: 0x29DFD71 VA: 0x29DFC70
	public static ProcDesc Jump(int label) { }

	// RVA: 0x29DFD10 Offset: 0x29DFE11 VA: 0x29DFD10
	public static ProcDesc Jump(string label) { }

	// RVA: 0x29DFD90 Offset: 0x29DFE91 VA: 0x29DFD90
	public static ProcDesc Label(int label) { }

	// RVA: 0x29DFE30 Offset: 0x29DFF31 VA: 0x29DFE30
	public static ProcDesc Label(string label) { }

	// RVA: 0x29D07B0 Offset: 0x29D08B1 VA: 0x29D07B0
	public static ProcDesc Jump(ValueType label) { }

	// RVA: 0x29D05B0 Offset: 0x29D06B1 VA: 0x29D05B0
	public static ProcDesc Label(ValueType label) { }

	// RVA: 0x29DFEB0 Offset: 0x29DFFB1 VA: 0x29DFEB0
	public static ProcDesc Push(int label) { }

	// RVA: 0x29DFF50 Offset: 0x29E0051 VA: 0x29DFF50
	public static ProcDesc Push(ValueType label) { }

	// RVA: 0x29E0010 Offset: 0x29E0111 VA: 0x29E0010
	public static ProcDesc Pop() { }

	// RVA: 0x29E00A0 Offset: 0x29E01A1 VA: 0x29E00A0
	public static ProcDesc Yield() { }

	// RVA: 0x29E0130 Offset: 0x29E0231 VA: 0x29E0130
	public static ProcDesc Call(ProcVoidFunction function) { }

	// RVA: 0x29D0690 Offset: 0x29D0791 VA: 0x29D0690
	public static ProcDesc Call(ProcVoidMethod function) { }

	// RVA: 0x29E0230 Offset: 0x29E0331 VA: 0x29E0230
	public static ProcDesc Call(Action<ProcInst, string> function, string arg) { }

	// RVA: 0x29E0320 Offset: 0x29E0421 VA: 0x29E0320
	public static ProcDesc Call(Action<string> function, string arg) { }

	// RVA: -1 Offset: -1
	public static ProcDesc Call<T>(Action<ProcInst, T> function, T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20120D0 Offset: 0x20121D1 VA: 0x20120D0
	|-Proc.Call<Int32Enum>
	|-Proc.Call<SaveDataMenuSequence.Mode>
	|
	|-RVA: 0x2012140 Offset: 0x2012241 VA: 0x2012140
	|-Proc.Call<float>
	*/

	// RVA: -1 Offset: -1
	public static ProcDesc Call<T>(Action<T> function, T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011F80 Offset: 0x2012081 VA: 0x2011F80
	|-Proc.Call<bool>
	|
	|-RVA: 0x2011FF0 Offset: 0x20120F1 VA: 0x2011FF0
	|-Proc.Call<int>
	|
	|-RVA: 0x2012060 Offset: 0x2012161 VA: 0x2012060
	|-Proc.Call<Int32Enum>
	|-Proc.Call<GameSound.FadeSpeedType>
	|-Proc.Call<Versus.CheckDataType>
	*/

	// RVA: 0x29E0410 Offset: 0x29E0511 VA: 0x29E0410
	public static ProcDesc Tick(ProcVoidFunction function) { }

	// RVA: 0x29E04D0 Offset: 0x29E05D1 VA: 0x29E04D0
	public static ProcDesc Tick(ProcVoidMethod method) { }

	// RVA: 0x29E0590 Offset: 0x29E0691 VA: 0x29E0590
	public static ProcDesc Tick(ProcEnumMethod method) { }

	// RVA: 0x29E06A0 Offset: 0x29E07A1 VA: 0x29E06A0
	public static ProcDesc WaitTime(float second) { }

	// RVA: 0x29E0750 Offset: 0x29E0851 VA: 0x29E0750
	public static ProcDesc WaitWhileTrue(ProcBoolFunction function) { }

	// RVA: 0x29E0810 Offset: 0x29E0911 VA: 0x29E0810
	public static ProcDesc WaitWhileFalse(ProcBoolFunction function) { }

	// RVA: 0x29D0730 Offset: 0x29D0831 VA: 0x29D0730
	public static ProcDesc WaitWhileTrue(ProcBoolMethod function) { }

	// RVA: 0x29E0910 Offset: 0x29E0A11 VA: 0x29E0910
	public static ProcDesc WaitWhileFalse(ProcBoolMethod function) { }

	// RVA: 0x29E09D0 Offset: 0x29E0AD1 VA: 0x29E09D0
	public static ProcDesc JumpTrue(ProcBoolFunction function, int label) { }

	// RVA: 0x29E0AA0 Offset: 0x29E0BA1 VA: 0x29E0AA0
	public static ProcDesc JumpTrue(ProcBoolFunction function, string label) { }

	// RVA: 0x29E0B40 Offset: 0x29E0C41 VA: 0x29E0B40
	public static ProcDesc JumpFalse(ProcBoolFunction function, int label) { }

	// RVA: 0x29E0C10 Offset: 0x29E0D11 VA: 0x29E0C10
	public static ProcDesc JumpFalse(ProcBoolFunction function, string label) { }

	// RVA: 0x29E0CB0 Offset: 0x29E0DB1 VA: 0x29E0CB0
	public static ProcDesc JumpTrue(ProcBoolMethod function, int label) { }

	// RVA: 0x29E0D80 Offset: 0x29E0E81 VA: 0x29E0D80
	public static ProcDesc JumpFalse(ProcBoolMethod function, int label) { }

	// RVA: 0x29D0870 Offset: 0x29D0971 VA: 0x29D0870
	public static ProcDesc JumpTrue(ProcBoolMethod method, ValueType label) { }

	// RVA: 0x29E0E50 Offset: 0x29E0F51 VA: 0x29E0E50
	public static ProcDesc JumpFalse(ProcBoolMethod method, ValueType label) { }

	// RVA: 0x29E0F20 Offset: 0x29E1021 VA: 0x29E0F20
	public static ProcDesc Persistent(ProcVoidMethod method) { }

	// RVA: 0x29E0FE0 Offset: 0x29E10E1 VA: 0x29E0FE0
	public static ProcDesc PersistentNull() { }

	// RVA: 0x29E1050 Offset: 0x29E1151 VA: 0x29E1050
	public static ProcDesc Sound(string eventName) { }

	// RVA: 0x29E1110 Offset: 0x29E1211 VA: 0x29E1110
	public static ProcDesc Log(string log) { }

	// RVA: 0x29E11D0 Offset: 0x29E12D1 VA: 0x29E11D0
	public static ProcDesc Vsync(GameTime.VsycMode mode) { }

	// RVA: 0x29E1270 Offset: 0x29E1371 VA: 0x29E1270
	public static ProcDesc WaitIsLoading() { }

	// RVA: -1 Offset: -1
	public static T CreateNoDesc<T>(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20124F0 Offset: 0x20125F1 VA: 0x20124F0
	|-Proc.CreateNoDesc<object>
	*/

	// RVA: -1 Offset: -1
	public static T CreateBindNoDesc<T>(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20124B0 Offset: 0x20125B1 VA: 0x20124B0
	|-Proc.CreateBindNoDesc<object>
	|-Proc.CreateBindNoDesc<TalkBind>
	|-Proc.CreateBindNoDesc<TalkSound.WaitSE>
	*/

	// RVA: 0x29E1340 Offset: 0x29E1441 VA: 0x29E1340
	public static string GetDebugLog(ProcInst inst) { }

	// RVA: 0x29E13A0 Offset: 0x29E14A1 VA: 0x29E13A0
	public void .ctor() { }

	// RVA: 0x29E13B0 Offset: 0x29E14B1 VA: 0x29E13B0
	private static void .cctor() { }
}

