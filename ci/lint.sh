#!/bin/sh
# The `lint` check: `dotnet format --verify-no-changes` over the solution, which fails when a whitespace, code
# style or analyzer fix would change a file (the SDK's defaults: the repository has no .editorconfig of its own).
# `dotnet format ArturRios.ProjectEuler.sln` applies the same fixes. Only the solution's projects are covered:
# src/TechCraftsmen.ProjectEuler has no project file, so nothing builds or formats it.
#
# yggdrasil.yml runs it in the pinned .NET SDK image from the repository's root; by hand, from that root:
#   docker run --rm -v "$PWD:/src" -w /src <image> sh ci/lint.sh
# or, with the .NET 10 SDK installed, just `sh ci/lint.sh`.
set -eu

# The repository's root, wherever this is run from.
cd "$(dirname "$0")/.."

export DOTNET_CLI_TELEMETRY_OPTOUT=1 DOTNET_NOLOGO=1

dotnet format ArturRios.ProjectEuler.sln --verify-no-changes --verbosity minimal
