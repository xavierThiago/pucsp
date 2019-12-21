# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.0.9] - 2019-12-21
### Added
- Console logging on HTML builder project's startup.

### Fixed
- HTML builder dockerfile.

## [0.0.8] - 2019-12-21
### Added
- ToHtml method in all HTML elements;
- Unit tests on HTML builder.

### Changed
- Moved several subclasses' methods to the abstract (Node).

### Fixed
- .NET framework target on HTML Builder project.

## [0.0.7] - 2019-12-21
### Added
- Configuration factory;
- Enumeration of some configuration providers;
- JsonFileConfiguration, QueueConfiguration and EnvironmentConfiguration settings providers.

### Fixed
- ConfigurationManager dockefile;
- ConfigurationManager project framework target and output type.

## [0.0.6] - 2019-11-30
### Added
- Created initial DatabaseConnection project, featuring factory, builder and object pool patterns.

### Changed
- ConfigurationManager project framework target to .NETStandar.

## [0.0.5] - 2019-11-30
### Added
- .gitattributes to control eol and other stuff;
- .dockerignore om all projects;
- Dockerfile in all projects to build and execute .NETStandard 2.1;
- HtmlAttribute class;
- Unit tests to validate HTML attribute creation;
- Light DDD file structure in ConfigurationManager project.

### Changed
- Namespace naming.

## [0.0.4] - 2019-11-28
### Added
- Added configuration management project;
- Light DDD project structure.

## [0.0.3] - 2019-11-23
### Added
- RemoteAttribute method in IHtmlElement interface.
- Node class, that will be responsible to manage element's attributes, etc.

### Changed
- Some code organization.

## [0.0.2] - 2019-11-23
### Added
- Initial Configuration and Html Builder .NET projects;
- Initial testing project;
- Representation of some HTML elements;
- Basic HTML elements testing;
- Dockerfile on each project.

### Changed
- Dotnet project's folder structure.

### Fixed
- Encoding and newline feed on every file.

## [0.0.1] - 2019-11-23
### Added
- This changelog.

### Changed
- LICENSE to reflect year and copyrights;
- README description.
