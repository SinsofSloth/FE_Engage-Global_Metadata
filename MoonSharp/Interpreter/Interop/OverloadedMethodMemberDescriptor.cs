// Namespace: MoonSharp.Interpreter.Interop
public class OverloadedMethodMemberDescriptor : IOptimizableDescriptor, IMemberDescriptor, IWireableDescriptor // TypeDefIndex: 6118
{
	// Fields
	private const int CACHE_SIZE = 5;
	private List<IOverloadableMemberDescriptor> m_Overloads; // 0x10
	private List<IOverloadableMemberDescriptor> m_ExtOverloads; // 0x18
	private bool m_Unsorted; // 0x20
	private OverloadedMethodMemberDescriptor.OverloadCacheItem[] m_Cache; // 0x28
	private int m_CacheHits; // 0x30
	private int m_ExtensionMethodVersion; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0xE850 Offset: 0xE951 VA: 0xE850
	private bool <IgnoreExtensionMethods>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xE860 Offset: 0xE961 VA: 0xE860
	private string <Name>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xE870 Offset: 0xE971 VA: 0xE870
	private Type <DeclaringType>k__BackingField; // 0x48

	// Properties
	public bool IgnoreExtensionMethods { get; set; }
	public string Name { get; set; }
	public Type DeclaringType { get; set; }
	public int OverloadCount { get; }
	public bool IsStatic { get; }
	public MemberDescriptorAccess MemberAccess { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10900 Offset: 0x10A01 VA: 0x10900
	// RVA: 0x2BC51F0 Offset: 0x2BC52F1 VA: 0x2BC51F0
	public bool get_IgnoreExtensionMethods() { }

	[CompilerGeneratedAttribute] // RVA: 0x10910 Offset: 0x10A11 VA: 0x10910
	// RVA: 0x2BC5200 Offset: 0x2BC5301 VA: 0x2BC5200
	public void set_IgnoreExtensionMethods(bool value) { }

	// RVA: 0x2BC5210 Offset: 0x2BC5311 VA: 0x2BC5210
	public void .ctor(string name, Type declaringType) { }

	// RVA: 0x2BC5330 Offset: 0x2BC5431 VA: 0x2BC5330
	public void .ctor(string name, Type declaringType, IOverloadableMemberDescriptor descriptor) { }

	// RVA: 0x2BC53B0 Offset: 0x2BC54B1 VA: 0x2BC53B0
	public void .ctor(string name, Type declaringType, IEnumerable<IOverloadableMemberDescriptor> descriptors) { }

	// RVA: 0x2BC5430 Offset: 0x2BC5531 VA: 0x2BC5430
	internal void SetExtensionMethodsSnapshot(int version, List<IOverloadableMemberDescriptor> extMethods) { }

	[CompilerGeneratedAttribute] // RVA: 0x10920 Offset: 0x10A21 VA: 0x10920
	// RVA: 0x2BC5470 Offset: 0x2BC5571 VA: 0x2BC5470 Slot: 6
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10930 Offset: 0x10A31 VA: 0x10930
	// RVA: 0x2BC5480 Offset: 0x2BC5581 VA: 0x2BC5480
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10940 Offset: 0x10A41 VA: 0x10940
	// RVA: 0x2BC5490 Offset: 0x2BC5591 VA: 0x2BC5490
	public Type get_DeclaringType() { }

	[CompilerGeneratedAttribute] // RVA: 0x10950 Offset: 0x10A51 VA: 0x10950
	// RVA: 0x2BC54A0 Offset: 0x2BC55A1 VA: 0x2BC54A0
	private void set_DeclaringType(Type value) { }

	// RVA: 0x2BC54B0 Offset: 0x2BC55B1 VA: 0x2BC54B0
	public void AddOverload(IOverloadableMemberDescriptor overload) { }

	// RVA: 0x2BC5520 Offset: 0x2BC5621 VA: 0x2BC5520
	public int get_OverloadCount() { }

	// RVA: 0x2BC5570 Offset: 0x2BC5671 VA: 0x2BC5570
	private DynValue PerformOverloadedCall(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	// RVA: 0x2BC6A00 Offset: 0x2BC6B01 VA: 0x2BC6A00
	private void Cache(bool hasObject, CallbackArguments args, IOverloadableMemberDescriptor bestOverload) { }

	// RVA: 0x2BC5BB0 Offset: 0x2BC5CB1 VA: 0x2BC5BB0
	private bool CheckMatch(bool hasObject, CallbackArguments args, OverloadedMethodMemberDescriptor.OverloadCacheItem overloadCacheItem) { }

	// RVA: 0x2BC5DF0 Offset: 0x2BC5EF1 VA: 0x2BC5DF0
	private int CalcScoreForOverload(ScriptExecutionContext context, CallbackArguments args, IOverloadableMemberDescriptor method, bool isExtMethod) { }

	// RVA: 0x2BC6E50 Offset: 0x2BC6F51 VA: 0x2BC6E50
	private static int CalcScoreForSingleArgument(ParameterDescriptor desc, Type parameterType, DynValue arg, bool isOptional) { }

	// RVA: 0x2BC6F30 Offset: 0x2BC7031 VA: 0x2BC6F30
	public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, object obj) { }

	// RVA: 0x2BC7040 Offset: 0x2BC7141 VA: 0x2BC7040 Slot: 4
	private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	// RVA: 0x2BC7350 Offset: 0x2BC7451 VA: 0x2BC7350
	public CallbackFunction GetCallbackFunction(Script script, object obj) { }

	// RVA: 0x2BC73F0 Offset: 0x2BC74F1 VA: 0x2BC73F0 Slot: 5
	public bool get_IsStatic() { }

	// RVA: 0x2BC7520 Offset: 0x2BC7621 VA: 0x2BC7520 Slot: 7
	public MemberDescriptorAccess get_MemberAccess() { }

	// RVA: 0x2BC7530 Offset: 0x2BC7631 VA: 0x2BC7530 Slot: 8
	public DynValue GetValue(Script script, object obj) { }

	// RVA: 0x2BC7610 Offset: 0x2BC7711 VA: 0x2BC7610 Slot: 9
	public void SetValue(Script script, object obj, DynValue value) { }

	// RVA: 0x2BC7620 Offset: 0x2BC7721 VA: 0x2BC7620 Slot: 10
	public void PrepareForWiring(Table t) { }
}

