

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 8.00.0603 */
/* at Wed Apr 28 16:40:16 2021
 */
/* Compiler settings for IviUpconverterTypeLib.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 8.00.0603 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, LIBID_IviUpconverterLib,0x47ed512d,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverter,0x47ed53dc,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterReferenceOscillator,0x47ed53ed,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterIFInput,0x47ed53e5,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterRFOutput,0x47ed53ee,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterExternalLO,0x47ed53e1,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterALC,0x47ed53dd,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterIQ,0x47ed53e6,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterIQImpairment,0x47ed53e7,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterAnalogModulation,0x47ed53df,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterAM,0x47ed53de,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterFM,0x47ed53e2,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterPM,0x47ed53e9,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterAnalogModulationSource,0x47ed53e0,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterPulseModulation,0x47ed53ec,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterSweep,0x47ed53ef,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterFrequencySweep,0x47ed53e4,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterPowerSweep,0x47ed53eb,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterFrequencyStep,0x47ed53e3,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterPowerStep,0x47ed53ea,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterList,0x47ed53e8,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterGainStep,0x47ed53f0,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);


MIDL_DEFINE_GUID(IID, IID_IIviUpconverterGainSweep,0x47ed53f1,0xa398,0x11d4,0xba,0x58,0x00,0x00,0x64,0x65,0x73,0x74);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



