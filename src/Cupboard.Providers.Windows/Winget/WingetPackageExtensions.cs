namespace Cupboard
{
    public static class WingetPackageExtensions
    {
        public static IResourceBuilder<WingetPackage> Ensure(this IResourceBuilder<WingetPackage> builder, PackageState state)
        {
            return builder.Configure(pkg => pkg.Ensure = state);
        }

        public static IResourceBuilder<WingetPackage> Package(this IResourceBuilder<WingetPackage> builder, string package)
        {
            return builder.Configure(pkg => pkg.Package = package);
        }

        public static IResourceBuilder<WingetPackage> Force(this IResourceBuilder<WingetPackage> builder, bool force)
        {
            return builder.Configure(pkg => pkg.Force = force);
        }

        public static IResourceBuilder<WingetPackage> PackageVersion(this IResourceBuilder<WingetPackage> builder, string version)
        {
            return builder.Configure(pkg => pkg.PackageVersion = version);
        }
    }
}
