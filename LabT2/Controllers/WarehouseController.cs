using LabT2.Data;
using LabT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabT2.Controllers
{
    [Produces("application/json")]
    [Route("api/Warehouse")]
    public class WarehouseController : Controller
    {
        private readonly IApiRequestSend<Warehouse> apiRequestSend;

        public WarehouseController(IApiRequestSend<Warehouse> apiRequestSend)
        {
            this.apiRequestSend = apiRequestSend;
        }

        public void AddWarehouseProduct(Warehouse product)
        {
            apiRequestSend.AddEntity(product);
        }

        public void EditWarehouseProduct(int id, Warehouse product)
        {
            apiRequestSend.ModifyEntity(id, product);
        }

        public void DeleteWarehouseProduct(Warehouse product)
        {
            apiRequestSend.DeleteEntity(product);
        }

        public void GetAll() => apiRequestSend.GetAllData();
    }
}