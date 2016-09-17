using Nancy;
using System;
using WordCounter;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
          return View["index.cshtml"];
       };
     Post["/results"] = _ => {
       RepeatCounter checkWord = new RepeatCounter (
         Request.Form["word"],
         Request.Form["sentence"]
       );
       return View["results.cshtml", checkWord];
     };

   }
 }
}
