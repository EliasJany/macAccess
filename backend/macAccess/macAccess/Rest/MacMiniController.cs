namespace macAccess.Rest
{
    [Route("backend/MacMini")]
    [ApiController]
    public class MacMiniController: ControllerBase
    {
        private readonly MacMiniManager manager;

        public MacMiniController(MacMiniManager manager)
        {
            this.manager = manager;
        }
    }
}
