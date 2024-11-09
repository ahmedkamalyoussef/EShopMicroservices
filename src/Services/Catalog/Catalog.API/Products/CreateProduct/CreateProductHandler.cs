﻿using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, string ImageFile, List<string> Category, decimal Price)
        : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
