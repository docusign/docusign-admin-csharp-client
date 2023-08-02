# DocuSign Admin C# Client Changelog
See [DocuSign Support Center](https://support.docusign.com/en/releasenotes/) for Product Release Notes.

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


