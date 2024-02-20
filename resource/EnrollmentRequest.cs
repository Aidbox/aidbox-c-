using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Resource;

public class EnrollmentRequest : DomainResource, IResource
{
	public Base.Identifier[]? Identifier { get; set; }
	public string? Status { get; set; }
	public string? Created { get; set; }
	public Base.ResourceReference? Insurer { get; set; }
	public Base.ResourceReference? Provider { get; set; }
	public Base.ResourceReference? Candidate { get; set; }
	public Base.ResourceReference? Coverage { get; set; }
}