using System;
using System.Collections.Generic;
using burgerapi.Models;
using burgerapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgerapi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgersController : ControllerBase
  {
    private readonly BurgerService _bs;
    public BurgersController(BurgerService bs)
    {
      _bs = bs;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> Get()
    {
      return Ok();
    }

    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger burger)
    {
      try
      {

        return Ok();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // [HttpPut("{id}")
    //  public ActionResult<Burger> Edit(int index, [FromBody] Burger burger)
    //  {
    //   try
    //   {
    //     Burger burgerToEdit = Burgers.Find(burger => burger[index] == Burgers[index]);

    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }

  }
}