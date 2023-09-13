﻿using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.ActivateMailAuthentication
{
    public class ActivateMailAuthenticationCommandRequest : IRequest<BaseResponse>
    {
        public string? Email { get; set; }
        public string? ActivationCode { get; set; }
    }
}