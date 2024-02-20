using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Constraint;

public class MoneyQuantity : IResource
{
	public Meta Meta { get; set; } = new() { Profile = ["http://hl7.org/fhir/StructureDefinition/MoneyQuantity"] };
	public string? Value { get; set; }
	public string? Comparator { get; set; }
	public string? Unit { get; set; }
	public string? System { get; set; }
	public string? Code { get; set; }
	public string? Id { get; set; }
	public Base.Extension[]? Extension { get; set; }
}