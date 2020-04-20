<img src=".docs/img/styleguide.svg" width="500" />


The SXA Styleguide is an education site based on SXA that helps explaining the inner working and illustrating best practices. 

It should not be considered as a demo environment for SXA or Sitecore in general. For demo purposes we like to refer you to [Habitat Home](https://github.com/Sitecore/Sitecore.HabitatHome.Platform), the official demo environment maintained by Sitecore and available as open-source.

![](.docs/img/home.png)


## Requirements
The Styleguide is built to support **[Sitecore Experience Platform 9.3](https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/93/Sitecore_Experience_Platform_93_Initial_Release.aspx)** using **[Sitecore Experience Accelerator (SXA) 9.3](https://dev.sitecore.net/Downloads/Sitecore_Experience_Accelerator/9x/Sitecore_Experience_Accelerator_930.aspx)**.

## Installation
You can install the styleguide on a Sitecore 9.3 instance with SXA 9.3 installed. Installation can be done using the package you can download from the [releases page](https://github.com/markvanaalst/SXA.Styleguide/releases).

1. Clone or copy the repository
2. Open `SXA.Styleguide.sln` in Visual Studio 2019
3. Set local publish target
   1. Remove .example from the filename `build\props\Website.Publishing.props.user.example`
   2. Set PublishRootDirectory variable in the file to path your local Sitecore instance
4. Change Unicorn serialization folder location
   1. Open `src\Project\Website\website\App_Config\Include\Project\Styleguide.Project.Website\Styleguide.Project.Website.config`
   2. Change `serializationFolder` to your local folder e.g. `C:\inetpub\wwwroot\INSTANCENAME\App_Data\Unicorn\sxa-styleguide`
5. Rebuild solution

## Acknowledgements

I would like to thank the following people for their support and contributions:
- [Michael West](http://twitter.com/michaelwest101) for adding Docker support
- [Sebastian Winter](http://twitter.com/lovesitecore) for all the feedback provided
- [Adam Najmanowicz](http://twitter.com/adamnaj) for reviewing, feedback and his patience :-)
***
#### Support
The code, samples and/or solutions provided in this repository are unsupported by Sitecore Support. Support is provided on a best-effort basis via GitHub issues.

It is assumed that you already have a working instance of Sitecore XM and all prerequisites prior to installing the demo. Support for product installation issues should be directed to relevant Community channels or through regular Sitecore support channels.

#### Warranty
The code, samples and/or solutions provided in this repository are for example purposes only and without warranty (expressed or implied). The code has not been extensively tested and is not guaranteed to be bug free.

