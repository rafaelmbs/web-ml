using AutoMapper;
using System;
using web_ml.Contracts;
using web_ml.Repository.Views.Items;

namespace web_ml.Repository.Mapping
{
    public class ItemsMapping : Profile
    {
        public ItemsMapping()
        {
            CreateMap<ResultItemsView, ItemsGetResponse>()
                .ForMember(dest => dest.categories, opt => opt.MapFrom(s => s.filters[0].values[0].path_from_root))
                .ForMember(dest => dest.items, opt => opt.MapFrom(s => s.results));

            CreateMap<ResultItemsView, AuthorView>()
                .ForMember(dest => dest.name, opt => opt.MapFrom(s => "Rafael"))
                .ForMember(dest => dest.lastname, opt => opt.MapFrom(s => "Mendes"));

            CreateMap<ResultView, ItemsView>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(s => s.id))
                .ForMember(dest => dest.title, opt => opt.MapFrom(s => s.title))
                .ForMember(dest => dest.price, opt => opt.MapFrom(s => new PriceView()
                {
                    currency = s.currency_id,
                    amount = Convert.ToInt32(s.price),
                    decimals = 0
                }))
                .ForMember(dest => dest.picture, opt => opt.MapFrom(s => s.thumbnail))
                .ForMember(dest => dest.condition, opt => opt.MapFrom(s => s.condition))
                .ForMember(dest => dest.free_shipping, opt => opt.MapFrom(s => s.shipping.free_shipping));
        }
    }
}
