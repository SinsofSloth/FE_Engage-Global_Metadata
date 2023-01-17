// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x471C60 Offset: 0x471D61 VA: 0x471C60
public interface ICustomAttributeProvider // TypeDefIndex: 525
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsDefined(Type attributeType, bool inherit);
}

