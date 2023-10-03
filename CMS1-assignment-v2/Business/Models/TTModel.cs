namespace CMS1_assignment_v2.Business.Models
{
	public class TTModel
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Title { get; set; }
		public string LeadText { get; set; }
		public string? Body { get; set; }
		public DateTime? Published { get; set; }
	}
}
