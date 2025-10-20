# Introduction
The Healthcare Identifiers (HI) Service specifications are one of the foundation services the Agency has provided for eHealth (along with Terminology, Secure Messaging and NASH).

Services Australia has developed and currently operates the HI Service, and publishes the specifications and WSDL/schemas. The specifications and WSDLs can be downloaded from the department’s website (www.humanservices.gov.au/hiservice > Information for Software Vendors developing for the Healthcare Identifiers Service) once a licence agreement has been signed.

The HI Service provides a variety of interfaces for retrieving IHI, HPI-I and HPI-O numbers, as well as a number of maintenance features.

The Healthcare Identifiers B2B Client Library provides vendors with an example implementation of some of these client interfaces in both Java and .net development environments.

# Content
The Healthcare Identifiers B2B Client Library simplifies the development process by providing vendors with a sample implementation of how to interact with the HI Service Endpoints. The library implements only the “Main Search” HI interfaces and operations as listed below.

### Main Search Interfaces
The Main Search interfaces cover all the different types of searches a vendor system would need.

The Read Reference Data is an additional interface that provides all the “static” reference values that are returned in the above searches. This allows for additional values to be added to specific reference sets.

- IHI Inquiry Search via B2B - 3.0 [SIS.6]
- Consumer Search IHI Batch Synchronous - 3.0 [SIS.12]
- Consumer Search IHI Batch Asynchronous - 3.0 [SIS.30]
- Healthcare Provider Directory – Search for Individual Provider Directory Entry – 3.2.0 [SIS.17]
- Healthcare Provider Directory – Search for Organisation Provider Directory Entry – 3.2.0 [SIS.18]
- Search for Provider Individual Details – 5.0.0 [SIS.31]
- Search for Provider Organisation Details – 5.0.0 [SIS.32]
- Search for Provider Individual Batch Asynchronous – 5.1.0 [SIS.33]
- Search for Provider Organisation Batch Asynchronous – 5.1.0 [SIS.34]
- Read Reference Data – 3.2.0 [SIS.22]

### Organisation Maintenance Interfaces
The Organisation Maintenance Interfaces allow a vendor’s software to control and maintain what organisation information is held by the HI Service for a particular HPI-O, and what information is published into the Healthcare Provider Directory. This can be very useful for secure messaging vendors who want to be able to automate the publishing of Endpoint Location Service information.
- Read Provider Organisation Details – 3.2.0 [SIS.16]
- Manage Provider Organisation Details – 3.2.0 [SIS.14]
- Healthcare Provider Directory – Manage Provider Directory Entry– 3.2.0 [SIS.19]

### Provider Maintenance Interfaces
The Provider Maintenance Interfaces allow a vendor’s software to control and maintain what provider or HI User information is held by the HI Service, and what information is published into the Healthcare Provider Directory. For HPI-I information that comes from a trusted data source, their demographic information is read only, but still can be published.
- Read Provider or Administrative Individual Details – 3.2.0 [SIS.15]
- Manage Provider or Administrative Individual Details – 3.2.0 [SIS.13]
- Healthcare Provider Directory – Manage Provider Directory Entry – 3.2.0 [SIS.19]
- Match Provider or Administrative Individual Details – 6.0.0 [SIS.36]

### Consumer Maintenance Interfaces
Emergency departments and maternity units are prime locations for these types of interfaces, but are still being worked out from a workflow perspective.
- Update IHI via B2B – 3.2.0 [SIS.5]

### Consumer Maintenance Interfaces - still being developed
The use cases for the Consumer Maintenance Interfaces are still being developed. Emergency departments and maternity units are prime locations for these types of interfaces, but are still being worked out from a workflow perspective.
- Create Provisional IHI via B2B – 3.0 [SIS.10]
- Update Provisional IHI via B2B – 3.0 [SIS.3]
- Create Unverified IHI via B2B – 3.0.2 [SIS.11]
- Create Verified IHI for Newborn via B2B – 4.0 [SIS.26]
- Resolve Provisional IHI-Merge record via B2B – 3.0 [SIS.8]
- Resolve Provisional IHI – Create Unverified IHI via B2B – 3.0.2 [SIS.9]
- Notify of Duplicate IHI via B2B – 3.2.0 [SIS.24]
- Notify of Replica IHI via B2B – 3.2.0 [SIS.25]

# Common Specifications
There are also a few common specifications, which are useful to read as a starting point.
- HI Service - Developers Guide – 7.1
- HI Service - IHI Searching Guide - 5.0
- Common Functionality Document – 5.0 [SIS.1]
- Common Field Processing Reference Document – 3.1 [SIS.2]


# Project
This is a software library that provides an example implementation of how to connect up to the Healthcare Identifiers Web Services client using .NET.

# Setup
- To build the distributable package, Visual Studio must be installed.
- Start up HI.sln

# Solution
The solution consists of several projects, however the main project is the HI project. 
This project contains the code to communicate with the hi service.

# Building and using the library
The solution can be built using 'F6'. 

# Library Usage
Documentation can be found in the sample project.

# Licensing
See [LICENSE](LICENSE.txt) file.
