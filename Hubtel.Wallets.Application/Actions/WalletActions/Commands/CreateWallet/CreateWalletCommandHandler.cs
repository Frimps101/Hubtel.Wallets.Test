using AutoMapper;
using Hubtel.Wallets.Application.DTOs.Wallet.Create;
using Hubtel.Wallets.Application.Persistence.Repositories;
using Hubtel.Wallets.Application.Services;
using Hubtel.Wallets.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Application.Actions.WalletActions.Commands.CreateWallet
{
    public class CreateWalletCommandHandler:IRequestHandler<CreateWalletCommand, BaseResponse>
    {
        private readonly IGenericRepository<CreateWalletDto> _repository;
        private readonly IMapper _mapper;

        public CreateWalletCommandHandler(IGenericRepository<CreateWalletDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(CreateWalletCommand request, CancellationToken cancellationToken)
        {
            var validationResult = (new CreateWalletValidator()).Validate(request.Dto);

            if (!validationResult.IsValid)
            {
                BaseResponse baseResponse = new BaseResponse
                {
                    Success = false,
                    Message = "Could not Create Wallet",
                    Errors = validationResult.Errors.Select(err => err.ErrorMessage).ToList(),
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }

            var dto = request.Dto;
            var Entity = new Wallet();
            var data = _mapper.Map(dto, Entity);

            FormattableString sql = $"sdf";

            var createdData = await _repository.Add(sql);
            BaseResponse baseResponse1 = new BaseResponse()
            {
                Id = createdData,
                Success = true,
                Message = "Wallet created successfully",
                Errors = validationResult.Errors.Select(err => err.ErrorMessage).ToList(),
                StatusCode = StatusCodes.Status400BadRequest
            };
            return baseResponse1;

        }
    }
}
