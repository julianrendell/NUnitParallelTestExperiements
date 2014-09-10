# What's This?

Some early experiments with the development branch of [NUnit's](nunit) support for parallel test execution, particularly with thoughts to Selenium and similar UI/integration tests.

## Introductory Notes

NUnit is split up into several repos/projects on GitHub.

All the dev notes are on the GitHub wiki of the [dev repo](nu-dev-wiki). This is not at all obvious; there aren't any links to this from any of the other repos or project wikis.

Don't try running these test cases using Resharper/other NUnit 2.6 runners. It won't work. 

## Levels of Parallelism

###[Engine Level](https://github.com/nunit/dev/wiki/Engine-Parallel-Test-Execution)

Running tests in different assemblies (dlls) at the same time.
There will be control over how processes are partitioned between app domains and processes.

The notes make it sound like this is working, but (as of 9/9/2014) `--process=Multiple` is not supported in the versions of the nunit runner included in the [framework](nu-framework) or [console runner](nu-console) repos.

### [Framework Level](https://github.com/nunit/dev/wiki/Framework-Parallel-Test-Execution)

This wiki page seems to be up-to-date.

This supports/will support running multiple testcases from the same fixture, or fixtures in the same assembly.

The `[Parallelizable]` attribute works.

Exclusion groups will allow you to tag groups of tests. There will only ever be a single test from an exclusion group running. They are yet to be implemented.

At present tests from different test fixtures but the same assembly will be executed in parallel. All other configurations result in sequential test execution.

### PNUnit

Probably not what you're looking for.  It's a way to coordinate tests running on multiple machines- eg be able to (re)use a test running on one machine interacting with an API, and another, running else-where, verifying a change in a client UI.


## Example Execution

```
C:\dev>nunit-framework\bin\Debug\nunit-console.exe --workers=8 --process=Multiple --domain=Multiple NunitParallelTestExperiments\src\NunitParallelTestExperimentsAssembly1\bin\Debug\NunitParallelTestExperimentsAssembly1.dll NunitParallelTestExperiments\src\NunitParallelTestExperimentsAssembly2\bin\Debug\NunitParallelTestExperimentsAssembly2.dll
```


[nunit]: https://github.com/nunit
[nu_framework]: https://github.com/nunit/nunit-framework.git
[nu-console]: https://github.com/nunit/nunit-console.git
[nu-dev-wiki]: https://github.com/nunit/dev.git