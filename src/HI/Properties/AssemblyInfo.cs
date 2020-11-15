using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Nehta.VendorLibrary.HI")]
[assembly: AssemblyDescription("A library for communicating with the HI Service")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Australian Digital Health Agency")]
[assembly: AssemblyProduct("Nehta.VendorLibrary.HI")]
[assembly: AssemblyCopyright("Copyright ©2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e0a9025d-bb60-4a7d-89b0-ce757b0e025c")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.7.0.0")]
[assembly: AssemblyFileVersion("1.7.0.0")]

// Make internal variables visible to specified assembly for testing
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Nehta.VendorLibrary.HI.Test")]