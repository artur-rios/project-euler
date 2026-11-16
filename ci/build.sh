#!/bin/sh
# The `build` check: restore, build the solution in Release and run its xunit tests
# (tests/ArturRios.ProjectEuler.Tests). The problems project, the utils and the tests all target net10.0: the
# pinned .NET 10 SDK image builds all three and runs the tests on its .NET 10 runtime.
#
# yggdrasil.yml runs it in that image from the repository's root; by hand, from that root:
#   docker run --rm -v "$PWD:/src" -w /src <image> sh ci/build.sh
# or, with the .NET 10 SDK installed, just `sh ci/build.sh`.
set -eu

# The repository's root, wherever this is run from.
cd "$(dirname "$0")/.."

export DOTNET_CLI_TELEMETRY_OPTOUT=1 DOTNET_NOLOGO=1

solution=ArturRios.ProjectEuler.sln
dotnet restore "$solution"
dotnet build "$solution" --no-restore --configuration Release
dotnet test "$solution" --no-build --configuration Release
