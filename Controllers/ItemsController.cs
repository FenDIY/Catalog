using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;
    }

    public ItemsController()
    {
        repository = new InMemItemsRepository();
    }

    [HttpGet]
    public IEnumberable<Item> GetItems()
    {
        var items = repository.GetItems();
        return items;
    }
}