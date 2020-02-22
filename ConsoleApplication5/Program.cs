using System;

namespace ConsoleApplication5
{
    interface IWorker
    {
        void work();
    }

    class Worker : IWorker
    {
        int workerid;
        public int salary;

    public void work()
    {
            Console.WriteLine("Worker is working");
    }
}

class SuperWorker : IWorker
{

     public void work()
{
           Console.WriteLine("Superwoker is working");
}
}
class RobotWorker: IWorker
{
   public void work()
{
            Console.WriteLine("This is robot worker");
}
}
    class JapanWorker : IWorker
    {
        public void work()
        {
            Console.WriteLine("The Japanese worker is working");
        }
    }
 class GermanWorker: IWorker
    {
        public void work()
        {
            Console.WriteLine("The German worker is working");
        }
    }

class Manager
{
        IWorker worker;
        //Worker worker;

    public void setWorker(IWorker w)
    {
        worker = w;
    }

    public void manage()
    {
        worker.work();
    }
}
    class Entry
    {
        public static void Main()
        {
            Manager obj = new Manager();
            Worker wrk = new Worker();
            SuperWorker swrk = new SuperWorker();
            RobotWorker rwrk = new RobotWorker();
            JapanWorker jpwrk = new JapanWorker();
            GermanWorker grwrk = new GermanWorker();
            obj.setWorker(wrk);
            obj.manage();

            obj.setWorker(swrk);
            obj.manage();

            obj.setWorker(rwrk);
            obj.manage();

            obj.setWorker(jpwrk);
            obj.manage();

            obj.setWorker(grwrk);
            obj.manage();

        }
    }

}
