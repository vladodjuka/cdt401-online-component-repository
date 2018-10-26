

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 7.00.0555 */
/* at Fri Oct 26 22:01:37 2018
 */
/* Compiler settings for COM_inspect.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 7.00.0555 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __COM_inspect_i_h__
#define __COM_inspect_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __Iinspect_FWD_DEFINED__
#define __Iinspect_FWD_DEFINED__
typedef interface Iinspect Iinspect;
#endif 	/* __Iinspect_FWD_DEFINED__ */


#ifndef __inspect_FWD_DEFINED__
#define __inspect_FWD_DEFINED__

#ifdef __cplusplus
typedef class inspect inspect;
#else
typedef struct inspect inspect;
#endif /* __cplusplus */

#endif 	/* __inspect_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"
#include "shobjidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __Iinspect_INTERFACE_DEFINED__
#define __Iinspect_INTERFACE_DEFINED__

/* interface Iinspect */
/* [unique][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_Iinspect;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("7381555C-1CA9-464A-A196-3AEF76526AB4")
    Iinspect : public IDispatch
    {
    public:
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE inspect_component( 
            /* [in] */ BSTR path,
            /* [out][in] */ BSTR *interfaces,
            /* [out][in] */ BSTR *classes) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE count( 
            /* [in] */ BSTR path,
            /* [out][in] */ LONG *nb_interfaces,
            /* [out][in] */ LONG *nb_classes) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IinspectVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            Iinspect * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            Iinspect * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            Iinspect * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            Iinspect * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            Iinspect * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            Iinspect * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            Iinspect * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *inspect_component )( 
            Iinspect * This,
            /* [in] */ BSTR path,
            /* [out][in] */ BSTR *interfaces,
            /* [out][in] */ BSTR *classes);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *count )( 
            Iinspect * This,
            /* [in] */ BSTR path,
            /* [out][in] */ LONG *nb_interfaces,
            /* [out][in] */ LONG *nb_classes);
        
        END_INTERFACE
    } IinspectVtbl;

    interface Iinspect
    {
        CONST_VTBL struct IinspectVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define Iinspect_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define Iinspect_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define Iinspect_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define Iinspect_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define Iinspect_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define Iinspect_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define Iinspect_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define Iinspect_inspect_component(This,path,interfaces,classes)	\
    ( (This)->lpVtbl -> inspect_component(This,path,interfaces,classes) ) 

#define Iinspect_count(This,path,nb_interfaces,nb_classes)	\
    ( (This)->lpVtbl -> count(This,path,nb_interfaces,nb_classes) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __Iinspect_INTERFACE_DEFINED__ */



#ifndef __COM_inspectLib_LIBRARY_DEFINED__
#define __COM_inspectLib_LIBRARY_DEFINED__

/* library COM_inspectLib */
/* [version][uuid] */ 


EXTERN_C const IID LIBID_COM_inspectLib;

EXTERN_C const CLSID CLSID_inspect;

#ifdef __cplusplus

class DECLSPEC_UUID("F227C3B7-B3F6-4B09-8D14-4C87D296F5FC")
inspect;
#endif
#endif /* __COM_inspectLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  BSTR_UserSize(     unsigned long *, unsigned long            , BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserMarshal(  unsigned long *, unsigned char *, BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserUnmarshal(unsigned long *, unsigned char *, BSTR * ); 
void                      __RPC_USER  BSTR_UserFree(     unsigned long *, BSTR * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


