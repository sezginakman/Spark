using System;
using Spark.Abstractions;
namespace Spark.SampleTestJob
{
    public class RunBaby : Job
    {
        public override string Key => "RunBaby";
        public override void CallBack()
        {
            this.Parameter["test"] = "new valueee";
            
            Console.WriteLine("Run Baby");
           
        }
    }
    public class WaitBaby : Job
    {
        public override string Key => "WaitBaby";
        public override void CallBack()
        {
            this.Parameter["test"] = "new WaitBaby";

            Console.WriteLine("Wait Baby");

        }
    }
}
