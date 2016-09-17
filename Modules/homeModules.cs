using Nancy;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      View["index.cshtml"];


    }


  }
}
