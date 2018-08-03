﻿using Microsoft.AspNetCore.Mvc;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.DanLiris.Service.Core.Lib.Models;
using Com.DanLiris.Service.Core.WebApi.Helpers;
using Com.DanLiris.Service.Core.Lib.ViewModels;
using Com.DanLiris.Service.Core.Lib;

namespace Com.DanLiris.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-currencies")]
    public class GarmentCurrenciesController : BasicController<GarmentCurrencyService, GarmentCurrency, GarmentCurrencyViewModel, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";

        public GarmentCurrenciesController(GarmentCurrencyService service) : base(service, ApiVersion)
        {
        }
    }
}
