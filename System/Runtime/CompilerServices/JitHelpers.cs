// Namespace: System.Runtime.CompilerServices
[FriendAccessAllowedAttribute] // RVA: 0x475AC0 Offset: 0x475BC1 VA: 0x475AC0
internal static class JitHelpers // TypeDefIndex: 1278
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2959F80 Offset: 0x295A081 VA: 0x2959F80
	|-JitHelpers.UnsafeCast<object>
	*/

	// RVA: -1 Offset: -1
	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2959F90 Offset: 0x295A091 VA: 0x2959F90
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	*/

	// RVA: -1 Offset: -1
	internal static long UnsafeEnumCastLong<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2959FA0 Offset: 0x295A0A1 VA: 0x2959FA0
	|-JitHelpers.UnsafeEnumCastLong<Int64Enum>
	*/
}

