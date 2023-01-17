// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 1640
{
	// Properties
	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DtdValidation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IValidationEventHandling get_ValidationEventHandling();
}

