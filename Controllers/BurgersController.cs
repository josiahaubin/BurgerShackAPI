using System;
using System.Collections.Generic;
using burgerapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgerapi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgerController : ControllerBase
  {
    List<Burger> Burgers = new List<Burger>(){
      new Burger("Cheezeburger", "Issa cheezeburger", 9.99),
      new Burger("Mushroom Swiss", "Its got mushrooms and swiss", 10.00),
      new Burger("Ham and Egg", "Burger with Ham and an egg on it", 12.00)
    };

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> Get()
    {
      return Ok(Burgers);
    }

    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger burger)
    {
      try
      {
        Burgers.Add(burger);
        return Ok(Burgers);
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