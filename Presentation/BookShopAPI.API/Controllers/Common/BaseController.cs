﻿using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Cryptography;

namespace BookShopAPI.API.Controllers.Common
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        public readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [NonAction]
        public async Task<IActionResult> NoDataResponse(IRequest<BaseResponse> request)
        {
            var response = await _mediator.Send(request);

            if(!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [NonAction]
        public async Task<IActionResult> DataResponse<TResponseParameters>(IRequest<BaseDataResponse<TResponseParameters>> request)
            where TResponseParameters : class , new()
        {
            var response = await _mediator.Send(request);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
    }
}