﻿namespace ECommerce.Catalog.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }
        public string? Description { get; set; }
        public string CategoryId { get; set; }
    }
}
