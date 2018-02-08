using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using HealthCare.Authorization;
using HealthCare.TestingFirstApi;

namespace HealthCare {
    [DependsOn(
        typeof(HealthCareCoreModule),
        typeof(AbpAutoMapperModule))]
    public class HealthCareApplicationModule : AbpModule {
        public override void PreInitialize() {
            Configuration.Authorization.Providers.Add<HealthCareAuthorizationProvider>();
        }

        public override void Initialize() {
            var thisAssembly = typeof(HealthCareApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
