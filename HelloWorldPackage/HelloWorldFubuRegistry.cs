using FubuMVC.Core;
using FubuMVC.Spark;
using HelloWorldPackage.Features;

namespace HelloWorldPackage
{
    public class HelloWorldFubuRegistry : FubuPackageRegistry
    {
        public HelloWorldFubuRegistry()
        {
            IncludeDiagnostics(true);

            Applies
                .ToThisAssembly();

            ApplyHandlerConventions<FeaturesMarker>();

            Views
                .TryToAttachWithDefaultConventions();

            this.UseSpark();
        }
    }
}