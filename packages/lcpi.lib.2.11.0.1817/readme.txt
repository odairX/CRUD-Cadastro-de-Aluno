README - LCPI Instrumental Library.

=================================================================
Description:

This package contains common structures for LCPI software.

Home Page:
 http://www.ibprovider.com

Contact E-Mail:
 ibprovider@ibprovider.com

=================================================================
ChangeLog:

v2.11.0
* Added a support for .NET6.0 (Windows)

* Changes in lcpi.lib.oledb:
 - [added] tagDBDATE.Create(DateOnly)
 - [added] tagDBDATE.ToDateOnly()
 - [added] tagDBTIME.Create(TimeOnly)
 - [added] tagDBTIME.ToTimeOnly()
 - [added] tagDBTIME2.Create(TimeOnly)
 - [added] tagDBTIME2.ToTimeOnly()
 - [added] tagTIMESTAMP.Create(DateOnly)
 - [added] tagTIMESTAMP.ToDateOnly()
 - [added] DBBindDataWriter::DBDATE

* Common improvement of code

Assembiles for .NET6 were compiled by VS2019 CE 16.11.0 Preview 2.0.

v2.10.0
* Added support for:
 - .NET Standard 2.1
 - .NET 5.0 (Windows)

v2.9.0
* New implementation of lcpi.lib.structure.ParameterList
 - More stringent text processing
 - [del] Add methods
 - [new] AddNew, AddOrReplace, TryAdd methods

v2.8.0
* [new] oledb.TDBProperty.Clone

v2.7.0
Reorganization
* [del] lcpi.lib.oledb.StdPropID.IBP_Init

These identifiers now defined in "lcpi.sdk.ibprovider.v05" nuget package.

Provider from "lcpi.data.oledb" uses own, private copy of these identifiers.

v2.6.0.1722
* static class lcpi.lib.oledb.StdPropID.IBP_Init
  - [add] IBP_DBPROP__INIT__REMOTE__WIRE_COMPRESSION
  - [add] IBP_DBPROP__INIT__REMOTE__WIRE_COMPRESSION_LIBRARY
  - [add] IBP_DBPROP__INIT__REMOTE__WIRE_COMPRESSION_LIBRARY_64
  - [add] IBP_DBPROP__INIT__REMOTE__WIRE_COMPRESSION_TYPE

v2.5.1.1719
* Assemblies for .NET FW4.8 are now compiled in VS2017
  - was: VS2019

v2.5.0.1716
* Added support for FW4.8

v2.4.0.1710
* New class lcpi.lib.com.IPersist
* New data lcpi.lib.com.StdComIID.IID_IPersist
* New data lcpi.lib.com.NativeFunctions.ProgIDFromCLSID
* New method lcpi.lib.com.ClsidUtils.ProgIDFromCLSID
* New method lcpi.lib.structure.ParameterList.CreateTextElement

v2.3.0.1701
* class structure.DecimalUtils
   - [add] public static MpNum10 ToMpNum10(System.Decimal value)
   - [add] public static System.Decimal ToDecimal(MpNum10 value)
   - [add] public static System.Decimal ToDecimal(MpNum10 value,bool isNegative,byte scale)
   - [add] public static System.Decimal Round(System.Decimal value,int digits)

* [add] class structure.MpNum10
* [add] class structure.MpNum10.RW

* [add] class structure.DoubleUtils
   - public static double Round(double value,int digits)

v2.2.0.1687
* Added support for FW4.7.2
* Added support for new IBProvider property "schema_ldr_cfg__descriptions"
* Improvements in structure.TraceMsgBuilderUtils

v2.1.2.1669
* Fixed small problems, which detected by PVS-Studio:
  - Mistakes in code with verifications:
     - tagDBTIMESTAMPOFFSET::Create
     - tagDBTIMESTAMP::Create
     - tagDBDATE::Create

v2.1.1.1665
* Updating of version after code revision
  - No changes in code, only formatting of sources

v2.1.0.1660
* tagDBDATE::ToDateTime_NoThrow
* tagDBTIMESTAMP::ToDateTime_NoThrow
* tagDBTIMESTAMPOFFSET::ToDateTimeOffset_NoThrow
  - Usage DB_E_DATAOVERFLOW instead DISP_E_OVERFLOW

v2.0.0.1654
* Redesign of public interface

v1.1.0.1348
* Reorganization
  - structure.t_str_formatter renamed to structure.StringFormatter
    + more exact implementation
  - structure.t_str_version renamed to structure.Version
  - structure.intptr_utils renamed to structure.IntPtrUtils
  - structure.uintptr_utils renamed to structure.UIntPtrUtils

v1.0.0.1282
* First public release
