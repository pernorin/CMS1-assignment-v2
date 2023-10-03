using CMS1_assignment_v2.Business.ScheduleJobs;

namespace CMS1_assignment_v2.Business.Registers
{
	public static class UmbracoBuilderHostedServiceExtensions
	{
		public static IUmbracoBuilder AddCustomHostedServices(this IUmbracoBuilder
		builder)
		{
			builder.Services.AddHostedService<TTImport>();
			return builder;
		}
	}
}
