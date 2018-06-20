using System;
using Xunit;
using Moq;
using LabT2.Data;
using LabT2.Models;
using LabT2.Controllers;

namespace LabT2_Test
{
    public class WarehouseTest
    {
        [Fact] // GetAllData_CallsGetAllDataOnce
        public void Data_TryGetAllData()
        {
            var MockRequest = new Mock<IApiRequestSend<Warehouse>>();
            var itemController = new WarehouseController(MockRequest.Object);

            itemController.GetAll();

            MockRequest.Verify(m => m.GetAllData(), Times.Once());
        }

        private Warehouse ProductUsedForTesting()
        {
            return new Warehouse()
            {
                Id = 555,
                Product = "Bag of luck",
                Value = 10,
                Quantity = 1000,
                Section = "Unclear"
            };
        }

        [Fact] // AddStorageSort_CallsAddEntityOnce
        public void Item_TryAddItem()
        {
            var item = ProductUsedForTesting();
            var MockRequest = new Mock<IApiRequestSend<Warehouse>>();
            var itemController = new WarehouseController(MockRequest.Object);

            itemController.AddWarehouseProduct(item);
            MockRequest.Verify(m => m.AddEntity(item), Times.Once);
        }

        [Fact]
        public void Item_TryModifyItem()
        {
            var item = ProductUsedForTesting();
            var MockRequest = new Mock<IApiRequestSend<Warehouse>>();
            var itemController = new WarehouseController(MockRequest.Object);

            itemController.EditWarehouseProduct(item.Id, item);
            MockRequest.Verify(m => m.ModifyEntity(item.Id, item), Times.Once);
        }

        [Fact]
        public void Item_TryDeleteItem()
        {
            var product = ProductUsedForTesting();
            var MockRequest = new Mock<IApiRequestSend<Warehouse>>();
            var itemController = new WarehouseController(MockRequest.Object);

            itemController.DeleteWarehouseProduct(product);
            MockRequest.Verify(m => m.DeleteEntity(product), Times.Once);
        }
    }
}
