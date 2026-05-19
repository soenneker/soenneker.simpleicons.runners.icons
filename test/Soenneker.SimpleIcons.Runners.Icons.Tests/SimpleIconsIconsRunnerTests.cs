using Soenneker.SimpleIcons.Runners.Icons.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.SimpleIcons.Runners.Icons.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SimpleIconsIconsRunnerTests : HostedUnitTest
{
    private readonly ISimpleIconsIconsRunner _runner;

    public SimpleIconsIconsRunnerTests(Host host) : base(host)
    {
        _runner = Resolve<ISimpleIconsIconsRunner>(true);
    }

    [Test]
    public void Default()
    {

    }
}
