using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace BugRepro {
  public class ServiceHostFactory : AutofacWebServiceHostFactory {

    public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses) {
      Container = new ContainerBuilder().Build(); 
      
      // Service not registered. Expecting InvalidOperationException, getting NRE instead.

      return base.CreateServiceHost(constructorString, baseAddresses);
    }
  }
}