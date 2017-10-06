using LearnWebAPI.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;

namespace LearnWebAPI.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { OrderID = "1_1", SourceOrderID = 1, SKU = "1342561", SKU_Desc = "Cozy by the Fire™", Quantity = 1, Image = "http://www.yankeecandle.com/media/images/product/small/1342561.jpg" },
            new Order { OrderID = "1_2", SourceOrderID = 1, SKU = "1187884", SKU_Desc = "Apple Cider", Quantity = 3, Image = "http://www.yankeecandle.com/media/images/product/small/1187884.jpg" },
            new Order { OrderID = "2_1", SourceOrderID = 2, SKU = "1241216", SKU_Desc = "Bahama Breeze™", Quantity = 1, Image = "http://www.yankeecandle.com/media/images/product/small/1241216.jpg" },
            new Order { OrderID = "2_2", SourceOrderID = 2, SKU = "1510124", SKU_Desc = "Crisp Fall Night", Quantity = 1, Image = "http://www.yankeecandle.com/media/images/product/small/1510124.jpg" }
        };

        [Route("")]
        [HttpGet]
        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }

        [Route("{order_id}", Name = "GetOrderByOrderID")]
        public HttpResponseMessage GetOrderByOrderID(string order_id) {
            var orderList = orders.Where((o) => o.OrderID == order_id);

            // Write the list to the response body.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orderList);
            return response;

        }

        [Route("{order_id:int}", Name = "GetOrderBySourceOrderID")]
        public IHttpActionResult GetOrderBySourceOrderID(int order_id)
        {
            var orderList = orders.Where((o) => o.SourceOrderID == order_id);
            return Ok(orderList);
        }
    }
}
