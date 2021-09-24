using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    /// <summary>
    /// Class Behavior.
    /// </summary>
    /// <seealso cref="IEndpointBehavior" />
    public class Behavior : IEndpointBehavior
    {
        /// <summary>
        /// The inspector
        /// </summary>
        protected readonly Inspector inspector;

        /// <summary>
        /// Initializes a new instance of the <see cref="Behavior" /> class.
        /// </summary>
        /// <param name="inspector">The inspector.</param>
        public Behavior(Inspector inspector)
        {
            this.inspector = inspector;
        }

        /// <summary>
        /// Adds the binding parameters.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="bindingParameters">The binding parameters.</param>
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        /// <summary>
        /// Applies the client behavior.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="clientRuntime">The client runtime.</param>
        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            this.inspector.OriginalNamespace = endpoint.Contract.Namespace;
            clientRuntime.ClientMessageInspectors.Add(this.inspector);
        }

        /// <summary>
        /// Applies the dispatch behavior.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="endpointDispatcher">The endpoint dispatcher.</param>
        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        /// <summary>
        /// Validates the specified endpoint.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        public void Validate(ServiceEndpoint endpoint)
        {
        }
    }
}
