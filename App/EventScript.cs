// Namespace: App
public class EventScript : Script // TypeDefIndex: 10231
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DC70 Offset: 0x28DD71 VA: 0x28DC70
	private string <Name>k__BackingField; // 0x58
	private static Stack<EventScript> s_Stack; // 0x0

	// Properties
	public string Name { get; set; }
	public static EventScript Instance { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BD800 Offset: 0x2BD901 VA: 0x2BD800
	// RVA: 0x27FA8A0 Offset: 0x27FA9A1 VA: 0x27FA8A0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD810 Offset: 0x2BD911 VA: 0x2BD810
	// RVA: 0x27FA8B0 Offset: 0x27FA9B1 VA: 0x27FA8B0
	private void set_Name(string value) { }

	// RVA: 0x27FA8C0 Offset: 0x27FA9C1 VA: 0x27FA8C0
	public DynValue GetFunc(string name) { }

	// RVA: 0x27FA8F0 Offset: 0x27FA9F1 VA: 0x27FA8F0
	public void Call(string name, DynValue[] args) { }

	// RVA: 0x27FA960 Offset: 0x27FAA61 VA: 0x27FA960
	public DynValue TryCreateCoroutine(string name) { }

	// RVA: 0x27FA9A0 Offset: 0x27FAAA1 VA: 0x27FA9A0
	public DynValue TryCreateCoroutine(DynValue function) { }

	// RVA: 0x27FAA60 Offset: 0x27FAB61 VA: 0x27FAA60
	public bool IsDead(DynValue coroutine) { }

	// RVA: 0x27FAAC0 Offset: 0x27FABC1 VA: 0x27FAAC0
	public DynValue DoCoroutine(DynValue coroutine, DynValue[] args) { }

	// RVA: 0x27FAD10 Offset: 0x27FAE11 VA: 0x27FAD10
	public void Dump() { }

	// RVA: 0x27FAFA0 Offset: 0x27FB0A1 VA: 0x27FAFA0
	public void RegistFunction(EventScript.FunctionArgs func, string name) { }

	// RVA: 0x27FAFF0 Offset: 0x27FB0F1 VA: 0x27FAFF0
	public void RegistAction(EventScript.ActionArgs func, string name) { }

	// RVA: 0x27FB040 Offset: 0x27FB141 VA: 0x27FB040
	public void Regist() { }

	// RVA: 0x27FB0C0 Offset: 0x27FB1C1 VA: 0x27FB0C0
	public static void Initialize() { }

	// RVA: 0x27FB1E0 Offset: 0x27FB2E1 VA: 0x27FB1E0
	private void LoadImpl(string path) { }

	// RVA: 0x27FB540 Offset: 0x27FB641 VA: 0x27FB540
	private void UnloadImpl() { }

	// RVA: 0x27FB550 Offset: 0x27FB651 VA: 0x27FB550
	public static void Load(string path) { }

	// RVA: 0x27FB720 Offset: 0x27FB821 VA: 0x27FB720
	public static void Unload() { }

	// RVA: 0x27FB830 Offset: 0x27FB931 VA: 0x27FB830
	public static EventScript get_Instance() { }

	// RVA: 0x27FB6B0 Offset: 0x27FB7B1 VA: 0x27FB6B0
	public void .ctor() { }

	// RVA: 0x27FB940 Offset: 0x27FBA41 VA: 0x27FB940
	private static void .cctor() { }
}

