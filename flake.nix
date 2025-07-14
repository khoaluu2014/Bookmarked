{
  description = ".NET development evironment";
  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixos-unstable";
    flake-utils.url = "github:numtide/flake-utils";
  };
  outputs =
    {
      self,
      nixpkgs,
      flake-utils,
    }:
    flake-utils.lib.eachDefaultSystem (
      system:
      let
        pkgs = nixpkgs.legacyPackages.${system};
      in
      {
        devShells.default = pkgs.mkShell {
          packages = [
            pkgs.zsh
            pkgs.starship
            pkgs.dotnetCorePackages.sdk_9_0_3xx
            pkgs.dotnet-ef
          ];
          shellHook = ''
            export NUGET_PACKAGES=$(pwd)/.nuget
            mkdir -p $NUGET_PACKAGES
            exec zsh
          '';
        };
      }
    );
}
