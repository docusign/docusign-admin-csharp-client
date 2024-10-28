# DocuSign Admin C# Client Changelog
See [DocuSign Support Center](https://support.docusign.com/en/releasenotes/) for Product Release Notes.

## [v2.0.0] - Admin API v2.1-1.4.1 - 2024-10-28
### Changed
- Added support for version v2.1-1.4.1 of the DocuSign Admin API.
- Fixes deserialization issue of text/csv type response
- Removed the staging base path and OAuth path constant.
- Updated the SDK release version.

## [v2.0.0-rc5] - Admin API v2.1-1.4.1 - 2024-10-22
### Changed
- Added support for version v2.1-1.4.1 of the DocuSign Admin API.
- Fixes deserialization issue of text/csv type response
- Removed the staging base path and OAuth path constant.
- Updated the SDK release version.

## [v2.0.0-rc4] - Admin API v2.1-1.4.0 - 2024-08-27
### Breaking Changes
<details>
<summary>API Changes (Click to expand)</summary>

<br/>
<div style="margin-left: 20px;">

Added new query parameter "include_ds_groups" to the API "/v2/organizations/{organizationId}/users":

<h3>Added New APIs for Account Creation</h3>
<li>GET: get subscription details for organization</li>
<li>POST: initiate Create account request</li>
<li>GET: get ongoing process details by org ID</li>
<li>GET: get individual process details by org ID, asset group ID, asset group work ID</li>


</div>
</details>
 
### Other Changes
- Improved error logging capabilities for the SDK
- Introduced async versions of `ApiClient` authorization methods.
- Added support for version v2.1-1.4.0 of the DocuSign Admin API.
- Updated the SDK release version.

## [v2.0.0-rc3] - Admin API v2.1-1.3.0 - 2024-05-20
### Changed
- Updated C# SDK dependencies.
    - BouncyCastle.Cryptography: Version bumped from 2.3.0 to 2.3.1.
    - Microsoft.IdentityModel.JsonWebTokens: Version bumped from 7.5.1 to 7.5.2.
## [v2.0.0-rc2] - Admin API v2.1-1.3.0 - 2024-04-29
### Breaking Changes
- Updated from System.IdentityModel.Tokens.Jwt to Microsoft.IdentityModel.JsonWebTokens for token handling.
## [v2.0.0-rc1] - Admin API v2.1-1.3.0 - 2024-04-05
### Breaking Changes
- Updated C# SDK dependencies.
    - Microsoft.CSharp: Version bumped from 4.5.0 to 4.7.0.
    - Newtonsoft.Json: Version bumped from 13.0.1 to 13.0.3.
    - System.ComponentModel.Annotations: Version bumped from 4.5.0 to 5.0.0.
    - Microsoft.IdentityModel.Protocols: Version bumped from 5.4.0 to 7.3.1.
    - System.IdentityModel.Tokens.Jwt: Version bumped from 5.4.0 to 7.3.1.
    - BouncyCastle.Cryptography: Version bumped from 2.2.1 to 2.3.0.
### Changed
- Updated the SDK release version.
## [v1.4.1] - Admin API v2.1-1.3.0 - 2023-12-15
### Changed
- Updated the SDK release version.
- Removed tracked files which are now present in .gitignore.

## [v1.4.0] - Admin API v2.1-1.3.0 - 2023-08-02
### Changed
- Added support for version v2.1-1.3.0 of the DocuSign Admin API.
- Updated the SDK release version.

New endpoints:
* `GET /v1/organizations/{organizationId}/assetGroups/accounts` Get asset group accounts for an organization.
* `POST /v1/organizations/{organizationId}/assetGroups/accountClone` Clone an existing DocuSign account.
* `GET /v1/organizations/{organizationId}/assetGroups/accountClones` Gets all asset group account clones for an organization.
* `GET /v1/organizations/{organizationId}/assetGroups/{assetGroupId}/accountClones/{assetGroupWorkId}` Gets information about a single cloned account.
## [v1.3.0] - Admin API v2.1-1.2.0 - 2023-05-10
### Changed
- Removed support for .NET Framework 4.5.2. Miminum requirement is now .NET Framework 4.6.2
- Removed [BouncyCastle.Crypto](https://www.nuget.org/packages/BouncyCastle) and [Portable.BouncyCastle](https://www.nuget.org/packages/Portable.BouncyCastle) dependencies as they've been deprecated and added [BouncyCastle.Cryptography](https://www.nuget.org/packages/BouncyCastle.Cryptography) which is the recommended replacement and is being maintained.
- Added support for version v2.1-1.2.0 of the DocuSign Admin API.
- Updated the SDK release version.

## [v1.2.0] - Admin API v2.1-1.1.1 - 2023-03-22
### Changed
- Added support for version v2.1-1.1.1 of the DocuSign Admin API.
- Updated the SDK release version.

## [v1.1.0] - Admin API v2.1-1.1.0 - 2022-04-26
### Changed
- Added support for version v2.1-1.1.0 of the DocuSign Admin API.
- Updated the SDK release version.

## [v1.0.0] - DocuSign Admin API v2.1-1.0.0 - 09/22/2021
### Changed
- Added support for version v2.1-1.0.0 of the DocuSign Admin API.
- Updated the SDK release version.

## [v1.0.0-beta] - DocuSign Admin API v2.1-1.0.0 - 09/02/2021
### Changed
- First Beta version of DocuSign Admin API.


