using AutoMapper;
using Buyfilet.DTOs;
using Buyfilet.Entities;

namespace Buyfilet.BLL.Mappings.AutoMapper
{
    public class Profiles:Profile
    {
        public Profiles()
        {
            CreateMap<Product, ProductListDto>().ReverseMap();
            CreateMap<Product, ProductCreateDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();

            CreateMap<CategoryCreateDto ,Category>().ReverseMap();
            CreateMap<CategoryListDto, Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();

            CreateMap<ImageListDto, Image>().ReverseMap();
            CreateMap<ImageCreateDto, Image>().ReverseMap();
            CreateMap<ImageUpdateDto, Image>().ReverseMap();

            CreateMap<CommentListDto, Comment>().ReverseMap();
            CreateMap<CategoryUpdateDto, Comment>().ReverseMap();
            CreateMap<CategoryCreateDto, Comment>().ReverseMap();

            CreateMap<BFUser, BFUserCreateDto>().ReverseMap();
            CreateMap<BFUser, BFUserLoginDto>().ReverseMap();
            CreateMap<BFUser, BFUserListDto>().ReverseMap();

            CreateMap<Seller, SellerCreateDto>().ReverseMap();
            CreateMap<Seller, SellerListDto>().ReverseMap();
            CreateMap<Seller, SellerUpdateDto>().ReverseMap();

            CreateMap<Variant, VariantListDto>().ReverseMap();
            CreateMap<Variant, VariantCreateDto>().ReverseMap();
            CreateMap<Variant, VariantUpdateDto>().ReverseMap();

            CreateMap<QuestionAndAnswer, QuestionAndAnswerCreateDto>().ReverseMap();
            CreateMap<QuestionAndAnswer, QuestionAndAnswerListDto>().ReverseMap();




        }
    }
}
