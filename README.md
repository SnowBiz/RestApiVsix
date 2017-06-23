# RestApi

<!-- Replace this badge with your own-->
[![Build status](https://ci.appveyor.com/api/projects/status/ijmh81fe2gi6hk2f?svg=true)](https://ci.appveyor.com/project/SnowBiz/restapivsix)

---------------------------------------

RestApi VSIX Project.

See the [change log](CHANGELOG.md) for changes and road map.

## Project Template Solution

[RestApi Repo](https://github.com/SnowBiz/RestAPI)

### Vsix Installer
This is what manages building out the vsix extension to install the project template.

### Wizard
The Wizard solution is what implements the IWizard interface to tie into the project creation wizard in Visual Studio.

#### Future Plans
Establish a way to include [RestApi Repo](https://github.com/SnowBiz/RestAPI) in this repo and then on build use pre & post build events in combination with custom powershell scripts to create the zip file needed for the vsix installer. This will also include establishing a way to generate the .vstemplate files in a more dynamic process.

## Contribute
Check out the [contribution guidelines](CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE)
