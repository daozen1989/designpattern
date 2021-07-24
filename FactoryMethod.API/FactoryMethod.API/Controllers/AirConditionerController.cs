using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethod.API.BuilderPattern;
using FactoryMethod.API.Services.Factories.abstracts;
using FactoryMethod.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMethod.API.Controllers
{
    [Route("api/[controller]")]
    public class AirConditionerController : Controller
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;

        public AirConditionerController()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>();
            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                var actionClassName = "FactoryMethod.API.Services.Factories." + Enum.GetName(typeof(Actions), action) + "Factory";

                AirConditionerFactory factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType(actionClassName));
                _factories.Add(action, factory);
            }
        }

        private IAirConditioner ExecuteCreation(Actions action) => _factories[action].Create();

        [HttpGet("method/{actionParams}/{degrees}")]
        public string GetMethod(Actions actionParams, string degrees)
        {
            var factory = ExecuteCreation(actionParams);

            var builderResult = new CarBuilder()
                .SetAddress("119 Binh Long")
                .SetType("sedan")
                .SetCity("HCM")
                .SetColor("blue")
                .SetNumberOfDoors(2)
                .Build();

            return factory.Operate(degrees) + "-----" + builderResult;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
