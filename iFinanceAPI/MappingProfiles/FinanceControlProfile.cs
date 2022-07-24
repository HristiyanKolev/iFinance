using AutoMapper;

using InputModels.FinanceControlInputModels;
using FinanceControlServices.Models;
using ResponseModels.FinanceControlResponseModels;

namespace iFinanceAPI.MappingProfiles
{
    public class FinanceControlProfile : Profile
    {
        public FinanceControlProfile()
        {
            CreateMap<EntityInputModel, EntityServiceModel>();
            CreateMap<EntityServiceModel, EntityResponseModel>();

            CreateMap<MonthlyBalanceInputModel, MonthlyBalanceServiceModel>();
            CreateMap<MonthlyBalanceServiceModel, MonthlyBalanceResponseModel>();

            CreateMap<QuarterlyBalanceInputModel, QuarterlyBalanceServiceModel>();
            CreateMap<QuarterlyBalanceServiceModel, QuarterlyBalanceResponseModel>();

            CreateMap<RecurringEntityInputModel, RecurringEntityServiceModel>();
            CreateMap<RecurringEntityServiceModel, RecurringEntityResponseModel>();

            CreateMap<YearlyBalanceInputModel, YearlyBalanceServiceModel>();
            CreateMap<YearlyBalanceServiceModel, YearlyBalanceResponseModel>();
        }
    }
}
