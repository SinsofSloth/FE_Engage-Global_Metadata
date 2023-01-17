// Namespace: 
private class OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer : IComparer<IOverloadableMemberDescriptor> // TypeDefIndex: 6114
{
	// Methods

	// RVA: 0x335E570 Offset: 0x335E671 VA: 0x335E570 Slot: 4
	public int Compare(IOverloadableMemberDescriptor x, IOverloadableMemberDescriptor y) { }

	// RVA: 0x335E690 Offset: 0x335E791 VA: 0x335E690
	public void .ctor() { }
}

// Namespace: 
private class OverloadedMethodMemberDescriptor.OverloadCacheItem // TypeDefIndex: 6115
{
	// Fields
	public bool HasObject; // 0x10
	public IOverloadableMemberDescriptor Method; // 0x18
	public List<DataType> ArgsDataType; // 0x20
	public List<Type> ArgsUserDataType; // 0x28
	public int HitIndexAtLastHit; // 0x30

	// Methods

	// RVA: 0x335E560 Offset: 0x335E661 VA: 0x335E560
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xD860 Offset: 0xD961 VA: 0xD860
private sealed class OverloadedMethodMemberDescriptor.<>c__DisplayClass33_0 // TypeDefIndex: 6116
{
	// Fields
	public OverloadedMethodMemberDescriptor <>4__this; // 0x10
	public Script script; // 0x18
	public object obj; // 0x20

	// Methods

	// RVA: 0x335E530 Offset: 0x335E631 VA: 0x335E530
	public void .ctor() { }

	// RVA: 0x335E540 Offset: 0x335E641 VA: 0x335E540
	internal DynValue <GetCallback>b__0(ScriptExecutionContext context, CallbackArguments args) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xD870 Offset: 0xD971 VA: 0xD870
[Serializable]
private sealed class OverloadedMethodMemberDescriptor.<>c // TypeDefIndex: 6117
{
	// Fields
	public static readonly OverloadedMethodMemberDescriptor.<>c <>9; // 0x0
	public static Func<IOverloadableMemberDescriptor, bool> <>9__37_0; // 0x8

	// Methods

	// RVA: 0x335E410 Offset: 0x335E511 VA: 0x335E410
	private static void .cctor() { }

	// RVA: 0x335E480 Offset: 0x335E581 VA: 0x335E480
	public void .ctor() { }

	// RVA: 0x335E490 Offset: 0x335E591 VA: 0x335E490
	internal bool <get_IsStatic>b__37_0(IOverloadableMemberDescriptor o) { }
}

