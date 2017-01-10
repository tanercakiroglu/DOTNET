using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace BuySellRent
{
    public sealed class AutomapServiceBehavior : Attribute, IServiceBehavior
    {
        public AutomapServiceBehavior()
        {
        }

        #region IServiceBehavior Members

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase,
            Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            AutomapBootstrap.InitializeMap();
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
        }

        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
        }

        #endregion
    }
}
