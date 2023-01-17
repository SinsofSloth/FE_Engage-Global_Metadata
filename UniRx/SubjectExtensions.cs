// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12F10 Offset: 0x13011 VA: 0x12F10
public static class SubjectExtensions // TypeDefIndex: 6647
{
	// Methods

	[ExtensionAttribute] // RVA: 0x160D0 Offset: 0x161D1 VA: 0x160D0
	// RVA: -1 Offset: -1
	public static ISubject<T> Synchronize<T>(ISubject<T> subject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20232A0 Offset: 0x20233A1 VA: 0x20232A0
	|-SubjectExtensions.Synchronize<object>
	*/

	[ExtensionAttribute] // RVA: 0x160E0 Offset: 0x161E1 VA: 0x160E0
	// RVA: -1 Offset: -1
	public static ISubject<T> Synchronize<T>(ISubject<T> subject, object gate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023320 Offset: 0x2023421 VA: 0x2023320
	|-SubjectExtensions.Synchronize<object>
	*/
}

