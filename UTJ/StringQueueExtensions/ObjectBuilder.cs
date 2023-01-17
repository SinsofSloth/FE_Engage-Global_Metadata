// Namespace: UTJ.StringQueueExtensions
[ExtensionAttribute] // RVA: 0x5B460 Offset: 0x5B561 VA: 0x5B460
public static class ObjectBuilder // TypeDefIndex: 6431
{
	// Methods

	[ExtensionAttribute] // RVA: 0x5C350 Offset: 0x5C451 VA: 0x5C350
	// RVA: 0x310AB50 Offset: 0x310AC51 VA: 0x310AB50
	public static float DequeueFloat(Queue<string> queue) { }

	[ExtensionAttribute] // RVA: 0x5C360 Offset: 0x5C461 VA: 0x5C360
	// RVA: 0x310ABB0 Offset: 0x310ACB1 VA: 0x310ABB0
	public static int DequeueInt(Queue<string> queue) { }

	[ExtensionAttribute] // RVA: 0x5C370 Offset: 0x5C471 VA: 0x5C370
	// RVA: 0x310AC10 Offset: 0x310AD11 VA: 0x310AC10
	public static Vector3 DequeueVector3(Queue<string> queue) { }

	[ExtensionAttribute] // RVA: 0x5C380 Offset: 0x5C481 VA: 0x5C380
	// RVA: 0x310ACC0 Offset: 0x310ADC1 VA: 0x310ACC0
	public static Transform DequeueTransform(Queue<string> queue, GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x5C390 Offset: 0x5C491 VA: 0x5C390
	// RVA: 0x310B010 Offset: 0x310B111 VA: 0x310B010
	public static Component DequeueComponent(Queue<string> queue, Type type, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	[ExtensionAttribute] // RVA: 0x5C3A0 Offset: 0x5C4A1 VA: 0x5C3A0
	// RVA: -1 Offset: -1
	public static T DequeueComponent<T>(Queue<string> queue, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969CD0 Offset: 0x2969DD1 VA: 0x2969CD0
	|-ObjectBuilder.DequeueComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x5C3B0 Offset: 0x5C4B1 VA: 0x5C3B0
	// RVA: -1 Offset: -1
	public static T DequeueComponent<T>(Queue<string> queue, GameObject rootObject, TypedStringToValueMap valueMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969DE0 Offset: 0x2969EE1 VA: 0x2969DE0
	|-ObjectBuilder.DequeueComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x5C3C0 Offset: 0x5C4C1 VA: 0x5C3C0
	// RVA: 0x310B2E0 Offset: 0x310B3E1 VA: 0x310B2E0
	public static void DequeueFields(Queue<string> queue, Type classType, object item, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	[ExtensionAttribute] // RVA: 0x5C3D0 Offset: 0x5C4D1 VA: 0x5C3D0
	// RVA: -1 Offset: -1
	public static void DequeueFields<T>(Queue<string> queue, T item, string firstOptionalField) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969EB0 Offset: 0x2969FB1 VA: 0x2969EB0
	|-ObjectBuilder.DequeueFields<object>
	*/

	[ExtensionAttribute] // RVA: 0x5C3E0 Offset: 0x5C4E1 VA: 0x5C3E0
	// RVA: 0x310B930 Offset: 0x310BA31 VA: 0x310B930
	public static void DequeueFields(Queue<string> queue, Type classType, object item, string firstOptionalField) { }

	[ExtensionAttribute] // RVA: 0x5C3F0 Offset: 0x5C4F1 VA: 0x5C3F0
	// RVA: -1 Offset: -1
	public static T DequeueObject<T>(Queue<string> queue, string firstOptionalField) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969F50 Offset: 0x296A051 VA: 0x2969F50
	|-ObjectBuilder.DequeueObject<object>
	|-ObjectBuilder.DequeueObject<SpringBoneSerialization.SpringBoneBaseSerializer>
	*/

	[ExtensionAttribute] // RVA: 0x5C400 Offset: 0x5C501 VA: 0x5C400
	// RVA: 0x3108A20 Offset: 0x3108B21 VA: 0x3108A20
	public static object DequeueObject(Queue<string> queue, Type type, string firstOptionalField) { }

	// RVA: 0x310BA70 Offset: 0x310BB71 VA: 0x310BA70
	private static object ParsePrimitiveType(Type type, string valueSource) { }

	// RVA: 0x310BCF0 Offset: 0x310BDF1 VA: 0x310BCF0
	private static object ParseEnum(Type type, string valueSource) { }

	[ExtensionAttribute] // RVA: 0x5C410 Offset: 0x5C511 VA: 0x5C410
	// RVA: 0x310B3C0 Offset: 0x310B4C1 VA: 0x310B3C0
	private static object GetValueByType(Queue<string> queue, Type type, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	[ExtensionAttribute] // RVA: 0x5C420 Offset: 0x5C521 VA: 0x5C420
	// RVA: 0x310C4F0 Offset: 0x310C5F1 VA: 0x310C4F0
	private static Array BuildArray(Queue<string> queue, Type elementType, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	// RVA: 0x310C050 Offset: 0x310C151 VA: 0x310C050
	private static Component FindComponent(Type type, GameObject root, string objectName) { }
}

