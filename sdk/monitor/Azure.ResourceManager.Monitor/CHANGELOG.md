# Release History

## 1.3.0-beta.3 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.3.0-beta.2 (2023-06-13)

### Features Added

- Added azure monitor workspaces APIs (version `2023-04-03`)

## 1.3.0-beta.1 (2023-05-30)

### Features Added

- Enable the model factory feature for model mocking, more information can be found [here](https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-mocking-factory-builder).

### Other Changes

- Upgraded dependent Azure.Core to 1.32.0.
- Upgraded dependent Azure.ResourceManager to 1.6.0.

## 1.2.0 (2023-04-24)

### Features Added

- Bump api-version of `DataCollectionRules` to `2022-06-01`
- Bump api-version of `DataCollectionRuleAsociations` to `2022-06-01`
- Bump api-version of `DataCollectionEndpoints` to `2022-06-01`

### Breaking Changes

- Property `MetadataProvisionedBy` on `DataCollectionRuleData` is no longer available for api-version >= `2022-06-01`
- Property `MetadataProvisionedBy` on `DataCollectionRuleAsociationData` is no longer available for api-version >= `2022-06-01`

## 1.1.0 (2023-04-04)

### Other Changes

- Bump api-version of `ActionGroups` to `2023-01-01`.
- Bump api-version of `Metrics` to `2021-05-01`.
- Method `MonitorExtensions.CreateNotifications` and `MonitorExtensions.CreateNotificationsAsync` on `SubscriptionResource` and `ResourceGroupResource` were no longer available for api-version >= `2023-01-01`.
- Method `MonitorExtensions.GetNotificationStatus` and `MonitorExtensions.GetNotificationStatusAsync` on `SubscriptionResource` and `ResourceGroupResource` were no longer available for api-version >= `2023-01-01`.

## 1.0.1 (2023-02-21)

### Other Changes

- Upgraded dependent `Azure.Core` to `1.28.0`.
- Upgraded dependent `Azure.ResourceManager` to `1.4.0`.

## 1.0.0 (2022-09-26)

This release is the first stable release of the Monitor Management library.

### Breaking Changes

- The type of `MonitorScaleCapacity.minimum`, `MonitorScaleCapacity.maximum` and `MonitorScaleCapacity.default` were changed to `integer`.
- The type of `RecurrentSchedule.Days` was changed to `MonitorDayOfWeek`.
- Removed the extension methods `GetDiagnosticSettings` and `GetDiagnosticSetting` that extends from `ArmResource`.

### Other Changes

- Upgraded dependent Azure.ResourceManager to 1.3.1.
- Optimized the implementation of methods related to tag operations.

## 1.0.0-beta.3 (2022-08-29)

### Breaking Changes

- Base type of `ActionGroupData` changed to `Azure.ResourceManager.Models.TrackedResourceData`.
- Base type of `LogSearchRuleData` changed to `Azure.ResourceManager.Models.TrackedResourceData`.
- Type `AzureResource` was removed.
- Base type of `DataCollectionEndpointProperties` changed to `Azure.ResourceManager.Models.TrackedResourceData`.
- Type `ResourceAutoGenerated` was removed.

### Other Changes

- Upgraded dependent `Azure.ResourceManager` to 1.3.0

## 1.0.0-beta.2 (2022-04-08)

### Breaking Changes

- Simplify `type` property names.
- Normalized the body parameter type names for PUT / POST / PATCH operations if it is only used as input.

### Other Changes

- Upgrade dependency to Azure.ResourceManager 1.0.0

## 1.0.0-beta.1 (2022-03-31)

### Breaking Changes

New design of track 2 initial commit.

### Package Name

The package name has been changed from `Microsoft.Azure.Management.Monitor` to `Azure.ResourceManager.Monitor`.

### General New Features
This package follows the [new Azure SDK guidelines](https://azure.github.io/azure-sdk/general_introduction.html), and provides many core capabilities:

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET.
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing.
    - HTTP pipeline with custom policies.
    - Better error-handling.
    - Support uniform telemetry across all languages.

This package is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

> NOTE: For more information about unified authentication, please refer to [Microsoft Azure Identity documentation for .NET](https://docs.microsoft.com//dotnet/api/overview/azure/identity-readme?view=azure-dotnet).
