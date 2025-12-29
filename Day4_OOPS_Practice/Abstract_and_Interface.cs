using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Oops
{
    /// <summary>
    /// Defines a contract for objects that support logging messages.
    /// </summary>
    /// <remarks>Implementations of this interface can be used to record informational, warning, or error
    /// messages. The specific logging mechanism depends on the implementing type.</remarks>
    interface ILoggable { void Log(string message); }
    interface INotifiable { void Notify(string message); }
    /// <summary>
    /// Provides a base class for implementing services that can be started and executed.
    /// </summary>
    /// <remarks>Derive from ServiceBase to create a custom service. Override the Execute method to define the
    /// service's execution logic. The Start method can be used to perform initialization or startup actions before
    /// execution.</remarks>
    abstract class ServiceBase
    {
        protected string ServiceName { get; }
        protected ServiceBase(string serviceName) => ServiceName = serviceName;

        public void Start() => Console.WriteLine($"{ServiceName} started.");
        public abstract void Execute();
    }
    /// <summary>
    /// Provides functionality for executing email-related operations, including logging and notification capabilities.
    /// </summary>
    /// <remarks>EmailService extends ServiceBase and implements ILoggable and INotifiable, allowing
    /// integration with logging and notification systems. This class is typically used to manage the execution of email
    /// pipelines within an application.</remarks>
    class EmailService : ServiceBase, ILoggable, INotifiable
    {
        public EmailService() : base("EmailService") { }

        public override void Execute()
        {
            Log("Executing email pipeline...");
            Notify("Email batch started");
            Console.WriteLine("Sending emails...");
        }

        public void Log(string message) => Console.WriteLine($"[LOG] {message}");
        public void Notify(string message) => Console.WriteLine($"[NOTIFY] {message}");
    }
}
class Abstract_and_Interface
{
    public static void Main()
    {
        var svc = new Capgemini_Training.Oops.EmailService();
        svc.Start();
        svc.Execute();
    }
}
