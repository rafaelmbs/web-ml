using AutoMapper;
using System;
using web_ml.Contracts;
using web_ml.Repository.Views.ItemDetail;

namespace web_ml.Repository.Mapping
{
    public class ItemDetailMapping : Profile
    {
        public ItemDetailMapping()
        {
            CreateMap<ResultItemDetailView, ItemDetailGetResponse>()
                .ForMember(dest => dest.author, opt => opt.MapFrom(s => new AuthorView()
                {
                    name = "Rafael",
                    lastname = "Mendes"
                }))
                .ForMember(dest => dest.item, opt => opt.MapFrom(s => s));

            CreateMap<ResultItemDetailView, ItemDetailView>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.title, opt => opt.MapFrom(src => src.title))
                .ForMember(dest => dest.price, opt => opt.MapFrom(src => new PriceView()
                {
                    currency = src.currency_id,
                    amount = Convert.ToInt32(src.price),
                    decimals = 0
                }))
                .ForMember(dest => dest.picture, opt => opt.MapFrom(src => src.thumbnail))
                .ForMember(dest => dest.condition, opt => opt.MapFrom(src => src.condition))
                .ForMember(dest => dest.free_shipping, opt => opt.MapFrom(src => src.shipping.free_shipping))
                .ForMember(dest => dest.sold_quantity, opt => opt.MapFrom(src => src.sold_quantity))
                .ForMember(dest => dest.description, opt => opt.MapFrom(src => GetDescritption(src.currency_id)));
        }

        private string GetDescritption(string id)
        {
            return "Description";
        }
    }
}
