﻿using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Exceptions;

namespace Application.Managers
{
    public class TypeManager
    {
        private readonly ITypeRepository _typeRepository;
        public TypeManager(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public async Task<Guid> CreateAsync(AssetType assetType, CancellationToken cancellationToken)
        {
            var existingTypes = await _typeRepository.FindByNameAsync(assetType.Name, cancellationToken);

            if (existingTypes != null)
                throw new ExistingTypeException("This type alredy exist!");

            var typeId = await _typeRepository.CreateAsync(assetType, cancellationToken);

            return typeId;
        }
    }
}
