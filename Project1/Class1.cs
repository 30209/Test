using System.Web.Mvc;

namespace Fonlow.WebApiClientGen
{
    [Route("api/[controller]")]
    public class ConectionControler : ControllerBase
    {
        /// <summary>
        /// Trigger the API to generate WebApiClientAuto.cs for an established client API project.
        /// </summary>
        /// <param name="settings"></param>
        /// <returns>OK if OK</returns>
        [HttpPost]
        public int Post()
        {
            return 1;
        }

        protected override void ExecuteCore()
        {
            throw new System.NotImplementedException();
        }
    }
}