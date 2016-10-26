# NQuantLib64
A free/open-source quantitative finance library written in C++ and connected to C# via SWIG.

Uses QuantLib-1.8 for 64-bit systems.

NuGet Package
-
https://www.nuget.org/packages/NQuantLib64/

How to Create the NQuantLib64 NuGet Package
-
These instructions assume you are using Visual Studio 2013 and NuGet Package Explorer.  Note that some of the sub-steps in steps 4, 12, and 14 may have already been implemented by the QuantLib developers.

1. Download [Boost](http://www.boost.org/users/download/) and build in 64-bit mode.
	1. For help building, go [here](http://www.boost.org/doc/libs/1_61_0/more/getting_started/windows.html) and [here](http://stackoverflow.com/questions/2322255/64-bit-version-of-boost-for-64-bit-windows).
2. Download both [QuantLib and QuantLib-SWIG](https://sourceforge.net/projects/quantlib/files/QuantLib/).
3. Open the QuantLib solution.
4. In the QuantLib project Properties, perform the following settings for Configuration **All Configurations** and Platform **All Platforms**:
	1. Set **General**->**Output Directory** to **lib\$(Platform)\**.
	2. Set **General**->**Intermediate Directory** to **build\$(qlCompilerTag)\$(Platform)\$(Configuration)\**.
	3. Set **VC++ Directories**->**Include Directories** to the Boost directory (e.g., *C:\boost_1_61_0*).
	4. Set **VC++ Directories**->**Library Directories** to the Boost library file (e.g., *C:\boost_1_61_0\lib64-msvc-12.0*).
5. Close the QuantLib project Properties.
6. Set the **Configuration Manager**->**Active solution platform** to **x64**.
7. Build the QuantLib project in both **Debug** and **Release** modes.
8. Close the QuantLib solution.
9. Add **QL_DIR** to your environmental variables and set it to the QuantLib directory (e.g., *C:\QuantLib-1.8*)
10. Run **swig.cmd** in the QuantLib-SWIG C# solution directory.
11. Open the QuantLib-SWIG C# solution.
12. In the NQuantLibc project Properties, perform the following settings for Configuration **All Configurations** and Platform **All Platforms**:
	1. Set **General**->**Output Directory** to **bin\$(qlCompilerTag)\$(Platform)\$(Configuration)\**.
	2. Set **General**->**Intermediate Directory** to **build\$(qlCompilerTag)\$(Platform)\$(Configuration)\**.
	3. Set **Linker**->**General** to **$(QL_DIR)\lib\$(Platform)**.
13. Close the QuantLib-SWIG C# project Properties.
14. In the NQuantLib project Properties, perform the following settings for Platform **x64**:
	1. For **Configuration** set to **Debug**, set **Build**->**Output path** to **bin\x64\Debug\**.
	2. For **Configuration** set to **Release**, set **Build**->**Output path** to **bin\x64\Release\**.
15. Build the NQuantLib project in both **Debug** and **Release** modes.
16. Close the QuantLib-SWIG C# solution.
17. Follow this [tutorial](https://docs.nuget.org/create/using-a-gui-to-build-packages) on how to build your NuGet package.
