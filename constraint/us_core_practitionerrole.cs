using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Constraint;

public class UsCorePractitionerrole : IResource
{
	public Meta Meta { get; set; } = new() { Profile = ["http://hl7.org/fhir/us/core/StructureDefinition/us-core-practitionerrole"] };
	public PractitionerRole_AvailableTime[]? AvailableTime { get; set; }
	public Base.CodeableConcept[]? Specialty { get; set; }
	public PractitionerRole_NotAvailable[]? NotAvailable { get; set; }
	public Base.ResourceReference? Organization { get; set; }
	public bool? Active { get; set; }
	public Base.CodeableConcept[]? Code { get; set; }
	public Base.Identifier[]? Identifier { get; set; }
	public string? AvailabilityExceptions { get; set; }
	public Base.ResourceReference? Practitioner { get; set; }
	public Base.ContactPoint[]? Telecom { get; set; }
	public Base.Period? Period { get; set; }
	public Base.ResourceReference[]? Location { get; set; }
	public Base.ResourceReference[]? Endpoint { get; set; }
	public Base.ResourceReference[]? HealthcareService { get; set; }
	public Base.Narrative? Text { get; set; }
	public Base.Resource[]? Contained { get; set; }
	public Base.Extension[]? Extension { get; set; }
	public Base.Extension[]? ModifierExtension { get; set; }
	public string? Id { get; set; }
	public string? ImplicitRules { get; set; }
	public string? Language { get; set; }

public class PractitionerRole_AvailableTime : BackboneElement
{
	public string[]? DaysOfWeek { get; set; }
	public bool? AllDay { get; set; }
	public string? AvailableStartTime { get; set; }
	public string? AvailableEndTime { get; set; }
}

public class PractitionerRole_NotAvailable : BackboneElement
{
	public required string Description { get; set; }
	public Base.Period? During { get; set; }
}
}