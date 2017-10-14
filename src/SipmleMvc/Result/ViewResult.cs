namespace SipmleMvc
{
    public abstract class ViewResult : ActionResult
    {
        public abstract void ExecuteResult(ControllerContext context);
    }
}