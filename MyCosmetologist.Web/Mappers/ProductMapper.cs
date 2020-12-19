using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Mappers
{
    public static class ProductMapper
    {
        public static ProductViewModel MapToViewModel(this ProductDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new ProductViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Volume = dto.Volume,
                PriceFirst = dto.PriceFirst,
                PriceLast = dto.PriceLast,
                Quantity = dto.Quantity,
                ProductCategoryId = dto.ProductCategoryId,
                ProductCategoryName = dto.ProductCategoryName,
                ExpirationDate = dto.ExpirationDate
            };
        }
        public static ProductDto MapToDto(this ProductViewModel viewModel)
        {
            if (viewModel == null)
            {
                return null;
            }

            return new ProductDto
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Volume = viewModel.Volume,
                PriceFirst = viewModel.PriceFirst,
                PriceLast = viewModel.PriceLast,
                Quantity = viewModel.Quantity,
                ProductCategoryId = viewModel.ProductCategoryId,
                ExpirationDate = viewModel.ExpirationDate
            };
        }
    }
}
