// Namespace: System.Xml
internal interface IDtdParser // TypeDefIndex: 1638
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
}

